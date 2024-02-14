# Order Service

## Run instruction
To run order service standalone write the following command.
```commandline
uvicorn orders.app:app --reload
```

Then visit the following URI:

[http://127.0.0.1:8000/docs](http://127.0.0.1:8000/docs)

## Database & Migrations
Write the following command for migrations
```commandline
alembic init migrations
```

After modify credentials, write the following commands
```commandline
alembic revision --autogenerate -m "Initial migration"
```

Then write the following command.
```commandline
alembic upgrade heads
```

