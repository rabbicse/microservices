package main

import (
	"crypto/rand"
	"database/sql"
	"fmt"
	"os"
	"strings"
	"time"

	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/fiber/v2/middleware/logger"
	"github.com/gofiber/fiber/v2/middleware/recover"
	"github.com/gofiber/template/html/v2"
	"github.com/golang-jwt/jwt/v4"
	"github.com/google/uuid"
	"github.com/joho/godotenv"
	"github.com/lucsky/cuid"
	"golang.org/x/crypto/bcrypt"
	"gorm.io/driver/postgres"
	"gorm.io/gorm"
	"gorm.io/gorm/clause"
)

type Client struct {
	Id           int    `gorm:"primaryKey"`
	Name         string `gorm:"uniqueIndex"`
	ClientSecret string `json:"client_secret"`
	Website      string
	Logo         string
	Code         sql.NullString `gorm:"default null"`
	RedirectURI  string         `json:"redirect_uri"`
	CreatedAt    time.Time      `json:"created_at"`
	UpdatedAt    time.Time      `json:"updated_at"`
	DeletedAt    time.Time      `json:"-" gorm:"index"`
}

type NewUserRequest struct {
	Email    string
	Password string
}

type NewUserResponse struct {
	ID    uuid.UUID
	Email string
}

type User struct {
	Id        uuid.UUID `gorm:"primaryKey"`
	Email     string    `gorm:"uniqueIndex"`
	Password  string    `json:"-"`
	CreatedAt time.Time `json:"created_at"`
	UpdatedAt time.Time `json:"updated_at"`
	DeletedAt time.Time `json:"-" gorm:"index"`
}

func NewUser(req *NewUserRequest) *User {
	hashedPassword, err := hashPassword(req.Password)
	if err != nil {
		panic("failed to hash password")
	}

	return &User{
		Id:       uuid.New(),
		Email:    req.Email,
		Password: hashedPassword,
	}
}

type AuthRequest struct {
	ResponseType string `json:"response_type" query:"response_type"`
	ClientID     string `json:"client_id" query:"client_id"`
	RedirectURI  string `json:"redirect_uri" query:"redirect_uri"`
	Scope        string
	State        string
}

type ConfirmAuthRequest struct {
	Authorize bool   `json:"authorize" query:"authorize"`
	ClientID  string `json:"client_id" query:"client_id"`
	State     string
}

type TokenRequest struct {
	GrantType    string `json:"grant_type"`
	Code         string
	RedirectURI  string `json:"redirect_uri"`
	ClientID     string `json:"client_id"`
	ClientSecret string `json:"client_secret"`
}

type TokenResponse struct {
	AccessToken string `json:"access_token"`
	ExpiresIn   int    `json:"expires_in"`
}

func hashPassword(password string) (string, error) {
	bytes, err := bcrypt.GenerateFromPassword([]byte(password), 14)
	return string(bytes), err
}

func main() {
	err := godotenv.Load()
	if err != nil {
		panic("unable to load env file")
	}

	dbUrl := os.Getenv("DATABASE_URL")
	if dbUrl == "" {
		panic("DATABASE_URL is not set!")
	}

	db, err := gorm.Open(postgres.Open(dbUrl), &gorm.Config{})
	if err != nil {
		panic("failed to connect database")
	}

	// Migrate the schema
	db.AutoMigrate(&Client{}, &User{})

	// Client secret
	clientSecret, err := cuid.NewCrypto(rand.Reader)
	if err != nil {
		panic("failed to create new crypto")
	}

	// Create
	db.Clauses(clause.OnConflict{
		Columns:   []clause.Column{{Name: "id"}},
		DoUpdates: clause.AssignmentColumns([]string{"name", "website", "redirected_uri", "logo", "client_secret"}),
	})
	db.Create(&Client{
		Id:           1,
		Name:         "Mehmet",
		ClientSecret: clientSecret,
		Website:      "http://test.com",
		RedirectURI:  "http://localhost:8080/auth/callback",
		Logo:         "https://placehold.co/600x400",
	})

	views := html.New("./views", ".html")

	api := fiber.New(fiber.Config{
		AppName: "authorization service",
		Views:   views,
	})
	api.Use(logger.New())
	api.Use(recover.New())

	api.Get("/", func(c *fiber.Ctx) error {
		return c.SendString("Hello")
	})

	api.Post("/user", func(ctx *fiber.Ctx) error {
		userReq := new(NewUserRequest)
		if err := ctx.BodyParser(userReq); err != nil {
			return ctx.Status(400).JSON(fiber.Map{"error": fmt.Sprintf("invalid request: %v", err)})
		}

		if userReq.Email == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if userReq.Password == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		user := NewUser(userReq)
		if err := db.Create(&user).Error; err != nil {
			return ctx.Status(500).JSON(fiber.Map{"status": "error", "message": "Couldn't create user", "data": err})
		}

		return ctx.JSON(fiber.Map{"status": "success", "message": "Created user", "data": user})
	})

	api.Get("/auth", func(c *fiber.Ctx) error {
		authRequest := new(AuthRequest)
		if err := c.QueryParser(authRequest); err != nil {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if authRequest.Scope == "" {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if authRequest.State == "" {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if authRequest.ResponseType != "code" {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if authRequest.ClientID == "" {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if !strings.Contains(authRequest.RedirectURI, "https") {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		// check for client
		client := new(Client)
		if err := db.Where("name = ?", authRequest.ClientID).First(&client).Error; err != nil {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		// generate temp code
		code, err := cuid.NewCrypto(rand.Reader)
		if err != nil {
			return c.Status(500).JSON(fiber.Map{
				"error": "Internal server error!",
			})
		}

		c.Cookie(&fiber.Cookie{
			Name:     "auth_request_code",
			Value:    code,
			Secure:   true,
			Expires:  time.Now().Add(1 * time.Minute),
			HTTPOnly: true,
		})

		return c.Render("authorize_client", fiber.Map{
			"Logo":    client.Logo,
			"Name":    client.Name,
			"Website": client.Website,
			"State":   authRequest.State,
			"Scopes":  strings.Split(authRequest.Scope, " "),
		})
	})

	api.Get("/confirm_auth", func(ctx *fiber.Ctx) error {
		tempCode := ctx.Cookies("auth_request_code")

		if tempCode == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request auth_request_code",
			})
		}

		confirmAuthRequest := new(ConfirmAuthRequest)
		if err := ctx.QueryParser(confirmAuthRequest); err != nil {
			return ctx.Status(400).JSON(fiber.Map{"error": fmt.Sprintf("invalid request: %v", err)})
		}

		// check for client
		client := new(Client)
		if err := db.Where("name = ?", confirmAuthRequest.ClientID).First(&client).Error; err != nil {
			return ctx.Status(400).JSON(fiber.Map{"error": fmt.Sprintf("invalid request: %v", err)})
		}

		if !confirmAuthRequest.Authorize {
			return ctx.Redirect(client.RedirectURI + "?error=access_denied" + "&state=" + confirmAuthRequest.State)
		}

		// save generated auth code to client table
		db.Model(&client).Update("code", tempCode)

		return ctx.Redirect(client.RedirectURI + "?code=" + tempCode + "&state=" + confirmAuthRequest.State)
	})

	api.Post("/token", func(ctx *fiber.Ctx) error {
		tokenRequest := new(TokenRequest)
		if err := ctx.BodyParser(tokenRequest); err != nil {
			return ctx.Status(400).JSON(fiber.Map{"error": fmt.Sprintf("invalid request: %v", err)})
		}

		if tokenRequest.ClientID == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if tokenRequest.Code == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if tokenRequest.RedirectURI == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if tokenRequest.GrantType == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if tokenRequest.ClientSecret == "" {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		// check for client
		client := new(Client)
		if err := db.Where("name = ?", tokenRequest.ClientID).First(&client).Error; err != nil {
			return ctx.Status(404).JSON(fiber.Map{"error": fmt.Sprintf("invalid request: %v", err)})
		}

		// validate client and code
		if !client.Code.Valid {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if tokenRequest.Code != client.Code.String {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		token := jwt.New(jwt.SigningMethodHS256)

		claims := token.Claims.(jwt.MapClaims)
		// claims["username"] = userData.Username
		// claims["user_id"] = userData.ID
		claims["exp"] = time.Now().Add(time.Hour * 72).Unix()

		accessToken, err := token.SignedString([]byte(client.ClientSecret))
		if err != nil {
			return ctx.SendStatus(fiber.StatusInternalServerError)
		}

		tokenResponse := new(TokenResponse)
		tokenResponse.AccessToken = accessToken
		tokenResponse.ExpiresIn = 3600

		// Generate the access token
		return ctx.Status(200).JSON(tokenResponse)
	})

	port := os.Getenv("PORT")
	if port == "" {
		port = "3000"
	}

	api.Listen(fmt.Sprintf(":%s", port))
}
