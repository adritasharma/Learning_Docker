FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8085

ENV ASPNETCORE_URLS=http://+:8085

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PgSql_ASPNET_Core.csproj", "./"]
RUN dotnet restore "PgSql_ASPNET_Core.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PgSql_ASPNET_Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PgSql_ASPNET_Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PgSql_ASPNET_Core.dll"]


## Instructions

# Build Command - It creates the image that can be view under Images in Docker Desktop
    # docker build -t test3/postgresaspnetcore .
 
# Run Command - It runs the image.(Creates a container) We can see it under Containers/Apps in Docker Desktop
 # If we browse 8085, it should route to 5000 within the container 

  # WARNING ---> docker run -p  8085:5000 test3/postgresaspnetcore


    # THE ABOVE INSTRUCTION WON'T RUN THE CONATNER. IT WILL ENCOUNTER AN ERROR

    # System.Net.Internals.SocketExceptionFactory+ExtendedSocketException (99): Cannot assign requested address [::1]:5432

    # This means postgres is not connected, so we have to link containers
    
# LEGACY LINKING

## This will spin up a  postgres image
    # docker run -d -p 5432:5432  --name my-postgres -e POSTGRES_PASSWORD=dimapur postgres

    ## Note
    ### appsettings.json
    ####        "ConnectionStrings": {
    ####            "ToDoDb": "Host=my-postgres;port=5432;;Username=postgres;Password=dimapur;Database=ToDoApp"
    ####         },


## Here we will link postgres image to aspnetcoreprostgres
   #  docker run -d -p  8085:5000 --link  my-postgres:postgreys test3/postgresaspnetcore