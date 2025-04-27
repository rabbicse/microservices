package services

import (
	"authorization_server/internal/models"
	"sync"
	"time"
)

type AuthService struct {
	authCodes map[string]models.AuthCode
	clients   map[string]models.Client
	mu        sync.RWMutex
}

func NewAuthService() *AuthService {
	// Initialize with some sample clients
	clients := map[string]models.Client{
		"client1": {ID: "client1", Secret: "secret1"},
		"client2": {ID: "client2", Secret: "secret2"},
	}

	return &AuthService{
		authCodes: make(map[string]models.AuthCode),
		clients:   clients,
	}
}

func (s *AuthService) ValidateClientID(clientID string) bool {
	s.mu.RLock()
	defer s.mu.RUnlock()
	_, exists := s.clients[clientID]
	return exists
}

func (s *AuthService) ValidateClientCredentials(clientID, clientSecret string) bool {
	s.mu.RLock()
	defer s.mu.RUnlock()
	client, exists := s.clients[clientID]
	return exists && client.Secret == clientSecret
}

func (s *AuthService) StoreAuthorizationCode(code models.AuthCode) {
	s.mu.Lock()
	defer s.mu.Unlock()
	s.authCodes[code.Code] = code
}

func (s *AuthService) ValidateAuthorizationCode(code string) (models.AuthCode, bool) {
	s.mu.RLock()
	defer s.mu.RUnlock()
	authCode, exists := s.authCodes[code]
	if !exists || time.Now().After(authCode.ExpiresAt) {
		return models.AuthCode{}, false
	}
	return authCode, true
}

func (s *AuthService) DeleteAuthorizationCode(code string) {
	s.mu.Lock()
	defer s.mu.Unlock()
	delete(s.authCodes, code)
}

type TokenService struct {
	accessTokens map[string]models.AccessToken
	mu           sync.RWMutex
}

func NewTokenService() *TokenService {
	return &TokenService{
		accessTokens: make(map[string]models.AccessToken),
	}
}

func (s *TokenService) StoreAccessToken(token models.AccessToken) {
	s.mu.Lock()
	defer s.mu.Unlock()
	s.accessTokens[token.Token] = token
}

func (s *TokenService) ValidateAccessToken(token string) (models.AccessToken, bool) {
	s.mu.RLock()
	defer s.mu.RUnlock()
	accessToken, exists := s.accessTokens[token]
	if !exists || time.Now().After(accessToken.ExpiresAt) {
		return models.AccessToken{}, false
	}
	return accessToken, true
}
