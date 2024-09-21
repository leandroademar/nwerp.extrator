

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPEDICESTA : GerenteDePropriedades, IEntidade
{
    private decimal? _aliqfcp;

    private decimal? _aliqicms1;

    private decimal? _aliqicms2;

    private decimal? _aliqinternadest;

    private decimal? _basedifaliquotas;

    private decimal? _baseicst;

    private decimal? _baseicst_ant_rateio;

    private decimal? _codauxiliar;

    private string _codecf;

    private decimal? _codicmtab;

    private decimal _codprod;

    private decimal _codprodmp;

    private string _codprodtinta;

    private decimal? _codst;

    private decimal? _custofinest;

    private decimal? _iva;

    private decimal _numped;

    private decimal _numseq;

    private decimal? _pauta;

    private decimal? _pbaserca;

    private decimal? _percbasered;

    private decimal? _percbaseredpart;

    private decimal? _percbaseredst;

    private decimal? _percbaseredstfonte;

    private decimal? _percdifaliquotas;

    private decimal? _percipi;

    private decimal? _perciss;

    private decimal _percom;

    private decimal? _percom2;

    private decimal? _percom3;

    private decimal? _percom4;

    private decimal? _percprovpart;

    private decimal? _percredaliqipi;

    private decimal? _perctributos;

    private decimal? _perdesccusto;

    private decimal? _perdescpolitica;

    private decimal? _perdesctab;

    private decimal? _perfretecmv;

    private decimal _ptabela;

    private decimal _pvenda;

    private decimal? _pvendaanterior;

    private decimal? _qtmp;

    private decimal? _qtunitemb;

    private decimal _st;

    private decimal? _stclientegnre;

    private decimal? _st_ant_rateio;

    private decimal? _st_dif_rateio;

    private decimal? _txvenda;

    private decimal? _vlacrescrodape;

    private decimal? _vlbasepartdest;

    private decimal? _vlcustocont;

    private decimal _vlcustofin;

    private decimal _vlcustoreal;

    private decimal? _vlcustorep;

    private decimal? _vldesccustocmv;

    private decimal? _vldescrodape;

    private decimal? _vldescsuframa;

    private decimal? _vldifaliquotas;

    private decimal? _vlfcppart;

    private decimal? _vlfrete_rateio;

    private decimal? _vlicmsdifaliqpart;

    private decimal? _vlicmspart;

    private decimal? _vlicmspartdest;

    private decimal? _vlicmspartrem;

    private decimal? _vlipi;

    private decimal? _vliss;

    private decimal? _vlitemtributos;

    private decimal? _vloutras_rateio;

    private string _numlote;

    private decimal? _numseqitem;

    private DateTime? _data;

    private decimal? _vlicmsdesoneracao;

    private string _codmotivoicmsdesonerado;

    private static readonly string RO_QBCMONORET = "Qbcmonoret";

    private decimal? _qbcmonoret;

    private static readonly string RO_ADREMICMSRET = "Adremicmsret";

    private decimal? _adremicmsret;

    private static readonly string RO_VICMSMONORET = "Vicmsmonoret";

    private decimal? _vicmsmonoret;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Baseicst_Ant_Rateio
    {
        get
        {
            PropriedadeAcessada("Baseicst_Ant_Rateio");
            return _baseicst_ant_rateio;
        }
        set
        {
            PropriedadeModificada("Baseicst_Ant_Rateio", value);
            _baseicst_ant_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codecf
    {
        get
        {
            PropriedadeAcessada("Codecf");
            return _codecf;
        }
        set
        {
            PropriedadeModificada("Codecf", value);
            _codecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprodmp
    {
        get
        {
            PropriedadeAcessada("Codprodmp");
            return _codprodmp;
        }
        set
        {
            PropriedadeModificada("Codprodmp", value);
            _codprodmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perctributos
    {
        get
        {
            PropriedadeAcessada("Perctributos");
            return _perctributos;
        }
        set
        {
            PropriedadeModificada("Perctributos", value);
            _perctributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtmp
    {
        get
        {
            PropriedadeAcessada("Qtmp");
            return _qtmp;
        }
        set
        {
            PropriedadeModificada("Qtmp", value);
            _qtmp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St_Ant_Rateio
    {
        get
        {
            PropriedadeAcessada("St_Ant_Rateio");
            return _st_ant_rateio;
        }
        set
        {
            PropriedadeModificada("St_Ant_Rateio", value);
            _st_ant_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? St_Dif_Rateio
    {
        get
        {
            PropriedadeAcessada("St_Dif_Rateio");
            return _st_dif_rateio;
        }
        set
        {
            PropriedadeModificada("St_Dif_Rateio", value);
            _st_dif_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlacrescrodape
    {
        get
        {
            PropriedadeAcessada("Vlacrescrodape");
            return _vlacrescrodape;
        }
        set
        {
            PropriedadeModificada("Vlacrescrodape", value);
            _vlacrescrodape = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlfrete_Rateio
    {
        get
        {
            PropriedadeAcessada("Vlfrete_Rateio");
            return _vlfrete_rateio;
        }
        set
        {
            PropriedadeModificada("Vlfrete_Rateio", value);
            _vlfrete_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 22, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlitemtributos
    {
        get
        {
            PropriedadeAcessada("Vlitemtributos");
            return _vlitemtributos;
        }
        set
        {
            PropriedadeModificada("Vlitemtributos", value);
            _vlitemtributos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vloutras_Rateio
    {
        get
        {
            PropriedadeAcessada("Vloutras_Rateio");
            return _vloutras_rateio;
        }
        set
        {
            PropriedadeModificada("Vloutras_Rateio", value);
            _vloutras_rateio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numseqitem
    {
        get
        {
            PropriedadeAcessada("Numseqitem");
            return _numseqitem;
        }
        set
        {
            PropriedadeModificada("Numseqitem", value);
            _numseqitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlicmsdesoneracao
    {
        get
        {
            PropriedadeAcessada("Vlicmsdesoneracao");
            return _vlicmsdesoneracao;
        }
        set
        {
            PropriedadeModificada("Vlicmsdesoneracao", value);
            _vlicmsdesoneracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codmotivoicmsdesonerado
    {
        get
        {
            PropriedadeAcessada("Codmotivoicmsdesonerado");
            return _codmotivoicmsdesonerado;
        }
        set
        {
            PropriedadeModificada("Codmotivoicmsdesonerado", value);
            _codmotivoicmsdesonerado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 21, Precisao = 10)]
    public decimal? Qbcmonoret
    {
        get
        {
            PropriedadeAcessada(RO_QBCMONORET);
            return _qbcmonoret;
        }
        set
        {
            PropriedadeModificada(RO_QBCMONORET, value);
            _qbcmonoret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 4)]
    public decimal? Adremicmsret
    {
        get
        {
            PropriedadeAcessada(RO_ADREMICMSRET);
            return _adremicmsret;
        }
        set
        {
            PropriedadeModificada(RO_ADREMICMSRET, value);
            _adremicmsret = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPEDICESTA", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 23, Precisao = 10)]
    public decimal? Vicmsmonoret
    {
        get
        {
            PropriedadeAcessada(RO_VICMSMONORET);
            return _vicmsmonoret;
        }
        set
        {
            PropriedadeModificada(RO_VICMSMONORET, value);
            _vicmsmonoret = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPEDICESTA";
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
        _basedifaliquotas = AlterarTipo<decimal?>(leitor["Basedifaliquotas"]);
        _baseicst = AlterarTipo<decimal?>(leitor["Baseicst"]);
        _baseicst_ant_rateio = AlterarTipo<decimal?>(leitor["Baseicst_Ant_Rateio"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codicmtab = AlterarTipo<decimal?>(leitor["Codicmtab"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codprodmp = AlterarTipo<decimal>(leitor["Codprodmp"]);
        _codprodtinta = AlterarTipo<string>(leitor["Codprodtinta"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _custofinest = AlterarTipo<decimal?>(leitor["Custofinest"]);
        _iva = AlterarTipo<decimal?>(leitor["Iva"]);
        _numped = AlterarTipo<decimal>(leitor["Numped"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _pauta = AlterarTipo<decimal?>(leitor["Pauta"]);
        _pbaserca = AlterarTipo<decimal?>(leitor["Pbaserca"]);
        _percbasered = AlterarTipo<decimal?>(leitor["Percbasered"]);
        _percbaseredpart = AlterarTipo<decimal?>(leitor["Percbaseredpart"]);
        _percbaseredst = AlterarTipo<decimal?>(leitor["Percbaseredst"]);
        _percbaseredstfonte = AlterarTipo<decimal?>(leitor["Percbaseredstfonte"]);
        _percdifaliquotas = AlterarTipo<decimal?>(leitor["Percdifaliquotas"]);
        _percipi = AlterarTipo<decimal?>(leitor["Percipi"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percom = AlterarTipo<decimal>(leitor["Percom"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _percprovpart = AlterarTipo<decimal?>(leitor["Percprovpart"]);
        _percredaliqipi = AlterarTipo<decimal?>(leitor["Percredaliqipi"]);
        _perctributos = AlterarTipo<decimal?>(leitor["Perctributos"]);
        _perdesccusto = AlterarTipo<decimal?>(leitor["Perdesccusto"]);
        _perdescpolitica = AlterarTipo<decimal?>(leitor["Perdescpolitica"]);
        _perdesctab = AlterarTipo<decimal?>(leitor["Perdesctab"]);
        _perfretecmv = AlterarTipo<decimal?>(leitor["Perfretecmv"]);
        _ptabela = AlterarTipo<decimal>(leitor["Ptabela"]);
        _pvenda = AlterarTipo<decimal>(leitor["Pvenda"]);
        _pvendaanterior = AlterarTipo<decimal?>(leitor["Pvendaanterior"]);
        _qtmp = AlterarTipo<decimal?>(leitor["Qtmp"]);
        _qtunitemb = AlterarTipo<decimal?>(leitor["Qtunitemb"]);
        _st = AlterarTipo<decimal>(leitor["St"]);
        _stclientegnre = AlterarTipo<decimal?>(leitor["Stclientegnre"]);
        _st_ant_rateio = AlterarTipo<decimal?>(leitor["St_Ant_Rateio"]);
        _st_dif_rateio = AlterarTipo<decimal?>(leitor["St_Dif_Rateio"]);
        _txvenda = AlterarTipo<decimal?>(leitor["Txvenda"]);
        _vlacrescrodape = AlterarTipo<decimal?>(leitor["Vlacrescrodape"]);
        _vlbasepartdest = AlterarTipo<decimal?>(leitor["Vlbasepartdest"]);
        _vlcustocont = AlterarTipo<decimal?>(leitor["Vlcustocont"]);
        _vlcustofin = AlterarTipo<decimal>(leitor["Vlcustofin"]);
        _vlcustoreal = AlterarTipo<decimal>(leitor["Vlcustoreal"]);
        _vlcustorep = AlterarTipo<decimal?>(leitor["Vlcustorep"]);
        _vldesccustocmv = AlterarTipo<decimal?>(leitor["Vldesccustocmv"]);
        _vldescrodape = AlterarTipo<decimal?>(leitor["Vldescrodape"]);
        _vldescsuframa = AlterarTipo<decimal?>(leitor["Vldescsuframa"]);
        _vldifaliquotas = AlterarTipo<decimal?>(leitor["Vldifaliquotas"]);
        _vlfcppart = AlterarTipo<decimal?>(leitor["Vlfcppart"]);
        _vlfrete_rateio = AlterarTipo<decimal?>(leitor["Vlfrete_Rateio"]);
        _vlicmsdifaliqpart = AlterarTipo<decimal?>(leitor["Vlicmsdifaliqpart"]);
        _vlicmspart = AlterarTipo<decimal?>(leitor["Vlicmspart"]);
        _vlicmspartdest = AlterarTipo<decimal?>(leitor["Vlicmspartdest"]);
        _vlicmspartrem = AlterarTipo<decimal?>(leitor["Vlicmspartrem"]);
        _vlipi = AlterarTipo<decimal?>(leitor["Vlipi"]);
        _vliss = AlterarTipo<decimal?>(leitor["Vliss"]);
        _vlitemtributos = AlterarTipo<decimal?>(leitor["Vlitemtributos"]);
        _vloutras_rateio = AlterarTipo<decimal?>(leitor["Vloutras_Rateio"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _numseqitem = AlterarTipo<decimal?>(leitor["Numseq"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _vlicmsdesoneracao = AlterarTipo<decimal?>(leitor["Vlicmsdesoneracao"]);
        _codmotivoicmsdesonerado = AlterarTipo<string>(leitor["Codmotivoicmsdesonerado"]);
        Qbcmonoret = AlterarTipo<decimal?>(leitor[RO_QBCMONORET]);
        Adremicmsret = AlterarTipo<decimal?>(leitor[RO_ADREMICMSRET]);
        Vicmsmonoret = AlterarTipo<decimal?>(leitor[RO_VICMSMONORET]);
    }

}