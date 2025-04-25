# Passkey Authentication

## Getting Started
- Create Dockerfile
- Create .dockerignore
- Create docker-compose.yml

Now write the following command to start
```
docker compose up
```
Then to check it's working run the following command
```
docker compose run --service-ports web bash
```

Then,
```
node -v
npm init --yes
npm install express --save
npm install nodemon --save-dev
npx nodemon index.js
```

Then write the following commands
```
mkdir {app,db}
mv models ./app/models
mv migrations ./db/migrations
mv seeders ./db/seeders
mv config/config.json config/database.js
```

## Install sequalize package
```
docker compose exec web npm install sequelize --save
docker compose exec web npm install sequelize-cli --save-dev    
docker compose exec web npx sequelize-cli init
```