

////// namespace nwErp.Entidades.Caixa;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCANALISEPDV : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCCAIXA = "Codfunccaixa";

    private decimal? _codfunccaixa;

    private static readonly string RO_CODFUNCSUPERV = "Codfuncsuperv";

    private decimal? _codfuncsuperv;

    private static readonly string RO_DATA = "Data";

    private DateTime? _data;

    private static readonly string RO_DTHRENTRADA = "Dthrentrada";

    private DateTime? _dthrentrada;

    private static readonly string RO_DTHRSAIDA = "Dthrsaida";

    private DateTime? _dthrsaida;

    private static readonly string RO_GTCANCELFINAL = "Gtcancelfinal";

    private decimal? _gtcancelfinal;

    private static readonly string RO_GTCANCELINICIAL = "Gtcancelinicial";

    private decimal? _gtcancelinicial;

    private static readonly string RO_GTDESCFINAL = "Gtdescfinal";

    private decimal? _gtdescfinal;

    private static readonly string RO_GTDESCINICIAL = "Gtdescinicial";

    private decimal? _gtdescinicial;

    private static readonly string RO_GTVENDAFINAL = "Gtvendafinal";

    private decimal? _gtvendafinal;

    private static readonly string RO_GTVENDAINICIAL = "Gtvendainicial";

    private decimal? _gtvendainicial;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMSEQ = "Numseq";

    private decimal _numseq;

    private static readonly string RO_NUMSEQENTRADA = "Numseqentrada";

    private decimal? _numseqentrada;

    private static readonly string RO_QTDEABERTURAGAVETA = "Qtdeaberturagaveta";

    private decimal? _qtdeaberturagaveta;

    private static readonly string RO_QTDECLIENTES = "Qtdeclientes";

    private decimal? _qtdeclientes;

    private static readonly string RO_QTDECUPONSCANCEL = "Qtdecuponscancel";

    private decimal? _qtdecuponscancel;

    private static readonly string RO_QTDEITEMCANCEL = "Qtdeitemcancel";

    private decimal? _qtdeitemcancel;

    private static readonly string RO_QTDEITEMVENDA = "Qtdeitemvenda";

    private decimal? _qtdeitemvenda;

    private static readonly string RO_QTDEITEMVENDADIFERENCA = "Qtdeitemvendadiferenca";

    private decimal? _qtdeitemvendadiferenca;

    private static readonly string RO_QTDELINHASCUPOM = "Qtdelinhascupom";

    private decimal? _qtdelinhascupom;

    private static readonly string RO_QTDESANGRIA = "Qtdesangria";

    private decimal? _qtdesangria;

    private static readonly string RO_QTDESANGRIARECEBTOBANC = "Qtdesangriarecebtobanc";

    private decimal? _qtdesangriarecebtobanc;

    private static readonly string RO_QTDESUPRIMENTO = "Qtdesuprimento";

    private decimal? _qtdesuprimento;

    private static readonly string RO_QTDETEMPOCAIXAABERTO = "Qtdetempocaixaaberto";

    private decimal? _qtdetempocaixaaberto;

    private static readonly string RO_QTDETEMPOINATIVO = "Qtdetempoinativo";

    private decimal? _qtdetempoinativo;

    private static readonly string RO_QTDETEMPOPAUSA = "Qtdetempopausa";

    private decimal? _qtdetempopausa;

    private static readonly string RO_QTDETEMPOTOTALVENDA = "Qtdetempototalvenda";

    private decimal? _qtdetempototalvenda;

    private static readonly string RO_QTDETEMPOVENDAITEM = "Qtdetempovendaitem";

    private decimal? _qtdetempovendaitem;

    private static readonly string RO_QTDEVOLUMESPRODUTOS = "Qtdevolumesprodutos";

    private decimal? _qtdevolumesprodutos;

    private static readonly string RO_VALORCANCEL = "Valorcancel";

    private decimal? _valorcancel;

    private static readonly string RO_VALORDESC = "Valordesc";

    private decimal? _valordesc;

    private static readonly string RO_VALORENCARGO = "Valorencargo";

    private decimal? _valorencargo;

    private static readonly string RO_VALORENTRADANUMERARIO = "Valorentradanumerario";

    private decimal? _valorentradanumerario;

    private static readonly string RO_VALORFINALIZDIFERENCA = "Valorfinalizdiferenca";

    private decimal? _valorfinalizdiferenca;

    private static readonly string RO_VALORFUNDOTROCO = "Valorfundotroco";

    private decimal? _valorfundotroco;

    private static readonly string RO_VALORSANGRIA = "Valorsangria";

    private decimal? _valorsangria;

    private static readonly string RO_VALORSANGRIAAUTO = "Valorsangriaauto";

    private decimal? _valorsangriaauto;

    private static readonly string RO_VALORSANGRIADIFERENCA = "Valorsangriadiferenca";

    private decimal? _valorsangriadiferenca;

    private static readonly string RO_VALORSANGRIARECEBTOBANC = "Valorsangriarecebtobanc";

    private decimal? _valorsangriarecebtobanc;

    private static readonly string RO_VALORSUPRIMENTO = "Valorsuprimento";

    private decimal? _valorsuprimento;

    private static readonly string RO_VALORVENDA = "Valorvenda";

    private decimal? _valorvenda;

    private static readonly string RO_VALORVENDADIFERENCA = "Valorvendadiferenca";

    private decimal? _valorvendadiferenca;

    private static readonly string RO_HRINICIAL = "Hrinicial";

    private string _hrinicial;

    private static readonly string RO_HRFINAL = "Hrinicial";

    private string _hrfinal;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccaixa
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncsuperv
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCSUPERV);
            return _codfuncsuperv;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCSUPERV, value);
            _codfuncsuperv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Data
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthrentrada
    {
        get
        {
            PropriedadeAcessada(RO_DTHRENTRADA);
            return _dthrentrada;
        }
        set
        {
            PropriedadeModificada(RO_DTHRENTRADA, value);
            _dthrentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthrsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTHRSAIDA);
            return _dthrsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTHRSAIDA, value);
            _dthrsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtcancelfinal
    {
        get
        {
            PropriedadeAcessada(RO_GTCANCELFINAL);
            return _gtcancelfinal;
        }
        set
        {
            PropriedadeModificada(RO_GTCANCELFINAL, value);
            _gtcancelfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtcancelinicial
    {
        get
        {
            PropriedadeAcessada(RO_GTCANCELINICIAL);
            return _gtcancelinicial;
        }
        set
        {
            PropriedadeModificada(RO_GTCANCELINICIAL, value);
            _gtcancelinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtdescfinal
    {
        get
        {
            PropriedadeAcessada(RO_GTDESCFINAL);
            return _gtdescfinal;
        }
        set
        {
            PropriedadeModificada(RO_GTDESCFINAL, value);
            _gtdescfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtdescinicial
    {
        get
        {
            PropriedadeAcessada(RO_GTDESCINICIAL);
            return _gtdescinicial;
        }
        set
        {
            PropriedadeModificada(RO_GTDESCINICIAL, value);
            _gtdescinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtvendafinal
    {
        get
        {
            PropriedadeAcessada(RO_GTVENDAFINAL);
            return _gtvendafinal;
        }
        set
        {
            PropriedadeModificada(RO_GTVENDAFINAL, value);
            _gtvendafinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtvendainicial
    {
        get
        {
            PropriedadeAcessada(RO_GTVENDAINICIAL);
            return _gtvendainicial;
        }
        set
        {
            PropriedadeModificada(RO_GTVENDAINICIAL, value);
            _gtvendainicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numseq
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numseqentrada
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQENTRADA);
            return _numseqentrada;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQENTRADA, value);
            _numseqentrada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Qtdeaberturagaveta
    {
        get
        {
            PropriedadeAcessada(RO_QTDEABERTURAGAVETA);
            return _qtdeaberturagaveta;
        }
        set
        {
            PropriedadeModificada(RO_QTDEABERTURAGAVETA, value);
            _qtdeaberturagaveta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdeclientes
    {
        get
        {
            PropriedadeAcessada(RO_QTDECLIENTES);
            return _qtdeclientes;
        }
        set
        {
            PropriedadeModificada(RO_QTDECLIENTES, value);
            _qtdeclientes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdecuponscancel
    {
        get
        {
            PropriedadeAcessada(RO_QTDECUPONSCANCEL);
            return _qtdecuponscancel;
        }
        set
        {
            PropriedadeModificada(RO_QTDECUPONSCANCEL, value);
            _qtdecuponscancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 3)]
    public decimal? Qtdeitemcancel
    {
        get
        {
            PropriedadeAcessada(RO_QTDEITEMCANCEL);
            return _qtdeitemcancel;
        }
        set
        {
            PropriedadeModificada(RO_QTDEITEMCANCEL, value);
            _qtdeitemcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 3)]
    public decimal? Qtdeitemvenda
    {
        get
        {
            PropriedadeAcessada(RO_QTDEITEMVENDA);
            return _qtdeitemvenda;
        }
        set
        {
            PropriedadeModificada(RO_QTDEITEMVENDA, value);
            _qtdeitemvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 3)]
    public decimal? Qtdeitemvendadiferenca
    {
        get
        {
            PropriedadeAcessada(RO_QTDEITEMVENDADIFERENCA);
            return _qtdeitemvendadiferenca;
        }
        set
        {
            PropriedadeModificada(RO_QTDEITEMVENDADIFERENCA, value);
            _qtdeitemvendadiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdelinhascupom
    {
        get
        {
            PropriedadeAcessada(RO_QTDELINHASCUPOM);
            return _qtdelinhascupom;
        }
        set
        {
            PropriedadeModificada(RO_QTDELINHASCUPOM, value);
            _qtdelinhascupom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Qtdesangria
    {
        get
        {
            PropriedadeAcessada(RO_QTDESANGRIA);
            return _qtdesangria;
        }
        set
        {
            PropriedadeModificada(RO_QTDESANGRIA, value);
            _qtdesangria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdesangriarecebtobanc
    {
        get
        {
            PropriedadeAcessada(RO_QTDESANGRIARECEBTOBANC);
            return _qtdesangriarecebtobanc;
        }
        set
        {
            PropriedadeModificada(RO_QTDESANGRIARECEBTOBANC, value);
            _qtdesangriarecebtobanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
    public decimal? Qtdesuprimento
    {
        get
        {
            PropriedadeAcessada(RO_QTDESUPRIMENTO);
            return _qtdesuprimento;
        }
        set
        {
            PropriedadeModificada(RO_QTDESUPRIMENTO, value);
            _qtdesuprimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdetempocaixaaberto
    {
        get
        {
            PropriedadeAcessada(RO_QTDETEMPOCAIXAABERTO);
            return _qtdetempocaixaaberto;
        }
        set
        {
            PropriedadeModificada(RO_QTDETEMPOCAIXAABERTO, value);
            _qtdetempocaixaaberto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdetempoinativo
    {
        get
        {
            PropriedadeAcessada(RO_QTDETEMPOINATIVO);
            return _qtdetempoinativo;
        }
        set
        {
            PropriedadeModificada(RO_QTDETEMPOINATIVO, value);
            _qtdetempoinativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdetempopausa
    {
        get
        {
            PropriedadeAcessada(RO_QTDETEMPOPAUSA);
            return _qtdetempopausa;
        }
        set
        {
            PropriedadeModificada(RO_QTDETEMPOPAUSA, value);
            _qtdetempopausa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdetempototalvenda
    {
        get
        {
            PropriedadeAcessada(RO_QTDETEMPOTOTALVENDA);
            return _qtdetempototalvenda;
        }
        set
        {
            PropriedadeModificada(RO_QTDETEMPOTOTALVENDA, value);
            _qtdetempototalvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdetempovendaitem
    {
        get
        {
            PropriedadeAcessada(RO_QTDETEMPOVENDAITEM);
            return _qtdetempovendaitem;
        }
        set
        {
            PropriedadeModificada(RO_QTDETEMPOVENDAITEM, value);
            _qtdetempovendaitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Qtdevolumesprodutos
    {
        get
        {
            PropriedadeAcessada(RO_QTDEVOLUMESPRODUTOS);
            return _qtdevolumesprodutos;
        }
        set
        {
            PropriedadeModificada(RO_QTDEVOLUMESPRODUTOS, value);
            _qtdevolumesprodutos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorcancel
    {
        get
        {
            PropriedadeAcessada(RO_VALORCANCEL);
            return _valorcancel;
        }
        set
        {
            PropriedadeModificada(RO_VALORCANCEL, value);
            _valorcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valordesc
    {
        get
        {
            PropriedadeAcessada(RO_VALORDESC);
            return _valordesc;
        }
        set
        {
            PropriedadeModificada(RO_VALORDESC, value);
            _valordesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorencargo
    {
        get
        {
            PropriedadeAcessada(RO_VALORENCARGO);
            return _valorencargo;
        }
        set
        {
            PropriedadeModificada(RO_VALORENCARGO, value);
            _valorencargo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorentradanumerario
    {
        get
        {
            PropriedadeAcessada(RO_VALORENTRADANUMERARIO);
            return _valorentradanumerario;
        }
        set
        {
            PropriedadeModificada(RO_VALORENTRADANUMERARIO, value);
            _valorentradanumerario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorfinalizdiferenca
    {
        get
        {
            PropriedadeAcessada(RO_VALORFINALIZDIFERENCA);
            return _valorfinalizdiferenca;
        }
        set
        {
            PropriedadeModificada(RO_VALORFINALIZDIFERENCA, value);
            _valorfinalizdiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorfundotroco
    {
        get
        {
            PropriedadeAcessada(RO_VALORFUNDOTROCO);
            return _valorfundotroco;
        }
        set
        {
            PropriedadeModificada(RO_VALORFUNDOTROCO, value);
            _valorfundotroco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorsangria
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIA);
            return _valorsangria;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIA, value);
            _valorsangria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorsangriaauto
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIAAUTO);
            return _valorsangriaauto;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIAAUTO, value);
            _valorsangriaauto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorsangriadiferenca
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIADIFERENCA);
            return _valorsangriadiferenca;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIADIFERENCA, value);
            _valorsangriadiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorsangriarecebtobanc
    {
        get
        {
            PropriedadeAcessada(RO_VALORSANGRIARECEBTOBANC);
            return _valorsangriarecebtobanc;
        }
        set
        {
            PropriedadeModificada(RO_VALORSANGRIARECEBTOBANC, value);
            _valorsangriarecebtobanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorsuprimento
    {
        get
        {
            PropriedadeAcessada(RO_VALORSUPRIMENTO);
            return _valorsuprimento;
        }
        set
        {
            PropriedadeModificada(RO_VALORSUPRIMENTO, value);
            _valorsuprimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorvenda
    {
        get
        {
            PropriedadeAcessada(RO_VALORVENDA);
            return _valorvenda;
        }
        set
        {
            PropriedadeModificada(RO_VALORVENDA, value);
            _valorvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 2)]
    public decimal? Valorvendadiferenca
    {
        get
        {
            PropriedadeAcessada(RO_VALORVENDADIFERENCA);
            return _valorvendadiferenca;
        }
        set
        {
            PropriedadeModificada(RO_VALORVENDADIFERENCA, value);
            _valorvendadiferenca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Hrinicial
    {
        get
        {
            PropriedadeAcessada(RO_HRINICIAL);
            return _hrinicial;
        }
        set
        {
            PropriedadeModificada(RO_HRINICIAL, value);
            _hrinicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Hrfinal
    {
        get
        {
            PropriedadeAcessada(RO_HRFINAL);
            return _hrfinal;
        }
        set
        {
            PropriedadeModificada(RO_HRFINAL, value);
            _hrfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCANALISEPDV", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCANALISEPDV";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfunccaixa = AlterarTipo<decimal?>(leitor["Codfunccaixa"]);
        _codfuncsuperv = AlterarTipo<decimal?>(leitor["Codfuncsuperv"]);
        _data = AlterarTipo<DateTime?>(leitor["Data"]);
        _dthrentrada = AlterarTipo<DateTime?>(leitor["Dthrentrada"]);
        _dthrsaida = AlterarTipo<DateTime?>(leitor["Dthrsaida"]);
        _gtcancelfinal = AlterarTipo<decimal?>(leitor["Gtcancelfinal"]);
        _gtcancelinicial = AlterarTipo<decimal?>(leitor["Gtcancelinicial"]);
        _gtdescfinal = AlterarTipo<decimal?>(leitor["Gtdescfinal"]);
        _gtdescinicial = AlterarTipo<decimal?>(leitor["Gtdescinicial"]);
        _gtvendafinal = AlterarTipo<decimal?>(leitor["Gtvendafinal"]);
        _gtvendainicial = AlterarTipo<decimal?>(leitor["Gtvendainicial"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numseq = AlterarTipo<decimal>(leitor["Numseq"]);
        _numseqentrada = AlterarTipo<decimal?>(leitor["Numseqentrada"]);
        _qtdeaberturagaveta = AlterarTipo<decimal?>(leitor["Qtdeaberturagaveta"]);
        _qtdeclientes = AlterarTipo<decimal?>(leitor["Qtdeclientes"]);
        _qtdecuponscancel = AlterarTipo<decimal?>(leitor["Qtdecuponscancel"]);
        _qtdeitemcancel = AlterarTipo<decimal?>(leitor["Qtdeitemcancel"]);
        _qtdeitemvenda = AlterarTipo<decimal?>(leitor["Qtdeitemvenda"]);
        _qtdeitemvendadiferenca = AlterarTipo<decimal?>(leitor["Qtdeitemvendadiferenca"]);
        _qtdelinhascupom = AlterarTipo<decimal?>(leitor["Qtdelinhascupom"]);
        _qtdesangria = AlterarTipo<decimal?>(leitor["Qtdesangria"]);
        _qtdesangriarecebtobanc = AlterarTipo<decimal?>(leitor["Qtdesangriarecebtobanc"]);
        _qtdesuprimento = AlterarTipo<decimal?>(leitor["Qtdesuprimento"]);
        _qtdetempocaixaaberto = AlterarTipo<decimal?>(leitor["Qtdetempocaixaaberto"]);
        _qtdetempoinativo = AlterarTipo<decimal?>(leitor["Qtdetempoinativo"]);
        _qtdetempopausa = AlterarTipo<decimal?>(leitor["Qtdetempopausa"]);
        _qtdetempototalvenda = AlterarTipo<decimal?>(leitor["Qtdetempototalvenda"]);
        _qtdetempovendaitem = AlterarTipo<decimal?>(leitor["Qtdetempovendaitem"]);
        _qtdevolumesprodutos = AlterarTipo<decimal?>(leitor["Qtdevolumesprodutos"]);
        _valorcancel = AlterarTipo<decimal?>(leitor["Valorcancel"]);
        _valordesc = AlterarTipo<decimal?>(leitor["Valordesc"]);
        _valorencargo = AlterarTipo<decimal?>(leitor["Valorencargo"]);
        _valorentradanumerario = AlterarTipo<decimal?>(leitor["Valorentradanumerario"]);
        _valorfinalizdiferenca = AlterarTipo<decimal?>(leitor["Valorfinalizdiferenca"]);
        _valorfundotroco = AlterarTipo<decimal?>(leitor["Valorfundotroco"]);
        _valorsangria = AlterarTipo<decimal?>(leitor["Valorsangria"]);
        _valorsangriaauto = AlterarTipo<decimal?>(leitor["Valorsangriaauto"]);
        _valorsangriadiferenca = AlterarTipo<decimal?>(leitor["Valorsangriadiferenca"]);
        _valorsangriarecebtobanc = AlterarTipo<decimal?>(leitor["Valorsangriarecebtobanc"]);
        _valorsuprimento = AlterarTipo<decimal?>(leitor["Valorsuprimento"]);
        _valorvenda = AlterarTipo<decimal?>(leitor["Valorvenda"]);
        _valorvendadiferenca = AlterarTipo<decimal?>(leitor["Valorvendadiferenca"]);
        _hrinicial = AlterarTipo<string>(leitor["Hrinicial"]);
        _hrfinal = AlterarTipo<string>(leitor["Hrfinal"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
    }

	
}