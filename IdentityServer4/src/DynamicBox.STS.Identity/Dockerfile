FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/DynamicBox.STS.Identity/DynamicBox.STS.Identity.csproj", "src/DynamicBox.STS.Identity/"]
COPY ["src/DynamicBox.Admin.EntityFramework.Shared/DynamicBox.Admin.EntityFramework.Shared.csproj", "src/DynamicBox.Admin.EntityFramework.Shared/"]
COPY ["src/DynamicBox.Admin.EntityFramework.SqlServer/DynamicBox.Admin.EntityFramework.SqlServer.csproj", "src/DynamicBox.Admin.EntityFramework.SqlServer/"]
COPY ["src/DynamicBox.Admin.EntityFramework.PostgreSQL/DynamicBox.Admin.EntityFramework.PostgreSQL.csproj", "src/DynamicBox.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/DynamicBox.Shared/DynamicBox.Shared.csproj", "src/DynamicBox.Shared/"]
COPY ["src/DynamicBox.Admin.EntityFramework.MySql/DynamicBox.Admin.EntityFramework.MySql.csproj", "src/DynamicBox.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/DynamicBox.STS.Identity/DynamicBox.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/DynamicBox.STS.Identity"
RUN dotnet build "DynamicBox.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DynamicBox.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "DynamicBox.STS.Identity.dll"]