using Microsoft.Data.SqlClient;

namespace nwErp.Api.AppDbContext
{
    public class DbSessionTerrazzo : IDisposable
    {
        public IDbConnection Connection { get; }

        public DbSessionTerrazzo(IConfiguration configuration)
        {
            Connection = new SqlConnection(configuration.GetConnectionString("SqlServerConnection"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }

    public class DbSessionWinthor : IDisposable
    {
        public IDbConnection Connection { get; }

        public DbSessionWinthor(IConfiguration configuration)
        {
            Connection = new OracleConnection(configuration.GetConnectionString("OracleDbConnection"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}