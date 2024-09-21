

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCORCAVENDAI : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqinternadest;

    private string _alternativo;

    private string _ambiente;

    private string _baixado;

    private decimal? _basedifaliquotas;

    private decimal? _baseicst;

    private string _bonific;

    private string _brinde;

    private string _chaveprincipal;

    private decimal? _codauxiliar;

    private string _codbase;

    private decimal _codcli;

    private decimal? _codcombo;

    private decimal? _coddesconto;

    private decimal? _codemitenteitempedido;

    private string _codfilialretira;

    private string _codformula;

    private decimal? _codicmtab;

    private decimal? _codimp;

    private decimal? _codindicemultiplicador;

    private decimal? _codmaquina;

    private decimal? _codmoedaestrageira;

    private decimal? _codofertaorig;

    private decimal? _codprecofixo;

    private decimal _codprod;

    private decimal? _codprodcesta;

    private string _codprodtinta;

    private string _codpromocao;

    private decimal? _codst;

    private decimal _codusur;

    private string _complemento;

    private decimal? _custofinest;

    private DateTime _data;

    private DateTime? _dtentrega;

    private DateTime? _dtexportacao;

    private DateTime? _dtultalter;

    private decimal? _eancodprod;

    private decimal? _escaniado;

    private string _exportado;

    private decimal? _fatorpreco;

    private string _formanegociacao;

    private string _geragnre_cnpjcliente;

    private string _grupofaturamento;

    private string _impressorestaurante;

    private string _imprimerestaurante;

    private decimal? _iva;

    private string _letracomiss;

    private string _localizacao;

    private decimal? _margem;

    private decimal? _matricula;

    private string _negociacaoposterior;

    private decimal? _numcar;

    private decimal? _numccf;

    private decimal? _numeroetiqimpressa;

    private decimal? _numfichaorig;

    private decimal? _numitemorca;

    private decimal? _numlista;

    private string _numlote;

    private decimal _numorca;

    private decimal? _numorcaorig;

    private decimal _numseq;

    private decimal? _numseqcesta;

    private decimal? _numseqformula;

    private decimal? _numseqimpressao;

    private decimal? _numseqitemcontrato;

    private decimal? _numverbarebcmv;

    private string _observacao;

    private string _origemst;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _pbonific;

    private decimal? _perbonific;

    private decimal? _percagregadorst;

    private decimal? _percbasered;

    private decimal? _percbaseredpart;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percdescquant;

    private decimal? _percdesc_politica;

    private decimal? _percdifaliquotas;

    private decimal? _percipi;

    private decimal? _perciss;

    private decimal _percom;

    private decimal? _percom2;

    private decimal? _percom3;

    private decimal? _percom4;

    private decimal? _percomprof;

    private decimal? _percomsup;

    private decimal? _percomtab;

    private decimal? _percprovpart;

    private decimal? _percredaliqipi;

    private decimal? _percvenda;

    private decimal _perdesc;

    private decimal? _perdescaux;

    private decimal? _perdescavista;

    private decimal? _perdesccom;

    private decimal? _perdesccusto;

    private decimal? _perdescfin;

    private decimal? _perdescflex;

    private decimal? _perdescisentoicms;

    private decimal? _perdescnegociado;

    private decimal? _perdescpauta;

    private decimal? _perdescpolitica;

    private decimal? _perdesctab;

    private decimal? _perfretecmv;

    private decimal? _perredcomiss;

    private decimal? _perredcomisssup;

    private decimal? _pesobruto;

    private string _politicaprioritaria;

    private decimal? _poriginal;

    private string _posicao;

    private decimal? _prazomedio;

    private decimal? _precofixo;

    private string _proddescricaocontrato;

    private decimal _ptabela;

    private decimal _pvenda;

    private decimal? _pvenda1;

    private decimal? _pvendaanterior;

    private decimal? _pvendaatac;

    private decimal? _pvendabase;

    private decimal? _pvendaliq;

    private decimal _qt;

    private decimal? _qtcx;

    private decimal? _qtdiasentregaitem;

    private decimal? _qtentregar;

    private decimal? _qtentregue;

    private decimal? _qtentregueaux;

    private decimal? _qtfalta;

    private decimal? _qtimediata;

    private decimal? _qtminimaatacado;

    private decimal? _qtpecas;

    private decimal? _qtposterior;

    private decimal? _qtretira1;

    private decimal? _qtretira2;

    private decimal? _qtretira3;

    private decimal? _qtunitemb;

    private string _refcor;

    private string _rp_imediata;

    private string _siglaqualidade;

    private decimal _st;

    private decimal? _statussucata;

    private decimal? _stclientegnre;

    private decimal? _stpbaserca;

    private decimal? _stptabela;

    private decimal? _taxacasomoedareal;

    private string _tipodescaplicado;

    private string _tipoentrega;

    private string _tipomerc;

    private string _tipopeso;

    private string _truncaritem;

    private decimal? _txvenda;

    private string _unidade;

    private decimal? _vlacresccomplemento;

    private decimal? _vlacresfretekg;

    private decimal? _vlbasepartdest;

    private decimal? _vlbonific;

    private decimal? _vlcustocont;

    private decimal _vlcustofin;

    private decimal _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldesccom;

    private decimal? _vldesccustocmv;

    private decimal? _vldescfin;

    private decimal? _vloutrasdesp;

    private decimal? _vldescflex;

    private decimal? _vldescicmisencao;

    private decimal? _vldescpissuframa;

    private decimal? _vldescrodape;

    private decimal? _vlacrescrodape;

    private decimal? _vldescsuframa;

    private decimal? _vldifaliquotas;

    private decimal? _vlfcppart;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlipi;

    private decimal? _vliss;

    private decimal? _vlredcmvsimplesnac;

    private decimal? _vlredcomiss;

    private decimal? _vlredcomisssup;

    private decimal? _vlredpvendasimplesna;

    private decimal? _vlrepasse;

    private decimal? _vlrmoedaestrageira;

    private decimal? _vlverbacmv;

    private decimal? _vlverbacmvcli;

    private decimal? _volumedesejado;

    private string _versaoservicopartilha;

    private string _desconsiderardescatacado;

    private string _md5paf;

    private string _descricaopaf;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqfcp
    {
        get
        {
            PropriedadeAcessada("Aliqfcp");
            return _aliqfcp;
        }
        set
        {
            PropriedadeModificada("Aliqfcp", value);
            _aliqfcp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms1
    {
        get
        {
            PropriedadeAcessada("Aliqicms1");
            return _aliqicms1;
        }
        set
        {
            PropriedadeModificada("Aliqicms1", value);
            _aliqicms1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Aliqicms2
    {
        get
        {
            PropriedadeAcessada("Aliqicms2");
            return _aliqicms2;
        }
        set
        {
            PropriedadeModificada("Aliqicms2", value);
            _aliqicms2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Aliqinternadest
    {
        get
        {
            PropriedadeAcessada("Aliqinternadest");
            return _aliqinternadest;
        }
        set
        {
            PropriedadeModificada("Aliqinternadest", value);
            _aliqinternadest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Alternativo
    {
        get
        {
            PropriedadeAcessada("Alternativo");
            return _alternativo;
        }
        set
        {
            PropriedadeModificada("Alternativo", value);
            _alternativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Ambiente
    {
        get
        {
            PropriedadeAcessada("Ambiente");
            return _ambiente;
        }
        set
        {
            PropriedadeModificada("Ambiente", value);
            _ambiente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixado
    {
        get
        {
            PropriedadeAcessada("Baixado");
            return _baixado;
        }
        set
        {
            PropriedadeModificada("Baixado", value);
            _baixado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Basedifaliquotas
    {
        get
        {
            PropriedadeAcessada("Basedifaliquotas");
            return _basedifaliquotas;
        }
        set
        {
            PropriedadeModificada("Basedifaliquotas", value);
            _basedifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicst
    {
        get
        {
            PropriedadeAcessada("Baseicst");
            return _baseicst;
        }
        set
        {
            PropriedadeModificada("Baseicst", value);
            _baseicst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bonific
    {
        get
        {
            PropriedadeAcessada("Bonific");
            return _bonific;
        }
        set
        {
            PropriedadeModificada("Bonific", value);
            _bonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Brinde
    {
        get
        {
            PropriedadeAcessada("Brinde");
            return _brinde;
        }
        set
        {
            PropriedadeModificada("Brinde", value);
            _brinde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Chaveprincipal
    {
        get
        {
            PropriedadeAcessada("Chaveprincipal");
            return _chaveprincipal;
        }
        set
        {
            PropriedadeModificada("Chaveprincipal", value);
            _chaveprincipal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codbase
    {
        get
        {
            PropriedadeAcessada("Codbase");
            return _codbase;
        }
        set
        {
            PropriedadeModificada("Codbase", value);
            _codbase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcombo
    {
        get
        {
            PropriedadeAcessada("Codcombo");
            return _codcombo;
        }
        set
        {
            PropriedadeModificada("Codcombo", value);
            _codcombo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitenteitempedido
    {
        get
        {
            PropriedadeAcessada("Codemitenteitempedido");
            return _codemitenteitempedido;
        }
        set
        {
            PropriedadeModificada("Codemitenteitempedido", value);
            _codemitenteitempedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialretira
    {
        get
        {
            PropriedadeAcessada("Codfilialretira");
            return _codfilialretira;
        }
        set
        {
            PropriedadeModificada("Codfilialretira", value);
            _codfilialretira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Codformula
    {
        get
        {
            PropriedadeAcessada("Codformula");
            return _codformula;
        }
        set
        {
            PropriedadeModificada("Codformula", value);
            _codformula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Codicmtab
    {
        get
        {
            PropriedadeAcessada("Codicmtab");
            return _codicmtab;
        }
        set
        {
            PropriedadeModificada("Codicmtab", value);
            _codicmtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codimp
    {
        get
        {
            PropriedadeAcessada("Codimp");
            return _codimp;
        }
        set
        {
            PropriedadeModificada("Codimp", value);
            _codimp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codindicemultiplicador
    {
        get
        {
            PropriedadeAcessada("Codindicemultiplicador");
            return _codindicemultiplicador;
        }
        set
        {
            PropriedadeModificada("Codindicemultiplicador", value);
            _codindicemultiplicador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codmaquina
    {
        get
        {
            PropriedadeAcessada("Codmaquina");
            return _codmaquina;
        }
        set
        {
            PropriedadeModificada("Codmaquina", value);
            _codmaquina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codmoedaestrageira
    {
        get
        {
            PropriedadeAcessada("Codmoedaestrageira");
            return _codmoedaestrageira;
        }
        set
        {
            PropriedadeModificada("Codmoedaestrageira", value);
            _codmoedaestrageira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codofertaorig
    {
        get
        {
            PropriedadeAcessada("Codofertaorig");
            return _codofertaorig;
        }
        set
        {
            PropriedadeModificada("Codofertaorig", value);
            _codofertaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprodcesta
    {
        get
        {
            PropriedadeAcessada("Codprodcesta");
            return _codprodcesta;
        }
        set
        {
            PropriedadeModificada("Codprodcesta", value);
            _codprodcesta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codprodtinta
    {
        get
        {
            PropriedadeAcessada("Codprodtinta");
            return _codprodtinta;
        }
        set
        {
            PropriedadeModificada("Codprodtinta", value);
            _codprodtinta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Codpromocao
    {
        get
        {
            PropriedadeAcessada("Codpromocao");
            return _codpromocao;
        }
        set
        {
            PropriedadeModificada("Codpromocao", value);
            _codpromocao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada("Codst");
            return _codst;
        }
        set
        {
            PropriedadeModificada("Codst", value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Complemento
    {
        get
        {
            PropriedadeAcessada("Complemento");
            return _complemento;
        }
        set
        {
            PropriedadeModificada("Complemento", value);
            _complemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Custofinest
    {
        get
        {
            PropriedadeAcessada("Custofinest");
            return _custofinest;
        }
        set
        {
            PropriedadeModificada("Custofinest", value);
            _custofinest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentrega
    {
        get
        {
            PropriedadeAcessada("Dtentrega");
            return _dtentrega;
        }
        set
        {
            PropriedadeModificada("Dtentrega", value);
            _dtentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada("Dtultalter");
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada("Dtultalter", value);
            _dtultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
    public decimal? Eancodprod
    {
        get
        {
            PropriedadeAcessada("Eancodprod");
            return _eancodprod;
        }
        set
        {
            PropriedadeModificada("Eancodprod", value);
            _eancodprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Escaniado
    {
        get
        {
            PropriedadeAcessada("Escaniado");
            return _escaniado;
        }
        set
        {
            PropriedadeModificada("Escaniado", value);
            _escaniado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Formanegociacao
    {
        get
        {
            PropriedadeAcessada("Formanegociacao");
            return _formanegociacao;
        }
        set
        {
            PropriedadeModificada("Formanegociacao", value);
            _formanegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geragnre_Cnpjcliente
    {
        get
        {
            PropriedadeAcessada("Geragnre_Cnpjcliente");
            return _geragnre_cnpjcliente;
        }
        set
        {
            PropriedadeModificada("Geragnre_Cnpjcliente", value);
            _geragnre_cnpjcliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Grupofaturamento
    {
        get
        {
            PropriedadeAcessada("Grupofaturamento");
            return _grupofaturamento;
        }
        set
        {
            PropriedadeModificada("Grupofaturamento", value);
            _grupofaturamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impressorestaurante
    {
        get
        {
            PropriedadeAcessada("Impressorestaurante");
            return _impressorestaurante;
        }
        set
        {
            PropriedadeModificada("Impressorestaurante", value);
            _impressorestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimerestaurante
    {
        get
        {
            PropriedadeAcessada("Imprimerestaurante");
            return _imprimerestaurante;
        }
        set
        {
            PropriedadeModificada("Imprimerestaurante", value);
            _imprimerestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Iva
    {
        get
        {
            PropriedadeAcessada("Iva");
            return _iva;
        }
        set
        {
            PropriedadeModificada("Iva", value);
            _iva = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Letracomiss
    {
        get
        {
            PropriedadeAcessada("Letracomiss");
            return _letracomiss;
        }
        set
        {
            PropriedadeModificada("Letracomiss", value);
            _letracomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Localizacao
    {
        get
        {
            PropriedadeAcessada("Localizacao");
            return _localizacao;
        }
        set
        {
            PropriedadeModificada("Localizacao", value);
            _localizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Margem
    {
        get
        {
            PropriedadeAcessada("Margem");
            return _margem;
        }
        set
        {
            PropriedadeModificada("Margem", value);
            _margem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada("Matricula");
            return _matricula;
        }
        set
        {
            PropriedadeModificada("Matricula", value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Negociacaoposterior
    {
        get
        {
            PropriedadeAcessada("Negociacaoposterior");
            return _negociacaoposterior;
        }
        set
        {
            PropriedadeModificada("Negociacaoposterior", value);
            _negociacaoposterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada("Numcar");
            return _numcar;
        }
        set
        {
            PropriedadeModificada("Numcar", value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numccf
    {
        get
        {
            PropriedadeAcessada("Numccf");
            return _numccf;
        }
        set
        {
            PropriedadeModificada("Numccf", value);
            _numccf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Numeroetiqimpressa
    {
        get
        {
            PropriedadeAcessada("Numeroetiqimpressa");
            return _numeroetiqimpressa;
        }
        set
        {
            PropriedadeModificada("Numeroetiqimpressa", value);
            _numeroetiqimpressa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numfichaorig
    {
        get
        {
            PropriedadeAcessada("Numfichaorig");
            return _numfichaorig;
        }
        set
        {
            PropriedadeModificada("Numfichaorig", value);
            _numfichaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numitemorca
    {
        get
        {
            PropriedadeAcessada("Numitemorca");
            return _numitemorca;
        }
        set
        {
            PropriedadeModificada("Numitemorca", value);
            _numitemorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numlista
    {
        get
        {
            PropriedadeAcessada("Numlista");
            return _numlista;
        }
        set
        {
            PropriedadeModificada("Numlista", value);
            _numlista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numlote
    {
        get
        {
            PropriedadeAcessada("Numlote");
            return _numlote;
        }
        set
        {
            PropriedadeModificada("Numlote", value);
            _numlote = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numorca
    {
        get
        {
            PropriedadeAcessada("Numorca");
            return _numorca;
        }
        set
        {
            PropriedadeModificada("Numorca", value);
            _numorca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numorcaorig
    {
        get
        {
            PropriedadeAcessada("Numorcaorig");
            return _numorcaorig;
        }
        set
        {
            PropriedadeModificada("Numorcaorig", value);
            _numorcaorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqcesta
    {
        get
        {
            PropriedadeAcessada("Numseqcesta");
            return _numseqcesta;
        }
        set
        {
            PropriedadeModificada("Numseqcesta", value);
            _numseqcesta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqformula
    {
        get
        {
            PropriedadeAcessada("Numseqformula");
            return _numseqformula;
        }
        set
        {
            PropriedadeModificada("Numseqformula", value);
            _numseqformula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqimpressao
    {
        get
        {
            PropriedadeAcessada("Numseqimpressao");
            return _numseqimpressao;
        }
        set
        {
            PropriedadeModificada("Numseqimpressao", value);
            _numseqimpressao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqitemcontrato
    {
        get
        {
            PropriedadeAcessada("Numseqitemcontrato");
            return _numseqitemcontrato;
        }
        set
        {
            PropriedadeModificada("Numseqitemcontrato", value);
            _numseqitemcontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numverbarebcmv
    {
        get
        {
            PropriedadeAcessada("Numverbarebcmv");
            return _numverbarebcmv;
        }
        set
        {
            PropriedadeModificada("Numverbarebcmv", value);
            _numverbarebcmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Observacao
    {
        get
        {
            PropriedadeAcessada("Observacao");
            return _observacao;
        }
        set
        {
            PropriedadeModificada("Observacao", value);
            _observacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Origemst
    {
        get
        {
            PropriedadeAcessada("Origemst");
            return _origemst;
        }
        set
        {
            PropriedadeModificada("Origemst", value);
            _origemst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pauta
    {
        get
        {
            PropriedadeAcessada("Pauta");
            return _pauta;
        }
        set
        {
            PropriedadeModificada("Pauta", value);
            _pauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbaserca
    {
        get
        {
            PropriedadeAcessada("Pbaserca");
            return _pbaserca;
        }
        set
        {
            PropriedadeModificada("Pbaserca", value);
            _pbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pbonific
    {
        get
        {
            PropriedadeAcessada("Pbonific");
            return _pbonific;
        }
        set
        {
            PropriedadeModificada("Pbonific", value);
            _pbonific = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percagregadorst
    {
        get
        {
            PropriedadeAcessada("Percagregadorst");
            return _percagregadorst;
        }
        set
        {
            PropriedadeModificada("Percagregadorst", value);
            _percagregadorst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbasered
    {
        get
        {
            PropriedadeAcessada("Percbasered");
            return _percbasered;
        }
        set
        {
            PropriedadeModificada("Percbasered", value);
            _percbasered = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percbaseredpart
    {
        get
        {
            PropriedadeAcessada("Percbaseredpart");
            return _percbaseredpart;
        }
        set
        {
            PropriedadeModificada("Percbaseredpart", value);
            _percbaseredpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredst
    {
        get
        {
            PropriedadeAcessada("Percbaseredst");
            return _percbaseredst;
        }
        set
        {
            PropriedadeModificada("Percbaseredst", value);
            _percbaseredst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percbaseredstfonte
    {
        get
        {
            PropriedadeAcessada("Percbaseredstfonte");
            return _percbaseredstfonte;
        }
        set
        {
            PropriedadeModificada("Percbaseredstfonte", value);
            _percbaseredstfonte = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percdescquant
    {
        get
        {
            PropriedadeAcessada("Percdescquant");
            return _percdescquant;
        }
        set
        {
            PropriedadeModificada("Percdescquant", value);
            _percdescquant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Percdesc_Politica
    {
        get
        {
            PropriedadeAcessada("Percdesc_Politica");
            return _percdesc_politica;
        }
        set
        {
            PropriedadeModificada("Percdesc_Politica", value);
            _percdesc_politica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percdifaliquotas
    {
        get
        {
            PropriedadeAcessada("Percdifaliquotas");
            return _percdifaliquotas;
        }
        set
        {
            PropriedadeModificada("Percdifaliquotas", value);
            _percdifaliquotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Percipi
    {
        get
        {
            PropriedadeAcessada("Percipi");
            return _percipi;
        }
        set
        {
            PropriedadeModificada("Percipi", value);
            _percipi = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perciss
    {
        get
        {
            PropriedadeAcessada("Perciss");
            return _perciss;
        }
        set
        {
            PropriedadeModificada("Perciss", value);
            _perciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal Percom
    {
        get
        {
            PropriedadeAcessada("Percom");
            return _percom;
        }
        set
        {
            PropriedadeModificada("Percom", value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom2
    {
        get
        {
            PropriedadeAcessada("Percom2");
            return _percom2;
        }
        set
        {
            PropriedadeModificada("Percom2", value);
            _percom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom3
    {
        get
        {
            PropriedadeAcessada("Percom3");
            return _percom3;
        }
        set
        {
            PropriedadeModificada("Percom3", value);
            _percom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percom4
    {
        get
        {
            PropriedadeAcessada("Percom4");
            return _percom4;
        }
        set
        {
            PropriedadeModificada("Percom4", value);
            _percom4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percomprof
    {
        get
        {
            PropriedadeAcessada("Percomprof");
            return _percomprof;
        }
        set
        {
            PropriedadeModificada("Percomprof", value);
            _percomprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomsup
    {
        get
        {
            PropriedadeAcessada("Percomsup");
            return _percomsup;
        }
        set
        {
            PropriedadeModificada("Percomsup", value);
            _percomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomtab
    {
        get
        {
            PropriedadeAcessada("Percomtab");
            return _percomtab;
        }
        set
        {
            PropriedadeModificada("Percomtab", value);
            _percomtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percprovpart
    {
        get
        {
            PropriedadeAcessada("Percprovpart");
            return _percprovpart;
        }
        set
        {
            PropriedadeModificada("Percprovpart", value);
            _percprovpart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percvenda
    {
        get
        {
            PropriedadeAcessada("Percvenda");
            return _percvenda;
        }
        set
        {
            PropriedadeModificada("Percvenda", value);
            _percvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Perdesc
    {
        get
        {
            PropriedadeAcessada("Perdesc");
            return _perdesc;
        }
        set
        {
            PropriedadeModificada("Perdesc", value);
            _perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescaux
    {
        get
        {
            PropriedadeAcessada("Perdescaux");
            return _perdescaux;
        }
        set
        {
            PropriedadeModificada("Perdescaux", value);
            _perdescaux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescavista
    {
        get
        {
            PropriedadeAcessada("Perdescavista");
            return _perdescavista;
        }
        set
        {
            PropriedadeModificada("Perdescavista", value);
            _perdescavista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesccusto
    {
        get
        {
            PropriedadeAcessada("Perdesccusto");
            return _perdesccusto;
        }
        set
        {
            PropriedadeModificada("Perdesccusto", value);
            _perdesccusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Perdescfin
    {
        get
        {
            PropriedadeAcessada("Perdescfin");
            return _perdescfin;
        }
        set
        {
            PropriedadeModificada("Perdescfin", value);
            _perdescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescflex
    {
        get
        {
            PropriedadeAcessada("Perdescflex");
            return _perdescflex;
        }
        set
        {
            PropriedadeModificada("Perdescflex", value);
            _perdescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perdescisentoicms
    {
        get
        {
            PropriedadeAcessada("Perdescisentoicms");
            return _perdescisentoicms;
        }
        set
        {
            PropriedadeModificada("Perdescisentoicms", value);
            _perdescisentoicms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescnegociado
    {
        get
        {
            PropriedadeAcessada("Perdescnegociado");
            return _perdescnegociado;
        }
        set
        {
            PropriedadeModificada("Perdescnegociado", value);
            _perdescnegociado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perdescpauta
    {
        get
        {
            PropriedadeAcessada("Perdescpauta");
            return _perdescpauta;
        }
        set
        {
            PropriedadeModificada("Perdescpauta", value);
            _perdescpauta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Perdescpolitica
    {
        get
        {
            PropriedadeAcessada("Perdescpolitica");
            return _perdescpolitica;
        }
        set
        {
            PropriedadeModificada("Perdescpolitica", value);
            _perdescpolitica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perdesctab
    {
        get
        {
            PropriedadeAcessada("Perdesctab");
            return _perdesctab;
        }
        set
        {
            PropriedadeModificada("Perdesctab", value);
            _perdesctab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Perfretecmv
    {
        get
        {
            PropriedadeAcessada("Perfretecmv");
            return _perfretecmv;
        }
        set
        {
            PropriedadeModificada("Perfretecmv", value);
            _perfretecmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomiss
    {
        get
        {
            PropriedadeAcessada("Perredcomiss");
            return _perredcomiss;
        }
        set
        {
            PropriedadeModificada("Perredcomiss", value);
            _perredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Perredcomisssup
    {
        get
        {
            PropriedadeAcessada("Perredcomisssup");
            return _perredcomisssup;
        }
        set
        {
            PropriedadeModificada("Perredcomisssup", value);
            _perredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 3)]
    public decimal? Pesobruto
    {
        get
        {
            PropriedadeAcessada("Pesobruto");
            return _pesobruto;
        }
        set
        {
            PropriedadeModificada("Pesobruto", value);
            _pesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Politicaprioritaria
    {
        get
        {
            PropriedadeAcessada("Politicaprioritaria");
            return _politicaprioritaria;
        }
        set
        {
            PropriedadeModificada("Politicaprioritaria", value);
            _politicaprioritaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Posicao
    {
        get
        {
            PropriedadeAcessada("Posicao");
            return _posicao;
        }
        set
        {
            PropriedadeModificada("Posicao", value);
            _posicao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomedio
    {
        get
        {
            PropriedadeAcessada("Prazomedio");
            return _prazomedio;
        }
        set
        {
            PropriedadeModificada("Prazomedio", value);
            _prazomedio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precofixo
    {
        get
        {
            PropriedadeAcessada("Precofixo");
            return _precofixo;
        }
        set
        {
            PropriedadeModificada("Precofixo", value);
            _precofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 300, Precisao = 0)]
    public string Proddescricaocontrato
    {
        get
        {
            PropriedadeAcessada("Proddescricaocontrato");
            return _proddescricaocontrato;
        }
        set
        {
            PropriedadeModificada("Proddescricaocontrato", value);
            _proddescricaocontrato = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal Ptabela
    {
        get
        {
            PropriedadeAcessada("Ptabela");
            return _ptabela;
        }
        set
        {
            PropriedadeModificada("Ptabela", value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 19, Precisao = 6)]
    public decimal Pvenda
    {
        get
        {
            PropriedadeAcessada("Pvenda");
            return _pvenda;
        }
        set
        {
            PropriedadeModificada("Pvenda", value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda1
    {
        get
        {
            PropriedadeAcessada("Pvenda1");
            return _pvenda1;
        }
        set
        {
            PropriedadeModificada("Pvenda1", value);
            _pvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaanterior
    {
        get
        {
            PropriedadeAcessada("Pvendaanterior");
            return _pvendaanterior;
        }
        set
        {
            PropriedadeModificada("Pvendaanterior", value);
            _pvendaanterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendaatac
    {
        get
        {
            PropriedadeAcessada("Pvendaatac");
            return _pvendaatac;
        }
        set
        {
            PropriedadeModificada("Pvendaatac", value);
            _pvendaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendabase
    {
        get
        {
            PropriedadeAcessada("Pvendabase");
            return _pvendabase;
        }
        set
        {
            PropriedadeModificada("Pvendabase", value);
            _pvendabase = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaliq
    {
        get
        {
            PropriedadeAcessada("Pvendaliq");
            return _pvendaliq;
        }
        set
        {
            PropriedadeModificada("Pvendaliq", value);
            _pvendaliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal Qt
    {
        get
        {
            PropriedadeAcessada("Qt");
            return _qt;
        }
        set
        {
            PropriedadeModificada("Qt", value);
            _qt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtcx
    {
        get
        {
            PropriedadeAcessada("Qtcx");
            return _qtcx;
        }
        set
        {
            PropriedadeModificada("Qtcx", value);
            _qtcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtdiasentregaitem
    {
        get
        {
            PropriedadeAcessada("Qtdiasentregaitem");
            return _qtdiasentregaitem;
        }
        set
        {
            PropriedadeModificada("Qtdiasentregaitem", value);
            _qtdiasentregaitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtentregar
    {
        get
        {
            PropriedadeAcessada("Qtentregar");
            return _qtentregar;
        }
        set
        {
            PropriedadeModificada("Qtentregar", value);
            _qtentregar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtentregue
    {
        get
        {
            PropriedadeAcessada("Qtentregue");
            return _qtentregue;
        }
        set
        {
            PropriedadeModificada("Qtentregue", value);
            _qtentregue = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtentregueaux
    {
        get
        {
            PropriedadeAcessada("Qtentregueaux");
            return _qtentregueaux;
        }
        set
        {
            PropriedadeModificada("Qtentregueaux", value);
            _qtentregueaux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtfalta
    {
        get
        {
            PropriedadeAcessada("Qtfalta");
            return _qtfalta;
        }
        set
        {
            PropriedadeModificada("Qtfalta", value);
            _qtfalta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtimediata
    {
        get
        {
            PropriedadeAcessada("Qtimediata");
            return _qtimediata;
        }
        set
        {
            PropriedadeModificada("Qtimediata", value);
            _qtimediata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Qtpecas
    {
        get
        {
            PropriedadeAcessada("Qtpecas");
            return _qtpecas;
        }
        set
        {
            PropriedadeModificada("Qtpecas", value);
            _qtpecas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtposterior
    {
        get
        {
            PropriedadeAcessada("Qtposterior");
            return _qtposterior;
        }
        set
        {
            PropriedadeModificada("Qtposterior", value);
            _qtposterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtretira1
    {
        get
        {
            PropriedadeAcessada("Qtretira1");
            return _qtretira1;
        }
        set
        {
            PropriedadeModificada("Qtretira1", value);
            _qtretira1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtretira2
    {
        get
        {
            PropriedadeAcessada("Qtretira2");
            return _qtretira2;
        }
        set
        {
            PropriedadeModificada("Qtretira2", value);
            _qtretira2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtretira3
    {
        get
        {
            PropriedadeAcessada("Qtretira3");
            return _qtretira3;
        }
        set
        {
            PropriedadeModificada("Qtretira3", value);
            _qtretira3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtunitemb
    {
        get
        {
            PropriedadeAcessada("Qtunitemb");
            return _qtunitemb;
        }
        set
        {
            PropriedadeModificada("Qtunitemb", value);
            _qtunitemb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Refcor
    {
        get
        {
            PropriedadeAcessada("Refcor");
            return _refcor;
        }
        set
        {
            PropriedadeModificada("Refcor", value);
            _refcor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Rp_Imediata
    {
        get
        {
            PropriedadeAcessada("Rp_Imediata");
            return _rp_imediata;
        }
        set
        {
            PropriedadeModificada("Rp_Imediata", value);
            _rp_imediata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Siglaqualidade
    {
        get
        {
            PropriedadeAcessada("Siglaqualidade");
            return _siglaqualidade;
        }
        set
        {
            PropriedadeModificada("Siglaqualidade", value);
            _siglaqualidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal St
    {
        get
        {
            PropriedadeAcessada("St");
            return _st;
        }
        set
        {
            PropriedadeModificada("St", value);
            _st = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Statussucata
    {
        get
        {
            PropriedadeAcessada("Statussucata");
            return _statussucata;
        }
        set
        {
            PropriedadeModificada("Statussucata", value);
            _statussucata = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stclientegnre
    {
        get
        {
            PropriedadeAcessada("Stclientegnre");
            return _stclientegnre;
        }
        set
        {
            PropriedadeModificada("Stclientegnre", value);
            _stclientegnre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stpbaserca
    {
        get
        {
            PropriedadeAcessada("Stpbaserca");
            return _stpbaserca;
        }
        set
        {
            PropriedadeModificada("Stpbaserca", value);
            _stpbaserca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Stptabela
    {
        get
        {
            PropriedadeAcessada("Stptabela");
            return _stptabela;
        }
        set
        {
            PropriedadeModificada("Stptabela", value);
            _stptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Taxacasomoedareal
    {
        get
        {
            PropriedadeAcessada("Taxacasomoedareal");
            return _taxacasomoedareal;
        }
        set
        {
            PropriedadeModificada("Taxacasomoedareal", value);
            _taxacasomoedareal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipodescaplicado
    {
        get
        {
            PropriedadeAcessada("Tipodescaplicado");
            return _tipodescaplicado;
        }
        set
        {
            PropriedadeModificada("Tipodescaplicado", value);
            _tipodescaplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipoentrega
    {
        get
        {
            PropriedadeAcessada("Tipoentrega");
            return _tipoentrega;
        }
        set
        {
            PropriedadeModificada("Tipoentrega", value);
            _tipoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipomerc
    {
        get
        {
            PropriedadeAcessada("Tipomerc");
            return _tipomerc;
        }
        set
        {
            PropriedadeModificada("Tipomerc", value);
            _tipomerc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopeso
    {
        get
        {
            PropriedadeAcessada("Tipopeso");
            return _tipopeso;
        }
        set
        {
            PropriedadeModificada("Tipopeso", value);
            _tipopeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Truncaritem
    {
        get
        {
            PropriedadeAcessada("Truncaritem");
            return _truncaritem;
        }
        set
        {
            PropriedadeModificada("Truncaritem", value);
            _truncaritem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
    public decimal? Txvenda
    {
        get
        {
            PropriedadeAcessada("Txvenda");
            return _txvenda;
        }
        set
        {
            PropriedadeModificada("Txvenda", value);
            _txvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidade
    {
        get
        {
            PropriedadeAcessada("Unidade");
            return _unidade;
        }
        set
        {
            PropriedadeModificada("Unidade", value);
            _unidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacresccomplemento
    {
        get
        {
            PropriedadeAcessada("Vlacresccomplemento");
            return _vlacresccomplemento;
        }
        set
        {
            PropriedadeModificada("Vlacresccomplemento", value);
            _vlacresccomplemento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Vlacresfretekg
    {
        get
        {
            PropriedadeAcessada("Vlacresfretekg");
            return _vlacresfretekg;
        }
        set
        {
            PropriedadeModificada("Vlacresfretekg", value);
            _vlacresfretekg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlbasepartdest
    {
        get
        {
            PropriedadeAcessada("Vlbasepartdest");
            return _vlbasepartdest;
        }
        set
        {
            PropriedadeModificada("Vlbasepartdest", value);
            _vlbasepartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustocont
    {
        get
        {
            PropriedadeAcessada("Vlcustocont");
            return _vlcustocont;
        }
        set
        {
            PropriedadeModificada("Vlcustocont", value);
            _vlcustocont = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustofin
    {
        get
        {
            PropriedadeAcessada("Vlcustofin");
            return _vlcustofin;
        }
        set
        {
            PropriedadeModificada("Vlcustofin", value);
            _vlcustofin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Vlcustoreal
    {
        get
        {
            PropriedadeAcessada("Vlcustoreal");
            return _vlcustoreal;
        }
        set
        {
            PropriedadeModificada("Vlcustoreal", value);
            _vlcustoreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlcustorep
    {
        get
        {
            PropriedadeAcessada("Vlcustorep");
            return _vlcustorep;
        }
        set
        {
            PropriedadeModificada("Vlcustorep", value);
            _vlcustorep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vldesccustocmv
    {
        get
        {
            PropriedadeAcessada("Vldesccustocmv");
            return _vldesccustocmv;
        }
        set
        {
            PropriedadeModificada("Vldesccustocmv", value);
            _vldesccustocmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescfin
    {
        get
        {
            PropriedadeAcessada("Vldescfin");
            return _vldescfin;
        }
        set
        {
            PropriedadeModificada("Vldescfin", value);
            _vldescfin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutrasdesp
    {
        get
        {
            PropriedadeAcessada("Vloutrasdesp");
            return _vloutrasdesp;
        }
        set
        {
            PropriedadeModificada("Vloutrasdesp", value);
            _vloutrasdesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescflex
    {
        get
        {
            PropriedadeAcessada("Vldescflex");
            return _vldescflex;
        }
        set
        {
            PropriedadeModificada("Vldescflex", value);
            _vldescflex = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescicmisencao
    {
        get
        {
            PropriedadeAcessada("Vldescicmisencao");
            return _vldescicmisencao;
        }
        set
        {
            PropriedadeModificada("Vldescicmisencao", value);
            _vldescicmisencao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescpissuframa
    {
        get
        {
            PropriedadeAcessada("Vldescpissuframa");
            return _vldescpissuframa;
        }
        set
        {
            PropriedadeModificada("Vldescpissuframa", value);
            _vldescpissuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescrodape
    {
        get
        {
            PropriedadeAcessada("Vldescrodape");
            return _vldescrodape;
        }
        set
        {
            PropriedadeModificada("Vldescrodape", value);
            _vldescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescrodape
    {
        get
        {
            PropriedadeAcessada("Vldescrodape");
            return _vlacrescrodape;
        }
        set
        {
            PropriedadeModificada("Vlacrescrodape", value);
            _vlacrescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldescsuframa
    {
        get
        {
            PropriedadeAcessada("Vldescsuframa");
            return _vldescsuframa;
        }
        set
        {
            PropriedadeModificada("Vldescsuframa", value);
            _vldescsuframa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfcppart
    {
        get
        {
            PropriedadeAcessada("Vlfcppart");
            return _vlfcppart;
        }
        set
        {
            PropriedadeModificada("Vlfcppart", value);
            _vlfcppart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspart
    {
        get
        {
            PropriedadeAcessada("Vlicmspart");
            return _vlicmspart;
        }
        set
        {
            PropriedadeModificada("Vlicmspart", value);
            _vlicmspart = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartdest
    {
        get
        {
            PropriedadeAcessada("Vlicmspartdest");
            return _vlicmspartdest;
        }
        set
        {
            PropriedadeModificada("Vlicmspartdest", value);
            _vlicmspartdest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmspartrem
    {
        get
        {
            PropriedadeAcessada("Vlicmspartrem");
            return _vlicmspartrem;
        }
        set
        {
            PropriedadeModificada("Vlicmspartrem", value);
            _vlicmspartrem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vliss
    {
        get
        {
            PropriedadeAcessada("Vliss");
            return _vliss;
        }
        set
        {
            PropriedadeModificada("Vliss", value);
            _vliss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomiss
    {
        get
        {
            PropriedadeAcessada("Vlredcomiss");
            return _vlredcomiss;
        }
        set
        {
            PropriedadeModificada("Vlredcomiss", value);
            _vlredcomiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlredcomisssup
    {
        get
        {
            PropriedadeAcessada("Vlredcomisssup");
            return _vlredcomisssup;
        }
        set
        {
            PropriedadeModificada("Vlredcomisssup", value);
            _vlredcomisssup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlrmoedaestrageira
    {
        get
        {
            PropriedadeAcessada("Vlrmoedaestrageira");
            return _vlrmoedaestrageira;
        }
        set
        {
            PropriedadeModificada("Vlrmoedaestrageira", value);
            _vlrmoedaestrageira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmv
    {
        get
        {
            PropriedadeAcessada("Vlverbacmv");
            return _vlverbacmv;
        }
        set
        {
            PropriedadeModificada("Vlverbacmv", value);
            _vlverbacmv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlverbacmvcli
    {
        get
        {
            PropriedadeAcessada("Vlverbacmvcli");
            return _vlverbacmvcli;
        }
        set
        {
            PropriedadeModificada("Vlverbacmvcli", value);
            _vlverbacmvcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Volumedesejado
    {
        get
        {
            PropriedadeAcessada("Volumedesejado");
            return _volumedesejado;
        }
        set
        {
            PropriedadeModificada("Volumedesejado", value);
            _volumedesejado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Versaoservicopartilha
    {
        get
        {
            PropriedadeAcessada("Versaoservicopartilha");
            return _versaoservicopartilha;
        }
        set
        {
            PropriedadeModificada("Versaoservicopartilha", value);
            _versaoservicopartilha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Desconsiderardescatacado
    {
        get
        {
            PropriedadeAcessada("Desconsiderardescatacado");
            return _desconsiderardescatacado;
        }
        set
        {
            PropriedadeModificada("Desconsiderardescatacado", value);
            _desconsiderardescatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Md5paf
    {
        get
        {
            PropriedadeAcessada("Md5paf");
            return _md5paf;
        }
        set
        {
            PropriedadeModificada("Md5paf", value);
            _md5paf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCORCAVENDAI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Descricaopaf
    {
        get
        {
            PropriedadeAcessada("Descricaopaf");
            return _descricaopaf;
        }
        set
        {
            PropriedadeModificada("Descricaopaf", value);
            _descricaopaf = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCORCAVENDAI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aliqfcp = AlterarTipo<decimal?>(leitor["Aliqfcp"]);
        _aliqicms1 = AlterarTipo<decimal?>(leitor["Aliqicms1"]);
        _aliqicms2 = AlterarTipo<decimal?>(leitor["Aliqicms2"]);
        _aliqinternadest = AlterarTipo<decimal?>(leitor["Aliqinternadest"]);
        _alternativo = AlterarTipo<string>(leitor["Alternativo"]);
        _ambiente = AlterarTipo<string>(leitor["Ambiente"]);
        _baixado = AlterarTipo<string>(leitor["Baixado"]);
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _bonific = AlterarTipo<string>(leitor["Bonific"]);
        _brinde = AlterarTipo<string>(leitor["Brinde"]);
        _chaveprincipal = AlterarTipo<string>(leitor["Chaveprincipal"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codbase = AlterarTipo<string>(leitor["Codbase"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codcombo = AlterarTipo<decimal?>(leitor["Codcombo"]);
        _coddesconto = AlterarTipo<decimal?>(leitor["Coddesconto"]);
        _codemitenteitempedido = AlterarTipo<decimal?>(leitor["Codemitenteitempedido"]);
        _codfilialretira = AlterarTipo<string>(leitor["Codfilialretira"]);
        _codformula = AlterarTipo<string>(leitor["Codformula"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codimp = AlterarTipo<decimal?>(leitor["Codimp"]);
        _codindicemultiplicador = AlterarTipo<decimal?>(leitor["Codindicemultiplicador"]);
        _codmaquina = AlterarTipo<decimal?>(leitor["Codmaquina"]);
        _codmoedaestrageira = AlterarTipo<decimal?>(leitor["Codmoedaestrageira"]);
        _codofertaorig = AlterarTipo<decimal?>(leitor["Codofertaorig"]);
        _codprecofixo = AlterarTipo<decimal?>(leitor["Codprecofixo"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodcesta = AlterarTipo<decimal?>(leitor["Codprodcesta"]);
        _codprodtinta = AlterarTipo<string>(leitor["Codprodtinta"]);
        _codpromocao = AlterarTipo<string>(leitor["Codpromocao"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _complemento = AlterarTipo<string>(leitor["Complemento"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtentrega = AlterarTipo<DateTime?>(leitor["Dtentrega"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _eancodprod = AlterarTipo<decimal?>(leitor["Eancodprod"]);
        _escaniado = AlterarTipo<decimal?>(leitor["Escaniado"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _fatorpreco = AlterarTipo<decimal?>(leitor["Fatorpreco"]);
        _formanegociacao = AlterarTipo<string>(leitor["Formanegociacao"]);
        _geragnre_cnpjcliente = AlterarTipo<string>(leitor["Geragnre_Cnpjcliente"]);
        _grupofaturamento = AlterarTipo<string>(leitor["Grupofaturamento"]);
        _impressorestaurante = AlterarTipo<string>(leitor["Impressorestaurante"]);
        _imprimerestaurante = AlterarTipo<string>(leitor["Imprimerestaurante"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _letracomiss = AlterarTipo<string>(leitor["Letracomiss"]);
        _localizacao = AlterarTipo<string>(leitor["Localizacao"]);
        _margem = AlterarTipo<decimal?>(leitor["Margem"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _negociacaoposterior = AlterarTipo<string>(leitor["Negociacaoposterior"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
        _numeroetiqimpressa = AlterarTipo<decimal?>(leitor["Numeroetiqimpressa"]);
        _numfichaorig = AlterarTipo<decimal?>(leitor["Numfichaorig"]);
        _numitemorca = AlterarTipo<decimal?>(leitor["Numitemorca"]);
        _numlista = AlterarTipo<decimal?>(leitor["Numlista"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numorca = AlterarTipo<decimal>(leitor["Numorca"]);
        _numorcaorig = AlterarTipo<decimal?>(leitor["Numorcaorig"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numseqcesta = AlterarTipo<decimal?>(leitor["Numseqcesta"]);
        _numseqformula = AlterarTipo<decimal?>(leitor["Numseqformula"]);
        _numseqimpressao = AlterarTipo<decimal?>(leitor["Numseqimpressao"]);
        _numseqitemcontrato = AlterarTipo<decimal?>(leitor["Numseqitemcontrato"]);
        _numverbarebcmv = AlterarTipo<decimal?>(leitor["Numverbarebcmv"]);
        _observacao = AlterarTipo<string>(leitor["Observacao"]);
        _origemst = AlterarTipo<string>(leitor["Origemst"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _pbonific = AlterarTipo<decimal?>(leitor["Pbonific"]);
        _perbonific = AlterarTipo<decimal?>(leitor["Perbonific"]);
        _percagregadorst = AlterarTipo<decimal?>(leitor["Percagregadorst"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percdescquant = AlterarTipo<decimal?>(leitor["Percdescquant"]);
        _percdesc_politica = AlterarTipo<decimal?>(leitor["Percdesc_Politica"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percom = AlterarTipo<decimal>(leitor["Percom"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _percomprof = AlterarTipo<decimal?>(leitor["Percomprof"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _percomtab = AlterarTipo<decimal?>(leitor["Percomtab"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _percredaliqipi = AlterarTipo<decimal?>(leitor["Percredaliqipi"]);
        _percvenda = AlterarTipo<decimal?>(leitor["Percvenda"]);
        _perdesc = AlterarTipo<decimal>(leitor["Perdesc"]);
        _perdescaux = AlterarTipo<decimal?>(leitor["Perdescaux"]);
        _perdescavista = AlterarTipo<decimal?>(leitor["Perdescavista"]);
        _perdesccom = AlterarTipo<decimal?>(leitor["Perdesccom"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdescfin = AlterarTipo<decimal?>(leitor["Perdescfin"]);
        _perdescflex = AlterarTipo<decimal?>(leitor["Perdescflex"]);
        _perdescisentoicms = AlterarTipo<decimal?>(leitor["Perdescisentoicms"]);
        _perdescnegociado = AlterarTipo<decimal?>(leitor["Perdescnegociado"]);
        _perdescpauta = AlterarTipo<decimal?>(leitor["Perdescpauta"]);
        _perdescpolitica = AlterarTipo<decimal?>(leitor["Perdescpolitica"]);
        _perdesctab = AlterarTipo<decimal?>(leitor["Perdesctab"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _perredcomiss = AlterarTipo<decimal?>(leitor["Perredcomiss"]);
        _perredcomisssup = AlterarTipo<decimal?>(leitor["Perredcomisssup"]);
        _pesobruto = AlterarTipo<decimal?>(leitor["Pesobruto"]);
        _politicaprioritaria = AlterarTipo<string>(leitor["Politicaprioritaria"]);
        _poriginal = AlterarTipo<decimal?>(leitor["Poriginal"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _prazomedio = AlterarTipo<decimal?>(leitor["Prazomedio"]);
        _precofixo = AlterarTipo<decimal?>(leitor["Precofixo"]);
        _proddescricaocontrato = AlterarTipo<string>(leitor["Proddescricaocontrato"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _pvenda1 = AlterarTipo<decimal?>(leitor["Pvenda1"]);
        _pvendaanterior = AlterarTipo<decimal?>(leitor["Pvendaanterior"]);
        _pvendaatac = AlterarTipo<decimal?>(leitor["Pvendaatac"]);
        _pvendabase = AlterarTipo<decimal?>(leitor["Pvendabase"]);
        _pvendaliq = AlterarTipo<decimal?>(leitor["Pvendaliq"]);
        _qt = AlterarTipo<decimal>(leitor["Qt"]);
        _qtcx = AlterarTipo<decimal?>(leitor["Qtcx"]);
        _qtdiasentregaitem = AlterarTipo<decimal?>(leitor["Qtdiasentregaitem"]);
        _qtentregar = AlterarTipo<decimal?>(leitor["Qtentregar"]);
        _qtentregue = AlterarTipo<decimal?>(leitor["Qtentregue"]);
        _qtentregueaux = AlterarTipo<decimal?>(leitor["Qtentregueaux"]);
        _qtfalta = AlterarTipo<decimal?>(leitor["Qtfalta"]);
        _qtimediata = AlterarTipo<decimal?>(leitor["Qtimediata"]);
        _qtminimaatacado = AlterarTipo<decimal?>(leitor["Qtminimaatacado"]);
        _qtpecas = AlterarTipo<decimal?>(leitor["Qtpecas"]);
        _qtposterior = AlterarTipo<decimal?>(leitor["Qtposterior"]);
        _qtretira1 = AlterarTipo<decimal?>(leitor["Qtretira1"]);
        _qtretira2 = AlterarTipo<decimal?>(leitor["Qtretira2"]);
        _qtretira3 = AlterarTipo<decimal?>(leitor["Qtretira3"]);
        _qtunitemb = AlterarTipo<decimal?>(leitor["Qtunitemb"]);
        _refcor = AlterarTipo<string>(leitor["Refcor"]);
        _rp_imediata = AlterarTipo<string>(leitor["Rp_Imediata"]);
        _siglaqualidade = AlterarTipo<string>(leitor["Siglaqualidade"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _statussucata = AlterarTipo<decimal?>(leitor["Statussucata"]);
        _stclientegnre = AlterarTipo<decimal?>(leitor["Stclientegnre"]);
        _stpbaserca = AlterarTipo<decimal?>(leitor["Stpbaserca"]);
        _stptabela = AlterarTipo<decimal?>(leitor["Stptabela"]);
        _taxacasomoedareal = AlterarTipo<decimal?>(leitor["Taxacasomoedareal"]);
        _tipodescaplicado = AlterarTipo<string>(leitor["Tipodescaplicado"]);
        _tipoentrega = AlterarTipo<string>(leitor["Tipoentrega"]);
        _tipomerc = AlterarTipo<string>(leitor["Tipomerc"]);
        _tipopeso = AlterarTipo<string>(leitor["Tipopeso"]);
        _truncaritem = AlterarTipo<string>(leitor["Truncaritem"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _unidade = AlterarTipo<string>(leitor["Unidade"]);
        _vlacresccomplemento = AlterarTipo<decimal?>(leitor["Vlacresccomplemento"]);
        _vlacresfretekg = AlterarTipo<decimal?>(leitor["Vlacresfretekg"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlbonific = AlterarTipo<decimal?>(leitor["Vlbonific"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldesccom = AlterarTipo<decimal?>(leitor["Vldesccom"]);
        _vldesccustocmv = AlterarTipo<decimal?>(leitor["Vldesccustocmv"]);
        _vldescfin = AlterarTipo<decimal?>(leitor["Vldescfin"]);
        _vloutrasdesp = AlterarTipo<decimal?>(leitor["Vloutrasdesp"]);
        _vldescflex = AlterarTipo<decimal?>(leitor["Vldescflex"]);
        _vldescicmisencao = AlterarTipo<decimal?>(leitor["Vldescicmisencao"]);
        _vldescpissuframa = AlterarTipo<decimal?>(leitor["Vldescpissuframa"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlredcmvsimplesnac = AlterarTipo<decimal?>(leitor["Vlredcmvsimplesnac"]);
        _vlredcomiss = AlterarTipo<decimal?>(leitor["Vlredcomiss"]);
        _vlredcomisssup = AlterarTipo<decimal?>(leitor["Vlredcomisssup"]);
        _vlredpvendasimplesna = AlterarTipo<decimal?>(leitor["Vlredpvendasimplesna"]);
        _vlrepasse = AlterarTipo<decimal?>(leitor["Vlrepasse"]);
        _vlrmoedaestrageira = AlterarTipo<decimal?>(leitor["Vlrmoedaestrageira"]);
        _vlverbacmv = AlterarTipo<decimal?>(leitor["Vlverbacmv"]);
        _vlverbacmvcli = AlterarTipo<decimal?>(leitor["Vlverbacmvcli"]);
        _volumedesejado = AlterarTipo<decimal?>(leitor["Volumedesejado"]);
        _versaoservicopartilha = AlterarTipo<string>(leitor["Versaoservicopartilha"]);
        _desconsiderardescatacado = AlterarTipo<string>(leitor["Desconsiderardescatacado"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _descricaopaf = AlterarTipo<string>(leitor["Descricaopaf"]);
    }

}