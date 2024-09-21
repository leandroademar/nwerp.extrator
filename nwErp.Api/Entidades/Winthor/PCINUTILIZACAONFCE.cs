

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCINUTILIZACAONFCE : GerenteDePropriedades, IEntidade
{
    private string _ambiente;

    private decimal _ano;

    private string _codfilial;

    private decimal? _codusuario;

    private DateTime? _dthoraprocessamento;

    private string _exportado;

    private string _justificativa;

    private decimal _numnotafinal;

    private decimal _numnotainicial;

    private string _protocoloinutilizacao;

    private decimal _serie;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private DateTime? _data;

    private string _posicao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ambiente
    {
        get
        {
            PropriedadeAcessada("Ambiente");
            return _ambiente;
        }
        set
        {
            PropriedadeModificada("Ambiente", value);
            _ambiente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Ano
    {
        get
        {
            PropriedadeAcessada("Ano");
            return _ano;
        }
        set
        {
            PropriedadeModificada("Ano", value);
            _ano = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuario
    {
        get
        {
            PropriedadeAcessada("Codusuario");
            return _codusuario;
        }
        set
        {
            PropriedadeModificada("Codusuario", value);
            _codusuario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraprocessamento
    {
        get
        {
            PropriedadeAcessada("Dthoraprocessamento");
            return _dthoraprocessamento;
        }
        set
        {
            PropriedadeModificada("Dthoraprocessamento", value);
            _dthoraprocessamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada("Exportado");
            return _exportado;
        }
        set
        {
            PropriedadeModificada("Exportado", value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 256, Precisao = 0)]
    public string Justificativa
    {
        get
        {
            PropriedadeAcessada("Justificativa");
            return _justificativa;
        }
        set
        {
            PropriedadeModificada("Justificativa", value);
            _justificativa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numnotafinal
    {
        get
        {
            PropriedadeAcessada("Numnotafinal");
            return _numnotafinal;
        }
        set
        {
            PropriedadeModificada("Numnotafinal", value);
            _numnotafinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numnotainicial
    {
        get
        {
            PropriedadeAcessada("Numnotainicial");
            return _numnotainicial;
        }
        set
        {
            PropriedadeModificada("Numnotainicial", value);
            _numnotainicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocoloinutilizacao
    {
        get
        {
            PropriedadeAcessada("Protocoloinutilizacao");
            return _protocoloinutilizacao;
        }
        set
        {
            PropriedadeModificada("Protocoloinutilizacao", value);
            _protocoloinutilizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Serie
    {
        get
        {
            PropriedadeAcessada("Serie");
            return _serie;
        }
        set
        {
            PropriedadeModificada("Serie", value);
            _serie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXA);
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXA, value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
    {
        get
        {
            PropriedadeAcessada("Data");
            return _data;
        }
        set
        {
            PropriedadeModificada("Data", value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCINUTILIZACAONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada("Posicao");
            return _posicao;
        }
        set
        {
            PropriedadeModificada("Posicao", value);
            _posicao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCINUTILIZACAONFCE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _ano = AlterarTipo<decimal>(leitor["Ano"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codusuario = AlterarTipo<decimal?>(leitor["Codusuario"]);
        _dthoraprocessamento = AlterarTipo<DateTime?>(leitor["Dthoraprocessamento"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _justificativa = AlterarTipo<string>(leitor["Justificativa"]);
        _numnotafinal = AlterarTipo<decimal>(leitor["Numnotafinal"]);
        _numnotainicial = AlterarTipo<decimal>(leitor["Numnotainicial"]);
        _protocoloinutilizacao = AlterarTipo<string>(leitor["Protocoloinutilizacao"]);
        _serie = AlterarTipo<decimal>(leitor["Serie"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
    }

}