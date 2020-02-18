#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["SimpleMVC2/SimpleMVC2.csproj", "SimpleMVC2/"]
RUN dotnet restore "SimpleMVC2/SimpleMVC2.csproj"
COPY . .
WORKDIR "/src/SimpleMVC2"
RUN dotnet build "SimpleMVC2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleMVC2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleMVC2.dll"]