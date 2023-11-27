package cache

import "github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"

type PostCache interface {
	Set(key string, value *entity.Post)
	Get(key string) *entity.Post
}
