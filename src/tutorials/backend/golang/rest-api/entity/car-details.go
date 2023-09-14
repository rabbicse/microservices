package entity

type CarDetails struct {
	ID        int    `json:"id"`
	Brand     string `json:"brand"`
	Model     string `json:"model"`
	Year      string `json:"model_year"`
	FirstName string `json:"owner_first_name"`
	LastName  string `json:"owner_last_name"`
	Email     string `json:"owner_email"`
}
