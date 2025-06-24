package api

import (
	"authorization_server/internal/api/rest"

	"github.com/gofiber/fiber/v2"
)

func StartServer() {
	app := fiber.New()

	app.Get("/", func(c *fiber.Ctx) error {
		return c.SendString("Hello, World!")
	})

	app.Listen(":3000")
}

func setupRoutes(rh *rest.RestHandler) {
	handlers.SetupUserRoutes(rh)
}
