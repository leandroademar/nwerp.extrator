

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCMOVCR : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal _codbanco;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCONTACRED = "Codcontacred";

    private decimal? _codcontacred;

    private static readonly string RO_CODCONTADEB = "Codcontadeb";

    private decimal? _codcontadeb;

    private static readonly string RO_CODCRECLI = "Codcrecli";

    private decimal? _codcrecli;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNC = "Codfunc";

    private decimal _codfunc;

    private static readonly string RO_CODFUNCCONCIL = "Codfuncconcil";

    private decimal? _codfuncconcil;

    private static readonly string RO_CODFUNCDNICLI = "Codfuncdnicli";

    private decimal? _codfuncdnicli;

    private static readonly string RO_CODFUNCESTORNOCONCIL = "Codfuncestornoconcil";

    private decimal? _codfuncestornoconcil;

    private static readonly string RO_CODROTINALANC = "Codrotinalanc";

    private decimal? _codrotinalanc;

    private static readonly string RO_CONCILIACAO = "Conciliacao";

    private string _conciliacao;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DATACOMPLETA = "Datacompleta";

    private DateTime? _datacompleta;

    private static readonly string RO_DTASSOCIADNICLI = "Dtassociadnicli";

    private DateTime? _dtassociadnicli;

    private static readonly string RO_DTCOMPENSACAO = "Dtcompensacao";

    private DateTime? _dtcompensacao;

    private static readonly string RO_DTCONCIL = "Dtconcil";

    private DateTime? _dtconcil;

    private static readonly string RO_DTESTORNO = "Dtestorno";

    private DateTime? _dtestorno;

    private static readonly string RO_DTESTORNOLANC = "Dtestornolanc";

    private DateTime? _dtestornolanc;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTVENCTICKT = "Dtvenctickt";

    private DateTime? _dtvenctickt;

    private static readonly string RO_DUPLICBAIXA = "Duplicbaixa";

    private decimal? _duplicbaixa;

    private static readonly string RO_ESTORNO = "Estorno";

    private string _estorno;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_HISTORICO = "Historico";

    private string _historico;

    private static readonly string RO_HISTORICO2 = "Historico2";

    private string _historico2;

    private static readonly string RO_HORA = "Hora";

    private decimal _hora;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_INDICE = "Indice";

    private string _indice;

    private static readonly string RO_MINUTO = "Minuto";

    private decimal _minuto;

    private static readonly string RO_NUMASSOCDNI = "Numassocdni";

    private decimal? _numassocdni;

    private static readonly string RO_NUMCARR = "Numcarr";

    private decimal? _numcarr;

    private static readonly string RO_NUMCARREG = "Numcarreg";

    private decimal? _numcarreg;

    private static readonly string RO_NUMCHEQUE = "Numcheque";

    private string _numcheque;

    private static readonly string RO_NUMCX = "Numcx";

    private decimal? _numcx;

    private static readonly string RO_NUMDOC = "Numdoc";

    private string _numdoc;

    private static readonly string RO_NUMLANC = "Numlanc";

    private decimal? _numlanc;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal? _numseq;

    private static readonly string RO_NUMTRANS = "Numtrans";

    private decimal _numtrans;

    private static readonly string RO_NUMTRANSECF = "Numtransecf";

    private decimal? _numtransecf;

    private static readonly string RO_NUMTRANSEST = "Numtransest";

    private decimal? _numtransest;

    private static readonly string RO_NUMVALEECF = "Numvaleecf";

    private decimal? _numvaleecf;

    private static readonly string RO_OPERACAO = "Operacao";

    private decimal? _operacao;

    private static readonly string RO_PRESTBAIXA = "Prestbaixa";

    private string _prestbaixa;

    private static readonly string RO_SALDOTMP = "Saldotmp";

    private decimal? _saldotmp;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    private static readonly string RO_VALOR = "Valor";

    private decimal _valor;

    private static readonly string RO_VALORCAIXA = "Valorcaixa";

    private decimal? _valorcaixa;

    private static readonly string RO_VLSALDO = "Vlsaldo";

    private decimal _vlsaldo;

    private static readonly string RO_VLSALDOCONCIL = "Vlsaldoconcil";

    private decimal? _vlsaldoconcil;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codbanco
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacred
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACRED);
            return _codcontacred;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACRED, value);
            _codcontacred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontadeb
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTADEB);
            return _codcontadeb;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTADEB, value);
            _codcontadeb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcrecli
    {
        get
        {
            PropriedadeAcessada(RO_CODCRECLI);
            return _codcrecli;
        }
        set
        {
            PropriedadeModificada(RO_CODCRECLI, value);
            _codcrecli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Codfunc
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconcil
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONCIL);
            return _codfuncconcil;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONCIL, value);
            _codfuncconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncdnicli
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCDNICLI);
            return _codfuncdnicli;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCDNICLI, value);
            _codfuncdnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncestornoconcil
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCESTORNOCONCIL);
            return _codfuncestornoconcil;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCESTORNOCONCIL, value);
            _codfuncestornoconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codrotinalanc
    {
        get
        {
            PropriedadeAcessada(RO_CODROTINALANC);
            return _codrotinalanc;
        }
        set
        {
            PropriedadeModificada(RO_CODROTINALANC, value);
            _codrotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Conciliacao
    {
        get
        {
            PropriedadeAcessada(RO_CONCILIACAO);
            return _conciliacao;
        }
        set
        {
            PropriedadeModificada(RO_CONCILIACAO, value);
            _conciliacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacompleta
    {
        get
        {
            PropriedadeAcessada(RO_DATACOMPLETA);
            return _datacompleta;
        }
        set
        {
            PropriedadeModificada(RO_DATACOMPLETA, value);
            _datacompleta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtassociadnicli
    {
        get
        {
            PropriedadeAcessada(RO_DTASSOCIADNICLI);
            return _dtassociadnicli;
        }
        set
        {
            PropriedadeModificada(RO_DTASSOCIADNICLI, value);
            _dtassociadnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcompensacao
    {
        get
        {
            PropriedadeAcessada(RO_DTCOMPENSACAO);
            return _dtcompensacao;
        }
        set
        {
            PropriedadeModificada(RO_DTCOMPENSACAO, value);
            _dtcompensacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcil
    {
        get
        {
            PropriedadeAcessada(RO_DTCONCIL);
            return _dtconcil;
        }
        set
        {
            PropriedadeModificada(RO_DTCONCIL, value);
            _dtconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestorno
    {
        get
        {
            PropriedadeAcessada(RO_DTESTORNO);
            return _dtestorno;
        }
        set
        {
            PropriedadeModificada(RO_DTESTORNO, value);
            _dtestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestornolanc
    {
        get
        {
            PropriedadeAcessada(RO_DTESTORNOLANC);
            return _dtestornolanc;
        }
        set
        {
            PropriedadeModificada(RO_DTESTORNOLANC, value);
            _dtestornolanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOSERVINT);
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOSERVINT, value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOSERVPRINC);
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOSERVPRINC, value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvenctickt
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCTICKT);
            return _dtvenctickt;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCTICKT, value);
            _dtvenctickt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Duplicbaixa
    {
        get
        {
            PropriedadeAcessada(RO_DUPLICBAIXA);
            return _duplicbaixa;
        }
        set
        {
            PropriedadeModificada(RO_DUPLICBAIXA, value);
            _duplicbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Estorno
    {
        get
        {
            PropriedadeAcessada(RO_ESTORNO);
            return _estorno;
        }
        set
        {
            PropriedadeModificada(RO_ESTORNO, value);
            _estorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADOSERVINT);
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADOSERVINT, value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal Hora
    {
        get
        {
            PropriedadeAcessada(RO_HORA);
            return _hora;
        }
        set
        {
            PropriedadeModificada(RO_HORA, value);
            _hora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOSERVPRINC);
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOSERVPRINC, value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal Minuto
    {
        get
        {
            PropriedadeAcessada(RO_MINUTO);
            return _minuto;
        }
        set
        {
            PropriedadeModificada(RO_MINUTO, value);
            _minuto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numassocdni
    {
        get
        {
            PropriedadeAcessada(RO_NUMASSOCDNI);
            return _numassocdni;
        }
        set
        {
            PropriedadeModificada(RO_NUMASSOCDNI, value);
            _numassocdni = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Numcarr
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARR);
            return _numcarr;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARR, value);
            _numcarr = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarreg
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARREG);
            return _numcarreg;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARREG, value);
            _numcarreg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcx
    {
        get
        {
            PropriedadeAcessada(RO_NUMCX);
            return _numcx;
        }
        set
        {
            PropriedadeModificada(RO_NUMCX, value);
            _numcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numdoc
    {
        get
        {
            PropriedadeAcessada(RO_NUMDOC);
            return _numdoc;
        }
        set
        {
            PropriedadeModificada(RO_NUMDOC, value);
            _numdoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlanc
    {
        get
        {
            PropriedadeAcessada(RO_NUMLANC);
            return _numlanc;
        }
        set
        {
            PropriedadeModificada(RO_NUMLANC, value);
            _numlanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numseq
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQ);
            return _numseq;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQ, value);
            _numseq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtrans
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSECF);
            return _numtransecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSECF, value);
            _numtransecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransest
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSEST);
            return _numtransest;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSEST, value);
            _numtransest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numvaleecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMVALEECF);
            return _numvaleecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMVALEECF, value);
            _numvaleecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Operacao
    {
        get
        {
            PropriedadeAcessada(RO_OPERACAO);
            return _operacao;
        }
        set
        {
            PropriedadeModificada(RO_OPERACAO, value);
            _operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Prestbaixa
    {
        get
        {
            PropriedadeAcessada(RO_PRESTBAIXA);
            return _prestbaixa;
        }
        set
        {
            PropriedadeModificada(RO_PRESTBAIXA, value);
            _prestbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Saldotmp
    {
        get
        {
            PropriedadeAcessada(RO_SALDOTMP);
            return _saldotmp;
        }
        set
        {
            PropriedadeModificada(RO_SALDOTMP, value);
            _saldotmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada(RO_TIPO);
            return _tipo;
        }
        set
        {
            PropriedadeModificada(RO_TIPO, value);
            _tipo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorcaixa
    {
        get
        {
            PropriedadeAcessada(RO_VALORCAIXA);
            return _valorcaixa;
        }
        set
        {
            PropriedadeModificada(RO_VALORCAIXA, value);
            _valorcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal Vlsaldo
    {
        get
        {
            PropriedadeAcessada(RO_VLSALDO);
            return _vlsaldo;
        }
        set
        {
            PropriedadeModificada(RO_VLSALDO, value);
            _vlsaldo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCMOVCR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlsaldoconcil
    {
        get
        {
            PropriedadeAcessada(RO_VLSALDOCONCIL);
            return _vlsaldoconcil;
        }
        set
        {
            PropriedadeModificada(RO_VLSALDOCONCIL, value);
            _vlsaldoconcil = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCMOVCR";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codbanco = AlterarTipo<decimal>(leitor["Codbanco"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcontacred = AlterarTipo<decimal?>(leitor["Codcontacred"]);
        _codcontadeb = AlterarTipo<decimal?>(leitor["Codcontadeb"]);
        _codcrecli = AlterarTipo<decimal?>(leitor["Codcrecli"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunc = AlterarTipo<decimal>(leitor["Codfunc"]);
        _codfuncconcil = AlterarTipo<decimal?>(leitor["Codfuncconcil"]);
        _codfuncdnicli = AlterarTipo<decimal?>(leitor["Codfuncdnicli"]);
        _codfuncestornoconcil = AlterarTipo<decimal?>(leitor["Codfuncestornoconcil"]);
        _codrotinalanc = AlterarTipo<decimal?>(leitor["Codrotinalanc"]);
        _conciliacao = AlterarTipo<string>(leitor["Conciliacao"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _datacompleta = AlterarTipo<DateTime?>(leitor["Datacompleta"]);
        _dtassociadnicli = AlterarTipo<DateTime?>(leitor["Dtassociadnicli"]);
        _dtcompensacao = AlterarTipo<DateTime?>(leitor["Dtcompensacao"]);
        _dtconcil = AlterarTipo<DateTime?>(leitor["Dtconcil"]);
        _dtestorno = AlterarTipo<DateTime?>(leitor["Dtestorno"]);
        _dtestornolanc = AlterarTipo<DateTime?>(leitor["Dtestornolanc"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtvenctickt = AlterarTipo<DateTime?>(leitor["Dtvenctickt"]);
        _duplicbaixa = AlterarTipo<decimal?>(leitor["Duplicbaixa"]);
        _estorno = AlterarTipo<string>(leitor["Estorno"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _historico = AlterarTipo<string>(leitor["Historico"]);
        _historico2 = AlterarTipo<string>(leitor["Historico2"]);
        _hora = AlterarTipo<decimal>(leitor["Hora"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _indice = AlterarTipo<string>(leitor["Indice"]);
        _minuto = AlterarTipo<decimal>(leitor["Minuto"]);
        _numassocdni = AlterarTipo<decimal?>(leitor["Numassocdni"]);
        _numcarr = AlterarTipo<decimal?>(leitor["Numcarr"]);
        _numcarreg = AlterarTipo<decimal?>(leitor["Numcarreg"]);
        _numcheque = AlterarTipo<string>(leitor["Numcheque"]);
        _numcx = AlterarTipo<decimal?>(leitor["Numcx"]);
        _numdoc = AlterarTipo<string>(leitor["Numdoc"]);
        _numlanc = AlterarTipo<decimal?>(leitor["Numlanc"]);
        _numseq = AlterarTipo<decimal?>(leitor["Numseq"]);
        _numtrans = AlterarTipo<decimal>(leitor["Numtrans"]);
        _numtransecf = AlterarTipo<decimal?>(leitor["Numtransecf"]);
        _numtransest = AlterarTipo<decimal?>(leitor["Numtransest"]);
        _numvaleecf = AlterarTipo<decimal?>(leitor["Numvaleecf"]);
        _operacao = AlterarTipo<decimal?>(leitor["Operacao"]);
        _prestbaixa = AlterarTipo<string>(leitor["Prestbaixa"]);
        _saldotmp = AlterarTipo<decimal?>(leitor["Saldotmp"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _valor = AlterarTipo<decimal>(leitor["Valor"]);
        _valorcaixa = AlterarTipo<decimal?>(leitor["Valorcaixa"]);
        _vlsaldo = AlterarTipo<decimal>(leitor["Vlsaldo"]);
        _vlsaldoconcil = AlterarTipo<decimal?>(leitor["Vlsaldoconcil"]);
    }

}