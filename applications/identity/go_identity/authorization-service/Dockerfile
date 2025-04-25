FROM golang:1.24-alpine as builder

WORKDIR /app

COPY . .

RUN go build -o /app/authorization-service

FROM scratch

COPY --from=builder /app/authorization-service /app/authorization-service

ENTRYPOINT [ "/app/authorization-service" ]