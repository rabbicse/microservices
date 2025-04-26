package main

import (
	"github.com/gofiber/fiber/v2"
	"github.com/gofiber/fiber/v2/middleware/logger"
	"github.com/gofiber/fiber/v2/middleware/recover"
)

type CodeResponse struct {
	Code  string `query:"code"`
	State string `query:"state"`
}

func main() {
	api := fiber.New(fiber.Config{
		AppName: "authorization service",
	})
	api.Use(logger.New())
	api.Use(recover.New())

	api.Get("/auth/callback", func(c *fiber.Ctx) error {
		codeResponse := new(CodeResponse)
		if err := c.QueryParser(codeResponse); err != nil {
			return c.Status(400).JSON(fiber.Map{
				"error": "Invalid request",
			})
		}
		return c.SendStatus(200)
	})

	api.Listen(":8080")
}
