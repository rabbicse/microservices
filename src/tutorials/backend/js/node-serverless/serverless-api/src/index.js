const serverless = require("serverless-http");
const express = require("express");
const { neon, neonConfig } = require("@neondatabase/serverless");

const app = express();

async function dbClient() {
  neonConfig.fetchConnectionCache = true;
  const sql = neon(process.env.DATABASE_URL);
  return sql;
}

async function indexRoute(req, res, next) {
  console.log(process.env.DEBUG);
  const sql = await dbClient();
  const [results] = await sql`SELECT NOW();`;
  return res.status(200).json({
    message: "Hello from root!",
    results: results.now,
  });
}

app.get("/", indexRoute);

app.get("/path", (req, res, next) => {
  return res.status(200).json({
    message: "Hello from path!",
  });
});

app.use((req, res, next) => {
  return res.status(404).json({
    error: "Not Found",
  });
});

// app.listen(3000, () => {
//   console.log("Server runnong on port 3000");
// });

module.exports.handler = serverless(app);
