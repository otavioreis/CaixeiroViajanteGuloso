FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

# Copiar csproj e restaurar dependencias
COPY *.sln ./
COPY Algoritmos/*.csproj ./Algoritmos/
COPY AplicacaoConsole/*.csproj ./AplicacaoConsole/
COPY Algoritmos.Tests/*.csproj ./Algoritmos.Tests/
RUN dotnet restore

# Build da aplicacao
COPY . ./
RUN dotnet publish -c Release -o out

# Build da imagem
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/AplicacaoConsole/out .
ENTRYPOINT ["dotnet", "AplicacaoConsole.dll"]
