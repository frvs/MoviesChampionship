# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY Api/*.csproj Api/
COPY Application/*.csproj Application/
COPY Domain/*.csproj Domain/
RUN dotnet restore Api/Api.csproj

# copy and build app and libraries
COPY Api/ Api/
COPY Application/ Application/
COPY Domain/ Domain/
WORKDIR /source/Api
RUN dotnet build -c release --no-restore

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api.dll"]