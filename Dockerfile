# syntax=docker/dockerfile:1

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["CREDO.WebApp/CREDO.WebApp.csproj", "CREDO.WebApp/"]
RUN dotnet restore "CREDO.WebApp/CREDO.WebApp.csproj"

COPY . .
RUN dotnet publish "CREDO.WebApp/CREDO.WebApp.csproj" \
    --configuration Release \
    --output /app/publish \
    --no-restore \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
ARG APP_UID=1654
WORKDIR /app

ENV ASPNETCORE_ENVIRONMENT=Production \
    ASPNETCORE_HTTP_PORTS=8080

EXPOSE 8080

COPY --from=build /app/publish .
RUN mkdir -p /app/Data \
    && chown -R ${APP_UID}:0 /app \
    && chmod -R g=u /app

USER ${APP_UID}

HEALTHCHECK --interval=30s --timeout=5s --start-period=20s --retries=3 \
    CMD dotnet CREDO.WebApp.dll --healthcheck "http://127.0.0.1:${ASPNETCORE_HTTP_PORTS:-8080}/health" || exit 1

ENTRYPOINT ["dotnet", "CREDO.WebApp.dll"]
