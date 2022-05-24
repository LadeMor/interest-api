FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["interest-api/interest-api.csproj", "interest-api/"]
RUN dotnet restore "interest-api/interest-api.csproj"
COPY . .
WORKDIR "/src/interest-api"
RUN dotnet build "interest-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "interest-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "interest-api.dll"]
