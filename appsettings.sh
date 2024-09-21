#!/bin/bash

echo '{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "OracleDbConnection": "User Id='"$ORACLE_DB_USER"';Password='"$ORACLE_DB_PASSWORD"';Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST='"$ORACLE_DB_HOST"')(PORT='"$ORACLE_DB_PORT"'))(CONNECT_DATA=(SERVICE_NAME='"$ORACLE_DB_SERVICE"')))",
    "SqlServerConnection": "Server='"$SQL_SERVER_HOST"';Database='"$SQL_SERVER_DB"';User Id='"$SQL_SERVER_USER"';Password='"$SQL_SERVER_PASSWORD"';"
  }
}' > /app/appsettings.json

echo "appsettings.json generated successfully."