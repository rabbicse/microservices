require('dotenv').config();
const express = require("express");
const mongoose = require("mongoose");
const Product = require("./models/product.model.js");
const productRoute = require("./routes/product.route.js");
const app = express();

// middleware
app.use(express.json());
app.use(express.urlencoded({ extended: false }));

// routes
app.use("/api/products", productRoute);

app.get("/", (req, res) => {
  res.send("Hello from Node API Server Updated");
});

mongoose
  .connect(
    process.env.MONGODB_CONNECTION
  )
  .then(() => {
    console.log("MongoDB connected!");
  })
  .catch((err) => {
    console.log("Connection failed!");
    console.log(err);
  });
