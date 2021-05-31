# This is multi stage docker file
# It has multiple steps to build as well as publish code in container
# and copy published code to final image we want to generate

## Stage 1

# Base aspnet runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 8082

ENV ASPNETCORE_URLS=http://+:8082

## Stage 2

# Base SDK Image
# It copies local project in /src, does dotnet retore and copies everything else, sets working directory and then build
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ASPNET_Core_WebAPI.csproj", "./"]
RUN dotnet restore "ASPNET_Core_WebAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ASPNET_Core_WebAPI.csproj" -c Release -o /app/build

## Stage 3
# It publishes the build image a and output that to app/publish
FROM build AS publish
RUN dotnet publish "ASPNET_Core_WebAPI.csproj" -c Release -o /app/publish


## Stage 4
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASPNET_Core_WebAPI.dll"]

## Instructions

# Build Command - It creates the image that can be view under Images in Docker Desktop
    # docker build -t test4/aspnetcore .

# Run Command - It runs the image.(Creates a container) We can see it under Containers/Apps in Docker Desktop
 # If we browse 8082, it should route to 5000 within the container 
    # docker run -p  8082:5000 test4/aspnetcore
