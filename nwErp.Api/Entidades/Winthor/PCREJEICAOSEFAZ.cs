

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCREJEICAOSEFAZ : GerenteDePropriedades, IEntidade
{
    private decimal _codfunccx;

    private DateTime _data;

    private DateTime _datahora;

    private string _exportado;

    private string _msgrejeicao;

    private string _msgrejeicao2;

    private decimal _numcaixa;

    private decimal _numcaixafiscal;

    private decimal _numpedecf;

    private decimal _numpedecfauxiliar;

    private string _tipodocfiscal;

    private decimal _tipoemissao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunccx
    {
        get
        {
            PropriedadeAcessada("Codfunccx");
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada("Codfunccx", value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Datahora
    {
        get
        {
            PropriedadeAcessada("Datahora");
            return _datahora;
        }
        set
        {
            PropriedadeModificada("Datahora", value);
            _datahora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4000, Precisao = 0)]
    public string Msgrejeicao
    {
        get
        {
            PropriedadeAcessada("Msgrejeicao");
            return _msgrejeicao;
        }
        set
        {
            PropriedadeModificada("Msgrejeicao", value);
            _msgrejeicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Msgrejeicao2
    {
        get
        {
            PropriedadeAcessada("Msgrejeicao2");
            return _msgrejeicao2;
        }
        set
        {
            PropriedadeModificada("Msgrejeicao2", value);
            _msgrejeicao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixafiscal
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecfauxiliar
    {
        get
        {
            PropriedadeAcessada("Numpedecfauxiliar");
            return _numpedecfauxiliar;
        }
        set
        {
            PropriedadeModificada("Numpedecfauxiliar", value);
            _numpedecfauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Tipodocfiscal
    {
        get
        {
            PropriedadeAcessada("Tipodocfiscal");
            return _tipodocfiscal;
        }
        set
        {
            PropriedadeModificada("Tipodocfiscal", value);
            _tipodocfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREJEICAOSEFAZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal Tipoemissao
    {
        get
        {
            PropriedadeAcessada("Tipoemissao");
            return _tipoemissao;
        }
        set
        {
            PropriedadeModificada("Tipoemissao", value);
            _tipoemissao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCREJEICAOSEFAZ";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfunccx = AlterarTipo<decimal>(leitor["Codfunccx"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _datahora = AlterarTipo<DateTime>(leitor["Datahora"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _msgrejeicao = AlterarTipo<string>(leitor["Msgrejeicao"]);
        _msgrejeicao2 = AlterarTipo<string>(leitor["Msgrejeicao2"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal>(leitor["Numcaixafiscal"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numpedecfauxiliar = AlterarTipo<decimal>(leitor["Numpedecfauxiliar"]);
        _tipodocfiscal = AlterarTipo<string>(leitor["Tipodocfiscal"]);
        _tipoemissao = AlterarTipo<decimal>(leitor["Tipoemissao"]);
    }

}