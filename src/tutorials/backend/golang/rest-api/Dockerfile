FROM golang:latest

LABEL maintainer="Mehedi <rabbi.se@gmail.com>"

WORKDIR /app

COPY go.mod .

COPY go.sum .

RUN go mod download

COPY . .

ENV PORT 8000

RUN go build 

CMD ["./rest-api"]