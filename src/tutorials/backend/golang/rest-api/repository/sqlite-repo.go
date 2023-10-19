package repository

import (
	"database/sql"
	"fmt"
	"log"
	"os"

	_ "github.com/mattn/go-sqlite3"

	"github.com/rabbicse/microservices/tree/master/src/tutorials/backend/golang/rest-api/entity"
)

type sqliteRepo struct{}

func NewSQLiteRepository() PostRepository {
	os.Remove("./posts.db")

	db, err := sql.Open("sqlite3", "./posts.db")
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()

	sqlStmt := `
	create table posts (id integer not null primary key, title text, txt text);
	delete from posts;
	`

	_, err = db.Exec(sqlStmt)
	if err != nil {
		log.Printf("%q: %s\n", err, sqlStmt)
	}

	return &sqliteRepo{}
}

func (*sqliteRepo) Save(post *entity.Post) (*entity.Post, error) {
	db, err := sql.Open("sqlite3", "./posts.db")
	if err != nil {
		log.Fatalf("Failed to create a Firestore Client: %v", err)
		return nil, err
	}

	tx, err := db.Begin()
	if err != nil {
		log.Fatal(err)
		return nil, err
	}
	stmt, err := tx.Prepare(`insert into posts(id, title, txt) values (?, ?, ?)`)
	if err != nil {
		log.Fatal(err)
		return nil, err
	}
	defer stmt.Close()

	_, err = stmt.Exec(post.ID, post.Title, post.Text)
	if err != nil {
		log.Fatalf("Failed to adding a new post: %v", err)
		return nil, err
	}

	fmt.Println(post)

	return post, nil
}

func (*sqliteRepo) FindAll() ([]entity.Post, error) {
	db, err := sql.Open("sqlite3", "./posts.db")
	if err != nil {
		log.Fatalf("Failed to create a Firestore Client: %v", err)
		return nil, err
	}

	tx, err := db.Begin()
	if err != nil {
		log.Fatal(err)
		return nil, err
	}
	stmt, err := tx.Prepare(`SELECT * FROM posts`)
	if err != nil {
		log.Fatal(err)
		return nil, err
	}
	defer stmt.Close()

	results, error := stmt.Exec()
	if error != nil {
		log.Fatalf("Failed to adding a new post: %v", error)
		return nil, error
	}

	fmt.Println(results)

	var posts []entity.Post

	return posts, nil
}
