const swaggerAutogen = require("swagger-autogen")({ openapi: "3.1.0" });

const doc = {
  info: {
    version: "", // by default: "1.0.0"
    title: "", // by default: "REST API"
    description: "", // by default: ""
  },
  host: "", // by default: "localhost:3000"
  basePath: "", // by default: "/"
  schemes: [], // by default: ['http']
  consumes: [], // by default: ['application/json']
  produces: [], // by default: ['application/json']
  tags: [
    // by default: empty Array
    {
      name: "", // Tag name
      description: "", // Tag description
    },
    // { ... }
  ],
  securityDefinitions: {}, // by default: empty object
  definitions: {}, // by default: empty object
};

const outputFile = "./swagger.json";
const routes = ["./server.js", "./models/product.model.js"];

/* NOTE: If you are using the express Router, you must pass in the 'routes' only the 
root file where the route starts, such as index.js, app.js, routes.js, etc ... */

swaggerAutogen(outputFile, routes, doc);
