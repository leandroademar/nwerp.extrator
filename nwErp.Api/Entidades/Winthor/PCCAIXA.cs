

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCAIXA : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ADMISSAO = "Admissao";

    private DateTime? _admissao;

    private static readonly string RO_ATUALIZACESTABASICA = "Atualizacestabasica";

    private string _atualizacestabasica;

    private static readonly string RO_ATUALIZACFO = "Atualizacfo";

    private string _atualizacfo;

    private static readonly string RO_ATUALIZACLIENTE = "Atualizacliente";

    private string _atualizacliente;

    private static readonly string RO_ATUALIZACLIENTEDTFIM = "Atualizaclientedtfim";

    private DateTime? _atualizaclientedtfim;

    private static readonly string RO_ATUALIZACLIENTEDTINI = "Atualizaclientedtini";

    private DateTime? _atualizaclientedtini;

    private static readonly string RO_ATUALIZAEMPREGADO = "Atualizaempregado";

    private string _atualizaempregado;

    private static readonly string RO_ATUALIZAFORMAPG = "Atualizaformapg";

    private string _atualizaformapg;

    private static readonly string RO_ATUALIZALAYOUT = "Atualizalayout";

    private string _atualizalayout;

    private static readonly string RO_ATUALIZAPCCOMISSAOPLPAG = "Atualizapccomissaoplpag";

    private string _atualizapccomissaoplpag;

    private static readonly string RO_ATUALIZAPCCOMISSAOUSUR = "Atualizapccomissaousur";

    private string _atualizapccomissaousur;

    private static readonly string RO_ATUALIZAPLANO = "Atualizaplano";

    private string _atualizaplano;

    private static readonly string RO_ATUALIZAPRECOEMBALAGEM = "Atualizaprecoembalagem";

    private string _atualizaprecoembalagem;

    private static readonly string RO_ATUALIZAPRECOEMBALAGEMDTFIM = "Atualizaprecoembalagemdtfim";

    private DateTime? _atualizaprecoembalagemdtfim;

    private static readonly string RO_ATUALIZAPRECOEMBALAGEMDTINI = "Atualizaprecoembalagemdtini";

    private DateTime? _atualizaprecoembalagemdtini;

    private static readonly string RO_ATUALIZAPRECOFIMVENDA = "Atualizaprecofimvenda";

    private string _atualizaprecofimvenda;

    private static readonly string RO_ATUALIZAPRECOREGIAO = "Atualizaprecoregiao";

    private string _atualizaprecoregiao;

    private static readonly string RO_ATUALIZAPRECOREGIAODTFIM = "Atualizaprecoregiaodtfim";

    private DateTime? _atualizaprecoregiaodtfim;

    private static readonly string RO_ATUALIZAPRECOREGIAODTINI = "Atualizaprecoregiaodtini";

    private DateTime? _atualizaprecoregiaodtini;

    private static readonly string RO_ATUALIZAPRODUTO = "Atualizaproduto";

    private string _atualizaproduto;

    private static readonly string RO_ATUALIZAPRODUTODTFIM = "Atualizaprodutodtfim";

    private DateTime? _atualizaprodutodtfim;

    private static readonly string RO_ATUALIZAPRODUTODTINI = "Atualizaprodutodtini";

    private DateTime? _atualizaprodutodtini;

    private static readonly string RO_ATUALIZASETOR = "Atualizasetor";

    private string _atualizasetor;

    private static readonly string RO_ATUALIZATRIBUTACAO = "Atualizatributacao";

    private string _atualizatributacao;

    private static readonly string RO_BITSDEDADOSLEITOR = "Bitsdedadosleitor";

    private string _bitsdedadosleitor;

    private static readonly string RO_BITSPORSEGUNDOLEITOR = "Bitsporsegundoleitor";

    private string _bitsporsegundoleitor;

    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal? _codbanco;

    private static readonly string RO_CODCLIPARC = "Codcliparc";

    private decimal? _codcliparc;

    private static readonly string RO_CODEMPRESASITEF = "Codempresasitef";

    private string _codempresasitef;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODNACIONALECF = "Codnacionalecf";

    private string _codnacionalecf;

    private static readonly string RO_CODPRODPARC = "Codprodparc";

    private decimal? _codprodparc;

    private static readonly string RO_CONFIRMAR_CARGA = "Confirmar_Carga";

    private string _confirmar_carga;

    private static readonly string RO_DATAFIMPARC = "Datafimparc";

    private DateTime? _datafimparc;

    private static readonly string RO_DATAINIPARC = "Datainiparc";

    private DateTime? _datainiparc;

    private static readonly string RO_DEGUSTACAO = "Degustacao";

    private string _degustacao;

    private static readonly string RO_DESCRICAO = "Descricao";

    private string _descricao;

    private static readonly string RO_DIRATUALIZACAO = "Diratualizacao";

    private string _diratualizacao;

    private static readonly string RO_DTFIM = "Dtfim";

    private DateTime? _dtfim;

    private static readonly string RO_DTINICIO = "Dtinicio";

    private DateTime? _dtinicio;

    private static readonly string RO_DTPROXATULIZACAO = "Dtproxatulizacao";

    private decimal? _dtproxatulizacao;

    private static readonly string RO_DTPROXCARGAGERAL = "Dtproxcargageral";

    private DateTime? _dtproxcargageral;

    private static readonly string RO_DTPROXCARGAPARCIAL = "Dtproxcargaparcial";

    private DateTime? _dtproxcargaparcial;

    private static readonly string RO_DTREINICIOOP = "Dtreinicioop";

    private DateTime? _dtreinicioop;

    private static readonly string RO_DTSWBASICO = "Dtswbasico";

    private DateTime? _dtswbasico;

    private static readonly string RO_DTSWUSUARIO = "Dtswusuario";

    private DateTime? _dtswusuario;

    private static readonly string RO_DTULTCARGAGERAL = "Dtultcargageral";

    private DateTime? _dtultcargageral;

    private static readonly string RO_DTULTCARGAPARCIAL = "Dtultcargaparcial";

    private DateTime? _dtultcargaparcial;

    private static readonly string RO_GAVETAACOPLADA = "Gavetaacoplada";

    private string _gavetaacoplada;

    private static readonly string RO_IPSERVIDORSITEF = "Ipservidorsitef";

    private string _ipservidorsitef;

    private static readonly string RO_ITENSCARGAGERAL = "Itenscargageral";

    private string _itenscargageral;

    private static readonly string RO_ITENSCARGAPARCIAL = "Itenscargaparcial";

    private string _itenscargaparcial;

    private static readonly string RO_MODELO = "Modelo";

    private string _modelo;

    private static readonly string RO_MODELOECF = "Modeloecf";

    private string _modeloecf;

    private static readonly string RO_MSGCUPOMFISCAL = "Msgcupomfiscal";

    private string _msgcupomfiscal;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal _numcaixa;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_NUMCUPOMABERTO = "Numcupomaberto";

    private decimal? _numcupomaberto;

    private static readonly string RO_NUMCUPOMFECHADO = "Numcupomfechado";

    private decimal? _numcupomfechado;

    private static readonly string RO_NUMOPCX = "Numopcx";

    private decimal? _numopcx;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private string _numserieequip;

    private static readonly string RO_NUMUSUARIOECF = "Numusuarioecf";

    private decimal? _numusuarioecf;

    private static readonly string RO_PARIDADELEITOR = "Paridadeleitor";

    private string _paridadeleitor;

    private static readonly string RO_PERMITEABRIRGAVETA = "Permiteabrirgaveta";

    private string _permiteabrirgaveta;

    private static readonly string RO_PORTAIMPRESSORA = "Portaimpressora";

    private decimal? _portaimpressora;

    private static readonly string RO_PORTAIMPRESSORACHEQUE = "Portaimpressoracheque";

    private decimal? _portaimpressoracheque;

    private static readonly string RO_PORTALEITOR = "Portaleitor";

    private decimal? _portaleitor;

    private static readonly string RO_PORTALEITORCH = "Portaleitorch";

    private decimal? _portaleitorch;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    private static readonly string RO_RESPSITEFTECLADO = "Respsitefteclado";

    private string _respsitefteclado;

    private static readonly string RO_SALTARLINHATEF = "Saltarlinhatef";

    private string _saltarlinhatef;

    private static readonly string RO_SOLICITARCAVENDA = "Solicitarcavenda";

    private string _solicitarcavenda;

    private static readonly string RO_TERMINALSITEF = "Terminalsitef";

    private string _terminalsitef;

    private static readonly string RO_TIPOBALANCA = "Tipobalanca";

    private string _tipobalanca;

    private static readonly string RO_TIPOIMPRESSORA = "Tipoimpressora";

    private string _tipoimpressora;

    private static readonly string RO_TIPOIMPRESSORACHEQUE = "Tipoimpressoracheque";

    private string _tipoimpressoracheque;

    private static readonly string RO_TIPOTECLADO = "Tipoteclado";

    private string _tipoteclado;

    private static readonly string RO_TIPOTEF = "Tipotef";

    private string _tipotef;

    private static readonly string RO_USAINDICEECF = "Usaindiceecf";

    private string _usaindiceecf;

    private static readonly string RO_USASUFIXOLEITOR = "Usasufixoleitor";

    private string _usasufixoleitor;

    private static readonly string RO_VALIDACH = "Validach";

    private string _validach;

    private static readonly string RO_VERFIRMWARE = "Verfirmware";

    private string _verfirmware;

    private static readonly string RO_VERSAOIMPRESSORA = "Versaoimpressora";

    private string _versaoimpressora;

    private static readonly string RO_VERSAOIMPRESSORACHEQUE = "Versaoimpressoracheque";

    private string _versaoimpressoracheque;

    private static readonly string RO_NUMSAT = "Numsat";

    private decimal? _numsat;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Admissao
    {
        get
        {
            PropriedadeAcessada(RO_ADMISSAO);
            return _admissao;
        }
        set
        {
            PropriedadeModificada(RO_ADMISSAO, value);
            _admissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacestabasica
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACESTABASICA);
            return _atualizacestabasica;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACESTABASICA, value);
            _atualizacestabasica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacfo
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACFO);
            return _atualizacfo;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACFO, value);
            _atualizacfo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizacliente
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACLIENTE);
            return _atualizacliente;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACLIENTE, value);
            _atualizacliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaclientedtfim
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACLIENTEDTFIM);
            return _atualizaclientedtfim;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACLIENTEDTFIM, value);
            _atualizaclientedtfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaclientedtini
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZACLIENTEDTINI);
            return _atualizaclientedtini;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZACLIENTEDTINI, value);
            _atualizaclientedtini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaempregado
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAEMPREGADO);
            return _atualizaempregado;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAEMPREGADO, value);
            _atualizaempregado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaformapg
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAFORMAPG);
            return _atualizaformapg;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAFORMAPG, value);
            _atualizaformapg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizalayout
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZALAYOUT);
            return _atualizalayout;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZALAYOUT, value);
            _atualizalayout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizapccomissaoplpag
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPCCOMISSAOPLPAG);
            return _atualizapccomissaoplpag;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPCCOMISSAOPLPAG, value);
            _atualizapccomissaoplpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizapccomissaousur
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPCCOMISSAOUSUR);
            return _atualizapccomissaousur;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPCCOMISSAOUSUR, value);
            _atualizapccomissaousur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaplano
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPLANO);
            return _atualizaplano;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPLANO, value);
            _atualizaplano = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaprecoembalagem
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOEMBALAGEM);
            return _atualizaprecoembalagem;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOEMBALAGEM, value);
            _atualizaprecoembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprecoembalagemdtfim
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOEMBALAGEMDTFIM);
            return _atualizaprecoembalagemdtfim;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOEMBALAGEMDTFIM, value);
            _atualizaprecoembalagemdtfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprecoembalagemdtini
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOEMBALAGEMDTINI);
            return _atualizaprecoembalagemdtini;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOEMBALAGEMDTINI, value);
            _atualizaprecoembalagemdtini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaprecofimvenda
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOFIMVENDA);
            return _atualizaprecofimvenda;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOFIMVENDA, value);
            _atualizaprecofimvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaprecoregiao
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOREGIAO);
            return _atualizaprecoregiao;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOREGIAO, value);
            _atualizaprecoregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprecoregiaodtfim
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOREGIAODTFIM);
            return _atualizaprecoregiaodtfim;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOREGIAODTFIM, value);
            _atualizaprecoregiaodtfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprecoregiaodtini
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRECOREGIAODTINI);
            return _atualizaprecoregiaodtini;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRECOREGIAODTINI, value);
            _atualizaprecoregiaodtini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizaproduto
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRODUTO);
            return _atualizaproduto;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRODUTO, value);
            _atualizaproduto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprodutodtfim
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRODUTODTFIM);
            return _atualizaprodutodtfim;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRODUTODTFIM, value);
            _atualizaprodutodtfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Atualizaprodutodtini
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAPRODUTODTINI);
            return _atualizaprodutodtini;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAPRODUTODTINI, value);
            _atualizaprodutodtini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizasetor
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZASETOR);
            return _atualizasetor;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZASETOR, value);
            _atualizasetor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizatributacao
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZATRIBUTACAO);
            return _atualizatributacao;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZATRIBUTACAO, value);
            _atualizatributacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Bitsdedadosleitor
    {
        get
        {
            PropriedadeAcessada(RO_BITSDEDADOSLEITOR);
            return _bitsdedadosleitor;
        }
        set
        {
            PropriedadeModificada(RO_BITSDEDADOSLEITOR, value);
            _bitsdedadosleitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Bitsporsegundoleitor
    {
        get
        {
            PropriedadeAcessada(RO_BITSPORSEGUNDOLEITOR);
            return _bitsporsegundoleitor;
        }
        set
        {
            PropriedadeModificada(RO_BITSPORSEGUNDOLEITOR, value);
            _bitsporsegundoleitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcliparc
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIPARC);
            return _codcliparc;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIPARC, value);
            _codcliparc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codempresasitef
    {
        get
        {
            PropriedadeAcessada(RO_CODEMPRESASITEF);
            return _codempresasitef;
        }
        set
        {
            PropriedadeModificada(RO_CODEMPRESASITEF, value);
            _codempresasitef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codnacionalecf
    {
        get
        {
            PropriedadeAcessada(RO_CODNACIONALECF);
            return _codnacionalecf;
        }
        set
        {
            PropriedadeModificada(RO_CODNACIONALECF, value);
            _codnacionalecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodparc
    {
        get
        {
            PropriedadeAcessada(RO_CODPRODPARC);
            return _codprodparc;
        }
        set
        {
            PropriedadeModificada(RO_CODPRODPARC, value);
            _codprodparc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Confirmar_Carga
    {
        get
        {
            PropriedadeAcessada(RO_CONFIRMAR_CARGA);
            return _confirmar_carga;
        }
        set
        {
            PropriedadeModificada(RO_CONFIRMAR_CARGA, value);
            _confirmar_carga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafimparc
    {
        get
        {
            PropriedadeAcessada(RO_DATAFIMPARC);
            return _datafimparc;
        }
        set
        {
            PropriedadeModificada(RO_DATAFIMPARC, value);
            _datafimparc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datainiparc
    {
        get
        {
            PropriedadeAcessada(RO_DATAINIPARC);
            return _datainiparc;
        }
        set
        {
            PropriedadeModificada(RO_DATAINIPARC, value);
            _datainiparc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Degustacao
    {
        get
        {
            PropriedadeAcessada(RO_DEGUSTACAO);
            return _degustacao;
        }
        set
        {
            PropriedadeModificada(RO_DEGUSTACAO, value);
            _degustacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Diratualizacao
    {
        get
        {
            PropriedadeAcessada(RO_DIRATUALIZACAO);
            return _diratualizacao;
        }
        set
        {
            PropriedadeModificada(RO_DIRATUALIZACAO, value);
            _diratualizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfim
    {
        get
        {
            PropriedadeAcessada(RO_DTFIM);
            return _dtfim;
        }
        set
        {
            PropriedadeModificada(RO_DTFIM, value);
            _dtfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicio
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIO);
            return _dtinicio;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIO, value);
            _dtinicio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Dtproxatulizacao
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXATULIZACAO);
            return _dtproxatulizacao;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXATULIZACAO, value);
            _dtproxatulizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxcargageral
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXCARGAGERAL);
            return _dtproxcargageral;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXCARGAGERAL, value);
            _dtproxcargageral = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtproxcargaparcial
    {
        get
        {
            PropriedadeAcessada(RO_DTPROXCARGAPARCIAL);
            return _dtproxcargaparcial;
        }
        set
        {
            PropriedadeModificada(RO_DTPROXCARGAPARCIAL, value);
            _dtproxcargaparcial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtreinicioop
    {
        get
        {
            PropriedadeAcessada(RO_DTREINICIOOP);
            return _dtreinicioop;
        }
        set
        {
            PropriedadeModificada(RO_DTREINICIOOP, value);
            _dtreinicioop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtswbasico
    {
        get
        {
            PropriedadeAcessada(RO_DTSWBASICO);
            return _dtswbasico;
        }
        set
        {
            PropriedadeModificada(RO_DTSWBASICO, value);
            _dtswbasico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtswusuario
    {
        get
        {
            PropriedadeAcessada(RO_DTSWUSUARIO);
            return _dtswusuario;
        }
        set
        {
            PropriedadeModificada(RO_DTSWUSUARIO, value);
            _dtswusuario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultcargageral
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCARGAGERAL);
            return _dtultcargageral;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCARGAGERAL, value);
            _dtultcargageral = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultcargaparcial
    {
        get
        {
            PropriedadeAcessada(RO_DTULTCARGAPARCIAL);
            return _dtultcargaparcial;
        }
        set
        {
            PropriedadeModificada(RO_DTULTCARGAPARCIAL, value);
            _dtultcargaparcial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gavetaacoplada
    {
        get
        {
            PropriedadeAcessada(RO_GAVETAACOPLADA);
            return _gavetaacoplada;
        }
        set
        {
            PropriedadeModificada(RO_GAVETAACOPLADA, value);
            _gavetaacoplada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Ipservidorsitef
    {
        get
        {
            PropriedadeAcessada(RO_IPSERVIDORSITEF);
            return _ipservidorsitef;
        }
        set
        {
            PropriedadeModificada(RO_IPSERVIDORSITEF, value);
            _ipservidorsitef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Itenscargageral
    {
        get
        {
            PropriedadeAcessada(RO_ITENSCARGAGERAL);
            return _itenscargageral;
        }
        set
        {
            PropriedadeModificada(RO_ITENSCARGAGERAL, value);
            _itenscargageral = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Itenscargaparcial
    {
        get
        {
            PropriedadeAcessada(RO_ITENSCARGAPARCIAL);
            return _itenscargaparcial;
        }
        set
        {
            PropriedadeModificada(RO_ITENSCARGAPARCIAL, value);
            _itenscargaparcial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Modelo
    {
        get
        {
            PropriedadeAcessada(RO_MODELO);
            return _modelo;
        }
        set
        {
            PropriedadeModificada(RO_MODELO, value);
            _modelo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Modeloecf
    {
        get
        {
            PropriedadeAcessada(RO_MODELOECF);
            return _modeloecf;
        }
        set
        {
            PropriedadeModificada(RO_MODELOECF, value);
            _modeloecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Msgcupomfiscal
    {
        get
        {
            PropriedadeAcessada(RO_MSGCUPOMFISCAL);
            return _msgcupomfiscal;
        }
        set
        {
            PropriedadeModificada(RO_MSGCUPOMFISCAL, value);
            _msgcupomfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAIXAFISCAL);
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAIXAFISCAL, value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupomaberto
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOMABERTO);
            return _numcupomaberto;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOMABERTO, value);
            _numcupomaberto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupomfechado
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOMFECHADO);
            return _numcupomfechado;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOMFECHADO, value);
            _numcupomfechado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numopcx
    {
        get
        {
            PropriedadeAcessada(RO_NUMOPCX);
            return _numopcx;
        }
        set
        {
            PropriedadeModificada(RO_NUMOPCX, value);
            _numopcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numregiao
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numusuarioecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMUSUARIOECF);
            return _numusuarioecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMUSUARIOECF, value);
            _numusuarioecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Paridadeleitor
    {
        get
        {
            PropriedadeAcessada(RO_PARIDADELEITOR);
            return _paridadeleitor;
        }
        set
        {
            PropriedadeModificada(RO_PARIDADELEITOR, value);
            _paridadeleitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteabrirgaveta
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEABRIRGAVETA);
            return _permiteabrirgaveta;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEABRIRGAVETA, value);
            _permiteabrirgaveta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Portaimpressora
    {
        get
        {
            PropriedadeAcessada(RO_PORTAIMPRESSORA);
            return _portaimpressora;
        }
        set
        {
            PropriedadeModificada(RO_PORTAIMPRESSORA, value);
            _portaimpressora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Portaimpressoracheque
    {
        get
        {
            PropriedadeAcessada(RO_PORTAIMPRESSORACHEQUE);
            return _portaimpressoracheque;
        }
        set
        {
            PropriedadeModificada(RO_PORTAIMPRESSORACHEQUE, value);
            _portaimpressoracheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Portaleitor
    {
        get
        {
            PropriedadeAcessada(RO_PORTALEITOR);
            return _portaleitor;
        }
        set
        {
            PropriedadeModificada(RO_PORTALEITOR, value);
            _portaleitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Portaleitorch
    {
        get
        {
            PropriedadeAcessada(RO_PORTALEITORCH);
            return _portaleitorch;
        }
        set
        {
            PropriedadeModificada(RO_PORTALEITORCH, value);
            _portaleitorch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Respsitefteclado
    {
        get
        {
            PropriedadeAcessada(RO_RESPSITEFTECLADO);
            return _respsitefteclado;
        }
        set
        {
            PropriedadeModificada(RO_RESPSITEFTECLADO, value);
            _respsitefteclado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Saltarlinhatef
    {
        get
        {
            PropriedadeAcessada(RO_SALTARLINHATEF);
            return _saltarlinhatef;
        }
        set
        {
            PropriedadeModificada(RO_SALTARLINHATEF, value);
            _saltarlinhatef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Solicitarcavenda
    {
        get
        {
            PropriedadeAcessada(RO_SOLICITARCAVENDA);
            return _solicitarcavenda;
        }
        set
        {
            PropriedadeModificada(RO_SOLICITARCAVENDA, value);
            _solicitarcavenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Terminalsitef
    {
        get
        {
            PropriedadeAcessada(RO_TERMINALSITEF);
            return _terminalsitef;
        }
        set
        {
            PropriedadeModificada(RO_TERMINALSITEF, value);
            _terminalsitef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipobalanca
    {
        get
        {
            PropriedadeAcessada(RO_TIPOBALANCA);
            return _tipobalanca;
        }
        set
        {
            PropriedadeModificada(RO_TIPOBALANCA, value);
            _tipobalanca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoimpressora
    {
        get
        {
            PropriedadeAcessada(RO_TIPOIMPRESSORA);
            return _tipoimpressora;
        }
        set
        {
            PropriedadeModificada(RO_TIPOIMPRESSORA, value);
            _tipoimpressora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoimpressoracheque
    {
        get
        {
            PropriedadeAcessada(RO_TIPOIMPRESSORACHEQUE);
            return _tipoimpressoracheque;
        }
        set
        {
            PropriedadeModificada(RO_TIPOIMPRESSORACHEQUE, value);
            _tipoimpressoracheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoteclado
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTECLADO);
            return _tipoteclado;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTECLADO, value);
            _tipoteclado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipotef
    {
        get
        {
            PropriedadeAcessada(RO_TIPOTEF);
            return _tipotef;
        }
        set
        {
            PropriedadeModificada(RO_TIPOTEF, value);
            _tipotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usaindiceecf
    {
        get
        {
            PropriedadeAcessada(RO_USAINDICEECF);
            return _usaindiceecf;
        }
        set
        {
            PropriedadeModificada(RO_USAINDICEECF, value);
            _usaindiceecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usasufixoleitor
    {
        get
        {
            PropriedadeAcessada(RO_USASUFIXOLEITOR);
            return _usasufixoleitor;
        }
        set
        {
            PropriedadeModificada(RO_USASUFIXOLEITOR, value);
            _usasufixoleitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validach
    {
        get
        {
            PropriedadeAcessada(RO_VALIDACH);
            return _validach;
        }
        set
        {
            PropriedadeModificada(RO_VALIDACH, value);
            _validach = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Verfirmware
    {
        get
        {
            PropriedadeAcessada(RO_VERFIRMWARE);
            return _verfirmware;
        }
        set
        {
            PropriedadeModificada(RO_VERFIRMWARE, value);
            _verfirmware = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Versaoimpressora
    {
        get
        {
            PropriedadeAcessada(RO_VERSAOIMPRESSORA);
            return _versaoimpressora;
        }
        set
        {
            PropriedadeModificada(RO_VERSAOIMPRESSORA, value);
            _versaoimpressora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Versaoimpressoracheque
    {
        get
        {
            PropriedadeAcessada(RO_VERSAOIMPRESSORACHEQUE);
            return _versaoimpressoracheque;
        }
        set
        {
            PropriedadeModificada(RO_VERSAOIMPRESSORACHEQUE, value);
            _versaoimpressoracheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCAIXA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numsat
    {
        get
        {
            PropriedadeAcessada(RO_NUMSAT);
            return _numsat;
        }
        set
        {
            PropriedadeModificada(RO_NUMSAT, value);
            _numsat = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCAIXA";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _admissao = AlterarTipo<DateTime?>(leitor["Admissao"]);
        _atualizacestabasica = AlterarTipo<string>(leitor["Atualizacestabasica"]);
        _atualizacfo = AlterarTipo<string>(leitor["Atualizacfo"]);
        _atualizacliente = AlterarTipo<string>(leitor["Atualizacliente"]);
        _atualizaclientedtfim = AlterarTipo<DateTime?>(leitor["Atualizaclientedtfim"]);
        _atualizaclientedtini = AlterarTipo<DateTime?>(leitor["Atualizaclientedtini"]);
        _atualizaempregado = AlterarTipo<string>(leitor["Atualizaempregado"]);
        _atualizaformapg = AlterarTipo<string>(leitor["Atualizaformapg"]);
        _atualizalayout = AlterarTipo<string>(leitor["Atualizalayout"]);
        _atualizapccomissaoplpag = AlterarTipo<string>(leitor["Atualizapccomissaoplpag"]);
        _atualizapccomissaousur = AlterarTipo<string>(leitor["Atualizapccomissaousur"]);
        _atualizaplano = AlterarTipo<string>(leitor["Atualizaplano"]);
        _atualizaprecoembalagem = AlterarTipo<string>(leitor["Atualizaprecoembalagem"]);
        _atualizaprecoembalagemdtfim = AlterarTipo<DateTime?>(leitor["Atualizaprecoembalagemdtfim"]);
        _atualizaprecoembalagemdtini = AlterarTipo<DateTime?>(leitor["Atualizaprecoembalagemdtini"]);
        _atualizaprecofimvenda = AlterarTipo<string>(leitor["Atualizaprecofimvenda"]);
        _atualizaprecoregiao = AlterarTipo<string>(leitor["Atualizaprecoregiao"]);
        _atualizaprecoregiaodtfim = AlterarTipo<DateTime?>(leitor["Atualizaprecoregiaodtfim"]);
        _atualizaprecoregiaodtini = AlterarTipo<DateTime?>(leitor["Atualizaprecoregiaodtini"]);
        _atualizaproduto = AlterarTipo<string>(leitor["Atualizaproduto"]);
        _atualizaprodutodtfim = AlterarTipo<DateTime?>(leitor["Atualizaprodutodtfim"]);
        _atualizaprodutodtini = AlterarTipo<DateTime?>(leitor["Atualizaprodutodtini"]);
        _atualizasetor = AlterarTipo<string>(leitor["Atualizasetor"]);
        _atualizatributacao = AlterarTipo<string>(leitor["Atualizatributacao"]);
        _bitsdedadosleitor = AlterarTipo<string>(leitor["Bitsdedadosleitor"]);
        _bitsporsegundoleitor = AlterarTipo<string>(leitor["Bitsporsegundoleitor"]);
        _codbanco = AlterarTipo<decimal?>(leitor["Codbanco"]);
        _codcliparc = AlterarTipo<decimal?>(leitor["Codcliparc"]);
        _codempresasitef = AlterarTipo<string>(leitor["Codempresasitef"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codnacionalecf = AlterarTipo<string>(leitor["Codnacionalecf"]);
        _codprodparc = AlterarTipo<decimal?>(leitor["Codprodparc"]);
        _confirmar_carga = AlterarTipo<string>(leitor["Confirmar_Carga"]);
        _datafimparc = AlterarTipo<DateTime?>(leitor["Datafimparc"]);
        _datainiparc = AlterarTipo<DateTime?>(leitor["Datainiparc"]);
        _degustacao = AlterarTipo<string>(leitor["Degustacao"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _diratualizacao = AlterarTipo<string>(leitor["Diratualizacao"]);
        _dtfim = AlterarTipo<DateTime?>(leitor["Dtfim"]);
        _dtinicio = AlterarTipo<DateTime?>(leitor["Dtinicio"]);
        _dtproxatulizacao = AlterarTipo<decimal?>(leitor["Dtproxatulizacao"]);
        _dtproxcargageral = AlterarTipo<DateTime?>(leitor["Dtproxcargageral"]);
        _dtproxcargaparcial = AlterarTipo<DateTime?>(leitor["Dtproxcargaparcial"]);
        _dtreinicioop = AlterarTipo<DateTime?>(leitor["Dtreinicioop"]);
        _dtswbasico = AlterarTipo<DateTime?>(leitor["Dtswbasico"]);
        _dtswusuario = AlterarTipo<DateTime?>(leitor["Dtswusuario"]);
        _dtultcargageral = AlterarTipo<DateTime?>(leitor["Dtultcargageral"]);
        _dtultcargaparcial = AlterarTipo<DateTime?>(leitor["Dtultcargaparcial"]);
        _gavetaacoplada = AlterarTipo<string>(leitor["Gavetaacoplada"]);
        _ipservidorsitef = AlterarTipo<string>(leitor["Ipservidorsitef"]);
        _itenscargageral = AlterarTipo<string>(leitor["Itenscargageral"]);
        _itenscargaparcial = AlterarTipo<string>(leitor["Itenscargaparcial"]);
        _modelo = AlterarTipo<string>(leitor["Modelo"]);
        _modeloecf = AlterarTipo<string>(leitor["Modeloecf"]);
        _msgcupomfiscal = AlterarTipo<string>(leitor["Msgcupomfiscal"]);
        _numcaixa = AlterarTipo<decimal>(leitor["Numcaixa"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcupomaberto = AlterarTipo<decimal?>(leitor["Numcupomaberto"]);
        _numcupomfechado = AlterarTipo<decimal?>(leitor["Numcupomfechado"]);
        _numopcx = AlterarTipo<decimal?>(leitor["Numopcx"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
        _numusuarioecf = AlterarTipo<decimal?>(leitor["Numusuarioecf"]);
        _paridadeleitor = AlterarTipo<string>(leitor["Paridadeleitor"]);
        _permiteabrirgaveta = AlterarTipo<string>(leitor["Permiteabrirgaveta"]);
        _portaimpressora = AlterarTipo<decimal?>(leitor["Portaimpressora"]);
        _portaimpressoracheque = AlterarTipo<decimal?>(leitor["Portaimpressoracheque"]);
        _portaleitor = AlterarTipo<decimal?>(leitor["Portaleitor"]);
        _portaleitorch = AlterarTipo<decimal?>(leitor["Portaleitorch"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _respsitefteclado = AlterarTipo<string>(leitor["Respsitefteclado"]);
        _saltarlinhatef = AlterarTipo<string>(leitor["Saltarlinhatef"]);
        _solicitarcavenda = AlterarTipo<string>(leitor["Solicitarcavenda"]);
        _terminalsitef = AlterarTipo<string>(leitor["Terminalsitef"]);
        _tipobalanca = AlterarTipo<string>(leitor["Tipobalanca"]);
        _tipoimpressora = AlterarTipo<string>(leitor["Tipoimpressora"]);
        _tipoimpressoracheque = AlterarTipo<string>(leitor["Tipoimpressoracheque"]);
        _tipoteclado = AlterarTipo<string>(leitor["Tipoteclado"]);
        _tipotef = AlterarTipo<string>(leitor["Tipotef"]);
        _usaindiceecf = AlterarTipo<string>(leitor["Usaindiceecf"]);
        _usasufixoleitor = AlterarTipo<string>(leitor["Usasufixoleitor"]);
        _validach = AlterarTipo<string>(leitor["Validach"]);
        _verfirmware = AlterarTipo<string>(leitor["Verfirmware"]);
        _versaoimpressora = AlterarTipo<string>(leitor["Versaoimpressora"]);
        _versaoimpressoracheque = AlterarTipo<string>(leitor["Versaoimpressoracheque"]);
        _numsat = AlterarTipo<decimal?>(leitor["Numsat"]);
    }

}