

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCORIGEMPRECO : GerenteDePropriedades, IEntidade
{
    private decimal? _codautorizacao;

    private decimal? _codauxiliar;

    private decimal? _codcampanha;

    private decimal? _codcli;

    private decimal? _coddescflex;

    private decimal? _coddesconto;

    private decimal? _coddescpbase;

    private decimal? _coddescptabela;

    private decimal? _coddescvolptabela;

    private decimal? _coddescvolume;

    private decimal? _codemitente;

    private decimal? _codfidelidade;

    private decimal? _codfigvendatriangular;

    private string _codfilial;

    private string _codfilialnf;

    private decimal? _codfiscal;

    private decimal? _codfunccx;

    private decimal? _codplpag;

    private decimal? _codprecofixo;

    private decimal _codprod;

    private decimal? _codprodsubst;

    private decimal? _codrotinadescflex;

    private decimal? _codrotinadescptabela;

    private decimal? _codrotinapbase;

    private decimal? _colunapreco;

    private string _creditapoliticapbase;

    private DateTime? _data;

    private DateTime? _dtexportacao;

    private DateTime? _dtfimautor;

    private DateTime? _dtfimdescflex;

    private DateTime? _dtfimdescpbase;

    private DateTime? _dtfimdescptabela;

    private DateTime? _dtfimdescvolume;

    private DateTime? _dtfimfidelidade;

    private DateTime? _dtfimoferta;

    private DateTime? _dtinicioautor;

    private DateTime? _dtiniciodescflex;

    private DateTime? _dtiniciodescpbase;

    private DateTime? _dtiniciodescptabela;

    private DateTime? _dtiniciodescvolume;

    private DateTime? _dtiniciooferta;

    private DateTime? _dtinifidelidade;

    private string _exportado;

    private decimal? _fatorpreco;

    private decimal? _fimintervalo;

    private decimal? _fimintervaloautori;

    private decimal? _fimintervalopbase;

    private decimal? _fimintervaloptabela;

    private string _importado;

    private decimal? _inciointervaloautori;

    private decimal? _iniciointervalo;

    private decimal? _iniciointervaloautori;

    private decimal? _iniciointervalopbase;

    private decimal? _iniciointervaloptabela;

    private string _naodebitapoliticapbase;

    private decimal? _numcaixa;

    private decimal _numped;

    private decimal? _numpedecf;

    private decimal? _numregiao;

    private decimal _numseq;

    private string _numserieequip;

    private string _origemped;

    private string _origempedflex;

    private string _origempedpbase;

    private string _origempedptabela;

    private string _origempreco;

    private decimal? _peracrescismosimpnac;

    private decimal? _perbonific;

    private decimal? _percacresc;

    private decimal? _percacrescbalcao;

    private decimal? _percacrescimotelemarketing;

    private decimal? _percacrescpf;

    private decimal? _percdesc;

    private decimal? _percdescabatimento;

    private decimal? _percdescautor;

    private decimal? _percdesccofins;

    private decimal? _percdescfidelidade;

    private decimal? _percdescflex;

    private decimal? _percdescpbase;

    private decimal? _percdescpis;

    private decimal? _percdescptabela;

    private decimal? _percdescvolume;

    private decimal? _percfrete;

    private decimal? _percplpag;

    private decimal? _percramoativ;

    private decimal? _percredaliqipi;

    private decimal? _perdesccom;

    private decimal? _poferta;

    private decimal? _poriginal;

    private decimal? _precoecf;

    private decimal? _qtminatacado;

    private decimal? _qtmultiplo;

    private string _sittribut;

    private string _tipobroker;

    private string _tipodescflex;

    private string _tipodesconto;

    private string _tipodescpbase;

    private string _tipodescptabela;

    private string _tipofrete;

    private string _usatributporuf;

    private decimal? _vlacresc;

    private decimal? _vlbonific;

    private decimal? _vldesc;

    private decimal? _vldescabatimento;

    private decimal? _vldesccom;

    private decimal? _vldescicms;

    private decimal? _vldescreducaocofins;

    private decimal? _vldescreducaopis;

    private decimal? _vldifaliquotas;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspartilha;

    private decimal? _vlipi;

    private decimal? _vlredcmvsimplesnac;

    private decimal? _vlredpvendasimplesna;

    private decimal? _vlrepasse;

    private decimal? _vlst;

    private decimal? _vlsuframa;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codautorizacao
    {
        get
        {
            PropriedadeAcessada("Codautorizacao");
            return _codautorizacao;
        }
        set
        {
            PropriedadeModificada("Codautorizacao", value);
            _codautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcampanha
    {
        get
        {
            PropriedadeAcessada("Codcampanha");
            return _codcampanha;
        }
        set
        {
            PropriedadeModificada("Codcampanha", value);
            _codcampanha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescflex
    {
        get
        {
            PropriedadeAcessada("Coddescflex");
            return _coddescflex;
        }
        set
        {
            PropriedadeModificada("Coddescflex", value);
            _coddescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddesconto
    {
        get
        {
            PropriedadeAcessada("Coddesconto");
            return _coddesconto;
        }
        set
        {
            PropriedadeModificada("Coddesconto", value);
            _coddesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescpbase
    {
        get
        {
            PropriedadeAcessada("Coddescpbase");
            return _coddescpbase;
        }
        set
        {
            PropriedadeModificada("Coddescpbase", value);
            _coddescpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescptabela
    {
        get
        {
            PropriedadeAcessada("Coddescptabela");
            return _coddescptabela;
        }
        set
        {
            PropriedadeModificada("Coddescptabela", value);
            _coddescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescvolptabela
    {
        get
        {
            PropriedadeAcessada("Coddescvolptabela");
            return _coddescvolptabela;
        }
        set
        {
            PropriedadeModificada("Coddescvolptabela", value);
            _coddescvolptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddescvolume
    {
        get
        {
            PropriedadeAcessada("Coddescvolume");
            return _coddescvolume;
        }
        set
        {
            PropriedadeModificada("Coddescvolume", value);
            _coddescvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitente
    {
        get
        {
            PropriedadeAcessada("Codemitente");
            return _codemitente;
        }
        set
        {
            PropriedadeModificada("Codemitente", value);
            _codemitente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfidelidade
    {
        get
        {
            PropriedadeAcessada("Codfidelidade");
            return _codfidelidade;
        }
        set
        {
            PropriedadeModificada("Codfidelidade", value);
            _codfidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codfigvendatriangular
    {
        get
        {
            PropriedadeAcessada("Codfigvendatriangular");
            return _codfigvendatriangular;
        }
        set
        {
            PropriedadeModificada("Codfigvendatriangular", value);
            _codfigvendatriangular = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada("Codfilialnf");
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada("Codfilialnf", value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfiscal
    {
        get
        {
            PropriedadeAcessada("Codfiscal");
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada("Codfiscal", value);
            _codfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccx
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codplpag
    {
        get
        {
            PropriedadeAcessada("Codplpag");
            return _codplpag;
        }
        set
        {
            PropriedadeModificada("Codplpag", value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codprecofixo
    {
        get
        {
            PropriedadeAcessada("Codprecofixo");
            return _codprecofixo;
        }
        set
        {
            PropriedadeModificada("Codprecofixo", value);
            _codprecofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodsubst
    {
        get
        {
            PropriedadeAcessada("Codprodsubst");
            return _codprodsubst;
        }
        set
        {
            PropriedadeModificada("Codprodsubst", value);
            _codprodsubst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrotinadescflex
    {
        get
        {
            PropriedadeAcessada("Codrotinadescflex");
            return _codrotinadescflex;
        }
        set
        {
            PropriedadeModificada("Codrotinadescflex", value);
            _codrotinadescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrotinadescptabela
    {
        get
        {
            PropriedadeAcessada("Codrotinadescptabela");
            return _codrotinadescptabela;
        }
        set
        {
            PropriedadeModificada("Codrotinadescptabela", value);
            _codrotinadescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrotinapbase
    {
        get
        {
            PropriedadeAcessada("Codrotinapbase");
            return _codrotinapbase;
        }
        set
        {
            PropriedadeModificada("Codrotinapbase", value);
            _codrotinapbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Colunapreco
    {
        get
        {
            PropriedadeAcessada("Colunapreco");
            return _colunapreco;
        }
        set
        {
            PropriedadeModificada("Colunapreco", value);
            _colunapreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Creditapoliticapbase
    {
        get
        {
            PropriedadeAcessada("Creditapoliticapbase");
            return _creditapoliticapbase;
        }
        set
        {
            PropriedadeModificada("Creditapoliticapbase", value);
            _creditapoliticapbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada("Dtexportacao");
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada("Dtexportacao", value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimautor
    {
        get
        {
            PropriedadeAcessada("Dtfimautor");
            return _dtfimautor;
        }
        set
        {
            PropriedadeModificada("Dtfimautor", value);
            _dtfimautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimdescflex
    {
        get
        {
            PropriedadeAcessada("Dtfimdescflex");
            return _dtfimdescflex;
        }
        set
        {
            PropriedadeModificada("Dtfimdescflex", value);
            _dtfimdescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimdescpbase
    {
        get
        {
            PropriedadeAcessada("Dtfimdescpbase");
            return _dtfimdescpbase;
        }
        set
        {
            PropriedadeModificada("Dtfimdescpbase", value);
            _dtfimdescpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimdescptabela
    {
        get
        {
            PropriedadeAcessada("Dtfimdescptabela");
            return _dtfimdescptabela;
        }
        set
        {
            PropriedadeModificada("Dtfimdescptabela", value);
            _dtfimdescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimdescvolume
    {
        get
        {
            PropriedadeAcessada("Dtfimdescvolume");
            return _dtfimdescvolume;
        }
        set
        {
            PropriedadeModificada("Dtfimdescvolume", value);
            _dtfimdescvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimfidelidade
    {
        get
        {
            PropriedadeAcessada("Dtfimfidelidade");
            return _dtfimfidelidade;
        }
        set
        {
            PropriedadeModificada("Dtfimfidelidade", value);
            _dtfimfidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimoferta
    {
        get
        {
            PropriedadeAcessada("Dtfimoferta");
            return _dtfimoferta;
        }
        set
        {
            PropriedadeModificada("Dtfimoferta", value);
            _dtfimoferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicioautor
    {
        get
        {
            PropriedadeAcessada("Dtinicioautor");
            return _dtinicioautor;
        }
        set
        {
            PropriedadeModificada("Dtinicioautor", value);
            _dtinicioautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciodescflex
    {
        get
        {
            PropriedadeAcessada("Dtiniciodescflex");
            return _dtiniciodescflex;
        }
        set
        {
            PropriedadeModificada("Dtiniciodescflex", value);
            _dtiniciodescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciodescpbase
    {
        get
        {
            PropriedadeAcessada("Dtiniciodescpbase");
            return _dtiniciodescpbase;
        }
        set
        {
            PropriedadeModificada("Dtiniciodescpbase", value);
            _dtiniciodescpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciodescptabela
    {
        get
        {
            PropriedadeAcessada("Dtiniciodescptabela");
            return _dtiniciodescptabela;
        }
        set
        {
            PropriedadeModificada("Dtiniciodescptabela", value);
            _dtiniciodescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciodescvolume
    {
        get
        {
            PropriedadeAcessada("Dtiniciodescvolume");
            return _dtiniciodescvolume;
        }
        set
        {
            PropriedadeModificada("Dtiniciodescvolume", value);
            _dtiniciodescvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciooferta
    {
        get
        {
            PropriedadeAcessada("Dtiniciooferta");
            return _dtiniciooferta;
        }
        set
        {
            PropriedadeModificada("Dtiniciooferta", value);
            _dtiniciooferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinifidelidade
    {
        get
        {
            PropriedadeAcessada("Dtinifidelidade");
            return _dtinifidelidade;
        }
        set
        {
            PropriedadeModificada("Dtinifidelidade", value);
            _dtinifidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fatorpreco
    {
        get
        {
            PropriedadeAcessada("Fatorpreco");
            return _fatorpreco;
        }
        set
        {
            PropriedadeModificada("Fatorpreco", value);
            _fatorpreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fimintervalo
    {
        get
        {
            PropriedadeAcessada("Fimintervalo");
            return _fimintervalo;
        }
        set
        {
            PropriedadeModificada("Fimintervalo", value);
            _fimintervalo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fimintervaloautori
    {
        get
        {
            PropriedadeAcessada("Fimintervaloautori");
            return _fimintervaloautori;
        }
        set
        {
            PropriedadeModificada("Fimintervaloautori", value);
            _fimintervaloautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fimintervalopbase
    {
        get
        {
            PropriedadeAcessada("Fimintervalopbase");
            return _fimintervalopbase;
        }
        set
        {
            PropriedadeModificada("Fimintervalopbase", value);
            _fimintervalopbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fimintervaloptabela
    {
        get
        {
            PropriedadeAcessada("Fimintervaloptabela");
            return _fimintervaloptabela;
        }
        set
        {
            PropriedadeModificada("Fimintervaloptabela", value);
            _fimintervaloptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importado
    {
        get
        {
            PropriedadeAcessada("Importado");
            return _importado;
        }
        set
        {
            PropriedadeModificada("Importado", value);
            _importado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Inciointervaloautori
    {
        get
        {
            PropriedadeAcessada("Inciointervaloautori");
            return _inciointervaloautori;
        }
        set
        {
            PropriedadeModificada("Inciointervaloautori", value);
            _inciointervaloautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Iniciointervalo
    {
        get
        {
            PropriedadeAcessada("Iniciointervalo");
            return _iniciointervalo;
        }
        set
        {
            PropriedadeModificada("Iniciointervalo", value);
            _iniciointervalo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Iniciointervaloautori
    {
        get
        {
            PropriedadeAcessada("Iniciointervaloautori");
            return _iniciointervaloautori;
        }
        set
        {
            PropriedadeModificada("Iniciointervaloautori", value);
            _iniciointervaloautori = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Iniciointervalopbase
    {
        get
        {
            PropriedadeAcessada("Iniciointervalopbase");
            return _iniciointervalopbase;
        }
        set
        {
            PropriedadeModificada("Iniciointervalopbase", value);
            _iniciointervalopbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Iniciointervaloptabela
    {
        get
        {
            PropriedadeAcessada("Iniciointervaloptabela");
            return _iniciointervaloptabela;
        }
        set
        {
            PropriedadeModificada("Iniciointervaloptabela", value);
            _iniciointervaloptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naodebitapoliticapbase
    {
        get
        {
            PropriedadeAcessada("Naodebitapoliticapbase");
            return _naodebitapoliticapbase;
        }
        set
        {
            PropriedadeModificada("Naodebitapoliticapbase", value);
            _naodebitapoliticapbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numped
    {
        get
        {
            PropriedadeAcessada("Numped");
            return _numped;
        }
        set
        {
            PropriedadeModificada("Numped", value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao
    {
        get
        {
            PropriedadeAcessada("Numregiao");
            return _numregiao;
        }
        set
        {
            PropriedadeModificada("Numregiao", value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Numseq
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemped
    {
        get
        {
            PropriedadeAcessada("Origemped");
            return _origemped;
        }
        set
        {
            PropriedadeModificada("Origemped", value);
            _origemped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Origempedflex
    {
        get
        {
            PropriedadeAcessada("Origempedflex");
            return _origempedflex;
        }
        set
        {
            PropriedadeModificada("Origempedflex", value);
            _origempedflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Origempedpbase
    {
        get
        {
            PropriedadeAcessada("Origempedpbase");
            return _origempedpbase;
        }
        set
        {
            PropriedadeModificada("Origempedpbase", value);
            _origempedpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Origempedptabela
    {
        get
        {
            PropriedadeAcessada("Origempedptabela");
            return _origempedptabela;
        }
        set
        {
            PropriedadeModificada("Origempedptabela", value);
            _origempedptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Origempreco
    {
        get
        {
            PropriedadeAcessada("Origempreco");
            return _origempreco;
        }
        set
        {
            PropriedadeModificada("Origempreco", value);
            _origempreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Peracrescismosimpnac
    {
        get
        {
            PropriedadeAcessada("Peracrescismosimpnac");
            return _peracrescismosimpnac;
        }
        set
        {
            PropriedadeModificada("Peracrescismosimpnac", value);
            _peracrescismosimpnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perbonific
    {
        get
        {
            PropriedadeAcessada("Perbonific");
            return _perbonific;
        }
        set
        {
            PropriedadeModificada("Perbonific", value);
            _perbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percacresc
    {
        get
        {
            PropriedadeAcessada("Percacresc");
            return _percacresc;
        }
        set
        {
            PropriedadeModificada("Percacresc", value);
            _percacresc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percacrescbalcao
    {
        get
        {
            PropriedadeAcessada("Percacrescbalcao");
            return _percacrescbalcao;
        }
        set
        {
            PropriedadeModificada("Percacrescbalcao", value);
            _percacrescbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percacrescimotelemarketing
    {
        get
        {
            PropriedadeAcessada("Percacrescimotelemarketing");
            return _percacrescimotelemarketing;
        }
        set
        {
            PropriedadeModificada("Percacrescimotelemarketing", value);
            _percacrescimotelemarketing = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percacrescpf
    {
        get
        {
            PropriedadeAcessada("Percacrescpf");
            return _percacrescpf;
        }
        set
        {
            PropriedadeModificada("Percacrescpf", value);
            _percacrescpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdesc
    {
        get
        {
            PropriedadeAcessada("Percdesc");
            return _percdesc;
        }
        set
        {
            PropriedadeModificada("Percdesc", value);
            _percdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdescabatimento
    {
        get
        {
            PropriedadeAcessada("Percdescabatimento");
            return _percdescabatimento;
        }
        set
        {
            PropriedadeModificada("Percdescabatimento", value);
            _percdescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdescautor
    {
        get
        {
            PropriedadeAcessada("Percdescautor");
            return _percdescautor;
        }
        set
        {
            PropriedadeModificada("Percdescautor", value);
            _percdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesccofins
    {
        get
        {
            PropriedadeAcessada("Percdesccofins");
            return _percdesccofins;
        }
        set
        {
            PropriedadeModificada("Percdesccofins", value);
            _percdesccofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percdescfidelidade
    {
        get
        {
            PropriedadeAcessada("Percdescfidelidade");
            return _percdescfidelidade;
        }
        set
        {
            PropriedadeModificada("Percdescfidelidade", value);
            _percdescfidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescflex
    {
        get
        {
            PropriedadeAcessada("Percdescflex");
            return _percdescflex;
        }
        set
        {
            PropriedadeModificada("Percdescflex", value);
            _percdescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescpbase
    {
        get
        {
            PropriedadeAcessada("Percdescpbase");
            return _percdescpbase;
        }
        set
        {
            PropriedadeModificada("Percdescpbase", value);
            _percdescpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdescpis
    {
        get
        {
            PropriedadeAcessada("Percdescpis");
            return _percdescpis;
        }
        set
        {
            PropriedadeModificada("Percdescpis", value);
            _percdescpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescptabela
    {
        get
        {
            PropriedadeAcessada("Percdescptabela");
            return _percdescptabela;
        }
        set
        {
            PropriedadeModificada("Percdescptabela", value);
            _percdescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdescvolume
    {
        get
        {
            PropriedadeAcessada("Percdescvolume");
            return _percdescvolume;
        }
        set
        {
            PropriedadeModificada("Percdescvolume", value);
            _percdescvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percfrete
    {
        get
        {
            PropriedadeAcessada("Percfrete");
            return _percfrete;
        }
        set
        {
            PropriedadeModificada("Percfrete", value);
            _percfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percplpag
    {
        get
        {
            PropriedadeAcessada("Percplpag");
            return _percplpag;
        }
        set
        {
            PropriedadeModificada("Percplpag", value);
            _percplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percramoativ
    {
        get
        {
            PropriedadeAcessada("Percramoativ");
            return _percramoativ;
        }
        set
        {
            PropriedadeModificada("Percramoativ", value);
            _percramoativ = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percredaliqipi
    {
        get
        {
            PropriedadeAcessada("Percredaliqipi");
            return _percredaliqipi;
        }
        set
        {
            PropriedadeModificada("Percredaliqipi", value);
            _percredaliqipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdesccom
    {
        get
        {
            PropriedadeAcessada("Perdesccom");
            return _perdesccom;
        }
        set
        {
            PropriedadeModificada("Perdesccom", value);
            _perdesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Poferta
    {
        get
        {
            PropriedadeAcessada("Poferta");
            return _poferta;
        }
        set
        {
            PropriedadeModificada("Poferta", value);
            _poferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Poriginal
    {
        get
        {
            PropriedadeAcessada("Poriginal");
            return _poriginal;
        }
        set
        {
            PropriedadeModificada("Poriginal", value);
            _poriginal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precoecf
    {
        get
        {
            PropriedadeAcessada("Precoecf");
            return _precoecf;
        }
        set
        {
            PropriedadeModificada("Precoecf", value);
            _precoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtminatacado
    {
        get
        {
            PropriedadeAcessada("Qtminatacado");
            return _qtminatacado;
        }
        set
        {
            PropriedadeModificada("Qtminatacado", value);
            _qtminatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmultiplo
    {
        get
        {
            PropriedadeAcessada("Qtmultiplo");
            return _qtmultiplo;
        }
        set
        {
            PropriedadeModificada("Qtmultiplo", value);
            _qtmultiplo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada("Sittribut");
            return _sittribut;
        }
        set
        {
            PropriedadeModificada("Sittribut", value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipobroker
    {
        get
        {
            PropriedadeAcessada("Tipobroker");
            return _tipobroker;
        }
        set
        {
            PropriedadeModificada("Tipobroker", value);
            _tipobroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipodescflex
    {
        get
        {
            PropriedadeAcessada("Tipodescflex");
            return _tipodescflex;
        }
        set
        {
            PropriedadeModificada("Tipodescflex", value);
            _tipodescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipodesconto
    {
        get
        {
            PropriedadeAcessada("Tipodesconto");
            return _tipodesconto;
        }
        set
        {
            PropriedadeModificada("Tipodesconto", value);
            _tipodesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipodescpbase
    {
        get
        {
            PropriedadeAcessada("Tipodescpbase");
            return _tipodescpbase;
        }
        set
        {
            PropriedadeModificada("Tipodescpbase", value);
            _tipodescpbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipodescptabela
    {
        get
        {
            PropriedadeAcessada("Tipodescptabela");
            return _tipodescptabela;
        }
        set
        {
            PropriedadeModificada("Tipodescptabela", value);
            _tipodescptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipofrete
    {
        get
        {
            PropriedadeAcessada("Tipofrete");
            return _tipofrete;
        }
        set
        {
            PropriedadeModificada("Tipofrete", value);
            _tipofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usatributporuf
    {
        get
        {
            PropriedadeAcessada("Usatributporuf");
            return _usatributporuf;
        }
        set
        {
            PropriedadeModificada("Usatributporuf", value);
            _usatributporuf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacresc
    {
        get
        {
            PropriedadeAcessada("Vlacresc");
            return _vlacresc;
        }
        set
        {
            PropriedadeModificada("Vlacresc", value);
            _vlacresc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonific
    {
        get
        {
            PropriedadeAcessada("Vlbonific");
            return _vlbonific;
        }
        set
        {
            PropriedadeModificada("Vlbonific", value);
            _vlbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesc
    {
        get
        {
            PropriedadeAcessada("Vldesc");
            return _vldesc;
        }
        set
        {
            PropriedadeModificada("Vldesc", value);
            _vldesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescabatimento
    {
        get
        {
            PropriedadeAcessada("Vldescabatimento");
            return _vldescabatimento;
        }
        set
        {
            PropriedadeModificada("Vldescabatimento", value);
            _vldescabatimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldesccom
    {
        get
        {
            PropriedadeAcessada("Vldesccom");
            return _vldesccom;
        }
        set
        {
            PropriedadeModificada("Vldesccom", value);
            _vldesccom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicms
    {
        get
        {
            PropriedadeAcessada("Vldescicms");
            return _vldescicms;
        }
        set
        {
            PropriedadeModificada("Vldescicms", value);
            _vldescicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaocofins
    {
        get
        {
            PropriedadeAcessada("Vldescreducaocofins");
            return _vldescreducaocofins;
        }
        set
        {
            PropriedadeModificada("Vldescreducaocofins", value);
            _vldescreducaocofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 24, Precisao = 6)]
    public decimal? Vldescreducaopis
    {
        get
        {
            PropriedadeAcessada("Vldescreducaopis");
            return _vldescreducaopis;
        }
        set
        {
            PropriedadeModificada("Vldescreducaopis", value);
            _vldescreducaopis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldifaliquotas
    {
        get
        {
            PropriedadeAcessada("Vldifaliquotas");
            return _vldifaliquotas;
        }
        set
        {
            PropriedadeModificada("Vldifaliquotas", value);
            _vldifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Vlicmsdifaliqpart
    {
        get
        {
            PropriedadeAcessada("Vlicmsdifaliqpart");
            return _vlicmsdifaliqpart;
        }
        set
        {
            PropriedadeModificada("Vlicmsdifaliqpart", value);
            _vlicmsdifaliqpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartilha
    {
        get
        {
            PropriedadeAcessada("Vlicmspartilha");
            return _vlicmspartilha;
        }
        set
        {
            PropriedadeModificada("Vlicmspartilha", value);
            _vlicmspartilha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipi
    {
        get
        {
            PropriedadeAcessada("Vlipi");
            return _vlipi;
        }
        set
        {
            PropriedadeModificada("Vlipi", value);
            _vlipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcmvsimplesnac
    {
        get
        {
            PropriedadeAcessada("Vlredcmvsimplesnac");
            return _vlredcmvsimplesnac;
        }
        set
        {
            PropriedadeModificada("Vlredcmvsimplesnac", value);
            _vlredcmvsimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredpvendasimplesna
    {
        get
        {
            PropriedadeAcessada("Vlredpvendasimplesna");
            return _vlredpvendasimplesna;
        }
        set
        {
            PropriedadeModificada("Vlredpvendasimplesna", value);
            _vlredpvendasimplesna = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrepasse
    {
        get
        {
            PropriedadeAcessada("Vlrepasse");
            return _vlrepasse;
        }
        set
        {
            PropriedadeModificada("Vlrepasse", value);
            _vlrepasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlst
    {
        get
        {
            PropriedadeAcessada("Vlst");
            return _vlst;
        }
        set
        {
            PropriedadeModificada("Vlst", value);
            _vlst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORIGEMPRECO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsuframa
    {
        get
        {
            PropriedadeAcessada("Vlsuframa");
            return _vlsuframa;
        }
        set
        {
            PropriedadeModificada("Vlsuframa", value);
            _vlsuframa = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORIGEMPRECO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codautorizacao = AlterarTipo<decimal?>(leitor["Codautorizacao"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcampanha = AlterarTipo<decimal?>(leitor["Codcampanha"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _coddescflex = AlterarTipo<decimal?>(leitor["Coddescflex"]);
        _coddesconto = AlterarTipo<decimal?>(leitor["Coddesconto"]);
        _coddescpbase = AlterarTipo<decimal?>(leitor["Coddescpbase"]);
        _coddescptabela = AlterarTipo<decimal?>(leitor["Coddescptabela"]);
        _coddescvolptabela = AlterarTipo<decimal?>(leitor["Coddescvolptabela"]);
        _coddescvolume = AlterarTipo<decimal?>(leitor["Coddescvolume"]);
        _codemitente = AlterarTipo<decimal?>(leitor["Codemitente"]);
        _codfidelidade = AlterarTipo<decimal?>(leitor["Codfidelidade"]);
        _codfigvendatriangular = AlterarTipo<decimal?>(leitor["Codfigvendatriangular"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfiscal = AlterarTipo<decimal?>(leitor["Codfiscal"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codplpag = AlterarTipo<decimal?>(leitor["Codplpag"]);
        _codprecofixo = AlterarTipo<decimal?>(leitor["Codprecofixo"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodsubst = AlterarTipo<decimal?>(leitor["Codprodsubst"]);
        _codrotinadescflex = AlterarTipo<decimal?>(leitor["Codrotinadescflex"]);
        _codrotinadescptabela = AlterarTipo<decimal?>(leitor["Codrotinadescptabela"]);
        _codrotinapbase = AlterarTipo<decimal?>(leitor["Codrotinapbase"]);
        _colunapreco = AlterarTipo<decimal?>(leitor["Colunapreco"]);
        _creditapoliticapbase = AlterarTipo<string>(leitor["Creditapoliticapbase"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtfimautor = AlterarTipo<DateTime?>(leitor["Dtfimautor"]);
        _dtfimdescflex = AlterarTipo<DateTime?>(leitor["Dtfimdescflex"]);
        _dtfimdescpbase = AlterarTipo<DateTime?>(leitor["Dtfimdescpbase"]);
        _dtfimdescptabela = AlterarTipo<DateTime?>(leitor["Dtfimdescptabela"]);
        _dtfimdescvolume = AlterarTipo<DateTime?>(leitor["Dtfimdescvolume"]);
        _dtfimfidelidade = AlterarTipo<DateTime?>(leitor["Dtfimfidelidade"]);
        _dtfimoferta = AlterarTipo<DateTime?>(leitor["Dtfimoferta"]);
        _dtinicioautor = AlterarTipo<DateTime?>(leitor["Dtinicioautor"]);
        _dtiniciodescflex = AlterarTipo<DateTime?>(leitor["Dtiniciodescflex"]);
        _dtiniciodescpbase = AlterarTipo<DateTime?>(leitor["Dtiniciodescpbase"]);
        _dtiniciodescptabela = AlterarTipo<DateTime?>(leitor["Dtiniciodescptabela"]);
        _dtiniciodescvolume = AlterarTipo<DateTime?>(leitor["Dtiniciodescvolume"]);
        _dtiniciooferta = AlterarTipo<DateTime?>(leitor["Dtiniciooferta"]);
        _dtinifidelidade = AlterarTipo<DateTime?>(leitor["Dtinifidelidade"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _fatorpreco = AlterarTipo<decimal?>(leitor["Fatorpreco"]);
        _fimintervalo = AlterarTipo<decimal?>(leitor["Fimintervalo"]);
        _fimintervaloautori = AlterarTipo<decimal?>(leitor["Fimintervaloautori"]);
        _fimintervalopbase = AlterarTipo<decimal?>(leitor["Fimintervalopbase"]);
        _fimintervaloptabela = AlterarTipo<decimal?>(leitor["Fimintervaloptabela"]);
        _importado = AlterarTipo<string>(leitor["Importado"]);
        _inciointervaloautori = AlterarTipo<decimal?>(leitor["Inciointervaloautori"]);
        _iniciointervalo = AlterarTipo<decimal?>(leitor["Iniciointervalo"]);
        _iniciointervaloautori = AlterarTipo<decimal?>(leitor["Iniciointervaloautori"]);
        _iniciointervalopbase = AlterarTipo<decimal?>(leitor["Iniciointervalopbase"]);
        _iniciointervaloptabela = AlterarTipo<decimal?>(leitor["Iniciointervaloptabela"]);
        _naodebitapoliticapbase = AlterarTipo<string>(leitor["Naodebitapoliticapbase"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numped = AlterarTipo<decimal>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _origemped = AlterarTipo<string>(leitor["Origemped"]);
        _origempedflex = AlterarTipo<string>(leitor["Origempedflex"]);
        _origempedpbase = AlterarTipo<string>(leitor["Origempedpbase"]);
        _origempedptabela = AlterarTipo<string>(leitor["Origempedptabela"]);
        _origempreco = AlterarTipo<string>(leitor["Origempreco"]);
        _peracrescismosimpnac = AlterarTipo<decimal?>(leitor["Peracrescismosimpnac"]);
        _perbonific = AlterarTipo<decimal?>(leitor["Perbonific"]);
        _percacresc = AlterarTipo<decimal?>(leitor["Percacresc"]);
        _percacrescbalcao = AlterarTipo<decimal?>(leitor["Percacrescbalcao"]);
        _percacrescimotelemarketing = AlterarTipo<decimal?>(leitor["Percacrescimotelemarketing"]);
        _percacrescpf = AlterarTipo<decimal?>(leitor["Percacrescpf"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _percdescabatimento = AlterarTipo<decimal?>(leitor["Percdescabatimento"]);
        _percdescautor = AlterarTipo<decimal?>(leitor["Percdescautor"]);
        _percdesccofins = AlterarTipo<decimal?>(leitor["Percdesccofins"]);
        _percdescfidelidade = AlterarTipo<decimal?>(leitor["Percdescfidelidade"]);
        _percdescflex = AlterarTipo<decimal?>(leitor["Percdescflex"]);
        _percdescpbase = AlterarTipo<decimal?>(leitor["Percdescpbase"]);
        _percdescpis = AlterarTipo<decimal?>(leitor["Percdescpis"]);
        _percdescptabela = AlterarTipo<decimal?>(leitor["Percdescptabela"]);
        _percdescvolume = AlterarTipo<decimal?>(leitor["Percdescvolume"]);
        _percfrete = AlterarTipo<decimal?>(leitor["Percfrete"]);
        _percplpag = AlterarTipo<decimal?>(leitor["Percplpag"]);
        _percramoativ = AlterarTipo<decimal?>(leitor["Percramoativ"]);
        _percredaliqipi = AlterarTipo<decimal?>(leitor["Percredaliqipi"]);
        _perdesccom = AlterarTipo<decimal?>(leitor["Perdesccom"]);
        _poferta = AlterarTipo<decimal?>(leitor["Poferta"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _precoecf = AlterarTipo<decimal?>(leitor["Precoecf"]);
        _qtminatacado = AlterarTipo<decimal?>(leitor["Qtminatacado"]);
        _qtmultiplo = AlterarTipo<decimal?>(leitor["Qtmultiplo"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _tipobroker = AlterarTipo<string>(leitor["Tipobroker"]);
        _tipodescflex = AlterarTipo<string>(leitor["Tipodescflex"]);
        _tipodesconto = AlterarTipo<string>(leitor["Tipodesconto"]);
        _tipodescpbase = AlterarTipo<string>(leitor["Tipodescpbase"]);
        _tipodescptabela = AlterarTipo<string>(leitor["Tipodescptabela"]);
        _tipofrete = AlterarTipo<string>(leitor["Tipofrete"]);
        _usatributporuf = AlterarTipo<string>(leitor["Usatributporuf"]);
        _vlacresc = AlterarTipo<decimal?>(leitor["Vlacresc"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vldesc = AlterarTipo<decimal?>(leitor["Vldesc"]);
        _vldescabatimento = AlterarTipo<decimal?>(leitor["Vldescabatimento"]);
        _vldesccom = AlterarTipo<decimal?>(leitor["Vldesccom"]);
        _vldescicms = AlterarTipo<decimal?>(leitor["Vldescicms"]);
        _vldescreducaocofins = AlterarTipo<decimal?>(leitor["Vldescreducaocofins"]);
        _vldescreducaopis = AlterarTipo<decimal?>(leitor["Vldescreducaopis"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspartilha = AlterarTipo<decimal?>(leitor["Vlicmspartilha"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vlredcmvsimplesnac = AlterarTipo<decimal?>(leitor["Vlredcmvsimplesnac"]);
        _vlredpvendasimplesna = AlterarTipo<decimal?>(leitor["Vlredpvendasimplesna"]);
        _vlrepasse = AlterarTipo<decimal?>(leitor["Vlrepasse"]);
        _vlst = AlterarTipo<decimal?>(leitor["Vlst"]);
        _vlsuframa = AlterarTipo<decimal?>(leitor["Vlsuframa"]);
    }

}