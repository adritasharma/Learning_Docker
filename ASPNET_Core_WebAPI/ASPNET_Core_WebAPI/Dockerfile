FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5002

ENV ASPNETCORE_URLS=http://+:5002

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ASPNET_Core_WebAPI.csproj", "./"]
RUN dotnet restore "ASPNET_Core_WebAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ASPNET_Core_WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASPNET_Core_WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASPNET_Core_WebAPI.dll"]
