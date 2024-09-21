

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCCOB : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ACERTOAUTOCXMOT = "Acertoautocxmot";

    private string _acertoautocxmot;

    private static readonly string RO_AUTENTICARACERTOCX402 = "Autenticaracertocx402";

    private string _autenticaracertocx402;

    private static readonly string RO_BAIXACXBANCO = "Baixacxbanco";

    private string _baixacxbanco;

    private static readonly string RO_BLOQAUTOMATICO = "Bloqautomatico";

    private string _bloqautomatico;

    private static readonly string RO_BOLETO = "Boleto";

    private string _boleto;

    private static readonly string RO_CALCJUROSCOBRANCA = "Calcjuroscobranca";

    private string _calcjuroscobranca;

    private static readonly string RO_CARTAO = "Cartao";

    private string _cartao;

    private static readonly string RO_COBRANCA = "Cobranca";

    private string _cobranca;

    private static readonly string RO_COBRANCABROKER = "Cobrancabroker";

    private string _cobrancabroker;

    private static readonly string RO_COBRANCAEMTRANSITO = "Cobrancaemtransito";

    private string _cobrancaemtransito;

    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal? _codbanco;

    private static readonly string RO_CODBANCOTARIFA = "Codbancotarifa";

    private decimal? _codbancotarifa;

    private static readonly string RO_CODBANDEIRA = "Codbandeira";

    private decimal? _codbandeira;

    private static readonly string RO_CODCLICC = "Codclicc";

    private decimal? _codclicc;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCOBCC = "Codcobcc";

    private string _codcobcc;

    private static readonly string RO_CODCOBCHDESC = "Codcobchdesc";

    private string _codcobchdesc;

    private static readonly string RO_CODCOBDEVCHDESC = "Codcobdevchdesc";

    private string _codcobdevchdesc;

    private static readonly string RO_CODCONTACC = "Codcontacc";

    private decimal? _codcontacc;

    private static readonly string RO_CODECF = "Codecf";

    private string _codecf;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODIGOBANDEIRA = "Codigobandeira";

    private string _codigobandeira;

    private static readonly string RO_CODMOEDA = "Codmoeda";

    private string _codmoeda;

    private static readonly string RO_CODOPERADORACARTAO = "Codoperadoracartao";

    private string _codoperadoracartao;

    private static readonly string RO_CODPARANAOPROTESTO = "Codparanaoprotesto";

    private string _codparanaoprotesto;

    private static readonly string RO_CODPARAPROTESTO = "Codparaprotesto";

    private string _codparaprotesto;

    private static readonly string RO_COLUNAFLUXOCX = "Colunafluxocx";

    private decimal? _colunafluxocx;

    private static readonly string RO_CUSTODIA = "Custodia";

    private string _custodia;

    private static readonly string RO_DEPOSITOBANCARIO = "Depositobancario";

    private string _depositobancario;

    private static readonly string RO_DIASCARENCIA = "Diascarencia";

    private decimal? _diascarencia;

    private static readonly string RO_ENVIACOBRANCAFV = "Enviacobrancafv";

    private string _enviacobrancafv;

    private static readonly string RO_ENVIOPARAPROTESTO = "Envioparaprotesto";

    private string _envioparaprotesto;

    private static readonly string RO_EXIBIRBK = "Exibirbk";

    private string _exibirbk;

    private static readonly string RO_EXIBIRCXMOT = "Exibircxmot";

    private string _exibircxmot;

    private static readonly string RO_EXPORTARECF = "Exportarecf";

    private string _exportarecf;

    private static readonly string RO_FLUXOCX = "Fluxocx";

    private string _fluxocx;

    private static readonly string RO_LETRACOB = "Letracob";

    private string _letracob;

    private static readonly string RO_NIVELVENDA = "Nivelvenda";

    private decimal? _nivelvenda;

    private static readonly string RO_NUMBANCO = "Numbanco";

    private decimal? _numbanco;

    private static readonly string RO_NUMDIASBLOQAUTOMATIC = "Numdiasbloqautomatic";

    private decimal? _numdiasbloqautomatic;

    private static readonly string RO_NUMDIASLIBERACAOCREDITO = "Numdiasliberacaocredito";

    private decimal? _numdiasliberacaocredito;

    private static readonly string RO_NUMDIASPROTESTO = "Numdiasprotesto";

    private string _numdiasprotesto;

    private static readonly string RO_NUMDIASVENCFLUXOCX = "Numdiasvencfluxocx";

    private decimal? _numdiasvencfluxocx;

    private static readonly string RO_NUMMAXPARCELAS = "Nummaxparcelas";

    private decimal? _nummaxparcelas;

    private static readonly string RO_NUMVIASCPADICIONAL = "Numviascpadicional";

    private string _numviascpadicional;

    private static readonly string RO_OBSNF = "Obsnf";

    private string _obsnf;

    private static readonly string RO_PAGCOMISSAO = "Pagcomissao";

    private string _pagcomissao;

    private static readonly string RO_PERCACRESVENDA = "Percacresvenda";

    private decimal? _percacresvenda;

    private static readonly string RO_PERCOM = "Percom";

    private decimal? _percom;

    private static readonly string RO_PERCOMMOT = "Percommot";

    private decimal? _percommot;

    private static readonly string RO_PERCTXADMINCC = "Perctxadmincc";

    private decimal? _perctxadmincc;

    private static readonly string RO_PERMITEALTCOBDESD = "Permitealtcobdesd";

    private string _permitealtcobdesd;

    private static readonly string RO_PERMITEBAIXAMANUAL = "Permitebaixamanual";

    private string _permitebaixamanual;

    private static readonly string RO_PERMITECONTRAVALE = "Permitecontravale";

    private string _permitecontravale;

    private static readonly string RO_PERMITEDESCDEVCLI = "Permitedescdevcli";

    private string _permitedescdevcli;

    private static readonly string RO_PRAZOCC = "Prazocc";

    private decimal? _prazocc;

    private static readonly string RO_PRAZOMAXIMOVENDA = "Prazomaximovenda";

    private decimal? _prazomaximovenda;

    private static readonly string RO_SELECIONACLIENTEECF = "Selecionaclienteecf";

    private string _selecionaclienteecf;

    private static readonly string RO_SOMATARIFABANCDUPLIC = "Somatarifabancduplic";

    private string _somatarifabancduplic;

    private static readonly string RO_SOMATARIFABANCNF = "Somatarifabancnf";

    private string _somatarifabancnf;

    private static readonly string RO_TIPOCOMISSAO = "Tipocomissao";

    private string _tipocomissao;

    private static readonly string RO_TIPOOPERACAOTEF = "Tipooperacaotef";

    private string _tipooperacaotef;

    private static readonly string RO_TIPOPAGTOECF = "Tipopagtoecf";

    private string _tipopagtoecf;

    private static readonly string RO_TXJUROS = "Txjuros";

    private decimal? _txjuros;

    private static readonly string RO_UTILIZACHDESC = "Utilizachdesc";

    private string _utilizachdesc;

    private static readonly string RO_VALIDALIMCREDECF = "Validalimcredecf";

    private string _validalimcredecf;

    private static readonly string RO_VLMINPEDIDO = "Vlminpedido";

    private decimal? _vlminpedido;

    private static readonly string RO_VLTARIFA = "Vltarifa";

    private decimal? _vltarifa;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Acertoautocxmot
    {
        get
        {
            PropriedadeAcessada(RO_ACERTOAUTOCXMOT);
            return _acertoautocxmot;
        }
        set
        {
            PropriedadeModificada(RO_ACERTOAUTOCXMOT, value);
            _acertoautocxmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Autenticaracertocx402
    {
        get
        {
            PropriedadeAcessada(RO_AUTENTICARACERTOCX402);
            return _autenticaracertocx402;
        }
        set
        {
            PropriedadeModificada(RO_AUTENTICARACERTOCX402, value);
            _autenticaracertocx402 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixacxbanco
    {
        get
        {
            PropriedadeAcessada(RO_BAIXACXBANCO);
            return _baixacxbanco;
        }
        set
        {
            PropriedadeModificada(RO_BAIXACXBANCO, value);
            _baixacxbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqautomatico
    {
        get
        {
            PropriedadeAcessada(RO_BLOQAUTOMATICO);
            return _bloqautomatico;
        }
        set
        {
            PropriedadeModificada(RO_BLOQAUTOMATICO, value);
            _bloqautomatico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Boleto
    {
        get
        {
            PropriedadeAcessada(RO_BOLETO);
            return _boleto;
        }
        set
        {
            PropriedadeModificada(RO_BOLETO, value);
            _boleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Calcjuroscobranca
    {
        get
        {
            PropriedadeAcessada(RO_CALCJUROSCOBRANCA);
            return _calcjuroscobranca;
        }
        set
        {
            PropriedadeModificada(RO_CALCJUROSCOBRANCA, value);
            _calcjuroscobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cartao
    {
        get
        {
            PropriedadeAcessada(RO_CARTAO);
            return _cartao;
        }
        set
        {
            PropriedadeModificada(RO_CARTAO, value);
            _cartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Cobranca
    {
        get
        {
            PropriedadeAcessada(RO_COBRANCA);
            return _cobranca;
        }
        set
        {
            PropriedadeModificada(RO_COBRANCA, value);
            _cobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cobrancabroker
    {
        get
        {
            PropriedadeAcessada(RO_COBRANCABROKER);
            return _cobrancabroker;
        }
        set
        {
            PropriedadeModificada(RO_COBRANCABROKER, value);
            _cobrancabroker = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cobrancaemtransito
    {
        get
        {
            PropriedadeAcessada(RO_COBRANCAEMTRANSITO);
            return _cobrancaemtransito;
        }
        set
        {
            PropriedadeModificada(RO_COBRANCAEMTRANSITO, value);
            _cobrancaemtransito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCO);
            return _codbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCO, value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancotarifa
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOTARIFA);
            return _codbancotarifa;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOTARIFA, value);
            _codbancotarifa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbandeira
    {
        get
        {
            PropriedadeAcessada(RO_CODBANDEIRA);
            return _codbandeira;
        }
        set
        {
            PropriedadeModificada(RO_CODBANDEIRA, value);
            _codbandeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclicc
    {
        get
        {
            PropriedadeAcessada(RO_CODCLICC);
            return _codclicc;
        }
        set
        {
            PropriedadeModificada(RO_CODCLICC, value);
            _codclicc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada(RO_CODCOB);
            return _codcob;
        }
        set
        {
            PropriedadeModificada(RO_CODCOB, value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobcc
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBCC);
            return _codcobcc;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBCC, value);
            _codcobcc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobchdesc
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBCHDESC);
            return _codcobchdesc;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBCHDESC, value);
            _codcobchdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobdevchdesc
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBDEVCHDESC);
            return _codcobdevchdesc;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBDEVCHDESC, value);
            _codcobdevchdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacc
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACC);
            return _codcontacc;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACC, value);
            _codcontacc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codecf
    {
        get
        {
            PropriedadeAcessada(RO_CODECF);
            return _codecf;
        }
        set
        {
            PropriedadeModificada(RO_CODECF, value);
            _codecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codigobandeira
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOBANDEIRA);
            return _codigobandeira;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOBANDEIRA, value);
            _codigobandeira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codmoeda
    {
        get
        {
            PropriedadeAcessada(RO_CODMOEDA);
            return _codmoeda;
        }
        set
        {
            PropriedadeModificada(RO_CODMOEDA, value);
            _codmoeda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codoperadoracartao
    {
        get
        {
            PropriedadeAcessada(RO_CODOPERADORACARTAO);
            return _codoperadoracartao;
        }
        set
        {
            PropriedadeModificada(RO_CODOPERADORACARTAO, value);
            _codoperadoracartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codparanaoprotesto
    {
        get
        {
            PropriedadeAcessada(RO_CODPARANAOPROTESTO);
            return _codparanaoprotesto;
        }
        set
        {
            PropriedadeModificada(RO_CODPARANAOPROTESTO, value);
            _codparanaoprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codparaprotesto
    {
        get
        {
            PropriedadeAcessada(RO_CODPARAPROTESTO);
            return _codparaprotesto;
        }
        set
        {
            PropriedadeModificada(RO_CODPARAPROTESTO, value);
            _codparaprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Colunafluxocx
    {
        get
        {
            PropriedadeAcessada(RO_COLUNAFLUXOCX);
            return _colunafluxocx;
        }
        set
        {
            PropriedadeModificada(RO_COLUNAFLUXOCX, value);
            _colunafluxocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Custodia
    {
        get
        {
            PropriedadeAcessada(RO_CUSTODIA);
            return _custodia;
        }
        set
        {
            PropriedadeModificada(RO_CUSTODIA, value);
            _custodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Depositobancario
    {
        get
        {
            PropriedadeAcessada(RO_DEPOSITOBANCARIO);
            return _depositobancario;
        }
        set
        {
            PropriedadeModificada(RO_DEPOSITOBANCARIO, value);
            _depositobancario = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Diascarencia
    {
        get
        {
            PropriedadeAcessada(RO_DIASCARENCIA);
            return _diascarencia;
        }
        set
        {
            PropriedadeModificada(RO_DIASCARENCIA, value);
            _diascarencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviacobrancafv
    {
        get
        {
            PropriedadeAcessada(RO_ENVIACOBRANCAFV);
            return _enviacobrancafv;
        }
        set
        {
            PropriedadeModificada(RO_ENVIACOBRANCAFV, value);
            _enviacobrancafv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Envioparaprotesto
    {
        get
        {
            PropriedadeAcessada(RO_ENVIOPARAPROTESTO);
            return _envioparaprotesto;
        }
        set
        {
            PropriedadeModificada(RO_ENVIOPARAPROTESTO, value);
            _envioparaprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibirbk
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRBK);
            return _exibirbk;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRBK, value);
            _exibirbk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exibircxmot
    {
        get
        {
            PropriedadeAcessada(RO_EXIBIRCXMOT);
            return _exibircxmot;
        }
        set
        {
            PropriedadeModificada(RO_EXIBIRCXMOT, value);
            _exibircxmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportarecf
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTARECF);
            return _exportarecf;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTARECF, value);
            _exportarecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Fluxocx
    {
        get
        {
            PropriedadeAcessada(RO_FLUXOCX);
            return _fluxocx;
        }
        set
        {
            PropriedadeModificada(RO_FLUXOCX, value);
            _fluxocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Letracob
    {
        get
        {
            PropriedadeAcessada(RO_LETRACOB);
            return _letracob;
        }
        set
        {
            PropriedadeModificada(RO_LETRACOB, value);
            _letracob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Nivelvenda
    {
        get
        {
            PropriedadeAcessada(RO_NIVELVENDA);
            return _nivelvenda;
        }
        set
        {
            PropriedadeModificada(RO_NIVELVENDA, value);
            _nivelvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numbanco
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCO);
            return _numbanco;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCO, value);
            _numbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasbloqautomatic
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASBLOQAUTOMATIC);
            return _numdiasbloqautomatic;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASBLOQAUTOMATIC, value);
            _numdiasbloqautomatic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasliberacaocredito
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASLIBERACAOCREDITO);
            return _numdiasliberacaocredito;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASLIBERACAOCREDITO, value);
            _numdiasliberacaocredito = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Numdiasprotesto
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASPROTESTO);
            return _numdiasprotesto;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASPROTESTO, value);
            _numdiasprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdiasvencfluxocx
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASVENCFLUXOCX);
            return _numdiasvencfluxocx;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASVENCFLUXOCX, value);
            _numdiasvencfluxocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Nummaxparcelas
    {
        get
        {
            PropriedadeAcessada(RO_NUMMAXPARCELAS);
            return _nummaxparcelas;
        }
        set
        {
            PropriedadeModificada(RO_NUMMAXPARCELAS, value);
            _nummaxparcelas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Numviascpadicional
    {
        get
        {
            PropriedadeAcessada(RO_NUMVIASCPADICIONAL);
            return _numviascpadicional;
        }
        set
        {
            PropriedadeModificada(RO_NUMVIASCPADICIONAL, value);
            _numviascpadicional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obsnf
    {
        get
        {
            PropriedadeAcessada(RO_OBSNF);
            return _obsnf;
        }
        set
        {
            PropriedadeModificada(RO_OBSNF, value);
            _obsnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Pagcomissao
    {
        get
        {
            PropriedadeAcessada(RO_PAGCOMISSAO);
            return _pagcomissao;
        }
        set
        {
            PropriedadeModificada(RO_PAGCOMISSAO, value);
            _pagcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percacresvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESVENDA);
            return _percacresvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESVENDA, value);
            _percacresvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percommot
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMMOT);
            return _percommot;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMMOT, value);
            _percommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perctxadmincc
    {
        get
        {
            PropriedadeAcessada(RO_PERCTXADMINCC);
            return _perctxadmincc;
        }
        set
        {
            PropriedadeModificada(RO_PERCTXADMINCC, value);
            _perctxadmincc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitealtcobdesd
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEALTCOBDESD);
            return _permitealtcobdesd;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEALTCOBDESD, value);
            _permitealtcobdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitebaixamanual
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEBAIXAMANUAL);
            return _permitebaixamanual;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEBAIXAMANUAL, value);
            _permitebaixamanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitecontravale
    {
        get
        {
            PropriedadeAcessada(RO_PERMITECONTRAVALE);
            return _permitecontravale;
        }
        set
        {
            PropriedadeModificada(RO_PERMITECONTRAVALE, value);
            _permitecontravale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitedescdevcli
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEDESCDEVCLI);
            return _permitedescdevcli;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEDESCDEVCLI, value);
            _permitedescdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazocc
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOCC);
            return _prazocc;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOCC, value);
            _prazocc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazomaximovenda
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOMAXIMOVENDA);
            return _prazomaximovenda;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOMAXIMOVENDA, value);
            _prazomaximovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Selecionaclienteecf
    {
        get
        {
            PropriedadeAcessada(RO_SELECIONACLIENTEECF);
            return _selecionaclienteecf;
        }
        set
        {
            PropriedadeModificada(RO_SELECIONACLIENTEECF, value);
            _selecionaclienteecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatarifabancduplic
    {
        get
        {
            PropriedadeAcessada(RO_SOMATARIFABANCDUPLIC);
            return _somatarifabancduplic;
        }
        set
        {
            PropriedadeModificada(RO_SOMATARIFABANCDUPLIC, value);
            _somatarifabancduplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatarifabancnf
    {
        get
        {
            PropriedadeAcessada(RO_SOMATARIFABANCNF);
            return _somatarifabancnf;
        }
        set
        {
            PropriedadeModificada(RO_SOMATARIFABANCNF, value);
            _somatarifabancnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipooperacaotef
    {
        get
        {
            PropriedadeAcessada(RO_TIPOOPERACAOTEF);
            return _tipooperacaotef;
        }
        set
        {
            PropriedadeModificada(RO_TIPOOPERACAOTEF, value);
            _tipooperacaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopagtoecf
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPAGTOECF);
            return _tipopagtoecf;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPAGTOECF, value);
            _tipopagtoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Txjuros
    {
        get
        {
            PropriedadeAcessada(RO_TXJUROS);
            return _txjuros;
        }
        set
        {
            PropriedadeModificada(RO_TXJUROS, value);
            _txjuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Utilizachdesc
    {
        get
        {
            PropriedadeAcessada(RO_UTILIZACHDESC);
            return _utilizachdesc;
        }
        set
        {
            PropriedadeModificada(RO_UTILIZACHDESC, value);
            _utilizachdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validalimcredecf
    {
        get
        {
            PropriedadeAcessada(RO_VALIDALIMCREDECF);
            return _validalimcredecf;
        }
        set
        {
            PropriedadeModificada(RO_VALIDALIMCREDECF, value);
            _validalimcredecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlminpedido
    {
        get
        {
            PropriedadeAcessada(RO_VLMINPEDIDO);
            return _vlminpedido;
        }
        set
        {
            PropriedadeModificada(RO_VLMINPEDIDO, value);
            _vlminpedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCCOB", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vltarifa
    {
        get
        {
            PropriedadeAcessada(RO_VLTARIFA);
            return _vltarifa;
        }
        set
        {
            PropriedadeModificada(RO_VLTARIFA, value);
            _vltarifa = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCCOB";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _acertoautocxmot = AlterarTipo<string>(leitor["Acertoautocxmot"]);
        _autenticaracertocx402 = AlterarTipo<string>(leitor["Autenticaracertocx402"]);
        _baixacxbanco = AlterarTipo<string>(leitor["Baixacxbanco"]);
        _bloqautomatico = AlterarTipo<string>(leitor["Bloqautomatico"]);
        _boleto = AlterarTipo<string>(leitor["Boleto"]);
        _calcjuroscobranca = AlterarTipo<string>(leitor["Calcjuroscobranca"]);
        _cartao = AlterarTipo<string>(leitor["Cartao"]);
        _cobranca = AlterarTipo<string>(leitor["Cobranca"]);
        _cobrancabroker = AlterarTipo<string>(leitor["Cobrancabroker"]);
        _cobrancaemtransito = AlterarTipo<string>(leitor["Cobrancaemtransito"]);
        _codbanco = AlterarTipo<decimal?>(leitor["Codbanco"]);
        _codbancotarifa = AlterarTipo<decimal?>(leitor["Codbancotarifa"]);
        _codbandeira = AlterarTipo<decimal?>(leitor["Codbandeira"]);
        _codclicc = AlterarTipo<decimal?>(leitor["Codclicc"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcobcc = AlterarTipo<string>(leitor["Codcobcc"]);
        _codcobchdesc = AlterarTipo<string>(leitor["Codcobchdesc"]);
        _codcobdevchdesc = AlterarTipo<string>(leitor["Codcobdevchdesc"]);
        _codcontacc = AlterarTipo<decimal?>(leitor["Codcontacc"]);
        _codecf = AlterarTipo<string>(leitor["Codecf"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codigobandeira = AlterarTipo<string>(leitor["Codigobandeira"]);
        _codmoeda = AlterarTipo<string>(leitor["Codmoeda"]);
        _codoperadoracartao = AlterarTipo<string>(leitor["Codoperadoracartao"]);
        _codparanaoprotesto = AlterarTipo<string>(leitor["Codparanaoprotesto"]);
        _codparaprotesto = AlterarTipo<string>(leitor["Codparaprotesto"]);
        _colunafluxocx = AlterarTipo<decimal?>(leitor["Colunafluxocx"]);
        _custodia = AlterarTipo<string>(leitor["Custodia"]);
        _depositobancario = AlterarTipo<string>(leitor["Depositobancario"]);
        _diascarencia = AlterarTipo<decimal?>(leitor["Diascarencia"]);
        _enviacobrancafv = AlterarTipo<string>(leitor["Enviacobrancafv"]);
        _envioparaprotesto = AlterarTipo<string>(leitor["Envioparaprotesto"]);
        _exibirbk = AlterarTipo<string>(leitor["Exibirbk"]);
        _exibircxmot = AlterarTipo<string>(leitor["Exibircxmot"]);
        _exportarecf = AlterarTipo<string>(leitor["Exportarecf"]);
        _fluxocx = AlterarTipo<string>(leitor["Fluxocx"]);
        _letracob = AlterarTipo<string>(leitor["Letracob"]);
        _nivelvenda = AlterarTipo<decimal?>(leitor["Nivelvenda"]);
        _numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
        _numdiasbloqautomatic = AlterarTipo<decimal?>(leitor["Numdiasbloqautomatic"]);
        _numdiasliberacaocredito = AlterarTipo<decimal?>(leitor["Numdiasliberacaocredito"]);
        _numdiasprotesto = AlterarTipo<string>(leitor["Numdiasprotesto"]);
        _numdiasvencfluxocx = AlterarTipo<decimal?>(leitor["Numdiasvencfluxocx"]);
        _nummaxparcelas = AlterarTipo<decimal?>(leitor["Nummaxparcelas"]);
        _numviascpadicional = AlterarTipo<string>(leitor["Numviascpadicional"]);
        _obsnf = AlterarTipo<string>(leitor["Obsnf"]);
        _pagcomissao = AlterarTipo<string>(leitor["Pagcomissao"]);
        _percacresvenda = AlterarTipo<decimal?>(leitor["Percacresvenda"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percommot = AlterarTipo<decimal?>(leitor["Percommot"]);
        _perctxadmincc = AlterarTipo<decimal?>(leitor["Perctxadmincc"]);
        _permitealtcobdesd = AlterarTipo<string>(leitor["Permitealtcobdesd"]);
        _permitebaixamanual = AlterarTipo<string>(leitor["Permitebaixamanual"]);
        _permitecontravale = AlterarTipo<string>(leitor["Permitecontravale"]);
        _permitedescdevcli = AlterarTipo<string>(leitor["Permitedescdevcli"]);
        _prazocc = AlterarTipo<decimal?>(leitor["Prazocc"]);
        _prazomaximovenda = AlterarTipo<decimal?>(leitor["Prazomaximovenda"]);
        _selecionaclienteecf = AlterarTipo<string>(leitor["Selecionaclienteecf"]);
        _somatarifabancduplic = AlterarTipo<string>(leitor["Somatarifabancduplic"]);
        _somatarifabancnf = AlterarTipo<string>(leitor["Somatarifabancnf"]);
        _tipocomissao = AlterarTipo<string>(leitor["Tipocomissao"]);
        _tipooperacaotef = AlterarTipo<string>(leitor["Tipooperacaotef"]);
        _tipopagtoecf = AlterarTipo<string>(leitor["Tipopagtoecf"]);
        _txjuros = AlterarTipo<decimal?>(leitor["Txjuros"]);
        _utilizachdesc = AlterarTipo<string>(leitor["Utilizachdesc"]);
        _validalimcredecf = AlterarTipo<string>(leitor["Validalimcredecf"]);
        _vlminpedido = AlterarTipo<decimal?>(leitor["Vlminpedido"]);
        _vltarifa = AlterarTipo<decimal?>(leitor["Vltarifa"]);
    }

}