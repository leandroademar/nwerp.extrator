

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCOMPLEMENTONFCE : GerenteDePropriedades, IEntidade
{
    private string _ambiente;

    private string _chavenfce;

    private string _codfilial;

    private decimal? _codstatus;

    private DateTime? _data;

    private string _exportado;

    private string _mensagem;

    private decimal? _numcaixa;

    private decimal? _numcaixafiscal;

    private decimal? _numnota;

    private decimal? _numpedecf;

    private string _operacao;

    private string _protocolonfce;

    private string _xmlnfce;

    private static readonly string RO_DTHORAAUTORIZACAOSEFAZ = "Dthoraautorizacaosefaz";

    private DateTime? _dthoraautorizacaosefaz;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Chavenfce
    {
        get
        {
            PropriedadeAcessada("Chavenfce");
            return _chavenfce;
        }
        set
        {
            PropriedadeModificada("Chavenfce", value);
            _chavenfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codstatus
    {
        get
        {
            PropriedadeAcessada("Codstatus");
            return _codstatus;
        }
        set
        {
            PropriedadeModificada("Codstatus", value);
            _codstatus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Mensagem
    {
        get
        {
            PropriedadeAcessada("Mensagem");
            return _mensagem;
        }
        set
        {
            PropriedadeModificada("Mensagem", value);
            _mensagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numcaixa
    {
        get
        {
            PropriedadeAcessada("Numcaixa");
            return _numcaixa;
        }
        set
        {
            PropriedadeModificada("Numcaixa", value);
            _numcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada("Numcaixafiscal");
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada("Numcaixafiscal", value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnota
    {
        get
        {
            PropriedadeAcessada("Numnota");
            return _numnota;
        }
        set
        {
            PropriedadeModificada("Numnota", value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada("Numpedecf");
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada("Numpedecf", value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Operacao
    {
        get
        {
            PropriedadeAcessada("Operacao");
            return _operacao;
        }
        set
        {
            PropriedadeModificada("Operacao", value);
            _operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Protocolonfce
    {
        get
        {
            PropriedadeAcessada("Protocolonfce");
            return _protocolonfce;
        }
        set
        {
            PropriedadeModificada("Protocolonfce", value);
            _protocolonfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Xmlnfce
    {
        get
        {
            PropriedadeAcessada("Xmlnfce");
            return _xmlnfce;
        }
        set
        {
            PropriedadeModificada("Xmlnfce", value);
            _xmlnfce = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOMPLEMENTONFCE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraautorizacaosefaz
    {
        get
        {
            PropriedadeAcessada(RO_DTHORAAUTORIZACAOSEFAZ);
            return _dthoraautorizacaosefaz;
        }
        set
        {
            PropriedadeModificada(RO_DTHORAAUTORIZACAOSEFAZ, value);
            _dthoraautorizacaosefaz = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCOMPLEMENTONFCE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _chavenfce = AlterarTipo<string>(leitor["Chavenfce"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codstatus = AlterarTipo<decimal?>(leitor["Codstatus"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _mensagem = AlterarTipo<string>(leitor["Mensagem"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numnota = AlterarTipo<decimal?>(leitor["Numnota"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _protocolonfce = AlterarTipo<string>(leitor["Protocolonfce"]);
        _dthoraautorizacaosefaz = AlterarTipo<DateTime?>(leitor["Dthoraautorizacaosefaz"]);
        _xmlnfce = AlterarTipo<string>(leitor["Xmlnfce"]);
    }

}