

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPRESTPAF : GerenteDePropriedades, IEntidade
{
    private string _codcob;

    private string _codfilial;

    private DateTime? _dtemissao;

    private string _md5paf;

    private decimal? _numcaixa;

    private decimal? _numcaixafiscal;

    private string _numserieequip;

    private decimal? _tipodoc;

    private decimal? _valor;

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada("Codcob");
            return _codcob;
        }
        set
        {
            PropriedadeModificada("Codcob", value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada("Numserieequip");
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada("Numserieequip", value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Tipodoc
    {
        get
        {
            PropriedadeAcessada("Tipodoc");
            return _tipodoc;
        }
        set
        {
            PropriedadeModificada("Tipodoc", value);
            _tipodoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPAF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada("Valor");
            return _valor;
        }
        set
        {
            PropriedadeModificada("Valor", value);
            _valor = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPRESTPAF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _dtemissao = AlterarTipo<DateTime?>(leitor["Dtemissao"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _tipodoc = AlterarTipo<decimal?>(leitor["Tipodoc"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
    }

}