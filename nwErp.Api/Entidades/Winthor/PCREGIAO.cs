

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCREGIAO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ATUALIZAF11 = "Atualizaf11";

    private string _atualizaf11;

    private static readonly string RO_CODESTABELECIMENTO = "Codestabelecimento";

    private string _codestabelecimento;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_EXPORTAFV = "Exportafv";

    private decimal? _exportafv;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal _numregiao;

    private static readonly string RO_NUMTABELA = "Numtabela";

    private string _numtabela;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_PERFRETE = "Perfrete";

    private decimal _perfrete;

    private static readonly string RO_PERFRETECONHEC = "Perfreteconhec";

    private decimal? _perfreteconhec;

    private static readonly string RO_PERFRETEESPECIAL = "Perfreteespecial";

    private decimal? _perfreteespecial;

    private static readonly string RO_PERFRETETERCEIROS = "Perfreteterceiros";

    private decimal? _perfreteterceiros;

    private static readonly string RO_REGIAO = "Regiao";

    private string _regiao;

    private static readonly string RO_REGIAOZFM = "Regiaozfm";

    private string _regiaozfm;

    private static readonly string RO_SEGMENTO = "Segmento";

    private string _segmento;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_TAREPF = "Tarepf";

    private string _tarepf;

    private static readonly string RO_UF = "Uf";

    private string _uf;

    private static readonly string RO_VLFRETEKG = "Vlfretekg";

    private decimal? _vlfretekg;

    private static readonly string RO_VLFRETEKGPADRAO = "Vlfretekgpadrao";

    private decimal? _vlfretekgpadrao;

    private static readonly string RO_VLFRETEKGVENDA = "Vlfretekgvenda";

    private decimal? _vlfretekgvenda;

    private static readonly string RO_VLMINFATBK = "Vlminfatbk";

    private decimal? _vlminfatbk;

    private static readonly string RO_VLMINFATCH = "Vlminfatch";

    private decimal? _vlminfatch;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaf11
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAF11);
            return _atualizaf11;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAF11, value);
            _atualizaf11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codestabelecimento
    {
        get
        {
            PropriedadeAcessada(RO_CODESTABELECIMENTO);
            return _codestabelecimento;
        }
        set
        {
            PropriedadeModificada(RO_CODESTABELECIMENTO, value);
            _codestabelecimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Exportafv
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTAFV);
            return _exportafv;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTAFV, value);
            _exportafv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numregiao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO);
            return _numregiao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO, value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numtabela
    {
        get
        {
            PropriedadeAcessada(RO_NUMTABELA);
            return _numtabela;
        }
        set
        {
            PropriedadeModificada(RO_NUMTABELA, value);
            _numtabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada(RO_OBS);
            return _obs;
        }
        set
        {
            PropriedadeModificada(RO_OBS, value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal Perfrete
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETE);
            return _perfrete;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETE, value);
            _perfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfreteconhec
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETECONHEC);
            return _perfreteconhec;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETECONHEC, value);
            _perfreteconhec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfreteespecial
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETEESPECIAL);
            return _perfreteespecial;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETEESPECIAL, value);
            _perfreteespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfreteterceiros
    {
        get
        {
            PropriedadeAcessada(RO_PERFRETETERCEIROS);
            return _perfreteterceiros;
        }
        set
        {
            PropriedadeModificada(RO_PERFRETETERCEIROS, value);
            _perfreteterceiros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Regiao
    {
        get
        {
            PropriedadeAcessada(RO_REGIAO);
            return _regiao;
        }
        set
        {
            PropriedadeModificada(RO_REGIAO, value);
            _regiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Regiaozfm
    {
        get
        {
            PropriedadeAcessada(RO_REGIAOZFM);
            return _regiaozfm;
        }
        set
        {
            PropriedadeModificada(RO_REGIAOZFM, value);
            _regiaozfm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Segmento
    {
        get
        {
            PropriedadeAcessada(RO_SEGMENTO);
            return _segmento;
        }
        set
        {
            PropriedadeModificada(RO_SEGMENTO, value);
            _segmento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada(RO_STATUS);
            return _status;
        }
        set
        {
            PropriedadeModificada(RO_STATUS, value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tarepf
    {
        get
        {
            PropriedadeAcessada(RO_TAREPF);
            return _tarepf;
        }
        set
        {
            PropriedadeModificada(RO_TAREPF, value);
            _tarepf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Uf
    {
        get
        {
            PropriedadeAcessada(RO_UF);
            return _uf;
        }
        set
        {
            PropriedadeModificada(RO_UF, value);
            _uf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Vlfretekg
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETEKG);
            return _vlfretekg;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETEKG, value);
            _vlfretekg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Vlfretekgpadrao
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETEKGPADRAO);
            return _vlfretekgpadrao;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETEKGPADRAO, value);
            _vlfretekgpadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Vlfretekgvenda
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETEKGVENDA);
            return _vlfretekgvenda;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETEKGVENDA, value);
            _vlfretekgvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vlminfatbk
    {
        get
        {
            PropriedadeAcessada(RO_VLMINFATBK);
            return _vlminfatbk;
        }
        set
        {
            PropriedadeModificada(RO_VLMINFATBK, value);
            _vlminfatbk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCREGIAO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vlminfatch
    {
        get
        {
            PropriedadeAcessada(RO_VLMINFATCH);
            return _vlminfatch;
        }
        set
        {
            PropriedadeModificada(RO_VLMINFATCH, value);
            _vlminfatch = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCREGIAO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _atualizaf11 = AlterarTipo<string>(leitor["Atualizaf11"]);
        _codestabelecimento = AlterarTipo<string>(leitor["Codestabelecimento"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _exportafv = AlterarTipo<decimal?>(leitor["Exportafv"]);
        _numregiao = AlterarTipo<decimal>(leitor["Numregiao"]);
        _numtabela = AlterarTipo<string>(leitor["Numtabela"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _perfrete = AlterarTipo<decimal>(leitor["Perfrete"]);
        _perfreteconhec = AlterarTipo<decimal?>(leitor["Perfreteconhec"]);
        _perfreteespecial = AlterarTipo<decimal?>(leitor["Perfreteespecial"]);
        _perfreteterceiros = AlterarTipo<decimal?>(leitor["Perfreteterceiros"]);
        _regiao = AlterarTipo<string>(leitor["Regiao"]);
        _regiaozfm = AlterarTipo<string>(leitor["Regiaozfm"]);
        _segmento = AlterarTipo<string>(leitor["Segmento"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _tarepf = AlterarTipo<string>(leitor["Tarepf"]);
        _uf = AlterarTipo<string>(leitor["Uf"]);
        _vlfretekg = AlterarTipo<decimal?>(leitor["Vlfretekg"]);
        _vlfretekgpadrao = AlterarTipo<decimal?>(leitor["Vlfretekgpadrao"]);
        _vlfretekgvenda = AlterarTipo<decimal?>(leitor["Vlfretekgvenda"]);
        _vlminfatbk = AlterarTipo<decimal?>(leitor["Vlminfatbk"]);
        _vlminfatch = AlterarTipo<decimal?>(leitor["Vlminfatch"]);
    }

}