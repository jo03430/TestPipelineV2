#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestPipelineV2/TestPipelineV2.csproj", "TestPipelineV2/"]
COPY ["TestPipelineV2.Domain/TestPipelineV2.Domain.csproj", "TestPipelineV2.Domain/"]
RUN dotnet restore "TestPipelineV2/TestPipelineV2.csproj"
COPY . .
WORKDIR "/src/TestPipelineV2"
RUN dotnet build "TestPipelineV2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestPipelineV2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestPipelineV2.dll"]