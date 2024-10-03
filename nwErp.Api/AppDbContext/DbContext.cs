using System.Runtime.InteropServices;
using nwErp.Api.Utilidades;


namespace nwErp.Api.AppDbContext;
public class DbContext : IDbContext, IDisposable
  {
    private string _connectionString;
    private OracleConnection _dbConnection;
    private OracleTransaction _dbTransaction;
    private IntPtr nativeResource = Marshal.AllocHGlobal(100);

    public OracleConnection ObtenhaConexao()
    {
      return this._dbTransaction != null ? this._dbConnection : this.ObterConexao(false, false, false);
    }

    public DbContext()
    {
      this._connectionString = "Max Pool Size=300; Min Pool Size=0; Connection Lifetime=60; Connection Timeout=120; Incr Pool Size=1; Decr Pool Size=2; " + AppSettings.Get().GetConnectionString("SqlServerConnection");
    }

    ~DbContext() => this.Dispose(false);

    public string ConnectionString
    {
      get => this._connectionString;
      set
      {
        if (value != this._connectionString)
        {
          this.CloseDbConnection();
          this._dbConnection = (OracleConnection) null;
        }
        this._connectionString = value;
      }
    }

    public void CloseDbConnection()
    {
      this._dbConnection?.Close();
      this._dbConnection?.Dispose();
      this._dbConnection = (OracleConnection) null;
    }

    public IDbTransaction TransactionBegin()
    {
      return (IDbTransaction) this._dbTransaction ?? (IDbTransaction) (this._dbTransaction = this.ObterConexao(false, false, false).BeginTransaction());
    }

    public void TransactionCommit()
    {
      if (this._dbTransaction == null)
        return;
      this._dbTransaction.Commit();
      this._dbTransaction = (OracleTransaction) null;
    }

    public void TransactionRollback()
    {
      if (this._dbTransaction == null)
        return;
      this._dbTransaction.Rollback();
      this._dbTransaction = (OracleTransaction) null;
    }

    protected internal OracleCommand ObterComando()
    {
      OracleCommand command = this.ObterConexao(false, false, false).CreateCommand();
      command.FetchSize *= 64L;
      command.BindByName = true;
      return command;
    }

    public OracleConnection ObterConexao(
      bool tentarReconectar = false,
      bool executarComSystem = false,
      bool recriarConexao = false)
    {
      try
      {
        if (recriarConexao)
          this.RecriarConexao(executarComSystem);
        if (this._dbConnection == null | executarComSystem)
        {
          string str = executarComSystem ? this.ObtenhaStringConexaoSystem() : this.ConnectionString;
          OracleConnection oracleConnection = new OracleConnection();
          oracleConnection.ConnectionString = str;
          this._dbConnection = oracleConnection;
          this._dbConnection.Open();
          this._dbTransaction = (OracleTransaction) null;
        }
        if (this._dbConnection.State != ConnectionState.Open)
          this._dbConnection.Open();
        return this._dbConnection;
      }
      catch (Exception ex)
      {
        Instrumentacao.SalvarLogErro(nameof (ObterConexao), UtilitarioLogger.ObtenhaMessagemParaGravacaoLogError(ex));
        if (!tentarReconectar)
        {
          if (ex.Message.Contains("ORA-01017"))
            this.ObterConexao(true, true, true);
          else
            this.ObterConexao(true, false, true);
        }
      }
      HealthCheck.Incrementar();
      Instrumentacao.SalvarLogErro(nameof (ObterConexao), string.Format("Método retornou nulo ao ser chamado (Falhas {0})", (object) HealthCheck.Get()));
      return (OracleConnection) null;
    }

    public void RecriarConexao(bool executarComSystem = false)
    {
      HealthCheck.Incrementar();
      Instrumentacao.SalvarLogErro(nameof (RecriarConexao), string.Format(" Método RecriarConexao disparado (Falhas {0})", (object) HealthCheck.Get()));
      try
      {
        OracleConnection dbConnection = this._dbConnection;
        if ((dbConnection != null ? (dbConnection.State != 0 ? 1 : 0) : 1) != 0)
          this._dbConnection?.Close();
      }
      catch (Exception ex)
      {
        Instrumentacao.SalvarLogErro(nameof (RecriarConexao), " PT1 Exception: " + UtilitarioLogger.ObtenhaMessagemParaGravacaoLogError(ex));
      }
      finally
      {
        this.CloseDbConnection();
        OracleConnection.ClearPool(this._dbConnection);
      }
      try
      {
        string str = executarComSystem ? this.ObtenhaStringConexaoSystem() : this.ConnectionString;
        OracleConnection oracleConnection = new OracleConnection();
        oracleConnection.ConnectionString = str;
        this._dbConnection = oracleConnection;
        this._dbConnection.Open();
        this._dbTransaction = (OracleTransaction) null;
      }
      catch (Exception ex)
      {
        Instrumentacao.SalvarLogErro(nameof (RecriarConexao), " PT2 Exception: " + UtilitarioLogger.ObtenhaMessagemParaGravacaoLogError(ex));
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this._dbTransaction != null)
          this.TransactionCommit();
        this.CloseDbConnection();
      }
      if (!(this.nativeResource != IntPtr.Zero))
        return;
      Marshal.FreeHGlobal(this.nativeResource);
      this.nativeResource = IntPtr.Zero;
    }

    public DbCommand ObterNovoComando() => new DbCommand(this);

    public DataTable ExecutarQuery(string query)
    {
      using (DbCommand dbCommand = new DbCommand(this))
      {
        dbCommand.DefinirQuery(query);
        return dbCommand.ExecutarQuery();
      }
    }

    public object ExecutarResultadoUnico(string query)
    {
      using (DbCommand dbCommand = new DbCommand(this))
      {
        dbCommand.DefinirQuery(query);
        return dbCommand.ExecutarResultadoUnico();
      }
    }

    public bool IsCurrentlyInTransaction() => this._dbTransaction != null;

    public string GetSchemaName()
    {
      return new OracleConnectionStringBuilder(this.ConnectionString).UserID;
    }

    public DateTime GetDateTime()
    {
      using (OracleCommand oracleCommand = this.ObterComando())
      {
        oracleCommand.CommandText = "SELECT Datetime('Now', 'localtime')";
        return Convert.ToDateTime(oracleCommand.ExecuteScalar());
      }
    }

    public string ObtenhaStringConexaoSystem()
    {
      return "Max Pool Size=5; Min Pool Size=0; Connection Lifetime=1; Connection Timeout=120; Incr Pool Size=1; Decr Pool Size=2; " + AppSettings.Get().GetConnectionString("DefaultConnectionImplantacao");
    }

    public string ObtenhaStringConexaoMaxSolucoes()
    {
      return "Max Pool Size=300; Min Pool Size=0; Connection Lifetime=60; Connection Timeout=120; Incr Pool Size=1; Decr Pool Size=2; " + AppSettings.Get().GetConnectionString("DefaultConnection");
    }

    public void Conectar(ref OracleConnection conexao, bool executarComSystem = false)
    {
      try
      {
        string connectionString = executarComSystem ? this.ObtenhaStringConexaoSystem() : this.ObtenhaStringConexaoMaxSolucoes();
        conexao = new OracleConnection(connectionString);
        conexao.Open();
      }
      catch (Exception ex)
      {
        HealthCheck.Incrementar();
        Instrumentacao.SalvarLogErro(nameof (Conectar), UtilitarioLogger.ObtenhaMensagemLogErro("", ex));
        Instrumentacao.SalvarLogErro("ObterConexao", string.Format("Método retornou nulo ao ser chamado (Falhas {0})", (object) HealthCheck.Get()));
        conexao = (OracleConnection) null;
      }
    }

    public void CriarComando(
      ref OracleConnection conexao,
      ref OracleCommand comando,
      string querySql,
      CommandType tipo = CommandType.Text)
    {
      comando = new OracleCommand();
      try
      {
        if (conexao == null)
          comando = (OracleCommand) null;
        comando.Connection = conexao;
        comando.FetchSize *= 64L;
        comando.BindByName = true;
        comando.CommandType = tipo;
        comando.CommandText = querySql;
      }
      catch (Exception ex)
      {
        Instrumentacao.SalvarLogErro(nameof (CriarComando), UtilitarioLogger.ObtenhaMensagemLogErro("", ex));
        comando = (OracleCommand) null;
      }
    }

    public object ExecuteResultadoUnico(string querySql, bool executarComSystem = false)
    {
      OracleConnection conexao = new OracleConnection();
      OracleCommand comando = new OracleCommand();
      try
      {
        this.Conectar(ref conexao, executarComSystem);
        this.CriarComando(ref conexao, ref comando, querySql);
        return comando?.ExecuteScalar();
      }
      catch (Exception ex)
      {
        Instrumentacao.SalvarLogErro(nameof (ExecuteResultadoUnico), UtilitarioLogger.ObtenhaMensagemLogErro("SQL:" + querySql, ex));
        return (object) null;
      }
      finally
      {
        conexao.Close();
        conexao.Dispose();
        comando.Dispose();
      }
    }

    public bool ExecuteNonQuery(string querySql, bool executarComSystem = false, string pastaLogEspecifica = "")
    {
      OracleConnection conexao = new OracleConnection();
      OracleCommand comando = new OracleCommand();
      try
      {
        this.Conectar(ref conexao, executarComSystem);
        this.CriarComando(ref conexao, ref comando, querySql);
        if (comando == null)
          return false;
        comando.ExecuteNonQuery();
        return true;
      }
      catch (Exception ex)
      {
        if (!comando.CommandText.Contains("TRG_MXS_PCHISTEST") && !comando.CommandText.Contains("TRG_MXS_PCMOVCOMPLE") && !comando.CommandText.Contains("TRG_MXS_PCMXSESTFILIAL") && !comando.CommandText.Contains("TRG_MXS_POSICAO_PEDIDOS"))
          Instrumentacao.SalvarLogErro(string.IsNullOrEmpty(pastaLogEspecifica) ? nameof (ExecuteNonQuery) : pastaLogEspecifica, UtilitarioLogger.ObtenhaMensagemLogErro("SQL:" + querySql, ex));
        return false;
      }
      finally
      {
        conexao.Close();
        conexao.Dispose();
        comando.Dispose();
      }
    }

    public enum ETipoComandoSql
    {
      Consulta = 1,
      Persistencia = 2,
    }
}