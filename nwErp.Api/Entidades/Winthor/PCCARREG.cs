

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCARREG : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ABASTECIDO = "Abastecido";

    private string _abastecido;

    private static readonly string RO_BALCAOBAIXADO = "Balcaobaixado";

    private string _balcaobaixado;

    private static readonly string RO_CARGASECUNDARIA = "Cargasecundaria";

    private string _cargasecundaria;

    private static readonly string RO_CODAJUDTRANSBORDO = "Codajudtransbordo";

    private decimal? _codajudtransbordo;

    private static readonly string RO_CODCAIXA = "Codcaixa";

    private decimal? _codcaixa;

    private static readonly string RO_CODCONF = "Codconf";

    private decimal? _codconf;

    private static readonly string RO_CODFILIALSAIDA = "Codfilialsaida";

    private string _codfilialsaida;

    private static readonly string RO_CODFUNCAJUD = "Codfuncajud";

    private decimal? _codfuncajud;

    private static readonly string RO_CODFUNCAJUD2 = "Codfuncajud2";

    private decimal? _codfuncajud2;

    private static readonly string RO_CODFUNCAJUD3 = "Codfuncajud3";

    private decimal? _codfuncajud3;

    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";

    private decimal? _codfunccancel;

    private static readonly string RO_CODFUNCCONF = "Codfuncconf";

    private decimal? _codfuncconf;

    private static readonly string RO_CODFUNCFAT = "Codfuncfat";

    private decimal? _codfuncfat;

    private static readonly string RO_CODFUNCMAPA = "Codfuncmapa";

    private decimal? _codfuncmapa;

    private static readonly string RO_CODFUNCMAPACARAGRUPADO = "Codfuncmapacaragrupado";

    private decimal? _codfuncmapacaragrupado;

    private static readonly string RO_CODFUNCMON = "Codfuncmon";

    private decimal? _codfuncmon;

    private static readonly string RO_CODFUNCRETORNOCAR = "Codfuncretornocar";

    private decimal? _codfuncretornocar;

    private static readonly string RO_CODFUNCSAIDACAR = "Codfuncsaidacar";

    private decimal? _codfuncsaidacar;

    private static readonly string RO_CODMOTORISTA = "Codmotorista";

    private decimal? _codmotorista;

    private static readonly string RO_CODMOTORISTACARAGRUPADO = "Codmotoristacaragrupado";

    private decimal? _codmotoristacaragrupado;

    private static readonly string RO_CODMOTTRANSBORDO = "Codmottransbordo";

    private decimal? _codmottransbordo;

    private static readonly string RO_CODROTAPRINC = "Codrotaprinc";

    private decimal? _codrotaprinc;

    private static readonly string RO_CODVEICULCARAGRUPADO = "Codveiculcaragrupado";

    private decimal? _codveiculcaragrupado;

    private static readonly string RO_CODVEICULO = "Codveiculo";

    private decimal? _codveiculo;

    private static readonly string RO_CODVEICULO1 = "Codveiculo1";

    private decimal? _codveiculo1;

    private static readonly string RO_CODVEICULO2 = "Codveiculo2";

    private decimal? _codveiculo2;

    private static readonly string RO_CONHECFRETE = "Conhecfrete";

    private string _conhecfrete;

    private static readonly string RO_CONHECGERADO = "Conhecgerado";

    private string _conhecgerado;

    private static readonly string RO_DATACARAGRUPADO = "Datacaragrupado";

    private DateTime? _datacaragrupado;

    private static readonly string RO_DATACONF = "Dataconf";

    private DateTime? _dataconf;

    private static readonly string RO_DATACONFFIM = "Dataconffim";

    private DateTime? _dataconffim;

    private static readonly string RO_DATAHORAMAPA = "Datahoramapa";

    private DateTime? _datahoramapa;

    private static readonly string RO_DATAHORAMAPACARAGRUPADO = "Datahoramapacaragrupado";

    private DateTime? _datahoramapacaragrupado;

    private static readonly string RO_DATAMAPA = "Datamapa";

    private DateTime? _datamapa;

    private static readonly string RO_DATAMON = "Datamon";

    private DateTime? _datamon;

    private static readonly string RO_DESTINO = "Destino";

    private string _destino;

    private static readonly string RO_DESTINOAGRUP = "Destinoagrup";

    private string _destinoagrup;

    private static readonly string RO_DIVISAOCARGA = "Divisaocarga";

    private string _divisaocarga;

    private static readonly string RO_DTCAIXA = "Dtcaixa";

    private DateTime? _dtcaixa;

    private static readonly string RO_DT_CANCEL = "Dt_Cancel";

    private DateTime? _dt_cancel;

    private static readonly string RO_DTFAT = "Dtfat";

    private DateTime? _dtfat;

    private static readonly string RO_DTFECHA = "Dtfecha";

    private DateTime? _dtfecha;

    private static readonly string RO_DTFECHACOMAJUD = "Dtfechacomajud";

    private DateTime? _dtfechacomajud;

    private static readonly string RO_DTFECHACOMAJUDTRANSB = "Dtfechacomajudtransb";

    private DateTime? _dtfechacomajudtransb;

    private static readonly string RO_DTFECHACOMISSMOT = "Dtfechacomissmot";

    private DateTime? _dtfechacomissmot;

    private static readonly string RO_DTFECHACOMMOTTRANSB = "Dtfechacommottransb";

    private DateTime? _dtfechacommottransb;

    private static readonly string RO_DTFIMCHECKOUT = "Dtfimcheckout";

    private DateTime? _dtfimcheckout;

    private static readonly string RO_DTFINALPEND = "Dtfinalpend";

    private DateTime? _dtfinalpend;

    private static readonly string RO_DTINICIALPEND = "Dtinicialpend";

    private DateTime? _dtinicialpend;

    private static readonly string RO_DTINICIOCHECKOUT = "Dtiniciocheckout";

    private DateTime? _dtiniciocheckout;

    private static readonly string RO_DTRETORNO = "Dtretorno";

    private DateTime? _dtretorno;

    private static readonly string RO_DTSAIDA = "Dtsaida";

    private DateTime _dtsaida;

    private static readonly string RO_DTSAIDAVEICULO = "Dtsaidaveiculo";

    private DateTime? _dtsaidaveiculo;

    private static readonly string RO_FROTA_PESO = "Frota_Peso";

    private decimal? _frota_peso;

    private static readonly string RO_GEOVOLUMETOTAL = "Geovolumetotal";

    private decimal? _geovolumetotal;

    private static readonly string RO_GRUPOEMBCARGA = "Grupoembcarga";

    private string _grupoembcarga;

    private static readonly string RO_HORAFECHA = "Horafecha";

    private decimal? _horafecha;

    private static readonly string RO_HORAMON = "Horamon";

    private decimal? _horamon;

    private static readonly string RO_KMFINAL = "Kmfinal";

    private decimal? _kmfinal;

    private static readonly string RO_KMINICIAL = "Kminicial";

    private decimal? _kminicial;

    private static readonly string RO_LACRE = "Lacre";

    private string _lacre;

    private static readonly string RO_LANCARDESPDESCFINAUTOMATIC = "Lancardespdescfinautomatic";

    private string _lancardespdescfinautomatic;

    private static readonly string RO_LANCTOCPAGARFECHCOMISS414 = "Lanctocpagarfechcomiss414";

    private string _lanctocpagarfechcomiss414;

    private static readonly string RO_MAPAGERADOWMS = "Mapageradowms";

    private string _mapageradowms;

    private static readonly string RO_MAPAGERADOWMSPAL = "Mapageradowmspal";

    private string _mapageradowmspal;

    private static readonly string RO_MINUTOFECHA = "Minutofecha";

    private decimal? _minutofecha;

    private static readonly string RO_MINUTOMON = "Minutomon";

    private decimal? _minutomon;

    private static readonly string RO_NOMEAPROPRIADOCARGA = "Nomeapropriadocarga";

    private string _nomeapropriadocarga;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal _numcar;

    private static readonly string RO_NUMCARAGRUPADO = "Numcaragrupado";

    private decimal? _numcaragrupado;

    private static readonly string RO_NUMCARBROKER = "Numcarbroker";

    private decimal? _numcarbroker;

    private static readonly string RO_NUMCAROL = "Numcarol";

    private decimal? _numcarol;

    private static readonly string RO_NUMCAROPERLOG = "Numcaroperlog";

    private decimal? _numcaroperlog;

    private static readonly string RO_NUMCARWMS = "Numcarwms";

    private decimal? _numcarwms;

    private static readonly string RO_NUMCID = "Numcid";

    private decimal? _numcid;

    private static readonly string RO_NUMDIARIAS = "Numdiarias";

    private decimal? _numdiarias;

    private static readonly string RO_NUMENT = "Nument";

    private decimal? _nument;

    private static readonly string RO_NUMLANCDIARIA = "Numlancdiaria";

    private decimal? _numlancdiaria;

    private static readonly string RO_NUMNOTAS = "Numnotas";

    private decimal? _numnotas;

    private static readonly string RO_NUMONUCARGA = "Numonucarga";

    private string _numonucarga;

    private static readonly string RO_NUMVIASCARAGRUPADO = "Numviascaragrupado";

    private decimal? _numviascaragrupado;

    private static readonly string RO_NUMVIASMAPA = "Numviasmapa";

    private decimal? _numviasmapa;

    private static readonly string RO_OBSACERTO = "Obsacerto";

    private string _obsacerto;

    private static readonly string RO_OBSDESTINO = "Obsdestino";

    private string _obsdestino;

    private static readonly string RO_OBSDESTINOAGRUP = "Obsdestinoagrup";

    private string _obsdestinoagrup;

    private static readonly string RO_OBSFATUR = "Obsfatur";

    private string _obsfatur;

    private static readonly string RO_PAGCOMMOTMIN = "Pagcommotmin";

    private string _pagcommotmin;

    private static readonly string RO_PERCOM = "Percom";

    private decimal? _percom;

    private static readonly string RO_PERCOMAJUD = "Percomajud";

    private decimal? _percomajud;

    private static readonly string RO_PERCOMTERC = "Percomterc";

    private decimal? _percomterc;

    private static readonly string RO_PERGRIS = "Pergris";

    private decimal? _pergris;

    private static readonly string RO_PONTOFUGORCARGA = "Pontofugorcarga";

    private string _pontofugorcarga;

    private static readonly string RO_PREVCHEG = "Prevcheg";

    private DateTime? _prevcheg;

    private static readonly string RO_QTCAIXAS = "Qtcaixas";

    private decimal? _qtcaixas;

    private static readonly string RO_QTCOMBUSTIVEL = "Qtcombustivel";

    private decimal? _qtcombustivel;

    private static readonly string RO_QTDTOTALPRODCARGA = "Qtdtotalprodcarga";

    private string _qtdtotalprodcarga;

    private static readonly string RO_QTITENS = "Qtitens";

    private decimal? _qtitens;

    private static readonly string RO_SEGUNDOMON = "Segundomon";

    private decimal? _segundomon;

    private static readonly string RO_SEGUNDOSFECHA = "Segundosfecha";

    private decimal? _segundosfecha;

    private static readonly string RO_SEGURADA = "Segurada";

    private string _segurada;

    private static readonly string RO_TIPOCARGA = "Tipocarga";

    private string _tipocarga;

    private static readonly string RO_TIPOCOMISSAO = "Tipocomissao";

    private string _tipocomissao;

    private static readonly string RO_TOTPESO = "Totpeso";

    private decimal? _totpeso;

    private static readonly string RO_TOTVOLUME = "Totvolume";

    private decimal? _totvolume;

    private static readonly string RO_TRANSFERENCIA = "Transferencia";

    private string _transferencia;

    private static readonly string RO_VALORKG = "Valorkg";

    private decimal? _valorkg;

    private static readonly string RO_VLCOMBUSTIVEL = "Vlcombustivel";

    private decimal? _vlcombustivel;

    private static readonly string RO_VLDESPAJUDANTE = "Vldespajudante";

    private decimal? _vldespajudante;

    private static readonly string RO_VLDIARIA = "Vldiaria";

    private decimal? _vldiaria;

    private static readonly string RO_VLFIXO = "Vlfixo";

    private decimal? _vlfixo;

    private static readonly string RO_VLFRETE = "Vlfrete";

    private decimal? _vlfrete;

    private static readonly string RO_VLPED = "Vlped";

    private decimal? _vlped;

    private static readonly string RO_VLTOTAL = "Vltotal";

    private decimal? _vltotal;

    private static readonly string RO_VLVALERETENCAO = "Vlvaleretencao";

    private decimal? _vlvaleretencao;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Abastecido
    {
        get
        {
            PropriedadeAcessada(RO_ABASTECIDO);
            return _abastecido;
        }
        set
        {
            PropriedadeModificada(RO_ABASTECIDO, value);
            _abastecido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Balcaobaixado
    {
        get
        {
            PropriedadeAcessada(RO_BALCAOBAIXADO);
            return _balcaobaixado;
        }
        set
        {
            PropriedadeModificada(RO_BALCAOBAIXADO, value);
            _balcaobaixado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cargasecundaria
    {
        get
        {
            PropriedadeAcessada(RO_CARGASECUNDARIA);
            return _cargasecundaria;
        }
        set
        {
            PropriedadeModificada(RO_CARGASECUNDARIA, value);
            _cargasecundaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codajudtransbordo
    {
        get
        {
            PropriedadeAcessada(RO_CODAJUDTRANSBORDO);
            return _codajudtransbordo;
        }
        set
        {
            PropriedadeModificada(RO_CODAJUDTRANSBORDO, value);
            _codajudtransbordo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codcaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODCAIXA);
            return _codcaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODCAIXA, value);
            _codcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codconf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONF);
            return _codconf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONF, value);
            _codconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialsaida
    {
        get
        {
            PropriedadeAcessada(RO_CODFILIALSAIDA);
            return _codfilialsaida;
        }
        set
        {
            PropriedadeModificada(RO_CODFILIALSAIDA, value);
            _codfilialsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncajud
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCAJUD);
            return _codfuncajud;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCAJUD, value);
            _codfuncajud = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncajud2
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCAJUD2);
            return _codfuncajud2;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCAJUD2, value);
            _codfuncajud2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncajud3
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCAJUD3);
            return _codfuncajud3;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCAJUD3, value);
            _codfuncajud3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccancel
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCANCEL);
            return _codfunccancel;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCANCEL, value);
            _codfunccancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconf
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONF);
            return _codfuncconf;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONF, value);
            _codfuncconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfat
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFAT);
            return _codfuncfat;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFAT, value);
            _codfuncfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncmapa
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCMAPA);
            return _codfuncmapa;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCMAPA, value);
            _codfuncmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncmapacaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCMAPACARAGRUPADO);
            return _codfuncmapacaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCMAPACARAGRUPADO, value);
            _codfuncmapacaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncmon
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCMON);
            return _codfuncmon;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCMON, value);
            _codfuncmon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncretornocar
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCRETORNOCAR);
            return _codfuncretornocar;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCRETORNOCAR, value);
            _codfuncretornocar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncsaidacar
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCSAIDACAR);
            return _codfuncsaidacar;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCSAIDACAR, value);
            _codfuncsaidacar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTORISTA);
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTORISTA, value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotoristacaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTORISTACARAGRUPADO);
            return _codmotoristacaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTORISTACARAGRUPADO, value);
            _codmotoristacaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmottransbordo
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTTRANSBORDO);
            return _codmottransbordo;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTTRANSBORDO, value);
            _codmottransbordo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codrotaprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODROTAPRINC);
            return _codrotaprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODROTAPRINC, value);
            _codrotaprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculcaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULCARAGRUPADO);
            return _codveiculcaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULCARAGRUPADO, value);
            _codveiculcaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO);
            return _codveiculo;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO, value);
            _codveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo1
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO1);
            return _codveiculo1;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO1, value);
            _codveiculo1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codveiculo2
    {
        get
        {
            PropriedadeAcessada(RO_CODVEICULO2);
            return _codveiculo2;
        }
        set
        {
            PropriedadeModificada(RO_CODVEICULO2, value);
            _codveiculo2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conhecfrete
    {
        get
        {
            PropriedadeAcessada(RO_CONHECFRETE);
            return _conhecfrete;
        }
        set
        {
            PropriedadeModificada(RO_CONHECFRETE, value);
            _conhecfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Conhecgerado
    {
        get
        {
            PropriedadeAcessada(RO_CONHECGERADO);
            return _conhecgerado;
        }
        set
        {
            PropriedadeModificada(RO_CONHECGERADO, value);
            _conhecgerado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datacaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_DATACARAGRUPADO);
            return _datacaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_DATACARAGRUPADO, value);
            _datacaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconf
    {
        get
        {
            PropriedadeAcessada(RO_DATACONF);
            return _dataconf;
        }
        set
        {
            PropriedadeModificada(RO_DATACONF, value);
            _dataconf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconffim
    {
        get
        {
            PropriedadeAcessada(RO_DATACONFFIM);
            return _dataconffim;
        }
        set
        {
            PropriedadeModificada(RO_DATACONFFIM, value);
            _dataconffim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoramapa
    {
        get
        {
            PropriedadeAcessada(RO_DATAHORAMAPA);
            return _datahoramapa;
        }
        set
        {
            PropriedadeModificada(RO_DATAHORAMAPA, value);
            _datahoramapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoramapacaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_DATAHORAMAPACARAGRUPADO);
            return _datahoramapacaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_DATAHORAMAPACARAGRUPADO, value);
            _datahoramapacaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datamapa
    {
        get
        {
            PropriedadeAcessada(RO_DATAMAPA);
            return _datamapa;
        }
        set
        {
            PropriedadeModificada(RO_DATAMAPA, value);
            _datamapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datamon
    {
        get
        {
            PropriedadeAcessada(RO_DATAMON);
            return _datamon;
        }
        set
        {
            PropriedadeModificada(RO_DATAMON, value);
            _datamon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Destino
    {
        get
        {
            PropriedadeAcessada(RO_DESTINO);
            return _destino;
        }
        set
        {
            PropriedadeModificada(RO_DESTINO, value);
            _destino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Destinoagrup
    {
        get
        {
            PropriedadeAcessada(RO_DESTINOAGRUP);
            return _destinoagrup;
        }
        set
        {
            PropriedadeModificada(RO_DESTINOAGRUP, value);
            _destinoagrup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Divisaocarga
    {
        get
        {
            PropriedadeAcessada(RO_DIVISAOCARGA);
            return _divisaocarga;
        }
        set
        {
            PropriedadeModificada(RO_DIVISAOCARGA, value);
            _divisaocarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcaixa
    {
        get
        {
            PropriedadeAcessada(RO_DTCAIXA);
            return _dtcaixa;
        }
        set
        {
            PropriedadeModificada(RO_DTCAIXA, value);
            _dtcaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dt_Cancel
    {
        get
        {
            PropriedadeAcessada(RO_DT_CANCEL);
            return _dt_cancel;
        }
        set
        {
            PropriedadeModificada(RO_DT_CANCEL, value);
            _dt_cancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfat
    {
        get
        {
            PropriedadeAcessada(RO_DTFAT);
            return _dtfat;
        }
        set
        {
            PropriedadeModificada(RO_DTFAT, value);
            _dtfat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHA);
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHA, value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechacomajud
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHACOMAJUD);
            return _dtfechacomajud;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHACOMAJUD, value);
            _dtfechacomajud = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechacomajudtransb
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHACOMAJUDTRANSB);
            return _dtfechacomajudtransb;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHACOMAJUDTRANSB, value);
            _dtfechacomajudtransb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechacomissmot
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHACOMISSMOT);
            return _dtfechacomissmot;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHACOMISSMOT, value);
            _dtfechacomissmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechacommottransb
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHACOMMOTTRANSB);
            return _dtfechacommottransb;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHACOMMOTTRANSB, value);
            _dtfechacommottransb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimcheckout
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMCHECKOUT);
            return _dtfimcheckout;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMCHECKOUT, value);
            _dtfimcheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfinalpend
    {
        get
        {
            PropriedadeAcessada(RO_DTFINALPEND);
            return _dtfinalpend;
        }
        set
        {
            PropriedadeModificada(RO_DTFINALPEND, value);
            _dtfinalpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicialpend
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIALPEND);
            return _dtinicialpend;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIALPEND, value);
            _dtinicialpend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciocheckout
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIOCHECKOUT);
            return _dtiniciocheckout;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIOCHECKOUT, value);
            _dtiniciocheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtretorno
    {
        get
        {
            PropriedadeAcessada(RO_DTRETORNO);
            return _dtretorno;
        }
        set
        {
            PropriedadeModificada(RO_DTRETORNO, value);
            _dtretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDA);
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDA, value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaidaveiculo
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDAVEICULO);
            return _dtsaidaveiculo;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDAVEICULO, value);
            _dtsaidaveiculo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Geovolumetotal
    {
        get
        {
            PropriedadeAcessada(RO_GEOVOLUMETOTAL);
            return _geovolumetotal;
        }
        set
        {
            PropriedadeModificada(RO_GEOVOLUMETOTAL, value);
            _geovolumetotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Grupoembcarga
    {
        get
        {
            PropriedadeAcessada(RO_GRUPOEMBCARGA);
            return _grupoembcarga;
        }
        set
        {
            PropriedadeModificada(RO_GRUPOEMBCARGA, value);
            _grupoembcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafecha
    {
        get
        {
            PropriedadeAcessada(RO_HORAFECHA);
            return _horafecha;
        }
        set
        {
            PropriedadeModificada(RO_HORAFECHA, value);
            _horafecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horamon
    {
        get
        {
            PropriedadeAcessada(RO_HORAMON);
            return _horamon;
        }
        set
        {
            PropriedadeModificada(RO_HORAMON, value);
            _horamon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Kmfinal
    {
        get
        {
            PropriedadeAcessada(RO_KMFINAL);
            return _kmfinal;
        }
        set
        {
            PropriedadeModificada(RO_KMFINAL, value);
            _kmfinal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Kminicial
    {
        get
        {
            PropriedadeAcessada(RO_KMINICIAL);
            return _kminicial;
        }
        set
        {
            PropriedadeModificada(RO_KMINICIAL, value);
            _kminicial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Lacre
    {
        get
        {
            PropriedadeAcessada(RO_LACRE);
            return _lacre;
        }
        set
        {
            PropriedadeModificada(RO_LACRE, value);
            _lacre = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lancardespdescfinautomatic
    {
        get
        {
            PropriedadeAcessada(RO_LANCARDESPDESCFINAUTOMATIC);
            return _lancardespdescfinautomatic;
        }
        set
        {
            PropriedadeModificada(RO_LANCARDESPDESCFINAUTOMATIC, value);
            _lancardespdescfinautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Lanctocpagarfechcomiss414
    {
        get
        {
            PropriedadeAcessada(RO_LANCTOCPAGARFECHCOMISS414);
            return _lanctocpagarfechcomiss414;
        }
        set
        {
            PropriedadeModificada(RO_LANCTOCPAGARFECHCOMISS414, value);
            _lanctocpagarfechcomiss414 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mapageradowms
    {
        get
        {
            PropriedadeAcessada(RO_MAPAGERADOWMS);
            return _mapageradowms;
        }
        set
        {
            PropriedadeModificada(RO_MAPAGERADOWMS, value);
            _mapageradowms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Mapageradowmspal
    {
        get
        {
            PropriedadeAcessada(RO_MAPAGERADOWMSPAL);
            return _mapageradowmspal;
        }
        set
        {
            PropriedadeModificada(RO_MAPAGERADOWMSPAL, value);
            _mapageradowmspal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofecha
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOFECHA);
            return _minutofecha;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOFECHA, value);
            _minutofecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutomon
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOMON);
            return _minutomon;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOMON, value);
            _minutomon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 150, Precisao = 0)]
    public string Nomeapropriadocarga
    {
        get
        {
            PropriedadeAcessada(RO_NOMEAPROPRIADOCARGA);
            return _nomeapropriadocarga;
        }
        set
        {
            PropriedadeModificada(RO_NOMEAPROPRIADOCARGA, value);
            _nomeapropriadocarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal Numcar
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAR);
            return _numcar;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAR, value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARAGRUPADO);
            return _numcaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARAGRUPADO, value);
            _numcaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarbroker
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARBROKER);
            return _numcarbroker;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARBROKER, value);
            _numcarbroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarol
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAROL);
            return _numcarol;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAROL, value);
            _numcarol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaroperlog
    {
        get
        {
            PropriedadeAcessada(RO_NUMCAROPERLOG);
            return _numcaroperlog;
        }
        set
        {
            PropriedadeModificada(RO_NUMCAROPERLOG, value);
            _numcaroperlog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcarwms
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARWMS);
            return _numcarwms;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARWMS, value);
            _numcarwms = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcid
    {
        get
        {
            PropriedadeAcessada(RO_NUMCID);
            return _numcid;
        }
        set
        {
            PropriedadeModificada(RO_NUMCID, value);
            _numcid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiarias
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIARIAS);
            return _numdiarias;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIARIAS, value);
            _numdiarias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Nument
    {
        get
        {
            PropriedadeAcessada(RO_NUMENT);
            return _nument;
        }
        set
        {
            PropriedadeModificada(RO_NUMENT, value);
            _nument = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numlancdiaria
    {
        get
        {
            PropriedadeAcessada(RO_NUMLANCDIARIA);
            return _numlancdiaria;
        }
        set
        {
            PropriedadeModificada(RO_NUMLANCDIARIA, value);
            _numlancdiaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numnotas
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTAS);
            return _numnotas;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTAS, value);
            _numnotas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Numonucarga
    {
        get
        {
            PropriedadeAcessada(RO_NUMONUCARGA);
            return _numonucarga;
        }
        set
        {
            PropriedadeModificada(RO_NUMONUCARGA, value);
            _numonucarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numviascaragrupado
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASCARAGRUPADO);
            return _numviascaragrupado;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASCARAGRUPADO, value);
            _numviascaragrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numviasmapa
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASMAPA);
            return _numviasmapa;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASMAPA, value);
            _numviasmapa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Obsacerto
    {
        get
        {
            PropriedadeAcessada(RO_OBSACERTO);
            return _obsacerto;
        }
        set
        {
            PropriedadeModificada(RO_OBSACERTO, value);
            _obsacerto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsdestino
    {
        get
        {
            PropriedadeAcessada(RO_OBSDESTINO);
            return _obsdestino;
        }
        set
        {
            PropriedadeModificada(RO_OBSDESTINO, value);
            _obsdestino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsdestinoagrup
    {
        get
        {
            PropriedadeAcessada(RO_OBSDESTINOAGRUP);
            return _obsdestinoagrup;
        }
        set
        {
            PropriedadeModificada(RO_OBSDESTINOAGRUP, value);
            _obsdestinoagrup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
    public string Obsfatur
    {
        get
        {
            PropriedadeAcessada(RO_OBSFATUR);
            return _obsfatur;
        }
        set
        {
            PropriedadeModificada(RO_OBSFATUR, value);
            _obsfatur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagcommotmin
    {
        get
        {
            PropriedadeAcessada(RO_PAGCOMMOTMIN);
            return _pagcommotmin;
        }
        set
        {
            PropriedadeModificada(RO_PAGCOMMOTMIN, value);
            _pagcommotmin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percomajud
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMAJUD);
            return _percomajud;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMAJUD, value);
            _percomajud = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percomterc
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMTERC);
            return _percomterc;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMTERC, value);
            _percomterc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Pergris
    {
        get
        {
            PropriedadeAcessada(RO_PERGRIS);
            return _pergris;
        }
        set
        {
            PropriedadeModificada(RO_PERGRIS, value);
            _pergris = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Pontofugorcarga
    {
        get
        {
            PropriedadeAcessada(RO_PONTOFUGORCARGA);
            return _pontofugorcarga;
        }
        set
        {
            PropriedadeModificada(RO_PONTOFUGORCARGA, value);
            _pontofugorcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Prevcheg
    {
        get
        {
            PropriedadeAcessada(RO_PREVCHEG);
            return _prevcheg;
        }
        set
        {
            PropriedadeModificada(RO_PREVCHEG, value);
            _prevcheg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Qtcaixas
    {
        get
        {
            PropriedadeAcessada(RO_QTCAIXAS);
            return _qtcaixas;
        }
        set
        {
            PropriedadeModificada(RO_QTCAIXAS, value);
            _qtcaixas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtcombustivel
    {
        get
        {
            PropriedadeAcessada(RO_QTCOMBUSTIVEL);
            return _qtcombustivel;
        }
        set
        {
            PropriedadeModificada(RO_QTCOMBUSTIVEL, value);
            _qtcombustivel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Qtdtotalprodcarga
    {
        get
        {
            PropriedadeAcessada(RO_QTDTOTALPRODCARGA);
            return _qtdtotalprodcarga;
        }
        set
        {
            PropriedadeModificada(RO_QTDTOTALPRODCARGA, value);
            _qtdtotalprodcarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtitens
    {
        get
        {
            PropriedadeAcessada(RO_QTITENS);
            return _qtitens;
        }
        set
        {
            PropriedadeModificada(RO_QTITENS, value);
            _qtitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Segundomon
    {
        get
        {
            PropriedadeAcessada(RO_SEGUNDOMON);
            return _segundomon;
        }
        set
        {
            PropriedadeModificada(RO_SEGUNDOMON, value);
            _segundomon = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Segundosfecha
    {
        get
        {
            PropriedadeAcessada(RO_SEGUNDOSFECHA);
            return _segundosfecha;
        }
        set
        {
            PropriedadeModificada(RO_SEGUNDOSFECHA, value);
            _segundosfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Segurada
    {
        get
        {
            PropriedadeAcessada(RO_SEGURADA);
            return _segurada;
        }
        set
        {
            PropriedadeModificada(RO_SEGURADA, value);
            _segurada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipocarga
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCARGA);
            return _tipocarga;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCARGA, value);
            _tipocarga = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipocomissao
    {
        get
        {
            PropriedadeAcessada(RO_TIPOCOMISSAO);
            return _tipocomissao;
        }
        set
        {
            PropriedadeModificada(RO_TIPOCOMISSAO, value);
            _tipocomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Totpeso
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESO);
            return _totpeso;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESO, value);
            _totpeso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Totvolume
    {
        get
        {
            PropriedadeAcessada(RO_TOTVOLUME);
            return _totvolume;
        }
        set
        {
            PropriedadeModificada(RO_TOTVOLUME, value);
            _totvolume = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Transferencia
    {
        get
        {
            PropriedadeAcessada(RO_TRANSFERENCIA);
            return _transferencia;
        }
        set
        {
            PropriedadeModificada(RO_TRANSFERENCIA, value);
            _transferencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorkg
    {
        get
        {
            PropriedadeAcessada(RO_VALORKG);
            return _valorkg;
        }
        set
        {
            PropriedadeModificada(RO_VALORKG, value);
            _valorkg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Vlcombustivel
    {
        get
        {
            PropriedadeAcessada(RO_VLCOMBUSTIVEL);
            return _vlcombustivel;
        }
        set
        {
            PropriedadeModificada(RO_VLCOMBUSTIVEL, value);
            _vlcombustivel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldespajudante
    {
        get
        {
            PropriedadeAcessada(RO_VLDESPAJUDANTE);
            return _vldespajudante;
        }
        set
        {
            PropriedadeModificada(RO_VLDESPAJUDANTE, value);
            _vldespajudante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vldiaria
    {
        get
        {
            PropriedadeAcessada(RO_VLDIARIA);
            return _vldiaria;
        }
        set
        {
            PropriedadeModificada(RO_VLDIARIA, value);
            _vldiaria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlfixo
    {
        get
        {
            PropriedadeAcessada(RO_VLFIXO);
            return _vlfixo;
        }
        set
        {
            PropriedadeModificada(RO_VLFIXO, value);
            _vlfixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 2)]
    public decimal? Vlfrete
    {
        get
        {
            PropriedadeAcessada(RO_VLFRETE);
            return _vlfrete;
        }
        set
        {
            PropriedadeModificada(RO_VLFRETE, value);
            _vlfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlped
    {
        get
        {
            PropriedadeAcessada(RO_VLPED);
            return _vlped;
        }
        set
        {
            PropriedadeModificada(RO_VLPED, value);
            _vlped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vltotal
    {
        get
        {
            PropriedadeAcessada(RO_VLTOTAL);
            return _vltotal;
        }
        set
        {
            PropriedadeModificada(RO_VLTOTAL, value);
            _vltotal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCARREG", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvaleretencao
    {
        get
        {
            PropriedadeAcessada(RO_VLVALERETENCAO);
            return _vlvaleretencao;
        }
        set
        {
            PropriedadeModificada(RO_VLVALERETENCAO, value);
            _vlvaleretencao = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCARREG";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _abastecido = AlterarTipo<string>(leitor["Abastecido"]);
        _balcaobaixado = AlterarTipo<string>(leitor["Balcaobaixado"]);
        _cargasecundaria = AlterarTipo<string>(leitor["Cargasecundaria"]);
        _codajudtransbordo = AlterarTipo<decimal?>(leitor["Codajudtransbordo"]);
        _codcaixa = AlterarTipo<decimal?>(leitor["Codcaixa"]);
        _codconf = AlterarTipo<decimal?>(leitor["Codconf"]);
        _codfilialsaida = AlterarTipo<string>(leitor["Codfilialsaida"]);
        _codfuncajud = AlterarTipo<decimal?>(leitor["Codfuncajud"]);
        _codfuncajud2 = AlterarTipo<decimal?>(leitor["Codfuncajud2"]);
        _codfuncajud3 = AlterarTipo<decimal?>(leitor["Codfuncajud3"]);
        _codfunccancel = AlterarTipo<decimal?>(leitor["Codfunccancel"]);
        _codfuncconf = AlterarTipo<decimal?>(leitor["Codfuncconf"]);
        _codfuncfat = AlterarTipo<decimal?>(leitor["Codfuncfat"]);
        _codfuncmapa = AlterarTipo<decimal?>(leitor["Codfuncmapa"]);
        _codfuncmapacaragrupado = AlterarTipo<decimal?>(leitor["Codfuncmapacaragrupado"]);
        _codfuncmon = AlterarTipo<decimal?>(leitor["Codfuncmon"]);
        _codfuncretornocar = AlterarTipo<decimal?>(leitor["Codfuncretornocar"]);
        _codfuncsaidacar = AlterarTipo<decimal?>(leitor["Codfuncsaidacar"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codmotoristacaragrupado = AlterarTipo<decimal?>(leitor["Codmotoristacaragrupado"]);
        _codmottransbordo = AlterarTipo<decimal?>(leitor["Codmottransbordo"]);
        _codrotaprinc = AlterarTipo<decimal?>(leitor["Codrotaprinc"]);
        _codveiculcaragrupado = AlterarTipo<decimal?>(leitor["Codveiculcaragrupado"]);
        _codveiculo = AlterarTipo<decimal?>(leitor["Codveiculo"]);
        _codveiculo1 = AlterarTipo<decimal?>(leitor["Codveiculo1"]);
        _codveiculo2 = AlterarTipo<decimal?>(leitor["Codveiculo2"]);
        _conhecfrete = AlterarTipo<string>(leitor["Conhecfrete"]);
        _conhecgerado = AlterarTipo<string>(leitor["Conhecgerado"]);
        _datacaragrupado = AlterarTipo<DateTime?>(leitor["Datacaragrupado"]);
        _dataconf = AlterarTipo<DateTime?>(leitor["Dataconf"]);
        _dataconffim = AlterarTipo<DateTime?>(leitor["Dataconffim"]);
        _datahoramapa = AlterarTipo<DateTime?>(leitor["Datahoramapa"]);
        _datahoramapacaragrupado = AlterarTipo<DateTime?>(leitor["Datahoramapacaragrupado"]);
        _datamapa = AlterarTipo<DateTime?>(leitor["Datamapa"]);
        _datamon = AlterarTipo<DateTime?>(leitor["Datamon"]);
        _destino = AlterarTipo<string>(leitor["Destino"]);
        _destinoagrup = AlterarTipo<string>(leitor["Destinoagrup"]);
        _divisaocarga = AlterarTipo<string>(leitor["Divisaocarga"]);
        _dtcaixa = AlterarTipo<DateTime?>(leitor["Dtcaixa"]);
        _dt_cancel = AlterarTipo<DateTime?>(leitor["Dt_Cancel"]);
        _dtfat = AlterarTipo<DateTime?>(leitor["Dtfat"]);
        _dtfecha = AlterarTipo<DateTime?>(leitor["Dtfecha"]);
        _dtfechacomajud = AlterarTipo<DateTime?>(leitor["Dtfechacomajud"]);
        _dtfechacomajudtransb = AlterarTipo<DateTime?>(leitor["Dtfechacomajudtransb"]);
        _dtfechacomissmot = AlterarTipo<DateTime?>(leitor["Dtfechacomissmot"]);
        _dtfechacommottransb = AlterarTipo<DateTime?>(leitor["Dtfechacommottransb"]);
        _dtfimcheckout = AlterarTipo<DateTime?>(leitor["Dtfimcheckout"]);
        _dtfinalpend = AlterarTipo<DateTime?>(leitor["Dtfinalpend"]);
        _dtinicialpend = AlterarTipo<DateTime?>(leitor["Dtinicialpend"]);
        _dtiniciocheckout = AlterarTipo<DateTime?>(leitor["Dtiniciocheckout"]);
        _dtretorno = AlterarTipo<DateTime?>(leitor["Dtretorno"]);
        _dtsaida = AlterarTipo<DateTime>(leitor["Dtsaida"]);
        _dtsaidaveiculo = AlterarTipo<DateTime?>(leitor["Dtsaidaveiculo"]);
        _frota_peso = AlterarTipo<decimal?>(leitor["Frota_Peso"]);
        _geovolumetotal = AlterarTipo<decimal?>(leitor["Geovolumetotal"]);
        _grupoembcarga = AlterarTipo<string>(leitor["Grupoembcarga"]);
        _horafecha = AlterarTipo<decimal?>(leitor["Horafecha"]);
        _horamon = AlterarTipo<decimal?>(leitor["Horamon"]);
        _kmfinal = AlterarTipo<decimal?>(leitor["Kmfinal"]);
        _kminicial = AlterarTipo<decimal?>(leitor["Kminicial"]);
        _lacre = AlterarTipo<string>(leitor["Lacre"]);
        _lancardespdescfinautomatic = AlterarTipo<string>(leitor["Lancardespdescfinautomatic"]);
        _lanctocpagarfechcomiss414 = AlterarTipo<string>(leitor["Lanctocpagarfechcomiss414"]);
        _mapageradowms = AlterarTipo<string>(leitor["Mapageradowms"]);
        _mapageradowmspal = AlterarTipo<string>(leitor["Mapageradowmspal"]);
        _minutofecha = AlterarTipo<decimal?>(leitor["Minutofecha"]);
        _minutomon = AlterarTipo<decimal?>(leitor["Minutomon"]);
        _nomeapropriadocarga = AlterarTipo<string>(leitor["Nomeapropriadocarga"]);
        _numcar = AlterarTipo<decimal>(leitor["Numcar"]);
        _numcaragrupado = AlterarTipo<decimal?>(leitor["Numcaragrupado"]);
        _numcarbroker = AlterarTipo<decimal?>(leitor["Numcarbroker"]);
        _numcarol = AlterarTipo<decimal?>(leitor["Numcarol"]);
        _numcaroperlog = AlterarTipo<decimal?>(leitor["Numcaroperlog"]);
        _numcarwms = AlterarTipo<decimal?>(leitor["Numcarwms"]);
        _numcid = AlterarTipo<decimal?>(leitor["Numcid"]);
        _numdiarias = AlterarTipo<decimal?>(leitor["Numdiarias"]);
        _nument = AlterarTipo<decimal?>(leitor["Nument"]);
        _numlancdiaria = AlterarTipo<decimal?>(leitor["Numlancdiaria"]);
        _numnotas = AlterarTipo<decimal?>(leitor["Numnotas"]);
        _numonucarga = AlterarTipo<string>(leitor["Numonucarga"]);
        _numviascaragrupado = AlterarTipo<decimal?>(leitor["Numviascaragrupado"]);
        _numviasmapa = AlterarTipo<decimal?>(leitor["Numviasmapa"]);
        _obsacerto = AlterarTipo<string>(leitor["Obsacerto"]);
        _obsdestino = AlterarTipo<string>(leitor["Obsdestino"]);
        _obsdestinoagrup = AlterarTipo<string>(leitor["Obsdestinoagrup"]);
        _obsfatur = AlterarTipo<string>(leitor["Obsfatur"]);
        _pagcommotmin = AlterarTipo<string>(leitor["Pagcommotmin"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percomajud = AlterarTipo<decimal?>(leitor["Percomajud"]);
        _percomterc = AlterarTipo<decimal?>(leitor["Percomterc"]);
        _pergris = AlterarTipo<decimal?>(leitor["Pergris"]);
        _pontofugorcarga = AlterarTipo<string>(leitor["Pontofugorcarga"]);
        _prevcheg = AlterarTipo<DateTime?>(leitor["Prevcheg"]);
        _qtcaixas = AlterarTipo<decimal?>(leitor["Qtcaixas"]);
        _qtcombustivel = AlterarTipo<decimal?>(leitor["Qtcombustivel"]);
        _qtdtotalprodcarga = AlterarTipo<string>(leitor["Qtdtotalprodcarga"]);
        _qtitens = AlterarTipo<decimal?>(leitor["Qtitens"]);
        _segundomon = AlterarTipo<decimal?>(leitor["Segundomon"]);
        _segundosfecha = AlterarTipo<decimal?>(leitor["Segundosfecha"]);
        _segurada = AlterarTipo<string>(leitor["Segurada"]);
        _tipocarga = AlterarTipo<string>(leitor["Tipocarga"]);
        _tipocomissao = AlterarTipo<string>(leitor["Tipocomissao"]);
        _totpeso = AlterarTipo<decimal?>(leitor["Totpeso"]);
        _totvolume = AlterarTipo<decimal?>(leitor["Totvolume"]);
        _transferencia = AlterarTipo<string>(leitor["Transferencia"]);
        _valorkg = AlterarTipo<decimal?>(leitor["Valorkg"]);
        _vlcombustivel = AlterarTipo<decimal?>(leitor["Vlcombustivel"]);
        _vldespajudante = AlterarTipo<decimal?>(leitor["Vldespajudante"]);
        _vldiaria = AlterarTipo<decimal?>(leitor["Vldiaria"]);
        _vlfixo = AlterarTipo<decimal?>(leitor["Vlfixo"]);
        _vlfrete = AlterarTipo<decimal?>(leitor["Vlfrete"]);
        _vlped = AlterarTipo<decimal?>(leitor["Vlped"]);
        _vltotal = AlterarTipo<decimal?>(leitor["Vltotal"]);
        _vlvaleretencao = AlterarTipo<decimal?>(leitor["Vlvaleretencao"]);
    }

}