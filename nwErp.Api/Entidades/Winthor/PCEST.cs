

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCEST : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ALIQICMS1ULTENT = "Aliqicms1ultent";

    private decimal? _aliqicms1ultent;

    private static readonly string RO_PERFCPSTRET = "Perfcpstret";

    private decimal? _perfcpstret;

    private static readonly string RO_ALIQICMS1 = "Aliqicms1";

    private decimal? _aliqicms1;

    private static readonly string RO_ALIQICMS1ULTENTTAB = "Aliqicms1ultenttab";

    private decimal? _aliqicms1ultenttab;

    private static readonly string RO_ALIQICMS2ULTENT = "Aliqicms2ultent";

    private decimal? _aliqicms2ultent;

    private static readonly string RO_ALIQICMS2ULTENTTAB = "Aliqicms2ultenttab";

    private decimal? _aliqicms2ultenttab;

    private static readonly string RO_APTO = "Apto";

    private decimal? _apto;

    private static readonly string RO_APTOCX = "Aptocx";

    private decimal? _aptocx;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_BASEBCR = "Basebcr";

    private decimal? _basebcr;

    private static readonly string RO_BASEICMSULTENT = "Baseicmsultent";

    private decimal? _baseicmsultent;

    private static readonly string RO_BASEICMSULTENTTAB = "Baseicmsultenttab";

    private decimal? _baseicmsultenttab;

    private static readonly string RO_CODDEVOL = "Coddevol";

    private decimal? _coddevol;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CORREDOR = "Corredor";

    private decimal? _corredor;

    private static readonly string RO_CUSTOCONT = "Custocont";

    private decimal? _custocont;

    private static readonly string RO_CUSTODOLAR = "Custodolar";

    private decimal? _custodolar;

    private static readonly string RO_CUSTOFIN = "Custofin";

    private decimal? _custofin;

    private static readonly string RO_CUSTOFORNEC = "Custofornec";

    private decimal? _custofornec;

    private static readonly string RO_CUSTONFSEMST = "Custonfsemst";

    private decimal? _custonfsemst;

    private static readonly string RO_CUSTONFSEMSTGUIAULTENT = "Custonfsemstguiaultent";

    private decimal? _custonfsemstguiaultent;

    private static readonly string RO_CUSTONFSEMSTGUIAULTENTTAB = "Custonfsemstguiaultenttab";

    private decimal? _custonfsemstguiaultenttab;

    private static readonly string RO_CUSTONFSEMSTTAB = "Custonfsemsttab";

    private decimal? _custonfsemsttab;

    private static readonly string RO_CUSTOPROXIMACOMPRA = "Custoproximacompra";

    private decimal? _custoproximacompra;

    private static readonly string RO_CUSTOREAL = "Custoreal";

    private decimal? _custoreal;

    private static readonly string RO_CUSTOREALLIQ = "Custorealliq";

    private decimal? _custorealliq;

    private static readonly string RO_CUSTOREALSEMST = "Custorealsemst";

    private decimal? _custorealsemst;

    private static readonly string RO_CUSTOREP = "Custorep";

    private decimal? _custorep;

    private static readonly string RO_CUSTOULTENT = "Custoultent";

    private decimal? _custoultent;

    private static readonly string RO_CUSTOULTENTANT = "Custoultentant";

    private decimal? _custoultentant;

    private static readonly string RO_CUSTOULTENTCONT = "Custoultentcont";

    private decimal? _custoultentcont;

    private static readonly string RO_CUSTOULTENTFIN = "Custoultentfin";

    private decimal? _custoultentfin;

    private static readonly string RO_CUSTOULTENTLIQ = "Custoultentliq";

    private decimal? _custoultentliq;

    private static readonly string RO_CUSTOULTENTMED = "Custoultentmed";

    private decimal? _custoultentmed;

    private static readonly string RO_CUSTOULTPEDCOMPRA = "Custoultpedcompra";

    private decimal? _custoultpedcompra;

    private static readonly string RO_DTALTERACAO1107 = "Dtalteracao1107";

    private DateTime? _dtalteracao1107;

    private static readonly string RO_DTEMISSAOULTENT = "Dtemissaoultent";

    private DateTime? _dtemissaoultent;

    private static readonly string RO_DTPRIMCOMPRA = "Dtprimcompra";

    private DateTime? _dtprimcompra;

    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";

    private DateTime? _dtultaltersrvprc;

    private static readonly string RO_DTULTDESDOBRA = "Dtultdesdobra";

    private DateTime? _dtultdesdobra;

    private static readonly string RO_DTULTENT = "Dtultent";

    private DateTime? _dtultent;

    private static readonly string RO_DTULTFAT = "Dtultfat";

    private DateTime? _dtultfat;

    private static readonly string RO_DTULTINVENT = "Dtultinvent";

    private DateTime? _dtultinvent;

    private static readonly string RO_DTULTPEDCOMPRA = "Dtultpedcompra";

    private DateTime? _dtultpedcompra;

    private static readonly string RO_DTULTSAIDA = "Dtultsaida";

    private DateTime? _dtultsaida;

    private static readonly string RO_ESTIDEAL = "Estideal";

    private decimal? _estideal;

    private static readonly string RO_ESTMAX = "Estmax";

    private decimal? _estmax;

    private static readonly string RO_ESTMIN = "Estmin";

    private decimal? _estmin;

    private static readonly string RO_FIMESTOQUE = "Fimestoque";

    private string _fimestoque;

    private static readonly string RO_IVAULTENT = "Ivaultent";

    private decimal? _ivaultent;

    private static readonly string RO_IVAULTENTTAB = "Ivaultenttab";

    private decimal? _ivaultenttab;

    private static readonly string RO_MODULO = "Modulo";

    private decimal? _modulo;

    private static readonly string RO_MODULOCX = "Modulocx";

    private decimal? _modulocx;

    private static readonly string RO_MOTIVOBLOQESTOQUE = "Motivobloqestoque";

    private string _motivobloqestoque;

    private static readonly string RO_NUMERO = "Numero";

    private decimal? _numero;

    private static readonly string RO_NUMEROCX = "Numerocx";

    private decimal? _numerocx;

    private static readonly string RO_NUMNOTAULTENT = "Numnotaultent";

    private decimal? _numnotaultent;

    private static readonly string RO_NUMTRANSENTULTENT = "Numtransentultent";

    private decimal? _numtransentultent;

    private static readonly string RO_PCOMPRAULTENT = "Pcompraultent";

    private decimal? _pcompraultent;

    private static readonly string RO_PCUSTOANT = "Pcustoant";

    private decimal? _pcustoant;

    private static readonly string RO_PERCALIQEXTGUIAULTENT = "Percaliqextguiaultent";

    private decimal? _percaliqextguiaultent;

    private static readonly string RO_PERCALIQEXTGUIAULTENTTAB = "Percaliqextguiaultenttab";

    private decimal? _percaliqextguiaultenttab;

    private static readonly string RO_PERCEVOLUCAOVENDA = "Percevolucaovenda";

    private decimal? _percevolucaovenda;

    private static readonly string RO_PERCICMSFRETEFOBSTULTENT = "Percicmsfretefobstultent";

    private decimal? _percicmsfretefobstultent;

    private static readonly string RO_PERCICMSFRETEFOBSTULTENTTAB = "Percicmsfretefobstultenttab";

    private decimal? _percicmsfretefobstultenttab;

    private static readonly string RO_PERCMVAORIGTAB = "Percmvaorigtab";

    private decimal? _percmvaorigtab;

    private static readonly string RO_PERCMVAORIGULTENT = "Percmvaorigultent";

    private decimal? _percmvaorigultent;

    private static readonly string RO_QTBLOQTRANSF = "Qtbloqtransf";

    private decimal? _qtbloqtransf;

    private static readonly string RO_QTBLOQUEADA = "Qtbloqueada";

    private decimal? _qtbloqueada;

    private static readonly string RO_QTDEVOLMES = "Qtdevolmes";

    private decimal? _qtdevolmes;

    private static readonly string RO_QTDEVOLMES1 = "Qtdevolmes1";

    private decimal? _qtdevolmes1;

    private static readonly string RO_QTDEVOLMES2 = "Qtdevolmes2";

    private decimal? _qtdevolmes2;

    private static readonly string RO_QTDEVOLMES3 = "Qtdevolmes3";

    private decimal? _qtdevolmes3;

    private static readonly string RO_QTENTDIA = "Qtentdia";

    private decimal? _qtentdia;

    private static readonly string RO_QTENTMES = "Qtentmes";

    private decimal? _qtentmes;

    private static readonly string RO_QTEST = "Qtest";

    private decimal? _qtest;

    private static readonly string RO_QTESTANT = "Qtestant";

    private decimal? _qtestant;

    private static readonly string RO_QTESTGER = "Qtestger";

    private decimal? _qtestger;

    private static readonly string RO_QTESTORNOPRODUZDIA = "Qtestornoproduzdia";

    private decimal? _qtestornoproduzdia;

    private static readonly string RO_QTESTORNOPRODUZMES = "Qtestornoproduzmes";

    private decimal? _qtestornoproduzmes;

    private static readonly string RO_QTGIROCURVATURA = "Qtgirocurvatura";

    private decimal? _qtgirocurvatura;

    private static readonly string RO_QTGIROCURVATURAANT = "Qtgirocurvaturaant";

    private decimal? _qtgirocurvaturaant;

    private static readonly string RO_QTGIRODIA = "Qtgirodia";

    private decimal? _qtgirodia;

    private static readonly string RO_QTINDENIZ = "Qtindeniz";

    private decimal? _qtindeniz;

    private static readonly string RO_QTLOJA = "Qtloja";

    private decimal? _qtloja;

    private static readonly string RO_QTPEDIDA = "Qtpedida";

    private decimal? _qtpedida;

    private static readonly string RO_QTPENDENTE = "Qtpendente";

    private decimal? _qtpendente;

    private static readonly string RO_QTPERDADIA = "Qtperdadia";

    private decimal? _qtperdadia;

    private static readonly string RO_QTPERDAMES = "Qtperdames";

    private decimal? _qtperdames;

    private static readonly string RO_QTPRODUZIDADIA = "Qtproduzidadia";

    private decimal? _qtproduzidadia;

    private static readonly string RO_QTPRODUZIDAMES = "Qtproduzidames";

    private decimal? _qtproduzidames;

    private static readonly string RO_QTREQUISICAO = "Qtrequisicao";

    private decimal? _qtrequisicao;

    private static readonly string RO_QTRESERV = "Qtreserv";

    private decimal? _qtreserv;

    private static readonly string RO_QTRESERVMED = "Qtreservmed";

    private decimal? _qtreservmed;

    private static readonly string RO_QTTRANSITO = "Qttransito";

    private decimal? _qttransito;

    private static readonly string RO_QTULTENT = "Qtultent";

    private decimal? _qtultent;

    private static readonly string RO_QTULTINVENT = "Qtultinvent";

    private decimal? _qtultinvent;

    private static readonly string RO_QTVENDAPERDIDA = "Qtvendaperdida";

    private decimal? _qtvendaperdida;

    private static readonly string RO_QTVENDDIA = "Qtvenddia";

    private decimal? _qtvenddia;

    private static readonly string RO_QTVENDMES = "Qtvendmes";

    private decimal? _qtvendmes;

    private static readonly string RO_QTVENDMES1 = "Qtvendmes1";

    private decimal? _qtvendmes1;

    private static readonly string RO_QTVENDMES2 = "Qtvendmes2";

    private decimal? _qtvendmes2;

    private static readonly string RO_QTVENDMES3 = "Qtvendmes3";

    private decimal? _qtvendmes3;

    private static readonly string RO_QTVENDSEMANA = "Qtvendsemana";

    private decimal? _qtvendsemana;

    private static readonly string RO_QTVENDSEMANA1 = "Qtvendsemana1";

    private decimal? _qtvendsemana1;

    private static readonly string RO_QTVENDSEMANA2 = "Qtvendsemana2";

    private decimal? _qtvendsemana2;

    private static readonly string RO_QTVENDSEMANA3 = "Qtvendsemana3";

    private decimal? _qtvendsemana3;

    private static readonly string RO_REDBASEIVAULTENT = "Redbaseivaultent";

    private decimal? _redbaseivaultent;

    private static readonly string RO_REDBASEIVAULTENTTAB = "Redbaseivaultenttab";

    private decimal? _redbaseivaultenttab;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_RUA = "Rua";

    private decimal? _rua;

    private static readonly string RO_RUACX = "Ruacx";

    private decimal? _ruacx;

    private static readonly string RO_STBCR = "Stbcr";

    private decimal? _stbcr;

    private static readonly string RO_VALORULTENT = "Valorultent";

    private decimal? _valorultent;

    private static readonly string RO_VALORULTENTMED = "Valorultentmed";

    private decimal? _valorultentmed;

    private static readonly string RO_VLCUSTODIAFIN = "Vlcustodiafin";

    private decimal? _vlcustodiafin;

    private static readonly string RO_VLCUSTODIAREAL = "Vlcustodiareal";

    private decimal? _vlcustodiareal;

    private static readonly string RO_VLCUSTOMESFIN = "Vlcustomesfin";

    private decimal? _vlcustomesfin;

    private static readonly string RO_VLCUSTOMESFINANT = "Vlcustomesfinant";

    private decimal? _vlcustomesfinant;

    private static readonly string RO_VLCUSTOMESREAL = "Vlcustomesreal";

    private decimal? _vlcustomesreal;

    private static readonly string RO_VLCUSTOMESREALANT = "Vlcustomesrealant";

    private decimal? _vlcustomesrealant;

    private static readonly string RO_VLFRETECONHECULTENT = "Vlfreteconhecultent";

    private decimal? _vlfreteconhecultent;

    private static readonly string RO_VLFRETECONHECULTENTTAB = "Vlfreteconhecultenttab";

    private decimal? _vlfreteconhecultenttab;

    private static readonly string RO_VLSTGUIAULTENT = "Vlstguiaultent";

    private decimal? _vlstguiaultent;

    private static readonly string RO_VLSTGUIAULTENTTAB = "Vlstguiaultenttab";

    private decimal? _vlstguiaultenttab;

    private static readonly string RO_VLSTULTENT = "Vlstultent";

    private decimal? _vlstultent;

    private static readonly string RO_VLSTULTENTTAB = "Vlstultenttab";

    private decimal? _vlstultenttab;

    private static readonly string RO_VLULTENTCONTSEMST = "Vlultentcontsemst";

    private decimal? _vlultentcontsemst;

    private static readonly string RO_VLULTPCOMPRA = "Vlultpcompra";

    private decimal? _vlultpcompra;

    private static readonly string RO_VLVENDDIA = "Vlvenddia";

    private decimal? _vlvenddia;

    private static readonly string RO_VLVENDDIAREAL = "Vlvenddiareal";

    private decimal? _vlvenddiareal;

    private static readonly string RO_VLVENDMES = "Vlvendmes";

    private decimal? _vlvendmes;

    private static readonly string RO_VLVENDMESANT = "Vlvendmesant";

    private decimal? _vlvendmesant;

    private static readonly string RO_VLVENDMESREAL = "Vlvendmesreal";

    private decimal? _vlvendmesreal;

    private static readonly string RO_QTFRENTELOJA = "Qtfrenteloja";

    private decimal? _qtfrenteloja;

    private static readonly string RO_NUMTRANSULTENTST = "Numtransultentst";

    private decimal? _numtransultentst;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1ultent
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1ULTENT);
            return _aliqicms1ultent;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1ULTENT, value);
            _aliqicms1ultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perfcpstret
    {
        get
        {
            PropriedadeAcessada(RO_PERFCPSTRET);
            return _perfcpstret;
        }
        set
        {
            PropriedadeModificada(RO_PERFCPSTRET, value);
            _perfcpstret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1);
            return _aliqicms1;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1, value);
            _aliqicms1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms1ultenttab
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS1ULTENTTAB);
            return _aliqicms1ultenttab;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS1ULTENTTAB, value);
            _aliqicms1ultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms2ultent
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2ULTENT);
            return _aliqicms2ultent;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2ULTENT, value);
            _aliqicms2ultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Aliqicms2ultenttab
    {
        get
        {
            PropriedadeAcessada(RO_ALIQICMS2ULTENTTAB);
            return _aliqicms2ultenttab;
        }
        set
        {
            PropriedadeModificada(RO_ALIQICMS2ULTENTTAB, value);
            _aliqicms2ultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Apto
    {
        get
        {
            PropriedadeAcessada(RO_APTO);
            return _apto;
        }
        set
        {
            PropriedadeModificada(RO_APTO, value);
            _apto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Aptocx
    {
        get
        {
            PropriedadeAcessada(RO_APTOCX);
            return _aptocx;
        }
        set
        {
            PropriedadeModificada(RO_APTOCX, value);
            _aptocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Assinatura
    {
        get
        {
            PropriedadeAcessada(RO_ASSINATURA);
            return _assinatura;
        }
        set
        {
            PropriedadeModificada(RO_ASSINATURA, value);
            _assinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basebcr
    {
        get
        {
            PropriedadeAcessada(RO_BASEBCR);
            return _basebcr;
        }
        set
        {
            PropriedadeModificada(RO_BASEBCR, value);
            _basebcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultent
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSULTENT);
            return _baseicmsultent;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSULTENT, value);
            _baseicmsultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicmsultenttab
    {
        get
        {
            PropriedadeAcessada(RO_BASEICMSULTENTTAB);
            return _baseicmsultenttab;
        }
        set
        {
            PropriedadeModificada(RO_BASEICMSULTENTTAB, value);
            _baseicmsultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Coddevol
    {
        get
        {
            PropriedadeAcessada(RO_CODDEVOL);
            return _coddevol;
        }
        set
        {
            PropriedadeModificada(RO_CODDEVOL, value);
            _coddevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Corredor
    {
        get
        {
            PropriedadeAcessada(RO_CORREDOR);
            return _corredor;
        }
        set
        {
            PropriedadeModificada(RO_CORREDOR, value);
            _corredor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custocont
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOCONT);
            return _custocont;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOCONT, value);
            _custocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custodolar
    {
        get
        {
            PropriedadeAcessada(RO_CUSTODOLAR);
            return _custodolar;
        }
        set
        {
            PropriedadeModificada(RO_CUSTODOLAR, value);
            _custodolar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofin
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFIN);
            return _custofin;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFIN, value);
            _custofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Custofornec
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOFORNEC);
            return _custofornec;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOFORNEC, value);
            _custofornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemst
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMST);
            return _custonfsemst;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMST, value);
            _custonfsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstguiaultent
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMSTGUIAULTENT);
            return _custonfsemstguiaultent;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMSTGUIAULTENT, value);
            _custonfsemstguiaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemstguiaultenttab
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMSTGUIAULTENTTAB);
            return _custonfsemstguiaultenttab;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMSTGUIAULTENTTAB, value);
            _custonfsemstguiaultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custonfsemsttab
    {
        get
        {
            PropriedadeAcessada(RO_CUSTONFSEMSTTAB);
            return _custonfsemsttab;
        }
        set
        {
            PropriedadeModificada(RO_CUSTONFSEMSTTAB, value);
            _custonfsemsttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoproximacompra
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOPROXIMACOMPRA);
            return _custoproximacompra;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOPROXIMACOMPRA, value);
            _custoproximacompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoreal
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREAL);
            return _custoreal;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREAL, value);
            _custoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealliq
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALLIQ);
            return _custorealliq;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALLIQ, value);
            _custorealliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorealsemst
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREALSEMST);
            return _custorealsemst;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREALSEMST, value);
            _custorealsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custorep
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOREP);
            return _custorep;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOREP, value);
            _custorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultent
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENT);
            return _custoultent;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENT, value);
            _custoultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentant
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTANT);
            return _custoultentant;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTANT, value);
            _custoultentant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentcont
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTCONT);
            return _custoultentcont;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTCONT, value);
            _custoultentcont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentfin
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTFIN);
            return _custoultentfin;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTFIN, value);
            _custoultentfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentliq
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTLIQ);
            return _custoultentliq;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTLIQ, value);
            _custoultentliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultentmed
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTENTMED);
            return _custoultentmed;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTENTMED, value);
            _custoultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custoultpedcompra
    {
        get
        {
            PropriedadeAcessada(RO_CUSTOULTPEDCOMPRA);
            return _custoultpedcompra;
        }
        set
        {
            PropriedadeModificada(RO_CUSTOULTPEDCOMPRA, value);
            _custoultpedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtalteracao1107
    {
        get
        {
            PropriedadeAcessada(RO_DTALTERACAO1107);
            return _dtalteracao1107;
        }
        set
        {
            PropriedadeModificada(RO_DTALTERACAO1107, value);
            _dtalteracao1107 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoultent
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOULTENT);
            return _dtemissaoultent;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOULTENT, value);
            _dtemissaoultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprimcompra
    {
        get
        {
            PropriedadeAcessada(RO_DTPRIMCOMPRA);
            return _dtprimcompra;
        }
        set
        {
            PropriedadeModificada(RO_DTPRIMCOMPRA, value);
            _dtprimcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltersrvprc
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERSRVPRC);
            return _dtultaltersrvprc;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERSRVPRC, value);
            _dtultaltersrvprc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultdesdobra
    {
        get
        {
            PropriedadeAcessada(RO_DTULTDESDOBRA);
            return _dtultdesdobra;
        }
        set
        {
            PropriedadeModificada(RO_DTULTDESDOBRA, value);
            _dtultdesdobra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultent
    {
        get
        {
            PropriedadeAcessada(RO_DTULTENT);
            return _dtultent;
        }
        set
        {
            PropriedadeModificada(RO_DTULTENT, value);
            _dtultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultfat
    {
        get
        {
            PropriedadeAcessada(RO_DTULTFAT);
            return _dtultfat;
        }
        set
        {
            PropriedadeModificada(RO_DTULTFAT, value);
            _dtultfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultinvent
    {
        get
        {
            PropriedadeAcessada(RO_DTULTINVENT);
            return _dtultinvent;
        }
        set
        {
            PropriedadeModificada(RO_DTULTINVENT, value);
            _dtultinvent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultpedcompra
    {
        get
        {
            PropriedadeAcessada(RO_DTULTPEDCOMPRA);
            return _dtultpedcompra;
        }
        set
        {
            PropriedadeModificada(RO_DTULTPEDCOMPRA, value);
            _dtultpedcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTULTSAIDA);
            return _dtultsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTULTSAIDA, value);
            _dtultsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Estideal
    {
        get
        {
            PropriedadeAcessada(RO_ESTIDEAL);
            return _estideal;
        }
        set
        {
            PropriedadeModificada(RO_ESTIDEAL, value);
            _estideal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Estmax
    {
        get
        {
            PropriedadeAcessada(RO_ESTMAX);
            return _estmax;
        }
        set
        {
            PropriedadeModificada(RO_ESTMAX, value);
            _estmax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Estmin
    {
        get
        {
            PropriedadeAcessada(RO_ESTMIN);
            return _estmin;
        }
        set
        {
            PropriedadeModificada(RO_ESTMIN, value);
            _estmin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fimestoque
    {
        get
        {
            PropriedadeAcessada(RO_FIMESTOQUE);
            return _fimestoque;
        }
        set
        {
            PropriedadeModificada(RO_FIMESTOQUE, value);
            _fimestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivaultent
    {
        get
        {
            PropriedadeAcessada(RO_IVAULTENT);
            return _ivaultent;
        }
        set
        {
            PropriedadeModificada(RO_IVAULTENT, value);
            _ivaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Ivaultenttab
    {
        get
        {
            PropriedadeAcessada(RO_IVAULTENTTAB);
            return _ivaultenttab;
        }
        set
        {
            PropriedadeModificada(RO_IVAULTENTTAB, value);
            _ivaultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Modulo
    {
        get
        {
            PropriedadeAcessada(RO_MODULO);
            return _modulo;
        }
        set
        {
            PropriedadeModificada(RO_MODULO, value);
            _modulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Modulocx
    {
        get
        {
            PropriedadeAcessada(RO_MODULOCX);
            return _modulocx;
        }
        set
        {
            PropriedadeModificada(RO_MODULOCX, value);
            _modulocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Motivobloqestoque
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOBLOQESTOQUE);
            return _motivobloqestoque;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOBLOQESTOQUE, value);
            _motivobloqestoque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numero
    {
        get
        {
            PropriedadeAcessada(RO_NUMERO);
            return _numero;
        }
        set
        {
            PropriedadeModificada(RO_NUMERO, value);
            _numero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Numerocx
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROCX);
            return _numerocx;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROCX, value);
            _numerocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaultent
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAULTENT);
            return _numnotaultent;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAULTENT, value);
            _numnotaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentultent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTULTENT);
            return _numtransentultent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTULTENT, value);
            _numtransentultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pcompraultent
    {
        get
        {
            PropriedadeAcessada(RO_PCOMPRAULTENT);
            return _pcompraultent;
        }
        set
        {
            PropriedadeModificada(RO_PCOMPRAULTENT, value);
            _pcompraultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pcustoant
    {
        get
        {
            PropriedadeAcessada(RO_PCUSTOANT);
            return _pcustoant;
        }
        set
        {
            PropriedadeModificada(RO_PCUSTOANT, value);
            _pcustoant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqextguiaultent
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXTGUIAULTENT);
            return _percaliqextguiaultent;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXTGUIAULTENT, value);
            _percaliqextguiaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percaliqextguiaultenttab
    {
        get
        {
            PropriedadeAcessada(RO_PERCALIQEXTGUIAULTENTTAB);
            return _percaliqextguiaultenttab;
        }
        set
        {
            PropriedadeModificada(RO_PERCALIQEXTGUIAULTENTTAB, value);
            _percaliqextguiaultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percevolucaovenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCEVOLUCAOVENDA);
            return _percevolucaovenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCEVOLUCAOVENDA, value);
            _percevolucaovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobstultent
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSFRETEFOBSTULTENT);
            return _percicmsfretefobstultent;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSFRETEFOBSTULTENT, value);
            _percicmsfretefobstultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percicmsfretefobstultenttab
    {
        get
        {
            PropriedadeAcessada(RO_PERCICMSFRETEFOBSTULTENTTAB);
            return _percicmsfretefobstultenttab;
        }
        set
        {
            PropriedadeModificada(RO_PERCICMSFRETEFOBSTULTENTTAB, value);
            _percicmsfretefobstultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmvaorigtab
    {
        get
        {
            PropriedadeAcessada(RO_PERCMVAORIGTAB);
            return _percmvaorigtab;
        }
        set
        {
            PropriedadeModificada(RO_PERCMVAORIGTAB, value);
            _percmvaorigtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percmvaorigultent
    {
        get
        {
            PropriedadeAcessada(RO_PERCMVAORIGULTENT);
            return _percmvaorigultent;
        }
        set
        {
            PropriedadeModificada(RO_PERCMVAORIGULTENT, value);
            _percmvaorigultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtbloqtransf
    {
        get
        {
            PropriedadeAcessada(RO_QTBLOQTRANSF);
            return _qtbloqtransf;
        }
        set
        {
            PropriedadeModificada(RO_QTBLOQTRANSF, value);
            _qtbloqtransf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtbloqueada
    {
        get
        {
            PropriedadeAcessada(RO_QTBLOQUEADA);
            return _qtbloqueada;
        }
        set
        {
            PropriedadeModificada(RO_QTBLOQUEADA, value);
            _qtbloqueada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtdevolmes
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOLMES);
            return _qtdevolmes;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOLMES, value);
            _qtdevolmes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtdevolmes1
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOLMES1);
            return _qtdevolmes1;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOLMES1, value);
            _qtdevolmes1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtdevolmes2
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOLMES2);
            return _qtdevolmes2;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOLMES2, value);
            _qtdevolmes2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtdevolmes3
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOLMES3);
            return _qtdevolmes3;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOLMES3, value);
            _qtdevolmes3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtentdia
    {
        get
        {
            PropriedadeAcessada(RO_QTENTDIA);
            return _qtentdia;
        }
        set
        {
            PropriedadeModificada(RO_QTENTDIA, value);
            _qtentdia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtentmes
    {
        get
        {
            PropriedadeAcessada(RO_QTENTMES);
            return _qtentmes;
        }
        set
        {
            PropriedadeModificada(RO_QTENTMES, value);
            _qtentmes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtest
    {
        get
        {
            PropriedadeAcessada(RO_QTEST);
            return _qtest;
        }
        set
        {
            PropriedadeModificada(RO_QTEST, value);
            _qtest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtestant
    {
        get
        {
            PropriedadeAcessada(RO_QTESTANT);
            return _qtestant;
        }
        set
        {
            PropriedadeModificada(RO_QTESTANT, value);
            _qtestant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtestger
    {
        get
        {
            PropriedadeAcessada(RO_QTESTGER);
            return _qtestger;
        }
        set
        {
            PropriedadeModificada(RO_QTESTGER, value);
            _qtestger = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtestornoproduzdia
    {
        get
        {
            PropriedadeAcessada(RO_QTESTORNOPRODUZDIA);
            return _qtestornoproduzdia;
        }
        set
        {
            PropriedadeModificada(RO_QTESTORNOPRODUZDIA, value);
            _qtestornoproduzdia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtestornoproduzmes
    {
        get
        {
            PropriedadeAcessada(RO_QTESTORNOPRODUZMES);
            return _qtestornoproduzmes;
        }
        set
        {
            PropriedadeModificada(RO_QTESTORNOPRODUZMES, value);
            _qtestornoproduzmes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtgirocurvatura
    {
        get
        {
            PropriedadeAcessada(RO_QTGIROCURVATURA);
            return _qtgirocurvatura;
        }
        set
        {
            PropriedadeModificada(RO_QTGIROCURVATURA, value);
            _qtgirocurvatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtgirocurvaturaant
    {
        get
        {
            PropriedadeAcessada(RO_QTGIROCURVATURAANT);
            return _qtgirocurvaturaant;
        }
        set
        {
            PropriedadeModificada(RO_QTGIROCURVATURAANT, value);
            _qtgirocurvaturaant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtgirodia
    {
        get
        {
            PropriedadeAcessada(RO_QTGIRODIA);
            return _qtgirodia;
        }
        set
        {
            PropriedadeModificada(RO_QTGIRODIA, value);
            _qtgirodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtindeniz
    {
        get
        {
            PropriedadeAcessada(RO_QTINDENIZ);
            return _qtindeniz;
        }
        set
        {
            PropriedadeModificada(RO_QTINDENIZ, value);
            _qtindeniz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Qtloja
    {
        get
        {
            PropriedadeAcessada(RO_QTLOJA);
            return _qtloja;
        }
        set
        {
            PropriedadeModificada(RO_QTLOJA, value);
            _qtloja = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtpedida
    {
        get
        {
            PropriedadeAcessada(RO_QTPEDIDA);
            return _qtpedida;
        }
        set
        {
            PropriedadeModificada(RO_QTPEDIDA, value);
            _qtpedida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtpendente
    {
        get
        {
            PropriedadeAcessada(RO_QTPENDENTE);
            return _qtpendente;
        }
        set
        {
            PropriedadeModificada(RO_QTPENDENTE, value);
            _qtpendente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtperdadia
    {
        get
        {
            PropriedadeAcessada(RO_QTPERDADIA);
            return _qtperdadia;
        }
        set
        {
            PropriedadeModificada(RO_QTPERDADIA, value);
            _qtperdadia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtperdames
    {
        get
        {
            PropriedadeAcessada(RO_QTPERDAMES);
            return _qtperdames;
        }
        set
        {
            PropriedadeModificada(RO_QTPERDAMES, value);
            _qtperdames = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtproduzidadia
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODUZIDADIA);
            return _qtproduzidadia;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODUZIDADIA, value);
            _qtproduzidadia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtproduzidames
    {
        get
        {
            PropriedadeAcessada(RO_QTPRODUZIDAMES);
            return _qtproduzidames;
        }
        set
        {
            PropriedadeModificada(RO_QTPRODUZIDAMES, value);
            _qtproduzidames = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtrequisicao
    {
        get
        {
            PropriedadeAcessada(RO_QTREQUISICAO);
            return _qtrequisicao;
        }
        set
        {
            PropriedadeModificada(RO_QTREQUISICAO, value);
            _qtrequisicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qtreserv
    {
        get
        {
            PropriedadeAcessada(RO_QTRESERV);
            return _qtreserv;
        }
        set
        {
            PropriedadeModificada(RO_QTRESERV, value);
            _qtreserv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtreservmed
    {
        get
        {
            PropriedadeAcessada(RO_QTRESERVMED);
            return _qtreservmed;
        }
        set
        {
            PropriedadeModificada(RO_QTRESERVMED, value);
            _qtreservmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 8)]
    public decimal? Qttransito
    {
        get
        {
            PropriedadeAcessada(RO_QTTRANSITO);
            return _qttransito;
        }
        set
        {
            PropriedadeModificada(RO_QTTRANSITO, value);
            _qttransito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtultent
    {
        get
        {
            PropriedadeAcessada(RO_QTULTENT);
            return _qtultent;
        }
        set
        {
            PropriedadeModificada(RO_QTULTENT, value);
            _qtultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtultinvent
    {
        get
        {
            PropriedadeAcessada(RO_QTULTINVENT);
            return _qtultinvent;
        }
        set
        {
            PropriedadeModificada(RO_QTULTINVENT, value);
            _qtultinvent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendaperdida
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDAPERDIDA);
            return _qtvendaperdida;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDAPERDIDA, value);
            _qtvendaperdida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvenddia
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDDIA);
            return _qtvenddia;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDDIA, value);
            _qtvenddia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendmes
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDMES);
            return _qtvendmes;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDMES, value);
            _qtvendmes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendmes1
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDMES1);
            return _qtvendmes1;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDMES1, value);
            _qtvendmes1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendmes2
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDMES2);
            return _qtvendmes2;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDMES2, value);
            _qtvendmes2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendmes3
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDMES3);
            return _qtvendmes3;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDMES3, value);
            _qtvendmes3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendsemana
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDSEMANA);
            return _qtvendsemana;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDSEMANA, value);
            _qtvendsemana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendsemana1
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDSEMANA1);
            return _qtvendsemana1;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDSEMANA1, value);
            _qtvendsemana1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendsemana2
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDSEMANA2);
            return _qtvendsemana2;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDSEMANA2, value);
            _qtvendsemana2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtvendsemana3
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDSEMANA3);
            return _qtvendsemana3;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDSEMANA3, value);
            _qtvendsemana3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseivaultent
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEIVAULTENT);
            return _redbaseivaultent;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEIVAULTENT, value);
            _redbaseivaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Redbaseivaultenttab
    {
        get
        {
            PropriedadeAcessada(RO_REDBASEIVAULTENTTAB);
            return _redbaseivaultenttab;
        }
        set
        {
            PropriedadeModificada(RO_REDBASEIVAULTENTTAB, value);
            _redbaseivaultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalanc
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANC);
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANC, value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rua
    {
        get
        {
            PropriedadeAcessada(RO_RUA);
            return _rua;
        }
        set
        {
            PropriedadeModificada(RO_RUA, value);
            _rua = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Ruacx
    {
        get
        {
            PropriedadeAcessada(RO_RUACX);
            return _ruacx;
        }
        set
        {
            PropriedadeModificada(RO_RUACX, value);
            _ruacx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stbcr
    {
        get
        {
            PropriedadeAcessada(RO_STBCR);
            return _stbcr;
        }
        set
        {
            PropriedadeModificada(RO_STBCR, value);
            _stbcr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultent
    {
        get
        {
            PropriedadeAcessada(RO_VALORULTENT);
            return _valorultent;
        }
        set
        {
            PropriedadeModificada(RO_VALORULTENT, value);
            _valorultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorultentmed
    {
        get
        {
            PropriedadeAcessada(RO_VALORULTENTMED);
            return _valorultentmed;
        }
        set
        {
            PropriedadeModificada(RO_VALORULTENTMED, value);
            _valorultentmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcustodiafin
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTODIAFIN);
            return _vlcustodiafin;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTODIAFIN, value);
            _vlcustodiafin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcustodiareal
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTODIAREAL);
            return _vlcustodiareal;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTODIAREAL, value);
            _vlcustodiareal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcustomesfin
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOMESFIN);
            return _vlcustomesfin;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOMESFIN, value);
            _vlcustomesfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustomesfinant
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOMESFINANT);
            return _vlcustomesfinant;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOMESFINANT, value);
            _vlcustomesfinant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcustomesreal
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOMESREAL);
            return _vlcustomesreal;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOMESREAL, value);
            _vlcustomesreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlcustomesrealant
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTOMESREALANT);
            return _vlcustomesrealant;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTOMESREALANT, value);
            _vlcustomesrealant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteconhecultent
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETECONHECULTENT);
            return _vlfreteconhecultent;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETECONHECULTENT, value);
            _vlfreteconhecultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfreteconhecultenttab
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETECONHECULTENTTAB);
            return _vlfreteconhecultenttab;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETECONHECULTENTTAB, value);
            _vlfreteconhecultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstguiaultent
    {
        get
        {
            PropriedadeAcessada(RO_VLSTGUIAULTENT);
            return _vlstguiaultent;
        }
        set
        {
            PropriedadeModificada(RO_VLSTGUIAULTENT, value);
            _vlstguiaultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstguiaultenttab
    {
        get
        {
            PropriedadeAcessada(RO_VLSTGUIAULTENTTAB);
            return _vlstguiaultenttab;
        }
        set
        {
            PropriedadeModificada(RO_VLSTGUIAULTENTTAB, value);
            _vlstguiaultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstultent
    {
        get
        {
            PropriedadeAcessada(RO_VLSTULTENT);
            return _vlstultent;
        }
        set
        {
            PropriedadeModificada(RO_VLSTULTENT, value);
            _vlstultent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlstultenttab
    {
        get
        {
            PropriedadeAcessada(RO_VLSTULTENTTAB);
            return _vlstultenttab;
        }
        set
        {
            PropriedadeModificada(RO_VLSTULTENTTAB, value);
            _vlstultenttab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultentcontsemst
    {
        get
        {
            PropriedadeAcessada(RO_VLULTENTCONTSEMST);
            return _vlultentcontsemst;
        }
        set
        {
            PropriedadeModificada(RO_VLULTENTCONTSEMST, value);
            _vlultentcontsemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlultpcompra
    {
        get
        {
            PropriedadeAcessada(RO_VLULTPCOMPRA);
            return _vlultpcompra;
        }
        set
        {
            PropriedadeModificada(RO_VLULTPCOMPRA, value);
            _vlultpcompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvenddia
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDDIA);
            return _vlvenddia;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDDIA, value);
            _vlvenddia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvenddiareal
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDDIAREAL);
            return _vlvenddiareal;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDDIAREAL, value);
            _vlvenddiareal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvendmes
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDMES);
            return _vlvendmes;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDMES, value);
            _vlvendmes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlvendmesant
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDMESANT);
            return _vlvendmesant;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDMESANT, value);
            _vlvendmesant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvendmesreal
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDMESREAL);
            return _vlvendmesreal;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDMESREAL, value);
            _vlvendmesreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
    public decimal? Qtfrenteloja
    {
        get
        {
            PropriedadeAcessada(RO_QTFRENTELOJA);
            return _qtfrenteloja;
        }
        set
        {
            PropriedadeModificada(RO_QTFRENTELOJA, value);
            _qtfrenteloja = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Numtransultentst
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSULTENTST);
            return _numtransultentst;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSULTENTST, value);
            _numtransultentst = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCEST";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqicms1ultent = AlterarTipo<decimal?>(leitor["Aliqicms1ultent"]);
        _aliqicms1ultenttab = AlterarTipo<decimal?>(leitor["Aliqicms1ultenttab"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2ultent = AlterarTipo<decimal?>(leitor["Aliqicms2ultent"]);
        _aliqicms2ultenttab = AlterarTipo<decimal?>(leitor["Aliqicms2ultenttab"]);
        _apto = AlterarTipo<decimal?>(leitor["Apto"]);
        _aptocx = AlterarTipo<decimal?>(leitor["Aptocx"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _basebcr = AlterarTipo<decimal?>(leitor["Basebcr"]);
        _baseicmsultent = AlterarTipo<decimal?>(leitor["Baseicmsultent"]);
        _baseicmsultenttab = AlterarTipo<decimal?>(leitor["Baseicmsultenttab"]);
        _coddevol = AlterarTipo<decimal?>(leitor["Coddevol"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _corredor = AlterarTipo<decimal?>(leitor["Corredor"]);
        _custocont = AlterarTipo<decimal?>(leitor["Custocont"]);
        _custodolar = AlterarTipo<decimal?>(leitor["Custodolar"]);
        _custofin = AlterarTipo<decimal?>(leitor["Custofin"]);
        _custofornec = AlterarTipo<decimal?>(leitor["Custofornec"]);
        _custonfsemst = AlterarTipo<decimal?>(leitor["Custonfsemst"]);
        _custonfsemstguiaultent = AlterarTipo<decimal?>(leitor["Custonfsemstguiaultent"]);
        _custonfsemstguiaultenttab = AlterarTipo<decimal?>(leitor["Custonfsemstguiaultenttab"]);
        _custonfsemsttab = AlterarTipo<decimal?>(leitor["Custonfsemsttab"]);
        _custoproximacompra = AlterarTipo<decimal?>(leitor["Custoproximacompra"]);
        _custoreal = AlterarTipo<decimal?>(leitor["Custoreal"]);
        _custorealliq = AlterarTipo<decimal?>(leitor["Custorealliq"]);
        _custorealsemst = AlterarTipo<decimal?>(leitor["Custorealsemst"]);
        _custorep = AlterarTipo<decimal?>(leitor["Custorep"]);
        _custoultent = AlterarTipo<decimal?>(leitor["Custoultent"]);
        _custoultentant = AlterarTipo<decimal?>(leitor["Custoultentant"]);
        _custoultentcont = AlterarTipo<decimal?>(leitor["Custoultentcont"]);
        _custoultentfin = AlterarTipo<decimal?>(leitor["Custoultentfin"]);
        _custoultentliq = AlterarTipo<decimal?>(leitor["Custoultentliq"]);
        _custoultentmed = AlterarTipo<decimal?>(leitor["Custoultentmed"]);
        _custoultpedcompra = AlterarTipo<decimal?>(leitor["Custoultpedcompra"]);
        _dtalteracao1107 = AlterarTipo<DateTime?>(leitor["Dtalteracao1107"]);
        _dtemissaoultent = AlterarTipo<DateTime?>(leitor["Dtemissaoultent"]);
        _dtprimcompra = AlterarTipo<DateTime?>(leitor["Dtprimcompra"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _dtultdesdobra = AlterarTipo<DateTime?>(leitor["Dtultdesdobra"]);
        _dtultent = AlterarTipo<DateTime?>(leitor["Dtultent"]);
        _dtultfat = AlterarTipo<DateTime?>(leitor["Dtultfat"]);
        _dtultinvent = AlterarTipo<DateTime?>(leitor["Dtultinvent"]);
        _dtultpedcompra = AlterarTipo<DateTime?>(leitor["Dtultpedcompra"]);
        _dtultsaida = AlterarTipo<DateTime?>(leitor["Dtultsaida"]);
        _estideal = AlterarTipo<decimal?>(leitor["Estideal"]);
        _estmax = AlterarTipo<decimal?>(leitor["Estmax"]);
        _estmin = AlterarTipo<decimal?>(leitor["Estmin"]);
        _fimestoque = AlterarTipo<string>(leitor["Fimestoque"]);
        _ivaultent = AlterarTipo<decimal?>(leitor["Ivaultent"]);
        _ivaultenttab = AlterarTipo<decimal?>(leitor["Ivaultenttab"]);
        _modulo = AlterarTipo<decimal?>(leitor["Modulo"]);
        _modulocx = AlterarTipo<decimal?>(leitor["Modulocx"]);
        _motivobloqestoque = AlterarTipo<string>(leitor["Motivobloqestoque"]);
        _numero = AlterarTipo<decimal?>(leitor["Numero"]);
        _numerocx = AlterarTipo<decimal?>(leitor["Numerocx"]);
        _numnotaultent = AlterarTipo<decimal?>(leitor["Numnotaultent"]);
        _numtransentultent = AlterarTipo<decimal?>(leitor["Numtransentultent"]);
        _pcompraultent = AlterarTipo<decimal?>(leitor["Pcompraultent"]);
        _pcustoant = AlterarTipo<decimal?>(leitor["Pcustoant"]);
        _percaliqextguiaultent = AlterarTipo<decimal?>(leitor["Percaliqextguiaultent"]);
        _percaliqextguiaultenttab = AlterarTipo<decimal?>(leitor["Percaliqextguiaultenttab"]);
        _percevolucaovenda = AlterarTipo<decimal?>(leitor["Percevolucaovenda"]);
        _percicmsfretefobstultent = AlterarTipo<decimal?>(leitor["Percicmsfretefobstultent"]);
        _percicmsfretefobstultenttab = AlterarTipo<decimal?>(leitor["Percicmsfretefobstultenttab"]);
        _percmvaorigtab = AlterarTipo<decimal?>(leitor["Percmvaorigtab"]);
        _percmvaorigultent = AlterarTipo<decimal?>(leitor["Percmvaorigultent"]);
        _qtbloqtransf = AlterarTipo<decimal?>(leitor["Qtbloqtransf"]);
        _qtbloqueada = AlterarTipo<decimal?>(leitor["Qtbloqueada"]);
        _qtdevolmes = AlterarTipo<decimal?>(leitor["Qtdevolmes"]);
        _qtdevolmes1 = AlterarTipo<decimal?>(leitor["Qtdevolmes1"]);
        _qtdevolmes2 = AlterarTipo<decimal?>(leitor["Qtdevolmes2"]);
        _qtdevolmes3 = AlterarTipo<decimal?>(leitor["Qtdevolmes3"]);
        _qtentdia = AlterarTipo<decimal?>(leitor["Qtentdia"]);
        _qtentmes = AlterarTipo<decimal?>(leitor["Qtentmes"]);
        _qtest = AlterarTipo<decimal?>(leitor["Qtest"]);
        _qtestant = AlterarTipo<decimal?>(leitor["Qtestant"]);
        _qtestger = AlterarTipo<decimal?>(leitor["Qtestger"]);
        _qtestornoproduzdia = AlterarTipo<decimal?>(leitor["Qtestornoproduzdia"]);
        _qtestornoproduzmes = AlterarTipo<decimal?>(leitor["Qtestornoproduzmes"]);
        _qtgirocurvatura = AlterarTipo<decimal?>(leitor["Qtgirocurvatura"]);
        _qtgirocurvaturaant = AlterarTipo<decimal?>(leitor["Qtgirocurvaturaant"]);
        _qtgirodia = AlterarTipo<decimal?>(leitor["Qtgirodia"]);
        _qtindeniz = AlterarTipo<decimal?>(leitor["Qtindeniz"]);
        _qtloja = AlterarTipo<decimal?>(leitor["Qtloja"]);
        _qtpedida = AlterarTipo<decimal?>(leitor["Qtpedida"]);
        _qtpendente = AlterarTipo<decimal?>(leitor["Qtpendente"]);
        _qtperdadia = AlterarTipo<decimal?>(leitor["Qtperdadia"]);
        _qtperdames = AlterarTipo<decimal?>(leitor["Qtperdames"]);
        _qtproduzidadia = AlterarTipo<decimal?>(leitor["Qtproduzidadia"]);
        _qtproduzidames = AlterarTipo<decimal?>(leitor["Qtproduzidames"]);
        _qtrequisicao = AlterarTipo<decimal?>(leitor["Qtrequisicao"]);
        _qtreserv = AlterarTipo<decimal?>(leitor["Qtreserv"]);
        _qtreservmed = AlterarTipo<decimal?>(leitor["Qtreservmed"]);
        _qttransito = AlterarTipo<decimal?>(leitor["Qttransito"]);
        _qtultent = AlterarTipo<decimal?>(leitor["Qtultent"]);
        _qtultinvent = AlterarTipo<decimal?>(leitor["Qtultinvent"]);
        _qtvendaperdida = AlterarTipo<decimal?>(leitor["Qtvendaperdida"]);
        _qtvenddia = AlterarTipo<decimal?>(leitor["Qtvenddia"]);
        _qtvendmes = AlterarTipo<decimal?>(leitor["Qtvendmes"]);
        _qtvendmes1 = AlterarTipo<decimal?>(leitor["Qtvendmes1"]);
        _qtvendmes2 = AlterarTipo<decimal?>(leitor["Qtvendmes2"]);
        _qtvendmes3 = AlterarTipo<decimal?>(leitor["Qtvendmes3"]);
        _qtvendsemana = AlterarTipo<decimal?>(leitor["Qtvendsemana"]);
        _qtvendsemana1 = AlterarTipo<decimal?>(leitor["Qtvendsemana1"]);
        _qtvendsemana2 = AlterarTipo<decimal?>(leitor["Qtvendsemana2"]);
        _qtvendsemana3 = AlterarTipo<decimal?>(leitor["Qtvendsemana3"]);
        _redbaseivaultent = AlterarTipo<decimal?>(leitor["Redbaseivaultent"]);
        _redbaseivaultenttab = AlterarTipo<decimal?>(leitor["Redbaseivaultenttab"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _rua = AlterarTipo<decimal?>(leitor["Rua"]);
        _ruacx = AlterarTipo<decimal?>(leitor["Ruacx"]);
        _stbcr = AlterarTipo<decimal?>(leitor["Stbcr"]);
        _valorultent = AlterarTipo<decimal?>(leitor["Valorultent"]);
        _valorultentmed = AlterarTipo<decimal?>(leitor["Valorultentmed"]);
        _vlcustodiafin = AlterarTipo<decimal?>(leitor["Vlcustodiafin"]);
        _vlcustodiareal = AlterarTipo<decimal?>(leitor["Vlcustodiareal"]);
        _vlcustomesfin = AlterarTipo<decimal?>(leitor["Vlcustomesfin"]);
        _vlcustomesfinant = AlterarTipo<decimal?>(leitor["Vlcustomesfinant"]);
        _vlcustomesreal = AlterarTipo<decimal?>(leitor["Vlcustomesreal"]);
        _vlcustomesrealant = AlterarTipo<decimal?>(leitor["Vlcustomesrealant"]);
        _vlfreteconhecultent = AlterarTipo<decimal?>(leitor["Vlfreteconhecultent"]);
        _vlfreteconhecultenttab = AlterarTipo<decimal?>(leitor["Vlfreteconhecultenttab"]);
        _vlstguiaultent = AlterarTipo<decimal?>(leitor["Vlstguiaultent"]);
        _vlstguiaultenttab = AlterarTipo<decimal?>(leitor["Vlstguiaultenttab"]);
        _vlstultent = AlterarTipo<decimal?>(leitor["Vlstultent"]);
        _vlstultenttab = AlterarTipo<decimal?>(leitor["Vlstultenttab"]);
        _vlultentcontsemst = AlterarTipo<decimal?>(leitor["Vlultentcontsemst"]);
        _vlultpcompra = AlterarTipo<decimal?>(leitor["Vlultpcompra"]);
        _vlvenddia = AlterarTipo<decimal?>(leitor["Vlvenddia"]);
        _vlvenddiareal = AlterarTipo<decimal?>(leitor["Vlvenddiareal"]);
        _vlvendmes = AlterarTipo<decimal?>(leitor["Vlvendmes"]);
        _vlvendmesant = AlterarTipo<decimal?>(leitor["Vlvendmesant"]);
        _vlvendmesreal = AlterarTipo<decimal?>(leitor["Vlvendmesreal"]);
        _qtfrenteloja = AlterarTipo<decimal?>(leitor["Qtfrenteloja"]);
        _numtransultentst = AlterarTipo<decimal?>(leitor["Numtransultentst"]);
    }

}