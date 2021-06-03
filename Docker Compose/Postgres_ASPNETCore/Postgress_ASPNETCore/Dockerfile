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

