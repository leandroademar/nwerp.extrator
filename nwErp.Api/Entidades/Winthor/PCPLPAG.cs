

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPLPAG : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODEQUIPE = "Codequipe";

    private decimal? _codequipe;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNC = "Codfunc";

    private decimal? _codfunc;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPLPAGKRAFT = "Codplpagkraft";

    private string _codplpagkraft;

    private static readonly string RO_CODRESTRICAO = "Codrestricao";

    private decimal? _codrestricao;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DESCRICAO2 = "Descricao2";

    private string _descricao2;

    private static readonly string RO_DIAFIXO = "Diafixo";

    private decimal? _diafixo;

    private static readonly string RO_DIASCARENCIA = "Diascarencia";

    private decimal? _diascarencia;

    private static readonly string RO_DIASMAXPARCELA = "Diasmaxparcela";

    private decimal? _diasmaxparcela;

    private static readonly string RO_DIASMINPARCELA = "Diasminparcela";

    private decimal? _diasminparcela;

    private static readonly string RO_DTVENC1 = "Dtvenc1";

    private DateTime? _dtvenc1;

    private static readonly string RO_DTVENC2 = "Dtvenc2";

    private DateTime? _dtvenc2;

    private static readonly string RO_DTVENC3 = "Dtvenc3";

    private DateTime? _dtvenc3;

    private static readonly string RO_ENTRADA = "Entrada";

    private string _entrada;

    private static readonly string RO_ENVIAPLANOFV = "Enviaplanofv";

    private string _enviaplanofv;

    private static readonly string RO_FORMAPARCELAMENTO = "Formaparcelamento";

    private string _formaparcelamento;

    private static readonly string RO_LETRAPLPAG = "Letraplpag";

    private string _letraplpag;

    private static readonly string RO_MARGEMMIN = "Margemmin";

    private decimal? _margemmin;

    private static readonly string RO_NAODESCENTLIMCREDCLI = "Naodescentlimcredcli";

    private string _naodescentlimcredcli;

    private static readonly string RO_NUMDIAS = "Numdias";

    private decimal? _numdias;

    private static readonly string RO_NUMDIASATRASOFIM = "Numdiasatrasofim";

    private decimal? _numdiasatrasofim;

    private static readonly string RO_NUMDIASATRASOINI = "Numdiasatrasoini";

    private decimal? _numdiasatrasoini;

    private static readonly string RO_NUMDIASCARENCIA = "Numdiascarencia";

    private decimal? _numdiascarencia;

    private static readonly string RO_NUMDIASCARTAO = "Numdiascartao";

    private decimal? _numdiascartao;

    private static readonly string RO_NUMEROPARCELASDIAFIXO = "Numeroparcelasdiafixo";

    private decimal? _numeroparcelasdiafixo;

    private static readonly string RO_NUMITENSMINIMO = "Numitensminimo";

    private decimal? _numitensminimo;

    private static readonly string RO_NUMPARCELAS = "Numparcelas";

    private decimal? _numparcelas;

    private static readonly string RO_NUMPR = "Numpr";

    private decimal? _numpr;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSPLPAG = "Obsplpag";

    private string _obsplpag;

    private static readonly string RO_OFERTA = "Oferta";

    private string _oferta;

    private static readonly string RO_PERTXFIM = "Pertxfim";

    private decimal? _pertxfim;

    private static readonly string RO_PERTXFIMPALM = "Pertxfimpalm";

    private decimal? _pertxfimpalm;

    private static readonly string RO_PRAZOPONDERADO = "Prazoponderado";

    private string _prazoponderado;

    private static readonly string RO_PRAZO1 = "Prazo1";

    private decimal? _prazo1;

    private static readonly string RO_PRAZO10 = "Prazo10";

    private decimal? _prazo10;

    private static readonly string RO_PRAZO11 = "Prazo11";

    private decimal? _prazo11;

    private static readonly string RO_PRAZO12 = "Prazo12";

    private decimal? _prazo12;

    private static readonly string RO_PRAZO2 = "Prazo2";

    private decimal? _prazo2;

    private static readonly string RO_PRAZO3 = "Prazo3";

    private decimal? _prazo3;

    private static readonly string RO_PRAZO4 = "Prazo4";

    private decimal? _prazo4;

    private static readonly string RO_PRAZO5 = "Prazo5";

    private decimal? _prazo5;

    private static readonly string RO_PRAZO6 = "Prazo6";

    private decimal? _prazo6;

    private static readonly string RO_PRAZO7 = "Prazo7";

    private decimal? _prazo7;

    private static readonly string RO_PRAZO8 = "Prazo8";

    private decimal? _prazo8;

    private static readonly string RO_PRAZO9 = "Prazo9";

    private decimal? _prazo9;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_TIPOENTRADA = "Tipoentrada";

    private decimal? _tipoentrada;

    private static readonly string RO_TIPOPRAZO = "Tipoprazo";

    private string _tipoprazo;

    private static readonly string RO_TIPORESTRICAO = "Tiporestricao";

    private string _tiporestricao;

    private static readonly string RO_TIPOVENDA = "Tipovenda";

    private string _tipovenda;

    private static readonly string RO_TXFATOR = "Txfator";

    private decimal? _txfator;

    private static readonly string RO_USADESCFINANCEIRO = "Usadescfinanceiro";

    private string _usadescfinanceiro;

    private static readonly string RO_USADESCLINHAPROD = "Usadesclinhaprod";

    private string _usadesclinhaprod;

    private static readonly string RO_USAMULTIFILIAL = "Usamultifilial";

    private string _usamultifilial;

    private static readonly string RO_USAPLPAGAUTOSERVICO = "Usaplpagautoservico";

    private string _usaplpagautoservico;

    private static readonly string RO_USAPRAZOADICIONALPCCLIENT = "Usaprazoadicionalpcclient";

    private string _usaprazoadicionalpcclient;

    private static readonly string RO_VENDABK = "Vendabk";

    private string _vendabk;

    private static readonly string RO_VLMINPARCELA = "Vlminparcela";

    private decimal? _vlminparcela;

    private static readonly string RO_VLMINPEDIDO = "Vlminpedido";

    private decimal? _vlminpedido;

    private static readonly string RO_VLTXCARNE = "Vltxcarne";

    private decimal? _vltxcarne;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada(RO_CODCOB);
            return _codcob;
        }
        set
        {
            PropriedadeModificada(RO_CODCOB, value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codequipe
    {
        get
        {
            PropriedadeAcessada(RO_CODEQUIPE);
            return _codequipe;
        }
        set
        {
            PropriedadeModificada(RO_CODEQUIPE, value);
            _codequipe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNC);
            return _codfunc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNC, value);
            _codfunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codplpag
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAG);
            return _codplpag;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAG, value);
            _codplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codplpagkraft
    {
        get
        {
            PropriedadeAcessada(RO_CODPLPAGKRAFT);
            return _codplpagkraft;
        }
        set
        {
            PropriedadeModificada(RO_CODPLPAGKRAFT, value);
            _codplpagkraft = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrestricao
    {
        get
        {
            PropriedadeAcessada(RO_CODRESTRICAO);
            return _codrestricao;
        }
        set
        {
            PropriedadeModificada(RO_CODRESTRICAO, value);
            _codrestricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO);
            return _descricao;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO, value);
            _descricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 45, Precisao = 0)]
    public string Descricao2
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO2);
            return _descricao2;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO2, value);
            _descricao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Diafixo
    {
        get
        {
            PropriedadeAcessada(RO_DIAFIXO);
            return _diafixo;
        }
        set
        {
            PropriedadeModificada(RO_DIAFIXO, value);
            _diafixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Diascarencia
    {
        get
        {
            PropriedadeAcessada(RO_DIASCARENCIA);
            return _diascarencia;
        }
        set
        {
            PropriedadeModificada(RO_DIASCARENCIA, value);
            _diascarencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Diasmaxparcela
    {
        get
        {
            PropriedadeAcessada(RO_DIASMAXPARCELA);
            return _diasmaxparcela;
        }
        set
        {
            PropriedadeModificada(RO_DIASMAXPARCELA, value);
            _diasmaxparcela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Diasminparcela
    {
        get
        {
            PropriedadeAcessada(RO_DIASMINPARCELA);
            return _diasminparcela;
        }
        set
        {
            PropriedadeModificada(RO_DIASMINPARCELA, value);
            _diasminparcela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc1
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC1);
            return _dtvenc1;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC1, value);
            _dtvenc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc2
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC2);
            return _dtvenc2;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC2, value);
            _dtvenc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenc3
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC3);
            return _dtvenc3;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC3, value);
            _dtvenc3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Entrada
    {
        get
        {
            PropriedadeAcessada(RO_ENTRADA);
            return _entrada;
        }
        set
        {
            PropriedadeModificada(RO_ENTRADA, value);
            _entrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviaplanofv
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAPLANOFV);
            return _enviaplanofv;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAPLANOFV, value);
            _enviaplanofv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Formaparcelamento
    {
        get
        {
            PropriedadeAcessada(RO_FORMAPARCELAMENTO);
            return _formaparcelamento;
        }
        set
        {
            PropriedadeModificada(RO_FORMAPARCELAMENTO, value);
            _formaparcelamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Letraplpag
    {
        get
        {
            PropriedadeAcessada(RO_LETRAPLPAG);
            return _letraplpag;
        }
        set
        {
            PropriedadeModificada(RO_LETRAPLPAG, value);
            _letraplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Margemmin
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMMIN);
            return _margemmin;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMMIN, value);
            _margemmin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Naodescentlimcredcli
    {
        get
        {
            PropriedadeAcessada(RO_NAODESCENTLIMCREDCLI);
            return _naodescentlimcredcli;
        }
        set
        {
            PropriedadeModificada(RO_NAODESCENTLIMCREDCLI, value);
            _naodescentlimcredcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdias
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIAS);
            return _numdias;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIAS, value);
            _numdias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasatrasofim
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASATRASOFIM);
            return _numdiasatrasofim;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASATRASOFIM, value);
            _numdiasatrasofim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasatrasoini
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASATRASOINI);
            return _numdiasatrasoini;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASATRASOINI, value);
            _numdiasatrasoini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascarencia
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCARENCIA);
            return _numdiascarencia;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCARENCIA, value);
            _numdiascarencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascartao
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCARTAO);
            return _numdiascartao;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCARTAO, value);
            _numdiascartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numeroparcelasdiafixo
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROPARCELASDIAFIXO);
            return _numeroparcelasdiafixo;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROPARCELASDIAFIXO, value);
            _numeroparcelasdiafixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numitensminimo
    {
        get
        {
            PropriedadeAcessada(RO_NUMITENSMINIMO);
            return _numitensminimo;
        }
        set
        {
            PropriedadeModificada(RO_NUMITENSMINIMO, value);
            _numitensminimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numparcelas
    {
        get
        {
            PropriedadeAcessada(RO_NUMPARCELAS);
            return _numparcelas;
        }
        set
        {
            PropriedadeModificada(RO_NUMPARCELAS, value);
            _numparcelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numpr
    {
        get
        {
            PropriedadeAcessada(RO_NUMPR);
            return _numpr;
        }
        set
        {
            PropriedadeModificada(RO_NUMPR, value);
            _numpr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obsplpag
    {
        get
        {
            PropriedadeAcessada(RO_OBSPLPAG);
            return _obsplpag;
        }
        set
        {
            PropriedadeModificada(RO_OBSPLPAG, value);
            _obsplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Oferta
    {
        get
        {
            PropriedadeAcessada(RO_OFERTA);
            return _oferta;
        }
        set
        {
            PropriedadeModificada(RO_OFERTA, value);
            _oferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pertxfim
    {
        get
        {
            PropriedadeAcessada(RO_PERTXFIM);
            return _pertxfim;
        }
        set
        {
            PropriedadeModificada(RO_PERTXFIM, value);
            _pertxfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pertxfimpalm
    {
        get
        {
            PropriedadeAcessada(RO_PERTXFIMPALM);
            return _pertxfimpalm;
        }
        set
        {
            PropriedadeModificada(RO_PERTXFIMPALM, value);
            _pertxfimpalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Prazoponderado
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOPONDERADO);
            return _prazoponderado;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOPONDERADO, value);
            _prazoponderado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo1
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO1);
            return _prazo1;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO1, value);
            _prazo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo10
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO10);
            return _prazo10;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO10, value);
            _prazo10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo11
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO11);
            return _prazo11;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO11, value);
            _prazo11 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo12
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO12);
            return _prazo12;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO12, value);
            _prazo12 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo2
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO2);
            return _prazo2;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO2, value);
            _prazo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo3
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO3);
            return _prazo3;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO3, value);
            _prazo3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo4
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO4);
            return _prazo4;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO4, value);
            _prazo4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo5
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO5);
            return _prazo5;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO5, value);
            _prazo5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo6
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO6);
            return _prazo6;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO6, value);
            _prazo6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo7
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO7);
            return _prazo7;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO7, value);
            _prazo7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo8
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO8);
            return _prazo8;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO8, value);
            _prazo8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazo9
    {
        get
        {
            PropriedadeAcessada(RO_PRAZO9);
            return _prazo9;
        }
        set
        {
            PropriedadeModificada(RO_PRAZO9, value);
            _prazo9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Tipoentrada
    {
        get
        {
            PropriedadeAcessada(RO_TIPOENTRADA);
            return _tipoentrada;
        }
        set
        {
            PropriedadeModificada(RO_TIPOENTRADA, value);
            _tipoentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoprazo
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRAZO);
            return _tipoprazo;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRAZO, value);
            _tipoprazo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tiporestricao
    {
        get
        {
            PropriedadeAcessada(RO_TIPORESTRICAO);
            return _tiporestricao;
        }
        set
        {
            PropriedadeModificada(RO_TIPORESTRICAO, value);
            _tiporestricao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovenda
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVENDA);
            return _tipovenda;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVENDA, value);
            _tipovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Txfator
    {
        get
        {
            PropriedadeAcessada(RO_TXFATOR);
            return _txfator;
        }
        set
        {
            PropriedadeModificada(RO_TXFATOR, value);
            _txfator = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadescfinanceiro
    {
        get
        {
            PropriedadeAcessada(RO_USADESCFINANCEIRO);
            return _usadescfinanceiro;
        }
        set
        {
            PropriedadeModificada(RO_USADESCFINANCEIRO, value);
            _usadescfinanceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadesclinhaprod
    {
        get
        {
            PropriedadeAcessada(RO_USADESCLINHAPROD);
            return _usadesclinhaprod;
        }
        set
        {
            PropriedadeModificada(RO_USADESCLINHAPROD, value);
            _usadesclinhaprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usamultifilial
    {
        get
        {
            PropriedadeAcessada(RO_USAMULTIFILIAL);
            return _usamultifilial;
        }
        set
        {
            PropriedadeModificada(RO_USAMULTIFILIAL, value);
            _usamultifilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaplpagautoservico
    {
        get
        {
            PropriedadeAcessada(RO_USAPLPAGAUTOSERVICO);
            return _usaplpagautoservico;
        }
        set
        {
            PropriedadeModificada(RO_USAPLPAGAUTOSERVICO, value);
            _usaplpagautoservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaprazoadicionalpcclient
    {
        get
        {
            PropriedadeAcessada(RO_USAPRAZOADICIONALPCCLIENT);
            return _usaprazoadicionalpcclient;
        }
        set
        {
            PropriedadeModificada(RO_USAPRAZOADICIONALPCCLIENT, value);
            _usaprazoadicionalpcclient = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendabk
    {
        get
        {
            PropriedadeAcessada(RO_VENDABK);
            return _vendabk;
        }
        set
        {
            PropriedadeModificada(RO_VENDABK, value);
            _vendabk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlminparcela
    {
        get
        {
            PropriedadeAcessada(RO_VLMINPARCELA);
            return _vlminparcela;
        }
        set
        {
            PropriedadeModificada(RO_VLMINPARCELA, value);
            _vlminparcela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlminpedido
    {
        get
        {
            PropriedadeAcessada(RO_VLMINPEDIDO);
            return _vlminpedido;
        }
        set
        {
            PropriedadeModificada(RO_VLMINPEDIDO, value);
            _vlminpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPLPAG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vltxcarne
    {
        get
        {
            PropriedadeAcessada(RO_VLTXCARNE);
            return _vltxcarne;
        }
        set
        {
            PropriedadeModificada(RO_VLTXCARNE, value);
            _vltxcarne = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPLPAG";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codequipe = AlterarTipo<decimal?>(leitor["Codequipe"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunc = AlterarTipo<decimal?>(leitor["Codfunc"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codplpagkraft = AlterarTipo<string>(leitor["Codplpagkraft"]);
        _codrestricao = AlterarTipo<decimal?>(leitor["Codrestricao"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _descricao2 = AlterarTipo<string>(leitor["Descricao2"]);
        _diafixo = AlterarTipo<decimal?>(leitor["Diafixo"]);
        _diascarencia = AlterarTipo<decimal?>(leitor["Diascarencia"]);
        _diasmaxparcela = AlterarTipo<decimal?>(leitor["Diasmaxparcela"]);
        _diasminparcela = AlterarTipo<decimal?>(leitor["Diasminparcela"]);
        _dtvenc1 = AlterarTipo<DateTime?>(leitor["Dtvenc1"]);
        _dtvenc2 = AlterarTipo<DateTime?>(leitor["Dtvenc2"]);
        _dtvenc3 = AlterarTipo<DateTime?>(leitor["Dtvenc3"]);
        _entrada = AlterarTipo<string>(leitor["Entrada"]);
        _enviaplanofv = AlterarTipo<string>(leitor["Enviaplanofv"]);
        _formaparcelamento = AlterarTipo<string>(leitor["Formaparcelamento"]);
        _letraplpag = AlterarTipo<string>(leitor["Letraplpag"]);
        _margemmin = AlterarTipo<decimal?>(leitor["Margemmin"]);
        _naodescentlimcredcli = AlterarTipo<string>(leitor["Naodescentlimcredcli"]);
        _numdias = AlterarTipo<decimal?>(leitor["Numdias"]);
        _numdiasatrasofim = AlterarTipo<decimal?>(leitor["Numdiasatrasofim"]);
        _numdiasatrasoini = AlterarTipo<decimal?>(leitor["Numdiasatrasoini"]);
        _numdiascarencia = AlterarTipo<decimal?>(leitor["Numdiascarencia"]);
        _numdiascartao = AlterarTipo<decimal?>(leitor["Numdiascartao"]);
        _numeroparcelasdiafixo = AlterarTipo<decimal?>(leitor["Numeroparcelasdiafixo"]);
        _numitensminimo = AlterarTipo<decimal?>(leitor["Numitensminimo"]);
        _numparcelas = AlterarTipo<decimal?>(leitor["Numparcelas"]);
        _numpr = AlterarTipo<decimal?>(leitor["Numpr"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obsplpag = AlterarTipo<string>(leitor["Obsplpag"]);
        _oferta = AlterarTipo<string>(leitor["Oferta"]);
        _pertxfim = AlterarTipo<decimal?>(leitor["Pertxfim"]);
        _pertxfimpalm = AlterarTipo<decimal?>(leitor["Pertxfimpalm"]);
        _prazoponderado = AlterarTipo<string>(leitor["Prazoponderado"]);
        _prazo1 = AlterarTipo<decimal?>(leitor["Prazo1"]);
        _prazo10 = AlterarTipo<decimal?>(leitor["Prazo10"]);
        _prazo11 = AlterarTipo<decimal?>(leitor["Prazo11"]);
        _prazo12 = AlterarTipo<decimal?>(leitor["Prazo12"]);
        _prazo2 = AlterarTipo<decimal?>(leitor["Prazo2"]);
        _prazo3 = AlterarTipo<decimal?>(leitor["Prazo3"]);
        _prazo4 = AlterarTipo<decimal?>(leitor["Prazo4"]);
        _prazo5 = AlterarTipo<decimal?>(leitor["Prazo5"]);
        _prazo6 = AlterarTipo<decimal?>(leitor["Prazo6"]);
        _prazo7 = AlterarTipo<decimal?>(leitor["Prazo7"]);
        _prazo8 = AlterarTipo<decimal?>(leitor["Prazo8"]);
        _prazo9 = AlterarTipo<decimal?>(leitor["Prazo9"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _tipoentrada = AlterarTipo<decimal?>(leitor["Tipoentrada"]);
        _tipoprazo = AlterarTipo<string>(leitor["Tipoprazo"]);
        _tiporestricao = AlterarTipo<string>(leitor["Tiporestricao"]);
        _tipovenda = AlterarTipo<string>(leitor["Tipovenda"]);
        _txfator = AlterarTipo<decimal?>(leitor["Txfator"]);
        _usadescfinanceiro = AlterarTipo<string>(leitor["Usadescfinanceiro"]);
        _usadesclinhaprod = AlterarTipo<string>(leitor["Usadesclinhaprod"]);
        _usamultifilial = AlterarTipo<string>(leitor["Usamultifilial"]);
        _usaplpagautoservico = AlterarTipo<string>(leitor["Usaplpagautoservico"]);
        _usaprazoadicionalpcclient = AlterarTipo<string>(leitor["Usaprazoadicionalpcclient"]);
        _vendabk = AlterarTipo<string>(leitor["Vendabk"]);
        _vlminparcela = AlterarTipo<decimal?>(leitor["Vlminparcela"]);
        _vlminpedido = AlterarTipo<decimal?>(leitor["Vlminpedido"]);
        _vltxcarne = AlterarTipo<decimal?>(leitor["Vltxcarne"]);
    }

}