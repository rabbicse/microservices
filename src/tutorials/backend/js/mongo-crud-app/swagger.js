const swaggerAutogen = require('swagger-autogen');

const outputFile = './swagger_output.json'
const endpointsFiles = ['./routes/product.route.js']

swaggerAutogen(outputFile, endpointsFiles);