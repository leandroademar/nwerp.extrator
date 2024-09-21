# Etapa de Construção
FROM leandroademar/nw-base:1.0.2 AS build
WORKDIR /app

# Copiar arquivos necessários
COPY *.sln ./
COPY ["nwErp.Api/*.csproj", "nwErp.Api/"]

# Restaurar dependências
RUN dotnet restore

# Copiar todos os outros arquivos e construir a aplicação
COPY nwErp.Api/. ./nwErp.Api/
WORKDIR /app/nwErp.Api
RUN dotnet build -c Release -o /app/build

# Publicar a aplicação
RUN dotnet publish -c Release -o /app/publish

# Etapa de Runtime
FROM leandroademar/nw-base:1.0.2 AS runtime
WORKDIR /app

# Copiar arquivos publicados
COPY --from=build /app/publish ./

# Configuração de ambiente para o Oracle Instant Client
ENV ORACLE_HOME=/opt/oracle/instantclient_19_24
ENV LD_LIBRARY_PATH=$ORACLE_HOME:$LD_LIBRARY_PATH
ENV PATH=$ORACLE_HOME:$PATH
ENV PATH=$PATH:/opt/mssql-tools/bin

 
# Instalar dependências do sistema (se necessário)
RUN apt-get update && apt-get install -y libaio1 libaio-dev iputils-ping && apt-get clean && rm -rf /var/lib/apt/lists/*

# Copiar e preparar scripts de configuração
COPY tnsnames.sh /app/tnsnames.sh
COPY appsettings.sh /app/appsettings.sh
RUN chmod +x /app/tnsnames.sh /app/appsettings.sh

# Expor a porta que a aplicação irá escutar
EXPOSE 8080

# Comando de entrada para iniciar a aplicação
ENTRYPOINT ["/bin/bash", "-c", "/app/tnsnames.sh && /app/appsettings.sh && dotnet nwErp.Api.dll"]