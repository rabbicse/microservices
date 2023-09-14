package service

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

var (
	carDetailsService = NewCarDetailsService()
)

func TestGetDetails(t *testing.T) {

	carDetails := carDetailsService.GetDetails()

	assert.NotNil(t, carDetails)
}
