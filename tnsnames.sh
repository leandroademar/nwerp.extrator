#!/bin/bash
# Criação do arquivo tnsnames.ora
echo '
'"$ORACLE_DB"' =
  (DESCRIPTION =
    (ADDRESS_LIST =
      (ADDRESS = (PROTOCOL = TCP)(HOST = '"$ORACLE_DB_HOST"')(PORT = 1521))
    )
    (CONNECT_DATA =
      (SERVICE_NAME = '"$ORACLE_DB_SERVICE"')
    )
  )
' > $ORACLE_HOME/network/admin/tnsnames.ora

echo "Arquivo tnsnames.ora criado com sucesso em /opt/oracle/instantclient_19_24/network/admin/"