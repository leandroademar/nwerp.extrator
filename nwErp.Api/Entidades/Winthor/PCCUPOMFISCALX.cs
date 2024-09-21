

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCUPOMFISCALX : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODIGO = "Codigo";

    private decimal _codigo;

    private static readonly string RO_DATA = "Data";

    private DateTime _data;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal _numecf;

    private static readonly string RO_NUMREDUCAOZ = "Numreducaoz";

    private decimal? _numreducaoz;

    private static readonly string RO_NUMSERIE = "Numserie";

    private string _numserie;

    private static readonly string RO_POSICAO = "Posicao";

    private string _posicao;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SITTRIBUT = "Sittribut";

    private string _sittribut;

    private static readonly string RO_VALOR = "Valor";

    private decimal? _valor;

    private static readonly string RO_VALORMOVECF = "Valormovecf";

    private decimal? _valormovecf;

    private string _md5paf;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMEROORDEMOPERACAO = "Numeroordemoperacao";

    private decimal? _numeroordemoperacao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal Codigo
    {
        get
        {
            PropriedadeAcessada(RO_CODIGO);
            return _codigo;
        }
        set
        {
            PropriedadeModificada(RO_CODIGO, value);
            _codigo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAO);
            return _dtexportacao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAO, value);
            _dtexportacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportado
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADO);
            return _exportado;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADO, value);
            _exportado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMECF);
            return _numecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMECF, value);
            _numecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numreducaoz
    {
        get
        {
            PropriedadeAcessada(RO_NUMREDUCAOZ);
            return _numreducaoz;
        }
        set
        {
            PropriedadeModificada(RO_NUMREDUCAOZ, value);
            _numreducaoz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numserie
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIE);
            return _numserie;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIE, value);
            _numserie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Sittribut
    {
        get
        {
            PropriedadeAcessada(RO_SITTRIBUT);
            return _sittribut;
        }
        set
        {
            PropriedadeModificada(RO_SITTRIBUT, value);
            _sittribut = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valor
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valormovecf
    {
        get
        {
            PropriedadeAcessada(RO_VALORMOVECF);
            return _valormovecf;
        }
        set
        {
            PropriedadeModificada(RO_VALORMOVECF, value);
            _valormovecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALX", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numeroordemoperacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMEROORDEMOPERACAO);
            return _numeroordemoperacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMEROORDEMOPERACAO, value);
            _numeroordemoperacao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCUPOMFISCALX";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codigo = AlterarTipo<decimal>(leitor["Codigo"]);
        _data = AlterarTipo<DateTime>(leitor["Data"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numecf = AlterarTipo<decimal>(leitor["Numecf"]);
        _numreducaoz = AlterarTipo<decimal?>(leitor["Numreducaoz"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _posicao = AlterarTipo<string>(leitor["Posicao"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _sittribut = AlterarTipo<string>(leitor["Sittribut"]);
        _valor = AlterarTipo<decimal?>(leitor["Valor"]);
        _valormovecf = AlterarTipo<decimal?>(leitor["Valormovecf"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numeroordemoperacao = AlterarTipo<decimal?>(leitor["Numeroordemoperacao"]);
    }

}