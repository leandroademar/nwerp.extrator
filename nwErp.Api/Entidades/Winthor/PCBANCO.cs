[Serializable]
public class PCBANCO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";
    private int _codbanco;
    
    private static readonly string RO_NOME = "Nome";
    private string _nome;
    
    private static readonly string RO_NUMBANCO = "Numbanco";
    private int? _numbanco;
    
    private static readonly string RO_AGENCIA = "Agencia";
    private string? _agencia;
    
    private static readonly string RO_CONTA = "Conta";
    private string? _conta;
    
    private static readonly string RO_PROXNUMCH = "Proxnumch";
    private int? _proxnumch;
    
    private static readonly string RO_CODCONTABIL = "Codcontabil";
    private int? _codcontabil;
    
    private static readonly string RO_PROXNUMREMESSA = "Proxnumremessa";
    private int? _proxnumremessa;
    
    private static readonly string RO_TIPOCXBCO = "Tipocxbco";
    private string? _tipocxbco;
    
    private static readonly string RO_PROXNOSSONUMBCO = "Proxnossonumbco";
    private int? _proxnossonumbco;
    
    private static readonly string RO_NUMCARTEIRA = "Numcarteira";
    private string? _numcarteira;
    
    private static readonly string RO_NUMCONVENIO = "Numconvenio";
    private int? _numconvenio;
    
    private static readonly string RO_FLUXOCX = "Fluxocx";
    private string? _fluxocx;
    
    private static readonly string RO_CONTAPAGMAGNETICO = "Contapagmagnetico";
    private string? _contapagmagnetico;
    
    private static readonly string RO_CODFILIAL = "Codfilial";
    private string? _codfilial;
    
    private static readonly string RO_NUMCARTEIRA3 = "Numcarteira3";
    private string? _numcarteira3;
    
    private static readonly string RO_PROXNUMCUSTODIA = "Proxnumcustodia";
    private int? _proxnumcustodia;
    
    private static readonly string RO_FAIXAINI = "Faixaini";
    private int? _faixaini;
    
    private static readonly string RO_FAIXAFIM = "Faixafim";
    private int? _faixafim;
    
    private static readonly string RO_TIPOCOB = "Tipocob";
    private string? _tipocob;
    
    private static readonly string RO_VARIACAO = "Variacao";
    private int? _variacao;
    
    private static readonly string RO_NOMERTM = "Nomertm";
    private string? _nomertm;
    
    private static readonly string RO_AGENCIAENTREGA = "Agenciaentrega";
    private string? _agenciaentrega;
    
    private static readonly string RO_NUMCONVENIOCUSTODIA = "Numconveniocustodia";
    private int? _numconveniocustodia;
    
    private static readonly string RO_PROXNUMPAGTO = "Proxnumpagto";
    private int? _proxnumpagto;
    
    private static readonly string RO_NUMSEQCUSTODIA = "Numseqcustodia";
    private int? _numseqcustodia;
    
    private static readonly string RO_CODCLIENTENOBANCO = "Codclientenobanco";
    private string? _codclientenobanco;
    
    private static readonly string RO_CODCONTABILDNI = "Codcontabildni";
    private int? _codcontabildni;
    
    private static readonly string RO_CODCONTABILCOBS = "Codcontabilcobs";
    private int? _codcontabilcobs;
    
    private static readonly string RO_CODCONTABILCHDV = "Codcontabilchdv";
    private int? _codcontabilchdv;
    
    private static readonly string RO_GERARBOLETO = "Gerarboleto";
    private string? _gerarboleto;
    
    private static readonly string RO_AGENCIACORRESPONDENTE = "Agenciacorrespondente";
    private string? _agenciacorrespondente;
    
    private static readonly string RO_NUMCOLSVENDOR = "Numcolsvendor";
    private int? _numcolsvendor;
    
    private static readonly string RO_NUMDIASPROTESTO = "Numdiasprotesto";
    private string? _numdiasprotesto;
    
    private static readonly string RO_NOSSONUMBCOPREIMPR = "Nossonumbcopreimpr";
    private int? _nossonumbcopreimpr;
    
    private static readonly string RO_ANOREMESSA = "Anoremessa";
    private int? _anoremessa;
    
    private static readonly string RO_BAIXATITULONAOACERTADO = "Baixatitulonaoacertado";
    private string? _baixatitulonaoacertado;
    
    private static readonly string RO_BAIXAJUROSMENORCM = "Baixajurosmenorcm";
    private string? _baixajurosmenorcm;
    
    private static readonly string RO_NAOBAIXAJUROSMENORCM = "Naobaixajurosmenorcm";
    private string? _naobaixajurosmenorcm;
    
    private static readonly string RO_BAIXATITULOSDESCFINCM = "Baixatitulosdescfincm";
    private string? _baixatitulosdescfincm;
    
    private static readonly string RO_VLTARIFABANCARIA = "Vltarifabancaria";
    private decimal? _vltarifabancaria;
    
    private static readonly string RO_USATARIFABANCARIAPORBANCO = "Usatarifabancariaporbanco";
    private string? _usatarifabancariaporbanco;
    
    private static readonly string RO_CODCEDENTE = "Codcedente";
    private string? _codcedente;
    
    private static readonly string RO_NUMCODLAYOUTCUSTODIA = "Numcodlayoutcustodia";
    private int? _numcodlayoutcustodia;
    
    private static readonly string RO_CGCREMESSA = "Cgcremessa";
    private string? _cgcremessa;
    
    private static readonly string RO_PROXNOSSONUMBCOECF = "Proxnossonumbcoecf";
    private int? _proxnossonumbcoecf;
    
    private static readonly string RO_INCDUPJUROSDESD = "Incdupjurosdesd";
    private string? _incdupjurosdesd;
    
    private static readonly string RO_VALORGERAJUROS = "Valorgerajuros";
    private decimal? _valorgerajuros;
    
    private static readonly string RO_NOMEPREFREMESSA = "Nomeprefremessa";
    private string? _nomeprefremessa;
    
    private static readonly string RO_GERARCRECEBERCARTORIO = "Gerarcrecebercartorio";
    private string? _gerarcrecebercartorio;
    
    private static readonly string RO_QTHORASMAXFECHACX = "Qthorasmaxfechacx";
    private int? _qthorasmaxfechacx;
    
    private static readonly string RO_UTILIZAFECHAMENTOCAIXA = "Utilizafechamentocaixa";
    private string? _utilizafechamentocaixa;
    
    private static readonly string RO_PERCMULTA = "Percmulta";
    private decimal? _percmulta;
    
    private static readonly string RO_USABANCOSEC = "Usabancosec";
    private string? _usabancosec;
    
    private static readonly string RO_CODBANCOSEC = "Codbancosec";
    private int? _codbancosec;
    
    private static readonly string RO_ACEITAPGTOMENOR = "Aceitapgtomenor";
    private string? _aceitapgtomenor;
    
    private static readonly string RO_GERARCREDCLIPAGMAIOR = "Gerarcredclipagmaior";
    private string? _gerarcredclipagmaior;
    
    private static readonly string RO_BAIXARSEMINFORMARFILIAL = "Baixarseminformarfilial";
    private string? _baixarseminformarfilial;
    
    private static readonly string RO_ACEITADEPOSITOVERBAFORNEC = "Aceitadepositoverbafornec";
    private string? _aceitadepositoverbafornec;
    
    private static readonly string RO_POSICAO = "Posicao";
    private string? _posicao;
    
    private static readonly string RO_VAREJO = "Varejo";
    private string? _varejo;
    
    private static readonly string RO_CODFUNCCAIXA = "Codfunccaixa";
    private int? _codfunccaixa;
    
    private static readonly string RO_DTABERTURA = "Dtabertura";
    private DateTime? _dtabertura;
    
    private static readonly string RO_VALORMINENVIOPROT = "Valorminenvioprot";
    private decimal? _valorminenvioprot;
    
    private static readonly string RO_NUMCONVENIOCEF = "Numconveniocef";
    private string? _numconveniocef;
    
    private static readonly string RO_BLOQCREDCLIBAIXA = "Bloqcredclibaixa";
    private string? _bloqcredclibaixa;
    
    private static readonly string RO_CODCONTDESPBC = "Codcontdespbc";
    private int? _codcontdespbc;
    
    private static readonly string RO_CODLAYOUTCM = "Codlayoutcm";
    private int? _codlayoutcm;
    
    private static readonly string RO_CODBACEN = "Codbacen";
    private string? _codbacen;
    
    private static readonly string RO_GERARRECEITAPAGMAIOR = "Gerarreceitapagmaior";
    private string? _gerarreceitapagmaior;
    
    private static readonly string RO_DESCTARBANC = "Desctarbanc";
    private string? _desctarbanc;
    
    private static readonly string RO_BAIXATITCOMDIFVALORES = "Baixatitcomdifvalores";
    private string? _baixatitcomdifvalores;
    
    private static readonly string RO_VLRMAXBAIXATITPAGAR = "Vlrmaxbaixatitpagar";
    private decimal? _vlrmaxbaixatitpagar;
    
    private static readonly string RO_GERADOISDVBANCOSAFRACORRESP = "Geradoisdvbancosafracorresp";
    private string? _geradoisdvbancosafracorresp;
    
    private static readonly string RO_CODEVENTOINTFOLHADEB = "Codeventointfolhadeb";
    private string? _codeventointfolhadeb;
    
    private static readonly string RO_CODEVENTOINTFOLHACRED = "Codeventointfolhacred";
    private string? _codeventointfolhacred;
    
    private static readonly string RO_TIPOVALORPAGOBANRISUL = "Tipovalorpagobanrisul";
    private int? _tipovalorpagobanrisul;
    
    private static readonly string RO_GERAXMLNFE = "Geraxmlnfe";
    private string? _geraxmlnfe;
    
    private static readonly string RO_GERARCNAB444 = "Gerarcnab444";
    private string? _gerarcnab444;
    
    private static readonly string RO_PERCDESCONTODIA = "Percdescontodia";
    private decimal? _percdescontodia;
    
    private static readonly string RO_UTILIZABAIXACC = "Utilizabaixacc";
    private string? _utilizabaixacc;
    
    private static readonly string RO_NUMCONVENIOPAGTO = "Numconveniopagto";
    private string? _numconveniopagto;
    
    private static readonly string RO_BANCORETORNO = "Bancoretorno";
    private int? _bancoretorno;
    
    private static readonly string RO_NAOBAIXAAPOSVENCSEMVALORMULTA = "Naobaixaaposvencsemvalormulta";
    private string? _naobaixaaposvencsemvalormulta;
    
    private static readonly string RO_CODLAYOUTCPREM = "Codlayoutcprem";
    private int? _codlayoutcprem;
    
    private static readonly string RO_CODLAYOUTCPRET = "Codlayoutcpret";
    private int? _codlayoutcpret;
    
    private static readonly string RO_GERARNOSSONUMEROBASA7DIGITOS = "Gerarnossonumerobasa7digitos";
    private string? _gerarnossonumerobasa7digitos;
    
    private static readonly string RO_NUMDIASBAIXATITULO = "Numdiasbaixatitulo";
    private int? _numdiasbaixatitulo;
    
    private static readonly string RO_NOSSONUMBCO17DIGCOBCEFSIGCBREG = "Nossonumbco17digcobcefsigcbreg";
    private string? _nossonumbco17digcobcefsigcbreg;
    
    private static readonly string RO_SOMADESPVPAGO = "Somadespvpago";
    private string? _somadespvpago;
    
    private static readonly string RO_VALIDACODBANCOCM = "Validacodbancocm";
    private string? _validacodbancocm;
    
    private static readonly string RO_BAIXATITDESCONSIDERANDODESC = "Baixatitdesconsiderandodesc";
    private string? _baixatitdesconsiderandodesc;
    
    private static readonly string RO_VLRMAXIMODOC = "Vlrmaximodoc";
    private decimal? _vlrmaximodoc;
    
    private static readonly string RO_CODLAYOUTCODBARRA = "Codlayoutcodbarra";
    private int? _codlayoutcodbarra;
    
    private static readonly string RO_CODLAYOUTRETORNOCR = "Codlayoutretornocr";
    private int? _codlayoutretornocr;
    
    private static readonly string RO_CONSIDERADESPCOBBANC = "Consideradespcobbanc";
    private string? _consideradespcobbanc;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int Codbanco
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Nome
    {
        get
        {
            PropriedadeAcessada(RO_NOME);
            return _nome;
        }
        set
        {
            PropriedadeModificada(RO_NOME, value);
            _nome = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Numbanco
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCO);
            return _numbanco;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCO, value);
            _numbanco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Agencia
    {
        get
        {
            PropriedadeAcessada(RO_AGENCIA);
            return _agencia;
        }
        set
        {
            PropriedadeModificada(RO_AGENCIA, value);
            _agencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Conta
    {
        get
        {
            PropriedadeAcessada(RO_CONTA);
            return _conta;
        }
        set
        {
            PropriedadeModificada(RO_CONTA, value);
            _conta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Proxnumch
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCH);
            return _proxnumch;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCH, value);
            _proxnumch = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontabil
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABIL);
            return _codcontabil;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABIL, value);
            _codcontabil = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 7, Precisao = 0)]
    public int? Proxnumremessa
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMREMESSA);
            return _proxnumremessa;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMREMESSA, value);
            _proxnumremessa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipocxbco
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCXBCO);
            return _tipocxbco;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCXBCO, value);
            _tipocxbco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 15, Precisao = 0)]
    public int? Proxnossonumbco
    {
        get
        {
            PropriedadeAcessada(RO_PROXNOSSONUMBCO);
            return _proxnossonumbco;
        }
        set
        {
            PropriedadeModificada(RO_PROXNOSSONUMBCO, value);
            _proxnossonumbco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numcarteira
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARTEIRA);
            return _numcarteira;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARTEIRA, value);
            _numcarteira = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numconvenio
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONVENIO);
            return _numconvenio;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONVENIO, value);
            _numconvenio = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Fluxocx
    {
        get
        {
            PropriedadeAcessada(RO_FLUXOCX);
            return _fluxocx;
        }
        set
        {
            PropriedadeModificada(RO_FLUXOCX, value);
            _fluxocx = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Contapagmagnetico
    {
        get
        {
            PropriedadeAcessada(RO_CONTAPAGMAGNETICO);
            return _contapagmagnetico;
        }
        set
        {
            PropriedadeModificada(RO_CONTAPAGMAGNETICO, value);
            _contapagmagnetico = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfilial
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numcarteira3
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARTEIRA3);
            return _numcarteira3;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARTEIRA3, value);
            _numcarteira3 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Proxnumcustodia
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMCUSTODIA);
            return _proxnumcustodia;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMCUSTODIA, value);
            _proxnumcustodia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 15, Precisao = 0)]
    public int? Faixaini
    {
        get
        {
            PropriedadeAcessada(RO_FAIXAINI);
            return _faixaini;
        }
        set
        {
            PropriedadeModificada(RO_FAIXAINI, value);
            _faixaini = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 15, Precisao = 0)]
    public int? Faixafim
    {
        get
        {
            PropriedadeAcessada(RO_FAIXAFIM);
            return _faixafim;
        }
        set
        {
            PropriedadeModificada(RO_FAIXAFIM, value);
            _faixafim = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipocob
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCOB);
            return _tipocob;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCOB, value);
            _tipocob = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Variacao
    {
        get
        {
            PropriedadeAcessada(RO_VARIACAO);
            return _variacao;
        }
        set
        {
            PropriedadeModificada(RO_VARIACAO, value);
            _variacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Nomertm
    {
        get
        {
            PropriedadeAcessada(RO_NOMERTM);
            return _nomertm;
        }
        set
        {
            PropriedadeModificada(RO_NOMERTM, value);
            _nomertm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Agenciaentrega
    {
        get
        {
            PropriedadeAcessada(RO_AGENCIAENTREGA);
            return _agenciaentrega;
        }
        set
        {
            PropriedadeModificada(RO_AGENCIAENTREGA, value);
            _agenciaentrega = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numconveniocustodia
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONVENIOCUSTODIA);
            return _numconveniocustodia;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONVENIOCUSTODIA, value);
            _numconveniocustodia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Proxnumpagto
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPAGTO);
            return _proxnumpagto;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPAGTO, value);
            _proxnumpagto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 5, Precisao = 0)]
    public int? Numseqcustodia
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQCUSTODIA);
            return _numseqcustodia;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQCUSTODIA, value);
            _numseqcustodia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codclientenobanco
    {
        get
        {
            PropriedadeAcessada(RO_CODCLIENTENOBANCO);
            return _codclientenobanco;
        }
        set
        {
            PropriedadeModificada(RO_CODCLIENTENOBANCO, value);
            _codclientenobanco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontabildni
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABILDNI);
            return _codcontabildni;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABILDNI, value);
            _codcontabildni = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontabilcobs
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABILCOBS);
            return _codcontabilcobs;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABILCOBS, value);
            _codcontabilcobs = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontabilchdv
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTABILCHDV);
            return _codcontabilchdv;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTABILCHDV, value);
            _codcontabilchdv = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarboleto
    {
        get
        {
            PropriedadeAcessada(RO_GERARBOLETO);
            return _gerarboleto;
        }
        set
        {
            PropriedadeModificada(RO_GERARBOLETO, value);
            _gerarboleto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Agenciacorrespondente
    {
        get
        {
            PropriedadeAcessada(RO_AGENCIACORRESPONDENTE);
            return _agenciacorrespondente;
        }
        set
        {
            PropriedadeModificada(RO_AGENCIACORRESPONDENTE, value);
            _agenciacorrespondente = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Numcolsvendor
    {
        get
        {
            PropriedadeAcessada(RO_NUMCOLSVENDOR);
            return _numcolsvendor;
        }
        set
        {
            PropriedadeModificada(RO_NUMCOLSVENDOR, value);
            _numcolsvendor = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numdiasprotesto
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASPROTESTO);
            return _numdiasprotesto;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASPROTESTO, value);
            _numdiasprotesto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 30, Precisao = 0)]
    public int? Nossonumbcopreimpr
    {
        get
        {
            PropriedadeAcessada(RO_NOSSONUMBCOPREIMPR);
            return _nossonumbcopreimpr;
        }
        set
        {
            PropriedadeModificada(RO_NOSSONUMBCOPREIMPR, value);
            _nossonumbcopreimpr = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Anoremessa
    {
        get
        {
            PropriedadeAcessada(RO_ANOREMESSA);
            return _anoremessa;
        }
        set
        {
            PropriedadeModificada(RO_ANOREMESSA, value);
            _anoremessa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixatitulonaoacertado
    {
        get
        {
            PropriedadeAcessada(RO_BAIXATITULONAOACERTADO);
            return _baixatitulonaoacertado;
        }
        set
        {
            PropriedadeModificada(RO_BAIXATITULONAOACERTADO, value);
            _baixatitulonaoacertado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixajurosmenorcm
    {
        get
        {
            PropriedadeAcessada(RO_BAIXAJUROSMENORCM);
            return _baixajurosmenorcm;
        }
        set
        {
            PropriedadeModificada(RO_BAIXAJUROSMENORCM, value);
            _baixajurosmenorcm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Naobaixajurosmenorcm
    {
        get
        {
            PropriedadeAcessada(RO_NAOBAIXAJUROSMENORCM);
            return _naobaixajurosmenorcm;
        }
        set
        {
            PropriedadeModificada(RO_NAOBAIXAJUROSMENORCM, value);
            _naobaixajurosmenorcm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixatitulosdescfincm
    {
        get
        {
            PropriedadeAcessada(RO_BAIXATITULOSDESCFINCM);
            return _baixatitulosdescfincm;
        }
        set
        {
            PropriedadeModificada(RO_BAIXATITULOSDESCFINCM, value);
            _baixatitulosdescfincm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vltarifabancaria
    {
        get
        {
            PropriedadeAcessada(RO_VLTARIFABANCARIA);
            return _vltarifabancaria;
        }
        set
        {
            PropriedadeModificada(RO_VLTARIFABANCARIA, value);
            _vltarifabancaria = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usatarifabancariaporbanco
    {
        get
        {
            PropriedadeAcessada(RO_USATARIFABANCARIAPORBANCO);
            return _usatarifabancariaporbanco;
        }
        set
        {
            PropriedadeModificada(RO_USATARIFABANCARIAPORBANCO, value);
            _usatarifabancariaporbanco = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcedente
    {
        get
        {
            PropriedadeAcessada(RO_CODCEDENTE);
            return _codcedente;
        }
        set
        {
            PropriedadeModificada(RO_CODCEDENTE, value);
            _codcedente = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 5, Precisao = 0)]
    public int? Numcodlayoutcustodia
    {
        get
        {
            PropriedadeAcessada(RO_NUMCODLAYOUTCUSTODIA);
            return _numcodlayoutcustodia;
        }
        set
        {
            PropriedadeModificada(RO_NUMCODLAYOUTCUSTODIA, value);
            _numcodlayoutcustodia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Cgcremessa
    {
        get
        {
            PropriedadeAcessada(RO_CGCREMESSA);
            return _cgcremessa;
        }
        set
        {
            PropriedadeModificada(RO_CGCREMESSA, value);
            _cgcremessa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Proxnossonumbcoecf
    {
        get
        {
            PropriedadeAcessada(RO_PROXNOSSONUMBCOECF);
            return _proxnossonumbcoecf;
        }
        set
        {
            PropriedadeModificada(RO_PROXNOSSONUMBCOECF, value);
            _proxnossonumbcoecf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Incdupjurosdesd
    {
        get
        {
            PropriedadeAcessada(RO_INCDUPJUROSDESD);
            return _incdupjurosdesd;
        }
        set
        {
            PropriedadeModificada(RO_INCDUPJUROSDESD, value);
            _incdupjurosdesd = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Valorgerajuros
    {
        get
        {
            PropriedadeAcessada(RO_VALORGERAJUROS);
            return _valorgerajuros;
        }
        set
        {
            PropriedadeModificada(RO_VALORGERAJUROS, value);
            _valorgerajuros = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Nomeprefremessa
    {
        get
        {
            PropriedadeAcessada(RO_NOMEPREFREMESSA);
            return _nomeprefremessa;
        }
        set
        {
            PropriedadeModificada(RO_NOMEPREFREMESSA, value);
            _nomeprefremessa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarcrecebercartorio
    {
        get
        {
            PropriedadeAcessada(RO_GERARCRECEBERCARTORIO);
            return _gerarcrecebercartorio;
        }
        set
        {
            PropriedadeModificada(RO_GERARCRECEBERCARTORIO, value);
            _gerarcrecebercartorio = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Qthorasmaxfechacx
    {
        get
        {
            PropriedadeAcessada(RO_QTHORASMAXFECHACX);
            return _qthorasmaxfechacx;
        }
        set
        {
            PropriedadeModificada(RO_QTHORASMAXFECHACX, value);
            _qthorasmaxfechacx = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizafechamentocaixa
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZAFECHAMENTOCAIXA);
            return _utilizafechamentocaixa;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZAFECHAMENTOCAIXA, value);
            _utilizafechamentocaixa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percmulta
    {
        get
        {
            PropriedadeAcessada(RO_PERCMULTA);
            return _percmulta;
        }
        set
        {
            PropriedadeModificada(RO_PERCMULTA, value);
            _percmulta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usabancosec
    {
        get
        {
            PropriedadeAcessada(RO_USABANCOSEC);
            return _usabancosec;
        }
        set
        {
            PropriedadeModificada(RO_USABANCOSEC, value);
            _usabancosec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codbancosec
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOSEC);
            return _codbancosec;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOSEC, value);
            _codbancosec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Aceitapgtomenor
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAPGTOMENOR);
            return _aceitapgtomenor;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAPGTOMENOR, value);
            _aceitapgtomenor = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarcredclipagmaior
    {
        get
        {
            PropriedadeAcessada(RO_GERARCREDCLIPAGMAIOR);
            return _gerarcredclipagmaior;
        }
        set
        {
            PropriedadeModificada(RO_GERARCREDCLIPAGMAIOR, value);
            _gerarcredclipagmaior = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixarseminformarfilial
    {
        get
        {
            PropriedadeAcessada(RO_BAIXARSEMINFORMARFILIAL);
            return _baixarseminformarfilial;
        }
        set
        {
            PropriedadeModificada(RO_BAIXARSEMINFORMARFILIAL, value);
            _baixarseminformarfilial = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Aceitadepositoverbafornec
    {
        get
        {
            PropriedadeAcessada(RO_ACEITADEPOSITOVERBAFORNEC);
            return _aceitadepositoverbafornec;
        }
        set
        {
            PropriedadeModificada(RO_ACEITADEPOSITOVERBAFORNEC, value);
            _aceitadepositoverbafornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Posicao
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Varejo
    {
        get
        {
            PropriedadeAcessada(RO_VAREJO);
            return _varejo;
        }
        set
        {
            PropriedadeModificada(RO_VAREJO, value);
            _varejo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codfunccaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCAIXA);
            return _codfunccaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCAIXA, value);
            _codfunccaixa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtabertura
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURA);
            return _dtabertura;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURA, value);
            _dtabertura = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Valorminenvioprot
    {
        get
        {
            PropriedadeAcessada(RO_VALORMINENVIOPROT);
            return _valorminenvioprot;
        }
        set
        {
            PropriedadeModificada(RO_VALORMINENVIOPROT, value);
            _valorminenvioprot = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numconveniocef
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONVENIOCEF);
            return _numconveniocef;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONVENIOCEF, value);
            _numconveniocef = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Bloqcredclibaixa
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCREDCLIBAIXA);
            return _bloqcredclibaixa;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCREDCLIBAIXA, value);
            _bloqcredclibaixa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codcontdespbc
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTDESPBC);
            return _codcontdespbc;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTDESPBC, value);
            _codcontdespbc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codlayoutcm
    {
        get
        {
            PropriedadeAcessada(RO_CODLAYOUTCM);
            return _codlayoutcm;
        }
        set
        {
            PropriedadeModificada(RO_CODLAYOUTCM, value);
            _codlayoutcm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codbacen
    {
        get
        {
            PropriedadeAcessada(RO_CODBACEN);
            return _codbacen;
        }
        set
        {
            PropriedadeModificada(RO_CODBACEN, value);
            _codbacen = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarreceitapagmaior
    {
        get
        {
            PropriedadeAcessada(RO_GERARRECEITAPAGMAIOR);
            return _gerarreceitapagmaior;
        }
        set
        {
            PropriedadeModificada(RO_GERARRECEITAPAGMAIOR, value);
            _gerarreceitapagmaior = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Desctarbanc
    {
        get
        {
            PropriedadeAcessada(RO_DESCTARBANC);
            return _desctarbanc;
        }
        set
        {
            PropriedadeModificada(RO_DESCTARBANC, value);
            _desctarbanc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixatitcomdifvalores
    {
        get
        {
            PropriedadeAcessada(RO_BAIXATITCOMDIFVALORES);
            return _baixatitcomdifvalores;
        }
        set
        {
            PropriedadeModificada(RO_BAIXATITCOMDIFVALORES, value);
            _baixatitcomdifvalores = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrmaxbaixatitpagar
    {
        get
        {
            PropriedadeAcessada(RO_VLRMAXBAIXATITPAGAR);
            return _vlrmaxbaixatitpagar;
        }
        set
        {
            PropriedadeModificada(RO_VLRMAXBAIXATITPAGAR, value);
            _vlrmaxbaixatitpagar = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Geradoisdvbancosafracorresp
    {
        get
        {
            PropriedadeAcessada(RO_GERADOISDVBANCOSAFRACORRESP);
            return _geradoisdvbancosafracorresp;
        }
        set
        {
            PropriedadeModificada(RO_GERADOISDVBANCOSAFRACORRESP, value);
            _geradoisdvbancosafracorresp = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codeventointfolhadeb
    {
        get
        {
            PropriedadeAcessada(RO_CODEVENTOINTFOLHADEB);
            return _codeventointfolhadeb;
        }
        set
        {
            PropriedadeModificada(RO_CODEVENTOINTFOLHADEB, value);
            _codeventointfolhadeb = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codeventointfolhacred
    {
        get
        {
            PropriedadeAcessada(RO_CODEVENTOINTFOLHACRED);
            return _codeventointfolhacred;
        }
        set
        {
            PropriedadeModificada(RO_CODEVENTOINTFOLHACRED, value);
            _codeventointfolhacred = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 1, Precisao = 0)]
    public int? Tipovalorpagobanrisul
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVALORPAGOBANRISUL);
            return _tipovalorpagobanrisul;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVALORPAGOBANRISUL, value);
            _tipovalorpagobanrisul = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Geraxmlnfe
    {
        get
        {
            PropriedadeAcessada(RO_GERAXMLNFE);
            return _geraxmlnfe;
        }
        set
        {
            PropriedadeModificada(RO_GERAXMLNFE, value);
            _geraxmlnfe = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarcnab444
    {
        get
        {
            PropriedadeAcessada(RO_GERARCNAB444);
            return _gerarcnab444;
        }
        set
        {
            PropriedadeModificada(RO_GERARCNAB444, value);
            _gerarcnab444 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percdescontodia
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCONTODIA);
            return _percdescontodia;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCONTODIA, value);
            _percdescontodia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizabaixacc
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZABAIXACC);
            return _utilizabaixacc;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZABAIXACC, value);
            _utilizabaixacc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numconveniopagto
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONVENIOPAGTO);
            return _numconveniopagto;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONVENIOPAGTO, value);
            _numconveniopagto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Bancoretorno
    {
        get
        {
            PropriedadeAcessada(RO_BANCORETORNO);
            return _bancoretorno;
        }
        set
        {
            PropriedadeModificada(RO_BANCORETORNO, value);
            _bancoretorno = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Naobaixaaposvencsemvalormulta
    {
        get
        {
            PropriedadeAcessada(RO_NAOBAIXAAPOSVENCSEMVALORMULTA);
            return _naobaixaaposvencsemvalormulta;
        }
        set
        {
            PropriedadeModificada(RO_NAOBAIXAAPOSVENCSEMVALORMULTA, value);
            _naobaixaaposvencsemvalormulta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 0, Precisao = 0)]
    public int? Codlayoutcprem
    {
        get
        {
            PropriedadeAcessada(RO_CODLAYOUTCPREM);
            return _codlayoutcprem;
        }
        set
        {
            PropriedadeModificada(RO_CODLAYOUTCPREM, value);
            _codlayoutcprem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 0, Precisao = 0)]
    public int? Codlayoutcpret
    {
        get
        {
            PropriedadeAcessada(RO_CODLAYOUTCPRET);
            return _codlayoutcpret;
        }
        set
        {
            PropriedadeModificada(RO_CODLAYOUTCPRET, value);
            _codlayoutcpret = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Gerarnossonumerobasa7digitos
    {
        get
        {
            PropriedadeAcessada(RO_GERARNOSSONUMEROBASA7DIGITOS);
            return _gerarnossonumerobasa7digitos;
        }
        set
        {
            PropriedadeModificada(RO_GERARNOSSONUMEROBASA7DIGITOS, value);
            _gerarnossonumerobasa7digitos = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Numdiasbaixatitulo
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASBAIXATITULO);
            return _numdiasbaixatitulo;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASBAIXATITULO, value);
            _numdiasbaixatitulo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Nossonumbco17digcobcefsigcbreg
    {
        get
        {
            PropriedadeAcessada(RO_NOSSONUMBCO17DIGCOBCEFSIGCBREG);
            return _nossonumbco17digcobcefsigcbreg;
        }
        set
        {
            PropriedadeModificada(RO_NOSSONUMBCO17DIGCOBCEFSIGCBREG, value);
            _nossonumbco17digcobcefsigcbreg = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Somadespvpago
    {
        get
        {
            PropriedadeAcessada(RO_SOMADESPVPAGO);
            return _somadespvpago;
        }
        set
        {
            PropriedadeModificada(RO_SOMADESPVPAGO, value);
            _somadespvpago = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Validacodbancocm
    {
        get
        {
            PropriedadeAcessada(RO_VALIDACODBANCOCM);
            return _validacodbancocm;
        }
        set
        {
            PropriedadeModificada(RO_VALIDACODBANCOCM, value);
            _validacodbancocm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Baixatitdesconsiderandodesc
    {
        get
        {
            PropriedadeAcessada(RO_BAIXATITDESCONSIDERANDODESC);
            return _baixatitdesconsiderandodesc;
        }
        set
        {
            PropriedadeModificada(RO_BAIXATITDESCONSIDERANDODESC, value);
            _baixatitdesconsiderandodesc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrmaximodoc
    {
        get
        {
            PropriedadeAcessada(RO_VLRMAXIMODOC);
            return _vlrmaximodoc;
        }
        set
        {
            PropriedadeModificada(RO_VLRMAXIMODOC, value);
            _vlrmaximodoc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codlayoutcodbarra
    {
        get
        {
            PropriedadeAcessada(RO_CODLAYOUTCODBARRA);
            return _codlayoutcodbarra;
        }
        set
        {
            PropriedadeModificada(RO_CODLAYOUTCODBARRA, value);
            _codlayoutcodbarra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Codlayoutretornocr
    {
        get
        {
            PropriedadeAcessada(RO_CODLAYOUTRETORNOCR);
            return _codlayoutretornocr;
        }
        set
        {
            PropriedadeModificada(RO_CODLAYOUTRETORNOCR, value);
            _codlayoutretornocr = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBANCO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Consideradespcobbanc
    {
        get
        {
            PropriedadeAcessada(RO_CONSIDERADESPCOBBANC);
            return _consideradespcobbanc;
        }
        set
        {
            PropriedadeModificada(RO_CONSIDERADESPCOBBANC, value);
            _consideradespcobbanc = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCBANCO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<int>(leitor["Codbanco"]);
        _nome = AlterarTipo<string>(leitor["Nome"]);
        _numbanco = AlterarTipo<int?>(leitor["Numbanco"]);
        _agencia = AlterarTipo<string?>(leitor["Agencia"]);
        _conta = AlterarTipo<string?>(leitor["Conta"]);
        _proxnumch = AlterarTipo<int?>(leitor["Proxnumch"]);
        _codcontabil = AlterarTipo<int?>(leitor["Codcontabil"]);
        _proxnumremessa = AlterarTipo<int?>(leitor["Proxnumremessa"]);
        _tipocxbco = AlterarTipo<string?>(leitor["Tipocxbco"]);
        _proxnossonumbco = AlterarTipo<int?>(leitor["Proxnossonumbco"]);
        _numcarteira = AlterarTipo<string?>(leitor["Numcarteira"]);
        _numconvenio = AlterarTipo<int?>(leitor["Numconvenio"]);
        _fluxocx = AlterarTipo<string?>(leitor["Fluxocx"]);
        _contapagmagnetico = AlterarTipo<string?>(leitor["Contapagmagnetico"]);
        _codfilial = AlterarTipo<string?>(leitor["Codfilial"]);
        _numcarteira3 = AlterarTipo<string?>(leitor["Numcarteira3"]);
        _proxnumcustodia = AlterarTipo<int?>(leitor["Proxnumcustodia"]);
        _faixaini = AlterarTipo<int?>(leitor["Faixaini"]);
        _faixafim = AlterarTipo<int?>(leitor["Faixafim"]);
        _tipocob = AlterarTipo<string?>(leitor["Tipocob"]);
        _variacao = AlterarTipo<int?>(leitor["Variacao"]);
        _nomertm = AlterarTipo<string?>(leitor["Nomertm"]);
        _agenciaentrega = AlterarTipo<string?>(leitor["Agenciaentrega"]);
        _numconveniocustodia = AlterarTipo<int?>(leitor["Numconveniocustodia"]);
        _proxnumpagto = AlterarTipo<int?>(leitor["Proxnumpagto"]);
        _numseqcustodia = AlterarTipo<int?>(leitor["Numseqcustodia"]);
        _codclientenobanco = AlterarTipo<string?>(leitor["Codclientenobanco"]);
        _codcontabildni = AlterarTipo<int?>(leitor["Codcontabildni"]);
        _codcontabilcobs = AlterarTipo<int?>(leitor["Codcontabilcobs"]);
        _codcontabilchdv = AlterarTipo<int?>(leitor["Codcontabilchdv"]);
        _gerarboleto = AlterarTipo<string?>(leitor["Gerarboleto"]);
        _agenciacorrespondente = AlterarTipo<string?>(leitor["Agenciacorrespondente"]);
        _numcolsvendor = AlterarTipo<int?>(leitor["Numcolsvendor"]);
        _numdiasprotesto = AlterarTipo<string?>(leitor["Numdiasprotesto"]);
        _nossonumbcopreimpr = AlterarTipo<int?>(leitor["Nossonumbcopreimpr"]);
        _anoremessa = AlterarTipo<int?>(leitor["Anoremessa"]);
        _baixatitulonaoacertado = AlterarTipo<string?>(leitor["Baixatitulonaoacertado"]);
        _baixajurosmenorcm = AlterarTipo<string?>(leitor["Baixajurosmenorcm"]);
        _naobaixajurosmenorcm = AlterarTipo<string?>(leitor["Naobaixajurosmenorcm"]);
        _baixatitulosdescfincm = AlterarTipo<string?>(leitor["Baixatitulosdescfincm"]);
        _vltarifabancaria = AlterarTipo<decimal?>(leitor["Vltarifabancaria"]);
        _usatarifabancariaporbanco = AlterarTipo<string?>(leitor["Usatarifabancariaporbanco"]);
        _codcedente = AlterarTipo<string?>(leitor["Codcedente"]);
        _numcodlayoutcustodia = AlterarTipo<int?>(leitor["Numcodlayoutcustodia"]);
        _cgcremessa = AlterarTipo<string?>(leitor["Cgcremessa"]);
        _proxnossonumbcoecf = AlterarTipo<int?>(leitor["Proxnossonumbcoecf"]);
        _incdupjurosdesd = AlterarTipo<string?>(leitor["Incdupjurosdesd"]);
        _valorgerajuros = AlterarTipo<decimal?>(leitor["Valorgerajuros"]);
        _nomeprefremessa = AlterarTipo<string?>(leitor["Nomeprefremessa"]);
        _gerarcrecebercartorio = AlterarTipo<string?>(leitor["Gerarcrecebercartorio"]);
        _qthorasmaxfechacx = AlterarTipo<int?>(leitor["Qthorasmaxfechacx"]);
        _utilizafechamentocaixa = AlterarTipo<string?>(leitor["Utilizafechamentocaixa"]);
        _percmulta = AlterarTipo<decimal?>(leitor["Percmulta"]);
        _usabancosec = AlterarTipo<string?>(leitor["Usabancosec"]);
        _codbancosec = AlterarTipo<int?>(leitor["Codbancosec"]);
        _aceitapgtomenor = AlterarTipo<string?>(leitor["Aceitapgtomenor"]);
        _gerarcredclipagmaior = AlterarTipo<string?>(leitor["Gerarcredclipagmaior"]);
        _baixarseminformarfilial = AlterarTipo<string?>(leitor["Baixarseminformarfilial"]);
        _aceitadepositoverbafornec = AlterarTipo<string?>(leitor["Aceitadepositoverbafornec"]);
        _posicao = AlterarTipo<string?>(leitor["Posicao"]);
        _varejo = AlterarTipo<string?>(leitor["Varejo"]);
        _codfunccaixa = AlterarTipo<int?>(leitor["Codfunccaixa"]);
        _dtabertura = AlterarTipo<DateTime?>(leitor["Dtabertura"]);
        _valorminenvioprot = AlterarTipo<decimal?>(leitor["Valorminenvioprot"]);
        _numconveniocef = AlterarTipo<string?>(leitor["Numconveniocef"]);
        _bloqcredclibaixa = AlterarTipo<string?>(leitor["Bloqcredclibaixa"]);
        _codcontdespbc = AlterarTipo<int?>(leitor["Codcontdespbc"]);
        _codlayoutcm = AlterarTipo<int?>(leitor["Codlayoutcm"]);
        _codbacen = AlterarTipo<string?>(leitor["Codbacen"]);
        _gerarreceitapagmaior = AlterarTipo<string?>(leitor["Gerarreceitapagmaior"]);
        _desctarbanc = AlterarTipo<string?>(leitor["Desctarbanc"]);
        _baixatitcomdifvalores = AlterarTipo<string?>(leitor["Baixatitcomdifvalores"]);
        _vlrmaxbaixatitpagar = AlterarTipo<decimal?>(leitor["Vlrmaxbaixatitpagar"]);
        _geradoisdvbancosafracorresp = AlterarTipo<string?>(leitor["Geradoisdvbancosafracorresp"]);
        _codeventointfolhadeb = AlterarTipo<string?>(leitor["Codeventointfolhadeb"]);
        _codeventointfolhacred = AlterarTipo<string?>(leitor["Codeventointfolhacred"]);
        _tipovalorpagobanrisul = AlterarTipo<int?>(leitor["Tipovalorpagobanrisul"]);
        _geraxmlnfe = AlterarTipo<string?>(leitor["Geraxmlnfe"]);
        _gerarcnab444 = AlterarTipo<string?>(leitor["Gerarcnab444"]);
        _percdescontodia = AlterarTipo<decimal?>(leitor["Percdescontodia"]);
        _utilizabaixacc = AlterarTipo<string?>(leitor["Utilizabaixacc"]);
        _numconveniopagto = AlterarTipo<string?>(leitor["Numconveniopagto"]);
        _bancoretorno = AlterarTipo<int?>(leitor["Bancoretorno"]);
        _naobaixaaposvencsemvalormulta = AlterarTipo<string?>(leitor["Naobaixaaposvencsemvalormulta"]);
        _codlayoutcprem = AlterarTipo<int?>(leitor["Codlayoutcprem"]);
        _codlayoutcpret = AlterarTipo<int?>(leitor["Codlayoutcpret"]);
        _gerarnossonumerobasa7digitos = AlterarTipo<string?>(leitor["Gerarnossonumerobasa7digitos"]);
        _numdiasbaixatitulo = AlterarTipo<int?>(leitor["Numdiasbaixatitulo"]);
        _nossonumbco17digcobcefsigcbreg = AlterarTipo<string?>(leitor["Nossonumbco17digcobcefsigcbreg"]);
        _somadespvpago = AlterarTipo<string?>(leitor["Somadespvpago"]);
        _validacodbancocm = AlterarTipo<string?>(leitor["Validacodbancocm"]);
        _baixatitdesconsiderandodesc = AlterarTipo<string?>(leitor["Baixatitdesconsiderandodesc"]);
        _vlrmaximodoc = AlterarTipo<decimal?>(leitor["Vlrmaximodoc"]);
        _codlayoutcodbarra = AlterarTipo<int?>(leitor["Codlayoutcodbarra"]);
        _codlayoutretornocr = AlterarTipo<int?>(leitor["Codlayoutretornocr"]);
        _consideradespcobbanc = AlterarTipo<string?>(leitor["Consideradespcobbanc"]);
    }
}