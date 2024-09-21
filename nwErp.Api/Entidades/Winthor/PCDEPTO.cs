[Serializable]
public class PCDEPTO : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODEPTO = "Codepto";
    private int _codepto;
    
    private static readonly string RO_DESCRICAO = "Descricao";
    private string _descricao;
    
    private static readonly string RO_PERCPARTVENDAPREV = "Percpartvendaprev";
    private decimal? _percpartvendaprev;
    
    private static readonly string RO_PERCMARGEMPREV = "Percmargemprev";
    private decimal? _percmargemprev;
    
    private static readonly string RO_TIPOMERC = "Tipomerc";
    private string? _tipomerc;
    
    private static readonly string RO_EMITEQTUNIT = "Emiteqtunit";
    private string? _emiteqtunit;
    
    private static readonly string RO_ATUALIZAINVGERAL = "Atualizainvgeral";
    private string? _atualizainvgeral;
    
    private static readonly string RO_MARGEMPREVISTA = "Margemprevista";
    private decimal? _margemprevista;
    
    private static readonly string RO_REFERENCIA = "Referencia";
    private string? _referencia;
    
    private static readonly string RO_PERDESCMAXIDEAL = "Perdescmaxideal";
    private decimal? _perdescmaxideal;
    
    private static readonly string RO_PERDESCMAXPOSSIVEL = "Perdescmaxpossivel";
    private decimal? _perdescmaxpossivel;
    
    private static readonly string RO_PERDESCMAXAVISTA = "Perdescmaxavista";
    private decimal? _perdescmaxavista;
    
    private static readonly string RO_PERCCOMGARANTIDA = "Perccomgarantida";
    private decimal? _perccomgarantida;
    
    private static readonly string RO_IDINTEGRACAOCIASHOP = "Idintegracaociashop";
    private string? _idintegracaociashop;
    
    private static readonly string RO_ENVIAECOMMERCE = "Enviaecommerce";
    private string? _enviaecommerce;
    
    private static readonly string RO_DTULTALTER = "Dtultalter";
    private DateTime? _dtultalter;
    
    private static readonly string RO_CODCAMPLOMADEE = "Codcamplomadee";
    private string? _codcamplomadee;
    
    private static readonly string RO_CODADWORDS = "Codadwords";
    private string? _codadwords;
    
    private static readonly string RO_ATIVO = "Ativo";
    private string? _ativo;
    
    private static readonly string RO_DESCRICAOECOMMERCE = "Descricaoecommerce";
    private string? _descricaoecommerce;
    
    private static readonly string RO_TITULO = "Titulo";
    private string? _titulo;
    
    private static readonly string RO_CODDEPTOPRINC = "Coddeptoprinc";
    private int? _coddeptoprinc;
    
    private static readonly string RO_DTCADASTRO = "Dtcadastro";
    private DateTime? _dtcadastro;
    

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int Codepto
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
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string Descricao
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAO);
            return _descricao;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAO, value);
            _descricao = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percpartvendaprev
    {
        get
        {
            PropriedadeAcessada(RO_PERCPARTVENDAPREV);
            return _percpartvendaprev;
        }
        set
        {
            PropriedadeModificada(RO_PERCPARTVENDAPREV, value);
            _percpartvendaprev = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percmargemprev
    {
        get
        {
            PropriedadeAcessada(RO_PERCMARGEMPREV);
            return _percmargemprev;
        }
        set
        {
            PropriedadeModificada(RO_PERCMARGEMPREV, value);
            _percmargemprev = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Tipomerc
    {
        get
        {
            PropriedadeAcessada(RO_TIPOMERC);
            return _tipomerc;
        }
        set
        {
            PropriedadeModificada(RO_TIPOMERC, value);
            _tipomerc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Emiteqtunit
    {
        get
        {
            PropriedadeAcessada(RO_EMITEQTUNIT);
            return _emiteqtunit;
        }
        set
        {
            PropriedadeModificada(RO_EMITEQTUNIT, value);
            _emiteqtunit = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Atualizainvgeral
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAINVGERAL);
            return _atualizainvgeral;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAINVGERAL, value);
            _atualizainvgeral = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margemprevista
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMPREVISTA);
            return _margemprevista;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMPREVISTA, value);
            _margemprevista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Referencia
    {
        get
        {
            PropriedadeAcessada(RO_REFERENCIA);
            return _referencia;
        }
        set
        {
            PropriedadeModificada(RO_REFERENCIA, value);
            _referencia = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxideal
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXIDEAL);
            return _perdescmaxideal;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXIDEAL, value);
            _perdescmaxideal = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxpossivel
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXPOSSIVEL);
            return _perdescmaxpossivel;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXPOSSIVEL, value);
            _perdescmaxpossivel = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxavista
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXAVISTA);
            return _perdescmaxavista;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXAVISTA, value);
            _perdescmaxavista = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perccomgarantida
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMGARANTIDA);
            return _perccomgarantida;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMGARANTIDA, value);
            _perccomgarantida = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Idintegracaociashop
    {
        get
        {
            PropriedadeAcessada(RO_IDINTEGRACAOCIASHOP);
            return _idintegracaociashop;
        }
        set
        {
            PropriedadeModificada(RO_IDINTEGRACAOCIASHOP, value);
            _idintegracaociashop = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Enviaecommerce
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAECOMMERCE);
            return _enviaecommerce;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAECOMMERCE, value);
            _enviaecommerce = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTER);
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTER, value);
            _dtultalter = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codcamplomadee
    {
        get
        {
            PropriedadeAcessada(RO_CODCAMPLOMADEE);
            return _codcamplomadee;
        }
        set
        {
            PropriedadeModificada(RO_CODCAMPLOMADEE, value);
            _codcamplomadee = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Codadwords
    {
        get
        {
            PropriedadeAcessada(RO_CODADWORDS);
            return _codadwords;
        }
        set
        {
            PropriedadeModificada(RO_CODADWORDS, value);
            _codadwords = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Ativo
    {
        get
        {
            PropriedadeAcessada(RO_ATIVO);
            return _ativo;
        }
        set
        {
            PropriedadeModificada(RO_ATIVO, value);
            _ativo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Descricaoecommerce
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAOECOMMERCE);
            return _descricaoecommerce;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAOECOMMERCE, value);
            _descricaoecommerce = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 0, Precisao = 0)]
    public string? Titulo
    {
        get
        {
            PropriedadeAcessada(RO_TITULO);
            return _titulo;
        }
        set
        {
            PropriedadeModificada(RO_TITULO, value);
            _titulo = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 6, Precisao = 0)]
    public int? Coddeptoprinc
    {
        get
        {
            PropriedadeAcessada(RO_CODDEPTOPRINC);
            return _coddeptoprinc;
        }
        set
        {
            PropriedadeModificada(RO_CODDEPTOPRINC, value);
            _coddeptoprinc = value;
        }
    }
    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDEPTO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 0, Precisao = 0)]
    public DateTime? Dtcadastro
    {
        get
        {
            PropriedadeAcessada(RO_DTCADASTRO);
            return _dtcadastro;
        }
        set
        {
            PropriedadeModificada(RO_DTCADASTRO, value);
            _dtcadastro = value;
        }
    }

    public void InicializarAtributos() { }

    public string ObterNomeTabela() => "PCDEPTO";

    public IEntidade NovaInstancia() => (IEntidade)GetType().GetConstructors()[0].Invoke(null);

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codepto = AlterarTipo<int>(leitor["Codepto"]);
        _descricao = AlterarTipo<string>(leitor["Descricao"]);
        _percpartvendaprev = AlterarTipo<decimal?>(leitor["Percpartvendaprev"]);
        _percmargemprev = AlterarTipo<decimal?>(leitor["Percmargemprev"]);
        _tipomerc = AlterarTipo<string?>(leitor["Tipomerc"]);
        _emiteqtunit = AlterarTipo<string?>(leitor["Emiteqtunit"]);
        _atualizainvgeral = AlterarTipo<string?>(leitor["Atualizainvgeral"]);
        _margemprevista = AlterarTipo<decimal?>(leitor["Margemprevista"]);
        _referencia = AlterarTipo<string?>(leitor["Referencia"]);
        _perdescmaxideal = AlterarTipo<decimal?>(leitor["Perdescmaxideal"]);
        _perdescmaxpossivel = AlterarTipo<decimal?>(leitor["Perdescmaxpossivel"]);
        _perdescmaxavista = AlterarTipo<decimal?>(leitor["Perdescmaxavista"]);
        _perccomgarantida = AlterarTipo<decimal?>(leitor["Perccomgarantida"]);
        _idintegracaociashop = AlterarTipo<string?>(leitor["Idintegracaociashop"]);
        _enviaecommerce = AlterarTipo<string?>(leitor["Enviaecommerce"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _codcamplomadee = AlterarTipo<string?>(leitor["Codcamplomadee"]);
        _codadwords = AlterarTipo<string?>(leitor["Codadwords"]);
        _ativo = AlterarTipo<string?>(leitor["Ativo"]);
        _descricaoecommerce = AlterarTipo<string?>(leitor["Descricaoecommerce"]);
        _titulo = AlterarTipo<string?>(leitor["Titulo"]);
        _coddeptoprinc = AlterarTipo<int?>(leitor["Coddeptoprinc"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
    }
}