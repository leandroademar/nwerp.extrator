

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCSAQUETEF : GerenteDePropriedades, IEntidade
{
    private string _codfilial;

    private decimal? _ccf;

    private string _cnpj;

    private DateTime? _dtemissao;

    private decimal? _matricula;

    private string _md5paf;

    private decimal? _numcaixa;

    private decimal _numcupom;

    private decimal _numpedecf;

    private string _razaobeneficiada;

    private string _rotinalanc;

    private decimal? _vlsaque;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Ccf
    {
        get
        {
            PropriedadeAcessada("Ccf");
            return _ccf;
        }
        set
        {
            PropriedadeModificada("Ccf", value);
            _ccf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
    public string Cnpj
    {
        get
        {
            PropriedadeAcessada("Cnpj");
            return _cnpj;
        }
        set
        {
            PropriedadeModificada("Cnpj", value);
            _cnpj = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissao
    {
        get
        {
            PropriedadeAcessada("Dtemissao");
            return _dtemissao;
        }
        set
        {
            PropriedadeModificada("Dtemissao", value);
            _dtemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada("Matricula");
            return _matricula;
        }
        set
        {
            PropriedadeModificada("Matricula", value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            PropriedadeAcessada("Md5paf");
            return _md5paf;
        }
        set
        {
            PropriedadeModificada("Md5paf", value);
            _md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numcupom
    {
        get
        {
            PropriedadeAcessada("Numcupom");
            return _numcupom;
        }
        set
        {
            PropriedadeModificada("Numcupom", value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Razaobeneficiada
    {
        get
        {
            PropriedadeAcessada("Razaobeneficiada");
            return _razaobeneficiada;
        }
        set
        {
            PropriedadeModificada("Razaobeneficiada", value);
            _razaobeneficiada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rotinalanc
    {
        get
        {
            PropriedadeAcessada("Rotinalanc");
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada("Rotinalanc", value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCSAQUETEF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlsaque
    {
        get
        {
            PropriedadeAcessada("Vlsaque");
            return _vlsaque;
        }
        set
        {
            PropriedadeModificada("Vlsaque", value);
            _vlsaque = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCSAQUETEF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _ccf = AlterarTipo<decimal?>(leitor["Ccf"]);
        _cnpj = AlterarTipo<string>(leitor["Cnpj"]);
        _dtemissao = AlterarTipo<DateTime?>(leitor["Dtemissao"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal>(leitor["Numcupom"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _razaobeneficiada = AlterarTipo<string>(leitor["Razaobeneficiada"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _vlsaque = AlterarTipo<decimal?>(leitor["Vlsaque"]);
    }

}