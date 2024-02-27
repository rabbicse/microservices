const express = require("express");
const mongoose = require("mongoose");

const app = express();
const port = 3000;

app.get("/", (req, res) => {
  res.send("Hello World!");
});

USER = "rabbicse";
PASSWORD = "MDgLGcgVzI55somb";

mongoose
  .connect("mongodb+srv://rabbise:MDgLGcgVzI55somb@cluster0.wultknp.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0", {useNewUrlParser:true})
  .then(() => {
    console.log("MongoDB connected!");
  })
  .catch((err) => {
    console.log("Connection failed!");
    console.log(err);
  });

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`);
});
