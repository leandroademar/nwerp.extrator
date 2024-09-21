

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCRECARGACEL : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODOPERRECARGACEL = "Codoperrecargacel";

    private decimal? _codoperrecargacel;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_NSU = "Nsu";

    private decimal? _nsu;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_OPERADORA = "Operadora";

    private string _operadora;

    private static readonly string RO_RECNUM = "Recnum";

    private decimal? _recnum;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_TIPOOPERACAO = "Tipooperacao";

    private string _tipooperacao;

    private static readonly string RO_INFPRODUTO = "Infproduto";

    private string _infproduto;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIAL);
            return _codfilial;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIAL, value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccx
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCX);
            return _codfunccx;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCX, value);
            _codfunccx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Codoperrecargacel
    {
        get
        {
            PropriedadeAcessada(RO_CODOPERRECARGACEL);
            return _codoperrecargacel;
        }
        set
        {
            PropriedadeModificada(RO_CODOPERRECARGACEL, value);
            _codoperrecargacel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
    {
        get
        {
            PropriedadeAcessada(RO_DATA);
            return _data;
        }
        set
        {
            PropriedadeModificada(RO_DATA, value);
            _data = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAO);
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAO, value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADO);
            return _exportado;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADO, value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Nsu
    {
        get
        {
            PropriedadeAcessada(RO_NSU);
            return _nsu;
        }
        set
        {
            PropriedadeModificada(RO_NSU, value);
            _nsu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupom
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOM);
            return _numcupom;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOM, value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numpedecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDECF);
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDECF, value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserieequip
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP);
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP, value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDA);
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDA, value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Operadora
    {
        get
        {
            PropriedadeAcessada(RO_OPERADORA);
            return _operadora;
        }
        set
        {
            PropriedadeModificada(RO_OPERADORA, value);
            _operadora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Recnum
    {
        get
        {
            PropriedadeAcessada(RO_RECNUM);
            return _recnum;
        }
        set
        {
            PropriedadeModificada(RO_RECNUM, value);
            _recnum = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valor
    {
        get
        {
            PropriedadeAcessada(RO_VALOR);
            return _valor;
        }
        set
        {
            PropriedadeModificada(RO_VALOR, value);
            _valor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipooperacao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOOPERACAO);
            return _tipooperacao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOOPERACAO, value);
            _tipooperacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Infproduto
    {
        get
        {
            PropriedadeAcessada(RO_INFPRODUTO);
            return _infproduto;
        }
        set
        {
            PropriedadeModificada(RO_INFPRODUTO, value);
            _infproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numfechamentomovcx
    {
        get
        {
            PropriedadeAcessada("Numfechamentomovcx");
            return _numfechamentomovcx;
        }
        set
        {
            PropriedadeModificada("Numfechamentomovcx", value);
            _numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCRECARGACEL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            PropriedadeAcessada("Dtmovimentocx");
            return _dtmovimentocx;
        }
        set
        {
            PropriedadeModificada("Dtmovimentocx", value);
            _dtmovimentocx = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCRECARGACEL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codoperrecargacel = AlterarTipo<decimal?>(leitor["Codoperrecargacel"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _nsu = AlterarTipo<decimal?>(leitor["Nsu"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _operadora = AlterarTipo<string>(leitor["Operadora"]);
        _recnum = AlterarTipo<decimal?>(leitor["Recnum"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _tipooperacao = AlterarTipo<string>(leitor["Tipooperacao"]);
        _infproduto = AlterarTipo<string>(leitor["Infproduto"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
    }

}