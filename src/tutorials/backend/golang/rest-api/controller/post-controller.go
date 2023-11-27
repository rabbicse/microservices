package controller

import (
	"encoding/json"
	"net/http"
	"strings"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/cache"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/errors"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/service"
)

type controller struct{}

var (
	postService service.PostService //= service.NewPostService()
	postCache   cache.PostCache
)

type PostController interface {
	GetPosts(resp http.ResponseWriter, req *http.Request)
	AddPost(resp http.ResponseWriter, req *http.Request)
	GetPostByID(resp http.ResponseWriter, req *http.Request)
}

func NewPostController(service service.PostService, cache cache.PostCache) PostController {
	postService = service
	postCache = cache
	return &controller{}
}

func (*controller) GetPosts(resp http.ResponseWriter, req *http.Request) {
	resp.Header().Set("Content-type", "application/json")
	posts, err := postService.FindAll()
	if err != nil {
		resp.WriteHeader(http.StatusInternalServerError)
		json.NewEncoder(resp).Encode(errors.ServiceError{Message: "Error getting the posts"})
	}
	resp.WriteHeader(http.StatusOK)
	json.NewEncoder(resp).Encode(posts)
}

func (*controller) GetPostByID(resp http.ResponseWriter, req *http.Request) {
	resp.Header().Set("Content-type", "application/json")
	postID := strings.Split(req.URL.Path, "/")[2]
	var post *entity.Post = postCache.Get(postID)
	if post == nil {
		post, err := postService.FindByID(postID)
		if err != nil {
			resp.WriteHeader(http.StatusNotFound)
			json.NewEncoder(resp).Encode(errors.ServiceError{Message: "No posts found"})
			return
		}

		postCache.Set(postID, post)
	}

	resp.WriteHeader(http.StatusOK)
	json.NewEncoder(resp).Encode(post)

}

func (*controller) AddPost(resp http.ResponseWriter, req *http.Request) {
	resp.Header().Set("Content-type", "application/json")
	var post entity.Post
	err := json.NewDecoder(req.Body).Decode(&post)
	if err != nil {
		resp.WriteHeader(http.StatusInternalServerError)
		json.NewEncoder(resp).Encode(errors.ServiceError{Message: "Error unmarshal the request"})
		return
	}

	errValidate := postService.Validate(&post)
	if errValidate != nil {
		resp.WriteHeader(http.StatusInternalServerError)
		json.NewEncoder(resp).Encode(errors.ServiceError{Message: errValidate.Error()})
		return
	}

	po, errPost := postService.Create(&post)
	if errPost != nil {
		resp.WriteHeader(http.StatusInternalServerError)
		json.NewEncoder(resp).Encode(errors.ServiceError{Message: "Error saving the post!"})
		return
	}
	resp.WriteHeader(http.StatusOK)
	json.NewEncoder(resp).Encode(po)
}
