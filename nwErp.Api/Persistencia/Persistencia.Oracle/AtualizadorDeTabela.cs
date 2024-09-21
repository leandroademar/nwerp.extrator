using System.Data.Common;
using System.Text;

namespace nwErp.Api.Persistencia.Oracle
{
    public class AtualizadorDeTabela : IDisposable, IObservadorAtualizacao
    {
        private class DefinicaoColuna
        {
            public string Nome { get; set; }

            public string Tipo { get; set; }

            public int Tamanho { get; set; }

            public int TamanhoNumerico { get; set; }

            public int PrecisaoNumerica { get; set; }

            public bool PodeSerNulo { get; set; }

            public DefinicaoColuna(OracleDataReader reader)
            {
                Nome = ((DbDataReader)(object)reader)[0].ToString();
                Tipo = ((DbDataReader)(object)reader)[1].ToString();
                Tamanho = Convert.ToInt32(((DbDataReader)(object)reader)[2]);
                TamanhoNumerico = Convert.ToInt32(((DbDataReader)(object)reader)[3]);
                PrecisaoNumerica = Convert.ToInt32(((DbDataReader)(object)reader)[4]);
                PodeSerNulo = ((DbDataReader)(object)reader)[5].ToString() == "N";
            }
        }

        private OracleConnection _conexao;

        private PropertyInfo[] _propriedades;

        private Type _tipoBase;

        private IObservadorAtualizacao _observador;

        public AtualizadorDeTabela(OracleConnection conexao, Type tipo, IObservadorAtualizacao observador)
        {
            _conexao = conexao;
            _tipoBase = ObterTipoDaEntidade(tipo);
            _propriedades = _tipoBase.GetProperties();
            _observador = observador ?? this;
            _observador.Registrar($"{Environment.NewLine} Tabela {_tipoBase.Name}");
        }

        public bool CriarTabela()
        {
            bool result = false;
            _observador.Registrar("  Verificando existencia");
            if (!TabelaExiste())
            {
                result = ExecutarScript(CriarScriptDeCriacao());
            }
            return result;
        }

        private bool ExecutarScript(string script)
        {
            bool result = false;
            OracleCommand val = _conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = script;
                try
                {
                    ((DbCommand)(object)val).ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("01440"))
                    {
                        _observador.Registrar($"    - Erro de execução de script: {ex.Message}");
                    }
                }
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
            return result;
        }

        private string CriarScriptDeCriacao()
        {
            _observador.Registrar($"    - Criando tabela {_tipoBase.Name}");
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            PropertyInfo[] propriedades = _propriedades;
            foreach (PropertyInfo propertyInfo in propriedades)
            {
                object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(InfoCampoEntidade), inherit: true);
                if (customAttributes == null || customAttributes.Length == 0)
                {
                    continue;
                }
                InfoCampoEntidade infoCampoEntidade = (InfoCampoEntidade)customAttributes[0];
                if (infoCampoEntidade == null)
                {
                    continue;
                }
                if (stringBuilder.Length == 0)
                {
                    stringBuilder.Append(ObterColunaComTipo(propertyInfo, infoCampoEntidade));
                }
                else
                {
                    stringBuilder.Append(", ");
                    stringBuilder.Append(ObterColunaComTipo(propertyInfo, infoCampoEntidade));
                }
                if (infoCampoEntidade.ChavePrimaria)
                {
                    if (stringBuilder2.Length == 0)
                    {
                        stringBuilder2.Append(propertyInfo.Name);
                        continue;
                    }
                    stringBuilder2.Append(", ");
                    stringBuilder2.Append(propertyInfo.Name);
                }
            }
            stringBuilder.Insert(0, $"create table {_tipoBase.Name}(");
            if (stringBuilder2.Length > 0)
            {
                stringBuilder.Append(", ");
                stringBuilder.Append($"constraint {_tipoBase.Name} primary key ({stringBuilder2.ToString()})");
            }
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        private bool TabelaExiste()
        {
            bool flag = false;
            OracleCommand val = _conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = $"select count(*) from user_tables where table_name = '{_tipoBase.Name}'";
                return Convert.ToInt32(((DbCommand)(object)val).ExecuteScalar()) > 0;
            }
            finally
            {
                ((IDisposable)val)?.Dispose();
            }
        }

        public bool ModificarTabela()
        {
            bool result = false;
            if (TabelaExiste())
            {
                _observador.Registrar("  Verificando alterações ");
                List<DefinicaoColuna> list = ObterDefinicoesDeColunas();
                List<PropertyInfo> list2 = new List<PropertyInfo>();
                if (list.Count > 0)
                {
                    PropertyInfo[] propriedades = _propriedades;
                    foreach (PropertyInfo propriedade in propriedades)
                    {
                        if (propriedade.GetCustomAttributes(typeof(InfoCampoEntidade), inherit: true).Count() > 0)
                        {
                            DefinicaoColuna definicaoColuna = list.Where((DefinicaoColuna def) => def.Nome == propriedade.Name.ToUpper()).FirstOrDefault();
                            if (definicaoColuna != null)
                            {
                                ValidarAlteracaoColuna(propriedade, definicaoColuna);
                            }
                            else
                            {
                                list2.Add(propriedade);
                            }
                        }
                    }
                    if (list2.Count > 0)
                    {
                        CriarColunasInexistentes(list2);
                    }
                }
            }
            return result;
        }

        private void CriarColunasInexistentes(List<PropertyInfo> colunasParaCriacao)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (PropertyInfo item in colunasParaCriacao)
            {
                object[] customAttributes = item.GetCustomAttributes(typeof(InfoCampoEntidade), inherit: true);
                if (customAttributes == null || customAttributes.Length == 0)
                {
                    continue;
                }
                InfoCampoEntidade infoCampoEntidade = (InfoCampoEntidade)customAttributes[0];
                if (infoCampoEntidade == null)
                {
                    continue;
                }
                string text = ObterColunaComTipo(item, infoCampoEntidade);
                if (text.Length > 0)
                {
                    stringBuilder.AppendLine($"      * {item.Name.ToUpper()}");
                    if (stringBuilder2.Length == 0)
                    {
                        stringBuilder2.Append(text);
                        continue;
                    }
                    stringBuilder2.Append(",");
                    stringBuilder2.Append(text);
                }
            }
            if (stringBuilder2.Length > 0)
            {
                if (colunasParaCriacao.Count == 1)
                {
                    stringBuilder.Insert(0, $"    - Adicionando o campo: {Environment.NewLine}");
                }
                else
                {
                    stringBuilder.Insert(0, $"    - Adicionando os campos: {Environment.NewLine}");
                }
                _observador.Registrar(stringBuilder.ToString());
                stringBuilder2.Insert(0, "alter table " + _tipoBase.Name + " add (");
                stringBuilder2.Append(")");
                ExecutarScript(stringBuilder2.ToString());
            }
        }

        private string ObterColunaComTipo(PropertyInfo propriedade, InfoCampoEntidade atributo)
        {
            string result = string.Empty;
            switch (atributo.Tipo)
            {
                case TipoDoCampoNoBancoDeDados.Decimal:
                    result = string.Format("{0} {1}({2},{3})", propriedade.Name, "NUMBER", atributo.Tamanho, atributo.Precisao);
                    break;
                case TipoDoCampoNoBancoDeDados.Inteiro:
                    result = string.Format("{0} {1}", propriedade.Name, "INT");
                    break;
                case TipoDoCampoNoBancoDeDados.Texto:
                    result = string.Format("{0} {1}({2})", propriedade.Name, "VARCHAR2", atributo.Tamanho);
                    break;
                case TipoDoCampoNoBancoDeDados.Binario:
                    result = string.Format("{0} {1}", propriedade.Name, "CLOB");
                    break;
                case TipoDoCampoNoBancoDeDados.Data:
                    result = string.Format("{0} {1}", propriedade.Name, "DATE");
                    break;
            }
            return result;
        }

        private void ValidarAlteracaoColuna(PropertyInfo propriedade, DefinicaoColuna definicao)
        {
            InfoCampoEntidade infoCampoEntidade = (InfoCampoEntidade)propriedade.GetCustomAttributes(typeof(InfoCampoEntidade), inherit: true)[0];
            if (infoCampoEntidade == null)
            {
                return;
            }
            string text = string.Empty;
            switch (infoCampoEntidade.Tipo)
            {
                case TipoDoCampoNoBancoDeDados.Decimal:
                    if (definicao.TamanhoNumerico > 0 && definicao.PrecisaoNumerica > 0 && (definicao.TamanhoNumerico < infoCampoEntidade.Tamanho || definicao.PrecisaoNumerica < infoCampoEntidade.Precisao))
                    {
                        _observador.Registrar("    - Alterando o campo " + propriedade.Name.ToUpper());
                        text = $"alter table {_tipoBase.Name} modify {propriedade.Name} {definicao.Tipo}({infoCampoEntidade.Tamanho},{infoCampoEntidade.Precisao})";
                    }
                    break;
                case TipoDoCampoNoBancoDeDados.Texto:
                    if ((definicao.Tipo == "VARCHAR2") & (definicao.Tamanho < infoCampoEntidade.Tamanho))
                    {
                        _observador.Registrar("    - Alterando o campo " + propriedade.Name.ToUpper());
                        text = $"alter table {_tipoBase.Name} modify {propriedade.Name} {definicao.Tipo}({infoCampoEntidade.Tamanho})";
                    }
                    break;
            }
            if (!string.IsNullOrEmpty(text))
            {
                ExecutarScript(text);
            }
        }

        private List<DefinicaoColuna> ObterDefinicoesDeColunas()
        {
            List<DefinicaoColuna> list = new List<DefinicaoColuna>();
            OracleCommand val = _conexao.CreateCommand();
            try
            {
                ((DbCommand)(object)val).CommandText = "select column_name, data_type, nvl(data_length,0) data_length, nvl(data_precision,0) data_precision, nvl(data_scale,0) data_scale, nullable from user_tab_cols where table_name = '" + _tipoBase.Name + "'";
                OracleDataReader val2 = val.ExecuteReader();
                try
                {
                    if (((DbDataReader)(object)val2).HasRows)
                    {
                        while (((DbDataReader)(object)val2).Read())
                        {
                            list.Add(new DefinicaoColuna(val2));
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
            return list;
        }

        private Type ObterTipoDaEntidade(Type tipo)
        {
            Type type = tipo;
            while (type.BaseType != typeof(GerenteDePropriedades))
            {
                type = type.BaseType;
            }
            return type;
        }

        public void Dispose()
        {
        }

        public void Registrar(string texto)
        {
        }

        public void RegistrarPercetualAndamento(int parcial, int total)
        {
        }
    }

}
