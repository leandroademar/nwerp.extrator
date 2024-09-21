

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPRODFILIAL : GerenteDePropriedades, IEntidade
{
    private string _abastepalete;

    private string _abastepaletecx;

    private string _aceitavendafracao;

    private decimal? _alturapal;

    private string _ativo;

    private string _atualizafilialgestaowms;

    private decimal? _basepiscofinslit;

    private string _calccredipi;

    private string _calculaipi;

    private string _checarmultiplovendabnf;

    private string _classe;

    private string _classeestoque;

    private string _classevenda;

    private string _cnaedesoneracao;

    private string _codauxiliarfav;

    private decimal? _codcaracprod;

    private decimal? _codcomprador;

    private decimal? _coddispestrutura;

    private decimal? _codexcecaopiscofins;

    private decimal? _codfigura;

    private string _codfilial;

    private decimal? _codfuncultalter;

    private decimal _codprod;

    private string _codprodantuticad;

    private decimal? _codrotinaultaltcom;

    private decimal? _codrotinaultaltcomtab;

    private decimal? _codrotinaultalter;

    private decimal? _codsittribpiscofins;

    private decimal? _codsittribpiscofinsdev;

    private decimal? _codtipoestruturapul;

    private string _codtribsefaz;

    private decimal? _codusuultaltcom;

    private decimal? _codusuultaltcomtab;

    private string _considerastguiacusto;

    private string _considerastguiacustocont;

    private string _considerastnfcusto;

    private string _considerastnfcustocont;

    private string _controlanumserie;

    private string _controlarfci;

    private string _controledevalidade;

    private decimal? _custorep;

    private decimal? _custorepant;

    private decimal? _custoreptab;

    private string _digitarqtmaster;

    private string _dscprodantuticad;

    private DateTime? _dtfinuticodprodantuticad;

    private DateTime? _dtinicodprodantuticad;

    private DateTime? _dtprimovnovcodprod;

    private DateTime? _dtultaltcom;

    private DateTime? _dtultatupcompra;

    private DateTime? _dtvigenciapolitica;

    private string _emitiretqent;

    private string _enviarforcavendas;

    private decimal? _estoqueideal;

    private decimal? _estoquemax;

    private decimal? _estoquemin;

    private string _estoqueporserie;

    private string _filialgestaowms;

    private string _foralinha;

    private string _fracionado;

    private string _gerabasepiscofinssemaliq;

    private string _geraicmslivrofiscal;

    private string _geraicmslivrofiscaldevfornec;

    private string _geraicmslivrofiscalent;

    private string _icmsdiferido;

    private decimal? _lastropal;

    private decimal? _multiplo;

    private decimal? _multiplocompras;

    private decimal? _nivelmaximoarm;

    private decimal? _nivelminimoarm;

    private string _normapalete;

    private string _novacaixaflowrack;

    private decimal? _numerosseriecontrolados;

    private string _origmerctrib;

    private string _pckrotativo;

    private decimal? _pcomext1;

    private decimal? _pcomint1;

    private decimal? _pcomrep1;

    private decimal? _percacres;

    private decimal? _percaliqvigext;

    private decimal? _percaliqvigint;

    private decimal? _percaltercustoent;

    private decimal? _percarredonda;

    private decimal? _percbon;

    private decimal? _percbonific;

    private decimal? _percbonifictab;

    private decimal? _percbonoutras;

    private decimal? _percbonoutrastab;

    private decimal? _percbontab;

    private decimal? _percdesc;

    private decimal? _percdesc1;

    private decimal? _percdesc10;

    private decimal? _percdesc10tab;

    private decimal? _percdesc1tab;

    private decimal? _percdesc2;

    private decimal? _percdesc2tab;

    private decimal? _percdesc3;

    private decimal? _percdesc3tab;

    private decimal? _percdesc4;

    private decimal? _percdesc4tab;

    private decimal? _percdesc5;

    private decimal? _percdesc5tab;

    private decimal? _percdesc6;

    private decimal? _percdesc6tab;

    private decimal? _percdesc7;

    private decimal? _percdesc7tab;

    private decimal? _percdesc8;

    private decimal? _percdesc8tab;

    private decimal? _percdesc9;

    private decimal? _percdesc9tab;

    private decimal? _percdesoneracao;

    private decimal? _percmargemmin;

    private decimal? _percmaxvarpvenda;

    private decimal? _percofins;

    private decimal? _percredpmc;

    private decimal? _perctoleranciacorte;

    private decimal? _perctoleranciadepuratransf;

    private decimal? _perctoleranciaval;

    private decimal? _perdescretencao;

    private decimal? _perpis;

    private decimal? _pesopalete;

    private string _piscofinsretido;

    private decimal? _prazoval;

    private string _precoutilizadonfe;

    private string _proibidavenda;

    private string _protocoloicms1785;

    private decimal? _ptabelafornec;

    private decimal? _qtmaxpedvenda;

    private decimal? _qtminautoserv;

    private decimal? _qtminimaatacado;

    private decimal? _qtminimaatacadof;

    private decimal? _qtminsugcompra;

    private decimal? _qtpulmaoregulador;

    private decimal? _qttotpal;

    private string _regimeespecial;

    private decimal? _restricaoblocado;

    private string _revenda;

    private string _subclasse;

    private string _sujdesoneracao;

    private string _tipoarredunidmaster;

    private decimal? _tipocarga;

    private string _tipoestagenda;

    private string _tipoestoquemaximo;

    private string _tipoestoqueminimo;

    private decimal? _tipopalpul;

    private decimal? _tipoprod;

    private string _tiposugestao;

    private string _tipovariacao;

    private string _usanumeroserie;

    private string _usapiscofinslit;

    private string _usapmcbasest;

    private string _usapulmaoregulador;

    private string _usarqtosun;

    private string _utilizaqtdesupmultipla;

    private string _validacapacidadepicking;

    private string _verbadinporperc;

    private decimal? _vlbonific;

    private decimal? _vlbonifictab;

    private decimal? _vlcofinslit;

    private decimal? _vlpautapiscofins;

    private decimal? _vlpislit;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastepalete
    {
        get
        {
            PropriedadeAcessada("Abastepalete");
            return _abastepalete;
        }
        set
        {
            PropriedadeModificada("Abastepalete", value);
            _abastepalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastepaletecx
    {
        get
        {
            PropriedadeAcessada("Abastepaletecx");
            return _abastepaletecx;
        }
        set
        {
            PropriedadeModificada("Abastepaletecx", value);
            _abastepaletecx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitavendafracao
    {
        get
        {
            PropriedadeAcessada("Aceitavendafracao");
            return _aceitavendafracao;
        }
        set
        {
            PropriedadeModificada("Aceitavendafracao", value);
            _aceitavendafracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Alturapal
    {
        get
        {
            PropriedadeAcessada("Alturapal");
            return _alturapal;
        }
        set
        {
            PropriedadeModificada("Alturapal", value);
            _alturapal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ativo
    {
        get
        {
            PropriedadeAcessada("Ativo");
            return _ativo;
        }
        set
        {
            PropriedadeModificada("Ativo", value);
            _ativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizafilialgestaowms
    {
        get
        {
            PropriedadeAcessada("Atualizafilialgestaowms");
            return _atualizafilialgestaowms;
        }
        set
        {
            PropriedadeModificada("Atualizafilialgestaowms", value);
            _atualizafilialgestaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basepiscofinslit
    {
        get
        {
            PropriedadeAcessada("Basepiscofinslit");
            return _basepiscofinslit;
        }
        set
        {
            PropriedadeModificada("Basepiscofinslit", value);
            _basepiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calccredipi
    {
        get
        {
            PropriedadeAcessada("Calccredipi");
            return _calccredipi;
        }
        set
        {
            PropriedadeModificada("Calccredipi", value);
            _calccredipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calculaipi
    {
        get
        {
            PropriedadeAcessada("Calculaipi");
            return _calculaipi;
        }
        set
        {
            PropriedadeModificada("Calculaipi", value);
            _calculaipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Checarmultiplovendabnf
    {
        get
        {
            PropriedadeAcessada("Checarmultiplovendabnf");
            return _checarmultiplovendabnf;
        }
        set
        {
            PropriedadeModificada("Checarmultiplovendabnf", value);
            _checarmultiplovendabnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classe
    {
        get
        {
            PropriedadeAcessada("Classe");
            return _classe;
        }
        set
        {
            PropriedadeModificada("Classe", value);
            _classe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classeestoque
    {
        get
        {
            PropriedadeAcessada("Classeestoque");
            return _classeestoque;
        }
        set
        {
            PropriedadeModificada("Classeestoque", value);
            _classeestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Classevenda
    {
        get
        {
            PropriedadeAcessada("Classevenda");
            return _classevenda;
        }
        set
        {
            PropriedadeModificada("Classevenda", value);
            _classevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Cnaedesoneracao
    {
        get
        {
            PropriedadeAcessada("Cnaedesoneracao");
            return _cnaedesoneracao;
        }
        set
        {
            PropriedadeModificada("Cnaedesoneracao", value);
            _cnaedesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 250, Precisao = 0)]
    public string Codauxiliarfav
    {
        get
        {
            PropriedadeAcessada("Codauxiliarfav");
            return _codauxiliarfav;
        }
        set
        {
            PropriedadeModificada("Codauxiliarfav", value);
            _codauxiliarfav = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codcaracprod
    {
        get
        {
            PropriedadeAcessada("Codcaracprod");
            return _codcaracprod;
        }
        set
        {
            PropriedadeModificada("Codcaracprod", value);
            _codcaracprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcomprador
    {
        get
        {
            PropriedadeAcessada("Codcomprador");
            return _codcomprador;
        }
        set
        {
            PropriedadeModificada("Codcomprador", value);
            _codcomprador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Coddispestrutura
    {
        get
        {
            PropriedadeAcessada("Coddispestrutura");
            return _coddispestrutura;
        }
        set
        {
            PropriedadeModificada("Coddispestrutura", value);
            _coddispestrutura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codexcecaopiscofins
    {
        get
        {
            PropriedadeAcessada("Codexcecaopiscofins");
            return _codexcecaopiscofins;
        }
        set
        {
            PropriedadeModificada("Codexcecaopiscofins", value);
            _codexcecaopiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfigura
    {
        get
        {
            PropriedadeAcessada("Codfigura");
            return _codfigura;
        }
        set
        {
            PropriedadeModificada("Codfigura", value);
            _codfigura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada("Codfuncultalter");
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada("Codfuncultalter", value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codprodantuticad
    {
        get
        {
            PropriedadeAcessada("Codprodantuticad");
            return _codprodantuticad;
        }
        set
        {
            PropriedadeModificada("Codprodantuticad", value);
            _codprodantuticad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrotinaultaltcom
    {
        get
        {
            PropriedadeAcessada("Codrotinaultaltcom");
            return _codrotinaultaltcom;
        }
        set
        {
            PropriedadeModificada("Codrotinaultaltcom", value);
            _codrotinaultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codrotinaultaltcomtab
    {
        get
        {
            PropriedadeAcessada("Codrotinaultaltcomtab");
            return _codrotinaultaltcomtab;
        }
        set
        {
            PropriedadeModificada("Codrotinaultaltcomtab", value);
            _codrotinaultaltcomtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codrotinaultalter
    {
        get
        {
            PropriedadeAcessada("Codrotinaultalter");
            return _codrotinaultalter;
        }
        set
        {
            PropriedadeModificada("Codrotinaultalter", value);
            _codrotinaultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofins
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofins");
            return _codsittribpiscofins;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofins", value);
            _codsittribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codsittribpiscofinsdev
    {
        get
        {
            PropriedadeAcessada("Codsittribpiscofinsdev");
            return _codsittribpiscofinsdev;
        }
        set
        {
            PropriedadeModificada("Codsittribpiscofinsdev", value);
            _codsittribpiscofinsdev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Codtipoestruturapul
    {
        get
        {
            PropriedadeAcessada("Codtipoestruturapul");
            return _codtipoestruturapul;
        }
        set
        {
            PropriedadeModificada("Codtipoestruturapul", value);
            _codtipoestruturapul = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Codtribsefaz
    {
        get
        {
            PropriedadeAcessada("Codtribsefaz");
            return _codtribsefaz;
        }
        set
        {
            PropriedadeModificada("Codtribsefaz", value);
            _codtribsefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuultaltcom
    {
        get
        {
            PropriedadeAcessada("Codusuultaltcom");
            return _codusuultaltcom;
        }
        set
        {
            PropriedadeModificada("Codusuultaltcom", value);
            _codusuultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusuultaltcomtab
    {
        get
        {
            PropriedadeAcessada("Codusuultaltcomtab");
            return _codusuultaltcomtab;
        }
        set
        {
            PropriedadeModificada("Codusuultaltcomtab", value);
            _codusuultaltcomtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastguiacusto
    {
        get
        {
            PropriedadeAcessada("Considerastguiacusto");
            return _considerastguiacusto;
        }
        set
        {
            PropriedadeModificada("Considerastguiacusto", value);
            _considerastguiacusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastguiacustocont
    {
        get
        {
            PropriedadeAcessada("Considerastguiacustocont");
            return _considerastguiacustocont;
        }
        set
        {
            PropriedadeModificada("Considerastguiacustocont", value);
            _considerastguiacustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastnfcusto
    {
        get
        {
            PropriedadeAcessada("Considerastnfcusto");
            return _considerastnfcusto;
        }
        set
        {
            PropriedadeModificada("Considerastnfcusto", value);
            _considerastnfcusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Considerastnfcustocont
    {
        get
        {
            PropriedadeAcessada("Considerastnfcustocont");
            return _considerastnfcustocont;
        }
        set
        {
            PropriedadeModificada("Considerastnfcustocont", value);
            _considerastnfcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlanumserie
    {
        get
        {
            PropriedadeAcessada("Controlanumserie");
            return _controlanumserie;
        }
        set
        {
            PropriedadeModificada("Controlanumserie", value);
            _controlanumserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlarfci
    {
        get
        {
            PropriedadeAcessada("Controlarfci");
            return _controlarfci;
        }
        set
        {
            PropriedadeModificada("Controlarfci", value);
            _controlarfci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controledevalidade
    {
        get
        {
            PropriedadeAcessada("Controledevalidade");
            return _controledevalidade;
        }
        set
        {
            PropriedadeModificada("Controledevalidade", value);
            _controledevalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorep
    {
        get
        {
            PropriedadeAcessada("Custorep");
            return _custorep;
        }
        set
        {
            PropriedadeModificada("Custorep", value);
            _custorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorepant
    {
        get
        {
            PropriedadeAcessada("Custorepant");
            return _custorepant;
        }
        set
        {
            PropriedadeModificada("Custorepant", value);
            _custorepant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreptab
    {
        get
        {
            PropriedadeAcessada("Custoreptab");
            return _custoreptab;
        }
        set
        {
            PropriedadeModificada("Custoreptab", value);
            _custoreptab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Digitarqtmaster
    {
        get
        {
            PropriedadeAcessada("Digitarqtmaster");
            return _digitarqtmaster;
        }
        set
        {
            PropriedadeModificada("Digitarqtmaster", value);
            _digitarqtmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Dscprodantuticad
    {
        get
        {
            PropriedadeAcessada("Dscprodantuticad");
            return _dscprodantuticad;
        }
        set
        {
            PropriedadeModificada("Dscprodantuticad", value);
            _dscprodantuticad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinuticodprodantuticad
    {
        get
        {
            PropriedadeAcessada("Dtfinuticodprodantuticad");
            return _dtfinuticodprodantuticad;
        }
        set
        {
            PropriedadeModificada("Dtfinuticodprodantuticad", value);
            _dtfinuticodprodantuticad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicodprodantuticad
    {
        get
        {
            PropriedadeAcessada("Dtinicodprodantuticad");
            return _dtinicodprodantuticad;
        }
        set
        {
            PropriedadeModificada("Dtinicodprodantuticad", value);
            _dtinicodprodantuticad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprimovnovcodprod
    {
        get
        {
            PropriedadeAcessada("Dtprimovnovcodprod");
            return _dtprimovnovcodprod;
        }
        set
        {
            PropriedadeModificada("Dtprimovnovcodprod", value);
            _dtprimovnovcodprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltcom
    {
        get
        {
            PropriedadeAcessada("Dtultaltcom");
            return _dtultaltcom;
        }
        set
        {
            PropriedadeModificada("Dtultaltcom", value);
            _dtultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultatupcompra
    {
        get
        {
            PropriedadeAcessada("Dtultatupcompra");
            return _dtultatupcompra;
        }
        set
        {
            PropriedadeModificada("Dtultatupcompra", value);
            _dtultatupcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvigenciapolitica
    {
        get
        {
            PropriedadeAcessada("Dtvigenciapolitica");
            return _dtvigenciapolitica;
        }
        set
        {
            PropriedadeModificada("Dtvigenciapolitica", value);
            _dtvigenciapolitica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Emitiretqent
    {
        get
        {
            PropriedadeAcessada("Emitiretqent");
            return _emitiretqent;
        }
        set
        {
            PropriedadeModificada("Emitiretqent", value);
            _emitiretqent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviarforcavendas
    {
        get
        {
            PropriedadeAcessada("Enviarforcavendas");
            return _enviarforcavendas;
        }
        set
        {
            PropriedadeModificada("Enviarforcavendas", value);
            _enviarforcavendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Estoqueideal
    {
        get
        {
            PropriedadeAcessada("Estoqueideal");
            return _estoqueideal;
        }
        set
        {
            PropriedadeModificada("Estoqueideal", value);
            _estoqueideal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Estoquemax
    {
        get
        {
            PropriedadeAcessada("Estoquemax");
            return _estoquemax;
        }
        set
        {
            PropriedadeModificada("Estoquemax", value);
            _estoquemax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Estoquemin
    {
        get
        {
            PropriedadeAcessada("Estoquemin");
            return _estoquemin;
        }
        set
        {
            PropriedadeModificada("Estoquemin", value);
            _estoquemin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estoqueporserie
    {
        get
        {
            PropriedadeAcessada("Estoqueporserie");
            return _estoqueporserie;
        }
        set
        {
            PropriedadeModificada("Estoqueporserie", value);
            _estoqueporserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Filialgestaowms
    {
        get
        {
            PropriedadeAcessada("Filialgestaowms");
            return _filialgestaowms;
        }
        set
        {
            PropriedadeModificada("Filialgestaowms", value);
            _filialgestaowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Foralinha
    {
        get
        {
            PropriedadeAcessada("Foralinha");
            return _foralinha;
        }
        set
        {
            PropriedadeModificada("Foralinha", value);
            _foralinha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fracionado
    {
        get
        {
            PropriedadeAcessada("Fracionado");
            return _fracionado;
        }
        set
        {
            PropriedadeModificada("Fracionado", value);
            _fracionado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Gerabasepiscofinssemaliq
    {
        get
        {
            PropriedadeAcessada("Gerabasepiscofinssemaliq");
            return _gerabasepiscofinssemaliq;
        }
        set
        {
            PropriedadeModificada("Gerabasepiscofinssemaliq", value);
            _gerabasepiscofinssemaliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscal
    {
        get
        {
            PropriedadeAcessada("Geraicmslivrofiscal");
            return _geraicmslivrofiscal;
        }
        set
        {
            PropriedadeModificada("Geraicmslivrofiscal", value);
            _geraicmslivrofiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscaldevfornec
    {
        get
        {
            PropriedadeAcessada("Geraicmslivrofiscaldevfornec");
            return _geraicmslivrofiscaldevfornec;
        }
        set
        {
            PropriedadeModificada("Geraicmslivrofiscaldevfornec", value);
            _geraicmslivrofiscaldevfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geraicmslivrofiscalent
    {
        get
        {
            PropriedadeAcessada("Geraicmslivrofiscalent");
            return _geraicmslivrofiscalent;
        }
        set
        {
            PropriedadeModificada("Geraicmslivrofiscalent", value);
            _geraicmslivrofiscalent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Icmsdiferido
    {
        get
        {
            PropriedadeAcessada("Icmsdiferido");
            return _icmsdiferido;
        }
        set
        {
            PropriedadeModificada("Icmsdiferido", value);
            _icmsdiferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Lastropal
    {
        get
        {
            PropriedadeAcessada("Lastropal");
            return _lastropal;
        }
        set
        {
            PropriedadeModificada("Lastropal", value);
            _lastropal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Multiplo
    {
        get
        {
            PropriedadeAcessada("Multiplo");
            return _multiplo;
        }
        set
        {
            PropriedadeModificada("Multiplo", value);
            _multiplo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Multiplocompras
    {
        get
        {
            PropriedadeAcessada("Multiplocompras");
            return _multiplocompras;
        }
        set
        {
            PropriedadeModificada("Multiplocompras", value);
            _multiplocompras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Nivelmaximoarm
    {
        get
        {
            PropriedadeAcessada("Nivelmaximoarm");
            return _nivelmaximoarm;
        }
        set
        {
            PropriedadeModificada("Nivelmaximoarm", value);
            _nivelmaximoarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Nivelminimoarm
    {
        get
        {
            PropriedadeAcessada("Nivelminimoarm");
            return _nivelminimoarm;
        }
        set
        {
            PropriedadeModificada("Nivelminimoarm", value);
            _nivelminimoarm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Normapalete
    {
        get
        {
            PropriedadeAcessada("Normapalete");
            return _normapalete;
        }
        set
        {
            PropriedadeModificada("Normapalete", value);
            _normapalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Novacaixaflowrack
    {
        get
        {
            PropriedadeAcessada("Novacaixaflowrack");
            return _novacaixaflowrack;
        }
        set
        {
            PropriedadeModificada("Novacaixaflowrack", value);
            _novacaixaflowrack = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numerosseriecontrolados
    {
        get
        {
            PropriedadeAcessada("Numerosseriecontrolados");
            return _numerosseriecontrolados;
        }
        set
        {
            PropriedadeModificada("Numerosseriecontrolados", value);
            _numerosseriecontrolados = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origmerctrib
    {
        get
        {
            PropriedadeAcessada("Origmerctrib");
            return _origmerctrib;
        }
        set
        {
            PropriedadeModificada("Origmerctrib", value);
            _origmerctrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pckrotativo
    {
        get
        {
            PropriedadeAcessada("Pckrotativo");
            return _pckrotativo;
        }
        set
        {
            PropriedadeModificada("Pckrotativo", value);
            _pckrotativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomext1
    {
        get
        {
            PropriedadeAcessada("Pcomext1");
            return _pcomext1;
        }
        set
        {
            PropriedadeModificada("Pcomext1", value);
            _pcomext1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomint1
    {
        get
        {
            PropriedadeAcessada("Pcomint1");
            return _pcomint1;
        }
        set
        {
            PropriedadeModificada("Pcomint1", value);
            _pcomint1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep1
    {
        get
        {
            PropriedadeAcessada("Pcomrep1");
            return _pcomrep1;
        }
        set
        {
            PropriedadeModificada("Pcomrep1", value);
            _pcomrep1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Percacres
    {
        get
        {
            PropriedadeAcessada("Percacres");
            return _percacres;
        }
        set
        {
            PropriedadeModificada("Percacres", value);
            _percacres = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percaliqvigext
    {
        get
        {
            PropriedadeAcessada("Percaliqvigext");
            return _percaliqvigext;
        }
        set
        {
            PropriedadeModificada("Percaliqvigext", value);
            _percaliqvigext = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percaliqvigint
    {
        get
        {
            PropriedadeAcessada("Percaliqvigint");
            return _percaliqvigint;
        }
        set
        {
            PropriedadeModificada("Percaliqvigint", value);
            _percaliqvigint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percaltercustoent
    {
        get
        {
            PropriedadeAcessada("Percaltercustoent");
            return _percaltercustoent;
        }
        set
        {
            PropriedadeModificada("Percaltercustoent", value);
            _percaltercustoent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percarredonda
    {
        get
        {
            PropriedadeAcessada("Percarredonda");
            return _percarredonda;
        }
        set
        {
            PropriedadeModificada("Percarredonda", value);
            _percarredonda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
    public decimal? Percbon
    {
        get
        {
            PropriedadeAcessada("Percbon");
            return _percbon;
        }
        set
        {
            PropriedadeModificada("Percbon", value);
            _percbon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbonific
    {
        get
        {
            PropriedadeAcessada("Percbonific");
            return _percbonific;
        }
        set
        {
            PropriedadeModificada("Percbonific", value);
            _percbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbonifictab
    {
        get
        {
            PropriedadeAcessada("Percbonifictab");
            return _percbonifictab;
        }
        set
        {
            PropriedadeModificada("Percbonifictab", value);
            _percbonifictab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbonoutras
    {
        get
        {
            PropriedadeAcessada("Percbonoutras");
            return _percbonoutras;
        }
        set
        {
            PropriedadeModificada("Percbonoutras", value);
            _percbonoutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percbonoutrastab
    {
        get
        {
            PropriedadeAcessada("Percbonoutrastab");
            return _percbonoutrastab;
        }
        set
        {
            PropriedadeModificada("Percbonoutrastab", value);
            _percbonoutrastab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
    public decimal? Percbontab
    {
        get
        {
            PropriedadeAcessada("Percbontab");
            return _percbontab;
        }
        set
        {
            PropriedadeModificada("Percbontab", value);
            _percbontab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc1
    {
        get
        {
            PropriedadeAcessada("Percdesc1");
            return _percdesc1;
        }
        set
        {
            PropriedadeModificada("Percdesc1", value);
            _percdesc1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc10
    {
        get
        {
            PropriedadeAcessada("Percdesc10");
            return _percdesc10;
        }
        set
        {
            PropriedadeModificada("Percdesc10", value);
            _percdesc10 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc10tab
    {
        get
        {
            PropriedadeAcessada("Percdesc10tab");
            return _percdesc10tab;
        }
        set
        {
            PropriedadeModificada("Percdesc10tab", value);
            _percdesc10tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc1tab
    {
        get
        {
            PropriedadeAcessada("Percdesc1tab");
            return _percdesc1tab;
        }
        set
        {
            PropriedadeModificada("Percdesc1tab", value);
            _percdesc1tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc2
    {
        get
        {
            PropriedadeAcessada("Percdesc2");
            return _percdesc2;
        }
        set
        {
            PropriedadeModificada("Percdesc2", value);
            _percdesc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc2tab
    {
        get
        {
            PropriedadeAcessada("Percdesc2tab");
            return _percdesc2tab;
        }
        set
        {
            PropriedadeModificada("Percdesc2tab", value);
            _percdesc2tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc3
    {
        get
        {
            PropriedadeAcessada("Percdesc3");
            return _percdesc3;
        }
        set
        {
            PropriedadeModificada("Percdesc3", value);
            _percdesc3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc3tab
    {
        get
        {
            PropriedadeAcessada("Percdesc3tab");
            return _percdesc3tab;
        }
        set
        {
            PropriedadeModificada("Percdesc3tab", value);
            _percdesc3tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc4
    {
        get
        {
            PropriedadeAcessada("Percdesc4");
            return _percdesc4;
        }
        set
        {
            PropriedadeModificada("Percdesc4", value);
            _percdesc4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc4tab
    {
        get
        {
            PropriedadeAcessada("Percdesc4tab");
            return _percdesc4tab;
        }
        set
        {
            PropriedadeModificada("Percdesc4tab", value);
            _percdesc4tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc5
    {
        get
        {
            PropriedadeAcessada("Percdesc5");
            return _percdesc5;
        }
        set
        {
            PropriedadeModificada("Percdesc5", value);
            _percdesc5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc5tab
    {
        get
        {
            PropriedadeAcessada("Percdesc5tab");
            return _percdesc5tab;
        }
        set
        {
            PropriedadeModificada("Percdesc5tab", value);
            _percdesc5tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc6
    {
        get
        {
            PropriedadeAcessada("Percdesc6");
            return _percdesc6;
        }
        set
        {
            PropriedadeModificada("Percdesc6", value);
            _percdesc6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc6tab
    {
        get
        {
            PropriedadeAcessada("Percdesc6tab");
            return _percdesc6tab;
        }
        set
        {
            PropriedadeModificada("Percdesc6tab", value);
            _percdesc6tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc7
    {
        get
        {
            PropriedadeAcessada("Percdesc7");
            return _percdesc7;
        }
        set
        {
            PropriedadeModificada("Percdesc7", value);
            _percdesc7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc7tab
    {
        get
        {
            PropriedadeAcessada("Percdesc7tab");
            return _percdesc7tab;
        }
        set
        {
            PropriedadeModificada("Percdesc7tab", value);
            _percdesc7tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc8
    {
        get
        {
            PropriedadeAcessada("Percdesc8");
            return _percdesc8;
        }
        set
        {
            PropriedadeModificada("Percdesc8", value);
            _percdesc8 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc8tab
    {
        get
        {
            PropriedadeAcessada("Percdesc8tab");
            return _percdesc8tab;
        }
        set
        {
            PropriedadeModificada("Percdesc8tab", value);
            _percdesc8tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc9
    {
        get
        {
            PropriedadeAcessada("Percdesc9");
            return _percdesc9;
        }
        set
        {
            PropriedadeModificada("Percdesc9", value);
            _percdesc9 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percdesc9tab
    {
        get
        {
            PropriedadeAcessada("Percdesc9tab");
            return _percdesc9tab;
        }
        set
        {
            PropriedadeModificada("Percdesc9tab", value);
            _percdesc9tab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percdesoneracao
    {
        get
        {
            PropriedadeAcessada("Percdesoneracao");
            return _percdesoneracao;
        }
        set
        {
            PropriedadeModificada("Percdesoneracao", value);
            _percdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Percmargemmin
    {
        get
        {
            PropriedadeAcessada("Percmargemmin");
            return _percmargemmin;
        }
        set
        {
            PropriedadeModificada("Percmargemmin", value);
            _percmargemmin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percmaxvarpvenda
    {
        get
        {
            PropriedadeAcessada("Percmaxvarpvenda");
            return _percmaxvarpvenda;
        }
        set
        {
            PropriedadeModificada("Percmaxvarpvenda", value);
            _percmaxvarpvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percofins
    {
        get
        {
            PropriedadeAcessada("Percofins");
            return _percofins;
        }
        set
        {
            PropriedadeModificada("Percofins", value);
            _percofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percredpmc
    {
        get
        {
            PropriedadeAcessada("Percredpmc");
            return _percredpmc;
        }
        set
        {
            PropriedadeModificada("Percredpmc", value);
            _percredpmc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Perctoleranciacorte
    {
        get
        {
            PropriedadeAcessada("Perctoleranciacorte");
            return _perctoleranciacorte;
        }
        set
        {
            PropriedadeModificada("Perctoleranciacorte", value);
            _perctoleranciacorte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciadepuratransf
    {
        get
        {
            PropriedadeAcessada("Perctoleranciadepuratransf");
            return _perctoleranciadepuratransf;
        }
        set
        {
            PropriedadeModificada("Perctoleranciadepuratransf", value);
            _perctoleranciadepuratransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perctoleranciaval
    {
        get
        {
            PropriedadeAcessada("Perctoleranciaval");
            return _perctoleranciaval;
        }
        set
        {
            PropriedadeModificada("Perctoleranciaval", value);
            _perctoleranciaval = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdescretencao
    {
        get
        {
            PropriedadeAcessada("Perdescretencao");
            return _perdescretencao;
        }
        set
        {
            PropriedadeModificada("Perdescretencao", value);
            _perdescretencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perpis
    {
        get
        {
            PropriedadeAcessada("Perpis");
            return _perpis;
        }
        set
        {
            PropriedadeModificada("Perpis", value);
            _perpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 6)]
    public decimal? Pesopalete
    {
        get
        {
            PropriedadeAcessada("Pesopalete");
            return _pesopalete;
        }
        set
        {
            PropriedadeModificada("Pesopalete", value);
            _pesopalete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Piscofinsretido
    {
        get
        {
            PropriedadeAcessada("Piscofinsretido");
            return _piscofinsretido;
        }
        set
        {
            PropriedadeModificada("Piscofinsretido", value);
            _piscofinsretido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoval
    {
        get
        {
            PropriedadeAcessada("Prazoval");
            return _prazoval;
        }
        set
        {
            PropriedadeModificada("Prazoval", value);
            _prazoval = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Precoutilizadonfe
    {
        get
        {
            PropriedadeAcessada("Precoutilizadonfe");
            return _precoutilizadonfe;
        }
        set
        {
            PropriedadeModificada("Precoutilizadonfe", value);
            _precoutilizadonfe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Proibidavenda
    {
        get
        {
            PropriedadeAcessada("Proibidavenda");
            return _proibidavenda;
        }
        set
        {
            PropriedadeModificada("Proibidavenda", value);
            _proibidavenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Protocoloicms1785
    {
        get
        {
            PropriedadeAcessada("Protocoloicms1785");
            return _protocoloicms1785;
        }
        set
        {
            PropriedadeModificada("Protocoloicms1785", value);
            _protocoloicms1785 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Ptabelafornec
    {
        get
        {
            PropriedadeAcessada("Ptabelafornec");
            return _ptabelafornec;
        }
        set
        {
            PropriedadeModificada("Ptabelafornec", value);
            _ptabelafornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtmaxpedvenda
    {
        get
        {
            PropriedadeAcessada("Qtmaxpedvenda");
            return _qtmaxpedvenda;
        }
        set
        {
            PropriedadeModificada("Qtmaxpedvenda", value);
            _qtmaxpedvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtminautoserv
    {
        get
        {
            PropriedadeAcessada("Qtminautoserv");
            return _qtminautoserv;
        }
        set
        {
            PropriedadeModificada("Qtminautoserv", value);
            _qtminautoserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtminimaatacado
    {
        get
        {
            PropriedadeAcessada("Qtminimaatacado");
            return _qtminimaatacado;
        }
        set
        {
            PropriedadeModificada("Qtminimaatacado", value);
            _qtminimaatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtminimaatacadof
    {
        get
        {
            PropriedadeAcessada("Qtminimaatacadof");
            return _qtminimaatacadof;
        }
        set
        {
            PropriedadeModificada("Qtminimaatacadof", value);
            _qtminimaatacadof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtminsugcompra
    {
        get
        {
            PropriedadeAcessada("Qtminsugcompra");
            return _qtminsugcompra;
        }
        set
        {
            PropriedadeModificada("Qtminsugcompra", value);
            _qtminsugcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtpulmaoregulador
    {
        get
        {
            PropriedadeAcessada("Qtpulmaoregulador");
            return _qtpulmaoregulador;
        }
        set
        {
            PropriedadeModificada("Qtpulmaoregulador", value);
            _qtpulmaoregulador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qttotpal
    {
        get
        {
            PropriedadeAcessada("Qttotpal");
            return _qttotpal;
        }
        set
        {
            PropriedadeModificada("Qttotpal", value);
            _qttotpal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Regimeespecial
    {
        get
        {
            PropriedadeAcessada("Regimeespecial");
            return _regimeespecial;
        }
        set
        {
            PropriedadeModificada("Regimeespecial", value);
            _regimeespecial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Restricaoblocado
    {
        get
        {
            PropriedadeAcessada("Restricaoblocado");
            return _restricaoblocado;
        }
        set
        {
            PropriedadeModificada("Restricaoblocado", value);
            _restricaoblocado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Revenda
    {
        get
        {
            PropriedadeAcessada("Revenda");
            return _revenda;
        }
        set
        {
            PropriedadeModificada("Revenda", value);
            _revenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Subclasse
    {
        get
        {
            PropriedadeAcessada("Subclasse");
            return _subclasse;
        }
        set
        {
            PropriedadeModificada("Subclasse", value);
            _subclasse = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sujdesoneracao
    {
        get
        {
            PropriedadeAcessada("Sujdesoneracao");
            return _sujdesoneracao;
        }
        set
        {
            PropriedadeModificada("Sujdesoneracao", value);
            _sujdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoarredunidmaster
    {
        get
        {
            PropriedadeAcessada("Tipoarredunidmaster");
            return _tipoarredunidmaster;
        }
        set
        {
            PropriedadeModificada("Tipoarredunidmaster", value);
            _tipoarredunidmaster = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Tipocarga
    {
        get
        {
            PropriedadeAcessada("Tipocarga");
            return _tipocarga;
        }
        set
        {
            PropriedadeModificada("Tipocarga", value);
            _tipocarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoestagenda
    {
        get
        {
            PropriedadeAcessada("Tipoestagenda");
            return _tipoestagenda;
        }
        set
        {
            PropriedadeModificada("Tipoestagenda", value);
            _tipoestagenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoestoquemaximo
    {
        get
        {
            PropriedadeAcessada("Tipoestoquemaximo");
            return _tipoestoquemaximo;
        }
        set
        {
            PropriedadeModificada("Tipoestoquemaximo", value);
            _tipoestoquemaximo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoestoqueminimo
    {
        get
        {
            PropriedadeAcessada("Tipoestoqueminimo");
            return _tipoestoqueminimo;
        }
        set
        {
            PropriedadeModificada("Tipoestoqueminimo", value);
            _tipoestoqueminimo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipopalpul
    {
        get
        {
            PropriedadeAcessada("Tipopalpul");
            return _tipopalpul;
        }
        set
        {
            PropriedadeModificada("Tipopalpul", value);
            _tipopalpul = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Tipoprod
    {
        get
        {
            PropriedadeAcessada("Tipoprod");
            return _tipoprod;
        }
        set
        {
            PropriedadeModificada("Tipoprod", value);
            _tipoprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tiposugestao
    {
        get
        {
            PropriedadeAcessada("Tiposugestao");
            return _tiposugestao;
        }
        set
        {
            PropriedadeModificada("Tiposugestao", value);
            _tiposugestao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipovariacao
    {
        get
        {
            PropriedadeAcessada("Tipovariacao");
            return _tipovariacao;
        }
        set
        {
            PropriedadeModificada("Tipovariacao", value);
            _tipovariacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usanumeroserie
    {
        get
        {
            PropriedadeAcessada("Usanumeroserie");
            return _usanumeroserie;
        }
        set
        {
            PropriedadeModificada("Usanumeroserie", value);
            _usanumeroserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapiscofinslit
    {
        get
        {
            PropriedadeAcessada("Usapiscofinslit");
            return _usapiscofinslit;
        }
        set
        {
            PropriedadeModificada("Usapiscofinslit", value);
            _usapiscofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapmcbasest
    {
        get
        {
            PropriedadeAcessada("Usapmcbasest");
            return _usapmcbasest;
        }
        set
        {
            PropriedadeModificada("Usapmcbasest", value);
            _usapmcbasest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usapulmaoregulador
    {
        get
        {
            PropriedadeAcessada("Usapulmaoregulador");
            return _usapulmaoregulador;
        }
        set
        {
            PropriedadeModificada("Usapulmaoregulador", value);
            _usapulmaoregulador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Usarqtosun
    {
        get
        {
            PropriedadeAcessada("Usarqtosun");
            return _usarqtosun;
        }
        set
        {
            PropriedadeModificada("Usarqtosun", value);
            _usarqtosun = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizaqtdesupmultipla
    {
        get
        {
            PropriedadeAcessada("Utilizaqtdesupmultipla");
            return _utilizaqtdesupmultipla;
        }
        set
        {
            PropriedadeModificada("Utilizaqtdesupmultipla", value);
            _utilizaqtdesupmultipla = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validacapacidadepicking
    {
        get
        {
            PropriedadeAcessada("Validacapacidadepicking");
            return _validacapacidadepicking;
        }
        set
        {
            PropriedadeModificada("Validacapacidadepicking", value);
            _validacapacidadepicking = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Verbadinporperc
    {
        get
        {
            PropriedadeAcessada("Verbadinporperc");
            return _verbadinporperc;
        }
        set
        {
            PropriedadeModificada("Verbadinporperc", value);
            _verbadinporperc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbonifictab
    {
        get
        {
            PropriedadeAcessada("Vlbonifictab");
            return _vlbonifictab;
        }
        set
        {
            PropriedadeModificada("Vlbonifictab", value);
            _vlbonifictab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofinslit
    {
        get
        {
            PropriedadeAcessada("Vlcofinslit");
            return _vlcofinslit;
        }
        set
        {
            PropriedadeModificada("Vlcofinslit", value);
            _vlcofinslit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautapiscofins
    {
        get
        {
            PropriedadeAcessada("Vlpautapiscofins");
            return _vlpautapiscofins;
        }
        set
        {
            PropriedadeModificada("Vlpautapiscofins", value);
            _vlpautapiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRODFILIAL", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpislit
    {
        get
        {
            PropriedadeAcessada("Vlpislit");
            return _vlpislit;
        }
        set
        {
            PropriedadeModificada("Vlpislit", value);
            _vlpislit = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPRODFILIAL";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _abastepalete = AlterarTipo<string>(leitor["Abastepalete"]);
        _abastepaletecx = AlterarTipo<string>(leitor["Abastepaletecx"]);
        _aceitavendafracao = AlterarTipo<string>(leitor["Aceitavendafracao"]);
        _alturapal = AlterarTipo<decimal?>(leitor["Alturapal"]);
        _ativo = AlterarTipo<string>(leitor["Ativo"]);
        _atualizafilialgestaowms = AlterarTipo<string>(leitor["Atualizafilialgestaowms"]);
        _basepiscofinslit = AlterarTipo<decimal?>(leitor["Basepiscofinslit"]);
        _calccredipi = AlterarTipo<string>(leitor["Calccredipi"]);
        _calculaipi = AlterarTipo<string>(leitor["Calculaipi"]);
        _checarmultiplovendabnf = AlterarTipo<string>(leitor["Checarmultiplovendabnf"]);
        _classe = AlterarTipo<string>(leitor["Classe"]);
        _classeestoque = AlterarTipo<string>(leitor["Classeestoque"]);
        _classevenda = AlterarTipo<string>(leitor["Classevenda"]);
        _cnaedesoneracao = AlterarTipo<string>(leitor["Cnaedesoneracao"]);
        _codauxiliarfav = AlterarTipo<string>(leitor["Codauxiliarfav"]);
        _codcaracprod = AlterarTipo<decimal?>(leitor["Codcaracprod"]);
        _codcomprador = AlterarTipo<decimal?>(leitor["Codcomprador"]);
        _coddispestrutura = AlterarTipo<decimal?>(leitor["Coddispestrutura"]);
        _codexcecaopiscofins = AlterarTipo<decimal?>(leitor["Codexcecaopiscofins"]);
        _codfigura = AlterarTipo<decimal?>(leitor["Codfigura"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodantuticad = AlterarTipo<string>(leitor["Codprodantuticad"]);
        _codrotinaultaltcom = AlterarTipo<decimal?>(leitor["Codrotinaultaltcom"]);
        _codrotinaultaltcomtab = AlterarTipo<decimal?>(leitor["Codrotinaultaltcomtab"]);
        _codrotinaultalter = AlterarTipo<decimal?>(leitor["Codrotinaultalter"]);
        _codsittribpiscofins = AlterarTipo<decimal?>(leitor["Codsittribpiscofins"]);
        _codsittribpiscofinsdev = AlterarTipo<decimal?>(leitor["Codsittribpiscofinsdev"]);
        _codtipoestruturapul = AlterarTipo<decimal?>(leitor["Codtipoestruturapul"]);
        _codtribsefaz = AlterarTipo<string>(leitor["Codtribsefaz"]);
        _codusuultaltcom = AlterarTipo<decimal?>(leitor["Codusuultaltcom"]);
        _codusuultaltcomtab = AlterarTipo<decimal?>(leitor["Codusuultaltcomtab"]);
        _considerastguiacusto = AlterarTipo<string>(leitor["Considerastguiacusto"]);
        _considerastguiacustocont = AlterarTipo<string>(leitor["Considerastguiacustocont"]);
        _considerastnfcusto = AlterarTipo<string>(leitor["Considerastnfcusto"]);
        _considerastnfcustocont = AlterarTipo<string>(leitor["Considerastnfcustocont"]);
        _controlanumserie = AlterarTipo<string>(leitor["Controlanumserie"]);
        _controlarfci = AlterarTipo<string>(leitor["Controlarfci"]);
        _controledevalidade = AlterarTipo<string>(leitor["Controledevalidade"]);
        _custorep = AlterarTipo<decimal?>(leitor["Custorep"]);
        _custorepant = AlterarTipo<decimal?>(leitor["Custorepant"]);
        _custoreptab = AlterarTipo<decimal?>(leitor["Custoreptab"]);
        _digitarqtmaster = AlterarTipo<string>(leitor["Digitarqtmaster"]);
        _dscprodantuticad = AlterarTipo<string>(leitor["Dscprodantuticad"]);
        _dtfinuticodprodantuticad = AlterarTipo<DateTime?>(leitor["Dtfinuticodprodantuticad"]);
        _dtinicodprodantuticad = AlterarTipo<DateTime?>(leitor["Dtinicodprodantuticad"]);
        _dtprimovnovcodprod = AlterarTipo<DateTime?>(leitor["Dtprimovnovcodprod"]);
        _dtultaltcom = AlterarTipo<DateTime?>(leitor["Dtultaltcom"]);
        _dtultatupcompra = AlterarTipo<DateTime?>(leitor["Dtultatupcompra"]);
        _dtvigenciapolitica = AlterarTipo<DateTime?>(leitor["Dtvigenciapolitica"]);
        _emitiretqent = AlterarTipo<string>(leitor["Emitiretqent"]);
        _enviarforcavendas = AlterarTipo<string>(leitor["Enviarforcavendas"]);
        _estoqueideal = AlterarTipo<decimal?>(leitor["Estoqueideal"]);
        _estoquemax = AlterarTipo<decimal?>(leitor["Estoquemax"]);
        _estoquemin = AlterarTipo<decimal?>(leitor["Estoquemin"]);
        _estoqueporserie = AlterarTipo<string>(leitor["Estoqueporserie"]);
        _filialgestaowms = AlterarTipo<string>(leitor["Filialgestaowms"]);
        _foralinha = AlterarTipo<string>(leitor["Foralinha"]);
        _fracionado = AlterarTipo<string>(leitor["Fracionado"]);
        _gerabasepiscofinssemaliq = AlterarTipo<string>(leitor["Gerabasepiscofinssemaliq"]);
        _geraicmslivrofiscal = AlterarTipo<string>(leitor["Geraicmslivrofiscal"]);
        _geraicmslivrofiscaldevfornec = AlterarTipo<string>(leitor["Geraicmslivrofiscaldevfornec"]);
        _geraicmslivrofiscalent = AlterarTipo<string>(leitor["Geraicmslivrofiscalent"]);
        _icmsdiferido = AlterarTipo<string>(leitor["Icmsdiferido"]);
        _lastropal = AlterarTipo<decimal?>(leitor["Lastropal"]);
        _multiplo = AlterarTipo<decimal?>(leitor["Multiplo"]);
        _multiplocompras = AlterarTipo<decimal?>(leitor["Multiplocompras"]);
        _nivelmaximoarm = AlterarTipo<decimal?>(leitor["Nivelmaximoarm"]);
        _nivelminimoarm = AlterarTipo<decimal?>(leitor["Nivelminimoarm"]);
        _normapalete = AlterarTipo<string>(leitor["Normapalete"]);
        _novacaixaflowrack = AlterarTipo<string>(leitor["Novacaixaflowrack"]);
        _numerosseriecontrolados = AlterarTipo<decimal?>(leitor["Numerosseriecontrolados"]);
        _origmerctrib = AlterarTipo<string>(leitor["Origmerctrib"]);
        _pckrotativo = AlterarTipo<string>(leitor["Pckrotativo"]);
        _pcomext1 = AlterarTipo<decimal?>(leitor["Pcomext1"]);
        _pcomint1 = AlterarTipo<decimal?>(leitor["Pcomint1"]);
        _pcomrep1 = AlterarTipo<decimal?>(leitor["Pcomrep1"]);
        _percacres = AlterarTipo<decimal?>(leitor["Percacres"]);
        _percaliqvigext = AlterarTipo<decimal?>(leitor["Percaliqvigext"]);
        _percaliqvigint = AlterarTipo<decimal?>(leitor["Percaliqvigint"]);
        _percaltercustoent = AlterarTipo<decimal?>(leitor["Percaltercustoent"]);
        _percarredonda = AlterarTipo<decimal?>(leitor["Percarredonda"]);
        _percbon = AlterarTipo<decimal?>(leitor["Percbon"]);
        _percbonific = AlterarTipo<decimal?>(leitor["Percbonific"]);
        _percbonifictab = AlterarTipo<decimal?>(leitor["Percbonifictab"]);
        _percbonoutras = AlterarTipo<decimal?>(leitor["Percbonoutras"]);
        _percbonoutrastab = AlterarTipo<decimal?>(leitor["Percbonoutrastab"]);
        _percbontab = AlterarTipo<decimal?>(leitor["Percbontab"]);
        _percdesc = AlterarTipo<decimal?>(leitor["Percdesc"]);
        _percdesc1 = AlterarTipo<decimal?>(leitor["Percdesc1"]);
        _percdesc10 = AlterarTipo<decimal?>(leitor["Percdesc10"]);
        _percdesc10tab = AlterarTipo<decimal?>(leitor["Percdesc10tab"]);
        _percdesc1tab = AlterarTipo<decimal?>(leitor["Percdesc1tab"]);
        _percdesc2 = AlterarTipo<decimal?>(leitor["Percdesc2"]);
        _percdesc2tab = AlterarTipo<decimal?>(leitor["Percdesc2tab"]);
        _percdesc3 = AlterarTipo<decimal?>(leitor["Percdesc3"]);
        _percdesc3tab = AlterarTipo<decimal?>(leitor["Percdesc3tab"]);
        _percdesc4 = AlterarTipo<decimal?>(leitor["Percdesc4"]);
        _percdesc4tab = AlterarTipo<decimal?>(leitor["Percdesc4tab"]);
        _percdesc5 = AlterarTipo<decimal?>(leitor["Percdesc5"]);
        _percdesc5tab = AlterarTipo<decimal?>(leitor["Percdesc5tab"]);
        _percdesc6 = AlterarTipo<decimal?>(leitor["Percdesc6"]);
        _percdesc6tab = AlterarTipo<decimal?>(leitor["Percdesc6tab"]);
        _percdesc7 = AlterarTipo<decimal?>(leitor["Percdesc7"]);
        _percdesc7tab = AlterarTipo<decimal?>(leitor["Percdesc7tab"]);
        _percdesc8 = AlterarTipo<decimal?>(leitor["Percdesc8"]);
        _percdesc8tab = AlterarTipo<decimal?>(leitor["Percdesc8tab"]);
        _percdesc9 = AlterarTipo<decimal?>(leitor["Percdesc9"]);
        _percdesc9tab = AlterarTipo<decimal?>(leitor["Percdesc9tab"]);
        _percdesoneracao = AlterarTipo<decimal?>(leitor["Percdesoneracao"]);
        _percmargemmin = AlterarTipo<decimal?>(leitor["Percmargemmin"]);
        _percmaxvarpvenda = AlterarTipo<decimal?>(leitor["Percmaxvarpvenda"]);
        _percofins = AlterarTipo<decimal?>(leitor["Percofins"]);
        _percredpmc = AlterarTipo<decimal?>(leitor["Percredpmc"]);
        _perctoleranciacorte = AlterarTipo<decimal?>(leitor["Perctoleranciacorte"]);
        _perctoleranciadepuratransf = AlterarTipo<decimal?>(leitor["Perctoleranciadepuratransf"]);
        _perctoleranciaval = AlterarTipo<decimal?>(leitor["Perctoleranciaval"]);
        _perdescretencao = AlterarTipo<decimal?>(leitor["Perdescretencao"]);
        _perpis = AlterarTipo<decimal?>(leitor["Perpis"]);
        _pesopalete = AlterarTipo<decimal?>(leitor["Pesopalete"]);
        _piscofinsretido = AlterarTipo<string>(leitor["Piscofinsretido"]);
        _prazoval = AlterarTipo<decimal?>(leitor["Prazoval"]);
        _precoutilizadonfe = AlterarTipo<string>(leitor["Precoutilizadonfe"]);
        _proibidavenda = AlterarTipo<string>(leitor["Proibidavenda"]);
        _protocoloicms1785 = AlterarTipo<string>(leitor["Protocoloicms1785"]);
        _ptabelafornec = AlterarTipo<decimal?>(leitor["Ptabelafornec"]);
        _qtmaxpedvenda = AlterarTipo<decimal?>(leitor["Qtmaxpedvenda"]);
        _qtminautoserv = AlterarTipo<decimal?>(leitor["Qtminautoserv"]);
        _qtminimaatacado = AlterarTipo<decimal?>(leitor["Qtminimaatacado"]);
        _qtminimaatacadof = AlterarTipo<decimal?>(leitor["Qtminimaatacadof"]);
        _qtminsugcompra = AlterarTipo<decimal?>(leitor["Qtminsugcompra"]);
        _qtpulmaoregulador = AlterarTipo<decimal?>(leitor["Qtpulmaoregulador"]);
        _qttotpal = AlterarTipo<decimal?>(leitor["Qttotpal"]);
        _regimeespecial = AlterarTipo<string>(leitor["Regimeespecial"]);
        _restricaoblocado = AlterarTipo<decimal?>(leitor["Restricaoblocado"]);
        _revenda = AlterarTipo<string>(leitor["Revenda"]);
        _subclasse = AlterarTipo<string>(leitor["Subclasse"]);
        _sujdesoneracao = AlterarTipo<string>(leitor["Sujdesoneracao"]);
        _tipoarredunidmaster = AlterarTipo<string>(leitor["Tipoarredunidmaster"]);
        _tipocarga = AlterarTipo<decimal?>(leitor["Tipocarga"]);
        _tipoestagenda = AlterarTipo<string>(leitor["Tipoestagenda"]);
        _tipoestoquemaximo = AlterarTipo<string>(leitor["Tipoestoquemaximo"]);
        _tipoestoqueminimo = AlterarTipo<string>(leitor["Tipoestoqueminimo"]);
        _tipopalpul = AlterarTipo<decimal?>(leitor["Tipopalpul"]);
        _tipoprod = AlterarTipo<decimal?>(leitor["Tipoprod"]);
        _tiposugestao = AlterarTipo<string>(leitor["Tiposugestao"]);
        _tipovariacao = AlterarTipo<string>(leitor["Tipovariacao"]);
        _usanumeroserie = AlterarTipo<string>(leitor["Usanumeroserie"]);
        _usapiscofinslit = AlterarTipo<string>(leitor["Usapiscofinslit"]);
        _usapmcbasest = AlterarTipo<string>(leitor["Usapmcbasest"]);
        _usapulmaoregulador = AlterarTipo<string>(leitor["Usapulmaoregulador"]);
        _usarqtosun = AlterarTipo<string>(leitor["Usarqtosun"]);
        _utilizaqtdesupmultipla = AlterarTipo<string>(leitor["Utilizaqtdesupmultipla"]);
        _validacapacidadepicking = AlterarTipo<string>(leitor["Validacapacidadepicking"]);
        _verbadinporperc = AlterarTipo<string>(leitor["Verbadinporperc"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlbonifictab = AlterarTipo<decimal?>(leitor["Vlbonifictab"]);
        _vlcofinslit = AlterarTipo<decimal?>(leitor["Vlcofinslit"]);
        _vlpautapiscofins = AlterarTipo<decimal?>(leitor["Vlpautapiscofins"]);
        _vlpislit = AlterarTipo<decimal?>(leitor["Vlpislit"]);
    }

}