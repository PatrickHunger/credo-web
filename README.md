# credo-web
The web application for C.R.E.D.O. organisation

The initial project was created as follows:

```bash
dotnet new blazor -n CREDO.WebApp -f net10.0 --auth Individual --interactivity Server

dotnet new sln -n CREDO

dotnet sln CREDO.slnx add .\CREDO.WebApp\CREDO.WebApp.csproj

dotnet restore
```

## Docker

The application can be built and run as a containerized ASP.NET Core app. The
container image uses a multi-stage .NET 10 build, runs the published application
with the ASP.NET runtime image, listens on all container interfaces, and runs as
a non-root user.

### Prerequisites

- Docker Engine or Docker Desktop
- Docker Compose v2 for `docker compose` commands

No .NET SDK or ASP.NET runtime is required on the Docker host.

### Build the image

```bash
docker build -t credo-web:local .
```

### Run the container directly

```bash
docker run --rm \
  --name credo-web \
  -p 8080:8080 \
  -e ASPNETCORE_ENVIRONMENT=Production \
  -e ASPNETCORE_HTTP_PORTS=8080 \
  -e "ConnectionStrings__DefaultConnection=DataSource=/app/Data/app.db;Cache=Shared" \
  -v credo-data:/app/Data \
  credo-web:local
```

Open `http://localhost:8080` after the container has started.

### Run with Docker Compose

```bash
docker compose up --build
```

To run in the background:

```bash
docker compose up --build -d
```

To stop and remove the Compose containers:

```bash
docker compose down
```

To stop the containers and remove the SQLite volume as well:

```bash
docker compose down --volumes
```

### Configuration

Configuration is supplied through environment variables so the image does not
need to be rebuilt for different environments.

| Variable | Default | Description |
| --- | --- | --- |
| `CREDO_HOST_PORT` | `8080` | Host port used by Docker Compose. |
| `ASPNETCORE_HTTP_PORTS` | `8080` | HTTP port the app listens on inside the container. |
| `ASPNETCORE_ENVIRONMENT` | `Production` | ASP.NET Core runtime environment. |
| `CREDO_DB_CONNECTION` | `DataSource=/app/Data/app.db;Cache=Shared` | Connection string passed to `ConnectionStrings__DefaultConnection` by Compose. |
| `ConnectionStrings__DefaultConnection` | `DataSource=/app/Data/app.db;Cache=Shared` | Direct ASP.NET Core connection string variable for `docker run`. |
| `LOGGING__LOGLEVEL__DEFAULT` | `Information` | Default logging level used by Compose. |
| `LOGGING__LOGLEVEL__MICROSOFT_ASPNETCORE` | `Warning` | ASP.NET Core logging level used by Compose. |

For Compose, copy `.env.example` to `.env` and adjust values locally if needed.
The `.env` file is excluded from version control and should be used for
environment-specific settings.

### Database storage

The application currently uses SQLite. The Docker image contains the published
application files only, and Compose mounts a named volume at `/app/Data` so the
SQLite database can persist across container restarts.

For direct `docker run` usage, mount the same path:

```bash
docker volume create credo-data

docker run --rm \
  -p 8080:8080 \
  -v credo-data:/app/Data \
  credo-web:local
```

If a deployment uses another database location or an external database service,
provide the final value through `ConnectionStrings__DefaultConnection` or
`CREDO_DB_CONNECTION`.

### Secrets

Do not bake passwords, connection strings, API keys, certificates, or other
sensitive values into the image. Pass them through environment variables, Docker
secrets, your hosting platform's secret store, or an untracked `.env` file.

### Health checks

The app exposes `GET /health` and the image includes a Docker health check. The
Compose service also uses the same check.

Inspect health status with:

```bash
docker compose ps
```

or for a directly started container:

```bash
docker inspect --format='{{json .State.Health}}' credo-web
```

### Logs and diagnostics

View Compose logs:

```bash
docker compose logs -f webapp
```

View direct container logs:

```bash
docker logs -f credo-web
```

Common startup checks:

- Confirm the host port is not already in use.
- Confirm `ASPNETCORE_HTTP_PORTS` matches the container side of the port mapping.
- Confirm the SQLite volume is mounted at `/app/Data`.
- Confirm the configured connection string points to a writable location.

### Rebuild after changes

```bash
docker compose build --no-cache
docker compose up -d
```

### Deployment

Build and tag the image for the target registry:

```bash
docker build -t registry.example.com/credo-web:latest .
docker push registry.example.com/credo-web:latest
```

On a Docker-compatible server, provide the required environment variables and a
persistent `/app/Data` volume, then start the image with the same port and
connection-string configuration shown above.
