ARG postgres_version=15.1.1.49

ARG pgbouncer_release=1.18.0
ARG postgrest_release=10.1.2
ARG gotrue_release=2.130.0
ARG adminapi_release=0.64.1
ARG adminmgr_release=0.22.1
ARG vector_release=0.22.3
ARG postgres_exporter_release=0.15.0
ARG envoy_release=1.28.0

# Update `gateway-28` in the URL below if upgrading above v2.8.x.
ARG kong_release=2.8.1

FROM supabase/postgres:${postgres_version} AS base
ARG TARGETARCH
ARG postgresql_major

FROM base AS builder
# Install build dependencies
RUN apt-get update && apt-get install -y \
    postgresql-server-dev-${postgresql_major} \
    build-essential \
    checkinstall \
    pkg-config \
    cmake \
    && rm -rf /var/lib/apt/lists/*

####################
# Install pgbouncer
####################
FROM builder AS pgbouncer-source
# Download and extract
ARG pgbouncer_release
ADD "https://www.pgbouncer.org/downloads/files/${pgbouncer_release}/pgbouncer-${pgbouncer_release}.tar.gz" /tmp/pgbouncer.tar.gz
RUN tar -xvf /tmp/pgbouncer.tar.gz -C /tmp && \
    rm -rf /tmp/pgbouncer.tar.gz
# Install build dependencies
RUN apt-get update && apt-get install -y \
    libevent-dev \
    && rm -rf /var/lib/apt/lists/*
# Build from source
WORKDIR /tmp/pgbouncer-${pgbouncer_release}
RUN ./configure --prefix=/usr/local
RUN make -j$(nproc)
# Create debian package
RUN checkinstall -D --install=no --fstrans=no --backup=no --pakdir=/tmp --requires=libevent-2.1-7 --nodoc

FROM base AS pgbouncer
# Download pre-built packages
RUN apt-get update && apt-get install -y --no-install-recommends --download-only \
    pgbouncer \
    && rm -rf /var/lib/apt/lists/*
RUN mv /var/cache/apt/archives/*.deb /tmp/

####################
# Install PostgREST
####################
FROM postgrest/postgrest:v${postgrest_release} AS pgrst

####################
# Install GoTrue
####################
FROM supabase/gotrue:v${gotrue_release} AS gotrue

####################
# Install Envoy
####################
FROM envoyproxy/envoy:v${envoy_release} AS envoy

####################
# Install Kong
####################
FROM base AS kong
ARG kong_release
ADD "https://packages.konghq.com/public/gateway-28/deb/ubuntu/pool/focal/main/k/ko/kong_${kong_release}/kong_${kong_release}_${TARGETARCH}.deb" \
    /tmp/kong.deb

####################
# Install admin api
####################
FROM base AS adminapi
ARG adminapi_release
ADD "https://supabase-public-artifacts-bucket.s3.amazonaws.com/supabase-admin-api/v${adminapi_release}/supabase-admin-api_${adminapi_release}_linux_${TARGETARCH}.tar.gz" /tmp/supabase-admin-api.tar.gz
RUN tar -xvf /tmp/supabase-admin-api.tar.gz -C /tmp && \
    rm -rf /tmp/supabase-admin-api.tar.gz

####################
# Install admin mgr
####################
FROM base AS adminmgr
ARG adminmgr_release
ADD "https://supabase-public-artifacts-bucket.s3.amazonaws.com/admin-mgr/v${adminmgr_release}/admin-mgr_${adminmgr_release}_linux_${TARGETARCH}.tar.gz" /tmp/admin-mgr.tar.gz
RUN tar -xvf /tmp/admin-mgr.tar.gz -C /tmp && \
    rm -rf /tmp/admin-mgr.tar.gz

####################
# Install Prometheus Exporter
####################
FROM base AS exporter
ARG postgres_exporter_release
ADD "https://github.com/prometheus-community/postgres_exporter/releases/download/v${postgres_exporter_release}/postgres_exporter-${postgres_exporter_release}.linux-${TARGETARCH}.tar.gz" /tmp/postgres_exporter.tar.gz
RUN tar -xvf /tmp/postgres_exporter.tar.gz -C /tmp --strip-components 1 && \
    rm -rf /tmp/postgres_exporter.tar.gz

####################
# Install vector
####################
FROM base AS vector
ARG vector_release
ADD "https://packages.timber.io/vector/${vector_release}/vector_${vector_release}-1_${TARGETARCH}.deb" /tmp/vector.deb

####################
# Install supervisord
####################
FROM base AS supervisor
# Download pre-built packages
RUN apt-get update -y && apt-get install -y --no-install-recommends --download-only \
    supervisor \
    && rm -rf /var/lib/apt/lists/*
RUN mv /var/cache/apt/archives/*.deb /tmp/

####################
# Create the final image for production
####################
FROM base AS production

# Copy dependencies from previous build stages
COPY --from=pgbouncer /tmp/*.deb /tmp/
COPY --from=vector /tmp/*.deb /tmp/
COPY --from=kong /tmp/*.deb /tmp/
COPY --from=supervisor /tmp/*.deb /tmp/

# Install runtime dependencies
RUN apt-get update && apt-get install -y --no-install-recommends \
    /tmp/*.deb \
    # For health check
    curl \
    # For parsing init payload
    jq \
    # Security tools
    fail2ban \
    # sudo
    sudo \
    vim-tiny \
    less \
    libnuma1 \
    logrotate \
    dumb-init \
    # pg_egress_collect deps
    tcpdump libio-async-perl \
    && rm -rf /var/lib/apt/lists/* /tmp/* \
    && mkdir -p /dist \
    && mkdir -p /data/opt && chmod go+rwx /data/opt

####################
# Install salt
####################
ENV DEBIAN_FRONTEND noninteractive
ENV SALT_VERSION 3006

# Install one-dir salt
RUN mkdir /etc/apt/keyrings \
    && curl -fsSL -o /etc/apt/keyrings/salt-archive-keyring-2023-arm.gpg https://repo.saltproject.io/salt/py3/ubuntu/20.04/arm64/SALT-PROJECT-GPG-PUBKEY-2023.gpg \
    && echo "deb [signed-by=/etc/apt/keyrings/salt-archive-keyring-2023-arm.gpg arch=arm64] https://repo.saltproject.io/salt/py3/ubuntu/20.04/arm64/$SALT_VERSION focal main" | tee /etc/apt/sources.list.d/salt.list \
    && curl -fsSL -o /etc/apt/keyrings/salt-archive-keyring-2023-amd.gpg https://repo.saltproject.io/salt/py3/ubuntu/20.04/amd64/SALT-PROJECT-GPG-PUBKEY-2023.gpg \
    && echo "deb [signed-by=/etc/apt/keyrings/salt-archive-keyring-2023-amd.gpg arch=amd64] https://repo.saltproject.io/salt/py3/ubuntu/20.04/amd64/$SALT_VERSION focal main" | tee -a /etc/apt/sources.list.d/salt.list \
    && apt-get clean && apt-get update \
    && apt-get install -y salt-minion

ADD etc/salt/minion /etc/salt/minion


# Copy single binary dependencies
COPY --from=pgrst /bin/postgrest /dist/
COPY --from=gotrue /usr/local/bin/auth /dist/gotrue
COPY --from=gotrue /usr/local/etc/auth /opt/gotrue/
COPY --from=envoy /usr/local/bin/envoy /dist/
COPY --from=adminapi /tmp/supabase-admin-api /dist/
COPY --chown=root:root --from=adminmgr /tmp/admin-mgr /dist/
COPY --from=exporter /tmp/postgres_exporter /opt/postgres_exporter/
COPY opt/postgres_exporter /opt/postgres_exporter/

# Configuring dangling symlinks for binaries
RUN ln -s /data/opt/supabase-admin-api /opt/supabase-admin-api \
    && ln -s /data/opt/postgrest /opt/postgrest \
    && ln -s /data/opt/gotrue /opt/gotrue/gotrue \
    && ln -s /data/opt/admin-mgr /usr/bin/admin-mgr

# Scripts for adminapi
COPY ansible/files/admin_api_scripts /root
COPY --chown=adminapi:adminapi etc/adminapi /etc/adminapi
COPY --chmod=644 etc/sudoers.d /etc/sudoers.d/

# Script for pg_egress_collect
COPY --chown=adminapi:adminapi opt/pg_egress_collect /opt/pg_egress_collect

# Customizations for pgbouncer
COPY etc/pgbouncer /etc/pgbouncer
COPY etc/pgbouncer-custom /etc/pgbouncer-custom
COPY etc/tmpfiles.d /etc/tmpfiles.d

# Customizations for postgres
COPY --chown=postgres:postgres etc/postgresql/pg_hba.conf /etc/postgresql/
COPY --chown=postgres:postgres etc/postgresql/logging.conf /etc/postgresql/
COPY --chown=postgres:postgres etc/postgresql-custom /etc/postgresql-custom
COPY --chown=postgres:postgres etc/postgresql.schema.sql /etc/postgresql.schema.sql

# Customizations for postgres_exporter
COPY --chown=postgres:postgres opt/postgres_exporter/queries.yml /opt/postgres_exporter/queries.yml

# Customizations for fail2ban
COPY etc/fail2ban/filter.d /etc/fail2ban/filter.d/
COPY etc/fail2ban/jail.d /etc/fail2ban/jail.d/

# Customizations for postgrest
COPY --chown=postgrest:postgrest etc/postgrest/bootstrap.sh /etc/postgrest/bootstrap.sh
COPY --chown=postgrest:postgrest etc/postgrest/base.conf /etc/postgrest/base.conf
COPY --chown=postgrest:postgrest etc/postgrest/generated.conf /etc/postgrest/generated.conf

# Customizations for logrotate
COPY etc/logrotate.d/walg.conf /etc/logrotate.d/walg.conf
COPY etc/logrotate.d/postgresql.conf /etc/logrotate.d/postgresql.conf

# Customizations for gotrue
COPY etc/gotrue.env /etc/gotrue.env

# Customizations for envoy
ARG envoy_release
ADD --chmod=755 --chown=envoy:envoy "https://raw.githubusercontent.com/envoyproxy/envoy/v${envoy_release}/restarter/hot-restarter.py" /opt/envoy-hot-restarter.py
COPY --chmod=775 --chown=envoy:envoy ansible/files/envoy_config/ /etc/envoy/
COPY --chmod=755 --chown=envoy:envoy ansible/files/start-envoy.sh /opt/

# Customizations for kong
COPY etc/kong/kong.conf /etc/kong/kong.conf
COPY etc/kong/kong.yml /etc/kong/kong.yml

# Customizations for vector
COPY --chown=vector:vector etc/vector/vector.yaml /etc/vector/vector.yaml

# Customizations for supervisor
COPY etc/supervisor /etc/supervisor

# Customizations for supa-shutdown
COPY --chown=adminapi:adminapi etc/supa-shutdown /etc/supa-shutdown
COPY configure-shim.sh /usr/local/bin/configure-shim.sh

# Configure service ports
ENV PGRST_SERVER_PORT=3000
ENV PGRST_ADMIN_SERVER_PORT=3001
EXPOSE ${PGRST_SERVER_PORT}

ENV GOTRUE_SITE_URL=http://localhost:${PGRST_SERVER_PORT}
ENV GOTRUE_API_PORT=9999
EXPOSE ${GOTRUE_API_PORT}

ENV ENVOY_HTTP_PORT=8000
ENV ENVOY_HTTPS_PORT=8443

ENV KONG_HTTP_PORT=8000
ENV KONG_HTTPS_PORT=8443

ENV HTTP_PORT=${ENVOY_HTTP_PORT:-KONG_HTTP_PORT}
ENV HTTP_PORT=${ENVOY_HTTPS_PORT:-KONG_HTTPS_PORT}
EXPOSE ${HTTP_PORT} ${HTTPS_PORT}

ENV ADMIN_API_CERT_DIR=/etc/ssl/adminapi
ENV ADMIN_API_PORT=8085
EXPOSE ${ADMIN_API_PORT}

ENV PGBOUNCER_PORT=6543
EXPOSE ${PGBOUNCER_PORT}

ENV PGEXPORTER_PORT=9187
EXPOSE ${PGEXPORTER_PORT}

ENV VECTOR_API_PORT=9001

# Create system users
RUN useradd --create-home --shell /bin/bash postgrest && \
    useradd --create-home --shell /bin/bash gotrue && \
    useradd --create-home --shell /bin/bash envoy && \
    useradd --create-home --shell /bin/bash pgbouncer -G postgres,ssl-cert && \
    useradd --create-home --shell /bin/bash adminapi -G root,envoy,kong,pgbouncer,postgres,postgrest,wal-g && \
    usermod --append --shell /bin/bash -G postgres vector
RUN mkdir -p /etc/wal-g && \
    chown -R adminapi:adminapi /etc/wal-g && \
    chmod g+w /etc/wal-g
RUN mkdir -p /var/log/wal-g \
    && chown -R postgres:postgres /var/log/wal-g \
    && chmod +x /dist/admin-mgr \
    && chmod ug+s /dist/admin-mgr \
    && touch /etc/wal-g/config.json \
    && chown adminapi:adminapi /etc/wal-g/config.json \
    && echo '{"WALG_S3_PREFIX": "s3://foo/bar/"}' > /etc/wal-g/config.json
RUN chown -R adminapi:adminapi /etc/adminapi
RUN sed -i "s;#include = '/etc/postgresql-custom/generated-optimizations.conf';include = '/etc/postgresql-custom/generated-optimizations.conf';" /etc/postgresql/postgresql.conf

# Add healthcheck and entrypoint scripts
COPY healthcheck.sh /usr/local/bin/
HEALTHCHECK --interval=3s --timeout=2s --start-period=4s --retries=10 CMD [ "healthcheck.sh" ]

COPY init /init
COPY entrypoint.sh /usr/local/bin/
COPY postgres-entrypoint.sh /usr/local/bin/
COPY shutdown.sh /usr/local/bin/supa-shutdown.sh
COPY run-logrotate.sh /usr/local/bin/run-logrotate.sh
RUN chmod +x /usr/local/bin/entrypoint.sh /usr/local/bin/supa-shutdown.sh /usr/local/bin/run-logrotate.sh /usr/local/bin/configure-shim.sh 

ENTRYPOINT [ "/usr/bin/dumb-init" ]

CMD [ "entrypoint.sh"]
