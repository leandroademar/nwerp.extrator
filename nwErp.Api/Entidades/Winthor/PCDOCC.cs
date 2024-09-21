

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCDOCC : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_CODDOC = "Coddoc";

    private decimal? _coddoc;

    private static readonly string RO_CODFISCAL = "Codfiscal";

    private string _codfiscal;

    private static readonly string RO_ESPACAMENTO = "Espacamento";

    private string _espacamento;

    private static readonly string RO_IMPRESSORA = "Impressora";

    private string _impressora;

    private static readonly string RO_LETRA = "Letra";

    private string _letra;

    private static readonly string RO_NUMLINHAS = "Numlinhas";

    private decimal? _numlinhas;

    private static readonly string RO_OPERACAO = "Operacao";

    private string _operacao;

    private static readonly string RO_QTMAXITENS = "Qtmaxitens";

    private decimal? _qtmaxitens;

    private static readonly string RO_SERIE = "Serie";

    private string _serie;

    private static readonly string RO_TIPODOC = "Tipodoc";

    private string _tipodoc;

    private static readonly string RO_TIPOPRECO = "Tipopreco";

    private string _tipopreco;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Coddoc
    {
        get
        {
            PropriedadeAcessada(RO_CODDOC);
            return _coddoc;
        }
        set
        {
            PropriedadeModificada(RO_CODDOC, value);
            _coddoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codfiscal
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Espacamento
    {
        get
        {
            PropriedadeAcessada(RO_ESPACAMENTO);
            return _espacamento;
        }
        set
        {
            PropriedadeModificada(RO_ESPACAMENTO, value);
            _espacamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Impressora
    {
        get
        {
            PropriedadeAcessada(RO_IMPRESSORA);
            return _impressora;
        }
        set
        {
            PropriedadeModificada(RO_IMPRESSORA, value);
            _impressora = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Letra
    {
        get
        {
            PropriedadeAcessada(RO_LETRA);
            return _letra;
        }
        set
        {
            PropriedadeModificada(RO_LETRA, value);
            _letra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numlinhas
    {
        get
        {
            PropriedadeAcessada(RO_NUMLINHAS);
            return _numlinhas;
        }
        set
        {
            PropriedadeModificada(RO_NUMLINHAS, value);
            _numlinhas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Operacao
    {
        get
        {
            PropriedadeAcessada(RO_OPERACAO);
            return _operacao;
        }
        set
        {
            PropriedadeModificada(RO_OPERACAO, value);
            _operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Qtmaxitens
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXITENS);
            return _qtmaxitens;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXITENS, value);
            _qtmaxitens = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Serie
    {
        get
        {
            PropriedadeAcessada(RO_SERIE);
            return _serie;
        }
        set
        {
            PropriedadeModificada(RO_SERIE, value);
            _serie = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Tipodoc
    {
        get
        {
            PropriedadeAcessada(RO_TIPODOC);
            return _tipodoc;
        }
        set
        {
            PropriedadeModificada(RO_TIPODOC, value);
            _tipodoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCDOCC", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopreco
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRECO);
            return _tipopreco;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRECO, value);
            _tipopreco = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCDOCC";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _coddoc = AlterarTipo<decimal?>(leitor["Coddoc"]);
        _codfiscal = AlterarTipo<string>(leitor["Codfiscal"]);
        _espacamento = AlterarTipo<string>(leitor["Espacamento"]);
        _impressora = AlterarTipo<string>(leitor["Impressora"]);
        _letra = AlterarTipo<string>(leitor["Letra"]);
        _numlinhas = AlterarTipo<decimal?>(leitor["Numlinhas"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _qtmaxitens = AlterarTipo<decimal?>(leitor["Qtmaxitens"]);
        _serie = AlterarTipo<string>(leitor["Serie"]);
        _tipodoc = AlterarTipo<string>(leitor["Tipodoc"]);
        _tipopreco = AlterarTipo<string>(leitor["Tipopreco"]);
    }

}