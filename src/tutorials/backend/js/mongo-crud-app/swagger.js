// const swaggerAutogen = require('swagger-autogen')({openapi: '3.1.0'});

// const outputFile = './swagger_output.json'
// const endpointsFiles = ['./routes/product.route.js']

// swaggerAutogen(outputFile, endpointsFiles);

const swaggerAutogen = require("swagger-autogen")({ openapi: "3.1.0" });

const doc = {
  info: {
    version: "", // by default: '1.0.0'
    title: "", // by default: 'REST API'
    description: "", // by default: ''
  },
  servers: [
    {
      url: "", // by default: 'http://localhost:3000'
      description: "", // by default: ''
    },
    // { ... }
  ],
  tags: [
    // by default: empty Array
    {
      name: "", // Tag name
      description: "", // Tag description
    },
    // { ... }
  ],
  components: {}, // by default: empty object
};

const outputFile = "./swagger.json";
const routes = ['./server.js', './models/product.model.js'];

/* NOTE: If you are using the express Router, you must pass in the 'routes' only the 
root file where the route starts, such as index.js, app.js, routes.js, etc ... */

swaggerAutogen(outputFile, routes);
