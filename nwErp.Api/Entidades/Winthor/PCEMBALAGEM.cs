

////// // namespace nwErp.Entidades.Winthor;

// // namespace nwErp.Api.Modelos;

[Serializable]
public class PCEMBALAGEM : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ACEITAPRECOREPLICADO = "Aceitaprecoreplicado";

    private string _aceitaprecoreplicado;

    private static readonly string RO_ALTURA = "Altura";

    private decimal? _altura;

    private static readonly string RO_ASSINATURA = "Assinatura";

    private string _assinatura;

    private static readonly string RO_BEBALCOOLICA = "Bebalcoolica";

    private string _bebalcoolica;

    private static readonly string RO_CODAUXILIAR = "Codauxiliar";

    private decimal _codauxiliar;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal? _codcli;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODDIGITAQTDE = "Coddigitaqtde";

    private string _coddigitaqtde;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFUNCALTPOFERTA = "Codfuncaltpoferta";

    private decimal? _codfuncaltpoferta;

    private static readonly string RO_CODFUNCALTPOFERTAATAC = "Codfuncaltpofertaatac";

    private decimal? _codfuncaltpofertaatac;

    private static readonly string RO_CODFUNCALTPTABELA = "Codfuncaltptabela";

    private decimal? _codfuncaltptabela;

    private static readonly string RO_CODFUNCALTPTABELAATAC = "Codfuncaltptabelaatac";

    private decimal? _codfuncaltptabelaatac;

    private static readonly string RO_CODFUNCALTPVENDA = "Codfuncaltpvenda";

    private decimal? _codfuncaltpvenda;

    private static readonly string RO_CODFUNCALTPVENDAATAC = "Codfuncaltpvendaatac";

    private decimal? _codfuncaltpvendaatac;

    private static readonly string RO_CODFUNCINATIVO = "Codfuncinativo";

    private decimal? _codfuncinativo;

    private static readonly string RO_CODINFEXTRABAL = "Codinfextrabal";

    private decimal? _codinfextrabal;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_COMPRIMENTO = "Comprimento";

    private decimal? _comprimento;

    private static readonly string RO_CONTROLEVASILHAME = "Controlevasilhame";

    private string _controlevasilhame;

    private static readonly string RO_DESCRICAOECF = "Descricaoecf";

    private string _descricaoecf;

    private static readonly string RO_DESCRICAOWEB = "Descricaoweb";

    private string _descricaoweb;

    private static readonly string RO_DESTINOOFERTAATAC = "Destinoofertaatac";

    private string _destinoofertaatac;

    private static readonly string RO_DESTINOOFERTAVAREJO = "Destinoofertavarejo";

    private string _destinoofertavarejo;

    private static readonly string RO_DTAPLICPRECOATAC = "Dtaplicprecoatac";

    private DateTime? _dtaplicprecoatac;

    private static readonly string RO_DTAPLICPRECOVAREJO = "Dtaplicprecovarejo";

    private DateTime? _dtaplicprecovarejo;

    private static readonly string RO_DTEMISSAOETIQ = "Dtemissaoetiq";

    private DateTime? _dtemissaoetiq;

    private static readonly string RO_DTEMISSAOETIQPOFERTAS = "Dtemissaoetiqpofertas";

    private DateTime? _dtemissaoetiqpofertas;

    private static readonly string RO_DTINATIVO = "Dtinativo";

    private DateTime? _dtinativo;

    private static readonly string RO_DTOFERTAATACFIM = "Dtofertaatacfim";

    private DateTime? _dtofertaatacfim;

    private static readonly string RO_DTOFERTAATACINI = "Dtofertaatacini";

    private DateTime? _dtofertaatacini;

    private static readonly string RO_DTOFERTAFIM = "Dtofertafim";

    private DateTime? _dtofertafim;

    private static readonly string RO_DTOFERTAINI = "Dtofertaini";

    private DateTime? _dtofertaini;

    private static readonly string RO_DTOFERTAWEBFIM = "Dtofertawebfim";

    private DateTime? _dtofertawebfim;

    private static readonly string RO_DTOFERTAWEBINI = "Dtofertawebini";

    private DateTime? _dtofertawebini;

    private static readonly string RO_DTULTALT = "Dtultalt";

    private DateTime? _dtultalt;

    private static readonly string RO_DTULTALTCOM = "Dtultaltcom";

    private DateTime? _dtultaltcom;

    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";

    private DateTime? _dtultaltersrvprc;

    private static readonly string RO_DTULTALTGIRO = "Dtultaltgiro";

    private DateTime? _dtultaltgiro;

    private static readonly string RO_DTULTALTPTABELA = "Dtultaltptabela";

    private DateTime? _dtultaltptabela;

    private static readonly string RO_DTULTALTPTABELAATAC = "Dtultaltptabelaatac";

    private DateTime? _dtultaltptabelaatac;

    private static readonly string RO_DTULTALTPTABELAWEB = "Dtultaltptabelaweb";

    private DateTime? _dtultaltptabelaweb;

    private static readonly string RO_DTULTALTPVENDA = "Dtultaltpvenda";

    private DateTime? _dtultaltpvenda;

    private static readonly string RO_DTULTALTPVENDAATAC = "Dtultaltpvendaatac";

    private DateTime? _dtultaltpvendaatac;

    private static readonly string RO_EMBALAGEM = "Embalagem";

    private string _embalagem;

    private static readonly string RO_ENVIABALANCA = "Enviabalanca";

    private string _enviabalanca;

    private static readonly string RO_ENVIAFRENTECAIXA = "Enviafrentecaixa";

    private string _enviafrentecaixa;

    private static readonly string RO_ENVIAFV = "Enviafv";

    private string _enviafv;

    private static readonly string RO_ENVIAINFNUTRI = "Enviainfnutri";

    private string _enviainfnutri;

    private static readonly string RO_ENVIATELEMARKETING = "Enviatelemarketing";

    private string _enviatelemarketing;

    private static readonly string RO_EXCLUIDO = "Excluido";

    private string _excluido;

    private static readonly string RO_EXPORTACAMPO = "Exportacampo";

    private string _exportacampo;

    private static readonly string RO_FATORCONVERSAO = "Fatorconversao";

    private decimal? _fatorconversao;

    private static readonly string RO_FATORPRECO = "Fatorpreco";

    private decimal? _fatorpreco;

    private static readonly string RO_GIROMEDIODIA = "Giromediodia";

    private decimal? _giromediodia;

    private static readonly string RO_GIROMES = "Giromes";

    private decimal? _giromes;

    private static readonly string RO_IMPDATAEMBALAGEMBALANCA = "Impdataembalagembalanca";

    private string _impdataembalagembalanca;

    private static readonly string RO_IMPRESSAORESTAURANTE = "Impressaorestaurante";

    private string _impressaorestaurante;

    private static readonly string RO_IMPRIMERESTAURANTE = "Imprimerestaurante";

    private string _imprimerestaurante;

    private static readonly string RO_INDCVENDECODINTERNO = "Indcvendecodinterno";

    private string _indcvendecodinterno;

    private static readonly string RO_INDICALERTAQUANTIDADE = "Indicalertaquantidade";

    private string _indicalertaquantidade;

    private static readonly string RO_INDICGERARCODPESOVAR = "Indicgerarcodpesovar";

    private string _indicgerarcodpesovar;

    private static readonly string RO_INDICPERMITEDIGITACAODESCONTO = "Indicpermitedigitacaodesconto";

    private string _indicpermitedigitacaodesconto;

    private static readonly string RO_INDICPERMITEDIGITACAOPRECO = "Indicpermitedigitacaopreco";

    private string _indicpermitedigitacaopreco;

    private static readonly string RO_INDICPERMITEPORPREVENDA = "Indicpermiteporprevenda";

    private string _indicpermiteporprevenda;

    private static readonly string RO_INDICPESAGEMOBRIGATORIA = "Indicpesagemobrigatoria";

    private string _indicpesagemobrigatoria;

    private static readonly string RO_INDICPRODUCAOPROPRIA = "Indicproducaopropria";

    private string _indicproducaopropria;

    private static readonly string RO_INFOPRODWEB = "Infoprodweb";

    private string _infoprodweb;

    private static readonly string RO_LARGURA = "Largura";

    private decimal? _largura;

    private static readonly string RO_LAYOUTETIQUETA = "Layoutetiqueta";

    private string _layoutetiqueta;

    private static readonly string RO_MARGEM = "Margem";

    private decimal? _margem;

    private static readonly string RO_MARGEMATAC = "Margematac";

    private decimal? _margematac;

    private static readonly string RO_MARGEMATAC_ESP = "Margematac_Esp";

    private decimal? _margematac_esp;

    private static readonly string RO_MARGEMIDEALATAC = "Margemidealatac";

    private decimal? _margemidealatac;

    private static readonly string RO_MARGEM_ESP = "Margem_Esp";

    private decimal? _margem_esp;

    private static readonly string RO_MOTIVOOFERTA = "Motivooferta";

    private string _motivooferta;

    private static readonly string RO_NUMSEQATU = "Numseqatu";

    private decimal? _numseqatu;

    private static readonly string RO_OBRIGALEITURACODBARRA = "Obrigaleituracodbarra";

    private string _obrigaleituracodbarra;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_PCOMEXT1 = "Pcomext1";

    private decimal? _pcomext1;

    private static readonly string RO_PCOMINT1 = "Pcomint1";

    private decimal? _pcomint1;

    private static readonly string RO_PCOMREP1 = "Pcomrep1";

    private decimal? _pcomrep1;

    private static readonly string RO_PERDESCCARTAOFIDELIDADE = "Perdesccartaofidelidade";

    private decimal? _perdesccartaofidelidade;

    private static readonly string RO_PERMITEMULTIPLICACAO = "Permitemultiplicacao";

    private string _permitemultiplicacao;

    private static readonly string RO_PERMITEVENDAATACADO = "Permitevendaatacado";

    private string _permitevendaatacado;

    private static readonly string RO_PERMITEVENDACOMINTERNO = "Permitevendacominterno";

    private string _permitevendacominterno;

    private static readonly string RO_PERVARIACAOPTABELA = "Pervariacaoptabela";

    private decimal? _pervariacaoptabela;

    private static readonly string RO_PESOBRUTO = "Pesobruto";

    private decimal? _pesobruto;

    private static readonly string RO_PESOLIQ = "Pesoliq";

    private decimal? _pesoliq;

    private static readonly string RO_POFERTA = "Poferta";

    private decimal? _poferta;

    private static readonly string RO_POFERTAATAC = "Pofertaatac";

    private decimal? _pofertaatac;

    private static readonly string RO_POFERTAWEB = "Pofertaweb";

    private decimal? _pofertaweb;

    private static readonly string RO_PRAZOVAL = "Prazoval";

    private decimal? _prazoval;

    private static readonly string RO_PRECOANTERIOR = "Precoanterior";

    private decimal? _precoanterior;

    private static readonly string RO_PRECOANTERIORATAC = "Precoanterioratac";

    private decimal _precoanterioratac;

    private static readonly string RO_PTABELA = "Ptabela";

    private decimal? _ptabela;

    private static readonly string RO_PTABELAANT = "Ptabelaant";

    private decimal? _ptabelaant;

    private static readonly string RO_PTABELAATAC = "Ptabelaatac";

    private decimal _ptabelaatac;

    private static readonly string RO_PTABELAATACANT = "Ptabelaatacant";

    private decimal? _ptabelaatacant;

    private static readonly string RO_PTABELAWEB = "Ptabelaweb";

    private decimal? _ptabelaweb;

    private static readonly string RO_PTABELAWEBANT = "Ptabelawebant";

    private decimal? _ptabelawebant;

    private static readonly string RO_PVENDA = "Pvenda";

    private decimal? _pvenda;

    private static readonly string RO_PVENDAATAC = "Pvendaatac";

    private decimal _pvendaatac;

    private static readonly string RO_PVENDAWEB = "Pvendaweb";

    private decimal? _pvendaweb;

    private static readonly string RO_PVENDAWEBANT = "Pvendawebant";

    private decimal? _pvendawebant;

    private static readonly string RO_QTDIAS = "Qtdias";

    private decimal? _qtdias;

    private static readonly string RO_QTEMISSAOETIQ = "Qtemissaoetiq";

    private decimal? _qtemissaoetiq;

    private static readonly string RO_QTFIXAMULTIPLICCHECKOUT = "Qtfixamultipliccheckout";

    private decimal? _qtfixamultipliccheckout;

    private static readonly string RO_QTMAXGONDOLA = "Qtmaxgondola";

    private decimal? _qtmaxgondola;

    private static readonly string RO_QTMAXVENDA = "Qtmaxvenda";

    private decimal? _qtmaxvenda;

    private static readonly string RO_QTMINGONDOLA = "Qtmingondola";

    private decimal? _qtmingondola;

    private static readonly string RO_QTMINIMAATACADO = "Qtminimaatacado";

    private decimal? _qtminimaatacado;

    private static readonly string RO_QTMINIMAATACADOF = "Qtminimaatacadof";

    private decimal? _qtminimaatacadof;

    private static readonly string RO_QTMULTIPLA = "Qtmultipla";

    private decimal? _qtmultipla;

    private static readonly string RO_QTUNIT = "Qtunit";

    private decimal? _qtunit;

    private static readonly string RO_SITUACAOWEB = "Situacaoweb";

    private string _situacaoweb;

    private static readonly string RO_SOCIOTORCEDOR = "Sociotorcedor";

    private string _sociotorcedor;

    private static readonly string RO_TARAF = "Taraf";

    private decimal? _taraf;

    private static readonly string RO_TIPOEMBALAGEM = "Tipoembalagem";

    private string _tipoembalagem;

    private static readonly string RO_UNIDADE = "Unidade";

    private string _unidade;

    private static readonly string RO_UNMEDIDA = "Unmedida";

    private string _unmedida;

    private static readonly string RO_USABALANCATOLEDO = "Usabalancatoledo";

    private string _usabalancatoledo;

    private static readonly string RO_USARESTAURANTE = "Usarestaurante";

    private string _usarestaurante;

    private static readonly string RO_VOLUME = "Volume";

    private decimal? _volume;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Aceitaprecoreplicado
    {
        get
        {
            PropriedadeAcessada(RO_ACEITAPRECOREPLICADO);
            return _aceitaprecoreplicado;
        }
        set
        {
            PropriedadeModificada(RO_ACEITAPRECOREPLICADO, value);
            _aceitaprecoreplicado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Altura
    {
        get
        {
            PropriedadeAcessada(RO_ALTURA);
            return _altura;
        }
        set
        {
            PropriedadeModificada(RO_ALTURA, value);
            _altura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bebalcoolica
    {
        get
        {
            PropriedadeAcessada(RO_BEBALCOOLICA);
            return _bebalcoolica;
        }
        set
        {
            PropriedadeModificada(RO_BEBALCOOLICA, value);
            _bebalcoolica = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal Codauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_CODAUXILIAR);
            return _codauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_CODAUXILIAR, value);
            _codauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcli
    {
        get
        {
            PropriedadeAcessada(RO_CODCLI);
            return _codcli;
        }
        set
        {
            PropriedadeModificada(RO_CODCLI, value);
            _codcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Coddigitaqtde
    {
        get
        {
            PropriedadeAcessada(RO_CODDIGITAQTDE);
            return _coddigitaqtde;
        }
        set
        {
            PropriedadeModificada(RO_CODDIGITAQTDE, value);
            _coddigitaqtde = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltpoferta
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPOFERTA);
            return _codfuncaltpoferta;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPOFERTA, value);
            _codfuncaltpoferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltpofertaatac
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPOFERTAATAC);
            return _codfuncaltpofertaatac;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPOFERTAATAC, value);
            _codfuncaltpofertaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltptabela
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPTABELA);
            return _codfuncaltptabela;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPTABELA, value);
            _codfuncaltptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltptabelaatac
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPTABELAATAC);
            return _codfuncaltptabelaatac;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPTABELAATAC, value);
            _codfuncaltptabelaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltpvenda
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPVENDA);
            return _codfuncaltpvenda;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPVENDA, value);
            _codfuncaltpvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncaltpvendaatac
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCALTPVENDAATAC);
            return _codfuncaltpvendaatac;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCALTPVENDAATAC, value);
            _codfuncaltpvendaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncinativo
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCINATIVO);
            return _codfuncinativo;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCINATIVO, value);
            _codfuncinativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codinfextrabal
    {
        get
        {
            PropriedadeAcessada(RO_CODINFEXTRABAL);
            return _codinfextrabal;
        }
        set
        {
            PropriedadeModificada(RO_CODINFEXTRABAL, value);
            _codinfextrabal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Comprimento
    {
        get
        {
            PropriedadeAcessada(RO_COMPRIMENTO);
            return _comprimento;
        }
        set
        {
            PropriedadeModificada(RO_COMPRIMENTO, value);
            _comprimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Controlevasilhame
    {
        get
        {
            PropriedadeAcessada(RO_CONTROLEVASILHAME);
            return _controlevasilhame;
        }
        set
        {
            PropriedadeModificada(RO_CONTROLEVASILHAME, value);
            _controlevasilhame = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Descricaoecf
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAOECF);
            return _descricaoecf;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAOECF, value);
            _descricaoecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Descricaoweb
    {
        get
        {
            PropriedadeAcessada(RO_DESCRICAOWEB);
            return _descricaoweb;
        }
        set
        {
            PropriedadeModificada(RO_DESCRICAOWEB, value);
            _descricaoweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Destinoofertaatac
    {
        get
        {
            PropriedadeAcessada(RO_DESTINOOFERTAATAC);
            return _destinoofertaatac;
        }
        set
        {
            PropriedadeModificada(RO_DESTINOOFERTAATAC, value);
            _destinoofertaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Destinoofertavarejo
    {
        get
        {
            PropriedadeAcessada(RO_DESTINOOFERTAVAREJO);
            return _destinoofertavarejo;
        }
        set
        {
            PropriedadeModificada(RO_DESTINOOFERTAVAREJO, value);
            _destinoofertavarejo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaplicprecoatac
    {
        get
        {
            PropriedadeAcessada(RO_DTAPLICPRECOATAC);
            return _dtaplicprecoatac;
        }
        set
        {
            PropriedadeModificada(RO_DTAPLICPRECOATAC, value);
            _dtaplicprecoatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaplicprecovarejo
    {
        get
        {
            PropriedadeAcessada(RO_DTAPLICPRECOVAREJO);
            return _dtaplicprecovarejo;
        }
        set
        {
            PropriedadeModificada(RO_DTAPLICPRECOVAREJO, value);
            _dtaplicprecovarejo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoetiq
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOETIQ);
            return _dtemissaoetiq;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOETIQ, value);
            _dtemissaoetiq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoetiqpofertas
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOETIQPOFERTAS);
            return _dtemissaoetiqpofertas;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOETIQPOFERTAS, value);
            _dtemissaoetiqpofertas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinativo
    {
        get
        {
            PropriedadeAcessada(RO_DTINATIVO);
            return _dtinativo;
        }
        set
        {
            PropriedadeModificada(RO_DTINATIVO, value);
            _dtinativo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertaatacfim
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAATACFIM);
            return _dtofertaatacfim;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAATACFIM, value);
            _dtofertaatacfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertaatacini
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAATACINI);
            return _dtofertaatacini;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAATACINI, value);
            _dtofertaatacini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertafim
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAFIM);
            return _dtofertafim;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAFIM, value);
            _dtofertafim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertaini
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAINI);
            return _dtofertaini;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAINI, value);
            _dtofertaini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertawebfim
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAWEBFIM);
            return _dtofertawebfim;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAWEBFIM, value);
            _dtofertawebfim = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtofertawebini
    {
        get
        {
            PropriedadeAcessada(RO_DTOFERTAWEBINI);
            return _dtofertawebini;
        }
        set
        {
            PropriedadeModificada(RO_DTOFERTAWEBINI, value);
            _dtofertawebini = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalt
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALT);
            return _dtultalt;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALT, value);
            _dtultalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltcom
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTCOM);
            return _dtultaltcom;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTCOM, value);
            _dtultaltcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltersrvprc
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERSRVPRC);
            return _dtultaltersrvprc;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERSRVPRC, value);
            _dtultaltersrvprc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltgiro
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTGIRO);
            return _dtultaltgiro;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTGIRO, value);
            _dtultaltgiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltptabela
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPTABELA);
            return _dtultaltptabela;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPTABELA, value);
            _dtultaltptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltptabelaatac
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPTABELAATAC);
            return _dtultaltptabelaatac;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPTABELAATAC, value);
            _dtultaltptabelaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltptabelaweb
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPTABELAWEB);
            return _dtultaltptabelaweb;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPTABELAWEB, value);
            _dtultaltptabelaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltpvenda
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPVENDA);
            return _dtultaltpvenda;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPVENDA, value);
            _dtultaltpvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltpvendaatac
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPVENDAATAC);
            return _dtultaltpvendaatac;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPVENDAATAC, value);
            _dtultaltpvendaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Embalagem
    {
        get
        {
            PropriedadeAcessada(RO_EMBALAGEM);
            return _embalagem;
        }
        set
        {
            PropriedadeModificada(RO_EMBALAGEM, value);
            _embalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviabalanca
    {
        get
        {
            PropriedadeAcessada(RO_ENVIABALANCA);
            return _enviabalanca;
        }
        set
        {
            PropriedadeModificada(RO_ENVIABALANCA, value);
            _enviabalanca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviafrentecaixa
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAFRENTECAIXA);
            return _enviafrentecaixa;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAFRENTECAIXA, value);
            _enviafrentecaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviafv
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAFV);
            return _enviafv;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAFV, value);
            _enviafv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviainfnutri
    {
        get
        {
            PropriedadeAcessada(RO_ENVIAINFNUTRI);
            return _enviainfnutri;
        }
        set
        {
            PropriedadeModificada(RO_ENVIAINFNUTRI, value);
            _enviainfnutri = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviatelemarketing
    {
        get
        {
            PropriedadeAcessada(RO_ENVIATELEMARKETING);
            return _enviatelemarketing;
        }
        set
        {
            PropriedadeModificada(RO_ENVIATELEMARKETING, value);
            _enviatelemarketing = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Excluido
    {
        get
        {
            PropriedadeAcessada(RO_EXCLUIDO);
            return _excluido;
        }
        set
        {
            PropriedadeModificada(RO_EXCLUIDO, value);
            _excluido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportacampo
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTACAMPO);
            return _exportacampo;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTACAMPO, value);
            _exportacampo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Fatorconversao
    {
        get
        {
            PropriedadeAcessada(RO_FATORCONVERSAO);
            return _fatorconversao;
        }
        set
        {
            PropriedadeModificada(RO_FATORCONVERSAO, value);
            _fatorconversao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Fatorpreco
    {
        get
        {
            PropriedadeAcessada(RO_FATORPRECO);
            return _fatorpreco;
        }
        set
        {
            PropriedadeModificada(RO_FATORPRECO, value);
            _fatorpreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Giromediodia
    {
        get
        {
            PropriedadeAcessada(RO_GIROMEDIODIA);
            return _giromediodia;
        }
        set
        {
            PropriedadeModificada(RO_GIROMEDIODIA, value);
            _giromediodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
    public decimal? Giromes
    {
        get
        {
            PropriedadeAcessada(RO_GIROMES);
            return _giromes;
        }
        set
        {
            PropriedadeModificada(RO_GIROMES, value);
            _giromes = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impdataembalagembalanca
    {
        get
        {
            PropriedadeAcessada(RO_IMPDATAEMBALAGEMBALANCA);
            return _impdataembalagembalanca;
        }
        set
        {
            PropriedadeModificada(RO_IMPDATAEMBALAGEMBALANCA, value);
            _impdataembalagembalanca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Impressaorestaurante
    {
        get
        {
            PropriedadeAcessada(RO_IMPRESSAORESTAURANTE);
            return _impressaorestaurante;
        }
        set
        {
            PropriedadeModificada(RO_IMPRESSAORESTAURANTE, value);
            _impressaorestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Imprimerestaurante
    {
        get
        {
            PropriedadeAcessada(RO_IMPRIMERESTAURANTE);
            return _imprimerestaurante;
        }
        set
        {
            PropriedadeModificada(RO_IMPRIMERESTAURANTE, value);
            _imprimerestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indcvendecodinterno
    {
        get
        {
            PropriedadeAcessada(RO_INDCVENDECODINTERNO);
            return _indcvendecodinterno;
        }
        set
        {
            PropriedadeModificada(RO_INDCVENDECODINTERNO, value);
            _indcvendecodinterno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicalertaquantidade
    {
        get
        {
            PropriedadeAcessada(RO_INDICALERTAQUANTIDADE);
            return _indicalertaquantidade;
        }
        set
        {
            PropriedadeModificada(RO_INDICALERTAQUANTIDADE, value);
            _indicalertaquantidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicgerarcodpesovar
    {
        get
        {
            PropriedadeAcessada(RO_INDICGERARCODPESOVAR);
            return _indicgerarcodpesovar;
        }
        set
        {
            PropriedadeModificada(RO_INDICGERARCODPESOVAR, value);
            _indicgerarcodpesovar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicpermitedigitacaodesconto
    {
        get
        {
            PropriedadeAcessada(RO_INDICPERMITEDIGITACAODESCONTO);
            return _indicpermitedigitacaodesconto;
        }
        set
        {
            PropriedadeModificada(RO_INDICPERMITEDIGITACAODESCONTO, value);
            _indicpermitedigitacaodesconto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicpermitedigitacaopreco
    {
        get
        {
            PropriedadeAcessada(RO_INDICPERMITEDIGITACAOPRECO);
            return _indicpermitedigitacaopreco;
        }
        set
        {
            PropriedadeModificada(RO_INDICPERMITEDIGITACAOPRECO, value);
            _indicpermitedigitacaopreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicpermiteporprevenda
    {
        get
        {
            PropriedadeAcessada(RO_INDICPERMITEPORPREVENDA);
            return _indicpermiteporprevenda;
        }
        set
        {
            PropriedadeModificada(RO_INDICPERMITEPORPREVENDA, value);
            _indicpermiteporprevenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicpesagemobrigatoria
    {
        get
        {
            PropriedadeAcessada(RO_INDICPESAGEMOBRIGATORIA);
            return _indicpesagemobrigatoria;
        }
        set
        {
            PropriedadeModificada(RO_INDICPESAGEMOBRIGATORIA, value);
            _indicpesagemobrigatoria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicproducaopropria
    {
        get
        {
            PropriedadeAcessada(RO_INDICPRODUCAOPROPRIA);
            return _indicproducaopropria;
        }
        set
        {
            PropriedadeModificada(RO_INDICPRODUCAOPROPRIA, value);
            _indicproducaopropria = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Binario, Tamanho = 4000, Precisao = 0)]
    public string Infoprodweb
    {
        get
        {
            PropriedadeAcessada(RO_INFOPRODWEB);
            return _infoprodweb;
        }
        set
        {
            PropriedadeModificada(RO_INFOPRODWEB, value);
            _infoprodweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Largura
    {
        get
        {
            PropriedadeAcessada(RO_LARGURA);
            return _largura;
        }
        set
        {
            PropriedadeModificada(RO_LARGURA, value);
            _largura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Layoutetiqueta
    {
        get
        {
            PropriedadeAcessada(RO_LAYOUTETIQUETA);
            return _layoutetiqueta;
        }
        set
        {
            PropriedadeModificada(RO_LAYOUTETIQUETA, value);
            _layoutetiqueta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margem
    {
        get
        {
            PropriedadeAcessada(RO_MARGEM);
            return _margem;
        }
        set
        {
            PropriedadeModificada(RO_MARGEM, value);
            _margem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margematac
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMATAC);
            return _margematac;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMATAC, value);
            _margematac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margematac_Esp
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMATAC_ESP);
            return _margematac_esp;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMATAC_ESP, value);
            _margematac_esp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margemidealatac
    {
        get
        {
            PropriedadeAcessada(RO_MARGEMIDEALATAC);
            return _margemidealatac;
        }
        set
        {
            PropriedadeModificada(RO_MARGEMIDEALATAC, value);
            _margemidealatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margem_Esp
    {
        get
        {
            PropriedadeAcessada(RO_MARGEM_ESP);
            return _margem_esp;
        }
        set
        {
            PropriedadeModificada(RO_MARGEM_ESP, value);
            _margem_esp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Motivooferta
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVOOFERTA);
            return _motivooferta;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVOOFERTA, value);
            _motivooferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 0, Precisao = 0)]
    public decimal? Numseqatu
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQATU);
            return _numseqatu;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQATU, value);
            _numseqatu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Obrigaleituracodbarra
    {
        get
        {
            PropriedadeAcessada(RO_OBRIGALEITURACODBARRA);
            return _obrigaleituracodbarra;
        }
        set
        {
            PropriedadeModificada(RO_OBRIGALEITURACODBARRA, value);
            _obrigaleituracodbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Obs
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomext1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMEXT1);
            return _pcomext1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMEXT1, value);
            _pcomext1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomint1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMINT1);
            return _pcomint1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMINT1, value);
            _pcomint1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMREP1);
            return _pcomrep1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMREP1, value);
            _pcomrep1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdesccartaofidelidade
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCCARTAOFIDELIDADE);
            return _perdesccartaofidelidade;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCCARTAOFIDELIDADE, value);
            _perdesccartaofidelidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitemultiplicacao
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEMULTIPLICACAO);
            return _permitemultiplicacao;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEMULTIPLICACAO, value);
            _permitemultiplicacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitevendaatacado
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEVENDAATACADO);
            return _permitevendaatacado;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEVENDAATACADO, value);
            _permitevendaatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permitevendacominterno
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEVENDACOMINTERNO);
            return _permitevendacominterno;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEVENDACOMINTERNO, value);
            _permitevendacominterno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Pervariacaoptabela
    {
        get
        {
            PropriedadeAcessada(RO_PERVARIACAOPTABELA);
            return _pervariacaoptabela;
        }
        set
        {
            PropriedadeModificada(RO_PERVARIACAOPTABELA, value);
            _pervariacaoptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Pesobruto
    {
        get
        {
            PropriedadeAcessada(RO_PESOBRUTO);
            return _pesobruto;
        }
        set
        {
            PropriedadeModificada(RO_PESOBRUTO, value);
            _pesobruto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Pesoliq
    {
        get
        {
            PropriedadeAcessada(RO_PESOLIQ);
            return _pesoliq;
        }
        set
        {
            PropriedadeModificada(RO_PESOLIQ, value);
            _pesoliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Poferta
    {
        get
        {
            PropriedadeAcessada(RO_POFERTA);
            return _poferta;
        }
        set
        {
            PropriedadeModificada(RO_POFERTA, value);
            _poferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pofertaatac
    {
        get
        {
            PropriedadeAcessada(RO_POFERTAATAC);
            return _pofertaatac;
        }
        set
        {
            PropriedadeModificada(RO_POFERTAATAC, value);
            _pofertaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pofertaweb
    {
        get
        {
            PropriedadeAcessada(RO_POFERTAWEB);
            return _pofertaweb;
        }
        set
        {
            PropriedadeModificada(RO_POFERTAWEB, value);
            _pofertaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Prazoval
    {
        get
        {
            PropriedadeAcessada(RO_PRAZOVAL);
            return _prazoval;
        }
        set
        {
            PropriedadeModificada(RO_PRAZOVAL, value);
            _prazoval = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Precoanterior
    {
        get
        {
            PropriedadeAcessada(RO_PRECOANTERIOR);
            return _precoanterior;
        }
        set
        {
            PropriedadeModificada(RO_PRECOANTERIOR, value);
            _precoanterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal Precoanterioratac
    {
        get
        {
            PropriedadeAcessada(RO_PRECOANTERIORATAC);
            return _precoanterioratac;
        }
        set
        {
            PropriedadeModificada(RO_PRECOANTERIORATAC, value);
            _precoanterioratac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabela
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA);
            return _ptabela;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA, value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelaant
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAANT);
            return _ptabelaant;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAANT, value);
            _ptabelaant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal Ptabelaatac
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC);
            return _ptabelaatac;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC, value);
            _ptabelaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelaatacant
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATACANT);
            return _ptabelaatacant;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATACANT, value);
            _ptabelaatacant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Ptabelaweb
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAWEB);
            return _ptabelaweb;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAWEB, value);
            _ptabelaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelawebant
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAWEBANT);
            return _ptabelawebant;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAWEBANT, value);
            _ptabelawebant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvenda
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA);
            return _pvenda;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA, value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal Pvendaatac
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC);
            return _pvendaatac;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC, value);
            _pvendaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Pvendaweb
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAWEB);
            return _pvendaweb;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAWEB, value);
            _pvendaweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendawebant
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAWEBANT);
            return _pvendawebant;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAWEBANT, value);
            _pvendawebant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtdias
    {
        get
        {
            PropriedadeAcessada(RO_QTDIAS);
            return _qtdias;
        }
        set
        {
            PropriedadeModificada(RO_QTDIAS, value);
            _qtdias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Qtemissaoetiq
    {
        get
        {
            PropriedadeAcessada(RO_QTEMISSAOETIQ);
            return _qtemissaoetiq;
        }
        set
        {
            PropriedadeModificada(RO_QTEMISSAOETIQ, value);
            _qtemissaoetiq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 3)]
    public decimal? Qtfixamultipliccheckout
    {
        get
        {
            PropriedadeAcessada(RO_QTFIXAMULTIPLICCHECKOUT);
            return _qtfixamultipliccheckout;
        }
        set
        {
            PropriedadeModificada(RO_QTFIXAMULTIPLICCHECKOUT, value);
            _qtfixamultipliccheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmaxgondola
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXGONDOLA);
            return _qtmaxgondola;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXGONDOLA, value);
            _qtmaxgondola = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtmaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_QTMAXVENDA);
            return _qtmaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_QTMAXVENDA, value);
            _qtmaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmingondola
    {
        get
        {
            PropriedadeAcessada(RO_QTMINGONDOLA);
            return _qtmingondola;
        }
        set
        {
            PropriedadeModificada(RO_QTMINGONDOLA, value);
            _qtmingondola = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtminimaatacado
    {
        get
        {
            PropriedadeAcessada(RO_QTMINIMAATACADO);
            return _qtminimaatacado;
        }
        set
        {
            PropriedadeModificada(RO_QTMINIMAATACADO, value);
            _qtminimaatacado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtminimaatacadof
    {
        get
        {
            PropriedadeAcessada(RO_QTMINIMAATACADOF);
            return _qtminimaatacadof;
        }
        set
        {
            PropriedadeModificada(RO_QTMINIMAATACADOF, value);
            _qtminimaatacadof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtmultipla
    {
        get
        {
            PropriedadeAcessada(RO_QTMULTIPLA);
            return _qtmultipla;
        }
        set
        {
            PropriedadeModificada(RO_QTMULTIPLA, value);
            _qtmultipla = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Qtunit
    {
        get
        {
            PropriedadeAcessada(RO_QTUNIT);
            return _qtunit;
        }
        set
        {
            PropriedadeModificada(RO_QTUNIT, value);
            _qtunit = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Situacaoweb
    {
        get
        {
            PropriedadeAcessada(RO_SITUACAOWEB);
            return _situacaoweb;
        }
        set
        {
            PropriedadeModificada(RO_SITUACAOWEB, value);
            _situacaoweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Sociotorcedor
    {
        get
        {
            PropriedadeAcessada(RO_SOCIOTORCEDOR);
            return _sociotorcedor;
        }
        set
        {
            PropriedadeModificada(RO_SOCIOTORCEDOR, value);
            _sociotorcedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 3)]
    public decimal? Taraf
    {
        get
        {
            PropriedadeAcessada(RO_TARAF);
            return _taraf;
        }
        set
        {
            PropriedadeModificada(RO_TARAF, value);
            _taraf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoembalagem
    {
        get
        {
            PropriedadeAcessada(RO_TIPOEMBALAGEM);
            return _tipoembalagem;
        }
        set
        {
            PropriedadeModificada(RO_TIPOEMBALAGEM, value);
            _tipoembalagem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Unidade
    {
        get
        {
            PropriedadeAcessada(RO_UNIDADE);
            return _unidade;
        }
        set
        {
            PropriedadeModificada(RO_UNIDADE, value);
            _unidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Unmedida
    {
        get
        {
            PropriedadeAcessada(RO_UNMEDIDA);
            return _unmedida;
        }
        set
        {
            PropriedadeModificada(RO_UNMEDIDA, value);
            _unmedida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usabalancatoledo
    {
        get
        {
            PropriedadeAcessada(RO_USABALANCATOLEDO);
            return _usabalancatoledo;
        }
        set
        {
            PropriedadeModificada(RO_USABALANCATOLEDO, value);
            _usabalancatoledo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarestaurante
    {
        get
        {
            PropriedadeAcessada(RO_USARESTAURANTE);
            return _usarestaurante;
        }
        set
        {
            PropriedadeModificada(RO_USARESTAURANTE, value);
            _usarestaurante = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMBALAGEM", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Volume
    {
        get
        {
            PropriedadeAcessada(RO_VOLUME);
            return _volume;
        }
        set
        {
            PropriedadeModificada(RO_VOLUME, value);
            _volume = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCEMBALAGEM";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _aceitaprecoreplicado = AlterarTipo<string>(leitor["Aceitaprecoreplicado"]);
        _altura = AlterarTipo<decimal?>(leitor["Altura"]);
        _assinatura = AlterarTipo<string>(leitor["Assinatura"]);
        _bebalcoolica = AlterarTipo<string>(leitor["Bebalcoolica"]);
        _codauxiliar = AlterarTipo<decimal>(leitor["Codauxiliar"]);
        _codcli = AlterarTipo<decimal?>(leitor["Codcli"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _coddigitaqtde = AlterarTipo<string>(leitor["Coddigitaqtde"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfuncaltpoferta = AlterarTipo<decimal?>(leitor["Codfuncaltpoferta"]);
        _codfuncaltpofertaatac = AlterarTipo<decimal?>(leitor["Codfuncaltpofertaatac"]);
        _codfuncaltptabela = AlterarTipo<decimal?>(leitor["Codfuncaltptabela"]);
        _codfuncaltptabelaatac = AlterarTipo<decimal?>(leitor["Codfuncaltptabelaatac"]);
        _codfuncaltpvenda = AlterarTipo<decimal?>(leitor["Codfuncaltpvenda"]);
        _codfuncaltpvendaatac = AlterarTipo<decimal?>(leitor["Codfuncaltpvendaatac"]);
        _codfuncinativo = AlterarTipo<decimal?>(leitor["Codfuncinativo"]);
        _codinfextrabal = AlterarTipo<decimal?>(leitor["Codinfextrabal"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _comprimento = AlterarTipo<decimal?>(leitor["Comprimento"]);
        _controlevasilhame = AlterarTipo<string>(leitor["Controlevasilhame"]);
        _descricaoecf = AlterarTipo<string>(leitor["Descricaoecf"]);
        _descricaoweb = AlterarTipo<string>(leitor["Descricaoweb"]);
        _destinoofertaatac = AlterarTipo<string>(leitor["Destinoofertaatac"]);
        _destinoofertavarejo = AlterarTipo<string>(leitor["Destinoofertavarejo"]);
        _dtaplicprecoatac = AlterarTipo<DateTime?>(leitor["Dtaplicprecoatac"]);
        _dtaplicprecovarejo = AlterarTipo<DateTime?>(leitor["Dtaplicprecovarejo"]);
        _dtemissaoetiq = AlterarTipo<DateTime?>(leitor["Dtemissaoetiq"]);
        _dtemissaoetiqpofertas = AlterarTipo<DateTime?>(leitor["Dtemissaoetiqpofertas"]);
        _dtinativo = AlterarTipo<DateTime?>(leitor["Dtinativo"]);
        _dtofertaatacfim = AlterarTipo<DateTime?>(leitor["Dtofertaatacfim"]);
        _dtofertaatacini = AlterarTipo<DateTime?>(leitor["Dtofertaatacini"]);
        _dtofertafim = AlterarTipo<DateTime?>(leitor["Dtofertafim"]);
        _dtofertaini = AlterarTipo<DateTime?>(leitor["Dtofertaini"]);
        _dtofertawebfim = AlterarTipo<DateTime?>(leitor["Dtofertawebfim"]);
        _dtofertawebini = AlterarTipo<DateTime?>(leitor["Dtofertawebini"]);
        _dtultalt = AlterarTipo<DateTime?>(leitor["Dtultalt"]);
        _dtultaltcom = AlterarTipo<DateTime?>(leitor["Dtultaltcom"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _dtultaltgiro = AlterarTipo<DateTime?>(leitor["Dtultaltgiro"]);
        _dtultaltptabela = AlterarTipo<DateTime?>(leitor["Dtultaltptabela"]);
        _dtultaltptabelaatac = AlterarTipo<DateTime?>(leitor["Dtultaltptabelaatac"]);
        _dtultaltptabelaweb = AlterarTipo<DateTime?>(leitor["Dtultaltptabelaweb"]);
        _dtultaltpvenda = AlterarTipo<DateTime?>(leitor["Dtultaltpvenda"]);
        _dtultaltpvendaatac = AlterarTipo<DateTime?>(leitor["Dtultaltpvendaatac"]);
        _embalagem = AlterarTipo<string>(leitor["Embalagem"]);
        _enviabalanca = AlterarTipo<string>(leitor["Enviabalanca"]);
        _enviafrentecaixa = AlterarTipo<string>(leitor["Enviafrentecaixa"]);
        _enviafv = AlterarTipo<string>(leitor["Enviafv"]);
        _enviainfnutri = AlterarTipo<string>(leitor["Enviainfnutri"]);
        _enviatelemarketing = AlterarTipo<string>(leitor["Enviatelemarketing"]);
        _excluido = AlterarTipo<string>(leitor["Excluido"]);
        _exportacampo = AlterarTipo<string>(leitor["Exportacampo"]);
        _fatorconversao = AlterarTipo<decimal?>(leitor["Fatorconversao"]);
        _fatorpreco = AlterarTipo<decimal?>(leitor["Fatorpreco"]);
        _giromediodia = AlterarTipo<decimal?>(leitor["Giromediodia"]);
        _giromes = AlterarTipo<decimal?>(leitor["Giromes"]);
        _impdataembalagembalanca = AlterarTipo<string>(leitor["Impdataembalagembalanca"]);
        _impressaorestaurante = AlterarTipo<string>(leitor["Impressaorestaurante"]);
        _imprimerestaurante = AlterarTipo<string>(leitor["Imprimerestaurante"]);
        _indcvendecodinterno = AlterarTipo<string>(leitor["Indcvendecodinterno"]);
        _indicalertaquantidade = AlterarTipo<string>(leitor["Indicalertaquantidade"]);
        _indicgerarcodpesovar = AlterarTipo<string>(leitor["Indicgerarcodpesovar"]);
        _indicpermitedigitacaodesconto = AlterarTipo<string>(leitor["Indicpermitedigitacaodesconto"]);
        _indicpermitedigitacaopreco = AlterarTipo<string>(leitor["Indicpermitedigitacaopreco"]);
        _indicpermiteporprevenda = AlterarTipo<string>(leitor["Indicpermiteporprevenda"]);
        _indicpesagemobrigatoria = AlterarTipo<string>(leitor["Indicpesagemobrigatoria"]);
        _indicproducaopropria = AlterarTipo<string>(leitor["Indicproducaopropria"]);
        _infoprodweb = AlterarTipo<string>(leitor["Infoprodweb"]);
        _largura = AlterarTipo<decimal?>(leitor["Largura"]);
        _layoutetiqueta = AlterarTipo<string>(leitor["Layoutetiqueta"]);
        _margem = AlterarTipo<decimal?>(leitor["Margem"]);
        _margematac = AlterarTipo<decimal?>(leitor["Margematac"]);
        _margematac_esp = AlterarTipo<decimal?>(leitor["Margematac_Esp"]);
        _margemidealatac = AlterarTipo<decimal?>(leitor["Margemidealatac"]);
        _margem_esp = AlterarTipo<decimal?>(leitor["Margem_Esp"]);
        _motivooferta = AlterarTipo<string>(leitor["Motivooferta"]);
        _numseqatu = AlterarTipo<decimal?>(leitor["Numseqatu"]);
        _obrigaleituracodbarra = AlterarTipo<string>(leitor["Obrigaleituracodbarra"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _pcomext1 = AlterarTipo<decimal?>(leitor["Pcomext1"]);
        _pcomint1 = AlterarTipo<decimal?>(leitor["Pcomint1"]);
        _pcomrep1 = AlterarTipo<decimal?>(leitor["Pcomrep1"]);
        _perdesccartaofidelidade = AlterarTipo<decimal?>(leitor["Perdesccartaofidelidade"]);
        _permitemultiplicacao = AlterarTipo<string>(leitor["Permitemultiplicacao"]);
        _permitevendaatacado = AlterarTipo<string>(leitor["Permitevendaatacado"]);
        _permitevendacominterno = AlterarTipo<string>(leitor["Permitevendacominterno"]);
        _pervariacaoptabela = AlterarTipo<decimal?>(leitor["Pervariacaoptabela"]);
        _pesobruto = AlterarTipo<decimal?>(leitor["Pesobruto"]);
        _pesoliq = AlterarTipo<decimal?>(leitor["Pesoliq"]);
        _poferta = AlterarTipo<decimal?>(leitor["Poferta"]);
        _pofertaatac = AlterarTipo<decimal?>(leitor["Pofertaatac"]);
        _pofertaweb = AlterarTipo<decimal?>(leitor["Pofertaweb"]);
        _prazoval = AlterarTipo<decimal?>(leitor["Prazoval"]);
        _precoanterior = AlterarTipo<decimal?>(leitor["Precoanterior"]);
        _precoanterioratac = AlterarTipo<decimal>(leitor["Precoanterioratac"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _ptabelaant = AlterarTipo<decimal?>(leitor["Ptabelaant"]);
        _ptabelaatac = AlterarTipo<decimal>(leitor["Ptabelaatac"]);
        _ptabelaatacant = AlterarTipo<decimal?>(leitor["Ptabelaatacant"]);
        _ptabelaweb = AlterarTipo<decimal?>(leitor["Ptabelaweb"]);
        _ptabelawebant = AlterarTipo<decimal?>(leitor["Ptabelawebant"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _pvendaatac = AlterarTipo<decimal>(leitor["Pvendaatac"]);
        _pvendaweb = AlterarTipo<decimal?>(leitor["Pvendaweb"]);
        _pvendawebant = AlterarTipo<decimal?>(leitor["Pvendawebant"]);
        _qtdias = AlterarTipo<decimal?>(leitor["Qtdias"]);
        _qtemissaoetiq = AlterarTipo<decimal?>(leitor["Qtemissaoetiq"]);
        _qtfixamultipliccheckout = AlterarTipo<decimal?>(leitor["Qtfixamultipliccheckout"]);
        _qtmaxgondola = AlterarTipo<decimal?>(leitor["Qtmaxgondola"]);
        _qtmaxvenda = AlterarTipo<decimal?>(leitor["Qtmaxvenda"]);
        _qtmingondola = AlterarTipo<decimal?>(leitor["Qtmingondola"]);
        _qtminimaatacado = AlterarTipo<decimal?>(leitor["Qtminimaatacado"]);
        _qtminimaatacadof = AlterarTipo<decimal?>(leitor["Qtminimaatacadof"]);
        _qtmultipla = AlterarTipo<decimal?>(leitor["Qtmultipla"]);
        _qtunit = AlterarTipo<decimal?>(leitor["Qtunit"]);
        _situacaoweb = AlterarTipo<string>(leitor["Situacaoweb"]);
        _sociotorcedor = AlterarTipo<string>(leitor["Sociotorcedor"]);
        _taraf = AlterarTipo<decimal?>(leitor["Taraf"]);
        _tipoembalagem = AlterarTipo<string>(leitor["Tipoembalagem"]);
        _unidade = AlterarTipo<string>(leitor["Unidade"]);
        _unmedida = AlterarTipo<string>(leitor["Unmedida"]);
        _usabalancatoledo = AlterarTipo<string>(leitor["Usabalancatoledo"]);
        _usarestaurante = AlterarTipo<string>(leitor["Usarestaurante"]);
        _volume = AlterarTipo<decimal?>(leitor["Volume"]);
    }

}