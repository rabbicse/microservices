# Mock Service

## Installation
Write the following command
```
npm install @stoplight/prism-cli
```

## Run mock services
Write the following command to run mock kitchen service.
```
./node_modules/.bin/prism mock kitchen.yaml --port 3000
```

Write the following curl command to view mock data of kitchen schedule
```
curl http:/ /localhost:3000/kitchen/schedules
```

Write the following command for payment service.
```
./node_modules/.bin/prism mock payments.yaml --port 3001
```