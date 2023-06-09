FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine as build

ENV PORT=7220

WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -o /app/published-app

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine as runtime
WORKDIR /app
COPY --from=build /app/published-app /app
EXPOSE 7220
ENTRYPOINT [ "dotnet", "/app/Nagp.UserInfo.dll" ]
