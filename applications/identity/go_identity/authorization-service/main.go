package main

import (
	"crypto/rand"
	"fmt"
	"os"
	"strings"
	"time"

	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/fiber/v2/middleware/logger"
	"github.com/gofiber/fiber/v2/middleware/recover"
	"github.com/gofiber/template/html/v2"
	"github.com/joho/godotenv"
	"github.com/lucsky/cuid"
	"gorm.io/driver/postgres"
	"gorm.io/gorm"
	"gorm.io/gorm/clause"
)

type Client struct {
	Id          int    `gorm:"primaryKey"`
	Name        string `gorm:"uniqueIndex"`
	Website     string
	Logo        string
	RedirectURI string    `json:"redirect_uri"`
	CreatedAt   time.Time `json:"created_at"`
	UpdatedAt   time.Time `json:"updated_at"`
	DeletedAt   time.Time `json:"-" gorm:"index"`
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
	db.AutoMigrate(&Client{})

	// Create
	db.Clauses(clause.OnConflict{
		Columns:   []clause.Column{{Name: "id"}},
		DoUpdates: clause.AssignmentColumns([]string{"name", "website", "redirected_uri", "logo"}),
	})
	db.Create(&Client{
		Id:          1,
		Name:        "Mehmet",
		Website:     "http://test.com",
		RedirectURI: "http://localhost:8080/auth/callback",
		Logo:        "https://placehold.co/600x400",
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
				"error": "Invalid request",
			})
		}

		confirmAuthRequest := new(ConfirmAuthRequest)
		if err := ctx.QueryParser(confirmAuthRequest); err != nil {
			return ctx.Status(400).JSON(fiber.Map{"error": "invalid request"})
		}

		// check for client
		client := new(Client)
		if err := db.Where("name = ?", confirmAuthRequest.ClientID).First(&client).Error; err != nil {
			return ctx.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}

		if !confirmAuthRequest.Authorize {
			return ctx.Redirect(client.RedirectURI + "?error=access_denied" + "&state=" + confirmAuthRequest.State)
		}

		return ctx.Redirect(client.RedirectURI + "?code=" + tempCode + "&state=" + confirmAuthRequest.State)
	})

	port := os.Getenv("PORT")
	if port == "" {
		port = "3000"
	}

	api.Listen(fmt.Sprintf(":%s", port))
}
