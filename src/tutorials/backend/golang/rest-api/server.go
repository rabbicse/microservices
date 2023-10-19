package main

import (
	"fmt"
	"net/http"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/controller"
	router "github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/http"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/repository"
	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/service"
)

var (
	postRepository       repository.PostRepository       = repository.NewSQLiteRepository()
	postService          service.PostService             = service.NewPostService(postRepository)
	postController       controller.PostController       = controller.NewPostController(postService)
	carDetailsService    service.CarDetailsService       = service.NewCarDetailsService()
	carDetailsController controller.CarDetailsController = controller.NewCarDetailsController(carDetailsService)
	httpRouter           router.Router                   = router.NewMuxRouter()
)

func main() {
	const port string = ":8000"
	httpRouter.GET("/", func(w http.ResponseWriter, r *http.Request) {
		fmt.Fprintln(w, "Up and running")
	})
	httpRouter.GET("/posts", postController.GetPosts)
	httpRouter.POST("/posts", postController.AddPost)

	httpRouter.GET("/carDetails", carDetailsController.GetCarDetails)

	httpRouter.SERVE(port)
}
