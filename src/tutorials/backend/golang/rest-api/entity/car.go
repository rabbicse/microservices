package entity

type Car struct {
	CarData `json:"car"`
}

type CarData struct {
	ID    int    `json:"id"`
	Brand string `json:"car"`
	Model string `json:"car_model"`
	Year  string `json:"car_model_year"`
}
