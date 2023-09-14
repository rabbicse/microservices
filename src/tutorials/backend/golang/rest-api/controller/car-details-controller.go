package controller

import (
	"encoding/json"
	"net/http"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/service"
)

type carDetailsController struct{}

var (
	carDetailsService service.CarDetailsService
)

type CarDetailsController interface {
	GetCarDetails(response http.ResponseWriter, request *http.Request)
}

func NewCarDetailsController(service service.CarDetailsService) CarDetailsController {
	carDetailsService = service
	return &carDetailsController{}
}

func (*carDetailsController) GetCarDetails(response http.ResponseWriter, request *http.Request) {
	response.Header().Set("Content-type", "application/json")
	result := carDetailsService.GetDetails()
	response.WriteHeader(http.StatusOK)
	json.NewEncoder(response).Encode(result)
}
