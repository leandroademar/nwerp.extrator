

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCCHECKOUT_VOUCHER_MOTOR : GerenteDePropriedades, IEntidade
{
    private string _campaignid;

    private DateTime? _creationdate;

    private DateTime? _expirationdate;

    private DateTime? _lastupdate;

    private string _numerocaixa;

    private string _numtransvenda;

    private decimal? _percentagediscount;

    private string _productid;

    private string _taxid;

    private DateTime? _usedate;

    private string _vouchercode;

    private string _voucherid;

    private string _voucherstatus;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Campaignid
    {
        get
        {
            PropriedadeAcessada("Campaignid");
            return _campaignid;
        }
        set
        {
            PropriedadeModificada("Campaignid", value);
            _campaignid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Creationdate
    {
        get
        {
            PropriedadeAcessada("Creationdate");
            return _creationdate;
        }
        set
        {
            PropriedadeModificada("Creationdate", value);
            _creationdate = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Expirationdate
    {
        get
        {
            PropriedadeAcessada("Expirationdate");
            return _expirationdate;
        }
        set
        {
            PropriedadeModificada("Expirationdate", value);
            _expirationdate = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Lastupdate
    {
        get
        {
            PropriedadeAcessada("Lastupdate");
            return _lastupdate;
        }
        set
        {
            PropriedadeModificada("Lastupdate", value);
            _lastupdate = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Numerocaixa
    {
        get
        {
            PropriedadeAcessada("Numerocaixa");
            return _numerocaixa;
        }
        set
        {
            PropriedadeModificada("Numerocaixa", value);
            _numerocaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numtransvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percentagediscount
    {
        get
        {
            PropriedadeAcessada("Percentagediscount");
            return _percentagediscount;
        }
        set
        {
            PropriedadeModificada("Percentagediscount", value);
            _percentagediscount = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Productid
    {
        get
        {
            PropriedadeAcessada("Productid");
            return _productid;
        }
        set
        {
            PropriedadeModificada("Productid", value);
            _productid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Taxid
    {
        get
        {
            PropriedadeAcessada("Taxid");
            return _taxid;
        }
        set
        {
            PropriedadeModificada("Taxid", value);
            _taxid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Usedate
    {
        get
        {
            PropriedadeAcessada("Usedate");
            return _usedate;
        }
        set
        {
            PropriedadeModificada("Usedate", value);
            _usedate = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Vouchercode
    {
        get
        {
            PropriedadeAcessada("Vouchercode");
            return _vouchercode;
        }
        set
        {
            PropriedadeModificada("Vouchercode", value);
            _vouchercode = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Voucherid
    {
        get
        {
            PropriedadeAcessada("Voucherid");
            return _voucherid;
        }
        set
        {
            PropriedadeModificada("Voucherid", value);
            _voucherid = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCHECKOUT_VOUCHER_MOTOR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Voucherstatus
    {
        get
        {
            PropriedadeAcessada("Voucherstatus");
            return _voucherstatus;
        }
        set
        {
            PropriedadeModificada("Voucherstatus", value);
            _voucherstatus = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCHECKOUT_VOUCHER_MOTOR";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _campaignid = AlterarTipo<string>(leitor["Campaignid"]);
        _creationdate = AlterarTipo<DateTime?>(leitor["Creationdate"]);
        _expirationdate = AlterarTipo<DateTime?>(leitor["Expirationdate"]);
        _lastupdate = AlterarTipo<DateTime?>(leitor["Lastupdate"]);
        _numerocaixa = AlterarTipo<string>(leitor["Numerocaixa"]);
        _numtransvenda = AlterarTipo<string>(leitor["Numtransvenda"]);
        _percentagediscount = AlterarTipo<decimal?>(leitor["Percentagediscount"]);
        _productid = AlterarTipo<string>(leitor["Productid"]);
        _taxid = AlterarTipo<string>(leitor["Taxid"]);
        _usedate = AlterarTipo<DateTime?>(leitor["Usedate"]);
        _vouchercode = AlterarTipo<string>(leitor["Vouchercode"]);
        _voucherid = AlterarTipo<string>(leitor["Voucherid"]);
        _voucherstatus = AlterarTipo<string>(leitor["Voucherstatus"]);
    }

}