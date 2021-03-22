#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 21021

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/VueLearning.Web.Host/", "VueLearning.Web.Host/"]
COPY ["src/VueLearning.Web.Core/", "VueLearning.Web.Core/"]
COPY ["src/VueLearning.Application/", "VueLearning.Application/"]
COPY ["src/VueLearning.Core/", "VueLearning.Core/"]
COPY ["src/VueLearning.EntityFrameworkCore/", "VueLearning.EntityFrameworkCore/"]
RUN dotnet restore "src/VueLearning.Web.Host/VueLearning.Web.Host.csproj" -s https://api.nuget.org/v3/index.json
COPY . .
WORKDIR "/src/src/VueLearning.Web.Host"
RUN dotnet build "VueLearning.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VueLearning.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VueLearning.Web.Host.dll"]