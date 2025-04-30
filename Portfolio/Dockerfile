
# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar el archivo .csproj y restaurar dependencias
COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o /app/out

# Etapa 2: runtime (la imagen de ejecución)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copiar los archivos de la etapa de build
COPY --from=build /app/out .

# Exponer puertos
EXPOSE 80
EXPOSE 443

# Configuración de la aplicación
ENTRYPOINT ["dotnet", "Portfolio.dll"]
