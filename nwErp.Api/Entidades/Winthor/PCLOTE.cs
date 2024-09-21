

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCLOTE : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ANALISE = "Analise";

    private string _analise;

    private static readonly string RO_ANALISEDESC = "Analisedesc";

    private string _analisedesc;

    private static readonly string RO_AN_IDENTIFICACAO = "An_Identificacao";

    private string _an_identificacao;

    private static readonly string RO_AN_IMPUREZA = "An_Impureza";

    private string _an_impureza;

    private static readonly string RO_BOLORESLEVEDURAS = "Boloresleveduras";

    private string _boloresleveduras;

    private static readonly string RO_CODBARRA = "Codbarra";

    private string _codbarra;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCONCILIACAO = "Codfuncconciliacao";

    private decimal? _codfuncconciliacao;

    private static readonly string RO_CODFUNCCQ = "Codfunccq";

    private decimal? _codfunccq;

    private static readonly string RO_CODFUNCEXCLUSAO = "Codfuncexclusao";

    private decimal? _codfuncexclusao;

    private static readonly string RO_CODFUNCRM = "Codfuncrm";

    private decimal? _codfuncrm;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_COL95 = "Col95";

    private string _col95;

    private static readonly string RO_CONTMICROBIANA = "Contmicrobiana";

    private string _contmicrobiana;

    private static readonly string RO_DATACONCILIACAO = "Dataconciliacao";

    private DateTime? _dataconciliacao;

    private static readonly string RO_DATAFABRICACAO = "Datafabricacao";

    private DateTime? _datafabricacao;

    private static readonly string RO_DENSIDADE = "Densidade";

    private string _densidade;

    private static readonly string RO_DESINTEGRACAO = "Desintegracao";

    private string _desintegracao;

    private static readonly string RO_DISSOLUCAO = "Dissolucao";

    private string _dissolucao;

    private static readonly string RO_DOSEAMENTO = "Doseamento";

    private string _doseamento;

    private static readonly string RO_DTAREANALISE = "Dtareanalise";

    private DateTime? _dtareanalise;

    private static readonly string RO_DTBLOQUEIO1 = "Dtbloqueio1";

    private DateTime? _dtbloqueio1;

    private static readonly string RO_DTBLOQUEIO2 = "Dtbloqueio2";

    private DateTime? _dtbloqueio2;

    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";

    private DateTime? _dtexclusao;

    private static readonly string RO_DTINSPVISUAL = "Dtinspvisual";

    private DateTime? _dtinspvisual;

    private static readonly string RO_DTLAUDO = "Dtlaudo";

    private DateTime? _dtlaudo;

    private static readonly string RO_DTLIBERACAO = "Dtliberacao";

    private DateTime? _dtliberacao;

    private static readonly string RO_DTPREVLIB = "Dtprevlib";

    private DateTime? _dtprevlib;

    private static readonly string RO_DTULTMOVENT = "Dtultmovent";

    private DateTime? _dtultmovent;

    private static readonly string RO_DTULTMOVSAI = "Dtultmovsai";

    private DateTime? _dtultmovsai;

    private static readonly string RO_DTVALIDADE = "Dtvalidade";

    private DateTime? _dtvalidade;

    private static readonly string RO_EMBALAGEM = "Embalagem";

    private string _embalagem;

    private static readonly string RO_ESTFAUREAUS = "Estfaureaus";

    private string _estfaureaus;

    private static readonly string RO_FABRICANTE = "Fabricante";

    private string _fabricante;

    private static readonly string RO_FATORPUREZA = "Fatorpureza";

    private decimal? _fatorpureza;

    private static readonly string RO_FRIABILIDADE = "Friabilidade";

    private string _friabilidade;

    private static readonly string RO_IDENTIFICACAO = "Identificacao";

    private string _identificacao;

    private static readonly string RO_IMPUREZA = "Impureza";

    private string _impureza;

    private static readonly string RO_LAUDO = "Laudo";

    private string _laudo;

    private static readonly string RO_LAUDOFAB = "Laudofab";

    private string _laudofab;

    private static readonly string RO_LIPIDEO = "Lipideo";

    private string _lipideo;

    private static readonly string RO_MOFADO = "Mofado";

    private string _mofado;

    private static readonly string RO_MOTIVOBLOQESTOQUE = "Motivobloqestoque";

    private string _motivobloqestoque;

    private static readonly string RO_NUMCERTIFICADO = "Numcertificado";

    private string _numcertificado;

    private static readonly string RO_NUMLOTE = "Numlote";

    private string _numlote;

    private static readonly string RO_NUMLOTEFAB = "Numlotefab";

    private string _numlotefab;

    private static readonly string RO_NUMLOTEFORNEC = "Numlotefornec";

    private string _numlotefornec;

    private static readonly string RO_NUMNEGOCIACAO = "Numnegociacao";

    private decimal? _numnegociacao;

    private static readonly string RO_NUMNOTAENT = "Numnotaent";

    private decimal? _numnotaent;

    private static readonly string RO_NUMREVISAO = "Numrevisao";

    private decimal? _numrevisao;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSENTDEVCLI = "Numtransentdevcli";

    private decimal? _numtransentdevcli;

    private static readonly string RO_NUMTRANSENTORIG = "Numtransentorig";

    private decimal? _numtransentorig;

    private static readonly string RO_OBSANALISE = "Obsanalise";

    private string _obsanalise;

    private static readonly string RO_OBSBLOQUEIO = "Obsbloqueio";

    private string _obsbloqueio;

    private static readonly string RO_OBSBLOQUEIOMANUAL = "Obsbloqueiomanual";

    private string _obsbloqueiomanual;

    private static readonly string RO_OBS1 = "Obs1";

    private string _obs1;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_PAGTOANTECIPADO = "Pagtoantecipado";

    private string _pagtoantecipado;

    private static readonly string RO_PERCTEOR = "Percteor";

    private decimal? _percteor;

    private static readonly string RO_PESQPATOGENOS = "Pesqpatogenos";

    private string _pesqpatogenos;

    private static readonly string RO_PH = "Ph";

    private string _ph;

    private static readonly string RO_PRECOCOMPRA = "Precocompra";

    private decimal? _precocompra;

    private static readonly string RO_PROTEINA = "Proteina";

    private string _proteina;

    private static readonly string RO_PROXNUMSEQLOTE = "Proxnumseqlote";

    private decimal? _proxnumseqlote;

    private static readonly string RO_QT = "Qt";

    private decimal? _qt;

    private static readonly string RO_QTBLOQUEADA = "Qtbloqueada";

    private decimal? _qtbloqueada;

    private static readonly string RO_QTEST = "Qtest";

    private decimal _qtest;

    private static readonly string RO_QTINDENIZ = "Qtindeniz";

    private decimal? _qtindeniz;

    private static readonly string RO_QTRESERV = "Qtreserv";

    private decimal? _qtreserv;

    private static readonly string RO_SALMONELA = "Salmonela";

    private string _salmonela;

    private static readonly string RO_TOTDEFEITO = "Totdefeito";

    private string _totdefeito;

    private static readonly string RO_TXCONVERSAO = "Txconversao";

    private decimal? _txconversao;

    private static readonly string RO_UMIDADE = "Umidade";

    private string _umidade;

    private static readonly string RO_UMIDADEANALISE = "Umidadeanalise";

    private string _umidadeanalise;

    private static readonly string RO_UNIFORMIDADE = "Uniformidade";

    private string _uniformidade;

    private static readonly string RO_VLCALORICO = "Vlcalorico";

    private string _vlcalorico;

    private static readonly string RO_VOLPESMED = "Volpesmed";

    private string _volpesmed;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Analise
    {
        get
        {
            PropriedadeAcessada(RO_ANALISE);
            return _analise;
        }
        set
        {
            PropriedadeModificada(RO_ANALISE, value);
            _analise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Analisedesc
    {
        get
        {
            PropriedadeAcessada(RO_ANALISEDESC);
            return _analisedesc;
        }
        set
        {
            PropriedadeModificada(RO_ANALISEDESC, value);
            _analisedesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string An_Identificacao
    {
        get
        {
            PropriedadeAcessada(RO_AN_IDENTIFICACAO);
            return _an_identificacao;
        }
        set
        {
            PropriedadeModificada(RO_AN_IDENTIFICACAO, value);
            _an_identificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string An_Impureza
    {
        get
        {
            PropriedadeAcessada(RO_AN_IMPUREZA);
            return _an_impureza;
        }
        set
        {
            PropriedadeModificada(RO_AN_IMPUREZA, value);
            _an_impureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Boloresleveduras
    {
        get
        {
            PropriedadeAcessada(RO_BOLORESLEVEDURAS);
            return _boloresleveduras;
        }
        set
        {
            PropriedadeModificada(RO_BOLORESLEVEDURAS, value);
            _boloresleveduras = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Codbarra
    {
        get
        {
            PropriedadeAcessada(RO_CODBARRA);
            return _codbarra;
        }
        set
        {
            PropriedadeModificada(RO_CODBARRA, value);
            _codbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfuncconciliacao
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONCILIACAO);
            return _codfuncconciliacao;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONCILIACAO, value);
            _codfuncconciliacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccq
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCQ);
            return _codfunccq;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCQ, value);
            _codfunccq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codfuncexclusao
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCEXCLUSAO);
            return _codfuncexclusao;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCEXCLUSAO, value);
            _codfuncexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncrm
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCRM);
            return _codfuncrm;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCRM, value);
            _codfuncrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Col95
    {
        get
        {
            PropriedadeAcessada(RO_COL95);
            return _col95;
        }
        set
        {
            PropriedadeModificada(RO_COL95, value);
            _col95 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Contmicrobiana
    {
        get
        {
            PropriedadeAcessada(RO_CONTMICROBIANA);
            return _contmicrobiana;
        }
        set
        {
            PropriedadeModificada(RO_CONTMICROBIANA, value);
            _contmicrobiana = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconciliacao
    {
        get
        {
            PropriedadeAcessada(RO_DATACONCILIACAO);
            return _dataconciliacao;
        }
        set
        {
            PropriedadeModificada(RO_DATACONCILIACAO, value);
            _dataconciliacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datafabricacao
    {
        get
        {
            PropriedadeAcessada(RO_DATAFABRICACAO);
            return _datafabricacao;
        }
        set
        {
            PropriedadeModificada(RO_DATAFABRICACAO, value);
            _datafabricacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Densidade
    {
        get
        {
            PropriedadeAcessada(RO_DENSIDADE);
            return _densidade;
        }
        set
        {
            PropriedadeModificada(RO_DENSIDADE, value);
            _densidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Desintegracao
    {
        get
        {
            PropriedadeAcessada(RO_DESINTEGRACAO);
            return _desintegracao;
        }
        set
        {
            PropriedadeModificada(RO_DESINTEGRACAO, value);
            _desintegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Dissolucao
    {
        get
        {
            PropriedadeAcessada(RO_DISSOLUCAO);
            return _dissolucao;
        }
        set
        {
            PropriedadeModificada(RO_DISSOLUCAO, value);
            _dissolucao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Doseamento
    {
        get
        {
            PropriedadeAcessada(RO_DOSEAMENTO);
            return _doseamento;
        }
        set
        {
            PropriedadeModificada(RO_DOSEAMENTO, value);
            _doseamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtareanalise
    {
        get
        {
            PropriedadeAcessada(RO_DTAREANALISE);
            return _dtareanalise;
        }
        set
        {
            PropriedadeModificada(RO_DTAREANALISE, value);
            _dtareanalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloqueio1
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQUEIO1);
            return _dtbloqueio1;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQUEIO1, value);
            _dtbloqueio1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbloqueio2
    {
        get
        {
            PropriedadeAcessada(RO_DTBLOQUEIO2);
            return _dtbloqueio2;
        }
        set
        {
            PropriedadeModificada(RO_DTBLOQUEIO2, value);
            _dtbloqueio2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXCLUSAO);
            return _dtexclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXCLUSAO, value);
            _dtexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinspvisual
    {
        get
        {
            PropriedadeAcessada(RO_DTINSPVISUAL);
            return _dtinspvisual;
        }
        set
        {
            PropriedadeModificada(RO_DTINSPVISUAL, value);
            _dtinspvisual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlaudo
    {
        get
        {
            PropriedadeAcessada(RO_DTLAUDO);
            return _dtlaudo;
        }
        set
        {
            PropriedadeModificada(RO_DTLAUDO, value);
            _dtlaudo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacao
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERACAO);
            return _dtliberacao;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERACAO, value);
            _dtliberacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprevlib
    {
        get
        {
            PropriedadeAcessada(RO_DTPREVLIB);
            return _dtprevlib;
        }
        set
        {
            PropriedadeModificada(RO_DTPREVLIB, value);
            _dtprevlib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultmovent
    {
        get
        {
            PropriedadeAcessada(RO_DTULTMOVENT);
            return _dtultmovent;
        }
        set
        {
            PropriedadeModificada(RO_DTULTMOVENT, value);
            _dtultmovent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultmovsai
    {
        get
        {
            PropriedadeAcessada(RO_DTULTMOVSAI);
            return _dtultmovsai;
        }
        set
        {
            PropriedadeModificada(RO_DTULTMOVSAI, value);
            _dtultmovsai = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTVALIDADE);
            return _dtvalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTVALIDADE, value);
            _dtvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Embalagem
    {
        get
        {
            PropriedadeAcessada(RO_EMBALAGEM);
            return _embalagem;
        }
        set
        {
            PropriedadeModificada(RO_EMBALAGEM, value);
            _embalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Estfaureaus
    {
        get
        {
            PropriedadeAcessada(RO_ESTFAUREAUS);
            return _estfaureaus;
        }
        set
        {
            PropriedadeModificada(RO_ESTFAUREAUS, value);
            _estfaureaus = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Fabricante
    {
        get
        {
            PropriedadeAcessada(RO_FABRICANTE);
            return _fabricante;
        }
        set
        {
            PropriedadeModificada(RO_FABRICANTE, value);
            _fabricante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Fatorpureza
    {
        get
        {
            PropriedadeAcessada(RO_FATORPUREZA);
            return _fatorpureza;
        }
        set
        {
            PropriedadeModificada(RO_FATORPUREZA, value);
            _fatorpureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Friabilidade
    {
        get
        {
            PropriedadeAcessada(RO_FRIABILIDADE);
            return _friabilidade;
        }
        set
        {
            PropriedadeModificada(RO_FRIABILIDADE, value);
            _friabilidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Identificacao
    {
        get
        {
            PropriedadeAcessada(RO_IDENTIFICACAO);
            return _identificacao;
        }
        set
        {
            PropriedadeModificada(RO_IDENTIFICACAO, value);
            _identificacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impureza
    {
        get
        {
            PropriedadeAcessada(RO_IMPUREZA);
            return _impureza;
        }
        set
        {
            PropriedadeModificada(RO_IMPUREZA, value);
            _impureza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Laudo
    {
        get
        {
            PropriedadeAcessada(RO_LAUDO);
            return _laudo;
        }
        set
        {
            PropriedadeModificada(RO_LAUDO, value);
            _laudo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Laudofab
    {
        get
        {
            PropriedadeAcessada(RO_LAUDOFAB);
            return _laudofab;
        }
        set
        {
            PropriedadeModificada(RO_LAUDOFAB, value);
            _laudofab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Lipideo
    {
        get
        {
            PropriedadeAcessada(RO_LIPIDEO);
            return _lipideo;
        }
        set
        {
            PropriedadeModificada(RO_LIPIDEO, value);
            _lipideo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Mofado
    {
        get
        {
            PropriedadeAcessada(RO_MOFADO);
            return _mofado;
        }
        set
        {
            PropriedadeModificada(RO_MOFADO, value);
            _mofado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numcertificado
    {
        get
        {
            PropriedadeAcessada(RO_NUMCERTIFICADO);
            return _numcertificado;
        }
        set
        {
            PropriedadeModificada(RO_NUMCERTIFICADO, value);
            _numcertificado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlote
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTE);
            return _numlote;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTE, value);
            _numlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numlotefab
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTEFAB);
            return _numlotefab;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTEFAB, value);
            _numlotefab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numlotefornec
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTEFORNEC);
            return _numlotefornec;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTEFORNEC, value);
            _numlotefornec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotaent
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAENT);
            return _numnotaent;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAENT, value);
            _numnotaent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 4)]
    public decimal? Numrevisao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREVISAO);
            return _numrevisao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREVISAO, value);
            _numrevisao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdevcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTDEVCLI);
            return _numtransentdevcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTDEVCLI, value);
            _numtransentdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentorig
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTORIG);
            return _numtransentorig;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTORIG, value);
            _numtransentorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obsanalise
    {
        get
        {
            PropriedadeAcessada(RO_OBSANALISE);
            return _obsanalise;
        }
        set
        {
            PropriedadeModificada(RO_OBSANALISE, value);
            _obsanalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obsbloqueio
    {
        get
        {
            PropriedadeAcessada(RO_OBSBLOQUEIO);
            return _obsbloqueio;
        }
        set
        {
            PropriedadeModificada(RO_OBSBLOQUEIO, value);
            _obsbloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Obsbloqueiomanual
    {
        get
        {
            PropriedadeAcessada(RO_OBSBLOQUEIOMANUAL);
            return _obsbloqueiomanual;
        }
        set
        {
            PropriedadeModificada(RO_OBSBLOQUEIOMANUAL, value);
            _obsbloqueiomanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obs1
    {
        get
        {
            PropriedadeAcessada(RO_OBS1);
            return _obs1;
        }
        set
        {
            PropriedadeModificada(RO_OBS1, value);
            _obs1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obs2
    {
        get
        {
            PropriedadeAcessada(RO_OBS2);
            return _obs2;
        }
        set
        {
            PropriedadeModificada(RO_OBS2, value);
            _obs2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagtoantecipado
    {
        get
        {
            PropriedadeAcessada(RO_PAGTOANTECIPADO);
            return _pagtoantecipado;
        }
        set
        {
            PropriedadeModificada(RO_PAGTOANTECIPADO, value);
            _pagtoantecipado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percteor
    {
        get
        {
            PropriedadeAcessada(RO_PERCTEOR);
            return _percteor;
        }
        set
        {
            PropriedadeModificada(RO_PERCTEOR, value);
            _percteor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Pesqpatogenos
    {
        get
        {
            PropriedadeAcessada(RO_PESQPATOGENOS);
            return _pesqpatogenos;
        }
        set
        {
            PropriedadeModificada(RO_PESQPATOGENOS, value);
            _pesqpatogenos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Ph
    {
        get
        {
            PropriedadeAcessada(RO_PH);
            return _ph;
        }
        set
        {
            PropriedadeModificada(RO_PH, value);
            _ph = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precocompra
    {
        get
        {
            PropriedadeAcessada(RO_PRECOCOMPRA);
            return _precocompra;
        }
        set
        {
            PropriedadeModificada(RO_PRECOCOMPRA, value);
            _precocompra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Proteina
    {
        get
        {
            PropriedadeAcessada(RO_PROTEINA);
            return _proteina;
        }
        set
        {
            PropriedadeModificada(RO_PROTEINA, value);
            _proteina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Proxnumseqlote
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMSEQLOTE);
            return _proxnumseqlote;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMSEQLOTE, value);
            _proxnumseqlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 8)]
    public decimal? Qt
    {
        get
        {
            PropriedadeAcessada(RO_QT);
            return _qt;
        }
        set
        {
            PropriedadeModificada(RO_QT, value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 2)]
    public decimal Qtest
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Salmonela
    {
        get
        {
            PropriedadeAcessada(RO_SALMONELA);
            return _salmonela;
        }
        set
        {
            PropriedadeModificada(RO_SALMONELA, value);
            _salmonela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Totdefeito
    {
        get
        {
            PropriedadeAcessada(RO_TOTDEFEITO);
            return _totdefeito;
        }
        set
        {
            PropriedadeModificada(RO_TOTDEFEITO, value);
            _totdefeito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Txconversao
    {
        get
        {
            PropriedadeAcessada(RO_TXCONVERSAO);
            return _txconversao;
        }
        set
        {
            PropriedadeModificada(RO_TXCONVERSAO, value);
            _txconversao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Umidade
    {
        get
        {
            PropriedadeAcessada(RO_UMIDADE);
            return _umidade;
        }
        set
        {
            PropriedadeModificada(RO_UMIDADE, value);
            _umidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Umidadeanalise
    {
        get
        {
            PropriedadeAcessada(RO_UMIDADEANALISE);
            return _umidadeanalise;
        }
        set
        {
            PropriedadeModificada(RO_UMIDADEANALISE, value);
            _umidadeanalise = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Uniformidade
    {
        get
        {
            PropriedadeAcessada(RO_UNIFORMIDADE);
            return _uniformidade;
        }
        set
        {
            PropriedadeModificada(RO_UNIFORMIDADE, value);
            _uniformidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Vlcalorico
    {
        get
        {
            PropriedadeAcessada(RO_VLCALORICO);
            return _vlcalorico;
        }
        set
        {
            PropriedadeModificada(RO_VLCALORICO, value);
            _vlcalorico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCLOTE", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Volpesmed
    {
        get
        {
            PropriedadeAcessada(RO_VOLPESMED);
            return _volpesmed;
        }
        set
        {
            PropriedadeModificada(RO_VOLPESMED, value);
            _volpesmed = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCLOTE";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _analise = AlterarTipo<string>(leitor["Analise"]);
        _analisedesc = AlterarTipo<string>(leitor["Analisedesc"]);
        _an_identificacao = AlterarTipo<string>(leitor["An_Identificacao"]);
        _an_impureza = AlterarTipo<string>(leitor["An_Impureza"]);
        _boloresleveduras = AlterarTipo<string>(leitor["Boloresleveduras"]);
        _codbarra = AlterarTipo<string>(leitor["Codbarra"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfuncconciliacao = AlterarTipo<decimal?>(leitor["Codfuncconciliacao"]);
        _codfunccq = AlterarTipo<decimal?>(leitor["Codfunccq"]);
        _codfuncexclusao = AlterarTipo<decimal?>(leitor["Codfuncexclusao"]);
        _codfuncrm = AlterarTipo<decimal?>(leitor["Codfuncrm"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _col95 = AlterarTipo<string>(leitor["Col95"]);
        _contmicrobiana = AlterarTipo<string>(leitor["Contmicrobiana"]);
        _dataconciliacao = AlterarTipo<DateTime?>(leitor["Dataconciliacao"]);
        _datafabricacao = AlterarTipo<DateTime?>(leitor["Datafabricacao"]);
        _densidade = AlterarTipo<string>(leitor["Densidade"]);
        _desintegracao = AlterarTipo<string>(leitor["Desintegracao"]);
        _dissolucao = AlterarTipo<string>(leitor["Dissolucao"]);
        _doseamento = AlterarTipo<string>(leitor["Doseamento"]);
        _dtareanalise = AlterarTipo<DateTime?>(leitor["Dtareanalise"]);
        _dtbloqueio1 = AlterarTipo<DateTime?>(leitor["Dtbloqueio1"]);
        _dtbloqueio2 = AlterarTipo<DateTime?>(leitor["Dtbloqueio2"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _dtinspvisual = AlterarTipo<DateTime?>(leitor["Dtinspvisual"]);
        _dtlaudo = AlterarTipo<DateTime?>(leitor["Dtlaudo"]);
        _dtliberacao = AlterarTipo<DateTime?>(leitor["Dtliberacao"]);
        _dtprevlib = AlterarTipo<DateTime?>(leitor["Dtprevlib"]);
        _dtultmovent = AlterarTipo<DateTime?>(leitor["Dtultmovent"]);
        _dtultmovsai = AlterarTipo<DateTime?>(leitor["Dtultmovsai"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _embalagem = AlterarTipo<string>(leitor["Embalagem"]);
        _estfaureaus = AlterarTipo<string>(leitor["Estfaureaus"]);
        _fabricante = AlterarTipo<string>(leitor["Fabricante"]);
        _fatorpureza = AlterarTipo<decimal?>(leitor["Fatorpureza"]);
        _friabilidade = AlterarTipo<string>(leitor["Friabilidade"]);
        _identificacao = AlterarTipo<string>(leitor["Identificacao"]);
        _impureza = AlterarTipo<string>(leitor["Impureza"]);
        _laudo = AlterarTipo<string>(leitor["Laudo"]);
        _laudofab = AlterarTipo<string>(leitor["Laudofab"]);
        _lipideo = AlterarTipo<string>(leitor["Lipideo"]);
        _mofado = AlterarTipo<string>(leitor["Mofado"]);
        _motivobloqestoque = AlterarTipo<string>(leitor["Motivobloqestoque"]);
        _numcertificado = AlterarTipo<string>(leitor["Numcertificado"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numlotefab = AlterarTipo<string>(leitor["Numlotefab"]);
        _numlotefornec = AlterarTipo<string>(leitor["Numlotefornec"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numnotaent = AlterarTipo<decimal?>(leitor["Numnotaent"]);
        _numrevisao = AlterarTipo<decimal?>(leitor["Numrevisao"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentdevcli = AlterarTipo<decimal?>(leitor["Numtransentdevcli"]);
        _numtransentorig = AlterarTipo<decimal?>(leitor["Numtransentorig"]);
        _obsanalise = AlterarTipo<string>(leitor["Obsanalise"]);
        _obsbloqueio = AlterarTipo<string>(leitor["Obsbloqueio"]);
        _obsbloqueiomanual = AlterarTipo<string>(leitor["Obsbloqueiomanual"]);
        _obs1 = AlterarTipo<string>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _pagtoantecipado = AlterarTipo<string>(leitor["Pagtoantecipado"]);
        _percteor = AlterarTipo<decimal?>(leitor["Percteor"]);
        _pesqpatogenos = AlterarTipo<string>(leitor["Pesqpatogenos"]);
        _ph = AlterarTipo<string>(leitor["Ph"]);
        _precocompra = AlterarTipo<decimal?>(leitor["Precocompra"]);
        _proteina = AlterarTipo<string>(leitor["Proteina"]);
        _proxnumseqlote = AlterarTipo<decimal?>(leitor["Proxnumseqlote"]);
        _qt = AlterarTipo<decimal?>(leitor["Qt"]);
        _qtbloqueada = AlterarTipo<decimal?>(leitor["Qtbloqueada"]);
        _qtest = AlterarTipo<decimal>(leitor["Qtest"]);
        _qtindeniz = AlterarTipo<decimal?>(leitor["Qtindeniz"]);
        _qtreserv = AlterarTipo<decimal?>(leitor["Qtreserv"]);
        _salmonela = AlterarTipo<string>(leitor["Salmonela"]);
        _totdefeito = AlterarTipo<string>(leitor["Totdefeito"]);
        _txconversao = AlterarTipo<decimal?>(leitor["Txconversao"]);
        _umidade = AlterarTipo<string>(leitor["Umidade"]);
        _umidadeanalise = AlterarTipo<string>(leitor["Umidadeanalise"]);
        _uniformidade = AlterarTipo<string>(leitor["Uniformidade"]);
        _vlcalorico = AlterarTipo<string>(leitor["Vlcalorico"]);
        _volpesmed = AlterarTipo<string>(leitor["Volpesmed"]);
    }

}