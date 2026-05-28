# credo-web
The web application for C.R.E.D.O. organisation

The initial project was created as follows:

```bash
dotnet new blazor -n CREDO.WebApp -f net10.0 --auth Individual --interactivity Server

dotnet new sln -n CREDO

dotnet sln CREDO.slnx add .\CREDO.WebApp\CREDO.WebApp.csproj

dotnet restore
```
