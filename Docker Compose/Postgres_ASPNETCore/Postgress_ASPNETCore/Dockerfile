FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Postgress_ASPNETCore.csproj", "./"]
RUN dotnet restore "Postgress_ASPNETCore.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Postgress_ASPNETCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Postgress_ASPNETCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Postgress_ASPNETCore.dll"]


## Instructions

# Build Command - It creates the image that can be view under Images in Docker Desktop
    # docker build -t demo1/postgresaspnetcore .
 
# Run Command - It runs the image.(Creates a container) We can see it under Containers/Apps in Docker Desktop
 # If we browse 5000, it should route to 5000 within the container 

  # WARNING ---> docker run -p  5000:5000 demo1/postgresaspnetcore


   # THE ABOVE INSTRUCTION WON'T RUN THE CONATNER. IT WILL ENCOUNTER AN ERROR

    # System.Net.Internals.SocketExceptionFactory+ExtendedSocketException (99): Cannot assign requested address [::1]:5432

    # This means postgres is not connected, so we have to link containers
    
# LEGACY LINKING

## This will spin up a  postgres image
    # docker run -d --name my-postgres -p 5432:5432 -e POSTGRES_PASSWORD=password postgres
    # or, docker run -d  --name my-postgres -e POSTGRES_PASSWORD=password postgres

    ## Note
    ### appsettings.json
    ####        "ConnectionStrings": {
    ####            "ToDoDb": "Host=postgres;port=5432;Username=postgres;Password=password;Database=ToDoApp"
    ####         },


## Here we will link postgres image to aspnetcoreprostgres
   #  docker run -d -p  5000:5000 --link  my-postgres:postgres demo1/postgresaspnetcore
