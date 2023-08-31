package service

import (
	"testing"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"
	"github.com/stretchr/testify/assert"
	"github.com/stretchr/testify/mock"
)

type MockRepository struct {
	mock.Mock
}

func (mock *MockRepository) Save(post *entity.Post) (*entity.Post, error) {
	args := mock.Called()
	result := args.Get(0)
	return result.(*entity.Post), args.Error(1)
}

func (mock *MockRepository) FindAll() ([]entity.Post, error) {
	args := mock.Called()
	result := args.Get(0)
	return result.([]entity.Post), args.Error(1)
}

func TestFindAll(t *testing.T) {
	mockRepo := new(MockRepository)

	var identifier int64 = 1

	post := entity.Post{ID: identifier, Title: "A", Text: "B"}
	// setup expectations
	mockRepo.On("FindAll").Return([]entity.Post{post}, nil)

	testService := NewPostService(mockRepo)

	result, _ := testService.FindAll()

	// Mock Assertions: Behavioral
	mockRepo.AssertExpectations(t)

	// Data Assertions
	assert.Equal(t, identifier, result[0].ID)
	assert.Equal(t, "A", result[0].Title)
	assert.Equal(t, "B", result[0].Text)
}

func TestValidateEmptyPost(t *testing.T) {
	testService := NewPostService(nil)

	err := testService.Validate(nil)

	assert.NotNil(t, err)

	assert.Equal(t, "The post is empty!", err.Error())
}

func TestValidateEmptyPostTitle(t *testing.T) {
	post := entity.Post{ID: 1, Title: "", Text: "8"}

	testService := NewPostService(nil)

	err := testService.Validate(&post)

	assert.NotNil(t, err)

	assert.Equal(t, "The post title is empty!", err.Error())

}
