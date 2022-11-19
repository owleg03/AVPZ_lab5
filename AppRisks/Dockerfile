FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AppRisks/AppRisks.csproj", "AppRisks/"]
RUN dotnet restore "AppRisks/AppRisks.csproj"
COPY . .
WORKDIR "/src/AppRisks"
RUN dotnet build "AppRisks.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AppRisks.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AppRisks.dll"]
