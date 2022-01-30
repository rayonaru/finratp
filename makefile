run:
	cd src/Finra.API/ && dotnet run

app-build:
	cd src/Finra.API/ && dotnet build

app-build-release:
	cd src/Finra.API/ && dotnet build -c Release -o ../app/build

app-publish:
	cd src/Finra.API/ && dotnet publish -c Release -o ../app/publish

migration-add:
	cd src/Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ migrations add $(name)

migration-remove:
	cd src/Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ migrations remove

update-database:
	cd src/Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ database update

docker-up:
	docker-compose build && docker-compose up