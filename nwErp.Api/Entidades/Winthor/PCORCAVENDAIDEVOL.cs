

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAIDEVOL : GerenteDePropriedades, IEntidade
{
    private decimal? _codauxiliar;

    private decimal? _codimp;

    private decimal? _codprod;

    private decimal? _codst;

    private decimal? _codsupervlibdevol;

    private decimal? _codusuariodevol;

    private decimal? _codusuariopedido;

    private DateTime? _datadevol;

    private string _historico;

    private string _impressorestaurante;

    private string _imprimerestaurante;

    private decimal? _numficha;

    private decimal? _numorca;

    private decimal? _numseq;

    private decimal? _numseqimpressao;

    private decimal? _ptabela;

    private decimal? _pvenda;

    private decimal? _qt;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codsupervlibdevol
    {
        get
        {
            PropriedadeAcessada("Codsupervlibdevol");
            return _codsupervlibdevol;
        }
        set
        {
            PropriedadeModificada("Codsupervlibdevol", value);
            _codsupervlibdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuariodevol
    {
        get
        {
            PropriedadeAcessada("Codusuariodevol");
            return _codusuariodevol;
        }
        set
        {
            PropriedadeModificada("Codusuariodevol", value);
            _codusuariodevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuariopedido
    {
        get
        {
            PropriedadeAcessada("Codusuariopedido");
            return _codusuariopedido;
        }
        set
        {
            PropriedadeModificada("Codusuariopedido", value);
            _codusuariopedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datadevol
    {
        get
        {
            PropriedadeAcessada("Datadevol");
            return _datadevol;
        }
        set
        {
            PropriedadeModificada("Datadevol", value);
            _datadevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada("Historico");
            return _historico;
        }
        set
        {
            PropriedadeModificada("Historico", value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numficha
    {
        get
        {
            PropriedadeAcessada("Numficha");
            return _numficha;
        }
        set
        {
            PropriedadeModificada("Numficha", value);
            _numficha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAIDEVOL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAIDEVOL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codimp = AlterarTipo<decimal?>(leitor["Codimp"]);
        _codprod = AlterarTipo<decimal?>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codsupervlibdevol = AlterarTipo<decimal?>(leitor["Codsupervlibdevol"]);
        _codusuariodevol = AlterarTipo<decimal?>(leitor["Codusuariodevol"]);
        _codusuariopedido = AlterarTipo<decimal?>(leitor["Codusuariopedido"]);
        _datadevol = AlterarTipo<DateTime?>(leitor["Datadevol"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _impressorestaurante = AlterarTipo<string>(leitor["Impressorestaurante"]);
        _imprimerestaurante = AlterarTipo<string>(leitor["Imprimerestaurante"]);
        _numficha = AlterarTipo<decimal?>(leitor["Numficha"]);
        _numorca = AlterarTipo<decimal?>(leitor["Numorca"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numseqimpressao = AlterarTipo<decimal?>(leitor["Numseqimpressao"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
    }

}