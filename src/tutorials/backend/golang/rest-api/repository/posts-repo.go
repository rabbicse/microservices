package repository

import (
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"
)

type PostRepository interface {
	Save(post *entity.Post) (*entity.Post, error)
	FindAll() ([]entity.Post, error)
	FindByID(postID string) (*entity.Post, error)
}
