package handlers

import (
	"authorization_server/internal/api/rest"
	"authorization_server/internal/helper"
	"fmt"
	"slices"

	"github.com/gofiber/fiber/v2"
)

type AuthHandler struct {
}

var apps = map[helper.ClientId]helper.App{
	"printshop": {
		"printshop",
		"alpine",
		"http://localhost:8090/callback",
		[]string{"all"},
	},
}

var AccessCombinations = make(map[helper.ClientId]helper.AccessCombination)

func SetupRoutes(rh *rest.RestHandler) {
	app := rh.App

	handler := AuthHandler{}

	app.Get("/authorize", handler.Authorize)
	// http.HandleFunc("/login", login)
	// http.HandleFunc("/consent", auth.RequestApproval)
	// http.HandleFunc("/token", auth.GetAccessToken)
	// http.HandleFunc("/access", resource.GrantAccess)
}

func (auth *AuthHandler) Authorize(ctx *fiber.Ctx) error {
	// Validate the Request
	if params := ctx.Queries(); validAuthRequestFiber(params) {

		// Create Access Combo
		clientId := params["client_id"]
		state := params["state"]

		combo := helper.NewAccessCombination(state)
		AccessCombinations[helper.ClientId(clientId)] = *combo

		// Request user permission
		return requestUserPermissionFiber(ctx)
	}

	return ctx.Status(fiber.StatusUnauthorized).SendString("Unauthorized")
}

func validAuthRequestFiber(params map[string]string) bool {
	responseType := params["response_type"]
	clientId := helper.ClientId(params["client_id"])
	redirectUri := params["redirect_uri"]
	scope := params["scope"]

	if app, prs := apps[clientId]; prs &&
		app.RedirectUri == redirectUri &&
		responseType == "code" &&
		slices.Contains(app.Scope, scope) {
		return true
	}

	return false
}

func requestUserPermissionFiber(c *fiber.Ctx) error {
	params := c.Queries()
	clientId := params["client_id"]
	redirectUri := params["redirect_uri"]
	scope := params["scope"]
	state := params["state"]

	url := fmt.Sprintf(
		"%s/login?client_id=%s&redirect_uri=%s&scope=%s&state=%s",
		helper.ServerUrl, clientId, redirectUri, scope, state,
	)

	return c.Redirect(url, fiber.StatusTemporaryRedirect)
}
