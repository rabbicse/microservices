const express = require('express')
const app = express()
const port = process.env.PORT || 3000
const host = '0.0.0.0'

app.get('/', (req, res) => {
  res.send('Hello World! Updated')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})