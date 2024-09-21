

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLANC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ADIANTAMENTO = "Adiantamento";

    private string _adiantamento;

    private static readonly string RO_AGENDAMENTO = "Agendamento";

    private string _agendamento;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_BOLETO = "Boleto";

    private string _boleto;

    private static readonly string RO_CODCOMPRADOR = "Codcomprador";

    private decimal? _codcomprador;

    private static readonly string RO_CODCONTA = "Codconta";

    private decimal _codconta;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFORNEC = "Codfornec";

    private decimal _codfornec;

    private static readonly string RO_CODFORNECPRINC = "Codfornecprinc";

    private decimal? _codfornecprinc;

    private static readonly string RO_CODFUNCAUTOR = "Codfuncautor";

    private decimal? _codfuncautor;

    private static readonly string RO_CODFUNCBAIXA = "Codfuncbaixa";

    private decimal? _codfuncbaixa;

    private static readonly string RO_CODFUNCESTORNOBAIXA = "Codfuncestornobaixa";

    private decimal? _codfuncestornobaixa;

    private static readonly string RO_CODFUNCRECLASSIFIC = "Codfuncreclassific";

    private decimal? _codfuncreclassific;

    private static readonly string RO_CODFUNCULTALTER = "Codfuncultalter";

    private decimal? _codfuncultalter;

    private static readonly string RO_CODPROJETO = "Codprojeto";

    private decimal? _codprojeto;

    private static readonly string RO_CODRECEITA = "Codreceita";

    private decimal? _codreceita;

    private static readonly string RO_CODROTINAALT = "Codrotinaalt";

    private string _codrotinaalt;

    private static readonly string RO_CODROTINABAIXA = "Codrotinabaixa";

    private decimal? _codrotinabaixa;

    private static readonly string RO_CODROTINACAD = "Codrotinacad";

    private string _codrotinacad;

    private static readonly string RO_COTACAO = "Cotacao";

    private decimal? _cotacao;

    private static readonly string RO_COTACAOBAIXA = "Cotacaobaixa";

    private decimal? _cotacaobaixa;

    private static readonly string RO_DESCONTOFIN = "Descontofin";

    private decimal? _descontofin;

    private static readonly string RO_DTAGENDAMENTO = "Dtagendamento";

    private DateTime? _dtagendamento;

    private static readonly string RO_DTASSINATURA = "Dtassinatura";

    private DateTime? _dtassinatura;

    private static readonly string RO_DTAUTOR = "Dtautor";

    private DateTime? _dtautor;

    private static readonly string RO_DTBLOQ = "Dtbloq";

    private DateTime? _dtbloq;

    private static readonly string RO_DTBORDER = "Dtborder";

    private DateTime? _dtborder;

    private static readonly string RO_DTCHEQ = "Dtcheq";

    private DateTime? _dtcheq;

    private static readonly string RO_DTCOMPETENCIA = "Dtcompetencia";

    private DateTime? _dtcompetencia;

    private static readonly string RO_DTCOTACAO = "Dtcotacao";

    private DateTime? _dtcotacao;

    private static readonly string RO_DTDESD = "Dtdesd";

    private DateTime? _dtdesd;

    private static readonly string RO_DTEMISSAO = "Dtemissao";

    private DateTime? _dtemissao;

    private static readonly string RO_DTESTORNOBAIXA = "Dtestornobaixa";

    private DateTime? _dtestornobaixa;

    private static readonly string RO_DTLANC = "Dtlanc";

    private DateTime _dtlanc;

    private static readonly string RO_DTMOEDA = "Dtmoeda";

    private string _dtmoeda;

    private static readonly string RO_DTPAGADIANTFOR = "Dtpagadiantfor";

    private DateTime? _dtpagadiantfor;

    private static readonly string RO_DTPAGTO = "Dtpagto";

    private DateTime? _dtpagto;

    private static readonly string RO_DTPRORROG = "Dtprorrog";

    private DateTime? _dtprorrog;

    private static readonly string RO_DTRECLASSIFIC = "Dtreclassific";

    private DateTime? _dtreclassific;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_DTVENC = "Dtvenc";

    private DateTime _dtvenc;

    private static readonly string RO_DUPLIC = "Duplic";

    private string _duplic;

    private static readonly string RO_DVAG = "Dvag";

    private string _dvag;

    private static readonly string RO_FORMAPGTO = "Formapgto";

    private string _formapgto;

    private static readonly string RO_FROTA_CODPRACA = "Frota_Codpraca";

    private decimal? _frota_codpraca;

    private static readonly string RO_FROTA_CODVEICULO = "Frota_Codveiculo";

    private decimal? _frota_codveiculo;

    private static readonly string RO_FROTA_COMISSAO = "Frota_Comissao";

    private decimal? _frota_comissao;

    private static readonly string RO_FROTA_DTABASTECE = "Frota_Dtabastece";

    private DateTime? _frota_dtabastece;

    private static readonly string RO_FROTA_KMABASTECE = "Frota_Kmabastece";

    private decimal? _frota_kmabastece;

    private static readonly string RO_FROTA_NUMCAR = "Frota_Numcar";

    private decimal? _frota_numcar;

    private static readonly string RO_FROTA_PESO = "Frota_Peso";

    private decimal? _frota_peso;

    private static readonly string RO_FROTA_QTLITROS = "Frota_Qtlitros";

    private decimal? _frota_qtlitros;

    private static readonly string RO_FUNCBLOQ = "Funcbloq";

    private decimal? _funcbloq;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HISTORICO2 = "Historico2";

    private string _historico2;

    private static readonly string RO_IDCONTROLEEMBARQUE = "Idcontroleembarque";

    private string _idcontroleembarque;

    private static readonly string RO_INDICE = "Indice";

    private string _indice;

    private static readonly string RO_LOCALIZACAO = "Localizacao";

    private string _localizacao;

    private static readonly string RO_MOEDA = "Moeda";

    private string _moeda;

    private static readonly string RO_MOEDAESTRANGEIRA = "Moedaestrangeira";

    private decimal? _moedaestrangeira;

    private static readonly string RO_NFSERVICO = "Nfservico";

    private string _nfservico;

    private static readonly string RO_NOMEFUNC = "Nomefunc";

    private string _nomefunc;

    private static readonly string RO_NUMAGDESTDOC = "Numagdestdoc";

    private decimal? _numagdestdoc;

    private static readonly string RO_NUMAGDESTDOC2 = "Numagdestdoc2";

    private decimal? _numagdestdoc2;

    private static readonly string RO_NUMBANCO = "Numbanco";

    private decimal? _numbanco;

    private static readonly string RO_NUMBCODESTDOC = "Numbcodestdoc";

    private decimal? _numbcodestdoc;

    private static readonly string RO_NUMBORDERO = "Numbordero";

    private decimal? _numbordero;

    private static readonly string RO_NUMCCDESTDOC = "Numccdestdoc";

    private decimal? _numccdestdoc;

    private static readonly string RO_NUMCHEQUE = "Numcheque";

    private string _numcheque;

    private static readonly string RO_NUMCHEQUE2 = "Numcheque2";

    private decimal? _numcheque2;

    private static readonly string RO_NUMCODBARRA = "Numcodbarra";

    private string _numcodbarra;

    private static readonly string RO_NUMCONTRATOCAMBIO = "Numcontratocambio";

    private string _numcontratocambio;

    private static readonly string RO_NUMDIIMPORTACAO = "Numdiimportacao";

    private string _numdiimportacao;

    private static readonly string RO_NUMDVDESTDOC = "Numdvdestdoc";

    private string _numdvdestdoc;

    private static readonly string RO_NUMNEGOCIACAO = "Numnegociacao";

    private decimal? _numnegociacao;

    private static readonly string RO_NUMNOTA = "Numnota";

    private decimal _numnota;

    private static readonly string RO_NUMNOTADEV = "Numnotadev";

    private decimal? _numnotadev;

    private static readonly string RO_NUMSEQBORDERO = "Numseqbordero";

    private decimal? _numseqbordero;

    private static readonly string RO_NUMTAB = "Numtab";

    private decimal? _numtab;

    private static readonly string RO_NUMTRANS = "Numtrans";

    private decimal? _numtrans;

    private static readonly string RO_NUMTRANSADIANTFOR = "Numtransadiantfor";

    private decimal? _numtransadiantfor;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSENTNF = "Numtransentnf";

    private decimal? _numtransentnf;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal? _numtransvenda;

    private static readonly string RO_NUMVIA = "Numvia";

    private decimal? _numvia;

    private static readonly string RO_NUMVIASFICHACP = "Numviasfichacp";

    private decimal? _numviasfichacp;

    private static readonly string RO_OBSBLOQ = "Obsbloq";

    private string _obsbloq;

    private static readonly string RO_PAGTONOMEDOCLIENTE = "Pagtonomedocliente";

    private string _pagtonomedocliente;

    private static readonly string RO_PERCDESCFINREAL = "Percdescfinreal";

    private decimal? _percdescfinreal;

    private static readonly string RO_PERCRECEITABRUTA = "Percreceitabruta";

    private decimal? _percreceitabruta;

    private static readonly string RO_PORTADORCHEQUE = "Portadorcheque";

    private string _portadorcheque;

    private static readonly string RO_PREST = "Prest";

    private string _prest;

    private static readonly string RO_PRORROG = "Prorrog";

    private decimal? _prorrog;

    private static readonly string RO_RECNUM = "Recnum";

    private decimal _recnum;

    private static readonly string RO_RECNUMPRINC = "Recnumprinc";

    private decimal? _recnumprinc;

    private static readonly string RO_TIPOLANC = "Tipolanc";

    private string _tipolanc;

    private static readonly string RO_TIPOPAGTO = "Tipopagto";

    private string _tipopagto;

    private static readonly string RO_TIPOPARCEIRO = "Tipoparceiro";

    private string _tipoparceiro;

    private static readonly string RO_TXPERM = "Txperm";

    private decimal? _txperm;

    private static readonly string RO_VALOR = "Valor";

    private decimal _valor;

    private static readonly string RO_VALORDEV = "Valordev";

    private decimal? _valordev;

    private static readonly string RO_VALORMOEDAESTRANGEIRA = "Valormoedaestrangeira";

    private decimal? _valormoedaestrangeira;

    private static readonly string RO_VLCOFINS = "Vlcofins";

    private decimal? _vlcofins;

    private static readonly string RO_VLCSRF = "Vlcsrf";

    private decimal? _vlcsrf;

    private static readonly string RO_VLINSS = "Vlinss";

    private decimal? _vlinss;

    private static readonly string RO_VLIRRF = "Vlirrf";

    private decimal? _vlirrf;

    private static readonly string RO_VLISS = "Vliss";

    private decimal? _vliss;

    private static readonly string RO_VLOUTRAS = "Vloutras";

    private decimal? _vloutras;

    private static readonly string RO_VLPIS = "Vlpis";

    private decimal? _vlpis;

    private static readonly string RO_VLSESTSENAT = "Vlsestsenat";

    private decimal? _vlsestsenat;

    private static readonly string RO_VLVARIACAOCAMBIAL = "Vlvariacaocambial";

    private decimal? _vlvariacaocambial;

    private static readonly string RO_VPAGO = "Vpago";

    private decimal? _vpago;

    private static readonly string RO_VPAGOBORDERO = "Vpagobordero";

    private decimal? _vpagobordero;

    private static readonly string RO_VRECEITABRUTA = "Vreceitabruta";

    private decimal? _vreceitabruta;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Adiantamento
    {
        get
        {
            PropriedadeAcessada(RO_ADIANTAMENTO);
            return _adiantamento;
        }
        set
        {
            PropriedadeModificada(RO_ADIANTAMENTO, value);
            _adiantamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agendamento
    {
        get
        {
            PropriedadeAcessada(RO_AGENDAMENTO);
            return _agendamento;
        }
        set
        {
            PropriedadeModificada(RO_AGENDAMENTO, value);
            _agendamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Boleto
    {
        get
        {
            PropriedadeAcessada(RO_BOLETO);
            return _boleto;
        }
        set
        {
            PropriedadeModificada(RO_BOLETO, value);
            _boleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcomprador
    {
        get
        {
            PropriedadeAcessada(RO_CODCOMPRADOR);
            return _codcomprador;
        }
        set
        {
            PropriedadeModificada(RO_CODCOMPRADOR, value);
            _codcomprador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Codconta
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTA);
            return _codconta;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTA, value);
            _codconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNEC);
            return _codfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNEC, value);
            _codfornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfornecprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECPRINC);
            return _codfornecprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECPRINC, value);
            _codfornecprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncautor
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCAUTOR);
            return _codfuncautor;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCAUTOR, value);
            _codfuncautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncbaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCBAIXA);
            return _codfuncbaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCBAIXA, value);
            _codfuncbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncestornobaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCESTORNOBAIXA);
            return _codfuncestornobaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCESTORNOBAIXA, value);
            _codfuncestornobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncreclassific
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCRECLASSIFIC);
            return _codfuncreclassific;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCRECLASSIFIC, value);
            _codfuncreclassific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCULTALTER);
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCULTALTER, value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprojeto
    {
        get
        {
            PropriedadeAcessada(RO_CODPROJETO);
            return _codprojeto;
        }
        set
        {
            PropriedadeModificada(RO_CODPROJETO, value);
            _codprojeto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codreceita
    {
        get
        {
            PropriedadeAcessada(RO_CODRECEITA);
            return _codreceita;
        }
        set
        {
            PropriedadeModificada(RO_CODRECEITA, value);
            _codreceita = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codrotinaalt
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINAALT);
            return _codrotinaalt;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINAALT, value);
            _codrotinaalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrotinabaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINABAIXA);
            return _codrotinabaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINABAIXA, value);
            _codrotinabaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codrotinacad
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINACAD);
            return _codrotinacad;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINACAD, value);
            _codrotinacad = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Cotacao
    {
        get
        {
            PropriedadeAcessada(RO_COTACAO);
            return _cotacao;
        }
        set
        {
            PropriedadeModificada(RO_COTACAO, value);
            _cotacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Cotacaobaixa
    {
        get
        {
            PropriedadeAcessada(RO_COTACAOBAIXA);
            return _cotacaobaixa;
        }
        set
        {
            PropriedadeModificada(RO_COTACAOBAIXA, value);
            _cotacaobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Descontofin
    {
        get
        {
            PropriedadeAcessada(RO_DESCONTOFIN);
            return _descontofin;
        }
        set
        {
            PropriedadeModificada(RO_DESCONTOFIN, value);
            _descontofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtagendamento
    {
        get
        {
            PropriedadeAcessada(RO_DTAGENDAMENTO);
            return _dtagendamento;
        }
        set
        {
            PropriedadeModificada(RO_DTAGENDAMENTO, value);
            _dtagendamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtassinatura
    {
        get
        {
            PropriedadeAcessada(RO_DTASSINATURA);
            return _dtassinatura;
        }
        set
        {
            PropriedadeModificada(RO_DTASSINATURA, value);
            _dtassinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtautor
    {
        get
        {
            PropriedadeAcessada(RO_DTAUTOR);
            return _dtautor;
        }
        set
        {
            PropriedadeModificada(RO_DTAUTOR, value);
            _dtautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloq
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQ);
            return _dtbloq;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQ, value);
            _dtbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtborder
    {
        get
        {
            PropriedadeAcessada(RO_DTBORDER);
            return _dtborder;
        }
        set
        {
            PropriedadeModificada(RO_DTBORDER, value);
            _dtborder = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcheq
    {
        get
        {
            PropriedadeAcessada(RO_DTCHEQ);
            return _dtcheq;
        }
        set
        {
            PropriedadeModificada(RO_DTCHEQ, value);
            _dtcheq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcompetencia
    {
        get
        {
            PropriedadeAcessada(RO_DTCOMPETENCIA);
            return _dtcompetencia;
        }
        set
        {
            PropriedadeModificada(RO_DTCOMPETENCIA, value);
            _dtcompetencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcotacao
    {
        get
        {
            PropriedadeAcessada(RO_DTCOTACAO);
            return _dtcotacao;
        }
        set
        {
            PropriedadeModificada(RO_DTCOTACAO, value);
            _dtcotacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesd
    {
        get
        {
            PropriedadeAcessada(RO_DTDESD);
            return _dtdesd;
        }
        set
        {
            PropriedadeModificada(RO_DTDESD, value);
            _dtdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissao
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAO);
            return _dtemissao;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAO, value);
            _dtemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestornobaixa
    {
        get
        {
            PropriedadeAcessada(RO_DTESTORNOBAIXA);
            return _dtestornobaixa;
        }
        set
        {
            PropriedadeModificada(RO_DTESTORNOBAIXA, value);
            _dtestornobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtlanc
    {
        get
        {
            PropriedadeAcessada(RO_DTLANC);
            return _dtlanc;
        }
        set
        {
            PropriedadeModificada(RO_DTLANC, value);
            _dtlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dtmoeda
    {
        get
        {
            PropriedadeAcessada(RO_DTMOEDA);
            return _dtmoeda;
        }
        set
        {
            PropriedadeModificada(RO_DTMOEDA, value);
            _dtmoeda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagadiantfor
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGADIANTFOR);
            return _dtpagadiantfor;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGADIANTFOR, value);
            _dtpagadiantfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagto
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGTO);
            return _dtpagto;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGTO, value);
            _dtpagto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprorrog
    {
        get
        {
            PropriedadeAcessada(RO_DTPRORROG);
            return _dtprorrog;
        }
        set
        {
            PropriedadeModificada(RO_DTPRORROG, value);
            _dtprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtreclassific
    {
        get
        {
            PropriedadeAcessada(RO_DTRECLASSIFIC);
            return _dtreclassific;
        }
        set
        {
            PropriedadeModificada(RO_DTRECLASSIFIC, value);
            _dtreclassific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTER);
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTER, value);
            _dtultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtvenc
    {
        get
        {
            PropriedadeAcessada(RO_DTVENC);
            return _dtvenc;
        }
        set
        {
            PropriedadeModificada(RO_DTVENC, value);
            _dtvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Duplic
    {
        get
        {
            PropriedadeAcessada(RO_DUPLIC);
            return _duplic;
        }
        set
        {
            PropriedadeModificada(RO_DUPLIC, value);
            _duplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Dvag
    {
        get
        {
            PropriedadeAcessada(RO_DVAG);
            return _dvag;
        }
        set
        {
            PropriedadeModificada(RO_DVAG, value);
            _dvag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Formapgto
    {
        get
        {
            PropriedadeAcessada(RO_FORMAPGTO);
            return _formapgto;
        }
        set
        {
            PropriedadeModificada(RO_FORMAPGTO, value);
            _formapgto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Frota_Codpraca
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_CODPRACA);
            return _frota_codpraca;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_CODPRACA, value);
            _frota_codpraca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Frota_Codveiculo
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_CODVEICULO);
            return _frota_codveiculo;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_CODVEICULO, value);
            _frota_codveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Frota_Comissao
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_COMISSAO);
            return _frota_comissao;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_COMISSAO, value);
            _frota_comissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Frota_Dtabastece
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_DTABASTECE);
            return _frota_dtabastece;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_DTABASTECE, value);
            _frota_dtabastece = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Frota_Kmabastece
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_KMABASTECE);
            return _frota_kmabastece;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_KMABASTECE, value);
            _frota_kmabastece = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Frota_Numcar
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_NUMCAR);
            return _frota_numcar;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_NUMCAR, value);
            _frota_numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Frota_Peso
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_PESO);
            return _frota_peso;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_PESO, value);
            _frota_peso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Frota_Qtlitros
    {
        get
        {
            PropriedadeAcessada(RO_FROTA_QTLITROS);
            return _frota_qtlitros;
        }
        set
        {
            PropriedadeModificada(RO_FROTA_QTLITROS, value);
            _frota_qtlitros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Funcbloq
    {
        get
        {
            PropriedadeAcessada(RO_FUNCBLOQ);
            return _funcbloq;
        }
        set
        {
            PropriedadeModificada(RO_FUNCBLOQ, value);
            _funcbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Historico
    {
        get
        {
            PropriedadeAcessada(RO_HISTORICO);
            return _historico;
        }
        set
        {
            PropriedadeModificada(RO_HISTORICO, value);
            _historico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Historico2
    {
        get
        {
            PropriedadeAcessada(RO_HISTORICO2);
            return _historico2;
        }
        set
        {
            PropriedadeModificada(RO_HISTORICO2, value);
            _historico2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Idcontroleembarque
    {
        get
        {
            PropriedadeAcessada(RO_IDCONTROLEEMBARQUE);
            return _idcontroleembarque;
        }
        set
        {
            PropriedadeModificada(RO_IDCONTROLEEMBARQUE, value);
            _idcontroleembarque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indice
    {
        get
        {
            PropriedadeAcessada(RO_INDICE);
            return _indice;
        }
        set
        {
            PropriedadeModificada(RO_INDICE, value);
            _indice = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Localizacao
    {
        get
        {
            PropriedadeAcessada(RO_LOCALIZACAO);
            return _localizacao;
        }
        set
        {
            PropriedadeModificada(RO_LOCALIZACAO, value);
            _localizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Moeda
    {
        get
        {
            PropriedadeAcessada(RO_MOEDA);
            return _moeda;
        }
        set
        {
            PropriedadeModificada(RO_MOEDA, value);
            _moeda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Moedaestrangeira
    {
        get
        {
            PropriedadeAcessada(RO_MOEDAESTRANGEIRA);
            return _moedaestrangeira;
        }
        set
        {
            PropriedadeModificada(RO_MOEDAESTRANGEIRA, value);
            _moedaestrangeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Nfservico
    {
        get
        {
            PropriedadeAcessada(RO_NFSERVICO);
            return _nfservico;
        }
        set
        {
            PropriedadeModificada(RO_NFSERVICO, value);
            _nfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nomefunc
    {
        get
        {
            PropriedadeAcessada(RO_NOMEFUNC);
            return _nomefunc;
        }
        set
        {
            PropriedadeModificada(RO_NOMEFUNC, value);
            _nomefunc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numagdestdoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGDESTDOC);
            return _numagdestdoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGDESTDOC, value);
            _numagdestdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numagdestdoc2
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGDESTDOC2);
            return _numagdestdoc2;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGDESTDOC2, value);
            _numagdestdoc2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numbanco
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numbcodestdoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMBCODESTDOC);
            return _numbcodestdoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMBCODESTDOC, value);
            _numbcodestdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numbordero
    {
        get
        {
            PropriedadeAcessada(RO_NUMBORDERO);
            return _numbordero;
        }
        set
        {
            PropriedadeModificada(RO_NUMBORDERO, value);
            _numbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numccdestdoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCDESTDOC);
            return _numccdestdoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCDESTDOC, value);
            _numccdestdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcheque
    {
        get
        {
            PropriedadeAcessada(RO_NUMCHEQUE);
            return _numcheque;
        }
        set
        {
            PropriedadeModificada(RO_NUMCHEQUE, value);
            _numcheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcheque2
    {
        get
        {
            PropriedadeAcessada(RO_NUMCHEQUE2);
            return _numcheque2;
        }
        set
        {
            PropriedadeModificada(RO_NUMCHEQUE2, value);
            _numcheque2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Numcodbarra
    {
        get
        {
            PropriedadeAcessada(RO_NUMCODBARRA);
            return _numcodbarra;
        }
        set
        {
            PropriedadeModificada(RO_NUMCODBARRA, value);
            _numcodbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numcontratocambio
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONTRATOCAMBIO);
            return _numcontratocambio;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONTRATOCAMBIO, value);
            _numcontratocambio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numdiimportacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIIMPORTACAO);
            return _numdiimportacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIIMPORTACAO, value);
            _numdiimportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Numdvdestdoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMDVDESTDOC);
            return _numdvdestdoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMDVDESTDOC, value);
            _numdvdestdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numnegociacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMNEGOCIACAO);
            return _numnegociacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMNEGOCIACAO, value);
            _numnegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numnota
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTA);
            return _numnota;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTA, value);
            _numnota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotadev
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTADEV);
            return _numnotadev;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTADEV, value);
            _numnotadev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqbordero
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQBORDERO);
            return _numseqbordero;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQBORDERO, value);
            _numseqbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numtab
    {
        get
        {
            PropriedadeAcessada(RO_NUMTAB);
            return _numtab;
        }
        set
        {
            PropriedadeModificada(RO_NUMTAB, value);
            _numtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtrans
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANS);
            return _numtrans;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANS, value);
            _numtrans = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransadiantfor
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSADIANTFOR);
            return _numtransadiantfor;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSADIANTFOR, value);
            _numtransadiantfor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENT);
            return _numtransent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENT, value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentnf
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTNF);
            return _numtransentnf;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTNF, value);
            _numtransentnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numvia
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIA);
            return _numvia;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIA, value);
            _numvia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numviasfichacp
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASFICHACP);
            return _numviasfichacp;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASFICHACP, value);
            _numviasfichacp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsbloq
    {
        get
        {
            PropriedadeAcessada(RO_OBSBLOQ);
            return _obsbloq;
        }
        set
        {
            PropriedadeModificada(RO_OBSBLOQ, value);
            _obsbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtonomedocliente
    {
        get
        {
            PropriedadeAcessada(RO_PAGTONOMEDOCLIENTE);
            return _pagtonomedocliente;
        }
        set
        {
            PropriedadeModificada(RO_PAGTONOMEDOCLIENTE, value);
            _pagtonomedocliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Percdescfinreal
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCFINREAL);
            return _percdescfinreal;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCFINREAL, value);
            _percdescfinreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percreceitabruta
    {
        get
        {
            PropriedadeAcessada(RO_PERCRECEITABRUTA);
            return _percreceitabruta;
        }
        set
        {
            PropriedadeModificada(RO_PERCRECEITABRUTA, value);
            _percreceitabruta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Portadorcheque
    {
        get
        {
            PropriedadeAcessada(RO_PORTADORCHEQUE);
            return _portadorcheque;
        }
        set
        {
            PropriedadeModificada(RO_PORTADORCHEQUE, value);
            _portadorcheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Prest
    {
        get
        {
            PropriedadeAcessada(RO_PREST);
            return _prest;
        }
        set
        {
            PropriedadeModificada(RO_PREST, value);
            _prest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prorrog
    {
        get
        {
            PropriedadeAcessada(RO_PRORROG);
            return _prorrog;
        }
        set
        {
            PropriedadeModificada(RO_PRORROG, value);
            _prorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Recnum
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Recnumprinc
    {
        get
        {
            PropriedadeAcessada(RO_RECNUMPRINC);
            return _recnumprinc;
        }
        set
        {
            PropriedadeModificada(RO_RECNUMPRINC, value);
            _recnumprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipolanc
    {
        get
        {
            PropriedadeAcessada(RO_TIPOLANC);
            return _tipolanc;
        }
        set
        {
            PropriedadeModificada(RO_TIPOLANC, value);
            _tipolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipopagto
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPAGTO);
            return _tipopagto;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPAGTO, value);
            _tipopagto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoparceiro
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPARCEIRO);
            return _tipoparceiro;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPARCEIRO, value);
            _tipoparceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Txperm
    {
        get
        {
            PropriedadeAcessada(RO_TXPERM);
            return _txperm;
        }
        set
        {
            PropriedadeModificada(RO_TXPERM, value);
            _txperm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal Valor
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valordev
    {
        get
        {
            PropriedadeAcessada(RO_VALORDEV);
            return _valordev;
        }
        set
        {
            PropriedadeModificada(RO_VALORDEV, value);
            _valordev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valormoedaestrangeira
    {
        get
        {
            PropriedadeAcessada(RO_VALORMOEDAESTRANGEIRA);
            return _valormoedaestrangeira;
        }
        set
        {
            PropriedadeModificada(RO_VALORMOEDAESTRANGEIRA, value);
            _valormoedaestrangeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcofins
    {
        get
        {
            PropriedadeAcessada(RO_VLCOFINS);
            return _vlcofins;
        }
        set
        {
            PropriedadeModificada(RO_VLCOFINS, value);
            _vlcofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcsrf
    {
        get
        {
            PropriedadeAcessada(RO_VLCSRF);
            return _vlcsrf;
        }
        set
        {
            PropriedadeModificada(RO_VLCSRF, value);
            _vlcsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlinss
    {
        get
        {
            PropriedadeAcessada(RO_VLINSS);
            return _vlinss;
        }
        set
        {
            PropriedadeModificada(RO_VLINSS, value);
            _vlinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vlirrf
    {
        get
        {
            PropriedadeAcessada(RO_VLIRRF);
            return _vlirrf;
        }
        set
        {
            PropriedadeModificada(RO_VLIRRF, value);
            _vlirrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliss
    {
        get
        {
            PropriedadeAcessada(RO_VLISS);
            return _vliss;
        }
        set
        {
            PropriedadeModificada(RO_VLISS, value);
            _vliss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Vloutras
    {
        get
        {
            PropriedadeAcessada(RO_VLOUTRAS);
            return _vloutras;
        }
        set
        {
            PropriedadeModificada(RO_VLOUTRAS, value);
            _vloutras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpis
    {
        get
        {
            PropriedadeAcessada(RO_VLPIS);
            return _vlpis;
        }
        set
        {
            PropriedadeModificada(RO_VLPIS, value);
            _vlpis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Vlsestsenat
    {
        get
        {
            PropriedadeAcessada(RO_VLSESTSENAT);
            return _vlsestsenat;
        }
        set
        {
            PropriedadeModificada(RO_VLSESTSENAT, value);
            _vlsestsenat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Vlvariacaocambial
    {
        get
        {
            PropriedadeAcessada(RO_VLVARIACAOCAMBIAL);
            return _vlvariacaocambial;
        }
        set
        {
            PropriedadeModificada(RO_VLVARIACAOCAMBIAL, value);
            _vlvariacaocambial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vpago
    {
        get
        {
            PropriedadeAcessada(RO_VPAGO);
            return _vpago;
        }
        set
        {
            PropriedadeModificada(RO_VPAGO, value);
            _vpago = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vpagobordero
    {
        get
        {
            PropriedadeAcessada(RO_VPAGOBORDERO);
            return _vpagobordero;
        }
        set
        {
            PropriedadeModificada(RO_VPAGOBORDERO, value);
            _vpagobordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLANC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vreceitabruta
    {
        get
        {
            PropriedadeAcessada(RO_VRECEITABRUTA);
            return _vreceitabruta;
        }
        set
        {
            PropriedadeModificada(RO_VRECEITABRUTA, value);
            _vreceitabruta = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLANC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _adiantamento = AlterarTipo<string>(leitor["Adiantamento"]);
        _agendamento = AlterarTipo<string>(leitor["Agendamento"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _boleto = AlterarTipo<string>(leitor["Boleto"]);
        _codcomprador = AlterarTipo<decimal?>(leitor["Codcomprador"]);
        _codconta = AlterarTipo<decimal>(leitor["Codconta"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfornec = AlterarTipo<decimal>(leitor["Codfornec"]);
        _codfornecprinc = AlterarTipo<decimal?>(leitor["Codfornecprinc"]);
        _codfuncautor = AlterarTipo<decimal?>(leitor["Codfuncautor"]);
        _codfuncbaixa = AlterarTipo<decimal?>(leitor["Codfuncbaixa"]);
        _codfuncestornobaixa = AlterarTipo<decimal?>(leitor["Codfuncestornobaixa"]);
        _codfuncreclassific = AlterarTipo<decimal?>(leitor["Codfuncreclassific"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codprojeto = AlterarTipo<decimal?>(leitor["Codprojeto"]);
        _codreceita = AlterarTipo<decimal?>(leitor["Codreceita"]);
        _codrotinaalt = AlterarTipo<string>(leitor["Codrotinaalt"]);
        _codrotinabaixa = AlterarTipo<decimal?>(leitor["Codrotinabaixa"]);
        _codrotinacad = AlterarTipo<string>(leitor["Codrotinacad"]);
        _cotacao = AlterarTipo<decimal?>(leitor["Cotacao"]);
        _cotacaobaixa = AlterarTipo<decimal?>(leitor["Cotacaobaixa"]);
        _descontofin = AlterarTipo<decimal?>(leitor["Descontofin"]);
        _dtagendamento = AlterarTipo<DateTime?>(leitor["Dtagendamento"]);
        _dtassinatura = AlterarTipo<DateTime?>(leitor["Dtassinatura"]);
        _dtautor = AlterarTipo<DateTime?>(leitor["Dtautor"]);
        _dtbloq = AlterarTipo<DateTime?>(leitor["Dtbloq"]);
        _dtborder = AlterarTipo<DateTime?>(leitor["Dtborder"]);
        _dtcheq = AlterarTipo<DateTime?>(leitor["Dtcheq"]);
        _dtcompetencia = AlterarTipo<DateTime?>(leitor["Dtcompetencia"]);
        _dtcotacao = AlterarTipo<DateTime?>(leitor["Dtcotacao"]);
        _dtdesd = AlterarTipo<DateTime?>(leitor["Dtdesd"]);
        _dtemissao = AlterarTipo<DateTime?>(leitor["Dtemissao"]);
        _dtestornobaixa = AlterarTipo<DateTime?>(leitor["Dtestornobaixa"]);
        _dtlanc = AlterarTipo<DateTime>(leitor["Dtlanc"]);
        _dtmoeda = AlterarTipo<string>(leitor["Dtmoeda"]);
        _dtpagadiantfor = AlterarTipo<DateTime?>(leitor["Dtpagadiantfor"]);
        _dtpagto = AlterarTipo<DateTime?>(leitor["Dtpagto"]);
        _dtprorrog = AlterarTipo<DateTime?>(leitor["Dtprorrog"]);
        _dtreclassific = AlterarTipo<DateTime?>(leitor["Dtreclassific"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtvenc = AlterarTipo<DateTime>(leitor["Dtvenc"]);
        _duplic = AlterarTipo<string>(leitor["Duplic"]);
        _dvag = AlterarTipo<string>(leitor["Dvag"]);
        _formapgto = AlterarTipo<string>(leitor["Formapgto"]);
        _frota_codpraca = AlterarTipo<decimal?>(leitor["Frota_Codpraca"]);
        _frota_codveiculo = AlterarTipo<decimal?>(leitor["Frota_Codveiculo"]);
        _frota_comissao = AlterarTipo<decimal?>(leitor["Frota_Comissao"]);
        _frota_dtabastece = AlterarTipo<DateTime?>(leitor["Frota_Dtabastece"]);
        _frota_kmabastece = AlterarTipo<decimal?>(leitor["Frota_Kmabastece"]);
        _frota_numcar = AlterarTipo<decimal?>(leitor["Frota_Numcar"]);
        _frota_peso = AlterarTipo<decimal?>(leitor["Frota_Peso"]);
        _frota_qtlitros = AlterarTipo<decimal?>(leitor["Frota_Qtlitros"]);
        _funcbloq = AlterarTipo<decimal?>(leitor["Funcbloq"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _historico2 = AlterarTipo<string>(leitor["Historico2"]);
        _idcontroleembarque = AlterarTipo<string>(leitor["Idcontroleembarque"]);
        _indice = AlterarTipo<string>(leitor["Indice"]);
        _localizacao = AlterarTipo<string>(leitor["Localizacao"]);
        _moeda = AlterarTipo<string>(leitor["Moeda"]);
        _moedaestrangeira = AlterarTipo<decimal?>(leitor["Moedaestrangeira"]);
        _nfservico = AlterarTipo<string>(leitor["Nfservico"]);
        _nomefunc = AlterarTipo<string>(leitor["Nomefunc"]);
        _numagdestdoc = AlterarTipo<decimal?>(leitor["Numagdestdoc"]);
        _numagdestdoc2 = AlterarTipo<decimal?>(leitor["Numagdestdoc2"]);
        _numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
        _numbcodestdoc = AlterarTipo<decimal?>(leitor["Numbcodestdoc"]);
        _numbordero = AlterarTipo<decimal?>(leitor["Numbordero"]);
        _numccdestdoc = AlterarTipo<decimal?>(leitor["Numccdestdoc"]);
        _numcheque = AlterarTipo<string>(leitor["Numcheque"]);
        _numcheque2 = AlterarTipo<decimal?>(leitor["Numcheque2"]);
        _numcodbarra = AlterarTipo<string>(leitor["Numcodbarra"]);
        _numcontratocambio = AlterarTipo<string>(leitor["Numcontratocambio"]);
        _numdiimportacao = AlterarTipo<string>(leitor["Numdiimportacao"]);
        _numdvdestdoc = AlterarTipo<string>(leitor["Numdvdestdoc"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numnota = AlterarTipo<decimal>(leitor["Numnota"]);
        _numnotadev = AlterarTipo<decimal?>(leitor["Numnotadev"]);
        _numseqbordero = AlterarTipo<decimal?>(leitor["Numseqbordero"]);
        _numtab = AlterarTipo<decimal?>(leitor["Numtab"]);
        _numtrans = AlterarTipo<decimal?>(leitor["Numtrans"]);
        _numtransadiantfor = AlterarTipo<decimal?>(leitor["Numtransadiantfor"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentnf = AlterarTipo<decimal?>(leitor["Numtransentnf"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _numvia = AlterarTipo<decimal?>(leitor["Numvia"]);
        _numviasfichacp = AlterarTipo<decimal?>(leitor["Numviasfichacp"]);
        _obsbloq = AlterarTipo<string>(leitor["Obsbloq"]);
        _pagtonomedocliente = AlterarTipo<string>(leitor["Pagtonomedocliente"]);
        _percdescfinreal = AlterarTipo<decimal?>(leitor["Percdescfinreal"]);
        _percreceitabruta = AlterarTipo<decimal?>(leitor["Percreceitabruta"]);
        _portadorcheque = AlterarTipo<string>(leitor["Portadorcheque"]);
        _prest = AlterarTipo<string>(leitor["Prest"]);
        _prorrog = AlterarTipo<decimal?>(leitor["Prorrog"]);
        _recnum = AlterarTipo<decimal>(leitor["Recnum"]);
        _recnumprinc = AlterarTipo<decimal?>(leitor["Recnumprinc"]);
        _tipolanc = AlterarTipo<string>(leitor["Tipolanc"]);
        _tipopagto = AlterarTipo<string>(leitor["Tipopagto"]);
        _tipoparceiro = AlterarTipo<string>(leitor["Tipoparceiro"]);
        _txperm = AlterarTipo<decimal?>(leitor["Txperm"]);
        _valor = AlterarTipo<decimal>(leitor["Valor"]);
        _valordev = AlterarTipo<decimal?>(leitor["Valordev"]);
        _valormoedaestrangeira = AlterarTipo<decimal?>(leitor["Valormoedaestrangeira"]);
        _vlcofins = AlterarTipo<decimal?>(leitor["Vlcofins"]);
        _vlcsrf = AlterarTipo<decimal?>(leitor["Vlcsrf"]);
        _vlinss = AlterarTipo<decimal?>(leitor["Vlinss"]);
        _vlirrf = AlterarTipo<decimal?>(leitor["Vlirrf"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vloutras = AlterarTipo<decimal?>(leitor["Vloutras"]);
        _vlpis = AlterarTipo<decimal?>(leitor["Vlpis"]);
        _vlsestsenat = AlterarTipo<decimal?>(leitor["Vlsestsenat"]);
        _vlvariacaocambial = AlterarTipo<decimal?>(leitor["Vlvariacaocambial"]);
        _vpago = AlterarTipo<decimal?>(leitor["Vpago"]);
        _vpagobordero = AlterarTipo<decimal?>(leitor["Vpagobordero"]);
        _vreceitabruta = AlterarTipo<decimal?>(leitor["Vreceitabruta"]);
    }

}