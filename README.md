# finratp
test project for fin-ra with auto migration, data seed and clean architecture 

# swagger
make run
````
http://localhost:5000/swagger/index.html
````
make docker-up
````
http://localhost:8080/swagger/index.html
````

# makefile
run api
````
make run
````
build api
````
make app-build
````
build api release version
````
make app-build-release
````
publish api
````
make app-publish
````
add migration
````
make migration-add name={migrationName}
````
remove last migration
````
make migration-remove
````

update database
````
make update-database
````

build docker conainer and uo
````
make docker-up
````


# run
````
dotnet run
````

# docker
````
docker-compose build
docker-compose up
````
