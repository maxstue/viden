#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["knowledge-journey.csproj", "."]
RUN dotnet restore "./knowledge-journey.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "knowledge-journey.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "knowledge-journey.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "knowledge-journey.dll"]