FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Nagp.UserInfo/Nagp.UserInfo.csproj", "Nagp.UserInfo/"]
RUN dotnet restore "Nagp.UserInfo/Nagp.UserInfo.csproj"
COPY . .
WORKDIR "/src/Nagp.UserInfo"
RUN dotnet build "Nagp.UserInfo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nagp.UserInfo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nagp.UserInfo.dll"]
