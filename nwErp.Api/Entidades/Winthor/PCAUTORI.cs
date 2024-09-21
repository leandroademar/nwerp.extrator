

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCAUTORI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AFETAPERDESC = "Afetaperdesc";

    private string _afetaperdesc;

    private static readonly string RO_APENASPLPAGMAX = "Apenasplpagmax";

    private string _apenasplpagmax;

    private static readonly string RO_BASECREDDEBRCA = "Basecreddebrca";

    private string _basecreddebrca;

    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal? _codauxiliar;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCADASTRO = "Codfunccadastro";

    private decimal? _codfunccadastro;

    private static readonly string RO_CODFUNCCX = "Codfunccx";

    private decimal? _codfunccx;

    private static readonly string RO_CODFUNCUTILIZ = "Codfuncutiliz";

    private decimal? _codfuncutiliz;

    private static readonly string RO_CODPLPAG = "Codplpag";

    private decimal _codplpag;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_DATAAUTORIZACAO = "Dataautorizacao";

    private DateTime _dataautorizacao;

    private static readonly string RO_DATA_UTILIZACAO = "Data_utilizacao";

    private DateTime? _data_utilizacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXCEDECOTA = "Excedecota";

    private string _excedecota;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_FIMINTERVALO = "Fimintervalo";

    private decimal? _fimintervalo;

    private static readonly string RO_GERADEBRCA = "Geradebrca";

    private string _geradebrca;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_INICIOINTERVALO = "Iniciointervalo";

    private decimal? _iniciointervalo;

    private static readonly string RO_NRAUTORIZACAO = "Nrautorizacao";

    private decimal _nrautorizacao;

    private static readonly string RO_NRAUTORIZACAOECF = "Nrautorizacaoecf";

    private decimal? _nrautorizacaoecf;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMCUPOM = "Numcupom";

    private decimal? _numcupom;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal? _numregiao;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_PERCDESCAUTOR = "Percdescautor";

    private decimal _percdescautor;

    private static readonly string RO_PERCOM = "Percom";

    private decimal? _percom;

    private static readonly string RO_PVENDAATUAL = "Pvendaatual";

    private decimal? _pvendaatual;

    private static readonly string RO_PVENDIDO = "Pvendido";

    private decimal? _pvendido;

    private static readonly string RO_QTVENDAECF = "Qtvendaecf";

    private decimal? _qtvendaecf;

    private static readonly string RO_SERIEEQUIP = "Serieequip";

    private string _serieequip;

    private static readonly string RO_STATUSUTILIZ = "Statusutiliz";

    private string _statusutiliz;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Afetaperdesc
    {
        get
        {
            PropriedadeAcessada(RO_AFETAPERDESC);
            return _afetaperdesc;
        }
        set
        {
            PropriedadeModificada(RO_AFETAPERDESC, value);
            _afetaperdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Apenasplpagmax
    {
        get
        {
            PropriedadeAcessada(RO_APENASPLPAGMAX);
            return _apenasplpagmax;
        }
        set
        {
            PropriedadeModificada(RO_APENASPLPAGMAX, value);
            _apenasplpagmax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Basecreddebrca
    {
        get
        {
            PropriedadeAcessada(RO_BASECREDDEBRCA);
            return _basecreddebrca;
        }
        set
        {
            PropriedadeModificada(RO_BASECREDDEBRCA, value);
            _basecreddebrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 0)]
    public decimal? Codauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR);
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR, value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccadastro
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCADASTRO);
            return _codfunccadastro;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCADASTRO, value);
            _codfunccadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncutiliz
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCUTILIZ);
            return _codfuncutiliz;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCUTILIZ, value);
            _codfuncutiliz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR);
            return _codusur;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR, value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dataautorizacao
    {
        get
        {
            PropriedadeAcessada(RO_DATAAUTORIZACAO);
            return _dataautorizacao;
        }
        set
        {
            PropriedadeModificada(RO_DATAAUTORIZACAO, value);
            _dataautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data_utilizacao
    {
        get
        {
            PropriedadeAcessada(RO_DATA_UTILIZACAO);
            return _data_utilizacao;
        }
        set
        {
            PropriedadeModificada(RO_DATA_UTILIZACAO, value);
            _data_utilizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Excedecota
    {
        get
        {
            PropriedadeAcessada(RO_EXCEDECOTA);
            return _excedecota;
        }
        set
        {
            PropriedadeModificada(RO_EXCEDECOTA, value);
            _excedecota = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Fimintervalo
    {
        get
        {
            PropriedadeAcessada(RO_FIMINTERVALO);
            return _fimintervalo;
        }
        set
        {
            PropriedadeModificada(RO_FIMINTERVALO, value);
            _fimintervalo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geradebrca
    {
        get
        {
            PropriedadeAcessada(RO_GERADEBRCA);
            return _geradebrca;
        }
        set
        {
            PropriedadeModificada(RO_GERADEBRCA, value);
            _geradebrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Iniciointervalo
    {
        get
        {
            PropriedadeAcessada(RO_INICIOINTERVALO);
            return _iniciointervalo;
        }
        set
        {
            PropriedadeModificada(RO_INICIOINTERVALO, value);
            _iniciointervalo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Nrautorizacao
    {
        get
        {
            PropriedadeAcessada(RO_NRAUTORIZACAO);
            return _nrautorizacao;
        }
        set
        {
            PropriedadeModificada(RO_NRAUTORIZACAO, value);
            _nrautorizacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nrautorizacaoecf
    {
        get
        {
            PropriedadeAcessada(RO_NRAUTORIZACAOECF);
            return _nrautorizacaoecf;
        }
        set
        {
            PropriedadeModificada(RO_NRAUTORIZACAOECF, value);
            _nrautorizacaoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcupom
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOM);
            return _numcupom;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOM, value);
            _numcupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada(RO_NUMPED);
            return _numped;
        }
        set
        {
            PropriedadeModificada(RO_NUMPED, value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDECF);
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDECF, value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal Percdescautor
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCAUTOR);
            return _percdescautor;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCAUTOR, value);
            _percdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percom
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM);
            return _percom;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM, value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatual
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATUAL);
            return _pvendaatual;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATUAL, value);
            _pvendaatual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendido
    {
        get
        {
            PropriedadeAcessada(RO_PVENDIDO);
            return _pvendido;
        }
        set
        {
            PropriedadeModificada(RO_PVENDIDO, value);
            _pvendido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtvendaecf
    {
        get
        {
            PropriedadeAcessada(RO_QTVENDAECF);
            return _qtvendaecf;
        }
        set
        {
            PropriedadeModificada(RO_QTVENDAECF, value);
            _qtvendaecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Serieequip
    {
        get
        {
            PropriedadeAcessada(RO_SERIEEQUIP);
            return _serieequip;
        }
        set
        {
            PropriedadeModificada(RO_SERIEEQUIP, value);
            _serieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCAUTORI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Statusutiliz
    {
        get
        {
            PropriedadeAcessada(RO_STATUSUTILIZ);
            return _statusutiliz;
        }
        set
        {
            PropriedadeModificada(RO_STATUSUTILIZ, value);
            _statusutiliz = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCAUTORI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _afetaperdesc = AlterarTipo<string>(leitor["Afetaperdesc"]);
        _apenasplpagmax = AlterarTipo<string>(leitor["Apenasplpagmax"]);
        _basecreddebrca = AlterarTipo<string>(leitor["Basecreddebrca"]);
        _codauxiliar = AlterarTipo<decimal?>(leitor["Codauxiliar"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccadastro = AlterarTipo<decimal?>(leitor["Codfunccadastro"]);
        _codfunccx = AlterarTipo<decimal?>(leitor["Codfunccx"]);
        _codfuncutiliz = AlterarTipo<decimal?>(leitor["Codfuncutiliz"]);
        _codplpag = AlterarTipo<decimal>(leitor["Codplpag"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _dataautorizacao = AlterarTipo<DateTime>(leitor["Dataautorizacao"]);
        _data_utilizacao = AlterarTipo<DateTime?>(leitor["Data_utilizacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _excedecota = AlterarTipo<string>(leitor["Excedecota"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _fimintervalo = AlterarTipo<decimal?>(leitor["Fimintervalo"]);
        _geradebrca = AlterarTipo<string>(leitor["Geradebrca"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _iniciointervalo = AlterarTipo<decimal?>(leitor["Iniciointervalo"]);
        _nrautorizacao = AlterarTipo<decimal>(leitor["Nrautorizacao"]);
        _nrautorizacaoecf = AlterarTipo<decimal?>(leitor["Nrautorizacaoecf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numcupom = AlterarTipo<decimal?>(leitor["Numcupom"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numregiao = AlterarTipo<decimal?>(leitor["Numregiao"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _percdescautor = AlterarTipo<decimal>(leitor["Percdescautor"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _pvendaatual = AlterarTipo<decimal?>(leitor["Pvendaatual"]);
        _pvendido = AlterarTipo<decimal?>(leitor["Pvendido"]);
        _qtvendaecf = AlterarTipo<decimal?>(leitor["Qtvendaecf"]);
        _serieequip = AlterarTipo<string>(leitor["Serieequip"]);
        _statusutiliz = AlterarTipo<string>(leitor["Statusutiliz"]);
    }

}