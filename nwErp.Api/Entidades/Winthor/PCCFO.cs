[Serializable]
public class PCCFO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODFISCAL = "Codfiscal";
    private int _codfiscal;
    
    private static readonly string RO_DESCCFO = "Desccfo";
    private string? _desccfo;
    
    private static readonly string RO_CODOPER = "Codoper";
    private string? _codoper;
    
    private static readonly string RO_DESCSINTEGRA = "Descsintegra";
    private string? _descsintegra;
    
    private static readonly string RO_CODFISCALMASTER = "Codfiscalmaster";
    private int? _codfiscalmaster;
    
    private static readonly string RO_OBSCFO = "Obscfo";
    private string? _obscfo;
    
    private static readonly string RO_CFOPINVERSO = "Cfopinverso";
    private int? _cfopinverso;
    
    private static readonly string RO_ESTOQUEEMTRANSITO = "Estoqueemtransito";
    private string? _estoqueemtransito;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int Codfiscal
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCAL);
            return _codfiscal;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCAL, value);
            _codfiscal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Desccfo
    {
        get
        {
            PropriedadeAcessada(RO_DESCCFO);
            return _desccfo;
        }
        set
        {
            PropriedadeModificada(RO_DESCCFO, value);
            _desccfo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codoper
    {
        get
        {
            PropriedadeAcessada(RO_CODOPER);
            return _codoper;
        }
        set
        {
            PropriedadeModificada(RO_CODOPER, value);
            _codoper = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Descsintegra
    {
        get
        {
            PropriedadeAcessada(RO_DESCSINTEGRA);
            return _descsintegra;
        }
        set
        {
            PropriedadeModificada(RO_DESCSINTEGRA, value);
            _descsintegra = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Codfiscalmaster
    {
        get
        {
            PropriedadeAcessada(RO_CODFISCALMASTER);
            return _codfiscalmaster;
        }
        set
        {
            PropriedadeModificada(RO_CODFISCALMASTER, value);
            _codfiscalmaster = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Obscfo
    {
        get
        {
            PropriedadeAcessada(RO_OBSCFO);
            return _obscfo;
        }
        set
        {
            PropriedadeModificada(RO_OBSCFO, value);
            _obscfo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
    public int? Cfopinverso
    {
        get
        {
            PropriedadeAcessada(RO_CFOPINVERSO);
            return _cfopinverso;
        }
        set
        {
            PropriedadeModificada(RO_CFOPINVERSO, value);
            _cfopinverso = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCFO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Estoqueemtransito
    {
        get
        {
            PropriedadeAcessada(RO_ESTOQUEEMTRANSITO);
            return _estoqueemtransito;
        }
        set
        {
            PropriedadeModificada(RO_ESTOQUEEMTRANSITO, value);
            _estoqueemtransito = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCCFO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codfiscal = AlterarTipo<int>(leitor["Codfiscal"]);
        _desccfo = AlterarTipo<string?>(leitor["Desccfo"]);
        _codoper = AlterarTipo<string?>(leitor["Codoper"]);
        _descsintegra = AlterarTipo<string?>(leitor["Descsintegra"]);
        _codfiscalmaster = AlterarTipo<int?>(leitor["Codfiscalmaster"]);
        _obscfo = AlterarTipo<string?>(leitor["Obscfo"]);
        _cfopinverso = AlterarTipo<int?>(leitor["Cfopinverso"]);
        _estoqueemtransito = AlterarTipo<string?>(leitor["Estoqueemtransito"]);
    }
}