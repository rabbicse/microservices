package models

import "time"

type AuthCode struct {
	Code        string
	ClientID    string
	RedirectURI string
	ExpiresAt   time.Time
}

type AccessToken struct {
	Token     string
	ClientID  string
	ExpiresAt time.Time
}

type Client struct {
	ID     string
	Secret string
}
