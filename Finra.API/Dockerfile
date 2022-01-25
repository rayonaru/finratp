FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80

# ENV ASPNETCORE_URLS=http://+:5000

RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["Finra.API/Finra.API.csproj", "Finra.API/"]
RUN dotnet restore "Finra.API/Finra.API.csproj"
COPY . .
WORKDIR "/src/Finra.API"
RUN dotnet build "Finra.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Finra.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Finra.API.dll"]
