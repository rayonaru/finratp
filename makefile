run:
	cd Finra.API/ && dotnet run

app-build:
	cd Finra.API/ && dotnet build

app-build-release:
	cd Finra.API/ && dotnet build -c Release -o ../app/build

app-publish:
	cd Finra.API/ && dotnet publish -c Release -o ../app/publish

migration-add:
	cd Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ migrations add $(name)

migration-remove:
	cd Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ migrations remove

update-database:
	cd Finra.Infrastructure/ && dotnet ef --startup-project ../Finra.API/ database update

docker-up:
	docker-compose build && docker-compose up