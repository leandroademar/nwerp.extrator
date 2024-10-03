﻿# Etapa de Construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Configuração de Variáveis de Ambiente
ENV ORACLE_HOME=/opt/oracle
ENV LD_LIBRARY_PATH=$ORACLE_HOME/instantclient_19_24
ENV PATH=$ORACLE_HOME:$PATH

# Instalando Dependências Necessárias
RUN apt-get update && apt-get install -y \
    unzip \
    libaio1 \
    libaio-dev \
    wget \
    libssl-dev \
    libpq-dev \
    libkrb5-dev \
    libsasl2-dev \
    libssl3 \
    build-essential \
    ca-certificates \
    libstdc++6 \
    zlib1g \
    curl \
    gnupg2 \
    apt-transport-https \
    gnupg && \
    rm -rf /var/lib/apt/lists/*

# Instalando o Oracle Instant Client (atenção ao licenciamento)
RUN wget -q https://download.oracle.com/otn_software/linux/instantclient/1923000/instantclient-basic-linux.x64-19.23.0.0.0dbru.zip && \
    wget -q https://download.oracle.com/otn_software/linux/instantclient/1923000/instantclient-sdk-linux.x64-19.23.0.0.0dbru.zip && \
    unzip -o -q instantclient-basic-linux.x64-19.23.0.0.0dbru.zip -d $ORACLE_HOME && \
    unzip -o -q instantclient-sdk-linux.x64-19.23.0.0.0dbru.zip -d $ORACLE_HOME && \
    rm -f instantclient-*.zip

# Instalando o Cliente SQL Server
RUN curl -sSL https://packages.microsoft.com/keys/microsoft.asc | apt-key add - && \
    curl -sSL https://packages.microsoft.com/config/ubuntu/22.04/prod.list > /etc/apt/sources.list.d/mssql-release.list && \
    apt-get update && \
    ACCEPT_EULA=Y apt-get install -y msodbcsql18 mssql-tools18 unixodbc-dev && \
    rm -rf /var/lib/apt/lists/*

# Atualizar PATH
ENV PATH=$PATH:/opt/mssql-tools18/bin

# Copiar e restaurar dependências
COPY *.sln ./
COPY nwErp.Api/*.csproj ./nwErp.Api/
RUN dotnet restore

# Copiar o restante do código e publicar
COPY . .
WORKDIR /app/nwErp.Api
RUN dotnet publish -c Release -o /app/publish

# Etapa de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Configuração de ambiente para o Oracle Instant Client
ENV ORACLE_HOME=/opt/oracle/instantclient_19_24
ENV LD_LIBRARY_PATH=$ORACLE_HOME
ENV PATH=$ORACLE_HOME:$PATH
ENV PATH=$PATH:/opt/mssql-tools18/bin

# Instalar dependências necessárias
RUN apt-get update && apt-get install -y libaio1 libaio-dev && rm -rf /var/lib/apt/lists/*

# Copiar o Oracle Instant Client do build
COPY --from=build $ORACLE_HOME $ORACLE_HOME

# Copiar arquivos publicados
COPY --from=build /app/publish ./

# Expor a porta
EXPOSE 8080

# Configurar usuário não-root (opcional)
# RUN useradd -m appuser
# USER appuser

# Comando de entrada
ENTRYPOINT ["dotnet", "nwErp.Api.dll"]