namespace nwErp.Api.AppDbContext;

public interface IDbContext : IDisposable
{
    DbCommand ObterNovoComando();

    DataTable ExecutarQuery(string query);

    object ExecutarResultadoUnico(string query);

    DateTime GetDateTime();

    bool IsCurrentlyInTransaction();

    IDbTransaction TransactionBegin();

    void TransactionCommit();

    void TransactionRollback();

    string GetSchemaName();

    OracleConnection ObterConexao(
        bool tentarReconectar = false,
        bool executarComSystem = false,
        bool recriarConexao = false);

    OracleConnection ObtenhaConexao();
}