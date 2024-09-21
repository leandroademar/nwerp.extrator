

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOGECF : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_DATAIMPORTACAO = "Dataimportacao";

    private DateTime? _dataimportacao;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTLOG = "Dtlog";

    private DateTime? _dtlog;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_HORAIMPORTACAO = "Horaimportacao";

    private decimal? _horaimportacao;

    private static readonly string RO_IMPORTADO = "Importado";

    private string _importado;

    private static readonly string RO_MINUTOIMPORTCAO = "Minutoimportcao";

    private decimal? _minutoimportcao;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_OBSERVACOES = "Observacoes";

    private string _observacoes;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataimportacao
    {
        get
        {
            PropriedadeAcessada(RO_DATAIMPORTACAO);
            return _dataimportacao;
        }
        set
        {
            PropriedadeModificada(RO_DATAIMPORTACAO, value);
            _dataimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlog
    {
        get
        {
            PropriedadeAcessada(RO_DTLOG);
            return _dtlog;
        }
        set
        {
            PropriedadeModificada(RO_DTLOG, value);
            _dtlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaimportacao
    {
        get
        {
            PropriedadeAcessada(RO_HORAIMPORTACAO);
            return _horaimportacao;
        }
        set
        {
            PropriedadeModificada(RO_HORAIMPORTACAO, value);
            _horaimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADO);
            return _importado;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADO, value);
            _importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoimportcao
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOIMPORTCAO);
            return _minutoimportcao;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOIMPORTCAO, value);
            _minutoimportcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAR);
            return _numcar;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAR, value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada(RO_NUMPED);
            return _numped;
        }
        set
        {
            PropriedadeModificada(RO_NUMPED, value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Observacoes
    {
        get
        {
            PropriedadeAcessada(RO_OBSERVACOES);
            return _observacoes;
        }
        set
        {
            PropriedadeModificada(RO_OBSERVACOES, value);
            _observacoes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOGECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada(RO_POSICAO);
            return _posicao;
        }
        set
        {
            PropriedadeModificada(RO_POSICAO, value);
            _posicao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOGECF";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _dataimportacao = AlterarTipo<DateTime?>(leitor["Dataimportacao"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtlog = AlterarTipo<DateTime?>(leitor["Dtlog"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _horaimportacao = AlterarTipo<decimal?>(leitor["Horaimportacao"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _minutoimportcao = AlterarTipo<decimal?>(leitor["Minutoimportcao"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _observacoes = AlterarTipo<string>(leitor["Observacoes"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
    }

}