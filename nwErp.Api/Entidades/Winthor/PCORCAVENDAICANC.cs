

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAICANC : GerenteDePropriedades, IEntidade
{
    private decimal? _codauxiliar;

    private string _codfilial;

    private decimal? _codfunccanc;

    private decimal? _codgarcomcanc;

    private decimal? _codimp;

    private decimal? _codprod;

    private decimal? _codst;

    private decimal? _codsupervlibcanc;

    private DateTime? _datacanc;

    private DateTime? _dtabertura;

    private string _impressorestaurante;

    private string _imprimerestaurante;

    private string _motivocanc;

    private decimal? _numfichadest;

    private decimal? _numfichaorig;

    private decimal? _numorca;

    private decimal? _numorcadest;

    private decimal? _numseq;

    private decimal? _numseqimpressao;

    private decimal? _ptabela;

    private decimal? _pvenda;

    private decimal? _qt;

    private string _rotinalanc;

    private string _tipocancel;

    private string _md5paf;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Codauxiliar
    {
        get
        {
            PropriedadeAcessada("Codauxiliar");
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada("Codauxiliar", value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccanc
    {
        get
        {
            PropriedadeAcessada("Codfunccanc");
            return _codfunccanc;
        }
        set
        {
            PropriedadeModificada("Codfunccanc", value);
            _codfunccanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codgarcomcanc
    {
        get
        {
            PropriedadeAcessada("Codgarcomcanc");
            return _codgarcomcanc;
        }
        set
        {
            PropriedadeModificada("Codgarcomcanc", value);
            _codgarcomcanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codimp
    {
        get
        {
            PropriedadeAcessada("Codimp");
            return _codimp;
        }
        set
        {
            PropriedadeModificada("Codimp", value);
            _codimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprod
    {
        get
        {
            PropriedadeAcessada("Codprod");
            return _codprod;
        }
        set
        {
            PropriedadeModificada("Codprod", value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada("Codst");
            return _codst;
        }
        set
        {
            PropriedadeModificada("Codst", value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codsupervlibcanc
    {
        get
        {
            PropriedadeAcessada("Codsupervlibcanc");
            return _codsupervlibcanc;
        }
        set
        {
            PropriedadeModificada("Codsupervlibcanc", value);
            _codsupervlibcanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacanc
    {
        get
        {
            PropriedadeAcessada("Datacanc");
            return _datacanc;
        }
        set
        {
            PropriedadeModificada("Datacanc", value);
            _datacanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtabertura
    {
        get
        {
            PropriedadeAcessada("Dtabertura");
            return _dtabertura;
        }
        set
        {
            PropriedadeModificada("Dtabertura", value);
            _dtabertura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impressorestaurante
    {
        get
        {
            PropriedadeAcessada("Impressorestaurante");
            return _impressorestaurante;
        }
        set
        {
            PropriedadeModificada("Impressorestaurante", value);
            _impressorestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimerestaurante
    {
        get
        {
            PropriedadeAcessada("Imprimerestaurante");
            return _imprimerestaurante;
        }
        set
        {
            PropriedadeModificada("Imprimerestaurante", value);
            _imprimerestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 120, Precisao = 0)]
    public string Motivocanc
    {
        get
        {
            PropriedadeAcessada("Motivocanc");
            return _motivocanc;
        }
        set
        {
            PropriedadeModificada("Motivocanc", value);
            _motivocanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numfichadest
    {
        get
        {
            PropriedadeAcessada("Numfichadest");
            return _numfichadest;
        }
        set
        {
            PropriedadeModificada("Numfichadest", value);
            _numfichadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numfichaorig
    {
        get
        {
            PropriedadeAcessada("Numfichaorig");
            return _numfichaorig;
        }
        set
        {
            PropriedadeModificada("Numfichaorig", value);
            _numfichaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcadest
    {
        get
        {
            PropriedadeAcessada("Numorcadest");
            return _numorcadest;
        }
        set
        {
            PropriedadeModificada("Numorcadest", value);
            _numorcadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada("Numseq");
            return _numseq;
        }
        set
        {
            PropriedadeModificada("Numseq", value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqimpressao
    {
        get
        {
            PropriedadeAcessada("Numseqimpressao");
            return _numseqimpressao;
        }
        set
        {
            PropriedadeModificada("Numseqimpressao", value);
            _numseqimpressao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal? Ptabela
    {
        get
        {
            PropriedadeAcessada("Ptabela");
            return _ptabela;
        }
        set
        {
            PropriedadeModificada("Ptabela", value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal? Pvenda
    {
        get
        {
            PropriedadeAcessada("Pvenda");
            return _pvenda;
        }
        set
        {
            PropriedadeModificada("Pvenda", value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qt
    {
        get
        {
            PropriedadeAcessada("Qt");
            return _qt;
        }
        set
        {
            PropriedadeModificada("Qt", value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocancel
    {
        get
        {
            PropriedadeAcessada("Tipocancel");
            return _tipocancel;
        }
        set
        {
            PropriedadeModificada("Tipocancel", value);
            _tipocancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAICANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAICANC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccanc = AlterarTipo<decimal?>(leitor["Codfunccanc"]);
        _codgarcomcanc = AlterarTipo<decimal?>(leitor["Codgarcomcanc"]);
        _codimp = AlterarTipo<decimal?>(leitor["Codimp"]);
        _codprod = AlterarTipo<decimal?>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codsupervlibcanc = AlterarTipo<decimal?>(leitor["Codsupervlibcanc"]);
        _datacanc = AlterarTipo<DateTime?>(leitor["Datacanc"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _impressorestaurante = AlterarTipo<string>(leitor["Impressorestaurante"]);
        _imprimerestaurante = AlterarTipo<string>(leitor["Imprimerestaurante"]);
        _motivocanc = AlterarTipo<string>(leitor["Motivocanc"]);
        _numfichadest = AlterarTipo<decimal?>(leitor["Numfichadest"]);
        _numfichaorig = AlterarTipo<decimal?>(leitor["Numfichaorig"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numorcadest = AlterarTipo<decimal?>(leitor["Numorcadest"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqimpressao = AlterarTipo<decimal?>(leitor["Numseqimpressao"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _tipocancel = AlterarTipo<string>(leitor["Tipocancel"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
    }

}