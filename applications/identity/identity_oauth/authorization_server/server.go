package main

import (
	"authorization_server/internal/models"
	"authorization_server/internal/services"
	"encoding/base64"
	"strings"
	"time"

	_ "authorization_server/docs"

	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/swagger"
	"github.com/google/uuid"
)

// @title Fiber Example API
// @version 1.0
// @description This is a sample swagger for Fiber
// @termsOfService http://swagger.io/terms/
// @contact.name API Support
// @contact.email fiber@swagger.io
// @license.name Apache 2.0
// @license.url http://www.apache.org/licenses/LICENSE-2.0.html
// @host localhost:8000
// @BasePath /

var authService *services.AuthService
var tokenService *services.TokenService

func main() {
	authService = services.NewAuthService()
	tokenService = services.NewTokenService()

	app := fiber.New()

	app.Get("/swagger/*", swagger.HandlerDefault)

	app.Get("/authorize", AuthorizeHandler)
	app.Post("/token", TokenHandler)
	app.Get("/protected", protectedHandler)

	app.Listen(":8000")
}

// @Summary Authorization Endpoint
// @Description Generates an authorization code after validating client_id and response_type
// @Tags Authorization
// @Accept  json
// @Produce  json
// @Param client_id query string true "Client ID"
// @Param response_type query string true "Response Type (must be 'code')"
// @Param redirect_uri query string true "Redirect URI"
// @Success 302 {string} string "Redirects with authorization code"
// @Failure 400 {object} map[string]string
// @Router /authorize [get]
func AuthorizeHandler(c *fiber.Ctx) error {
	clientID := c.Query("client_id")
	responseType := c.Query("response_type")
	redirectURI := c.Query("redirect_uri")

	if clientID == "" || responseType == "" || redirectURI == "" {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "invalid_request",
			"error_description": "client_id, response_type, and redirect_uri are required",
		})
	}

	if responseType != "code" {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "unsupported_response_type",
			"error_description": "response_type must be 'code'",
		})
	}

	if !authService.ValidateClientID(clientID) {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "invalid_client",
			"error_description": "Unknown client",
		})
	}

	code := uuid.New().String()
	authService.StoreAuthorizationCode(models.AuthCode{
		Code:        code,
		ClientID:    clientID,
		RedirectURI: redirectURI,
		ExpiresAt:   time.Now().Add(10 * time.Minute),
	})

	return c.Redirect(redirectURI+"?code="+code, fiber.StatusFound)
}

// @Summary Token Endpoint
// @Description Exchanges an authorization code for an access token
// @Tags Token
// @Accept application/x-www-form-urlencoded
// @Produce json
// @Param grant_type formData string true "Grant type (must be 'authorization_code')"
// @Param code formData string true "Authorization code"
// @Param redirect_uri formData string false "Redirect URI"
// @Param client_id formData string false "Client ID"
// @Param client_secret formData string false "Client Secret"
// @Success 200 {object} map[string]interface{}
// @Failure 400 {object} map[string]string
// @Failure 401 {object} map[string]string
// @Router /token [post]
func TokenHandler(c *fiber.Ctx) error {
	grantType := c.FormValue("grant_type")
	code := c.FormValue("code")
	redirectURI := c.FormValue("redirect_uri")

	if grantType != "authorization_code" {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "unsupported_grant_type",
			"error_description": "grant_type must be 'authorization_code'",
		})
	}

	clientID, clientSecret := getClientCredentials(c)

	if !authService.ValidateClientCredentials(clientID, clientSecret) {
		return c.Status(fiber.StatusUnauthorized).JSON(fiber.Map{
			"error":             "invalid_client",
			"error_description": "Invalid client credentials",
		})
	}

	authCode, valid := authService.ValidateAuthorizationCode(code)
	if !valid {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "invalid_grant",
			"error_description": "Invalid or expired authorization code",
		})
	}

	if redirectURI != "" && redirectURI != authCode.RedirectURI {
		return c.Status(fiber.StatusBadRequest).JSON(fiber.Map{
			"error":             "invalid_grant",
			"error_description": "redirect_uri does not match",
		})
	}

	accessToken := uuid.New().String()
	tokenService.StoreAccessToken(models.AccessToken{
		Token:     accessToken,
		ClientID:  clientID,
		ExpiresAt: time.Now().Add(1 * time.Hour),
	})

	authService.DeleteAuthorizationCode(code)

	return c.JSON(fiber.Map{
		"access_token": accessToken,
		"token_type":   "Bearer",
		"expires_in":   3600,
	})
}

// @Summary Protected Resource
// @Description Access a protected resource with a valid access token
// @Tags Protected
// @Accept  json
// @Produce  json
// @Security BearerAuth
// @Success 200 {object} map[string]interface{}
// @Failure 401 {object} map[string]string
// @Router /protected [get]
func protectedHandler(c *fiber.Ctx) error {
	authHeader := c.Get("Authorization")
	if authHeader == "" {
		return c.Status(fiber.StatusUnauthorized).JSON(fiber.Map{
			"error":             "invalid_request",
			"error_description": "Authorization header required",
		})
	}

	parts := strings.Split(authHeader, " ")
	if len(parts) != 2 || parts[0] != "Bearer" {
		return c.Status(fiber.StatusUnauthorized).JSON(fiber.Map{
			"error":             "invalid_request",
			"error_description": "Invalid Authorization header format",
		})
	}

	token := parts[1]
	accessToken, valid := tokenService.ValidateAccessToken(token)
	if !valid {
		return c.Status(fiber.StatusUnauthorized).JSON(fiber.Map{
			"error":             "invalid_token",
			"error_description": "Invalid or expired access token",
		})
	}

	return c.JSON(fiber.Map{
		"message": "Protected resource accessed successfully",
		"client":  accessToken.ClientID,
	})
}

// Helper function to extract client credentials
func getClientCredentials(c *fiber.Ctx) (string, string) {
	authHeader := c.Get("Authorization")
	if strings.HasPrefix(authHeader, "Basic ") {
		decoded, err := base64.StdEncoding.DecodeString(authHeader[6:])
		if err == nil {
			parts := strings.SplitN(string(decoded), ":", 2)
			if len(parts) == 2 {
				return parts[0], parts[1]
			}
		}
	}
	return c.FormValue("client_id"), c.FormValue("client_secret")
}
