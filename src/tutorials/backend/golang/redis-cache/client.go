package main

import (
	"fmt"

	"github.com/gomodule/redigo/redis"
)

func CreateConnection() redis.Conn {
	var pool = &redis.Pool{
		MaxIdle:   10,
		MaxActive: 1000,
		Dial: func() (redis.Conn, error) {
			return redis.Dial("tcp", ":6379")
		},
	}

	conn := pool.Get()

	return conn
}

func BasicGetSet(conn redis.Conn) {
	_, err := conn.Do("SET", "key", "value")
	if err != nil {
		fmt.Println("Error: " + err.Error())
	}

	value, err := redis.String(conn.Do("GET", "key"))
	fmt.Println(value)
}

func BasicListOperation(conn redis.Conn) {
	_, err := conn.Do("LPUSH", "mylist", "value")
	if err != nil {
		fmt.Println("Error: " + err.Error())
	}

	value, err := redis.String(conn.Do("RPOP", "mylist"))
	fmt.Println(value)
}

func BasicSetOperation(conn redis.Conn) {
	_, err := conn.Do("SADD", "myset", "value")
	if err != nil {
		fmt.Println("Error: " + err.Error())
	}

	exists, err := redis.Bool(conn.Do("SISMEMBER", "myset", "value"))
	fmt.Println(exists)
}

func BasicHashOperation(conn redis.Conn) {
	_, err := conn.Do("HSET", "myhash", "field", "value")
	if err != nil {
		fmt.Println("Error: " + err.Error())
	}

	value, err := redis.String(conn.Do("HGET", "myhash", "field"))
	fmt.Println(value)
}

func main() {
	fmt.Println("Redis client...")

	conn := CreateConnection()
	defer conn.Close()

	// basic get set commands
	BasicGetSet(conn)

	// basic list operations
	BasicListOperation(conn)

	// basic set operations
	BasicSetOperation(conn)

	// basic hash operations
	BasicHashOperation(conn)
}
