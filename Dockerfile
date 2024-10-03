# Etapa de Construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Configuração de Variáveis de Ambiente
ENV ORACLE_HOME=/opt/oracle
ENV LD_LIBRARY_PATH=$ORACLE_HOME/instantclient_19_24
ENV PATH=$ORACLE_HOME:$PATH

USER root
# Criando o diretório de configuração do Oracle e definindo permissões
RUN mkdir -p $ORACLE_HOME/instantclient_19_24/network/admin && chmod -R 755 $ORACLE_HOME

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
    apt-utils \
    curl \
    git \
    rsync \
    vim \
    ssh \
    tzdata \
    locales \
    gnupg2 \
    apt-transport-https \
    gnupg &&\
    rm -rf /var/lib/apt/lists/* &&\
    echo "pt_BR.UTF-8 UTF-8" > /etc/locale.gen && \
    locale-gen pt_BR.UTF-8 && \
    update-locale LANG=pt_BR.UTF-8 LC_ALL=pt_BR.UTF-8 &&\
    echo "America/Sao_Paulo" > /etc/timezone

# Instalando o Oracle Instant Client
RUN echo "Baixando pacotes para amd64..." && \
    wget -q https://download.oracle.com/otn_software/linux/instantclient/oracle-instantclient-basiclite-linuxx64.zip && \
    wget -q https://download.oracle.com/otn_software/linux/instantclient/oracle-instantclient-devel-linuxx64.zip && \
    wget -q https://download.oracle.com/otn_software/linux/instantclient/oracle-instantclient-sqlplus-linuxx64.zip && \
    echo "Extraindo pacotes..." && \
    unzip -o -q oracle-instantclient-basiclite-linuxx64.zip -d $ORACLE_HOME && \
    unzip -o -q oracle-instantclient-devel-linuxx64.zip -d $ORACLE_HOME && \
    unzip -o -q oracle-instantclient-sqlplus-linuxx64.zip -d $ORACLE_HOME && \
    rm -f oracle-instantclient-*.zip; 

# Instalando o Cliente SQL Server (MS ODBC Driver) e Ferramentas SQLCMD
RUN curl -sSL https://packages.microsoft.com/keys/microsoft.asc | tee /etc/apt/trusted.gpg.d/microsoft.asc && \
    curl -sSL https://packages.microsoft.com/config/ubuntu/22.04/prod.list | tee /etc/apt/sources.list.d/mssql-release.list && \
    apt-get update && \
    ACCEPT_EULA=Y apt-get install -y msodbcsql18 mssql-tools18 && \
    apt-get install -y unixodbc-dev && \
    echo 'export PATH="$PATH:/opt/mssql-tools18/bin"' >> ~/.bashrc && \
    apt-get clean && rm -rf /var/lib/apt/lists/*


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
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS runtime
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