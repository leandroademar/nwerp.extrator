

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCHEQUEPROPRIO : GerenteDePropriedades, IEntidade
{
    private decimal? _codcli;

    private DateTime? _dtcadastro;

    private DateTime? _dtimpresso;

    private DateTime? _dtsustado;

    private DateTime? _dtutilizado;

    private string _imprterceiro;

    private decimal _numcheque;

    private decimal? _numtalao;

    private decimal? _numtransvenda;

    private string _observacao;

    private string _status;

    private decimal? _usucadastro;

    private decimal? _usuimpresso;

    private decimal? _ususustado;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada("Codcli");
            return _codcli;
        }
        set
        {
            PropriedadeModificada("Codcli", value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcadastro
    {
        get
        {
            PropriedadeAcessada("Dtcadastro");
            return _dtcadastro;
        }
        set
        {
            PropriedadeModificada("Dtcadastro", value);
            _dtcadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimpresso
    {
        get
        {
            PropriedadeAcessada("Dtimpresso");
            return _dtimpresso;
        }
        set
        {
            PropriedadeModificada("Dtimpresso", value);
            _dtimpresso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsustado
    {
        get
        {
            PropriedadeAcessada("Dtsustado");
            return _dtsustado;
        }
        set
        {
            PropriedadeModificada("Dtsustado", value);
            _dtsustado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtutilizado
    {
        get
        {
            PropriedadeAcessada("Dtutilizado");
            return _dtutilizado;
        }
        set
        {
            PropriedadeModificada("Dtutilizado", value);
            _dtutilizado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprterceiro
    {
        get
        {
            PropriedadeAcessada("Imprterceiro");
            return _imprterceiro;
        }
        set
        {
            PropriedadeModificada("Imprterceiro", value);
            _imprterceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numcheque
    {
        get
        {
            PropriedadeAcessada("Numcheque");
            return _numcheque;
        }
        set
        {
            PropriedadeModificada("Numcheque", value);
            _numcheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtalao
    {
        get
        {
            PropriedadeAcessada("Numtalao");
            return _numtalao;
        }
        set
        {
            PropriedadeModificada("Numtalao", value);
            _numtalao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvenda
    {
        get
        {
            PropriedadeAcessada("Numtransvenda");
            return _numtransvenda;
        }
        set
        {
            PropriedadeModificada("Numtransvenda", value);
            _numtransvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 500, Precisao = 0)]
    public string Observacao
    {
        get
        {
            PropriedadeAcessada("Observacao");
            return _observacao;
        }
        set
        {
            PropriedadeModificada("Observacao", value);
            _observacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Status
    {
        get
        {
            PropriedadeAcessada("Status");
            return _status;
        }
        set
        {
            PropriedadeModificada("Status", value);
            _status = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Usucadastro
    {
        get
        {
            PropriedadeAcessada("Usucadastro");
            return _usucadastro;
        }
        set
        {
            PropriedadeModificada("Usucadastro", value);
            _usucadastro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Usuimpresso
    {
        get
        {
            PropriedadeAcessada("Usuimpresso");
            return _usuimpresso;
        }
        set
        {
            PropriedadeModificada("Usuimpresso", value);
            _usuimpresso = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHEQUEPROPRIO", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Ususustado
    {
        get
        {
            PropriedadeAcessada("Ususustado");
            return _ususustado;
        }
        set
        {
            PropriedadeModificada("Ususustado", value);
            _ususustado = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCHEQUEPROPRIO";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _dtcadastro = AlterarTipo<DateTime?>(leitor["Dtcadastro"]);
        _dtimpresso = AlterarTipo<DateTime?>(leitor["Dtimpresso"]);
        _dtsustado = AlterarTipo<DateTime?>(leitor["Dtsustado"]);
        _dtutilizado = AlterarTipo<DateTime?>(leitor["Dtutilizado"]);
        _imprterceiro = AlterarTipo<string>(leitor["Imprterceiro"]);
        _numcheque = AlterarTipo<decimal>(leitor["Numcheque"]);
        _numtalao = AlterarTipo<decimal?>(leitor["Numtalao"]);
        _numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
        _observacao = AlterarTipo<string>(leitor["Observacao"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _usucadastro = AlterarTipo<decimal?>(leitor["Usucadastro"]);
        _usuimpresso = AlterarTipo<decimal?>(leitor["Usuimpresso"]);
        _ususustado = AlterarTipo<decimal?>(leitor["Ususustado"]);
    }

}