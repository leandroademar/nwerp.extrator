[Serializable]
public class PCBONUSI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_NUMBONUS = "Numbonus";
    private int _numbonus;
    
    private static readonly string RO_CODPROD = "Codprod";
    private int _codprod;
    
    private static readonly string RO_QTNF = "Qtnf";
    private decimal? _qtnf;
    
    private static readonly string RO_QTENTRADA = "Qtentrada";
    private decimal? _qtentrada;
    
    private static readonly string RO_ENDERECADO = "Enderecado";
    private string? _enderecado;
    
    private static readonly string RO_DTVALIDADE = "Dtvalidade";
    private DateTime? _dtvalidade;
    
    private static readonly string RO_CODFORNEC = "Codfornec";
    private int? _codfornec;
    
    private static readonly string RO_CODEPTO = "Codepto";
    private int? _codepto;
    
    private static readonly string RO_QTSAIDA = "Qtsaida";
    private decimal? _qtsaida;
    
    private static readonly string RO_QTESTGER = "Qtestger";
    private decimal? _qtestger;
    
    private static readonly string RO_DTULTSAIDA = "Dtultsaida";
    private DateTime? _dtultsaida;
    
    private static readonly string RO_QTAVARIA = "Qtavaria";
    private decimal? _qtavaria;
    
    private static readonly string RO_NUMBONO = "Numbono";
    private int? _numbono;
    
    private static readonly string RO_PERCINTEIRO = "Percinteiro";
    private decimal? _percinteiro;
    
    private static readonly string RO_PERCQUEBRADO = "Percquebrado";
    private decimal? _percquebrado;
    
    private static readonly string RO_PERCIMPUREZA = "Percimpureza";
    private decimal? _percimpureza;
    
    private static readonly string RO_PERCVERMELHO = "Percvermelho";
    private decimal? _percvermelho;
    
    private static readonly string RO_PERCUMIDADE = "Percumidade";
    private decimal? _percumidade;
    
    private static readonly string RO_CODMOTIVO = "Codmotivo";
    private int? _codmotivo;
    
    private static readonly string RO_NUMLOTE = "Numlote";
    private string _numlote;
    
    private static readonly string RO_QTFALTA = "Qtfalta";
    private decimal? _qtfalta;
    
    private static readonly string RO_QTEXCESSO = "Qtexcesso";
    private decimal? _qtexcesso;
    
    private static readonly string RO_DIVERGENCIA = "Divergencia";
    private string? _divergencia;
    
    private static readonly string RO_OBSDIVERGENCIA = "Obsdivergencia";
    private string? _obsdivergencia;
    
    private static readonly string RO_TIPODIVERGENCIA = "Tipodivergencia";
    private int? _tipodivergencia;
    
    private static readonly string RO_CODFUNCSOLUCAODIVERGENCIA = "Codfuncsolucaodivergencia";
    private int? _codfuncsolucaodivergencia;
    
    private static readonly string RO_DTSOLUCAODIVERGENCIA = "Dtsolucaodivergencia";
    private DateTime? _dtsolucaodivergencia;
    
    private static readonly string RO_CONFERIDA = "Conferida";
    private string? _conferida;
    
    private static readonly string RO_QTAVARIANF = "Qtavarianf";
    private decimal? _qtavarianf;
    
    private static readonly string RO_TOLERANCIASHELFLIFE = "Toleranciashelflife";
    private int? _toleranciashelflife;
    
    private static readonly string RO_QTBLOQUEADALIBERADA = "Qtbloqueadaliberada";
    private string? _qtbloqueadaliberada;
    
    private static readonly string RO_DATAFABRICACAO = "Datafabricacao";
    private DateTime? _datafabricacao;
    
    private static readonly string RO_NUMSEQ = "Numseq";
    private int? _numseq;
    
    private static readonly string RO_QTDEPECAPESAGEM = "Qtdepecapesagem";
    private int? _qtdepecapesagem;
    
    private static readonly string RO_VALORTARAPORPECA = "Valortaraporpeca";
    private decimal? _valortaraporpeca;
    
    private static readonly string RO_NUMLOTENF = "Numlotenf";
    private string? _numlotenf;
    
    private static readonly string RO_QTENTRADACX = "Qtentradacx";
    private decimal? _qtentradacx;
    
    private static readonly string RO_QTAVARIACX = "Qtavariacx";
    private decimal? _qtavariacx;
    
    private static readonly string RO_QTENTCX = "Qtentcx";
    private decimal? _qtentcx;
    
    private static readonly string RO_QTENTUN = "Qtentun";
    private decimal? _qtentun;
    
    private static readonly string RO_QTAVARIAUN = "Qtavariaun";
    private decimal? _qtavariaun;
    
    private static readonly string RO_EANCONF = "Eanconf";
    private int? _eanconf;
    
    private static readonly string RO_DUNCONF = "Dunconf";
    private int? _dunconf;
    
    private static readonly string RO_LASTROCONF = "Lastroconf";
    private decimal? _lastroconf;
    
    private static readonly string RO_CAMADACONF = "Camadaconf";
    private decimal? _camadaconf;
    
    private static readonly string RO_QTTOTPALCONF = "Qttotpalconf";
    private decimal? _qttotpalconf;
    
    private static readonly string RO_DADOSLOGISTICOS = "Dadoslogisticos";
    private string? _dadoslogisticos;
    
    private static readonly string RO_NUMVIASETIQUETA = "Numviasetiqueta";
    private int? _numviasetiqueta;
    
    private static readonly string RO_CODAGREGACAO = "Codagregacao";
    private string? _codagregacao;
    
    private static readonly string RO_NUMLOTEFAB = "Numlotefab";
    private string? _numlotefab;
    
    private static readonly string RO_NUMLOTEFORNEC = "Numlotefornec";
    private string? _numlotefornec;
    
    private static readonly string RO_QTAVARIADIGITA = "Qtavariadigita";
    private decimal? _qtavariadigita;
    
    private static readonly string RO_CODDEPOSITO = "Coddeposito";
    private int? _coddeposito;
    
    private static readonly string RO_ITEMDESDOBRADO = "Itemdesdobrado";
    private string? _itemdesdobrado;
    
    private static readonly string RO_TIPOEMBALAGEMPEDIDO = "Tipoembalagempedido";
    private string? _tipoembalagempedido;
    
    private static readonly string RO_TRANSACAONOTADESDOBRALOTE = "Transacaonotadesdobralote";
    private int? _transacaonotadesdobralote;
    
    private static readonly string RO_ID_PCBONUSINF = "Id_pcbonusinf";
    private string? _id_pcbonusinf;
    
    private static readonly string RO_QTNFORIG = "Qtnforig";
    private decimal? _qtnforig;
    

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codprod
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtnf
    {
        get
        {
            PropriedadeAcessada(RO_QTNF);
            return _qtnf;
        }
        set
        {
            PropriedadeModificada(RO_QTNF, value);
            _qtnf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtentrada
    {
        get
        {
            PropriedadeAcessada(RO_QTENTRADA);
            return _qtentrada;
        }
        set
        {
            PropriedadeModificada(RO_QTENTRADA, value);
            _qtentrada = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Enderecado
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECADO);
            return _enderecado;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECADO, value);
            _enderecado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codfornec
    {
        get
        {
            PropriedadeAcessada(RO_CODFORNEC);
            return _codfornec;
        }
        set
        {
            PropriedadeModificada(RO_CODFORNEC, value);
            _codfornec = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Codepto
    {
        get
        {
            PropriedadeAcessada(RO_CODEPTO);
            return _codepto;
        }
        set
        {
            PropriedadeModificada(RO_CODEPTO, value);
            _codepto = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtsaida
    {
        get
        {
            PropriedadeAcessada(RO_QTSAIDA);
            return _qtsaida;
        }
        set
        {
            PropriedadeModificada(RO_QTSAIDA, value);
            _qtsaida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtestger
    {
        get
        {
            PropriedadeAcessada(RO_QTESTGER);
            return _qtestger;
        }
        set
        {
            PropriedadeModificada(RO_QTESTGER, value);
            _qtestger = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtultsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTULTSAIDA);
            return _dtultsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTULTSAIDA, value);
            _dtultsaida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavaria
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIA);
            return _qtavaria;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIA, value);
            _qtavaria = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Numbono
    {
        get
        {
            PropriedadeAcessada(RO_NUMBONO);
            return _numbono;
        }
        set
        {
            PropriedadeModificada(RO_NUMBONO, value);
            _numbono = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percinteiro
    {
        get
        {
            PropriedadeAcessada(RO_PERCINTEIRO);
            return _percinteiro;
        }
        set
        {
            PropriedadeModificada(RO_PERCINTEIRO, value);
            _percinteiro = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percquebrado
    {
        get
        {
            PropriedadeAcessada(RO_PERCQUEBRADO);
            return _percquebrado;
        }
        set
        {
            PropriedadeModificada(RO_PERCQUEBRADO, value);
            _percquebrado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percimpureza
    {
        get
        {
            PropriedadeAcessada(RO_PERCIMPUREZA);
            return _percimpureza;
        }
        set
        {
            PropriedadeModificada(RO_PERCIMPUREZA, value);
            _percimpureza = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percvermelho
    {
        get
        {
            PropriedadeAcessada(RO_PERCVERMELHO);
            return _percvermelho;
        }
        set
        {
            PropriedadeModificada(RO_PERCVERMELHO, value);
            _percvermelho = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Percumidade
    {
        get
        {
            PropriedadeAcessada(RO_PERCUMIDADE);
            return _percumidade;
        }
        set
        {
            PropriedadeModificada(RO_PERCUMIDADE, value);
            _percumidade = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Codmotivo
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTIVO);
            return _codmotivo;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTIVO, value);
            _codmotivo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtfalta
    {
        get
        {
            PropriedadeAcessada(RO_QTFALTA);
            return _qtfalta;
        }
        set
        {
            PropriedadeModificada(RO_QTFALTA, value);
            _qtfalta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtexcesso
    {
        get
        {
            PropriedadeAcessada(RO_QTEXCESSO);
            return _qtexcesso;
        }
        set
        {
            PropriedadeModificada(RO_QTEXCESSO, value);
            _qtexcesso = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Divergencia
    {
        get
        {
            PropriedadeAcessada(RO_DIVERGENCIA);
            return _divergencia;
        }
        set
        {
            PropriedadeModificada(RO_DIVERGENCIA, value);
            _divergencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obsdivergencia
    {
        get
        {
            PropriedadeAcessada(RO_OBSDIVERGENCIA);
            return _obsdivergencia;
        }
        set
        {
            PropriedadeModificada(RO_OBSDIVERGENCIA, value);
            _obsdivergencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Tipodivergencia
    {
        get
        {
            PropriedadeAcessada(RO_TIPODIVERGENCIA);
            return _tipodivergencia;
        }
        set
        {
            PropriedadeModificada(RO_TIPODIVERGENCIA, value);
            _tipodivergencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfuncsolucaodivergencia
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCSOLUCAODIVERGENCIA);
            return _codfuncsolucaodivergencia;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCSOLUCAODIVERGENCIA, value);
            _codfuncsolucaodivergencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtsolucaodivergencia
    {
        get
        {
            PropriedadeAcessada(RO_DTSOLUCAODIVERGENCIA);
            return _dtsolucaodivergencia;
        }
        set
        {
            PropriedadeModificada(RO_DTSOLUCAODIVERGENCIA, value);
            _dtsolucaodivergencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Conferida
    {
        get
        {
            PropriedadeAcessada(RO_CONFERIDA);
            return _conferida;
        }
        set
        {
            PropriedadeModificada(RO_CONFERIDA, value);
            _conferida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Qtavarianf
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIANF);
            return _qtavarianf;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIANF, value);
            _qtavarianf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 4, Precisao = 0)]
    public int? Toleranciashelflife
    {
        get
        {
            PropriedadeAcessada(RO_TOLERANCIASHELFLIFE);
            return _toleranciashelflife;
        }
        set
        {
            PropriedadeModificada(RO_TOLERANCIASHELFLIFE, value);
            _toleranciashelflife = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 20, Precisao = 0)]
    public int? Numseq
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Qtdepecapesagem
    {
        get
        {
            PropriedadeAcessada(RO_QTDEPECAPESAGEM);
            return _qtdepecapesagem;
        }
        set
        {
            PropriedadeModificada(RO_QTDEPECAPESAGEM, value);
            _qtdepecapesagem = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valortaraporpeca
    {
        get
        {
            PropriedadeAcessada(RO_VALORTARAPORPECA);
            return _valortaraporpeca;
        }
        set
        {
            PropriedadeModificada(RO_VALORTARAPORPECA, value);
            _valortaraporpeca = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numlotenf
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTENF);
            return _numlotenf;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTENF, value);
            _numlotenf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtentradacx
    {
        get
        {
            PropriedadeAcessada(RO_QTENTRADACX);
            return _qtentradacx;
        }
        set
        {
            PropriedadeModificada(RO_QTENTRADACX, value);
            _qtentradacx = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavariacx
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIACX);
            return _qtavariacx;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIACX, value);
            _qtavariacx = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtentcx
    {
        get
        {
            PropriedadeAcessada(RO_QTENTCX);
            return _qtentcx;
        }
        set
        {
            PropriedadeModificada(RO_QTENTCX, value);
            _qtentcx = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtentun
    {
        get
        {
            PropriedadeAcessada(RO_QTENTUN);
            return _qtentun;
        }
        set
        {
            PropriedadeModificada(RO_QTENTUN, value);
            _qtentun = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavariaun
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIAUN);
            return _qtavariaun;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIAUN, value);
            _qtavariaun = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 20, Precisao = 0)]
    public int? Eanconf
    {
        get
        {
            PropriedadeAcessada(RO_EANCONF);
            return _eanconf;
        }
        set
        {
            PropriedadeModificada(RO_EANCONF, value);
            _eanconf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 20, Precisao = 0)]
    public int? Dunconf
    {
        get
        {
            PropriedadeAcessada(RO_DUNCONF);
            return _dunconf;
        }
        set
        {
            PropriedadeModificada(RO_DUNCONF, value);
            _dunconf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Lastroconf
    {
        get
        {
            PropriedadeAcessada(RO_LASTROCONF);
            return _lastroconf;
        }
        set
        {
            PropriedadeModificada(RO_LASTROCONF, value);
            _lastroconf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Camadaconf
    {
        get
        {
            PropriedadeAcessada(RO_CAMADACONF);
            return _camadaconf;
        }
        set
        {
            PropriedadeModificada(RO_CAMADACONF, value);
            _camadaconf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Qttotpalconf
    {
        get
        {
            PropriedadeAcessada(RO_QTTOTPALCONF);
            return _qttotpalconf;
        }
        set
        {
            PropriedadeModificada(RO_QTTOTPALCONF, value);
            _qttotpalconf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Dadoslogisticos
    {
        get
        {
            PropriedadeAcessada(RO_DADOSLOGISTICOS);
            return _dadoslogisticos;
        }
        set
        {
            PropriedadeModificada(RO_DADOSLOGISTICOS, value);
            _dadoslogisticos = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 2, Precisao = 0)]
    public int? Numviasetiqueta
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASETIQUETA);
            return _numviasetiqueta;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASETIQUETA, value);
            _numviasetiqueta = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codagregacao
    {
        get
        {
            PropriedadeAcessada(RO_CODAGREGACAO);
            return _codagregacao;
        }
        set
        {
            PropriedadeModificada(RO_CODAGREGACAO, value);
            _codagregacao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numlotefab
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Numlotefornec
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtavariadigita
    {
        get
        {
            PropriedadeAcessada(RO_QTAVARIADIGITA);
            return _qtavariadigita;
        }
        set
        {
            PropriedadeModificada(RO_QTAVARIADIGITA, value);
            _qtavariadigita = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Coddeposito
    {
        get
        {
            PropriedadeAcessada(RO_CODDEPOSITO);
            return _coddeposito;
        }
        set
        {
            PropriedadeModificada(RO_CODDEPOSITO, value);
            _coddeposito = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Itemdesdobrado
    {
        get
        {
            PropriedadeAcessada(RO_ITEMDESDOBRADO);
            return _itemdesdobrado;
        }
        set
        {
            PropriedadeModificada(RO_ITEMDESDOBRADO, value);
            _itemdesdobrado = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipoembalagempedido
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGEMPEDIDO);
            return _tipoembalagempedido;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGEMPEDIDO, value);
            _tipoembalagempedido = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 10, Precisao = 0)]
    public int? Transacaonotadesdobralote
    {
        get
        {
            PropriedadeAcessada(RO_TRANSACAONOTADESDOBRALOTE);
            return _transacaonotadesdobralote;
        }
        set
        {
            PropriedadeModificada(RO_TRANSACAONOTADESDOBRALOTE, value);
            _transacaonotadesdobralote = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Id_pcbonusinf
    {
        get
        {
            PropriedadeAcessada(RO_ID_PCBONUSINF);
            return _id_pcbonusinf;
        }
        set
        {
            PropriedadeModificada(RO_ID_PCBONUSINF, value);
            _id_pcbonusinf = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCBONUSI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 6)]
    public decimal? Qtnforig
    {
        get
        {
            PropriedadeAcessada(RO_QTNFORIG);
            return _qtnforig;
        }
        set
        {
            PropriedadeModificada(RO_QTNFORIG, value);
            _qtnforig = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCBONUSI";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _numbonus = AlterarTipo<int>(leitor["Numbonus"]);
        _codprod = AlterarTipo<int>(leitor["Codprod"]);
        _qtnf = AlterarTipo<decimal?>(leitor["Qtnf"]);
        _qtentrada = AlterarTipo<decimal?>(leitor["Qtentrada"]);
        _enderecado = AlterarTipo<string?>(leitor["Enderecado"]);
        _dtvalidade = AlterarTipo<DateTime?>(leitor["Dtvalidade"]);
        _codfornec = AlterarTipo<int?>(leitor["Codfornec"]);
        _codepto = AlterarTipo<int?>(leitor["Codepto"]);
        _qtsaida = AlterarTipo<decimal?>(leitor["Qtsaida"]);
        _qtestger = AlterarTipo<decimal?>(leitor["Qtestger"]);
        _dtultsaida = AlterarTipo<DateTime?>(leitor["Dtultsaida"]);
        _qtavaria = AlterarTipo<decimal?>(leitor["Qtavaria"]);
        _numbono = AlterarTipo<int?>(leitor["Numbono"]);
        _percinteiro = AlterarTipo<decimal?>(leitor["Percinteiro"]);
        _percquebrado = AlterarTipo<decimal?>(leitor["Percquebrado"]);
        _percimpureza = AlterarTipo<decimal?>(leitor["Percimpureza"]);
        _percvermelho = AlterarTipo<decimal?>(leitor["Percvermelho"]);
        _percumidade = AlterarTipo<decimal?>(leitor["Percumidade"]);
        _codmotivo = AlterarTipo<int?>(leitor["Codmotivo"]);
        _numlote = AlterarTipo<string>(leitor["Numlote"]);
        _qtfalta = AlterarTipo<decimal?>(leitor["Qtfalta"]);
        _qtexcesso = AlterarTipo<decimal?>(leitor["Qtexcesso"]);
        _divergencia = AlterarTipo<string?>(leitor["Divergencia"]);
        _obsdivergencia = AlterarTipo<string?>(leitor["Obsdivergencia"]);
        _tipodivergencia = AlterarTipo<int?>(leitor["Tipodivergencia"]);
        _codfuncsolucaodivergencia = AlterarTipo<int?>(leitor["Codfuncsolucaodivergencia"]);
        _dtsolucaodivergencia = AlterarTipo<DateTime?>(leitor["Dtsolucaodivergencia"]);
        _conferida = AlterarTipo<string?>(leitor["Conferida"]);
        _qtavarianf = AlterarTipo<decimal?>(leitor["Qtavarianf"]);
        _toleranciashelflife = AlterarTipo<int?>(leitor["Toleranciashelflife"]);
        _qtbloqueadaliberada = AlterarTipo<string?>(leitor["Qtbloqueadaliberada"]);
        _datafabricacao = AlterarTipo<DateTime?>(leitor["Datafabricacao"]);
        _numseq = AlterarTipo<int?>(leitor["Numseq"]);
        _qtdepecapesagem = AlterarTipo<int?>(leitor["Qtdepecapesagem"]);
        _valortaraporpeca = AlterarTipo<decimal?>(leitor["Valortaraporpeca"]);
        _numlotenf = AlterarTipo<string?>(leitor["Numlotenf"]);
        _qtentradacx = AlterarTipo<decimal?>(leitor["Qtentradacx"]);
        _qtavariacx = AlterarTipo<decimal?>(leitor["Qtavariacx"]);
        _qtentcx = AlterarTipo<decimal?>(leitor["Qtentcx"]);
        _qtentun = AlterarTipo<decimal?>(leitor["Qtentun"]);
        _qtavariaun = AlterarTipo<decimal?>(leitor["Qtavariaun"]);
        _eanconf = AlterarTipo<int?>(leitor["Eanconf"]);
        _dunconf = AlterarTipo<int?>(leitor["Dunconf"]);
        _lastroconf = AlterarTipo<decimal?>(leitor["Lastroconf"]);
        _camadaconf = AlterarTipo<decimal?>(leitor["Camadaconf"]);
        _qttotpalconf = AlterarTipo<decimal?>(leitor["Qttotpalconf"]);
        _dadoslogisticos = AlterarTipo<string?>(leitor["Dadoslogisticos"]);
        _numviasetiqueta = AlterarTipo<int?>(leitor["Numviasetiqueta"]);
        _codagregacao = AlterarTipo<string?>(leitor["Codagregacao"]);
        _numlotefab = AlterarTipo<string?>(leitor["Numlotefab"]);
        _numlotefornec = AlterarTipo<string?>(leitor["Numlotefornec"]);
        _qtavariadigita = AlterarTipo<decimal?>(leitor["Qtavariadigita"]);
        _coddeposito = AlterarTipo<int?>(leitor["Coddeposito"]);
        _itemdesdobrado = AlterarTipo<string?>(leitor["Itemdesdobrado"]);
        _tipoembalagempedido = AlterarTipo<string?>(leitor["Tipoembalagempedido"]);
        _transacaonotadesdobralote = AlterarTipo<int?>(leitor["Transacaonotadesdobralote"]);
        _id_pcbonusinf = AlterarTipo<string?>(leitor["Id_pcbonusinf"]);
        _qtnforig = AlterarTipo<decimal?>(leitor["Qtnforig"]);
    }
}