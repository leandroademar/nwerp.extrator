using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace nwErp.Api.Persistencia.Oracle
{
    public class PersistenciaOracle : IPersistencia, IDisposable
    {
        private string _stringDeConexao = "";

        private static PersistenciaOracle _instancia;

        private DateTime _ultimaDataHora = DateTime.MinValue;

        private static readonly object _lock = new object();

        private Dictionary<Type, DefinicaoDeSQL> _cacheDeSQL = new Dictionary<Type, DefinicaoDeSQL>();

        private Dictionary<Type, DefinicaoDeSQL> _cacheDeDelete = new Dictionary<Type, DefinicaoDeSQL>();

        private Dictionary<Type, PropertyInfo[]> _cacheDePropriedades = new Dictionary<Type, PropertyInfo[]>();

        private LogFaturamento logfat;

        private List<IOberservadorDeExecucao> _observadores;

        private const string separador = "#######################################################################################\n";

        private CultureInfo _cultura;

        private Stack<OracleTransaction> _transacoes;

        private List<IOberservadorDeExecucao> Observadores
        {
            get
            {
                if (_observadores == null)
                {
                    _observadores = new List<IOberservadorDeExecucao>();
                }
                return _observadores;
            }
        }
        

        public DateTime UltimaDataHora
        {
            get
            {
                if (_ultimaDataHora == DateTime.MinValue)
                {
                    return DataHoraAtual();
                }
                return _ultimaDataHora;
            }
        }

        private Stack<OracleTransaction> Transacoes
        {
            get
            {
                if (_transacoes == null)
                {
                    lock (_lock)
                    {
                        if (_transacoes == null)
                        {
                            _transacoes = new Stack<OracleTransaction>();
                        }
                    }
                }
                return _transacoes;
            }
        }

        public bool TransacaoAberta
        {
            get
            {
                if (Transacoes.Count > 0)
                {
                    return Transacoes.Peek().Connection != null;
                }
                return false;
            }
        }

        public bool RegistrarEventos { get; set; }

        public bool ModoDeTrace { get; set; }

        private PersistenciaOracle()
        {
        }

        public void TrabalharRemoto(bool pAtivo)
        {
        }

        private string CriarArgumentoSQLDoParametro(PropertyInfo propriedade, InfoCampoEntidade Atributo)
        {
            if (Atributo.Precisao > 0)
            {
                return $"trunc(:{propriedade.Name}, {Atributo.Precisao})";
            }
            if (Atributo.Tipo == TipoDoCampoNoBancoDeDados.Data && Atributo.TruncarData)
            {
                return $"trunc(:{propriedade.Name})";
            }
            if (Atributo.Tipo == TipoDoCampoNoBancoDeDados.Texto)
            {
                return $"substr(:{propriedade.Name}, 1, {Atributo.Tamanho})";
            }
            return $":{propriedade.Name}";
        }

        private void Alterar(OracleCommand command, IEntidade entidade)
        {
            StringBuilder stringBuilder = new StringBuilder("UPDATE ");
            stringBuilder.Append(entidade.ObterNomeTabela());
            stringBuilder.Append(" SET ");
            bool flag = false;
            PropertyInfo[] propriedadesModificadas = entidade.PropriedadesModificadas;
            foreach (PropertyInfo propertyInfo in propriedadesModificadas)
            {
                InfoCampoEntidade infoCampoEntidade = AtributoCampo(propertyInfo);
                if (infoCampoEntidade != null && !infoCampoEntidade.ChavePrimaria)
                {
                    if (flag)
                    {
                        stringBuilder.Append(" , ");
                    }
                    if (DefinirParametros(propertyInfo, infoCampoEntidade, command, entidade))
                    {
                        flag = true;
                        stringBuilder.Append($"{propertyInfo.Name} = {CriarArgumentoSQLDoParametro(propertyInfo, infoCampoEntidade)}");
                    }
                }
            }
            if (string.IsNullOrEmpty(entidade.IdentificacaoDoRegistro))
            {
                StringBuilder stringBuilder2 = new StringBuilder();
                propriedadesModificadas = ObterTipoDaEntidade(entidade.GetType()).GetProperties();
                foreach (PropertyInfo propertyInfo2 in propriedadesModificadas)
                {
                    InfoCampoEntidade infoCampoEntidade2 = AtributoCampo(propertyInfo2);
                    if (infoCampoEntidade2 != null && infoCampoEntidade2.ChavePrimaria && DefinirParametros(propertyInfo2, infoCampoEntidade2, command, entidade))
                    {
                        stringBuilder2.Append(string.Format(" AND {0} = :{0}", propertyInfo2.Name));
                    }
                }
                if (!flag)
                {
                    stringBuilder.Append(stringBuilder2.ToString().Replace("AND", ",").Substring(2));
                }
                ((DbCommand)(object)command).CommandText = $"{stringBuilder.ToString()} WHERE 1 = 1 {stringBuilder2.ToString()} ";
            }
            else
            {
                ((DbCommand)(object)command).CommandText = stringBuilder.ToString() + $" WHERE ROWID = '{entidade.IdentificacaoDoRegistro}'";
            }
        }

        private void Carregar(OracleCommand command, IEntidade entidade, bool todosOsRegistros)
        {
            Carregar(command, entidade, null, todosOsRegistros);
        }

        private void Carregar(OracleCommand command, IEntidade entidade, PropertyInfo[] camposDeSelecao, bool todosOsRegistros)
        {
            bool flag = camposDeSelecao == null;
            Type key = ObterTipoDaEntidade(entidade.GetType());
            if (flag && _cacheDeSQL.ContainsKey(key))
            {
                DefinirSQLPeloCache(command, entidade, _cacheDeSQL[key], todosOsRegistros);
                return;
            }
            DefinicaoDeSQL definicaoDeSQL = null;
            bool flag2 = flag && !_cacheDeSQL.ContainsKey(key);
            if (flag)
            {
                camposDeSelecao = ObterTipoDaEntidade(entidade.GetType()).GetProperties().ToArray();
            }
            if (flag2)
            {
                definicaoDeSQL = new DefinicaoDeSQL();
            }
            StringBuilder stringBuilder = new StringBuilder("SELECT ");
            StringBuilder stringBuilder2 = new StringBuilder(" WHERE 1 = 1 ");
            byte b = 0;
            PropertyInfo[] array = camposDeSelecao;
            foreach (PropertyInfo propertyInfo in array)
            {
                InfoCampoEntidade infoCampoEntidade = AtributoCampo(propertyInfo);
                if (infoCampoEntidade == null)
                {
                    continue;
                }
                if (b > 0)
                {
                    stringBuilder.Append(",");
                    stringBuilder.Append(propertyInfo.Name);
                }
                else
                {
                    stringBuilder.Append(propertyInfo.Name);
                    b++;
                }
                if (infoCampoEntidade.ChavePrimaria)
                {
                    if (flag2)
                    {
                        definicaoDeSQL.Parametros.Add(new DefinicaoDeParametro
                        {
                            Propriedade = propertyInfo,
                            Atributo = infoCampoEntidade
                        });
                    }
                    else if (!todosOsRegistros)
                    {
                        DefinirParametros(propertyInfo, infoCampoEntidade, command, entidade);
                    }
                    stringBuilder2.Append(string.Format(" AND {0} = :{0}", propertyInfo.Name));
                }
            }
            stringBuilder.Append(", ROWID ");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append(entidade.ObterNomeTabela());
            if (flag2)
            {
                definicaoDeSQL.SQL = stringBuilder.ToString();
                definicaoDeSQL.Where = stringBuilder2.ToString();
                _cacheDeSQL.Add(key, definicaoDeSQL);
                DefinirSQLPeloCache(command, entidade, _cacheDeSQL[key], todosOsRegistros);
            }
            else if (!todosOsRegistros)
            {
                if (!string.IsNullOrEmpty(entidade.IdentificacaoDoRegistro))
                {
                    ((DbCommand)(object)command).CommandText = stringBuilder.ToString();
                    ((DbCommand)(object)command).CommandText += $" WHERE ROWID = '{entidade.IdentificacaoDoRegistro}'";
                }
                else
                {
                    ((DbCommand)(object)command).CommandText = stringBuilder.ToString() + stringBuilder2.ToString();
                }
            }
            else
            {
                ((DbCommand)(object)command).CommandText = stringBuilder.ToString() + " WHERE 1 = 1 ";
            }
        }

        private void DefinirSQLPeloCache(OracleCommand command, IEntidade entidade, DefinicaoDeSQL sql)
        {
            DefinirSQLPeloCache(command, entidade, sql, todosOsRegistros: false);
        }

        private void DefinirSQLPeloCache(OracleCommand command, IEntidade entidade, DefinicaoDeSQL sql, bool todosOsRegistros)
        {
            ((DbCommand)(object)command).CommandText = string.Empty;
            ((DbParameterCollection)(object)command.Parameters).Clear();
            if (todosOsRegistros)
            {
                ((DbCommand)(object)command).CommandText = sql.SQL + " WHERE 1 = 1 ";
                return;
            }
            if (!string.IsNullOrEmpty(entidade.IdentificacaoDoRegistro))
            {
                ((DbCommand)(object)command).CommandText = sql.SQL;
                ((DbCommand)(object)command).CommandText += $" WHERE ROWID = '{entidade.IdentificacaoDoRegistro}'";
                return;
            }
            foreach (DefinicaoDeParametro parametro in sql.Parametros)
            {
                DefinirParametros(parametro.Propriedade, parametro.Atributo, command, entidade);
            }
            ((DbCommand)(object)command).CommandText = sql.SQL + sql.Where;
        }

        private Type ObterTipoDaEntidade(Type tipoBase)
        {
            return tipoBase;
        }

        private bool DefinirParametros(PropertyInfo propriedade, InfoCampoEntidade atributo, OracleCommand command, IEntidade entidade)
        {
            return DefinirParametros(propriedade, atributo, command, entidade, null);
        }

        private bool DefinirParametros(PropertyInfo propriedade, InfoCampoEntidade atributo, OracleCommand command, IEntidade entidade, string nomeDoParametro)
        {
            object value = propriedade.GetValue(entidade, null);
            string text = $":{propriedade.Name}";
            switch (atributo.Tipo)
            {
                case TipoDoCampoNoBancoDeDados.Decimal:
                case TipoDoCampoNoBancoDeDados.Inteiro:
                    ((DbParameter)(object)command.Parameters.Add(text, (OracleDbType)107)).Value = value;
                    return true;
                case TipoDoCampoNoBancoDeDados.Texto:
                    ((DbParameter)(object)command.Parameters.Add(text, (OracleDbType)126)).Value = (value ?? "").ToString();
                    return true;
                case TipoDoCampoNoBancoDeDados.Binario:
                    ((DbParameter)(object)command.Parameters.Add(text, (OracleDbType)105)).Value = ((value == null) ? value : value.ToString());
                    return true;
                case TipoDoCampoNoBancoDeDados.Data:
                    ((DbParameter)(object)command.Parameters.Add(text, (OracleDbType)106)).Value = ((value == null) ? ((object)DateTime.MinValue) : value);
                    return true;
                default:
                    command.Parameters.Add(text, ChangeType(value, propriedade.PropertyType));
                    return true;
            }
        }

        private void Deletar(OracleCommand command, IEntidade entidade)
        {
            ObterTipoDaEntidade(entidade.GetType());
            DefinicaoDeSQL definicaoDeSQL = new DefinicaoDeSQL();
            StringBuilder stringBuilder = new StringBuilder("DELETE FROM ");
            stringBuilder.Append(entidade.ObterNomeTabela());
            stringBuilder.Append(" WHERE 1 = 1 ");
            PropertyInfo[] properties = ObterTipoDaEntidade(entidade.GetType()).GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                InfoCampoEntidade infoCampoEntidade = AtributoCampo(propertyInfo);
                if (infoCampoEntidade != null && infoCampoEntidade.ChavePrimaria && DefinirParametros(propertyInfo, infoCampoEntidade, command, entidade))
                {
                    definicaoDeSQL.Parametros.Add(new DefinicaoDeParametro
                    {
                        Propriedade = propertyInfo,
                        Atributo = infoCampoEntidade
                    });
                    stringBuilder.Append(string.Format(" AND {0} = :{0}", propertyInfo.Name));
                }
            }
            ((DbCommand)(object)command).CommandText = stringBuilder.ToString();
            definicaoDeSQL.SQL = ((DbCommand)(object)command).CommandText;
        }

        private void Incluir(OracleCommand command, IEntidade entidade)
        {
            StringBuilder stringBuilder = new StringBuilder("INSERT INTO  ");
            StringBuilder stringBuilder2 = new StringBuilder();
            stringBuilder.Append(entidade.ObterNomeTabela());
            stringBuilder.Append(" (");
            PropertyInfo[] properties = ObterTipoDaEntidade(entidade.GetType()).GetProperties();
            foreach (PropertyInfo propriedade in properties)
            {
                InfoCampoEntidade infoCampoEntidade = AtributoCampo(propriedade);
                if (infoCampoEntidade != null && (infoCampoEntidade.ChavePrimaria || ((!propriedade.PropertyType.IsGenericType || !(propriedade.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))) && (!(propriedade.PropertyType.Name == typeof(string).Name) || (propriedade.GetValue(entidade, null) != null && !(propriedade.GetValue(entidade, null).ToString() == string.Empty)))) || entidade.PropriedadesModificadas.Where((PropertyInfo prop) => prop.Name == propriedade.Name).Count() > 0))
                {
                    if (stringBuilder2.Length > 0)
                    {
                        stringBuilder.Append(" , ");
                        stringBuilder2.Append(" , ");
                    }
                    if (DefinirParametros(propriedade, infoCampoEntidade, command, entidade))
                    {
                        stringBuilder.Append(propriedade.Name);
                        stringBuilder2.Append(CriarArgumentoSQLDoParametro(propriedade, infoCampoEntidade));
                    }
                }
            }
            stringBuilder.Append(" ) VALUES (");
            stringBuilder2.Append(" )");
            ((DbCommand)(object)command).CommandText = stringBuilder.ToString() + stringBuilder2.ToString();
        }

        private void PopularEntidade(OracleDataReader reader, IEntidade entidade, PropertyInfo[] camposDeSelecao)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (RegistrarEventos)
            {
                stopwatch.Start();
            }
            try
            {
                entidade.PosicaoEntidade = PosicaoEntidade.Persistindo;
                PropertyInfo[] array = camposDeSelecao;
                foreach (PropertyInfo propertyInfo in array)
                {
                    object obj = ((DbDataReader)(object)reader)[propertyInfo.Name];
                    if (obj.GetType() != typeof(DBNull))
                    {
                        AplicarValorAoObjeto(obj, entidade, propertyInfo);
                    }
                }
            }
            finally
            {
                if (camposDeSelecao.Count() > 0)
                {
                    entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                }
                if (RegistrarEventos)
                {
                    stopwatch.Stop();
                    NotificarOberservadoresDeExecucao($"\nEntidade {entidade.ObterNomeTabela()} populada em {stopwatch.Elapsed.ToString()}\n\n");
                }
            }
        }

        private InfoCampoEntidade AtributoCampo(PropertyInfo propriedade)
        {
            if (propriedade.IsDefined(typeof(InfoCampoEntidade), inherit: true))
            {
                return (InfoCampoEntidade)propriedade.GetCustomAttributes(typeof(InfoCampoEntidade), inherit: true)[0];
            }
            return null;
        }

        private bool Deletar(IEntidade entidade)
        {
            bool flag = false;
            string text = string.Empty;
            if (entidade.PosicaoEntidade == PosicaoEntidade.Carregada || entidade.PosicaoEntidade == PosicaoEntidade.Alterada)
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    OracleCommand val2 = val.CreateCommand();
                    try
                    {
                        Deletar(val2, entidade);
                        text = ((DbCommand)(object)val2).CommandText;
                        flag = ExecutarSQLNonQuery(val2, entidade) > 0;
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Random random = new Random();
                    logfat = new LogFaturamento(random.Next().ToString(), TipoLogFaturamento.Persistencia);
                    logfat.Adicionar($"Erro na execução do comando: {text}{Environment.NewLine}{ex.Message}{Environment.NewLine}");
                    throw ex;
                }
                finally
                {
                    FecharConexao(val);
                }
                if (flag)
                {
                    entidade.PosicaoEntidade = PosicaoEntidade.Excluida;
                }
            }
            return flag;
        }

        private void FecharConexao(OracleConnection conexao)
        {
            if (!TransacaoAberta)
            {
                ((DbConnection)(object)conexao).Close();
                ((Component)(object)conexao).Dispose();
            }
        }

        private bool Incluir(IEntidade entidade)
        {
            bool flag = false;
            string text = string.Empty;
            if (entidade.PosicaoEntidade == PosicaoEntidade.Nova || entidade.PosicaoEntidade == PosicaoEntidade.Excluida)
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    OracleCommand val2 = val.CreateCommand();
                    try
                    {
                        Incluir(val2, entidade);
                        text = ((DbCommand)(object)val2).CommandText;
                        flag = ExecutarSQLNonQuery(val2, entidade) > 0;
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Random random = new Random();
                    logfat = new LogFaturamento(random.Next().ToString(), TipoLogFaturamento.Persistencia);
                    logfat.Adicionar($"Erro na execução do comando: {text}{Environment.NewLine}{ex.Message}{Environment.NewLine}");
                    throw ex;
                }
                finally
                {
                    FecharConexao(val);
                }
                if (flag)
                {
                    entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                }
            }
            return flag;
        }

        private bool Alterar(IEntidade entidade)
        {
            bool flag = false;
            string text = string.Empty;
            if (entidade.PosicaoEntidade == PosicaoEntidade.Alterada)
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    OracleCommand val2 = val.CreateCommand();
                    try
                    {
                        Alterar(val2, entidade);
                        text = ((DbCommand)(object)val2).CommandText;
                        flag = ExecutarSQLNonQuery(val2, entidade) > 0;
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Random random = new Random();
                    logfat = new LogFaturamento(random.Next().ToString(), TipoLogFaturamento.Persistencia);
                    logfat.Adicionar($"Erro na execução do comando: {text}{Environment.NewLine}{ex.Message}{Environment.NewLine}");
                    throw ex;
                }
                finally
                {
                    FecharConexao(val);
                }
                if (flag)
                {
                    entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                }
            }
            return flag;
        }

        private void PopularVisao(OracleDataReader reader, IVisao visao, PropertyInfo[] propriedades)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (RegistrarEventos)
            {
                stopwatch.Start();
            }
            foreach (PropertyInfo propertyInfo in propriedades)
            {
                object obj = ((DbDataReader)(object)reader)[propertyInfo.Name];
                if (obj.GetType() != typeof(DBNull))
                {
                    AplicarValorAoObjeto(obj, visao, propertyInfo);
                }
            }
            if (RegistrarEventos)
            {
                stopwatch.Stop();
                NotificarOberservadoresDeExecucao($"\nVisao {visao.GetType().Name} populada em {stopwatch.Elapsed.ToString()}\n\n");
            }
        }

        private static object ChangeType(object value, Type conversionType)
        {
            if (conversionType == null)
            {
                throw new ArgumentNullException("conversionType");
            }
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }
                conversionType = new NullableConverter(conversionType).UnderlyingType;
            }
            return Convert.ChangeType(value, conversionType);
        }

        private static void AplicarValorAoObjeto(object valor, object obj, PropertyInfo propriedade)
        {
            propriedade.SetValue(obj, ChangeType(valor, propriedade.PropertyType), null);
        }

        private OracleConnection CriarNovaConexao()
        {
            return CriarNovaConexao(novaTransacao: false);
        }

        private OracleConnection CriarNovaConexao(bool novaTransacao)
        {
            //IL_0024: Unknown result type (might be due to invalid IL or missing references)
            //IL_002a: Expected O, but got Unknown
            OracleConnection val;
            if (TransacaoAberta && !novaTransacao)
            {
                val = Transacoes.Peek().Connection;
            }
            else
            {
                val = new OracleConnection(_stringDeConexao);
                AplicarPadroesCulturais(val);
                RegistrarInformacoesDaAplicacao(val);
            }
            return val;
        }

        private PersistenciaOracle(string stringDeConexao)
        {
            _stringDeConexao = stringDeConexao;
        }

        public static IPersistencia Instancia(string stringDeConexao)
        {
            if (_instancia == null)
            {
                _instancia = new PersistenciaOracle(stringDeConexao);
            }
            return _instancia;
        }

        public static IPersistencia NovaInstancia(string stringDeConexao)
        {
            return new PersistenciaOracle(stringDeConexao);
        }

        public List<T> CarregarLista<T>(T entidade, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            return CarregarLista(entidade, 0, null, filtros);
        }

        public List<T> CarregarLista<T>(T entidade, int quantidadeDeRegistros, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            return CarregarLista(entidade, quantidadeDeRegistros, null, filtros);
        }

        public List<T> CarregarLista<T>(T entidade, Expression<Func<T, object>> camposDeSelecao, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            return CarregarLista(entidade, 0, camposDeSelecao, filtros);
        }

        public List<T> CarregarLista<T>(T entidade, int quantidadeDeRegistros, Expression<Func<T, object>> campos, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            List<T> list = new List<T>();
            PropertyInfo[] array = ObterPropriedadesDoCache(entidade);
            if (campos != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                TratamentoDeExpressao.TratarExpressao(campos, stringBuilder);
                if (stringBuilder.Length > 0)
                {
                    string[] nomesDasPropriedades = stringBuilder.ToString().Split(',');
                    array = array.Where((PropertyInfo propriedade) => nomesDasPropriedades.Contains(propriedade.Name)).ToArray();
                }
            }
            OracleConnection val = CriarNovaConexao();
            string text = string.Empty;
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    Carregar(val2, entidade, array, todosOsRegistros: true);
                    if (quantidadeDeRegistros > 0)
                    {
                        ((DbCommand)(object)val2).CommandText = $"{((DbCommand)(object)val2).CommandText} and rownum < {quantidadeDeRegistros + 1} ";
                    }
                    if (filtros != null)
                    {
                        ((DbCommand)(object)val2).CommandText += TratarFiltros(filtros);
                    }
                    text = ((DbCommand)(object)val2).CommandText;
                    OracleDataReader val3 = ExecutarSQLReader(val2, entidade);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            while (((DbDataReader)(object)val3).Read())
                            {
                                T val4 = new T();
                                if (campos == null)
                                {
                                    val4.CarregarPorDataReader((IDataReader)val3);
                                    val4.PosicaoEntidade = PosicaoEntidade.Carregada;
                                }
                                else
                                {
                                    PopularEntidade(val3, val4, array);
                                    val4.PosicaoEntidade = PosicaoEntidade.CarregadaParcialmente;
                                }
                                ref T reference = ref val4;
                                T val5 = default(T);
                                if (val5 == null)
                                {
                                    val5 = reference;
                                    reference = ref val5;
                                }
                                reference.IdentificacaoDoRegistro = ((DbDataReader)(object)val3)["ROWID"].ToString();
                                list.Add(val4);
                            }
                        }
                        ((DbDataReader)(object)val3).Close();
                        return list;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            catch (Exception ex)
            {
                Random random = new Random();
                logfat = new LogFaturamento(random.Next().ToString(), TipoLogFaturamento.Persistencia);
                logfat.Adicionar($"Erro na execução do comando: {text}{Environment.NewLine}{ex.Message}{Environment.NewLine}");
                throw ex;
            }
            finally
            {
                FecharConexao(val);
            }
        }

        private PropertyInfo[] ObterPropriedadesDoCache(IEntidade entidade)
        {
            Type key = ObterTipoDaEntidade(entidade.GetType());
            PropertyInfo[] array = null;
            if (_cacheDePropriedades.ContainsKey(key))
            {
                return _cacheDePropriedades[key];
            }
            array = (from propriedade in ObterTipoDaEntidade(entidade.GetType()).GetProperties()
                     where propriedade.IsDefined(typeof(InfoCampoEntidade), inherit: true)
                     select propriedade).ToArray();
            _cacheDePropriedades.Add(key, array);
            return array;
        }

        public bool RegistrarOberservadorDeExecucao(IOberservadorDeExecucao observador)
        {
            //IL_0019: Unknown result type (might be due to invalid IL or missing references)
            //IL_0023: Expected O, but got Unknown
            OracleConnection val = CriarNovaConexao(novaTransacao: false);
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    observador.RegistrarComando((IDbCommand)val2, (IDataAdapter)new OracleDataAdapter(val2));
                    Observadores.Add(observador);
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
            return true;
        }

        private void DefinirTransacao(OracleCommand comando)
        {

        }

        public bool RemoverOberservadorDeExecucao(IOberservadorDeExecucao observador)
        {
            if (Observadores.Contains(observador))
            {
                Observadores.Remove(observador);
                return true;
            }
            return false;
        }

        private void NotificarOberservadoresDeExecucao(string registro)
        {
            if (!RegistrarEventos)
            {
                return;
            }
            foreach (IOberservadorDeExecucao observadore in Observadores)
            {
                observadore.Registrar(registro);
            }
        }

        private void RegistrarSQL(OracleCommand comandoExecucao)
        {
            //IL_003d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0044: Expected O, but got Unknown
            if (!RegistrarEventos)
            {
                return;
            }
            NotificarOberservadoresDeExecucao("#######################################################################################\n");
            StringBuilder stringBuilder = new StringBuilder();
            string text = ((DbCommand)(object)comandoExecucao).CommandText;
            List<OracleParameter> list = new List<OracleParameter>();
            foreach (OracleParameter item2 in (DbParameterCollection)(object)comandoExecucao.Parameters)
            {
                OracleParameter item = item2;
                list.Add(item);
            }
            foreach (OracleParameter item3 in list.OrderByDescending((OracleParameter param) => ((DbParameter)(object)param).ParameterName.Length))
            {
                string empty = string.Empty;
                text = text.Replace(newValue: (!(((DbParameter)(object)item3).Value is DateTime) && !(((DbParameter)(object)item3).Value is string)) ? ((DbParameter)(object)item3).Value.ToString().Replace(',', '.') : $"'{((DbParameter)(object)item3).Value.ToString()}'", oldValue: ((DbParameter)(object)item3).ParameterName);
            }
            stringBuilder.AppendLine(text);
            stringBuilder.AppendLine();
            NotificarOberservadoresDeExecucao(stringBuilder.ToString());
        }

        private void RegistrarTempo(Stopwatch tempo)
        {
            tempo.Stop();
            StringBuilder stringBuilder = new StringBuilder(Environment.NewLine);
            stringBuilder.AppendLine($"Instrução executada em {tempo.Elapsed.ToString()}");
            stringBuilder.AppendLine("#######################################################################################\n" + Environment.NewLine);
            NotificarOberservadoresDeExecucao(stringBuilder.ToString());
        }

        private void RegistrarExcessao(Exception erro)
        {
            if (RegistrarEventos)
            {
                StringBuilder stringBuilder = new StringBuilder(Environment.NewLine);
                stringBuilder.AppendLine($"Erro ao tentar executar a instrução!\nErro:\n{erro.Message}");
                stringBuilder.AppendLine("#######################################################################################\n" + Environment.NewLine);
                NotificarOberservadoresDeExecucao(stringBuilder.ToString());
            }
        }

        private OracleDataReader ExecutarSQLReader(OracleCommand comandoExecucao, IEntidade entidade)
        {
            try
            {
                DefinirTransacao(comandoExecucao);
                if (RegistrarEventos)
                {
                    RegistrarSQL(comandoExecucao);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    OracleDataReader result = comandoExecucao.ExecuteReader();
                    RegistrarTempo(stopwatch);
                    return result;
                }
                return comandoExecucao.ExecuteReader();
            }
            catch (Exception ex)
            {
                RegistrarExcessao(ex);
                throw TratarExcessao(ex, entidade);
            }
        }

        private int ExecutarSQLNonQuery(OracleCommand comandoExecucao, IEntidade entidade)
        {
            try
            {
                DefinirTransacao(comandoExecucao);
                if (RegistrarEventos)
                {
                    RegistrarSQL(comandoExecucao);
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    int result = ((DbCommand)(object)comandoExecucao).ExecuteNonQuery();
                    RegistrarTempo(stopwatch);
                    return result;
                }
                return ((DbCommand)(object)comandoExecucao).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                RegistrarExcessao(ex);
                throw TratarExcessao(ex, entidade);
            }
        }

        private Exception TratarExcessao(Exception excessao, IEntidade entidade)
        {
            //IL_0014: Unknown result type (might be due to invalid IL or missing references)
            //IL_001a: Expected O, but got Unknown
            Exception result = excessao;
            StringBuilder stringBuilder = new StringBuilder();
            if (excessao is OracleException)
            {
                OracleException val = (OracleException)excessao;
                stringBuilder.AppendLine("Ocorreu uma exceção ao fazer uso do banco de dados.");
                stringBuilder.AppendLine();
                switch (val.Number)
                {
                    case 1:
                        if (((Exception)(object)val).Message.ToUpper().Contains("PCPEDC_PK"))
                        {
                            stringBuilder.AppendLine("O númerador máximo de pedido foi atingido para o RCA!").AppendLine("É necessário parametrizar os numeradores do RCA na rotina 517.").AppendLine("Os cupons fiscais deste PDV não serão mais processados até que os numeradores sejam corrigidos.")
                                .AppendLine()
                                .AppendLine("Após a correção dos numeradores os arquivos devem ser reprocessados.");
                        }
                        else
                        {
                            stringBuilder.AppendLine("Violação de chave primária! ");
                        }
                        break;
                    case 904:
                        stringBuilder.AppendLine("Acesse o Gerenciador de Carga na área de trabalho e atualize as estruturas do banco.");
                        stringBuilder.AppendLine("Para mais detalhes acessa nossa central de apoio no seguinte link: https://tdn.totvs.com/pages/releaseview.action?pageId=173082376");
                        if (entidade != null)
                        {
                            stringBuilder.AppendLine($"Campo de tabela inválido! Campo: \"{entidade.ObterNomeTabela()} . {((Exception)(object)val).Message.Split('"')[1]}\"");
                        }
                        else
                        {
                            stringBuilder.AppendLine($"Campo de tabela inválido! Campo: \"{((Exception)(object)val).Message.Split('"')[1]}\"");
                        }
                        break;
                    case 54:
                        stringBuilder.AppendLine("Não foi possível bloquear o(s) registro(s) no banco de dados. O recurso está ocupado!");
                        break;
                    case 907:
                        stringBuilder.AppendLine("Parêntese direito ausente! ");
                        break;
                    case 920:
                        stringBuilder.AppendLine("Operador relacional inválido! ");
                        break;
                    case 933:
                        stringBuilder.AppendLine("Instrução SQL não finalizada corretamente! ");
                        break;
                    case 936:
                        stringBuilder.AppendLine("Expressão inválida ou ausente! ");
                        break;
                    case 1034:
                        stringBuilder.AppendLine("Banco de dados indisponível! ");
                        break;
                    case 1017:
                        stringBuilder.AppendLine("Senha inválida ou usuário inexistente para conexão com o banco de dados! Conexão negada! ");
                        break;
                    case 12154:
                        stringBuilder.AppendLine("Não foi possível resolver o identificador de conexão especificado!");
                        break;
                    case 12170:
                        stringBuilder.AppendLine("O tempo limite para conexão com o banco de dados foi esgotado! ");
                        break;
                    case 12537:
                        stringBuilder.AppendLine("A conexão com o banco de dados foi encerrada! ");
                        break;
                    case 4098:
                        stringBuilder.AppendLine($"Trigger \"{((Exception)(object)val).Message.Split('\'')[1]}\" inválida e houve falha na tentativa de ativa-la novamente!");
                        break;
                    case 1438:
                        try
                        {
                            if (entidade == null)
                            {
                                stringBuilder.AppendLine($"Campo de tabela inválido! OracleError: 1438");
                                break;
                            }
                            stringBuilder.AppendLine($"TABELA: {entidade.ObterNomeTabela().FirstOrDefault()}");
                            stringBuilder.AppendLine("");
                            stringBuilder.AppendLine("CAMPOS / VALORES");
                            stringBuilder.AppendLine("");
                            PropertyInfo[] properties = entidade.GetType().GetProperties();
                            foreach (PropertyInfo propertyInfo in properties)
                            {
                                if (propertyInfo.Name != "PropriedadesModificadas" && propertyInfo.Name != "IdentificacaoDoRegistro" && propertyInfo.Name != "PosicaoEntidade")
                                {
                                    stringBuilder.AppendLine(propertyInfo.Name + " =  " + propertyInfo.GetValue(entidade, null));
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    default:
                        stringBuilder.AppendLine("Erro não identificado de banco de dados!");
                        break;
                }
                stringBuilder.AppendLine().AppendLine("Detalhes:").AppendLine(excessao.Message);
            }
            if (stringBuilder.Length > 0)
            {
                result = new Exception(stringBuilder.ToString(), excessao);
            }
            return result;
        }

        private string TratarFiltros<T>(Expression<Func<T, bool>>[] filtros)
        {
            Stopwatch stopwatch = new Stopwatch();
            if (RegistrarEventos)
            {
                stopwatch.Start();
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Expression expression in filtros)
            {
                if (expression != null)
                {
                    stringBuilder.AppendLine(" and (");
                    TratamentoDeExpressao.TratarExpressao(expression, stringBuilder);
                    stringBuilder.Append(")");
                }
            }
            return stringBuilder.ToString().Replace("IdentificacaoDoRegistro", "ROWID");
        }

        public bool CarregarVisao<T>(IVisao visao, params Expression<Func<T, bool>>[] filtros) where T : IVisao, new()
        {
            bool result = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = visao.SQLConsulta();
                    if (filtros != null)
                    {
                        ((DbCommand)(object)val2).CommandText += TratarFiltros(filtros);
                    }
                    OracleDataReader val3 = ExecutarSQLReader(val2, null);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            PropertyInfo[] propriedades = (from propriedade in typeof(T).GetProperties()
                                                           where propriedade.IsDefined(typeof(InfoCampoVisao), inherit: true)
                                                           select propriedade).ToArray();
                            ((DbDataReader)(object)val3).Read();
                            PopularVisao(val3, visao, propriedades);
                            result = true;
                        }
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
            return result;
        }

        public List<T> CarregarListaVisao<T>(T visao, params Expression<Func<T, bool>>[] filtros) where T : IVisao, new()
        {
            List<T> list = new List<T>();
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = visao.SQLConsulta();
                    if (filtros != null)
                    {
                        ((DbCommand)(object)val2).CommandText += TratarFiltros(filtros);
                    }
                    OracleDataReader val3 = ExecutarSQLReader(val2, null);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            PropertyInfo[] propriedades = (from propriedade in visao.GetType().GetProperties()
                                                           where propriedade.IsDefined(typeof(InfoCampoVisao), inherit: true)
                                                           select propriedade).ToArray();
                            while (((DbDataReader)(object)val3).Read())
                            {
                                object obj = visao.NovaInstancia();
                                PopularVisao(val3, (IVisao)obj, propriedades);
                                list.Add((T)obj);
                            }
                        }
                        ((DbDataReader)(object)val3).Close();
                        return list;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public bool Persistir(TipoPersistencia tipo, IEntidade entidade)
        {
            switch (tipo)
            {
                case TipoPersistencia.INCLUIR:
                    return Incluir(entidade);
                case TipoPersistencia.ALTERAR:
                    return Alterar(entidade);
                case TipoPersistencia.DELETAR:
                    return Deletar(entidade);
                case TipoPersistencia.CARREGAR:
                case TipoPersistencia.RECARREGAR:
                    return Carregar(entidade);
                default:
                    return false;
            }
        }

        private bool Carregar(IEntidade entidade)
        {
            bool result = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    Carregar(val2, entidade, todosOsRegistros: false);
                    OracleDataReader val3 = ExecutarSQLReader(val2, entidade);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            ((DbDataReader)(object)val3).Read();
                            entidade.CarregarPorDataReader((IDataReader)val3);
                            entidade.IdentificacaoDoRegistro = ((DbDataReader)(object)val3)["ROWID"].ToString();
                            entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                            result = true;
                        }
                        ((DbDataReader)(object)val3).Close();
                        return result;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public bool CarregarEntidade(IEntidade entidade, bool travarRegistro)
        {
            bool result = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    Carregar(val2, entidade, todosOsRegistros: false);
                    if (travarRegistro)
                    {
                        ((DbCommand)(object)val2).CommandText += " FOR UPDATE ";
                    }
                    OracleDataReader val3 = ExecutarSQLReader(val2, entidade);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows && ((DbDataReader)(object)val3).Read())
                        {
                            entidade.CarregarPorDataReader((IDataReader)val3);
                            entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                            result = true;
                        }
                        ((DbDataReader)(object)val3).Close();
                        return result;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public bool CarregarEntidade(IEntidade entidade)
        {
            return Persistir(TipoPersistencia.CARREGAR, entidade);
        }

        public bool CarregarEntidadeParcialmente<T>(IEntidade entidade, Expression<Func<T, object>> campos) where T : IEntidade, new()
        {
            bool result = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    PropertyInfo[] array = ObterPropriedadesDoCache(entidade);
                    if (campos != null)
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        TratamentoDeExpressao.TratarExpressao(campos, stringBuilder);
                        string[] nomesDasPropriedades = stringBuilder.ToString().Split(',');
                        array = array.Where((PropertyInfo propriedade) => nomesDasPropriedades.Contains(propriedade.Name)).ToArray();
                    }
                    Carregar(val2, entidade, array, todosOsRegistros: false);
                    OracleDataReader val3 = ExecutarSQLReader(val2, entidade);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            ((DbDataReader)(object)val3).Read();
                            if (campos == null)
                            {
                                entidade.CarregarPorDataReader((IDataReader)val3);
                                entidade.PosicaoEntidade = PosicaoEntidade.Carregada;
                            }
                            else
                            {
                                PopularEntidade(val3, entidade, array);
                                entidade.PosicaoEntidade = PosicaoEntidade.CarregadaParcialmente;
                            }
                            result = true;
                        }
                        ((DbDataReader)(object)val3).Close();
                        return result;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public void Dispose()
        {
            foreach (OracleTransaction transaco in Transacoes)
            {
                _ = transaco;
                while (TransacaoAberta)
                {
                    CancelarTransacao();
                }
            }
        }

        public bool TestarConexao()
        {
            bool flag = false;
            OracleConnection val = null;
            try
            {
                val = CriarNovaConexao();
                flag = ((DbConnection)(object)val).State == ConnectionState.Open;
            }
            finally
            {
                if (flag)
                {
                    FecharConexao(val);
                }
            }
            return flag;
        }

        public int DeletarRegistros<T>(string tabela, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            int num = 0;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = $"DELETE FROM {tabela} WHERE 1 = 1";
                    if (filtros != null)
                    {
                        ((DbCommand)(object)val2).CommandText += TratarFiltros(filtros);
                    }
                    return ExecutarSQLNonQuery(val2, null);
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public DateTime DataHoraAtual()
        {
            return _ultimaDataHora = DateTime.Now;
        }

        public bool ProcedureValidaExiste(IProcedure procedure)
        {
            bool flag = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                Type type = procedure.GetType();
                string arg = type.Name;
                if (type.IsDefined(typeof(NomeDaPackage), inherit: true))
                {
                    arg = ((NomeDaPackage)type.GetCustomAttributes(typeof(NomeDaPackage), inherit: true)[0]).Nome;
                }
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    ((DbCommand)(object)val2).CommandText = $"SELECT COUNT(*) FROM USER_OBJECTS WHERE STATUS = 'VALID' AND OBJECT_NAME = '{arg}'";
                    return (decimal)((DbCommand)(object)val2).ExecuteScalar() > 0m;
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public bool FuncaoValidaExiste(IProcedure procedure)
        {
            bool flag = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                Type type = procedure.GetType();
                string arg = type.Name;
                if (type.IsDefined(typeof(NomeDaFuncao), inherit: true))
                {
                    arg = ((NomeDaFuncao)type.GetCustomAttributes(typeof(NomeDaFuncao), inherit: true)[0]).nomeFuncao;
                }
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    ((DbCommand)(object)val2).CommandText = $"SELECT COUNT(*) FROM  ALL_PROCEDURES WHERE PROCEDURE_NAME = '{arg}'";
                    return (decimal)((DbCommand)(object)val2).ExecuteScalar() > 0m;
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public bool ExecutarProcedure(IProcedure procedure)
        {

            bool result = false;
            if (ProcedureValidaExiste(procedure) || PackageValidaExiste(procedure))
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    Type type = procedure.GetType();
                    OracleCommand val2 = new OracleCommand(ObterNomeDaProcedure(procedure), val);
                    try
                    {
                        val2.BindByName = true;
                        MontarParametrosDeExecucaoDeProcedure(procedure, type, val2);
                        ExecutarSQLNonQuery(val2, null);
                        foreach (OracleParameter item in (DbParameterCollection)(object)val2.Parameters)
                        {
                            OracleParameter val3 = item;
                            if (((DbParameter)(object)val3).Direction == ParameterDirection.InputOutput || ((DbParameter)(object)val3).Direction == ParameterDirection.Output || ((DbParameter)(object)val3).Direction == ParameterDirection.ReturnValue)
                            {
                                PropertyInfo property = type.GetProperty(((DbParameter)(object)val3).ParameterName.Replace(":", ""));
                                if (property != null && ((DbParameter)(object)val3).Value != null && ((DbParameter)(object)val3).Value.ToString() != "null" && ((DbParameter)(object)val3).Value.GetType() != typeof(DBNull))
                                {
                                    property.SetValue(procedure, Convert.ChangeType(ConverterTipoDBParaTipoPrimario(val3), property.PropertyType), null);
                                }
                            }
                        }
                        result = true;
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                finally
                {
                    FecharConexao(val);
                }
            }
            return result;
        }

        public bool TabelaExiste(IEntidade entidade)
        {
            bool flag = false;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    ((DbCommand)(object)val2).CommandText = $"SELECT COUNT(*) FROM ALL_TABLES WHERE TABLE_NAME  = '{entidade.ObterNomeTabela()}'";
                    return (decimal)((DbCommand)(object)val2).ExecuteScalar() == 1m;
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        private string ObterNomeDaProcedure(IProcedure procedure)
        {
            Type type = procedure.GetType();
            string text = type.Name;
            if (type.IsDefined(typeof(NomeDaPackage), inherit: true))
            {
                text = $"{((NomeDaPackage)type.GetCustomAttributes(typeof(NomeDaPackage), inherit: true)[0]).Nome}.{text}";
            }
            return text;
        }

        private void MontarParametrosDeExecucaoDeProcedure(IProcedure procedure, Type tipoDaProcedure, OracleCommand comandoExecucao)
        {
            //IL_0035: Unknown result type (might be due to invalid IL or missing references)
            //IL_003c: Invalid comparison between Unknown and I4
            //IL_0029: Unknown result type (might be due to invalid IL or missing references)
            //IL_002e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0034: Expected O, but got Unknown
            //IL_014f: Unknown result type (might be due to invalid IL or missing references)
            //IL_0156: Invalid comparison between Unknown and I4
            List<OracleParameter> list = new List<OracleParameter>();
            OracleParameter val = null;
            PropertyInfo[] properties = tipoDaProcedure.GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (val == null)
                {
                    val = new OracleParameter(propertyInfo.Name, ObterTipoNoBancoDeDados(propertyInfo, procedure));
                }
                if ((int)val.OracleDbType == 126)
                {
                    val.ArrayBindSize = new int[3] { 1000, 1000, 1000 };
                    ((DbParameter)(object)val).Size = 1000;
                }
                if (propertyInfo.IsDefined(typeof(ParametroDeSaida), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.Output;
                    ((DbParameter)(object)val).Size = 1000;
                }
                else if (propertyInfo.IsDefined(typeof(ParametroDeEntrada), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.Input;
                    ((DbParameter)(object)val).Value = propertyInfo.GetValue(procedure, null);
                }
                else if (propertyInfo.IsDefined(typeof(ParametroDeRetorno), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.ReturnValue;
                    ((DbParameter)(object)val).Size = 1000;
                }
                else
                {
                    if (!propertyInfo.IsDefined(typeof(ParametroDeEntradaSaida), inherit: true))
                    {
                        continue;
                    }
                    ((DbParameter)(object)val).Direction = ParameterDirection.InputOutput;
                    ((DbParameter)(object)val).Value = propertyInfo.GetValue(procedure, null);
                    ((DbParameter)(object)val).Size = 1000;
                }
                list.Add(val);
                val = null;
            }
            if (list.Count > 0 && ((DbParameter)(object)list[0]).Direction == ParameterDirection.ReturnValue && (int)list[0].OracleDbType == 121)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (OracleParameter item2 in list)
                {
                    if (((DbParameter)(object)item2).Direction != ParameterDirection.ReturnValue)
                    {
                        if (stringBuilder.Length > 0)
                        {
                            stringBuilder.Append(",");
                        }
                        stringBuilder.Append(":");
                        stringBuilder.Append(((DbParameter)(object)item2).ParameterName);
                    }
                }
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Insert(0, ((DbCommand)(object)comandoExecucao).CommandText + "(");
                    stringBuilder.Append(")");
                }
                list[0].OracleDbType = (OracleDbType)112;
                ((DbCommand)(object)comandoExecucao).CommandText = $"BEGIN\r\n                               IF {stringBuilder.ToString()} THEN\r\n                                   :Retorno := 1;\r\n                               ELSE\r\n                                   :Retorno := 0;\r\n                               END IF;\r\n                           END;".Replace(Environment.NewLine, string.Empty);
                OracleParameter item = list[0];
                list.Remove(item);
                list.Add(item);
            }
            else
            {
                ((DbCommand)(object)comandoExecucao).CommandType = CommandType.StoredProcedure;
            }
            ((DbParameterCollection)(object)comandoExecucao.Parameters).AddRange((Array)list.ToArray());
        }

        private void MontarParametrosParaProcedureComRetornoBooleano(IProcedure procedure, Type tipoDaProcedure, OracleCommand comandoExecucao)
        {
            //IL_004d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0052: Unknown result type (might be due to invalid IL or missing references)
            //IL_0058: Expected O, but got Unknown
            ((DbCommand)(object)comandoExecucao).CommandText = string.Format("declare resultado boolean; begin resultado := {0}({1}); :{2} := sys.diutil.bool_to_int(resultado); end;", ((DbCommand)(object)comandoExecucao).CommandText, "{DEF_PARAMETROS}", "{DEF_RETORNO}");
            OracleParameter val = null;
            OracleParameter val2 = null;
            StringBuilder stringBuilder = new StringBuilder();
            PropertyInfo[] properties = tipoDaProcedure.GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (val == null)
                {
                    val = new OracleParameter(propertyInfo.Name, ObterTipoNoBancoDeDados(propertyInfo, procedure));
                }
                if (propertyInfo.IsDefined(typeof(ParametroDeSaida), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.Output;
                    ((DbParameter)(object)val).Size = 1000;
                }
                else if (propertyInfo.IsDefined(typeof(ParametroDeEntrada), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.Input;
                    ((DbParameter)(object)val).Value = propertyInfo.GetValue(procedure, null);
                }
                else if (propertyInfo.IsDefined(typeof(ParametroDeRetorno), inherit: true))
                {
                    ((DbParameter)(object)val).Direction = ParameterDirection.ReturnValue;
                    val.OracleDbType = (OracleDbType)112;
                    ((DbParameter)(object)val).Size = 1000;
                }
                else
                {
                    if (!propertyInfo.IsDefined(typeof(ParametroDeEntradaSaida), inherit: true))
                    {
                        continue;
                    }
                    ((DbParameter)(object)val).Direction = ParameterDirection.InputOutput;
                    ((DbParameter)(object)val).Value = propertyInfo.GetValue(procedure, null);
                    ((DbParameter)(object)val).Size = 1000;
                }
                if (((DbParameter)(object)val).Direction != ParameterDirection.ReturnValue)
                {
                    comandoExecucao.Parameters.Add(val);
                    if (stringBuilder.Length == 0)
                    {
                        stringBuilder.Append($":{((DbParameter)(object)val).ParameterName}");
                    }
                    else
                    {
                        stringBuilder.Append($", :{((DbParameter)(object)val).ParameterName}");
                    }
                }
                else
                {
                    val2 = val;
                    ((DbParameter)(object)val2).Direction = ParameterDirection.Output;
                    ((DbCommand)(object)comandoExecucao).CommandText = ((DbCommand)(object)comandoExecucao).CommandText.Replace("{DEF_RETORNO}", ((DbParameter)(object)val2).ParameterName);
                }
                val = null;
            }
            comandoExecucao.Parameters.Add(val2);
            ((DbCommand)(object)comandoExecucao).CommandText = ((DbCommand)(object)comandoExecucao).CommandText.Replace("{DEF_PARAMETROS}", stringBuilder.ToString());
            ((DbCommand)(object)comandoExecucao).CommandType = CommandType.Text;
        }

        private object ConverterTipoDB(PropertyInfo propriedade, object obj)
        {
            //IL_000b: Unknown result type (might be due to invalid IL or missing references)
            //IL_003c: Unknown result type (might be due to invalid IL or missing references)
            //IL_003d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0037: Unknown result type (might be due to invalid IL or missing references)
            object value = propriedade.GetValue(obj, null);
            OracleDbType val = (OracleDbType)126;
            TypeCode typeCode = TypeCode.String;
            if (value != null)
            {
                typeCode = Type.GetTypeCode(ChangeType(value, propriedade.PropertyType).GetType());
            }
            switch (typeCode)
            {
                case TypeCode.DateTime:
                    val = (OracleDbType)106;
                    break;
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    val = (OracleDbType)107;
                    break;
            }
            return val;
        }

        private object ConverterTipoDBParaTipoPrimario(OracleParameter parametro)
        {
            switch (parametro.OracleDbType)
            {
                case OracleDbType.BFile:
                case OracleDbType.Blob:
                case OracleDbType.Char:
                case OracleDbType.Clob:
                case OracleDbType.NChar:
                case OracleDbType.NClob:
                case OracleDbType.NVarchar2:
                case OracleDbType.Varchar2:
                    return (object)((DbParameter)parametro).Value.ToString();
                case OracleDbType.Date:
                    return (object)Convert.ToDateTime(((DbParameter)parametro).Value.ToString());
                case OracleDbType.Double:
                case OracleDbType.Int64:
                    return (object)Convert.ToDecimal(((DbParameter)parametro).Value.ToString());
                case OracleDbType.Int32:
                case OracleDbType.Byte:
                case OracleDbType.Int16:
                    return (object)(((DbParameter)parametro).Value == null ? Convert.ToInt32(((DbParameter)parametro).Value.ToString()) : 0);
                default:
                    return (object)((DbParameter)parametro).Value.ToString();
            }
        }


        private OracleDbType ObterTipoNoBancoDeDados(PropertyInfo propriedade, object obj)
        {
            //IL_000b: Unknown result type (might be due to invalid IL or missing references)
            //IL_006d: Unknown result type (might be due to invalid IL or missing references)
            //IL_0078: Unknown result type (might be due to invalid IL or missing references)
            //IL_0077: Unknown result type (might be due to invalid IL or missing references)
            //IL_0072: Unknown result type (might be due to invalid IL or missing references)
            object value = propriedade.GetValue(obj, null);
            OracleDbType result = (OracleDbType)126;
            TypeCode typeCode = TypeCode.String;
            if (value != null)
            {
                typeCode = Type.GetTypeCode(ChangeType(value, propriedade.PropertyType).GetType());
            }
            switch (typeCode)
            {
                case TypeCode.Boolean:
                    result = (OracleDbType)121;
                    break;
                case TypeCode.DateTime:
                    result = (OracleDbType)106;
                    break;
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    result = (OracleDbType)107;
                    break;
            }
            return result;
        }

        public int ContarRegistros<T>() where T : IEntidade, new()
        {
            return ContarRegistros((Expression<Func<T, bool>>[])null);
        }

        public int ContarRegistros<T>(params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new()
        {
            IEntidade entidade = new T();
            int num = 0;
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("select count(*) from ");
                    stringBuilder.Append(entidade.ObterNomeTabela());
                    if (filtros != null)
                    {
                        stringBuilder.Append(" where 1 = 1 ");
                        stringBuilder.Append(TratarFiltros(filtros));
                    }
                    ((DbCommand)(object)val2).CommandText = stringBuilder.ToString();
                    return Convert.ToInt32(((DbCommand)(object)val2).ExecuteScalar());
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public string ObterAssinaturaRegistro(string consultaSQL)
        {
            string text = "";
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(consultaSQL);
                    ((DbCommand)(object)val2).CommandText = stringBuilder.ToString();
                    OracleDataReader val3 = val2.ExecuteReader();
                    try
                    {
                        while (((DbDataReader)(object)val3).Read())
                        {
                            for (int i = 0; i < ((DbDataReader)(object)val3).FieldCount; i++)
                            {
                                if (((DbDataReader)(object)val3).GetName(i).ToUpper() != "ASSINATURA")
                                {
                                    object obj = ((DbDataReader)(object)val3)[i];
                                    if (((DbDataReader)(object)val3)[i] != DBNull.Value)
                                    {
                                        text += Convert.ToString(obj);
                                    }
                                }
                            }
                        }
                        ((DbDataReader)(object)val3).Close();
                        return text;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            catch (Exception)
            {
                return text;
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public List<T> ConsultaPorSQL<T>(string consultaSQL) where T : new()
        {
            List<T> list = new List<T>();
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append(consultaSQL);
                    ((DbCommand)(object)val2).CommandText = stringBuilder.ToString();
                    OracleDataReader reader = val2.ExecuteReader();
                    try
                    {
                        while (((DbDataReader)(object)reader).Read())
                        {
                            T val3 = new T();
                            int qtcol;
                            for (qtcol = 0; qtcol < ((DbDataReader)(object)reader).FieldCount; qtcol++)
                            {
                                object obj = DBNull.Value;
                                PropertyInfo propertyInfo = (from p in val3.GetType().GetProperties()
                                                             where p.Name.ToUpper().Equals(((DbDataReader)(object)reader).GetName(qtcol).ToUpper())
                                                             select p).FirstOrDefault();
                                try
                                {
                                    obj = ((DbDataReader)(object)reader)[qtcol];
                                }
                                catch (Exception)
                                {
                                }
                                if (obj != null && obj.GetType() != typeof(DBNull) && propertyInfo != null)
                                {
                                    try
                                    {
                                        AplicarValorAoObjeto(obj, val3, propertyInfo);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                            list.Add(val3);
                        }
                        ((DbDataReader)(object)reader).Close();
                        return list;
                    }
                    finally
                    {
                        if (reader != null)
                        {
                            ((IDisposable)reader).Dispose();
                        }
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            catch (Exception)
            {
                return list;
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public void AtualizarInformacoesRegionais(CultureInfo cultura)
        {
            _cultura = cultura;
        }

        private bool FormatoValidoDeData(string formato)
        {
            formato = formato.ToUpper();
            if ((formato.IndexOf("DD") > -1 || formato.IndexOf("D") > -1) && formato.IndexOf("MM") > -1)
            {
                if (formato.IndexOf("YYYY") <= -1)
                {
                    return formato.IndexOf("YY") > -1;
                }
                return true;
            }
            return false;
        }

        private void AplicarPadroesCulturais(OracleConnection conexao)
        {
            if (((DbConnection)(object)conexao).State != ConnectionState.Open)
            {
                ((DbConnection)(object)conexao).Open();
            }
            if (!ModoDeTrace)
            {
                return;
            }
            OracleCommand val = conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = "alter session set sql_trace=true";
                try
                {
                    ((DbCommand)(object)val).ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    NotificarOberservadoresDeExecucao($"Erro ao executar instrução: alter session set sql_trace=true\nMotivo:\n\n{ex.Message}");
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }

        public bool IniciarTransacao()
        {
            OracleTransaction item = CriarNovaConexao(novaTransacao: true).BeginTransaction();
            Transacoes.Push(item);
            return TransacaoAberta;
        }

        public bool FinalizarTransacao()
        {
            bool transacaoAberta = TransacaoAberta;
            if (logfat == null)
            {
                logfat = new LogFaturamento("FinalizarTransacao", TipoLogFaturamento.Persistencia);
            }
            if (transacaoAberta)
            {
                OracleTransaction val = Transacoes.Pop();
                try
                {
                    OracleConnection connection = val.Connection;
                    try
                    {
                        logfat.Adicionar($"REALIZANDO O COMMIT DAS TRANSAÇÔES {Transacoes.Count.ToString()}");
                        ((DbTransaction)(object)val).Commit();
                    }
                    catch (Exception ex)
                    {
                        ((DbTransaction)(object)val).Rollback();
                        throw new Exception(ex.Message);
                    }
                    if (connection != null)
                    {
                        try
                        {
                            logfat.Adicionar("REALIZANDO O CLOSE DA CONEXAO");
                            ((DbConnection)(object)connection).Close();
                            ((Component)(object)connection).Dispose();
                            logfat.Adicionar("CONEXAO FECHADA");
                        }
                        catch (Exception ex2)
                        {
                            throw new Exception(ex2.Message);
                        }
                    }
                }
                finally
                {
                    ((IDisposable)val)?.Dispose();
                }
            }
            logfat.Gravar();
            return transacaoAberta;
        }

        public bool CancelarTransacao()
        {
            bool transacaoAberta = TransacaoAberta;
            if (transacaoAberta)
            {
                OracleTransaction obj = Transacoes.Pop();
                OracleConnection connection = obj.Connection;
                ((DbTransaction)(object)obj).Rollback();
                try
                {
                    ((DbConnection)(object)connection).Close();
                    ((Component)(object)connection).Dispose();
                }
                catch
                {
                }
            }
            return transacaoAberta;
        }

        public bool BloquearRegistros<T>(List<T> registros, bool carregarEntidade) where T : IEntidade, new()
        {
            bool result = false;
            if (registros.Count > 0)
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    OracleCommand val2 = val.CreateCommand();
                    try
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(" select 1 from ");
                        T val3 = registros[0];
                        stringBuilder.AppendLine(val3.ObterNomeTabela());
                        stringBuilder.AppendLine("  where 1 = 1");
                        stringBuilder.AppendLine("    and ( ");
                        int num = 0;
                        foreach (T registro in registros)
                        {
                            T current = registro;
                            if (string.IsNullOrEmpty(current.IdentificacaoDoRegistro))
                            {
                                stringBuilder.AppendLine(" ( ");
                                StringBuilder stringBuilder2 = new StringBuilder();
                                PropertyInfo[] properties = ObterTipoDaEntidade(current.GetType()).GetProperties();
                                foreach (PropertyInfo propertyInfo in properties)
                                {
                                    InfoCampoEntidade infoCampoEntidade = AtributoCampo(propertyInfo);
                                    if (infoCampoEntidade == null || !infoCampoEntidade.ChavePrimaria)
                                    {
                                        continue;
                                    }
                                    string text = propertyInfo.Name + num;
                                    if (DefinirParametros(propertyInfo, infoCampoEntidade, val2, current, text))
                                    {
                                        if (stringBuilder2.Length == 0)
                                        {
                                            stringBuilder2.AppendLine($"{propertyInfo.Name} = :{text}");
                                        }
                                        else
                                        {
                                            stringBuilder2.AppendLine($" and {propertyInfo.Name} = :{text}");
                                        }
                                    }
                                }
                                stringBuilder.AppendLine(stringBuilder2.ToString());
                                stringBuilder.AppendLine(" ) ");
                            }
                            else
                            {
                                stringBuilder.AppendLine($" ( ROWID = '{current.IdentificacaoDoRegistro}' )");
                            }
                            ref T reference = ref current;
                            val3 = default(T);
                            if (val3 == null)
                            {
                                val3 = reference;
                                reference = ref val3;
                            }
                            if (!reference.Equals(registros[registros.Count - 1]))
                            {
                                stringBuilder.AppendLine(" OR ");
                                num++;
                            }
                        }
                        stringBuilder.AppendLine(" ) ");
                        stringBuilder.AppendLine(" FOR UPDATE ");
                        ((DbCommand)(object)val2).CommandText = stringBuilder.ToString();
                        ExecutarSQLNonQuery(val2, null);
                        result = true;
                        foreach (T registro2 in registros)
                        {
                            if (carregarEntidade)
                            {
                                Carregar(registro2);
                            }
                        }
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                finally
                {
                    FecharConexao(val);
                }
            }
            return result;
        }

        public bool BloquearRegistros<T>(List<T> registros) where T : IEntidade, new()
        {
            bool result = false;
            if (registros.Count > 0)
            {
                OracleConnection val = CriarNovaConexao();
                try
                {
                    OracleCommand val2 = val.CreateCommand();
                    try
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(" select null from ");
                        stringBuilder.AppendLine(registros[0].ObterNomeTabela());
                        stringBuilder.AppendLine("  where 1 = 1");
                        stringBuilder.AppendLine("    and ( ");
                        int num = 0;
                        foreach (T registro in registros)
                        {
                            IEntidade entidade = registro;
                            stringBuilder.AppendLine(" ( ");
                            if (string.IsNullOrEmpty(entidade.IdentificacaoDoRegistro))
                            {
                                StringBuilder stringBuilder2 = new StringBuilder();
                                PropertyInfo[] properties = ObterTipoDaEntidade(entidade.GetType()).GetProperties();
                                foreach (PropertyInfo propertyInfo in properties)
                                {
                                    InfoCampoEntidade infoCampoEntidade = AtributoCampo(propertyInfo);
                                    if (infoCampoEntidade == null || !infoCampoEntidade.ChavePrimaria)
                                    {
                                        continue;
                                    }
                                    string text = propertyInfo.Name + num;
                                    if (DefinirParametros(propertyInfo, infoCampoEntidade, val2, entidade, text))
                                    {
                                        if (stringBuilder2.Length == 0)
                                        {
                                            stringBuilder2.AppendLine($"{propertyInfo.Name} = :{text}");
                                        }
                                        else
                                        {
                                            stringBuilder2.AppendLine($" and {propertyInfo.Name} = :{text}");
                                        }
                                    }
                                }
                                stringBuilder.AppendLine(stringBuilder2.ToString());
                            }
                            else
                            {
                                stringBuilder.AppendLine($" ROWID = '{entidade.IdentificacaoDoRegistro}' ");
                            }
                            stringBuilder.AppendLine(" ) ");
                            if (!entidade.Equals(registros[registros.Count - 1]))
                            {
                                stringBuilder.AppendLine(" OR ");
                                num++;
                            }
                        }
                        stringBuilder.AppendLine(" ) ");
                        stringBuilder.AppendLine(" FOR UPDATE ");
                        ((DbCommand)(object)val2).CommandText = stringBuilder.ToString();
                        ExecutarSQLNonQuery(val2, null);
                        result = true;
                    }
                    finally
                    {
                        ((IDisposable)val2)?.Dispose();
                    }
                }
                finally
                {
                    FecharConexao(val);
                }
            }
            return result;
        }

        public bool PackageValidaExiste(IProcedure procedure)
        {
            bool result = false;
            if (procedure.GetType().IsDefined(typeof(NomeDaPackage), inherit: true))
            {
                NomeDaPackage nomeDaPackage = (NomeDaPackage)procedure.GetType().GetCustomAttributes(typeof(NomeDaPackage), inherit: true)[0];
                if (nomeDaPackage != null)
                {
                    OracleConnection val = CriarNovaConexao();
                    try
                    {
                        procedure.GetType();
                        OracleCommand val2 = val.CreateCommand();
                        try
                        {
                            DefinirTransacao(val2);
                            ((DbCommand)(object)val2).CommandText = $"SELECT COUNT(*) FROM USER_OBJECTS WHERE OBJECT_TYPE LIKE 'PACKAGE%' AND OBJECT_NAME = '{nomeDaPackage.Nome}' AND STATUS = 'VALID'";
                            result = (decimal)((DbCommand)(object)val2).ExecuteScalar() == 2m;
                        }
                        finally
                        {
                            ((IDisposable)val2)?.Dispose();
                        }
                    }
                    finally
                    {
                        FecharConexao(val);
                    }
                }
            }
            return result;
        }

        public void MapearObjeto<T>(T objeto, TipoMapeamentoDeObjeto tipo)
        {
            string comando = string.Empty;
            List<Parametro> parametros = new List<Parametro>();
            switch (tipo)
            {
                case TipoMapeamentoDeObjeto.Inserir:
                    comando = ObterComandoInsert(objeto);
                    parametros = ObterListaPropriedades(objeto);
                    break;
                case TipoMapeamentoDeObjeto.Excluir:
                    comando = ObterComandoDelete(objeto);
                    parametros = ObterListaPropriedadesChave(objeto);
                    break;
                case TipoMapeamentoDeObjeto.Atualizar:
                    comando = ObterComandoUpdate(objeto);
                    parametros = ObterListaPropriedades(objeto);
                    break;
            }
            ExecutarComando(comando, parametros);
        }

        private string ObterComandoInsert<T>(T objeto)
        {
            string value = ObterNomeTabela(objeto);
            List<Parametro> list = ObterListaPropriedades(objeto);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO ").Append(value).Append(" (");
            foreach (Parametro item in list)
            {
                stringBuilder.Append((string?)item.Identificador).Append(",");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1).Append(")");
            stringBuilder.Append("VALUES(");
            foreach (Parametro item2 in list)
            {
                stringBuilder.Append(":").Append((string?)item2.Identificador).Append(",");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1).Append(")");
            return stringBuilder.ToString();
        }

        private string ObterComandoDelete<T>(T objeto)
        {
            string value = ObterNomeTabela(objeto);
            List<Parametro> list = ObterListaPropriedadesChave(objeto);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("DELETE FROM ").Append(value);
            stringBuilder.Append(" WHERE ");
            foreach (Parametro item in list)
            {
                stringBuilder.Append((string?)item.Identificador).Append(" = ").Append(":").Append((string?)item.Identificador)
                    .Append(" AND ");
            }
            stringBuilder.Remove(stringBuilder.Length - " AND ".Length, " AND ".Length);
            return stringBuilder.ToString();
        }

        private string ObterComandoUpdate<T>(T objeto)
        {
            string value = ObterNomeTabela(objeto);
            List<Parametro> list = ObterListaPropriedadesChave(objeto);
            List<Parametro> list2 = ObterListaPropriedades(objeto, apenasNaoChaves: true);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("UPDATE ").Append(value);
            stringBuilder.Append(" SET ");
            foreach (Parametro item in list2)
            {
                stringBuilder.Append((string?)item.Identificador).Append(" = ").Append(":").Append((string?)item.Identificador)
                    .Append(",");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append(" WHERE ");
            foreach (Parametro item2 in list)
            {
                stringBuilder.Append((string?)item2.Identificador).Append(" = ").Append(":").Append((string?)item2.Identificador)
                    .Append(" AND ");
            }
            stringBuilder.Remove(stringBuilder.Length - " AND ".Length, " AND ".Length);
            return stringBuilder.ToString();
        }

        private string ObterNomeTabela<T>(T objeto)
        {
            return (((ObjetoMapeavel)(from a in typeof(T).GetCustomAttributes(inherit: false)
                                      where a.GetType().Equals(typeof(ObjetoMapeavel))
                                      select a).FirstOrDefault()) ?? throw new Exception("Objeto não possui o atributo ObjetoMapeavel especificando o nome da tabela.")).NomeDaTabela;
        }

        private List<Parametro> ObterListaPropriedadesChave<T>(T objeto)
        {
            List<Parametro> list = new List<Parametro>();
            foreach (PropertyInfo item in from p in objeto.GetType().GetProperties()
                                          where (from a in p.GetCustomAttributes(inherit: false)
                                                 where a.GetType().Equals(typeof(PropriedadeMapeavel))
                                                 select a).Count() > 0
                                          select p)
            {
                if (((PropriedadeMapeavel)(from a in item.GetCustomAttributes(inherit: false)
                                           where a.GetType().Equals(typeof(PropriedadeMapeavel))
                                           select a).FirstOrDefault()).Chave)
                {
                    list.Add(new Parametro(ObterNomePropriedadeColuna(item), item.GetValue(objeto, null)));
                }
            }
            if (list.Count == 0)
            {
                throw new Exception("Objeto não possui nenhuma propriedade chave.");
            }
            return list;
        }

        private List<Parametro> ObterListaPropriedades<T>(T objeto)
        {
            return ObterListaPropriedades(objeto, apenasNaoChaves: false);
        }

        private List<Parametro> ObterListaPropriedades<T>(T objeto, bool apenasNaoChaves)
        {
            List<Parametro> list = new List<Parametro>();
            if (apenasNaoChaves)
            {
                foreach (PropertyInfo item in from p in objeto.GetType().GetProperties()
                                              where (from a in p.GetCustomAttributes(inherit: false)
                                                     where a.GetType().Equals(typeof(PropriedadeMapeavel)) && ((PropriedadeMapeavel)a).Chave == !apenasNaoChaves
                                                     select a).Count() > 0
                                              select p)
                {
                    list.Add(new Parametro(ObterNomePropriedadeColuna(item), item.GetValue(objeto, null)));
                }
            }
            else
            {
                foreach (PropertyInfo item2 in from p in objeto.GetType().GetProperties()
                                               where (from a in p.GetCustomAttributes(inherit: false)
                                                      where a.GetType().Equals(typeof(PropriedadeMapeavel))
                                                      select a).Count() > 0
                                               select p)
                {
                    list.Add(new Parametro(ObterNomePropriedadeColuna(item2), item2.GetValue(objeto, null)));
                }
            }
            if (list.Count == 0)
            {
                throw new Exception("Objeto não possui nenhuma propriedade com o atributo PropriedadeMapeavel.");
            }
            return list;
        }

        private string ObterNomePropriedadeColuna(PropertyInfo prop)
        {
            return ((PropriedadeMapeavel)(from a in prop.GetCustomAttributes(inherit: false)
                                          where a.GetType().Equals(typeof(PropriedadeMapeavel))
                                          select a).FirstOrDefault()).Nome ?? prop.Name;
        }

        private void ExecutarComando(string comando, List<Parametro> parametros)
        {
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = comando;
                    ((DbCommand)(object)val2).Prepare();
                    foreach (Parametro parametro in parametros)
                    {
                        val2.Parameters.Add(parametro.Identificador, parametro.Valor);
                    }
                    ExecutarSQLNonQuery(val2, null);
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public void MapearObjeto<T>(T objeto, IMapeador mapeador)
        {
            List<Parametro> parametros = mapeador.Parametros;
            string commandText = mapeador.ObterSql();
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = commandText;
                    ((DbCommand)(object)val2).Prepare();
                    foreach (Parametro item in parametros)
                    {
                        if (item.Valor != null && item.Valor.GetType().IsArray)
                        {
                            ((DbCommand)(object)val2).CommandText = MontarComandoArray(val2, item);
                        }
                        else
                        {
                            val2.Parameters.Add(item.Identificador, item.Valor);
                        }
                    }
                    OracleDataReader val3 = ExecutarSQLReader(val2, null);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            ((DbDataReader)(object)val3).Read();
                            PopularDTO(objeto, val3);
                        }
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public List<T> MapearLista<T>(T objDTO, IMapeador mapeador)
        {
            List<Parametro> parametros = mapeador.Parametros;
            string commandText = mapeador.ObterSql();
            List<T> list = new List<T>();
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    ((DbCommand)(object)val2).CommandText = commandText;
                    ((DbCommand)(object)val2).Prepare();
                    foreach (Parametro item in parametros)
                    {
                        if (item.Valor != null && item.Valor.GetType().IsArray)
                        {
                            ((DbCommand)(object)val2).CommandText = MontarComandoArray(val2, item);
                        }
                        else
                        {
                            val2.Parameters.Add(item.Identificador, item.Valor);
                        }
                    }
                    OracleDataReader val3 = ExecutarSQLReader(val2, null);
                    try
                    {
                        if (((DbDataReader)(object)val3).HasRows)
                        {
                            while (((DbDataReader)(object)val3).Read())
                            {
                                T val4 = (T)typeof(T).GetConstructors()[0].Invoke(null);
                                PopularDTO(val4, val3);
                                list.Add(val4);
                            }
                        }
                        ((DbDataReader)(object)val3).Close();
                        return list;
                    }
                    finally
                    {
                        ((IDisposable)val3)?.Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        private void PopularDTO<T>(T objeto, OracleDataReader reader)
        {
            PropertyInfo[] array = (from propriedade in typeof(T).GetProperties()
                                    where propriedade.IsDefined(typeof(PropriedadeMapeavel), inherit: true)
                                    select propriedade).ToArray();
            foreach (PropertyInfo propertyInfo in array)
            {
                object obj = DBNull.Value;
                try
                {
                    obj = ((DbDataReader)(object)reader)[ObterNomePropriedadeColuna(propertyInfo)];
                }
                catch (Exception)
                {
                }
                if (obj.GetType() != typeof(DBNull))
                {
                    AplicarValorAoObjeto(obj, objeto, propertyInfo);
                }
            }
        }

        public string MontarComandoArray(OracleCommand pcommand, Parametro pparametro)
        {
            return new Regex($":{pparametro.Identificador}").Replace(((DbCommand)(object)pcommand).CommandText, ObterVetorFormatado(pparametro.Valor));
        }

        public string ObterVetorFormatado(object pvalor)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (pvalor.GetType().Equals(typeof(string[])))
            {
                string[] array = (string[])pvalor;
                foreach (string value in array)
                {
                    stringBuilder.Append("'").Append(value).Append("',");
                }
            }
            else
            {
                foreach (object item in (IEnumerable)pvalor)
                {
                    stringBuilder.Append(item.ToString()).Append(",");
                }
            }
            if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1].ToString().Equals(","))
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }
            return stringBuilder.ToString();
        }

        private void RegistrarInformacoesDaAplicacao(OracleConnection conexao)
        {
            OracleCommand val = conexao.CreateCommand();
            try
            {
                DefinirTransacao(val);
                ((DbCommand)(object)val).CommandText = "BEGIN DBMS_APPLICATION_INFO.SET_MODULE('IntegracaoApi.exe', 'nwApi'); END;";
                ExecutarSQLNonQuery(val, null);
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }

        private void AvaliarTipoDePersistenciaAninhada(TipoPersistencia tipoPersistenciaObjetoPai, IEntidade entidade, TipoDePersistenciaColetivaPermitida tipoDePersistenciaColetivaPermitida)
        {
            if (tipoPersistenciaObjetoPai == TipoPersistencia.RECARREGAR)
            {
                if (entidade.PosicaoEntidade == PosicaoEntidade.Alterada || entidade.PosicaoEntidade == PosicaoEntidade.Carregada)
                {
                    PersistirEmCascata(tipoPersistenciaObjetoPai, entidade);
                }
                return;
            }
            switch (entidade.PosicaoEntidade)
            {
                case PosicaoEntidade.Alterada:
                    if (OperacaoPodeSerRealizada(TipoPersistencia.ALTERAR, tipoDePersistenciaColetivaPermitida))
                    {
                        PersistirEmCascata(TipoPersistencia.ALTERAR, entidade);
                    }
                    break;
                case PosicaoEntidade.Nova:
                    if (OperacaoPodeSerRealizada(TipoPersistencia.INCLUIR, tipoDePersistenciaColetivaPermitida))
                    {
                        PersistirEmCascata(TipoPersistencia.INCLUIR, entidade);
                    }
                    break;
            }
        }

        private bool OperacaoPodeSerRealizada(TipoPersistencia tipo, TipoDePersistenciaColetivaPermitida tipoDePersistenciaColetivaPermitida)
        {
            bool result = false;
            switch (tipo)
            {
                case TipoPersistencia.INCLUIR:
                    result = (tipoDePersistenciaColetivaPermitida & TipoDePersistenciaColetivaPermitida.Incluir) != 0;
                    break;
                case TipoPersistencia.ALTERAR:
                    result = (tipoDePersistenciaColetivaPermitida & TipoDePersistenciaColetivaPermitida.Alterar) != 0;
                    break;
                case TipoPersistencia.DELETAR:
                    result = (tipoDePersistenciaColetivaPermitida & TipoDePersistenciaColetivaPermitida.Deletar) != 0;
                    break;
                case TipoPersistencia.CARREGAR:
                    result = (tipoDePersistenciaColetivaPermitida & TipoDePersistenciaColetivaPermitida.Carregar) != 0;
                    break;
                case TipoPersistencia.RECARREGAR:
                    result = (tipoDePersistenciaColetivaPermitida & TipoDePersistenciaColetivaPermitida.Recarregar) != 0;
                    break;
            }
            return result;
        }

        private void PersistirEntidadesAninhadas(TipoPersistencia tipo, IEntidade entidade)
        {
            PropertyInfo[] properties = ObterTipoDaEntidade(entidade.GetType()).GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (!propertyInfo.IsDefined(typeof(PersistirEmCascata), inherit: true))
                {
                    continue;
                }
                PersistirEmCascata persistirEmCascata = (PersistirEmCascata)propertyInfo.GetCustomAttributes(typeof(PersistirEmCascata), inherit: true)[0];
                switch (persistirEmCascata.Tipo)
                {
                    case TipoDePersistenciaEmCascata.Unitario:
                        {
                            IEntidade entidade2 = (IEntidade)propertyInfo.GetValue(entidade, null);
                            if (entidade2 != null)
                            {
                                AvaliarTipoDePersistenciaAninhada(tipo, entidade2, persistirEmCascata.TiposPermitidos);
                            }
                            break;
                        }
                    case TipoDePersistenciaEmCascata.Colecao:
                        {
                            object value = propertyInfo.GetValue(entidade, null);
                            if (value == null)
                            {
                                break;
                            }
                            foreach (object item in (ICollection)value)
                            {
                                AvaliarTipoDePersistenciaAninhada(tipo, (IEntidade)item, persistirEmCascata.TiposPermitidos);
                            }
                            break;
                        }
                }
            }
        }

        public bool PersistirEmCascata(TipoPersistencia tipo, IEntidade entidade)
        {
            if ((tipo != TipoPersistencia.DELETAR && tipo != TipoPersistencia.CARREGAR) || (tipo == TipoPersistencia.RECARREGAR && (entidade.PosicaoEntidade == PosicaoEntidade.Carregada || entidade.PosicaoEntidade == PosicaoEntidade.Alterada)))
            {
                PersistirEntidadesAninhadas(tipo, entidade);
            }
            return Persistir(tipo, entidade);
        }

        public decimal ObterNumeroSequencial(string identificador)
        {
            decimal num = default(decimal);
            OracleConnection val = CriarNovaConexao();
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    ((DbCommand)(object)val2).CommandText = $"SELECT {identificador}.NEXTVAL FROM DUAL";
                    return (decimal)((DbCommand)(object)val2).ExecuteScalar();
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }

        public decimal ObterNumeroSequencialDeTabela<TEntidade, TPropriedade>(TEntidade entidade, Expression<Func<TEntidade, TPropriedade>> expressao) where TEntidade : IEntidade, new()
        {
            return ObterNumeroSequencialDeTabela(entidade, 1m, expressao);
        }

        public void PersistenciaParalela<T>(T obj) where T : IEntidade, new()
        {
            IniciarTransacao();
            try
            {
                BloquearRegistros(new List<T> { obj });
                Persistir(TipoPersistencia.ALTERAR, obj);
                FinalizarTransacao();
            }
            catch
            {
                CancelarTransacao();
                throw;
            }
        }

        public decimal ObterNumeroSequencialDeTabela<TEntidade, TPropriedade>(TEntidade entidade, decimal quantidadeDeNumeros, Expression<Func<TEntidade, TPropriedade>> expressao) where TEntidade : IEntidade, new()
        {
            decimal num = -1m;
            PropertyInfo propertyInfo = ObterPropriedadePorExpressao(entidade, expressao);
            Type type = propertyInfo.PropertyType;
            if (type.IsGenericType)
            {
                type = new NullableConverter(type).UnderlyingType;
            }
            if (type == typeof(decimal))
            {
                IniciarTransacao();
                try
                {
                    BloquearRegistros(new List<TEntidade> { entidade });
                    CarregarEntidadeParcialmente(entidade, Converter(expressao));
                    num = Convert.ToDecimal(propertyInfo.GetValue(entidade, null));
                    propertyInfo.SetValue(entidade, num + quantidadeDeNumeros, null);
                    Persistir(TipoPersistencia.ALTERAR, entidade);
                    FinalizarTransacao();
                    return num;
                }
                catch
                {
                    CancelarTransacao();
                    throw;
                }
            }
            throw new ArgumentException($"A propriedade {propertyInfo.Name} deve ser do tipo Decimal e nao to tipo {propertyInfo.PropertyType.Name}");
        }

        private Expression<Func<T, object>> Converter<T, TSaida>(Expression<Func<T, TSaida>> expressao)
        {
            return Expression.Lambda<Func<T, object>>(Expression.Convert(expressao.Body, typeof(object)), expressao.Parameters);
        }

        private PropertyInfo ObterPropriedadePorExpressao<TEntidade, TProperty>(TEntidade entidade, Expression<Func<TEntidade, TProperty>> expressao)
        {
            Type typeFromHandle = typeof(TEntidade);
            PropertyInfo propertyInfo = ((expressao.Body as MemberExpression) ?? throw new ArgumentException($"Expression '{expressao.ToString()}' refers to a method, not a property.")).Member as PropertyInfo;
            if (propertyInfo == null)
            {
                throw new ArgumentException($"Expression '{expressao.ToString()}' refers to a field, not a property.");
            }
            if (typeFromHandle != propertyInfo.ReflectedType && !typeFromHandle.IsSubclassOf(propertyInfo.ReflectedType))
            {
                throw new ArgumentException($"Expresion '{expressao.ToString()}' refers to a property that is not from type {typeFromHandle}.");
            }
            return propertyInfo;
        }

        public void ValidarObjetoNoBanco(Type[] tipos, IObservadorAtualizacao observador)
        {
            throw new NotImplementedException();
            //OracleConnection conexao = CriarNovaConexao();
            //try
            //{
            //    List<string> objetosValidosDoBanco = BuscarObjetosValidos(conexao, observador);
            //    int num = 0;
            //    int total = tipos.Count();
            //    foreach (Type tipo in tipos)
            //    {
            //        using AtualizadorDeTabela atualizadorDeTabela = new AtualizadorDeTabela(conexao, tipo, observador);
            //        if (!atualizadorDeTabela.CriarTabela())
            //        {
            //            atualizadorDeTabela.ModificarTabela();
            //        }
            //        observador?.RegistrarPercetualAndamento(++num, total);
            //    }
            //    RecompilarObjectosInvalidos(conexao, objetosValidosDoBanco, observador);
            //}
            //finally
            //{
            //    FecharConexao(conexao);
            //}
            //observador?.RegistrarPercetualAndamento(1, 1);
        }

        private void RecompilarObjectosInvalidos(OracleConnection conexao, List<string> objetosValidosDoBanco, IObservadorAtualizacao observador)
        {
            List<string[]> list = new List<string[]>();
            if (observador != null)
            {
                observador.Registrar(string.Empty);
                observador.Registrar("Executando lenvantamento de objetos inválidos");
            }
            OracleCommand val = conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = "select object_name, object_type from user_objects where status = 'INVALID'";
                OracleDataReader val2 = val.ExecuteReader();
                try
                {
                    while (((DbDataReader)(object)val2).Read())
                    {
                        list.Add(new string[2]
                        {
                        ((DbDataReader)(object)val2)[0].ToString(),
                        ((DbDataReader)(object)val2)[1].ToString()
                        });
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
            OracleCommand val3 = conexao.CreateCommand();
            try
            {
                IEnumerable<string[]> enumerable = list.Where((string[] invalido) => objetosValidosDoBanco.Contains(invalido[0]));
                if (enumerable.Count() > 0)
                {
                    if (observador != null)
                    {
                        observador.Registrar($"  Encontrados  {enumerable.Count()} objetos inválidos");
                        observador.RegistrarPercetualAndamento(0, 100);
                    }
                    int num = 0;
                    int total = enumerable.Count();
                    {
                        foreach (string[] item in enumerable)
                        {
                            string arg = item[1].Replace("PACKAGE BODY", "PACKAGE").ToLower();
                            ((DbCommand)(object)val3).CommandText = $"alter {arg} {item[0]} compile";
                            try
                            {
                                observador?.Registrar($"  Recompilando {arg} {item[0]}");
                                ((DbCommand)(object)val3).ExecuteNonQuery();
                            }
                            catch (Exception)
                            {
                            }
                            observador?.RegistrarPercetualAndamento(++num, total);
                        }
                        return;
                    }
                }
                observador?.Registrar("  Nenhum objeto inválido encontrado");
            }
            finally
            {
                ((IDisposable)val3)?.Dispose();
            }
        }

        private List<string> BuscarObjetosValidos(OracleConnection conexao, IObservadorAtualizacao observador)
        {
            if (observador != null)
            {
                observador.Registrar(string.Empty);
                observador.Registrar("Executando lenvantamento de objetos válidos");
            }
            List<string> list = new List<string>();
            OracleCommand val = conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = "select object_name from user_objects where status = 'VALID'";
                OracleDataReader val2 = val.ExecuteReader();
                try
                {
                    while (((DbDataReader)(object)val2).Read())
                    {
                        try
                        {
                            list.Add(((DbDataReader)(object)val2)[0].ToString());
                        }
                        catch (Exception ex)
                        {
                            _ = ex.Message;
                        }
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
            if (observador != null && list.Count > 0)
            {
                observador.Registrar($"  {list.Count.ToString()} objetos válidos encontrados");
            }
            return list;
        }

        public void ExecutarScript(string script)
        {
            ExecutarScript(script, novaConexao: false);
        }

        public void ExecutarScript(string script,string nome,bool novaConexao)
        {
            ExecutarScript(script, novaConexao: false);
        }

        public void ExecutarScript(string script, bool novaConexao)
        {
            OracleConnection val = CriarNovaConexao(novaConexao);
            try
            {
                OracleCommand val2 = val.CreateCommand();
                try
                {
                    DefinirTransacao(val2);
                    ((DbCommand)(object)val2).CommandText = script;
                    try
                    {
                        ((DbCommand)(object)val2).ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Falha ao executar a instrução : {script} retorno: {ex.Message}");
                    }
                }
                finally
                {
                    ((IDisposable)val2)?.Dispose();
                }
            }
            finally
            {
                FecharConexao(val);
            }
        }
    }

}
