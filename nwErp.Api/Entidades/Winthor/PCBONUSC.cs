[Serializable]
public class PCBONUSC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_NUMBONUS = "Numbonus";
    private int _numbonus;
    
    private static readonly string RO_DATABONUS = "Databonus";
    private DateTime _databonus;
    
    private static readonly string RO_QTNFS = "Qtnfs";
    private int _qtnfs;
    
    private static readonly string RO_VALORTOTAL = "Valortotal";
    private decimal _valortotal;
    
    private static readonly string RO_PESOTOTAL = "Pesototal";
    private decimal? _pesototal;
    
    private static readonly string RO_DATARM = "Datarm";
    private DateTime? _datarm;
    
    private static readonly string RO_CODFUNCRM = "Codfuncrm";
    private int? _codfuncrm;
    
    private static readonly string RO_OBS = "Obs";
    private string? _obs;
    
    private static readonly string RO_DTFECHAMENTO = "Dtfechamento";
    private DateTime? _dtfechamento;
    
    private static readonly string RO_CODFUNCBONUS = "Codfuncbonus";
    private int? _codfuncbonus;
    
    private static readonly string RO_CODFUNCFECHA = "Codfuncfecha";
    private int? _codfuncfecha;
    
    private static readonly string RO_CODFILIAL = "Codfilial";
    private string? _codfilial;
    
    private static readonly string RO_PLACA = "Placa";
    private string? _placa;
    
    private static readonly string RO_TIPOSENHA = "Tiposenha";
    private string? _tiposenha;
    
    private static readonly string RO_HORA = "Hora";
    private int? _hora;
    
    private static readonly string RO_MINUTO = "Minuto";
    private int? _minuto;
    
    private static readonly string RO_SENHA = "Senha";
    private int? _senha;
    
    private static readonly string RO_TIPOCARGA = "Tipocarga";
    private string? _tipocarga;
    
    private static readonly string RO_PESO = "Peso";
    private decimal? _peso;
    
    private static readonly string RO_CODFORNECTRANSP = "Codfornectransp";
    private int? _codfornectransp;
    
    private static readonly string RO_OBS1 = "Obs1";
    private string? _obs1;
    
    private static readonly string RO_OBS2 = "Obs2";
    private string? _obs2;
    
    private static readonly string RO_TIPODESCARGA = "Tipodescarga";
    private string? _tipodescarga;
    
    private static readonly string RO_VLDESCARGA = "Vldescarga";
    private decimal? _vldescarga;
    
    private static readonly string RO_DTDESCARGA = "Dtdescarga";
    private DateTime? _dtdescarga;
    
    private static readonly string RO_NUMVIASRECIBO = "Numviasrecibo";
    private int? _numviasrecibo;
    
    private static readonly string RO_CALCDESCARGA = "Calcdescarga";
    private string? _calcdescarga;
    
    private static readonly string RO_VLDESCARGAP = "Vldescargap";
    private decimal? _vldescargap;
    
    private static readonly string RO_VLDESCARGAV = "Vldescargav";
    private decimal? _vldescargav;
    
    private static readonly string RO_TOTPESODESCARGA = "Totpesodescarga";
    private decimal? _totpesodescarga;
    
    private static readonly string RO_TOTVOLUMEDESCARGA = "Totvolumedescarga";
    private decimal? _totvolumedescarga;
    
    private static readonly string RO_DTCANCEL = "Dtcancel";
    private DateTime? _dtcancel;
    
    private static readonly string RO_CODFUNCCANCEL = "Codfunccancel";
    private int? _codfunccancel;
    
    private static readonly string RO_MOTIVOCANCEL = "Motivocancel";
    private string? _motivocancel;
    
    private static readonly string RO_OBS3 = "Obs3";
    private string? _obs3;
    
    private static readonly string RO_OBS4 = "Obs4";
    private string? _obs4;
    
    private static readonly string RO_OBS5 = "Obs5";
    private string? _obs5;
    
    private static readonly string RO_VLINFORMADO = "Vlinformado";
    private decimal? _vlinformado;
    
    private static readonly string RO_BOX = "Box";
    private int? _box;
    
    private static readonly string RO_NOMEMOTORISTA = "Nomemotorista";
    private string? _nomemotorista;
    
    private static readonly string RO_QTBLOQUEADALIBERADA = "Qtbloqueadaliberada";
    private string? _qtbloqueadaliberada;
    
    private static readonly string RO_EMITIDO = "Emitido";
    private string? _emitido;
    
    private static readonly string RO_MINUTOMONTAGEM = "Minutomontagem";
    private int? _minutomontagem;
    
    private static readonly string RO_HORAMONTAGEM = "Horamontagem";
    private int? _horamontagem;
    
    private static readonly string RO_PESOBALANCA1 = "Pesobalanca1";
    private decimal? _pesobalanca1;
    
    private static readonly string RO_PESOBALANCA2 = "Pesobalanca2";
    private decimal? _pesobalanca2;
    
    private static readonly string RO_VLADICIONAL = "Vladicional";
    private decimal? _vladicional;
    
    private static readonly string RO_CODBANCORECDESCARGA = "Codbancorecdescarga";
    private int? _codbancorecdescarga;
    
    private static readonly string RO_VLDESCONTO = "Vldesconto";
    private decimal? _vldesconto;
    
    private static readonly string RO_NUMVIASBONUS = "Numviasbonus";
    private int? _numviasbonus;
    
    private static readonly string RO_CODBANCORECREMONTE = "Codbancorecremonte";
    private int? _codbancorecremonte;
    
    private static readonly string RO_NUMVIASRECIBOREMONTE = "Numviasreciboremonte";
    private int? _numviasreciboremonte;
    
    private static readonly string RO_QTPALETESREMONTE = "Qtpaletesremonte";
    private int? _qtpaletesremonte;
    
    private static readonly string RO_VLREMONTE = "Vlremonte";
    private decimal? _vlremonte;
    
    private static readonly string RO_DATAFECHACOMPLETA = "Datafechacompleta";
    private DateTime? _datafechacompleta;
    
    private static readonly string RO_DTMONTAGEM = "Dtmontagem";
    private DateTime? _dtmontagem;
    
    private static readonly string RO_DTFECHAMENTOTOTAL = "Dtfechamentototal";
    private DateTime? _dtfechamentototal;
    
    private static readonly string RO_NUMTRANSENTLOTE = "Numtransentlote";
    private int? _numtransentlote;
    
    private static readonly string RO_NUMTRANSVENDALOTE = "Numtransvendalote";
    private int? _numtransvendalote;
    
    private static readonly string RO_TIPODOCMOTORISTA = "Tipodocmotorista";
    private string? _tipodocmotorista;
    
    private static readonly string RO_NUMDOCMOTORISTA = "Numdocmotorista";
    private string? _numdocmotorista;
    
    private static readonly string RO_DTCHEGADAMOTORISTA = "Dtchegadamotorista";
    private DateTime? _dtchegadamotorista;
    
    private static readonly string RO_ENDERECAMENTOPORPALETE = "Enderecamentoporpalete";
    private string? _enderecamentoporpalete;
    
    private static readonly string RO_UTILIZOUPREENT = "Utilizoupreent";
    private string? _utilizoupreent;
    
    private static readonly string RO_DATACONF = "Dataconf";
    private DateTime? _dataconf;
    
    private static readonly string RO_USARF = "Usarf";
    private string? _usarf;
    
    private static readonly string RO_ESTBONIFIC = "Estbonific";
    private string? _estbonific;
    
    private static readonly string RO_LIBERAESTENTMERC = "Liberaestentmerc";
    private string? _liberaestentmerc;
    
    private static readonly string RO_LIBERAESTFECHBONUS = "Liberaestfechbonus";
    private string? _liberaestfechbonus;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Numbonus
    {
        get
        {
            PropriedadeAcessada(RO_NUMBONUS);
            return _numbonus;
        }
        set
        {
            PropriedadeModificada(RO_NUMBONUS, value);
            _numbonus = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime Databonus
    {
        get
        {
            PropriedadeAcessada(RO_DATABONUS);
            return _databonus;
        }
        set
        {
            PropriedadeModificada(RO_DATABONUS, value);
            _databonus = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Qtnfs
    {
        get
        {
            PropriedadeAcessada(RO_QTNFS);
            return _qtnfs;
        }
        set
        {
            PropriedadeModificada(RO_QTNFS, value);
            _qtnfs = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal Valortotal
    {
        get
        {
            PropriedadeAcessada(RO_VALORTOTAL);
            return _valortotal;
        }
        set
        {
            PropriedadeModificada(RO_VALORTOTAL, value);
            _valortotal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Pesototal
    {
        get
        {
            PropriedadeAcessada(RO_PESOTOTAL);
            return _pesototal;
        }
        set
        {
            PropriedadeModificada(RO_PESOTOTAL, value);
            _pesototal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Datarm
    {
        get
        {
            PropriedadeAcessada(RO_DATARM);
            return _datarm;
        }
        set
        {
            PropriedadeModificada(RO_DATARM, value);
            _datarm = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfuncrm
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtfechamento
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAMENTO);
            return _dtfechamento;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAMENTO, value);
            _dtfechamento = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfuncbonus
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCBONUS);
            return _codfuncbonus;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCBONUS, value);
            _codfuncbonus = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfuncfecha
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFECHA);
            return _codfuncfecha;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFECHA, value);
            _codfuncfecha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codfilial
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Placa
    {
        get
        {
            PropriedadeAcessada(RO_PLACA);
            return _placa;
        }
        set
        {
            PropriedadeModificada(RO_PLACA, value);
            _placa = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tiposenha
    {
        get
        {
            PropriedadeAcessada(RO_TIPOSENHA);
            return _tiposenha;
        }
        set
        {
            PropriedadeModificada(RO_TIPOSENHA, value);
            _tiposenha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Hora
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Minuto
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Senha
    {
        get
        {
            PropriedadeAcessada(RO_SENHA);
            return _senha;
        }
        set
        {
            PropriedadeModificada(RO_SENHA, value);
            _senha = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipocarga
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Peso
    {
        get
        {
            PropriedadeAcessada(RO_PESO);
            return _peso;
        }
        set
        {
            PropriedadeModificada(RO_PESO, value);
            _peso = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codfornectransp
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNECTRANSP);
            return _codfornectransp;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNECTRANSP, value);
            _codfornectransp = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs1
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs2
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipodescarga
    {
        get
        {
            PropriedadeAcessada(RO_TIPODESCARGA);
            return _tipodescarga;
        }
        set
        {
            PropriedadeModificada(RO_TIPODESCARGA, value);
            _tipodescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldescarga
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCARGA);
            return _vldescarga;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCARGA, value);
            _vldescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtdescarga
    {
        get
        {
            PropriedadeAcessada(RO_DTDESCARGA);
            return _dtdescarga;
        }
        set
        {
            PropriedadeModificada(RO_DTDESCARGA, value);
            _dtdescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Numviasrecibo
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASRECIBO);
            return _numviasrecibo;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASRECIBO, value);
            _numviasrecibo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Calcdescarga
    {
        get
        {
            PropriedadeAcessada(RO_CALCDESCARGA);
            return _calcdescarga;
        }
        set
        {
            PropriedadeModificada(RO_CALCDESCARGA, value);
            _calcdescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldescargap
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCARGAP);
            return _vldescargap;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCARGAP, value);
            _vldescargap = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldescargav
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCARGAV);
            return _vldescargav;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCARGAV, value);
            _vldescargav = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
    public decimal? Totpesodescarga
    {
        get
        {
            PropriedadeAcessada(RO_TOTPESODESCARGA);
            return _totpesodescarga;
        }
        set
        {
            PropriedadeModificada(RO_TOTPESODESCARGA, value);
            _totpesodescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 4)]
    public decimal? Totvolumedescarga
    {
        get
        {
            PropriedadeAcessada(RO_TOTVOLUMEDESCARGA);
            return _totvolumedescarga;
        }
        set
        {
            PropriedadeModificada(RO_TOTVOLUMEDESCARGA, value);
            _totvolumedescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCEL);
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCEL, value);
            _dtcancel = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfunccancel
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Motivocancel
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOCANCEL);
            return _motivocancel;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOCANCEL, value);
            _motivocancel = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs3
    {
        get
        {
            PropriedadeAcessada(RO_OBS3);
            return _obs3;
        }
        set
        {
            PropriedadeModificada(RO_OBS3, value);
            _obs3 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs4
    {
        get
        {
            PropriedadeAcessada(RO_OBS4);
            return _obs4;
        }
        set
        {
            PropriedadeModificada(RO_OBS4, value);
            _obs4 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obs5
    {
        get
        {
            PropriedadeAcessada(RO_OBS5);
            return _obs5;
        }
        set
        {
            PropriedadeModificada(RO_OBS5, value);
            _obs5 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlinformado
    {
        get
        {
            PropriedadeAcessada(RO_VLINFORMADO);
            return _vlinformado;
        }
        set
        {
            PropriedadeModificada(RO_VLINFORMADO, value);
            _vlinformado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Box
    {
        get
        {
            PropriedadeAcessada(RO_BOX);
            return _box;
        }
        set
        {
            PropriedadeModificada(RO_BOX, value);
            _box = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Nomemotorista
    {
        get
        {
            PropriedadeAcessada(RO_NOMEMOTORISTA);
            return _nomemotorista;
        }
        set
        {
            PropriedadeModificada(RO_NOMEMOTORISTA, value);
            _nomemotorista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Qtbloqueadaliberada
    {
        get
        {
            PropriedadeAcessada(RO_QTBLOQUEADALIBERADA);
            return _qtbloqueadaliberada;
        }
        set
        {
            PropriedadeModificada(RO_QTBLOQUEADALIBERADA, value);
            _qtbloqueadaliberada = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Emitido
    {
        get
        {
            PropriedadeAcessada(RO_EMITIDO);
            return _emitido;
        }
        set
        {
            PropriedadeModificada(RO_EMITIDO, value);
            _emitido = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Minutomontagem
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOMONTAGEM);
            return _minutomontagem;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOMONTAGEM, value);
            _minutomontagem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Horamontagem
    {
        get
        {
            PropriedadeAcessada(RO_HORAMONTAGEM);
            return _horamontagem;
        }
        set
        {
            PropriedadeModificada(RO_HORAMONTAGEM, value);
            _horamontagem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Pesobalanca1
    {
        get
        {
            PropriedadeAcessada(RO_PESOBALANCA1);
            return _pesobalanca1;
        }
        set
        {
            PropriedadeModificada(RO_PESOBALANCA1, value);
            _pesobalanca1 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Pesobalanca2
    {
        get
        {
            PropriedadeAcessada(RO_PESOBALANCA2);
            return _pesobalanca2;
        }
        set
        {
            PropriedadeModificada(RO_PESOBALANCA2, value);
            _pesobalanca2 = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 2)]
    public decimal? Vladicional
    {
        get
        {
            PropriedadeAcessada(RO_VLADICIONAL);
            return _vladicional;
        }
        set
        {
            PropriedadeModificada(RO_VLADICIONAL, value);
            _vladicional = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codbancorecdescarga
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCORECDESCARGA);
            return _codbancorecdescarga;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCORECDESCARGA, value);
            _codbancorecdescarga = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 2)]
    public decimal? Vldesconto
    {
        get
        {
            PropriedadeAcessada(RO_VLDESCONTO);
            return _vldesconto;
        }
        set
        {
            PropriedadeModificada(RO_VLDESCONTO, value);
            _vldesconto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 3, Precisao = 0)]
    public int? Numviasbonus
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASBONUS);
            return _numviasbonus;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASBONUS, value);
            _numviasbonus = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codbancorecremonte
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCORECREMONTE);
            return _codbancorecremonte;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCORECREMONTE, value);
            _codbancorecremonte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Numviasreciboremonte
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASRECIBOREMONTE);
            return _numviasreciboremonte;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASRECIBOREMONTE, value);
            _numviasreciboremonte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Qtpaletesremonte
    {
        get
        {
            PropriedadeAcessada(RO_QTPALETESREMONTE);
            return _qtpaletesremonte;
        }
        set
        {
            PropriedadeModificada(RO_QTPALETESREMONTE, value);
            _qtpaletesremonte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 2)]
    public decimal? Vlremonte
    {
        get
        {
            PropriedadeAcessada(RO_VLREMONTE);
            return _vlremonte;
        }
        set
        {
            PropriedadeModificada(RO_VLREMONTE, value);
            _vlremonte = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Datafechacompleta
    {
        get
        {
            PropriedadeAcessada(RO_DATAFECHACOMPLETA);
            return _datafechacompleta;
        }
        set
        {
            PropriedadeModificada(RO_DATAFECHACOMPLETA, value);
            _datafechacompleta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtmontagem
    {
        get
        {
            PropriedadeAcessada(RO_DTMONTAGEM);
            return _dtmontagem;
        }
        set
        {
            PropriedadeModificada(RO_DTMONTAGEM, value);
            _dtmontagem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtfechamentototal
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAMENTOTOTAL);
            return _dtfechamentototal;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAMENTOTOTAL, value);
            _dtfechamentototal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numtransentlote
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTLOTE);
            return _numtransentlote;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTLOTE, value);
            _numtransentlote = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Numtransvendalote
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDALOTE);
            return _numtransvendalote;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDALOTE, value);
            _numtransvendalote = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipodocmotorista
    {
        get
        {
            PropriedadeAcessada(RO_TIPODOCMOTORISTA);
            return _tipodocmotorista;
        }
        set
        {
            PropriedadeModificada(RO_TIPODOCMOTORISTA, value);
            _tipodocmotorista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numdocmotorista
    {
        get
        {
            PropriedadeAcessada(RO_NUMDOCMOTORISTA);
            return _numdocmotorista;
        }
        set
        {
            PropriedadeModificada(RO_NUMDOCMOTORISTA, value);
            _numdocmotorista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtchegadamotorista
    {
        get
        {
            PropriedadeAcessada(RO_DTCHEGADAMOTORISTA);
            return _dtchegadamotorista;
        }
        set
        {
            PropriedadeModificada(RO_DTCHEGADAMOTORISTA, value);
            _dtchegadamotorista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Enderecamentoporpalete
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECAMENTOPORPALETE);
            return _enderecamentoporpalete;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECAMENTOPORPALETE, value);
            _enderecamentoporpalete = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Utilizoupreent
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZOUPREENT);
            return _utilizoupreent;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZOUPREENT, value);
            _utilizoupreent = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Usarf
    {
        get
        {
            PropriedadeAcessada(RO_USARF);
            return _usarf;
        }
        set
        {
            PropriedadeModificada(RO_USARF, value);
            _usarf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Estbonific
    {
        get
        {
            PropriedadeAcessada(RO_ESTBONIFIC);
            return _estbonific;
        }
        set
        {
            PropriedadeModificada(RO_ESTBONIFIC, value);
            _estbonific = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Liberaestentmerc
    {
        get
        {
            PropriedadeAcessada(RO_LIBERAESTENTMERC);
            return _liberaestentmerc;
        }
        set
        {
            PropriedadeModificada(RO_LIBERAESTENTMERC, value);
            _liberaestentmerc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Liberaestfechbonus
    {
        get
        {
            PropriedadeAcessada(RO_LIBERAESTFECHBONUS);
            return _liberaestfechbonus;
        }
        set
        {
            PropriedadeModificada(RO_LIBERAESTFECHBONUS, value);
            _liberaestfechbonus = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCBONUSC";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _numbonus = AlterarTipo<int>(leitor["Numbonus"]);
        _databonus = AlterarTipo<DateTime>(leitor["Databonus"]);
        _qtnfs = AlterarTipo<int>(leitor["Qtnfs"]);
        _valortotal = AlterarTipo<decimal>(leitor["Valortotal"]);
        _pesototal = AlterarTipo<decimal?>(leitor["Pesototal"]);
        _datarm = AlterarTipo<DateTime?>(leitor["Datarm"]);
        _codfuncrm = AlterarTipo<int?>(leitor["Codfuncrm"]);
        _obs = AlterarTipo<string?>(leitor["Obs"]);
        _dtfechamento = AlterarTipo<DateTime?>(leitor["Dtfechamento"]);
        _codfuncbonus = AlterarTipo<int?>(leitor["Codfuncbonus"]);
        _codfuncfecha = AlterarTipo<int?>(leitor["Codfuncfecha"]);
        _codfilial = AlterarTipo<string?>(leitor["Codfilial"]);
        _placa = AlterarTipo<string?>(leitor["Placa"]);
        _tiposenha = AlterarTipo<string?>(leitor["Tiposenha"]);
        _hora = AlterarTipo<int?>(leitor["Hora"]);
        _minuto = AlterarTipo<int?>(leitor["Minuto"]);
        _senha = AlterarTipo<int?>(leitor["Senha"]);
        _tipocarga = AlterarTipo<string?>(leitor["Tipocarga"]);
        _peso = AlterarTipo<decimal?>(leitor["Peso"]);
        _codfornectransp = AlterarTipo<int?>(leitor["Codfornectransp"]);
        _obs1 = AlterarTipo<string?>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string?>(leitor["Obs2"]);
        _tipodescarga = AlterarTipo<string?>(leitor["Tipodescarga"]);
        _vldescarga = AlterarTipo<decimal?>(leitor["Vldescarga"]);
        _dtdescarga = AlterarTipo<DateTime?>(leitor["Dtdescarga"]);
        _numviasrecibo = AlterarTipo<int?>(leitor["Numviasrecibo"]);
        _calcdescarga = AlterarTipo<string?>(leitor["Calcdescarga"]);
        _vldescargap = AlterarTipo<decimal?>(leitor["Vldescargap"]);
        _vldescargav = AlterarTipo<decimal?>(leitor["Vldescargav"]);
        _totpesodescarga = AlterarTipo<decimal?>(leitor["Totpesodescarga"]);
        _totvolumedescarga = AlterarTipo<decimal?>(leitor["Totvolumedescarga"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _codfunccancel = AlterarTipo<int?>(leitor["Codfunccancel"]);
        _motivocancel = AlterarTipo<string?>(leitor["Motivocancel"]);
        _obs3 = AlterarTipo<string?>(leitor["Obs3"]);
        _obs4 = AlterarTipo<string?>(leitor["Obs4"]);
        _obs5 = AlterarTipo<string?>(leitor["Obs5"]);
        _vlinformado = AlterarTipo<decimal?>(leitor["Vlinformado"]);
        _box = AlterarTipo<int?>(leitor["Box"]);
        _nomemotorista = AlterarTipo<string?>(leitor["Nomemotorista"]);
        _qtbloqueadaliberada = AlterarTipo<string?>(leitor["Qtbloqueadaliberada"]);
        _emitido = AlterarTipo<string?>(leitor["Emitido"]);
        _minutomontagem = AlterarTipo<int?>(leitor["Minutomontagem"]);
        _horamontagem = AlterarTipo<int?>(leitor["Horamontagem"]);
        _pesobalanca1 = AlterarTipo<decimal?>(leitor["Pesobalanca1"]);
        _pesobalanca2 = AlterarTipo<decimal?>(leitor["Pesobalanca2"]);
        _vladicional = AlterarTipo<decimal?>(leitor["Vladicional"]);
        _codbancorecdescarga = AlterarTipo<int?>(leitor["Codbancorecdescarga"]);
        _vldesconto = AlterarTipo<decimal?>(leitor["Vldesconto"]);
        _numviasbonus = AlterarTipo<int?>(leitor["Numviasbonus"]);
        _codbancorecremonte = AlterarTipo<int?>(leitor["Codbancorecremonte"]);
        _numviasreciboremonte = AlterarTipo<int?>(leitor["Numviasreciboremonte"]);
        _qtpaletesremonte = AlterarTipo<int?>(leitor["Qtpaletesremonte"]);
        _vlremonte = AlterarTipo<decimal?>(leitor["Vlremonte"]);
        _datafechacompleta = AlterarTipo<DateTime?>(leitor["Datafechacompleta"]);
        _dtmontagem = AlterarTipo<DateTime?>(leitor["Dtmontagem"]);
        _dtfechamentototal = AlterarTipo<DateTime?>(leitor["Dtfechamentototal"]);
        _numtransentlote = AlterarTipo<int?>(leitor["Numtransentlote"]);
        _numtransvendalote = AlterarTipo<int?>(leitor["Numtransvendalote"]);
        _tipodocmotorista = AlterarTipo<string?>(leitor["Tipodocmotorista"]);
        _numdocmotorista = AlterarTipo<string?>(leitor["Numdocmotorista"]);
        _dtchegadamotorista = AlterarTipo<DateTime?>(leitor["Dtchegadamotorista"]);
        _enderecamentoporpalete = AlterarTipo<string?>(leitor["Enderecamentoporpalete"]);
        _utilizoupreent = AlterarTipo<string?>(leitor["Utilizoupreent"]);
        _dataconf = AlterarTipo<DateTime?>(leitor["Dataconf"]);
        _usarf = AlterarTipo<string?>(leitor["Usarf"]);
        _estbonific = AlterarTipo<string?>(leitor["Estbonific"]);
        _liberaestentmerc = AlterarTipo<string?>(leitor["Liberaestentmerc"]);
        _liberaestfechbonus = AlterarTipo<string?>(leitor["Liberaestfechbonus"]);
    }
}