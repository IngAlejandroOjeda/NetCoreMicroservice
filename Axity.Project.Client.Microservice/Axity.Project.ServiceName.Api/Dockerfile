FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj", "Axity.Project.ServiceName.Api/"]
RUN dotnet restore "Axity.Project.ServiceName.Api/Axity.Project.ServiceName.Api.csproj"
COPY . .
WORKDIR "/src/Axity.Project.ServiceName.Api"
RUN dotnet build "Axity.Project.ServiceName.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Axity.Project.ServiceName.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Axity.Project.ServiceName.Api.dll"]