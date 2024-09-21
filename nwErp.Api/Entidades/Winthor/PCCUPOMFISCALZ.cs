

////// // namespace nwErp.Entidades.Caixa;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCUPOMFISCALZ : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ARQUIVONFP = "Arquivonfp";

    private string _arquivonfp;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CONFERIDO = "Conferido";

    private string _conferido;

    private static readonly string RO_COORZ = "Coorz";

    private decimal? _coorz;

    private static readonly string RO_DIRETORIOGERACAO = "Diretoriogeracao";

    private string _diretoriogeracao;

    private static readonly string RO_DTEMISSAO = "Dtemissao";

    private DateTime _dtemissao;

    private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

    private DateTime? _dtexportacao;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTHORAEMISSAO = "Dthoraemissao";

    private DateTime? _dthoraemissao;

    private static readonly string RO_DTHORANFP = "Dthoranfp";

    private DateTime? _dthoranfp;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_EXPORTADO = "Exportado";

    private string _exportado;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_GTFINAL = "Gtfinal";

    private decimal? _gtfinal;

    private static readonly string RO_GTINICIO = "Gtinicio";

    private decimal? _gtinicio;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_MODELO = "Modelo";

    private string _modelo;

    private static readonly string RO_MODOENVIONFP = "Modoenvionfp";

    private string _modoenvionfp;

    private static readonly string RO_NOMEARQUIVO = "Nomearquivo";

    private string _nomearquivo;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_NUMCDC = "Numcdc";

    private decimal? _numcdc;

    private static readonly string RO_NUMCOO = "Numcoo";

    private decimal? _numcoo;

    private static readonly string RO_NUMCUPOMFIM = "Numcupomfim";

    private decimal? _numcupomfim;

    private static readonly string RO_NUMCUPOMINICIO = "Numcupominicio";

    private decimal? _numcupominicio;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal _numecf;

    private static readonly string RO_NUMGNF = "Numgnf";

    private decimal? _numgnf;

    private static readonly string RO_NUMGRG = "Numgrg";

    private decimal? _numgrg;

    private static readonly string RO_NUMMAPA = "Nummapa";

    private decimal? _nummapa;

    private static readonly string RO_NUMREDUCAOZ = "Numreducaoz";

    private decimal? _numreducaoz;

    private static readonly string RO_NUMREINICIO = "Numreinicio";

    private decimal? _numreinicio;

    private static readonly string RO_NUMSERIE = "Numserie";

    private string _numserie;

    private static readonly string RO_OBSNFP = "Obsnfp";

    private string _obsnfp;

    private static readonly string RO_PROTOCOLONFP = "Protocolonfp";

    private string _protocolonfp;

    private static readonly string RO_REENVIARNFP = "Reenviarnfp";

    private string _reenviarnfp;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private string _rotinalanc;

    private static readonly string RO_SITUACAONFP = "Situacaonfp";

    private string _situacaonfp;

    private static readonly string RO_VENDABRUTA = "Vendabruta";

    private decimal? _vendabruta;

    private static readonly string RO_VLCONTABIL = "Vlcontabil";

    private decimal? _vlcontabil;

    private static readonly string RO_VLNFP = "Vlnfp";

    private decimal? _vlnfp;

    private string _horaemissao;

    private decimal? _numusuarioecf;

    private string _md5paf;

    private static readonly string RO_NUMCAIXA = "Numcaixa";

    private decimal? _numcaixa;

    private static readonly string RO_NUMEROORDEMOPERACAO = "Numeroordemoperacao";

    private decimal? _numeroordemoperacao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Arquivonfp
    {
        get
        {
            PropriedadeAcessada(RO_ARQUIVONFP);
            return _arquivonfp;
        }
        set
        {
            PropriedadeModificada(RO_ARQUIVONFP, value);
            _arquivonfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conferido
    {
        get
        {
            PropriedadeAcessada(RO_CONFERIDO);
            return _conferido;
        }
        set
        {
            PropriedadeModificada(RO_CONFERIDO, value);
            _conferido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Coorz
    {
        get
        {
            PropriedadeAcessada(RO_COORZ);
            return _coorz;
        }
        set
        {
            PropriedadeModificada(RO_COORZ, value);
            _coorz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Diretoriogeracao
    {
        get
        {
            PropriedadeAcessada(RO_DIRETORIOGERACAO);
            return _diretoriogeracao;
        }
        set
        {
            PropriedadeModificada(RO_DIRETORIOGERACAO, value);
            _diretoriogeracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtemissao
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoraemissao
    {
        get
        {
            PropriedadeAcessada(RO_DTHORAEMISSAO);
            return _dthoraemissao;
        }
        set
        {
            PropriedadeModificada(RO_DTHORAEMISSAO, value);
            _dthoraemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dthoranfp
    {
        get
        {
            PropriedadeAcessada(RO_DTHORANFP);
            return _dthoranfp;
        }
        set
        {
            PropriedadeModificada(RO_DTHORANFP, value);
            _dthoranfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtfinal
    {
        get
        {
            PropriedadeAcessada(RO_GTFINAL);
            return _gtfinal;
        }
        set
        {
            PropriedadeModificada(RO_GTFINAL, value);
            _gtfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Gtinicio
    {
        get
        {
            PropriedadeAcessada(RO_GTINICIO);
            return _gtinicio;
        }
        set
        {
            PropriedadeModificada(RO_GTINICIO, value);
            _gtinicio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Modelo
    {
        get
        {
            PropriedadeAcessada(RO_MODELO);
            return _modelo;
        }
        set
        {
            PropriedadeModificada(RO_MODELO, value);
            _modelo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Modoenvionfp
    {
        get
        {
            PropriedadeAcessada(RO_MODOENVIONFP);
            return _modoenvionfp;
        }
        set
        {
            PropriedadeModificada(RO_MODOENVIONFP, value);
            _modoenvionfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Nomearquivo
    {
        get
        {
            PropriedadeAcessada(RO_NOMEARQUIVO);
            return _nomearquivo;
        }
        set
        {
            PropriedadeModificada(RO_NOMEARQUIVO, value);
            _nomearquivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcdc
    {
        get
        {
            PropriedadeAcessada(RO_NUMCDC);
            return _numcdc;
        }
        set
        {
            PropriedadeModificada(RO_NUMCDC, value);
            _numcdc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcoo
    {
        get
        {
            PropriedadeAcessada(RO_NUMCOO);
            return _numcoo;
        }
        set
        {
            PropriedadeModificada(RO_NUMCOO, value);
            _numcoo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numcupomfim
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOMFIM);
            return _numcupomfim;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOMFIM, value);
            _numcupomfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numcupominicio
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUPOMINICIO);
            return _numcupominicio;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUPOMINICIO, value);
            _numcupominicio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numgnf
    {
        get
        {
            PropriedadeAcessada(RO_NUMGNF);
            return _numgnf;
        }
        set
        {
            PropriedadeModificada(RO_NUMGNF, value);
            _numgnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numgrg
    {
        get
        {
            PropriedadeAcessada(RO_NUMGRG);
            return _numgrg;
        }
        set
        {
            PropriedadeModificada(RO_NUMGRG, value);
            _numgrg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Nummapa
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAPA);
            return _nummapa;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAPA, value);
            _nummapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numreinicio
    {
        get
        {
            PropriedadeAcessada(RO_NUMREINICIO);
            return _numreinicio;
        }
        set
        {
            PropriedadeModificada(RO_NUMREINICIO, value);
            _numreinicio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 800, Precisao = 0)]
    public string Obsnfp
    {
        get
        {
            PropriedadeAcessada(RO_OBSNFP);
            return _obsnfp;
        }
        set
        {
            PropriedadeModificada(RO_OBSNFP, value);
            _obsnfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Protocolonfp
    {
        get
        {
            PropriedadeAcessada(RO_PROTOCOLONFP);
            return _protocolonfp;
        }
        set
        {
            PropriedadeModificada(RO_PROTOCOLONFP, value);
            _protocolonfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Reenviarnfp
    {
        get
        {
            PropriedadeAcessada(RO_REENVIARNFP);
            return _reenviarnfp;
        }
        set
        {
            PropriedadeModificada(RO_REENVIARNFP, value);
            _reenviarnfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Situacaonfp
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAONFP);
            return _situacaonfp;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAONFP, value);
            _situacaonfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 2)]
    public decimal? Vendabruta
    {
        get
        {
            PropriedadeAcessada(RO_VENDABRUTA);
            return _vendabruta;
        }
        set
        {
            PropriedadeModificada(RO_VENDABRUTA, value);
            _vendabruta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlcontabil
    {
        get
        {
            PropriedadeAcessada(RO_VLCONTABIL);
            return _vlcontabil;
        }
        set
        {
            PropriedadeModificada(RO_VLCONTABIL, value);
            _vlcontabil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlnfp
    {
        get
        {
            PropriedadeAcessada(RO_VLNFP);
            return _vlnfp;
        }
        set
        {
            PropriedadeModificada(RO_VLNFP, value);
            _vlnfp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Horaemissao
    {
        get
        {
            PropriedadeAcessada("Horaemissao");
            return _horaemissao;
        }
        set
        {
            PropriedadeModificada("Horaemissao", value);
            _horaemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numusuarioecf
    {
        get
        {
            PropriedadeAcessada("Numusuarioecf");
            return _numusuarioecf;
        }
        set
        {
            PropriedadeModificada("Numusuarioecf", value);
            _numusuarioecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCUPOMFISCALZ", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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
        return "PCCUPOMFISCALZ";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _arquivonfp = AlterarTipo<string>(leitor["Arquivonfp"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _conferido = AlterarTipo<string>(leitor["Conferido"]);
        _coorz = AlterarTipo<decimal?>(leitor["Coorz"]);
        _diretoriogeracao = AlterarTipo<string>(leitor["Diretoriogeracao"]);
        _dtemissao = AlterarTipo<DateTime>(leitor["Dtemissao"]);
        _dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dthoraemissao = AlterarTipo<DateTime?>(leitor["Dthoraemissao"]);
        _dthoranfp = AlterarTipo<DateTime?>(leitor["Dthoranfp"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _exportado = AlterarTipo<string>(leitor["Exportado"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _gtfinal = AlterarTipo<decimal?>(leitor["Gtfinal"]);
        _gtinicio = AlterarTipo<decimal?>(leitor["Gtinicio"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _modelo = AlterarTipo<string>(leitor["Modelo"]);
        _modoenvionfp = AlterarTipo<string>(leitor["Modoenvionfp"]);
        _nomearquivo = AlterarTipo<string>(leitor["Nomearquivo"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _numcdc = AlterarTipo<decimal?>(leitor["Numcdc"]);
        _numcoo = AlterarTipo<decimal?>(leitor["Numcoo"]);
        _numcupomfim = AlterarTipo<decimal?>(leitor["Numcupomfim"]);
        _numcupominicio = AlterarTipo<decimal?>(leitor["Numcupominicio"]);
        _numecf = AlterarTipo<decimal>(leitor["Numecf"]);
        _numgnf = AlterarTipo<decimal?>(leitor["Numgnf"]);
        _numgrg = AlterarTipo<decimal?>(leitor["Numgrg"]);
        _nummapa = AlterarTipo<decimal?>(leitor["Nummapa"]);
        _numreducaoz = AlterarTipo<decimal?>(leitor["Numreducaoz"]);
        _numreinicio = AlterarTipo<decimal?>(leitor["Numreinicio"]);
        _numserie = AlterarTipo<string>(leitor["Numserie"]);
        _obsnfp = AlterarTipo<string>(leitor["Obsnfp"]);
        _protocolonfp = AlterarTipo<string>(leitor["Protocolonfp"]);
        _reenviarnfp = AlterarTipo<string>(leitor["Reenviarnfp"]);
        _rotinalanc = AlterarTipo<string>(leitor["Rotinalanc"]);
        _situacaonfp = AlterarTipo<string>(leitor["Situacaonfp"]);
        _vendabruta = AlterarTipo<decimal?>(leitor["Vendabruta"]);
        _vlcontabil = AlterarTipo<decimal?>(leitor["Vlcontabil"]);
        _vlnfp = AlterarTipo<decimal?>(leitor["Vlnfp"]);
        _horaemissao = AlterarTipo<string>(leitor["Horaemissao"]);
        _numusuarioecf = AlterarTipo<decimal?>(leitor["Numusuarioecf"]);
        _md5paf = AlterarTipo<string>(leitor["Md5paf"]);
        _numcaixa = AlterarTipo<decimal?>(leitor["Numcaixa"]);
        _numeroordemoperacao = AlterarTipo<decimal?>(leitor["Numeroordemoperacao"]);
    }

}