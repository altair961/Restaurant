# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /Restaurant
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /Restaurant/out .
ENV ASPNETCORE_URLS=http://*:80
CMD dotnet Restaurant.dll