FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8083

ENV ASPNETCORE_URLS=http://+:8083

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ASPNETCORE_PgSQL/Demo.web.csproj", "ASPNETCORE_PgSQL/"]
COPY ["Demo.db/Demo.db.csproj", "ASPNETCORE_PgSQL.db/"]
COPY ["demo.repository/Demo.repository.csproj", "ASPNETCORE_PgSQL.repository/"]
COPY ["Demo.service/Demo.service.csproj", "ASPNETCORE_PgSQL.service/"]

RUN dotnet restore "ASPNETCORE_PgSQL\Demo.web.csproj"
COPY . .
WORKDIR "/src/ASPNETCORE_PgSQL"
RUN dotnet build "Demo.web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo.web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo.web.dll"]

## Instructions

# Build Command - It creates the image that can be view under Images in Docker Desktop
    # docker build -t test2/aspnetcoreprostgres .
 
# Run Command - It runs the image.(Creates a container) We can see it under Containers/Apps in Docker Desktop
 # If we browse 8083, it should route to 5000 within the container 

  # WARNING ---> docker run -p  8083:5000 test2/aspnetcoreprostgres


    # THE ABOVE INSTRUCTION WON'T RUN THE CONATNER. IT WILL ENCOUNTER AN ERROR

    # System.Net.Internals.SocketExceptionFactory+ExtendedSocketException (99): Cannot assign requested address [::1]:5432

    # This means postgres is not connected, so we have to link containers

# LEGACY LINKING

## This will spin up a  postgres image
    # docker run -d --name my-postgres -e POSTGRES_PASSWORD=dimapur postgres

    ## Note
    ### appsettings.json
    ####        "ConnectionStrings": {
    ####            "ToDoDb": "Host=my-postgres;port=5432;;Username=postgres;Password=dimapur;Database=ToDoApp"
    ####         },


## Here we will link postgres image to aspnetcoreprostgres
   #  docker run -d -p  8083:5000 --link  my-postgres:postgreys test2/aspnetcoreprostgres
