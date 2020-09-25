FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ApiTaxa.Presentation/ApiTaxa.Presentation.csproj", "ApiTaxa.Presentation/"]
RUN dotnet restore "ApiTaxa.Presentation/ApiTaxa.Presentation.csproj"
COPY . .
WORKDIR "/src/ApiTaxa.Presentation"
RUN dotnet build "ApiTaxa.Presentation.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ApiTaxa.Presentation.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ApiTaxa.Presentation.dll"]
