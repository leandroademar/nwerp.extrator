namespace nwErp.Api.AppDbContext;

public class DbCommand : IDisposable
  {
    private readonly DbContext _db;
    private OracleCommand _oracleComandoGenerico;
    private OracleCommand _oracleCommandDelete;
    private OracleCommand _oracleCommandInsert;
    private OracleCommand _oracleCommandSelect;
    private OracleCommand _oracleCommandUpdate;
    private string _sqlQueryDelete;
    private string _sqlQueryInsert;
    private string _sqlQuerySelect;
    private string _sqlQueryUpdate;

    public DbCommand(DbContext context) => this._db = context;

    private List<OracleParameter> Parametros { get; set; } = new List<OracleParameter>();

    private string SqlQuery { get; set; }

    public void CriaQueryDelete(string nomeTabela, string filtroDelete)
    {
      if (!string.IsNullOrEmpty(filtroDelete))
        this._sqlQueryDelete = "delete from " + nomeTabela + " WHERE " + filtroDelete + " ";
      if (this._oracleCommandDelete != null)
        return;
      this.CriarComandoPreparar(ref this._oracleCommandDelete, this._sqlQueryDelete);
    }

    public void CriaQueryDinamico(string nomeTabela, string filtroConsulta)
    {
      this.CriaQueryInsert(nomeTabela);
      this.CriaQueryUpdateDinamico(nomeTabela, filtroConsulta);
      this.CriaQueryDelete(nomeTabela, filtroConsulta);
    }

    public void CriaQueryInsert(string nomeTabela)
    {
      if (!string.IsNullOrWhiteSpace(this._sqlQueryInsert))
        return;
      List<OracleParameter> list = this.Parametros.OrderByDescending<OracleParameter, int>((Func<OracleParameter, int>) (x => x.ParameterName.Length)).ToList<OracleParameter>();
      if (list.Count == 0)
        return;
      string str = string.Join(", ", list.Select<OracleParameter, string>((Func<OracleParameter, string>) (x => x.ParameterName)).ToArray<string>());
      this._sqlQueryInsert = "INSERT INTO " + nomeTabela + " (" + str.Replace(":", "") + ") VALUES (" + str + ")";
      this.CriarComandoPreparar(ref this._oracleCommandInsert, this._sqlQueryInsert);
    }

    public void CriaQuerySelect(string nomeTabela, string filtroConsulta = "", string camposSelect = "*")
    {
      if (!string.IsNullOrWhiteSpace(this._sqlQuerySelect))
        return;
      this._sqlQuerySelect = "SELECT " + camposSelect + " FROM " + nomeTabela;
      if (!string.IsNullOrEmpty(filtroConsulta))
        this._sqlQuerySelect = this._sqlQuerySelect + " WHERE " + filtroConsulta;
      this.CriarComandoPreparar(ref this._oracleCommandSelect, this._sqlQuerySelect);
    }

    public void CriaQueryUpdate(string nomeTabela, string camposUpdate, string filtroUpdate)
    {
      if (string.IsNullOrEmpty(camposUpdate) || !camposUpdate.Contains(":") || string.IsNullOrEmpty(filtroUpdate))
        return;
      string query = "UPDATE " + nomeTabela + " SET " + camposUpdate + " WHERE " + filtroUpdate;
      if (this._oracleCommandUpdate != null)
        return;
      this.CriarComandoPreparar(ref this._oracleCommandUpdate, query);
    }

    public void CriaQueryUpdateDinamico(string nomeTabela, string filtroUpdate)
    {
      if (!string.IsNullOrWhiteSpace(this._sqlQueryUpdate) || string.IsNullOrEmpty(filtroUpdate))
        return;
      List<OracleParameter> list = this.Parametros.OrderByDescending<OracleParameter, int>((Func<OracleParameter, int>) (x => x.ParameterName.Length)).ToList<OracleParameter>();
      if (list == null || list.Count == 0)
        return;
      this._sqlQueryUpdate = "UPDATE " + nomeTabela + " SET ";
      List<string> parametrosUpdate = this.ObtemListaDeParametrosUtizadosNaString(filtroUpdate);
      for (int posicao = 0; posicao < parametrosUpdate.Count; posicao++)
        list = list.Where<OracleParameter>((Func<OracleParameter, bool>) (x => !x.ParameterName.ToUpper().Equals(":" + parametrosUpdate[posicao]))).ToList<OracleParameter>();
      foreach (OracleParameter oracleParameter in list)
        this._sqlQueryUpdate += string.Format("{0} = {1}, ", (object) oracleParameter.ToString().Replace(":", ""), (object) oracleParameter);
      this._sqlQueryUpdate = this._sqlQueryUpdate + "WHERE " + filtroUpdate;
      this._sqlQueryUpdate = this._sqlQueryUpdate.Replace(", WHERE", " WHERE");
      if (this._oracleCommandUpdate != null)
        return;
      this.CriarComandoPreparar(ref this._oracleCommandUpdate, this._sqlQueryUpdate);
    }

    public void DefinirQuery(string sqlQuery) => this.SqlQuery = sqlQuery;

    public void SubstituirQuerySQL(string valorAtual, string novoValor)
    {
      this.SqlQuery = this.SqlQuery.Replace(valorAtual, novoValor);
    }

    public string TraduzirQuery()
    {
      string str = this.SqlQuery.ToUpper();
      foreach (OracleParameter oracleParameter in this.Parametros.OrderByDescending<OracleParameter, int>((Func<OracleParameter, int>) (x => x.ParameterName.Length)).ToList<OracleParameter>())
      {
        if (string.IsNullOrEmpty(oracleParameter.Value?.ToString()))
          str = str.Replace(oracleParameter.ParameterName.ToUpper(), "null");
        else if (oracleParameter.Value.ToString().Contains("System.Nullable"))
        {
          str = str.Replace(oracleParameter.ParameterName.ToUpper(), "'" + oracleParameter.Value.ToString() + "'");
        }
        else
        {
          OracleDbType oracleDbType = oracleParameter.OracleDbType;
          if (oracleDbType.Equals((object) OracleDbType.Date))
          {
            str = str.Replace(oracleParameter.ParameterName.ToUpper(), "TO_DATE('" + DateTime.Parse(oracleParameter.Value.ToString()).ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy')");
          }
          else
          {
            oracleDbType = oracleParameter.OracleDbType;
            if (!oracleDbType.Equals((object) OracleDbType.TimeStamp))
            {
              oracleDbType = oracleParameter.OracleDbType;
              if (!oracleDbType.Equals((object) OracleDbType.TimeStampLTZ))
              {
                oracleDbType = oracleParameter.OracleDbType;
                if (!oracleDbType.Equals((object) OracleDbType.TimeStampTZ))
                {
                  oracleDbType = oracleParameter.OracleDbType;
                  if (!oracleDbType.Equals((object) OracleDbType.Varchar2))
                  {
                    oracleDbType = oracleParameter.OracleDbType;
                    if (!oracleDbType.Equals((object) OracleDbType.Char))
                    {
                      oracleDbType = oracleParameter.OracleDbType;
                      if (!oracleDbType.Equals((object) OracleDbType.NChar))
                      {
                        str = str.Replace(oracleParameter.ParameterName.ToUpper(), oracleParameter.Value.ToString().Replace(",", ".") ?? "");
                        continue;
                      }
                    }
                  }
                  str = str.Replace(oracleParameter.ParameterName.ToUpper(), "'" + oracleParameter.Value?.ToString() + "'");
                  continue;
                }
              }
            }
            str = str.Replace(oracleParameter.ParameterName.ToUpper(), "TO_DATE('" + DateTime.Parse(oracleParameter.Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss") + "', 'dd/mm/yyyy hh24:mi:ss')");
          }
        }
      }
      return str;
    }

    private void CriarComandoPreparar(ref OracleCommand comando, string query)
    {
      comando = this._db.ObterComando();
      comando.CommandType = CommandType.Text;
      comando.CommandText = query;
      comando.Prepare();
    }

    private List<string> ObtemListaDeParametrosUtizadosNaString(string comandoOriginal)
    {
      return ((IEnumerable<string>) comandoOriginal.ToUpper().Replace("=", "*").Replace("AND", "*").Replace(" ", "").Replace(":", "*").Split('*')).Where<string>((Func<string, bool>) (x => !string.IsNullOrEmpty(x))).ToList<string>();
    }

    public void AdicionarParametro(
      DbType tipo,
      string parametro,
      ParameterDirection direcao = ParameterDirection.Input,
      int? tamanho = null)
    {
      OracleDbType oracleType = this.ConvertDbTypeToOracleType(tipo);
      OracleParameter oracleParameter = new OracleParameter(parametro, oracleType, direcao);
      if (tamanho.HasValue)
        oracleParameter.Size = tamanho.Value;
      this.Parametros.Add(oracleParameter);
    }

    public void AdicionarParametro(
      DbType tipo,
      string parametro,
      object valor,
      bool ignorarStringVazia = false,
      ParameterDirection direcao = ParameterDirection.Input,
      int? tamanho = null)
    {
      OracleDbType oracleType = this.ConvertDbTypeToOracleType(tipo);
      if (ignorarStringVazia && string.IsNullOrEmpty(valor?.ToString()))
        valor = (object) DBNull.Value;
      OracleParameter oracleParameter1 = new OracleParameter(parametro, oracleType, direcao);
      oracleParameter1.Value = valor ?? (object) DBNull.Value;
      OracleParameter oracleParameter2 = oracleParameter1;
      if (tamanho.HasValue)
        oracleParameter2.Size = tamanho.Value;
      this.Parametros.Add(oracleParameter2);
    }

    public void AdicionarParametroCursor(string parametro, object valor = null)
    {
      OracleParameter oracleParameter = new OracleParameter();
      oracleParameter.OracleDbType = OracleDbType.RefCursor;
      oracleParameter.ParameterName = parametro;
      oracleParameter.Value = valor ?? (object) DBNull.Value;
      oracleParameter.Direction = ParameterDirection.Output;
      this.Parametros.Add(oracleParameter);
    }

    public void AlterarValorParametro(string nomeParametro, object valor)
    {
      OracleParameter oracleParameter = this.Parametros.FirstOrDefault<OracleParameter>((Func<OracleParameter, bool>) (p => p.ParameterName == nomeParametro));
      if (oracleParameter == null)
        return;
      oracleParameter.Value = valor ?? (object) DBNull.Value;
    }

    public void CriaQuery(string sql) => this.SqlQuery = sql;

    public void LimparParametros() => this.Parametros = new List<OracleParameter>();

    public object ObterValorParametro(string nomeParametro)
    {
      return this.Parametros.FirstOrDefault<OracleParameter>((Func<OracleParameter, bool>) (p => p.ParameterName == nomeParametro))?.Value;
    }

    private OracleDbType ConvertDbTypeToOracleType(DbType dbType)
    {
      switch (dbType)
      {
        case DbType.AnsiString:
          return OracleDbType.Varchar2;
        case DbType.Binary:
          return OracleDbType.Blob;
        case DbType.Byte:
          return OracleDbType.Byte;
        case DbType.Boolean:
          return OracleDbType.Boolean;
        case DbType.Currency:
          return OracleDbType.Decimal;
        case DbType.Date:
          return OracleDbType.Date;
        case DbType.DateTime:
          return OracleDbType.TimeStamp;
        case DbType.Decimal:
          return OracleDbType.Decimal;
        case DbType.Double:
          return OracleDbType.Decimal;
        case DbType.Guid:
          return OracleDbType.Raw;
        case DbType.Int16:
          return OracleDbType.Int16;
        case DbType.Int32:
          return OracleDbType.Int32;
        case DbType.Int64:
          return OracleDbType.Int64;
        case DbType.Object:
          return OracleDbType.Clob;
        case DbType.SByte:
          return OracleDbType.Int64;
        case DbType.Single:
          return OracleDbType.Single;
        case DbType.String:
          return OracleDbType.Varchar2;
        case DbType.Time:
          return OracleDbType.IntervalDS;
        case DbType.UInt16:
          return OracleDbType.Int16;
        case DbType.UInt32:
          return OracleDbType.Int32;
        case DbType.UInt64:
          return OracleDbType.Int64;
        case DbType.VarNumeric:
          return OracleDbType.Decimal;
        case DbType.AnsiStringFixedLength:
          return OracleDbType.Char;
        case DbType.StringFixedLength:
          return OracleDbType.NChar;
        case DbType.Xml:
          return OracleDbType.XmlType;
        case DbType.DateTime2:
          return OracleDbType.TimeStamp;
        case DbType.DateTimeOffset:
          return OracleDbType.TimeStampTZ;
        default:
          return OracleDbType.Varchar2;
      }
    }

    public DataTable ExecutarQuery(CommandType tipo = CommandType.Text)
    {
      DataSet dataSet = new DataSet();
      IDbDataAdapter dbDataAdapter = (IDbDataAdapter) new OracleDataAdapter();
      OracleCommand comando = this.ObtenhaComandoUtilizado();
      comando.BindByName = true;
      this.AdicionarParametro(comando);
      dbDataAdapter.SelectCommand = (IDbCommand) comando;
      using (OracleDataReader reader = comando.ExecuteReader())
      {
        DataTable dataTable1 = new DataTable();
        dataTable1.Load((IDataReader) reader);
        dbDataAdapter.Fill(dataSet);
        DataTable dataTable2 = dataSet.Tables.Count > 0 ? dataSet.Tables[0] : new DataTable();
        dataTable1.Dispose();
        dataSet.Dispose();
        return dataTable2;
      }
    }

    public DataTable ExecutarQueryRequisicao(CommandType tipo = CommandType.Text)
    {
      OracleCommand oracleCommand = this.ObtenhaComandoUtilizado();
      oracleCommand.BindByName = true;
      this.AdicionarParametro(oracleCommand);
      OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(oracleCommand);
      DataTable dataTable1 = new DataTable();
      DataTable dataTable2 = dataTable1;
      oracleDataAdapter.Fill(dataTable2);
      return dataTable1;
    }

    public async Task<DataTable> ExecutarQueryAsync(CommandType tipo = CommandType.Text)
    {
      OracleCommand comando = this.ObtenhaComandoUtilizado();
      this.AdicionarParametro(comando);
      DataTable dataTable = new DataTable();
      using (OracleDataReader reader = comando.ExecuteReader(CommandBehavior.Default))
      {
        reader.FetchSize = reader.RowSize * 1000L;
        dataTable.Load((IDataReader) reader);
        reader.Close();
      }
      return dataTable;
    }

    public object ExecutarResultadoUnico(CommandType tipo = CommandType.Text)
    {
      OracleCommand comando = this.ObtenhaComandoUtilizado();
      this.AdicionarParametro(comando);
      return comando.ExecuteScalar();
    }

    public async Task<object> ExecutarResultadoUnicoAsync()
    {
      OracleCommand comando = this.ObtenhaComandoUtilizado();
      this.AdicionarParametro(comando);
      return await comando.ExecuteScalarAsync();
    }

    public void ExecuteComando() => this.ObtenhaComandoUtilizado().ExecuteNonQuery();

    public int ExecuteComandoRetorno() => this.ObtenhaComandoUtilizado().ExecuteNonQuery();

    public async Task ExecuteComandoAsync()
    {
      int num = await this.ObtenhaComandoUtilizado().ExecuteNonQueryAsync();
    }

    public int ExecuteNonQuery(ref OracleCommand comando)
    {
      this.AdicionarParametro(comando);
      int num = comando.ExecuteNonQuery();
      comando.Parameters.Clear();
      return num;
    }

    public async Task<int> ExecuteNonQueryAsync(OracleCommand comando)
    {
      this.AdicionarParametro(comando);
      int num = await comando.ExecuteNonQueryAsync();
      comando.Parameters.Clear();
      return num;
    }

    public int InserirAlterarDeletar()
    {
      OracleCommand comando = this.ObtenhaComandoUtilizado();
      return this.ExecuteNonQuery(ref comando);
    }

    public int DeletarRegistro() => this.ExecuteNonQuery(ref this._oracleCommandDelete);

    public int InserirAlterarDeletarDinamico()
    {
      int num = this.ExecuteNonQuery(ref this._oracleCommandUpdate);
      return num > 0 ? num : this.ExecuteNonQuery(ref this._oracleCommandInsert);
    }

    public async Task<int> InserirAlterarDeletarDinamicoAsync()
    {
      int num = await this.ExecuteNonQueryAsync(this._oracleCommandUpdate);
      return num > 0 ? num : await this.ExecuteNonQueryAsync(this._oracleCommandInsert);
    }

    private void AdicionarParametro(OracleCommand comando)
    {
      if (!this.Parametros.Any<OracleParameter>())
        return;
      comando.Parameters.AddRange((Array) this.Parametros.ToArray());
    }

    private OracleCommand ObtenhaComandoUtilizado()
    {
      if (this._oracleCommandSelect != null)
        return this._oracleCommandSelect;
      if (this._oracleCommandDelete != null)
        return this._oracleCommandDelete;
      if (this._oracleCommandInsert != null)
        return this._oracleCommandInsert;
      if (this._oracleCommandUpdate != null)
        return this._oracleCommandUpdate;
      if (this._oracleComandoGenerico == null)
        this.CriarComandoPreparar(ref this._oracleComandoGenerico, this.SqlQuery);
      return this._oracleComandoGenerico;
    }

    public void Dispose()
    {
      this._oracleComandoGenerico?.Dispose();
      this._oracleCommandDelete?.Dispose();
      this._oracleCommandInsert?.Dispose();
      this._oracleCommandSelect?.Dispose();
      this._oracleCommandUpdate?.Dispose();
    }
  }
