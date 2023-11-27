package controller

import (
	"bytes"
	"encoding/json"
	"io"
	"net/http"
	"net/http/httptest"
	"testing"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/cache"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/repository"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/service"
	"github.com/stretchr/testify/assert"
)

var (
	postRepo       repository.PostRepository = repository.NewSQLiteRepository()
	postSrv        service.PostService       = service.NewPostService(postRepo)
	postCacheSrv   cache.PostCache           = cache.NewRedisCache("localhost:6379", 0, 10)
	postController PostController            = NewPostController(postSrv, postCacheSrv)
)

func TestAddPost(t *testing.T) {
	// create a new HTTP POST request
	var jsonReq = []byte(`{"title": "Test Title 008","text": "Text 008"}`)
	req, _ := http.NewRequest("POST", "posts", bytes.NewBuffer(jsonReq))

	// assign HTTP handler function: controller AddPost function
	handler := http.HandlerFunc(postController.AddPost)

	// record HTTP response
	response := httptest.NewRecorder()

	// dispatch the HTTP request
	handler.ServeHTTP(response, req)

	// add assertion on the HTTP request
	status := response.Code

	if status != http.StatusOK {
		t.Errorf("Handler returned a wrong status code: got %v want %v", status, http.StatusOK)
	}

	// decode the HTTP response
	var post entity.Post
	json.NewDecoder(io.Reader(response.Body)).Decode(&post)

	// assert HTTP response
	assert.NotNil(t, post.ID)
}

func TestGetPosts(t *testing.T) {

}
