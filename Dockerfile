FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

COPY . /source

WORKDIR /source

ARG TARGETARCH

RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish -a ${TARGETARCH/amd64/x64} --use-current-runtime --self-contained false -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS dev
WORKDIR /app

COPY --from=build /app .

USER $APP_UID

ENV ASPNETCORE_ENVIRONMENT=Development

ENTRYPOINT ["dotnet", "racetijden-api-dotnet.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS prod
WORKDIR /app

COPY --from=build /app .

USER $APP_UID

ENV ASPNETCORE_ENVIRONMENT=Production

ENTRYPOINT ["dotnet", "racetijden-api-dotnet.dll"]
