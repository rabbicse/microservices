package entity

type Owner struct {
	OwnerData `json:"User"`
}

type OwnerData struct {
	FirstName string `json:"first_name"`
	LastName  string `json:"last_name"`
	Email     string `json:"email"`
}
