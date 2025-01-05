FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

COPY *.sln .
COPY ./src ./src

RUN dotnet restore Blog.sln

RUN dotnet publish ./src/Blog.Api/Blog.Api.csproj -c Release -o /app
FROM base AS api
WORKDIR /app

# Copy everything needed to run the app from the "build" stage.
COPY --from=base /app .
# Switch to a non-privileged user (defined in the base image) that the app will run under.
# See https://docs.docker.com/go/dockerfile-user-best-practices/
# and https://github.com/dotnet/dotnet-docker/discussions/4764
USER $APP_UID

ENTRYPOINT ["dotnet", "Blog.Api.dll"]
