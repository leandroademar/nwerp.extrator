

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPRESTPREFAT : GerenteDePropriedades, IEntidade
{
    private string _agrupado;

    private decimal? _alinea;

    private string _arqretorno;

    private string _baixaconciliada;

    private decimal? _bandeiracartao;

    private string _bloqdesdemitentedif;

    private string _boleto;

    private string _cartorio;

    private string _cgccpfch;

    private string _chequeterceiro;

    private string _cnpjcisp;

    private string _cnpjcredenccartao;

    private string _codadmcartao;

    private decimal? _codagentecobranca;

    private decimal? _codautorizacaotef;

    private decimal? _codbaixa;

    private decimal? _codbaixacartaorede;

    private decimal? _codbanco;

    private decimal? _codbancobaixa;

    private decimal? _codbancocm;

    private decimal? _codbancocm2;

    private decimal? _codbancocustodia;

    private decimal? _codbancovendor;

    private string _codbandeiratef;

    private string _codbarra;

    private string _codbarra2;

    private decimal? _codbcocustodia;

    private decimal? _codbloco;

    private decimal _codcli;

    private decimal? _codclicc;

    private string _codcob;

    private string _codcobbanco;

    private string _codcoborig;

    private string _codcobpos;

    private decimal? _codcobrador;

    private string _codcobsefaz;

    private decimal? _codcred;

    private decimal? _codedital;

    private decimal? _codemitentepedido;

    private decimal? _codepto;

    private string _codestabelecimento;

    private string _codfilial;

    private string _codfilialnf;

    private string _codfilialrec;

    private decimal? _codfuncbordero;

    private decimal? _codfunccheckout;

    private decimal? _codfuncconcil;

    private decimal? _codfuncconcilvenc;

    private decimal? _codfunccxmot;

    private decimal? _codfuncdesd;

    private decimal? _codfuncdesd1;

    private decimal? _codfuncdnicli;

    private decimal? _codfuncestorno;

    private decimal? _codfuncfecha;

    private decimal? _codfuncinc;

    private decimal? _codfuncliberacaoentrega;

    private decimal? _codfuncprorrog;

    private decimal? _codfuncultalter;

    private decimal? _codfuncvale;

    private decimal? _codfuncvend;

    private decimal? _codhistvale;

    private decimal? _codmotorista;

    private decimal? _codocorrbaixa;

    private decimal? _codportador;

    private decimal? _codprofissional;

    private decimal? _codstatuscob;

    private decimal? _codsupervisor;

    private decimal _codusur;

    private decimal? _codusur2;

    private decimal? _codusur3;

    private decimal? _codusur4;

    private decimal? _codusurant;

    private decimal? _codusurpgcomissao;

    private decimal? _compensacaobco;

    private decimal? _contratovendor;

    private string _correspondente;

    private string _credpagcomissmed;

    private string _dadosecf;

    private DateTime? _dataconsolidacaoprefat;

    private DateTime? _datahoraminutobaixa;

    private string _digitao;

    private DateTime? _dtaberturaconta;

    private DateTime? _dtassociadnicli;

    private DateTime? _dtbaixa;

    private DateTime? _dtbaixacred;

    private DateTime? _dtborder;

    private DateTime? _dtbordero;

    private DateTime? _dtcancel;

    private DateTime? _dtconcil;

    private DateTime? _dtconcilvenc;

    private DateTime? _dtcriacao;

    private DateTime? _dtcustodia;

    private DateTime? _dtcxmot;

    private DateTime? _dtcxmothhmmss;

    private DateTime? _dtdefagente;

    private DateTime? _dtdesc;

    private DateTime? _dtdescontado;

    private DateTime? _dtdescontotitbco;

    private DateTime? _dtdesd;

    private DateTime? _dtdevol;

    private DateTime _dtemissao;

    private DateTime? _dtemissaoorig;

    private DateTime? _dtenvioserasa;

    private DateTime? _dtestorno;

    private DateTime? _dtexportacaoservint;

    private DateTime? _dtfecha;

    private DateTime? _dtfechavendor;

    private DateTime? _dtimportacaoservprinc;

    private DateTime? _dtimpressao;

    private DateTime? _dtinclusao;

    private DateTime? _dtinclusaomanual;

    private DateTime? _dtlancch;

    private DateTime? _dtlancprorrog;

    private DateTime? _dtliberacaoentrega;

    private DateTime? _dtliberacaofechamento;

    private DateTime? _dtmovimentocx;

    private DateTime? _dtpag;

    private DateTime? _dtpagcomissao;

    private DateTime? _dtpagcomissao2;

    private DateTime? _dtpagcomissao3;

    private DateTime? _dtpagcomissao4;

    private DateTime? _dtpagcomissaoprof;

    private DateTime? _dtprocessamento;

    private DateTime? _dtrecebimentoprevisto;

    private DateTime? _dtregcarteira;

    private DateTime? _dtremvendor;

    private DateTime? _dtretiradaserasa;

    private DateTime? _dtsaida;

    private DateTime? _dttransacaocc;

    private DateTime? _dtultalter;

    private DateTime? _dtultestorno;

    private DateTime _dtvenc;

    private DateTime? _dtvencanterior;

    private DateTime _dtvencorig;

    private DateTime? _dtvencvale;

    private DateTime? _dtvendor;

    private decimal _duplic;

    private decimal? _dvagencia;

    private decimal? _dvcheque;

    private decimal? _dvcob;

    private decimal? _dvconta;

    private string _enviadoqis;

    private string _equiplanc;

    private string _exportadoservint;

    private string _factoring;

    private string _funclanc;

    private string _geracaorazaoauxiliar;

    private string _hash;

    private string _historigdesdobramento;

    private decimal? _hobpercommot;

    private decimal? _hobpercomsup;

    private decimal? _horadesd;

    private decimal? _horaestorno;

    private decimal? _horafecha;

    private decimal? _idcob;

    private decimal? _idpagamento;

    private decimal? _idpagamentolocal;

    private decimal? _idrespfiscal;

    private decimal? _idtitulo;

    private string _importadoservprinc;

    private string _linhadig;

    private string _linhadig2;

    private decimal? _minutodesd;

    private decimal? _minutoestorno;

    private decimal? _minutofecha;

    private string _nomearquivo;

    private string _nossonumbco;

    private string _nossonumbco2;

    private string _nsuhost;

    private string _nsutef;

    private decimal? _numagencia;

    private decimal? _numassocdni;

    private decimal? _numbanco;

    private decimal? _numbordero;

    private decimal? _numcaixafiscal;

    private decimal? _hubnumcaixapadrao;

    private decimal? _numcar;

    private decimal? _numcaranterior;

    private string _numcartao;

    private string _numcartaocrm;

    private decimal? _numcheckout;

    private decimal? _numcheque;

    private decimal? _numcontacorrente;

    private decimal? _numcustodia;

    private decimal? _numdiascarencia;

    private decimal? _numdiasprazoprotesto;

    private decimal? _numecf;

    private decimal? _numfechamentomovcx;

    private string _numlotecartaotef;

    private decimal? _numlotecustodia;

    private decimal? _numnegociacao;

    private decimal? _numos;

    private decimal? _numped;

    private string _numprotocolochq;

    private decimal? _numrecibo;

    private decimal? _numremessa;

    private string _numresumo;

    private decimal? _numseqretorno;

    private decimal? _numtrans;

    private decimal? _numtransent;

    private decimal? _numtransentdevcli;

    private decimal _numtransvenda;

    private decimal? _numtransvendast;

    private decimal? _numtransvendor;

    private string _obs;

    private string _obs2;

    private string _obscustodia;

    private string _obsfinanc;

    private string _obstitulo;

    private string _operacao;

    private string _origemboleto;

    private string _parcelamentotef;

    private string _pastaarquivoboleto;

    private string _pdv;

    private decimal? _percom;

    private decimal? _percom2;

    private decimal? _percom3;

    private decimal? _percom4;

    private decimal? _percomliq;

    private decimal? _percomsup;

    private decimal? _perdesc;

    private string _permiteestorno;

    private string _prest;

    private decimal? _presttef;

    private string _protesto;

    private decimal? _qtparcelaspos;

    private string _razaocredenccartao;

    private string _responsavelpag;

    private decimal? _rotdesd;

    private string _rotinadesd;

    private string _rotinafecha;

    private string _rotinainsert;

    private decimal? _rotinalanc;

    private string _rotinalancultalt;

    private string _rotinapag;

    private string _serialpos;

    private string _somatxboleto;

    private string _status;

    private string _statussci;

    private string _tipo;

    private string _tipoestorno;

    private string _tipooperacaotef;

    private string _tipooperedital;

    private string _tipoportador;

    private string _tipoprorrog;

    private string _tipovendordesc;

    private decimal? _txperm;

    private decimal? _txpermprevisto;

    private decimal? _txpermprevreal;

    private decimal? _txvendorbco;

    private decimal? _txvendorcli;

    private decimal _valor;

    private decimal? _valordesc;

    private decimal? _valordescorig;

    private decimal? _valorestorno;

    private decimal? _valorliqcom;

    private decimal? _valorliqcomsup;

    private decimal? _valormulta;

    private decimal? _valororig;

    private decimal? _versaohash;

    private decimal? _vlcontratovendor;

    private decimal? _vlcustodocvendor;

    private decimal? _vldevol;

    private decimal? _vlrcofinsorgpub;

    private decimal? _vlrcontsocialorgpub;

    private decimal? _vlrdespbancarias;

    private decimal? _vlrdespcartorais;

    private decimal? _vlricmsretorgpub;

    private decimal? _vlrimprendaorgpub;

    private decimal? _vlroutrasdeducoesorgpub;

    private decimal? _vlroutrosacresc;

    private decimal? _vlrpisorgpub;

    private decimal? _vlrtotdespesasejuros;

    private decimal? _vltroco;

    private decimal? _vltxboleto;

    private decimal? _vltxiof;

    private decimal? _vltxiofcomplementar;

    private decimal? _vltxvendor;

    private decimal? _vpago;

    private string _tipocorban;

    private string _processadortranspagdigital;

    private string _numtranspagdigital;

    private string _nsupagdigital;

    private string _carteiradigital;

    private string _nomecarteiradigital;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agrupado
    {
        get
        {
            PropriedadeAcessada("Agrupado");
            return _agrupado;
        }
        set
        {
            PropriedadeModificada("Agrupado", value);
            _agrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Alinea
    {
        get
        {
            PropriedadeAcessada("Alinea");
            return _alinea;
        }
        set
        {
            PropriedadeModificada("Alinea", value);
            _alinea = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
    public string Arqretorno
    {
        get
        {
            PropriedadeAcessada("Arqretorno");
            return _arqretorno;
        }
        set
        {
            PropriedadeModificada("Arqretorno", value);
            _arqretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixaconciliada
    {
        get
        {
            PropriedadeAcessada("Baixaconciliada");
            return _baixaconciliada;
        }
        set
        {
            PropriedadeModificada("Baixaconciliada", value);
            _baixaconciliada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Bandeiracartao
    {
        get
        {
            PropriedadeAcessada("Bandeiracartao");
            return _bandeiracartao;
        }
        set
        {
            PropriedadeModificada("Bandeiracartao", value);
            _bandeiracartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqdesdemitentedif
    {
        get
        {
            PropriedadeAcessada("Bloqdesdemitentedif");
            return _bloqdesdemitentedif;
        }
        set
        {
            PropriedadeModificada("Bloqdesdemitentedif", value);
            _bloqdesdemitentedif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Boleto
    {
        get
        {
            PropriedadeAcessada("Boleto");
            return _boleto;
        }
        set
        {
            PropriedadeModificada("Boleto", value);
            _boleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cartorio
    {
        get
        {
            PropriedadeAcessada("Cartorio");
            return _cartorio;
        }
        set
        {
            PropriedadeModificada("Cartorio", value);
            _cartorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cgccpfch
    {
        get
        {
            PropriedadeAcessada("Cgccpfch");
            return _cgccpfch;
        }
        set
        {
            PropriedadeModificada("Cgccpfch", value);
            _cgccpfch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Chequeterceiro
    {
        get
        {
            PropriedadeAcessada("Chequeterceiro");
            return _chequeterceiro;
        }
        set
        {
            PropriedadeModificada("Chequeterceiro", value);
            _chequeterceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Cnpjcisp
    {
        get
        {
            PropriedadeAcessada("Cnpjcisp");
            return _cnpjcisp;
        }
        set
        {
            PropriedadeModificada("Cnpjcisp", value);
            _cnpjcisp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
    public string Cnpjcredenccartao
    {
        get
        {
            PropriedadeAcessada("Cnpjcredenccartao");
            return _cnpjcredenccartao;
        }
        set
        {
            PropriedadeModificada("Cnpjcredenccartao", value);
            _cnpjcredenccartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
    public string Codadmcartao
    {
        get
        {
            PropriedadeAcessada("Codadmcartao");
            return _codadmcartao;
        }
        set
        {
            PropriedadeModificada("Codadmcartao", value);
            _codadmcartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codagentecobranca
    {
        get
        {
            PropriedadeAcessada("Codagentecobranca");
            return _codagentecobranca;
        }
        set
        {
            PropriedadeModificada("Codagentecobranca", value);
            _codagentecobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Codautorizacaotef
    {
        get
        {
            PropriedadeAcessada("Codautorizacaotef");
            return _codautorizacaotef;
        }
        set
        {
            PropriedadeModificada("Codautorizacaotef", value);
            _codautorizacaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codbaixa
    {
        get
        {
            PropriedadeAcessada("Codbaixa");
            return _codbaixa;
        }
        set
        {
            PropriedadeModificada("Codbaixa", value);
            _codbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codbaixacartaorede
    {
        get
        {
            PropriedadeAcessada("Codbaixacartaorede");
            return _codbaixacartaorede;
        }
        set
        {
            PropriedadeModificada("Codbaixacartaorede", value);
            _codbaixacartaorede = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbanco
    {
        get
        {
            PropriedadeAcessada("Codbanco");
            return _codbanco;
        }
        set
        {
            PropriedadeModificada("Codbanco", value);
            _codbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbancobaixa
    {
        get
        {
            PropriedadeAcessada("Codbancobaixa");
            return _codbancobaixa;
        }
        set
        {
            PropriedadeModificada("Codbancobaixa", value);
            _codbancobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocm
    {
        get
        {
            PropriedadeAcessada("Codbancocm");
            return _codbancocm;
        }
        set
        {
            PropriedadeModificada("Codbancocm", value);
            _codbancocm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocm2
    {
        get
        {
            PropriedadeAcessada("Codbancocm2");
            return _codbancocm2;
        }
        set
        {
            PropriedadeModificada("Codbancocm2", value);
            _codbancocm2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocustodia
    {
        get
        {
            PropriedadeAcessada("Codbancocustodia");
            return _codbancocustodia;
        }
        set
        {
            PropriedadeModificada("Codbancocustodia", value);
            _codbancocustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancovendor
    {
        get
        {
            PropriedadeAcessada("Codbancovendor");
            return _codbancovendor;
        }
        set
        {
            PropriedadeModificada("Codbancovendor", value);
            _codbancovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
    public string Codbandeiratef
    {
        get
        {
            PropriedadeAcessada("Codbandeiratef");
            return _codbandeiratef;
        }
        set
        {
            PropriedadeModificada("Codbandeiratef", value);
            _codbandeiratef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Codbarra
    {
        get
        {
            PropriedadeAcessada("Codbarra");
            return _codbarra;
        }
        set
        {
            PropriedadeModificada("Codbarra", value);
            _codbarra = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Codbarra2
    {
        get
        {
            PropriedadeAcessada("Codbarra2");
            return _codbarra2;
        }
        set
        {
            PropriedadeModificada("Codbarra2", value);
            _codbarra2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbcocustodia
    {
        get
        {
            PropriedadeAcessada("Codbcocustodia");
            return _codbcocustodia;
        }
        set
        {
            PropriedadeModificada("Codbcocustodia", value);
            _codbcocustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Codbloco
    {
        get
        {
            PropriedadeAcessada("Codbloco");
            return _codbloco;
        }
        set
        {
            PropriedadeModificada("Codbloco", value);
            _codbloco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codcli
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codclicc
    {
        get
        {
            PropriedadeAcessada("Codclicc");
            return _codclicc;
        }
        set
        {
            PropriedadeModificada("Codclicc", value);
            _codclicc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcob
    {
        get
        {
            PropriedadeAcessada("Codcob");
            return _codcob;
        }
        set
        {
            PropriedadeModificada("Codcob", value);
            _codcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobbanco
    {
        get
        {
            PropriedadeAcessada("Codcobbanco");
            return _codcobbanco;
        }
        set
        {
            PropriedadeModificada("Codcobbanco", value);
            _codcobbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcoborig
    {
        get
        {
            PropriedadeAcessada("Codcoborig");
            return _codcoborig;
        }
        set
        {
            PropriedadeModificada("Codcoborig", value);
            _codcoborig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobpos
    {
        get
        {
            PropriedadeAcessada("Codcobpos");
            return _codcobpos;
        }
        set
        {
            PropriedadeModificada("Codcobpos", value);
            _codcobpos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcobrador
    {
        get
        {
            PropriedadeAcessada("Codcobrador");
            return _codcobrador;
        }
        set
        {
            PropriedadeModificada("Codcobrador", value);
            _codcobrador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobsefaz
    {
        get
        {
            PropriedadeAcessada("Codcobsefaz");
            return _codcobsefaz;
        }
        set
        {
            PropriedadeModificada("Codcobsefaz", value);
            _codcobsefaz = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcred
    {
        get
        {
            PropriedadeAcessada("Codcred");
            return _codcred;
        }
        set
        {
            PropriedadeModificada("Codcred", value);
            _codcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 9, Precisao = 0)]
    public decimal? Codedital
    {
        get
        {
            PropriedadeAcessada("Codedital");
            return _codedital;
        }
        set
        {
            PropriedadeModificada("Codedital", value);
            _codedital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitentepedido
    {
        get
        {
            PropriedadeAcessada("Codemitentepedido");
            return _codemitentepedido;
        }
        set
        {
            PropriedadeModificada("Codemitentepedido", value);
            _codemitentepedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
    {
        get
        {
            PropriedadeAcessada("Codepto");
            return _codepto;
        }
        set
        {
            PropriedadeModificada("Codepto", value);
            _codepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codestabelecimento
    {
        get
        {
            PropriedadeAcessada("Codestabelecimento");
            return _codestabelecimento;
        }
        set
        {
            PropriedadeModificada("Codestabelecimento", value);
            _codestabelecimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilial
    {
        get
        {
            PropriedadeAcessada("Codfilial");
            return _codfilial;
        }
        set
        {
            PropriedadeModificada("Codfilial", value);
            _codfilial = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialnf
    {
        get
        {
            PropriedadeAcessada("Codfilialnf");
            return _codfilialnf;
        }
        set
        {
            PropriedadeModificada("Codfilialnf", value);
            _codfilialnf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Codfilialrec
    {
        get
        {
            PropriedadeAcessada("Codfilialrec");
            return _codfilialrec;
        }
        set
        {
            PropriedadeModificada("Codfilialrec", value);
            _codfilialrec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncbordero
    {
        get
        {
            PropriedadeAcessada("Codfuncbordero");
            return _codfuncbordero;
        }
        set
        {
            PropriedadeModificada("Codfuncbordero", value);
            _codfuncbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccheckout
    {
        get
        {
            PropriedadeAcessada("Codfunccheckout");
            return _codfunccheckout;
        }
        set
        {
            PropriedadeModificada("Codfunccheckout", value);
            _codfunccheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconcil
    {
        get
        {
            PropriedadeAcessada("Codfuncconcil");
            return _codfuncconcil;
        }
        set
        {
            PropriedadeModificada("Codfuncconcil", value);
            _codfuncconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconcilvenc
    {
        get
        {
            PropriedadeAcessada("Codfuncconcilvenc");
            return _codfuncconcilvenc;
        }
        set
        {
            PropriedadeModificada("Codfuncconcilvenc", value);
            _codfuncconcilvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccxmot
    {
        get
        {
            PropriedadeAcessada("Codfunccxmot");
            return _codfunccxmot;
        }
        set
        {
            PropriedadeModificada("Codfunccxmot", value);
            _codfunccxmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncdesd
    {
        get
        {
            PropriedadeAcessada("Codfuncdesd");
            return _codfuncdesd;
        }
        set
        {
            PropriedadeModificada("Codfuncdesd", value);
            _codfuncdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncdesd1
    {
        get
        {
            PropriedadeAcessada("Codfuncdesd1");
            return _codfuncdesd1;
        }
        set
        {
            PropriedadeModificada("Codfuncdesd1", value);
            _codfuncdesd1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfuncdnicli
    {
        get
        {
            PropriedadeAcessada("Codfuncdnicli");
            return _codfuncdnicli;
        }
        set
        {
            PropriedadeModificada("Codfuncdnicli", value);
            _codfuncdnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncestorno
    {
        get
        {
            PropriedadeAcessada("Codfuncestorno");
            return _codfuncestorno;
        }
        set
        {
            PropriedadeModificada("Codfuncestorno", value);
            _codfuncestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfecha
    {
        get
        {
            PropriedadeAcessada("Codfuncfecha");
            return _codfuncfecha;
        }
        set
        {
            PropriedadeModificada("Codfuncfecha", value);
            _codfuncfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncinc
    {
        get
        {
            PropriedadeAcessada("Codfuncinc");
            return _codfuncinc;
        }
        set
        {
            PropriedadeModificada("Codfuncinc", value);
            _codfuncinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncliberacaoentrega
    {
        get
        {
            PropriedadeAcessada("Codfuncliberacaoentrega");
            return _codfuncliberacaoentrega;
        }
        set
        {
            PropriedadeModificada("Codfuncliberacaoentrega", value);
            _codfuncliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncprorrog
    {
        get
        {
            PropriedadeAcessada("Codfuncprorrog");
            return _codfuncprorrog;
        }
        set
        {
            PropriedadeModificada("Codfuncprorrog", value);
            _codfuncprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada("Codfuncultalter");
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada("Codfuncultalter", value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncvale
    {
        get
        {
            PropriedadeAcessada("Codfuncvale");
            return _codfuncvale;
        }
        set
        {
            PropriedadeModificada("Codfuncvale", value);
            _codfuncvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncvend
    {
        get
        {
            PropriedadeAcessada("Codfuncvend");
            return _codfuncvend;
        }
        set
        {
            PropriedadeModificada("Codfuncvend", value);
            _codfuncvend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhistvale
    {
        get
        {
            PropriedadeAcessada("Codhistvale");
            return _codhistvale;
        }
        set
        {
            PropriedadeModificada("Codhistvale", value);
            _codhistvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada("Codmotorista");
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada("Codmotorista", value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codocorrbaixa
    {
        get
        {
            PropriedadeAcessada("Codocorrbaixa");
            return _codocorrbaixa;
        }
        set
        {
            PropriedadeModificada("Codocorrbaixa", value);
            _codocorrbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codportador
    {
        get
        {
            PropriedadeAcessada("Codportador");
            return _codportador;
        }
        set
        {
            PropriedadeModificada("Codportador", value);
            _codportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprofissional
    {
        get
        {
            PropriedadeAcessada("Codprofissional");
            return _codprofissional;
        }
        set
        {
            PropriedadeModificada("Codprofissional", value);
            _codprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codstatuscob
    {
        get
        {
            PropriedadeAcessada("Codstatuscob");
            return _codstatuscob;
        }
        set
        {
            PropriedadeModificada("Codstatuscob", value);
            _codstatuscob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codsupervisor
    {
        get
        {
            PropriedadeAcessada("Codsupervisor");
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada("Codsupervisor", value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada("Codusur");
            return _codusur;
        }
        set
        {
            PropriedadeModificada("Codusur", value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur2
    {
        get
        {
            PropriedadeAcessada("Codusur2");
            return _codusur2;
        }
        set
        {
            PropriedadeModificada("Codusur2", value);
            _codusur2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur3
    {
        get
        {
            PropriedadeAcessada("Codusur3");
            return _codusur3;
        }
        set
        {
            PropriedadeModificada("Codusur3", value);
            _codusur3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codusur4
    {
        get
        {
            PropriedadeAcessada("Codusur4");
            return _codusur4;
        }
        set
        {
            PropriedadeModificada("Codusur4", value);
            _codusur4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusurant
    {
        get
        {
            PropriedadeAcessada("Codusurant");
            return _codusurant;
        }
        set
        {
            PropriedadeModificada("Codusurant", value);
            _codusurant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusurpgcomissao
    {
        get
        {
            PropriedadeAcessada("Codusurpgcomissao");
            return _codusurpgcomissao;
        }
        set
        {
            PropriedadeModificada("Codusurpgcomissao", value);
            _codusurpgcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Compensacaobco
    {
        get
        {
            PropriedadeAcessada("Compensacaobco");
            return _compensacaobco;
        }
        set
        {
            PropriedadeModificada("Compensacaobco", value);
            _compensacaobco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Contratovendor
    {
        get
        {
            PropriedadeAcessada("Contratovendor");
            return _contratovendor;
        }
        set
        {
            PropriedadeModificada("Contratovendor", value);
            _contratovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Correspondente
    {
        get
        {
            PropriedadeAcessada("Correspondente");
            return _correspondente;
        }
        set
        {
            PropriedadeModificada("Correspondente", value);
            _correspondente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Credpagcomissmed
    {
        get
        {
            PropriedadeAcessada("Credpagcomissmed");
            return _credpagcomissmed;
        }
        set
        {
            PropriedadeModificada("Credpagcomissmed", value);
            _credpagcomissmed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dadosecf
    {
        get
        {
            PropriedadeAcessada("Dadosecf");
            return _dadosecf;
        }
        set
        {
            PropriedadeModificada("Dadosecf", value);
            _dadosecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dataconsolidacaoprefat
    {
        get
        {
            PropriedadeAcessada("Dataconsolidacaoprefat");
            return _dataconsolidacaoprefat;
        }
        set
        {
            PropriedadeModificada("Dataconsolidacaoprefat", value);
            _dataconsolidacaoprefat = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraminutobaixa
    {
        get
        {
            PropriedadeAcessada("Datahoraminutobaixa");
            return _datahoraminutobaixa;
        }
        set
        {
            PropriedadeModificada("Datahoraminutobaixa", value);
            _datahoraminutobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Digitao
    {
        get
        {
            PropriedadeAcessada("Digitao");
            return _digitao;
        }
        set
        {
            PropriedadeModificada("Digitao", value);
            _digitao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaberturaconta
    {
        get
        {
            PropriedadeAcessada("Dtaberturaconta");
            return _dtaberturaconta;
        }
        set
        {
            PropriedadeModificada("Dtaberturaconta", value);
            _dtaberturaconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtassociadnicli
    {
        get
        {
            PropriedadeAcessada("Dtassociadnicli");
            return _dtassociadnicli;
        }
        set
        {
            PropriedadeModificada("Dtassociadnicli", value);
            _dtassociadnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbaixa
    {
        get
        {
            PropriedadeAcessada("Dtbaixa");
            return _dtbaixa;
        }
        set
        {
            PropriedadeModificada("Dtbaixa", value);
            _dtbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbaixacred
    {
        get
        {
            PropriedadeAcessada("Dtbaixacred");
            return _dtbaixacred;
        }
        set
        {
            PropriedadeModificada("Dtbaixacred", value);
            _dtbaixacred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtborder
    {
        get
        {
            PropriedadeAcessada("Dtborder");
            return _dtborder;
        }
        set
        {
            PropriedadeModificada("Dtborder", value);
            _dtborder = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbordero
    {
        get
        {
            PropriedadeAcessada("Dtbordero");
            return _dtbordero;
        }
        set
        {
            PropriedadeModificada("Dtbordero", value);
            _dtbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada("Dtcancel");
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada("Dtcancel", value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcil
    {
        get
        {
            PropriedadeAcessada("Dtconcil");
            return _dtconcil;
        }
        set
        {
            PropriedadeModificada("Dtconcil", value);
            _dtconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcilvenc
    {
        get
        {
            PropriedadeAcessada("Dtconcilvenc");
            return _dtconcilvenc;
        }
        set
        {
            PropriedadeModificada("Dtconcilvenc", value);
            _dtconcilvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcriacao
    {
        get
        {
            PropriedadeAcessada("Dtcriacao");
            return _dtcriacao;
        }
        set
        {
            PropriedadeModificada("Dtcriacao", value);
            _dtcriacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcustodia
    {
        get
        {
            PropriedadeAcessada("Dtcustodia");
            return _dtcustodia;
        }
        set
        {
            PropriedadeModificada("Dtcustodia", value);
            _dtcustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcxmot
    {
        get
        {
            PropriedadeAcessada("Dtcxmot");
            return _dtcxmot;
        }
        set
        {
            PropriedadeModificada("Dtcxmot", value);
            _dtcxmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcxmothhmmss
    {
        get
        {
            PropriedadeAcessada("Dtcxmothhmmss");
            return _dtcxmothhmmss;
        }
        set
        {
            PropriedadeModificada("Dtcxmothhmmss", value);
            _dtcxmothhmmss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdefagente
    {
        get
        {
            PropriedadeAcessada("Dtdefagente");
            return _dtdefagente;
        }
        set
        {
            PropriedadeModificada("Dtdefagente", value);
            _dtdefagente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesc
    {
        get
        {
            PropriedadeAcessada("Dtdesc");
            return _dtdesc;
        }
        set
        {
            PropriedadeModificada("Dtdesc", value);
            _dtdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdescontado
    {
        get
        {
            PropriedadeAcessada("Dtdescontado");
            return _dtdescontado;
        }
        set
        {
            PropriedadeModificada("Dtdescontado", value);
            _dtdescontado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdescontotitbco
    {
        get
        {
            PropriedadeAcessada("Dtdescontotitbco");
            return _dtdescontotitbco;
        }
        set
        {
            PropriedadeModificada("Dtdescontotitbco", value);
            _dtdescontotitbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesd
    {
        get
        {
            PropriedadeAcessada("Dtdesd");
            return _dtdesd;
        }
        set
        {
            PropriedadeModificada("Dtdesd", value);
            _dtdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdevol
    {
        get
        {
            PropriedadeAcessada("Dtdevol");
            return _dtdevol;
        }
        set
        {
            PropriedadeModificada("Dtdevol", value);
            _dtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtemissao
    {
        get
        {
            PropriedadeAcessada("Dtemissao");
            return _dtemissao;
        }
        set
        {
            PropriedadeModificada("Dtemissao", value);
            _dtemissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoorig
    {
        get
        {
            PropriedadeAcessada("Dtemissaoorig");
            return _dtemissaoorig;
        }
        set
        {
            PropriedadeModificada("Dtemissaoorig", value);
            _dtemissaoorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtenvioserasa
    {
        get
        {
            PropriedadeAcessada("Dtenvioserasa");
            return _dtenvioserasa;
        }
        set
        {
            PropriedadeModificada("Dtenvioserasa", value);
            _dtenvioserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestorno
    {
        get
        {
            PropriedadeAcessada("Dtestorno");
            return _dtestorno;
        }
        set
        {
            PropriedadeModificada("Dtestorno", value);
            _dtestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada("Dtexportacaoservint");
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada("Dtexportacaoservint", value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada("Dtfecha");
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada("Dtfecha", value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechavendor
    {
        get
        {
            PropriedadeAcessada("Dtfechavendor");
            return _dtfechavendor;
        }
        set
        {
            PropriedadeModificada("Dtfechavendor", value);
            _dtfechavendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada("Dtimportacaoservprinc");
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada("Dtimportacaoservprinc", value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimpressao
    {
        get
        {
            PropriedadeAcessada("Dtimpressao");
            return _dtimpressao;
        }
        set
        {
            PropriedadeModificada("Dtimpressao", value);
            _dtimpressao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinclusao
    {
        get
        {
            PropriedadeAcessada("Dtinclusao");
            return _dtinclusao;
        }
        set
        {
            PropriedadeModificada("Dtinclusao", value);
            _dtinclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinclusaomanual
    {
        get
        {
            PropriedadeAcessada("Dtinclusaomanual");
            return _dtinclusaomanual;
        }
        set
        {
            PropriedadeModificada("Dtinclusaomanual", value);
            _dtinclusaomanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancch
    {
        get
        {
            PropriedadeAcessada("Dtlancch");
            return _dtlancch;
        }
        set
        {
            PropriedadeModificada("Dtlancch", value);
            _dtlancch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancprorrog
    {
        get
        {
            PropriedadeAcessada("Dtlancprorrog");
            return _dtlancprorrog;
        }
        set
        {
            PropriedadeModificada("Dtlancprorrog", value);
            _dtlancprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaoentrega
    {
        get
        {
            PropriedadeAcessada("Dtliberacaoentrega");
            return _dtliberacaoentrega;
        }
        set
        {
            PropriedadeModificada("Dtliberacaoentrega", value);
            _dtliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaofechamento
    {
        get
        {
            PropriedadeAcessada("Dtliberacaofechamento");
            return _dtliberacaofechamento;
        }
        set
        {
            PropriedadeModificada("Dtliberacaofechamento", value);
            _dtliberacaofechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtmovimentocx
    {
        get
        {
            PropriedadeAcessada("Dtmovimentocx");
            return _dtmovimentocx;
        }
        set
        {
            PropriedadeModificada("Dtmovimentocx", value);
            _dtmovimentocx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpag
    {
        get
        {
            PropriedadeAcessada("Dtpag");
            return _dtpag;
        }
        set
        {
            PropriedadeModificada("Dtpag", value);
            _dtpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao");
            return _dtpagcomissao;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao", value);
            _dtpagcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao2
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao2");
            return _dtpagcomissao2;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao2", value);
            _dtpagcomissao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao3
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao3");
            return _dtpagcomissao3;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao3", value);
            _dtpagcomissao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao4
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissao4");
            return _dtpagcomissao4;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissao4", value);
            _dtpagcomissao4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoprof
    {
        get
        {
            PropriedadeAcessada("Dtpagcomissaoprof");
            return _dtpagcomissaoprof;
        }
        set
        {
            PropriedadeModificada("Dtpagcomissaoprof", value);
            _dtpagcomissaoprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprocessamento
    {
        get
        {
            PropriedadeAcessada("Dtprocessamento");
            return _dtprocessamento;
        }
        set
        {
            PropriedadeModificada("Dtprocessamento", value);
            _dtprocessamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtrecebimentoprevisto
    {
        get
        {
            PropriedadeAcessada("Dtrecebimentoprevisto");
            return _dtrecebimentoprevisto;
        }
        set
        {
            PropriedadeModificada("Dtrecebimentoprevisto", value);
            _dtrecebimentoprevisto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtregcarteira
    {
        get
        {
            PropriedadeAcessada("Dtregcarteira");
            return _dtregcarteira;
        }
        set
        {
            PropriedadeModificada("Dtregcarteira", value);
            _dtregcarteira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtremvendor
    {
        get
        {
            PropriedadeAcessada("Dtremvendor");
            return _dtremvendor;
        }
        set
        {
            PropriedadeModificada("Dtremvendor", value);
            _dtremvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtretiradaserasa
    {
        get
        {
            PropriedadeAcessada("Dtretiradaserasa");
            return _dtretiradaserasa;
        }
        set
        {
            PropriedadeModificada("Dtretiradaserasa", value);
            _dtretiradaserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaida
    {
        get
        {
            PropriedadeAcessada("Dtsaida");
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada("Dtsaida", value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dttransacaocc
    {
        get
        {
            PropriedadeAcessada("Dttransacaocc");
            return _dttransacaocc;
        }
        set
        {
            PropriedadeModificada("Dttransacaocc", value);
            _dttransacaocc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalter
    {
        get
        {
            PropriedadeAcessada("Dtultalter");
            return _dtultalter;
        }
        set
        {
            PropriedadeModificada("Dtultalter", value);
            _dtultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultestorno
    {
        get
        {
            PropriedadeAcessada("Dtultestorno");
            return _dtultestorno;
        }
        set
        {
            PropriedadeModificada("Dtultestorno", value);
            _dtultestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtvenc
    {
        get
        {
            PropriedadeAcessada("Dtvenc");
            return _dtvenc;
        }
        set
        {
            PropriedadeModificada("Dtvenc", value);
            _dtvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencanterior
    {
        get
        {
            PropriedadeAcessada("Dtvencanterior");
            return _dtvencanterior;
        }
        set
        {
            PropriedadeModificada("Dtvencanterior", value);
            _dtvencanterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime Dtvencorig
    {
        get
        {
            PropriedadeAcessada("Dtvencorig");
            return _dtvencorig;
        }
        set
        {
            PropriedadeModificada("Dtvencorig", value);
            _dtvencorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencvale
    {
        get
        {
            PropriedadeAcessada("Dtvencvale");
            return _dtvencvale;
        }
        set
        {
            PropriedadeModificada("Dtvencvale", value);
            _dtvencvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvendor
    {
        get
        {
            PropriedadeAcessada("Dtvendor");
            return _dtvendor;
        }
        set
        {
            PropriedadeModificada("Dtvendor", value);
            _dtvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Duplic
    {
        get
        {
            PropriedadeAcessada("Duplic");
            return _duplic;
        }
        set
        {
            PropriedadeModificada("Duplic", value);
            _duplic = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dvagencia
    {
        get
        {
            PropriedadeAcessada("Dvagencia");
            return _dvagencia;
        }
        set
        {
            PropriedadeModificada("Dvagencia", value);
            _dvagencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dvcheque
    {
        get
        {
            PropriedadeAcessada("Dvcheque");
            return _dvcheque;
        }
        set
        {
            PropriedadeModificada("Dvcheque", value);
            _dvcheque = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dvcob
    {
        get
        {
            PropriedadeAcessada("Dvcob");
            return _dvcob;
        }
        set
        {
            PropriedadeModificada("Dvcob", value);
            _dvcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dvconta
    {
        get
        {
            PropriedadeAcessada("Dvconta");
            return _dvconta;
        }
        set
        {
            PropriedadeModificada("Dvconta", value);
            _dvconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadoqis
    {
        get
        {
            PropriedadeAcessada("Enviadoqis");
            return _enviadoqis;
        }
        set
        {
            PropriedadeModificada("Enviadoqis", value);
            _enviadoqis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Equiplanc
    {
        get
        {
            PropriedadeAcessada("Equiplanc");
            return _equiplanc;
        }
        set
        {
            PropriedadeModificada("Equiplanc", value);
            _equiplanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada("Exportadoservint");
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada("Exportadoservint", value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Factoring
    {
        get
        {
            PropriedadeAcessada("Factoring");
            return _factoring;
        }
        set
        {
            PropriedadeModificada("Factoring", value);
            _factoring = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Funclanc
    {
        get
        {
            PropriedadeAcessada("Funclanc");
            return _funclanc;
        }
        set
        {
            PropriedadeModificada("Funclanc", value);
            _funclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracaorazaoauxiliar
    {
        get
        {
            PropriedadeAcessada("Geracaorazaoauxiliar");
            return _geracaorazaoauxiliar;
        }
        set
        {
            PropriedadeModificada("Geracaorazaoauxiliar", value);
            _geracaorazaoauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 32, Precisao = 0)]
    public string Hash
    {
        get
        {
            PropriedadeAcessada("Hash");
            return _hash;
        }
        set
        {
            PropriedadeModificada("Hash", value);
            _hash = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1000, Precisao = 0)]
    public string Historigdesdobramento
    {
        get
        {
            PropriedadeAcessada("Historigdesdobramento");
            return _historigdesdobramento;
        }
        set
        {
            PropriedadeModificada("Historigdesdobramento", value);
            _historigdesdobramento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Hobpercommot
    {
        get
        {
            PropriedadeAcessada("Hobpercommot");
            return _hobpercommot;
        }
        set
        {
            PropriedadeModificada("Hobpercommot", value);
            _hobpercommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Hobpercomsup
    {
        get
        {
            PropriedadeAcessada("Hobpercomsup");
            return _hobpercomsup;
        }
        set
        {
            PropriedadeModificada("Hobpercomsup", value);
            _hobpercomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horadesd
    {
        get
        {
            PropriedadeAcessada("Horadesd");
            return _horadesd;
        }
        set
        {
            PropriedadeModificada("Horadesd", value);
            _horadesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaestorno
    {
        get
        {
            PropriedadeAcessada("Horaestorno");
            return _horaestorno;
        }
        set
        {
            PropriedadeModificada("Horaestorno", value);
            _horaestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafecha
    {
        get
        {
            PropriedadeAcessada("Horafecha");
            return _horafecha;
        }
        set
        {
            PropriedadeModificada("Horafecha", value);
            _horafecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Idcob
    {
        get
        {
            PropriedadeAcessada("Idcob");
            return _idcob;
        }
        set
        {
            PropriedadeModificada("Idcob", value);
            _idcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Idpagamento
    {
        get
        {
            PropriedadeAcessada("Idpagamento");
            return _idpagamento;
        }
        set
        {
            PropriedadeModificada("Idpagamento", value);
            _idpagamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Idpagamentolocal
    {
        get
        {
            PropriedadeAcessada("Idpagamentolocal");
            return _idpagamentolocal;
        }
        set
        {
            PropriedadeModificada("Idpagamentolocal", value);
            _idpagamentolocal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Idrespfiscal
    {
        get
        {
            PropriedadeAcessada("Idrespfiscal");
            return _idrespfiscal;
        }
        set
        {
            PropriedadeModificada("Idrespfiscal", value);
            _idrespfiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Idtitulo
    {
        get
        {
            PropriedadeAcessada("Idtitulo");
            return _idtitulo;
        }
        set
        {
            PropriedadeModificada("Idtitulo", value);
            _idtitulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada("Importadoservprinc");
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada("Importadoservprinc", value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 65, Precisao = 0)]
    public string Linhadig
    {
        get
        {
            PropriedadeAcessada("Linhadig");
            return _linhadig;
        }
        set
        {
            PropriedadeModificada("Linhadig", value);
            _linhadig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 65, Precisao = 0)]
    public string Linhadig2
    {
        get
        {
            PropriedadeAcessada("Linhadig2");
            return _linhadig2;
        }
        set
        {
            PropriedadeModificada("Linhadig2", value);
            _linhadig2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutodesd
    {
        get
        {
            PropriedadeAcessada("Minutodesd");
            return _minutodesd;
        }
        set
        {
            PropriedadeModificada("Minutodesd", value);
            _minutodesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoestorno
    {
        get
        {
            PropriedadeAcessada("Minutoestorno");
            return _minutoestorno;
        }
        set
        {
            PropriedadeModificada("Minutoestorno", value);
            _minutoestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofecha
    {
        get
        {
            PropriedadeAcessada("Minutofecha");
            return _minutofecha;
        }
        set
        {
            PropriedadeModificada("Minutofecha", value);
            _minutofecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Nomearquivo
    {
        get
        {
            PropriedadeAcessada("Nomearquivo");
            return _nomearquivo;
        }
        set
        {
            PropriedadeModificada("Nomearquivo", value);
            _nomearquivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nossonumbco
    {
        get
        {
            PropriedadeAcessada("Nossonumbco");
            return _nossonumbco;
        }
        set
        {
            PropriedadeModificada("Nossonumbco", value);
            _nossonumbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nossonumbco2
    {
        get
        {
            PropriedadeAcessada("Nossonumbco2");
            return _nossonumbco2;
        }
        set
        {
            PropriedadeModificada("Nossonumbco2", value);
            _nossonumbco2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsuhost
    {
        get
        {
            PropriedadeAcessada("Nsuhost");
            return _nsuhost;
        }
        set
        {
            PropriedadeModificada("Nsuhost", value);
            _nsuhost = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nsutef
    {
        get
        {
            PropriedadeAcessada("Nsutef");
            return _nsutef;
        }
        set
        {
            PropriedadeModificada("Nsutef", value);
            _nsutef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numagencia
    {
        get
        {
            PropriedadeAcessada("Numagencia");
            return _numagencia;
        }
        set
        {
            PropriedadeModificada("Numagencia", value);
            _numagencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numassocdni
    {
        get
        {
            PropriedadeAcessada("Numassocdni");
            return _numassocdni;
        }
        set
        {
            PropriedadeModificada("Numassocdni", value);
            _numassocdni = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numbanco
    {
        get
        {
            PropriedadeAcessada("Numbanco");
            return _numbanco;
        }
        set
        {
            PropriedadeModificada("Numbanco", value);
            _numbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numbordero
    {
        get
        {
            PropriedadeAcessada("Numbordero");
            return _numbordero;
        }
        set
        {
            PropriedadeModificada("Numbordero", value);
            _numbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numcaixafiscal
    {
        get
        {
            PropriedadeAcessada("Numcaixafiscal");
            return _numcaixafiscal;
        }
        set
        {
            PropriedadeModificada("Numcaixafiscal", value);
            _numcaixafiscal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Hubnumcaixapadrao
    {
        get
        {
            PropriedadeAcessada("Hubnumcaixapadrao");
            return _hubnumcaixapadrao;
        }
        set
        {
            PropriedadeModificada("Hubnumcaixapadrao", value);
            _hubnumcaixapadrao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcar
    {
        get
        {
            PropriedadeAcessada("Numcar");
            return _numcar;
        }
        set
        {
            PropriedadeModificada("Numcar", value);
            _numcar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaranterior
    {
        get
        {
            PropriedadeAcessada("Numcaranterior");
            return _numcaranterior;
        }
        set
        {
            PropriedadeModificada("Numcaranterior", value);
            _numcaranterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numcartao
    {
        get
        {
            PropriedadeAcessada("Numcartao");
            return _numcartao;
        }
        set
        {
            PropriedadeModificada("Numcartao", value);
            _numcartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
    public string Numcartaocrm
    {
        get
        {
            PropriedadeAcessada("Numcartaocrm");
            return _numcartaocrm;
        }
        set
        {
            PropriedadeModificada("Numcartaocrm", value);
            _numcartaocrm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcheckout
    {
        get
        {
            PropriedadeAcessada("Numcheckout");
            return _numcheckout;
        }
        set
        {
            PropriedadeModificada("Numcheckout", value);
            _numcheckout = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcheque
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcontacorrente
    {
        get
        {
            PropriedadeAcessada("Numcontacorrente");
            return _numcontacorrente;
        }
        set
        {
            PropriedadeModificada("Numcontacorrente", value);
            _numcontacorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcustodia
    {
        get
        {
            PropriedadeAcessada("Numcustodia");
            return _numcustodia;
        }
        set
        {
            PropriedadeModificada("Numcustodia", value);
            _numcustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascarencia
    {
        get
        {
            PropriedadeAcessada("Numdiascarencia");
            return _numdiascarencia;
        }
        set
        {
            PropriedadeModificada("Numdiascarencia", value);
            _numdiascarencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasprazoprotesto
    {
        get
        {
            PropriedadeAcessada("Numdiasprazoprotesto");
            return _numdiasprazoprotesto;
        }
        set
        {
            PropriedadeModificada("Numdiasprazoprotesto", value);
            _numdiasprazoprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numecf
    {
        get
        {
            PropriedadeAcessada("Numecf");
            return _numecf;
        }
        set
        {
            PropriedadeModificada("Numecf", value);
            _numecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numfechamentomovcx
    {
        get
        {
            PropriedadeAcessada("Numfechamentomovcx");
            return _numfechamentomovcx;
        }
        set
        {
            PropriedadeModificada("Numfechamentomovcx", value);
            _numfechamentomovcx = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numlotecartaotef
    {
        get
        {
            PropriedadeAcessada("Numlotecartaotef");
            return _numlotecartaotef;
        }
        set
        {
            PropriedadeModificada("Numlotecartaotef", value);
            _numlotecartaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlotecustodia
    {
        get
        {
            PropriedadeAcessada("Numlotecustodia");
            return _numlotecustodia;
        }
        set
        {
            PropriedadeModificada("Numlotecustodia", value);
            _numlotecustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numnegociacao
    {
        get
        {
            PropriedadeAcessada("Numnegociacao");
            return _numnegociacao;
        }
        set
        {
            PropriedadeModificada("Numnegociacao", value);
            _numnegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
    public decimal? Numos
    {
        get
        {
            PropriedadeAcessada("Numos");
            return _numos;
        }
        set
        {
            PropriedadeModificada("Numos", value);
            _numos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numped
    {
        get
        {
            PropriedadeAcessada("Numped");
            return _numped;
        }
        set
        {
            PropriedadeModificada("Numped", value);
            _numped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Numprotocolochq
    {
        get
        {
            PropriedadeAcessada("Numprotocolochq");
            return _numprotocolochq;
        }
        set
        {
            PropriedadeModificada("Numprotocolochq", value);
            _numprotocolochq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numrecibo
    {
        get
        {
            PropriedadeAcessada("Numrecibo");
            return _numrecibo;
        }
        set
        {
            PropriedadeModificada("Numrecibo", value);
            _numrecibo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Numremessa
    {
        get
        {
            PropriedadeAcessada("Numremessa");
            return _numremessa;
        }
        set
        {
            PropriedadeModificada("Numremessa", value);
            _numremessa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 22, Precisao = 0)]
    public string Numresumo
    {
        get
        {
            PropriedadeAcessada("Numresumo");
            return _numresumo;
        }
        set
        {
            PropriedadeModificada("Numresumo", value);
            _numresumo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqretorno
    {
        get
        {
            PropriedadeAcessada("Numseqretorno");
            return _numseqretorno;
        }
        set
        {
            PropriedadeModificada("Numseqretorno", value);
            _numseqretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numtrans
    {
        get
        {
            PropriedadeAcessada("Numtrans");
            return _numtrans;
        }
        set
        {
            PropriedadeModificada("Numtrans", value);
            _numtrans = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada("Numtransent");
            return _numtransent;
        }
        set
        {
            PropriedadeModificada("Numtransent", value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdevcli
    {
        get
        {
            PropriedadeAcessada("Numtransentdevcli");
            return _numtransentdevcli;
        }
        set
        {
            PropriedadeModificada("Numtransentdevcli", value);
            _numtransentdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendast
    {
        get
        {
            PropriedadeAcessada("Numtransvendast");
            return _numtransvendast;
        }
        set
        {
            PropriedadeModificada("Numtransvendast", value);
            _numtransvendast = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numtransvendor
    {
        get
        {
            PropriedadeAcessada("Numtransvendor");
            return _numtransvendor;
        }
        set
        {
            PropriedadeModificada("Numtransvendor", value);
            _numtransvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada("Obs");
            return _obs;
        }
        set
        {
            PropriedadeModificada("Obs", value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obs2
    {
        get
        {
            PropriedadeAcessada("Obs2");
            return _obs2;
        }
        set
        {
            PropriedadeModificada("Obs2", value);
            _obs2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obscustodia
    {
        get
        {
            PropriedadeAcessada("Obscustodia");
            return _obscustodia;
        }
        set
        {
            PropriedadeModificada("Obscustodia", value);
            _obscustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsfinanc
    {
        get
        {
            PropriedadeAcessada("Obsfinanc");
            return _obsfinanc;
        }
        set
        {
            PropriedadeModificada("Obsfinanc", value);
            _obsfinanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1000, Precisao = 0)]
    public string Obstitulo
    {
        get
        {
            PropriedadeAcessada("Obstitulo");
            return _obstitulo;
        }
        set
        {
            PropriedadeModificada("Obstitulo", value);
            _obstitulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Operacao
    {
        get
        {
            PropriedadeAcessada("Operacao");
            return _operacao;
        }
        set
        {
            PropriedadeModificada("Operacao", value);
            _operacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Origemboleto
    {
        get
        {
            PropriedadeAcessada("Origemboleto");
            return _origemboleto;
        }
        set
        {
            PropriedadeModificada("Origemboleto", value);
            _origemboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Parcelamentotef
    {
        get
        {
            PropriedadeAcessada("Parcelamentotef");
            return _parcelamentotef;
        }
        set
        {
            PropriedadeModificada("Parcelamentotef", value);
            _parcelamentotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2000, Precisao = 0)]
    public string Pastaarquivoboleto
    {
        get
        {
            PropriedadeAcessada("Pastaarquivoboleto");
            return _pastaarquivoboleto;
        }
        set
        {
            PropriedadeModificada("Pastaarquivoboleto", value);
            _pastaarquivoboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Pdv
    {
        get
        {
            PropriedadeAcessada("Pdv");
            return _pdv;
        }
        set
        {
            PropriedadeModificada("Pdv", value);
            _pdv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom
    {
        get
        {
            PropriedadeAcessada("Percom");
            return _percom;
        }
        set
        {
            PropriedadeModificada("Percom", value);
            _percom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom2
    {
        get
        {
            PropriedadeAcessada("Percom2");
            return _percom2;
        }
        set
        {
            PropriedadeModificada("Percom2", value);
            _percom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom3
    {
        get
        {
            PropriedadeAcessada("Percom3");
            return _percom3;
        }
        set
        {
            PropriedadeModificada("Percom3", value);
            _percom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom4
    {
        get
        {
            PropriedadeAcessada("Percom4");
            return _percom4;
        }
        set
        {
            PropriedadeModificada("Percom4", value);
            _percom4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percomliq
    {
        get
        {
            PropriedadeAcessada("Percomliq");
            return _percomliq;
        }
        set
        {
            PropriedadeModificada("Percomliq", value);
            _percomliq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomsup
    {
        get
        {
            PropriedadeAcessada("Percomsup");
            return _percomsup;
        }
        set
        {
            PropriedadeModificada("Percomsup", value);
            _percomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc
    {
        get
        {
            PropriedadeAcessada("Perdesc");
            return _perdesc;
        }
        set
        {
            PropriedadeModificada("Perdesc", value);
            _perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteestorno
    {
        get
        {
            PropriedadeAcessada("Permiteestorno");
            return _permiteestorno;
        }
        set
        {
            PropriedadeModificada("Permiteestorno", value);
            _permiteestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Prest
    {
        get
        {
            PropriedadeAcessada("Prest");
            return _prest;
        }
        set
        {
            PropriedadeModificada("Prest", value);
            _prest = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Presttef
    {
        get
        {
            PropriedadeAcessada("Presttef");
            return _presttef;
        }
        set
        {
            PropriedadeModificada("Presttef", value);
            _presttef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Protesto
    {
        get
        {
            PropriedadeAcessada("Protesto");
            return _protesto;
        }
        set
        {
            PropriedadeModificada("Protesto", value);
            _protesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtparcelaspos
    {
        get
        {
            PropriedadeAcessada("Qtparcelaspos");
            return _qtparcelaspos;
        }
        set
        {
            PropriedadeModificada("Qtparcelaspos", value);
            _qtparcelaspos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Razaocredenccartao
    {
        get
        {
            PropriedadeAcessada("Razaocredenccartao");
            return _razaocredenccartao;
        }
        set
        {
            PropriedadeModificada("Razaocredenccartao", value);
            _razaocredenccartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Responsavelpag
    {
        get
        {
            PropriedadeAcessada("Responsavelpag");
            return _responsavelpag;
        }
        set
        {
            PropriedadeModificada("Responsavelpag", value);
            _responsavelpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rotdesd
    {
        get
        {
            PropriedadeAcessada("Rotdesd");
            return _rotdesd;
        }
        set
        {
            PropriedadeModificada("Rotdesd", value);
            _rotdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Rotinadesd
    {
        get
        {
            PropriedadeAcessada("Rotinadesd");
            return _rotinadesd;
        }
        set
        {
            PropriedadeModificada("Rotinadesd", value);
            _rotinadesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Rotinafecha
    {
        get
        {
            PropriedadeAcessada("Rotinafecha");
            return _rotinafecha;
        }
        set
        {
            PropriedadeModificada("Rotinafecha", value);
            _rotinafecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Rotinainsert
    {
        get
        {
            PropriedadeAcessada("Rotinainsert");
            return _rotinainsert;
        }
        set
        {
            PropriedadeModificada("Rotinainsert", value);
            _rotinainsert = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rotinalanc
    {
        get
        {
            PropriedadeAcessada("Rotinalanc");
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada("Rotinalanc", value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalancultalt
    {
        get
        {
            PropriedadeAcessada("Rotinalancultalt");
            return _rotinalancultalt;
        }
        set
        {
            PropriedadeModificada("Rotinalancultalt", value);
            _rotinalancultalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Rotinapag
    {
        get
        {
            PropriedadeAcessada("Rotinapag");
            return _rotinapag;
        }
        set
        {
            PropriedadeModificada("Rotinapag", value);
            _rotinapag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Serialpos
    {
        get
        {
            PropriedadeAcessada("Serialpos");
            return _serialpos;
        }
        set
        {
            PropriedadeModificada("Serialpos", value);
            _serialpos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Somatxboleto
    {
        get
        {
            PropriedadeAcessada("Somatxboleto");
            return _somatxboleto;
        }
        set
        {
            PropriedadeModificada("Somatxboleto", value);
            _somatxboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Statussci
    {
        get
        {
            PropriedadeAcessada("Statussci");
            return _statussci;
        }
        set
        {
            PropriedadeModificada("Statussci", value);
            _statussci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada("Tipo");
            return _tipo;
        }
        set
        {
            PropriedadeModificada("Tipo", value);
            _tipo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoestorno
    {
        get
        {
            PropriedadeAcessada("Tipoestorno");
            return _tipoestorno;
        }
        set
        {
            PropriedadeModificada("Tipoestorno", value);
            _tipoestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipooperacaotef
    {
        get
        {
            PropriedadeAcessada("Tipooperacaotef");
            return _tipooperacaotef;
        }
        set
        {
            PropriedadeModificada("Tipooperacaotef", value);
            _tipooperacaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipooperedital
    {
        get
        {
            PropriedadeAcessada("Tipooperedital");
            return _tipooperedital;
        }
        set
        {
            PropriedadeModificada("Tipooperedital", value);
            _tipooperedital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoportador
    {
        get
        {
            PropriedadeAcessada("Tipoportador");
            return _tipoportador;
        }
        set
        {
            PropriedadeModificada("Tipoportador", value);
            _tipoportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoprorrog
    {
        get
        {
            PropriedadeAcessada("Tipoprorrog");
            return _tipoprorrog;
        }
        set
        {
            PropriedadeModificada("Tipoprorrog", value);
            _tipoprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipovendordesc
    {
        get
        {
            PropriedadeAcessada("Tipovendordesc");
            return _tipovendordesc;
        }
        set
        {
            PropriedadeModificada("Tipovendordesc", value);
            _tipovendordesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Txperm
    {
        get
        {
            PropriedadeAcessada("Txperm");
            return _txperm;
        }
        set
        {
            PropriedadeModificada("Txperm", value);
            _txperm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Txpermprevisto
    {
        get
        {
            PropriedadeAcessada("Txpermprevisto");
            return _txpermprevisto;
        }
        set
        {
            PropriedadeModificada("Txpermprevisto", value);
            _txpermprevisto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Txpermprevreal
    {
        get
        {
            PropriedadeAcessada("Txpermprevreal");
            return _txpermprevreal;
        }
        set
        {
            PropriedadeModificada("Txpermprevreal", value);
            _txpermprevreal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Txvendorbco
    {
        get
        {
            PropriedadeAcessada("Txvendorbco");
            return _txvendorbco;
        }
        set
        {
            PropriedadeModificada("Txvendorbco", value);
            _txvendorbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Txvendorcli
    {
        get
        {
            PropriedadeAcessada("Txvendorcli");
            return _txvendorcli;
        }
        set
        {
            PropriedadeModificada("Txvendorcli", value);
            _txvendorcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal Valor
    {
        get
        {
            PropriedadeAcessada("Valor");
            return _valor;
        }
        set
        {
            PropriedadeModificada("Valor", value);
            _valor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valordesc
    {
        get
        {
            PropriedadeAcessada("Valordesc");
            return _valordesc;
        }
        set
        {
            PropriedadeModificada("Valordesc", value);
            _valordesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valordescorig
    {
        get
        {
            PropriedadeAcessada("Valordescorig");
            return _valordescorig;
        }
        set
        {
            PropriedadeModificada("Valordescorig", value);
            _valordescorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorestorno
    {
        get
        {
            PropriedadeAcessada("Valorestorno");
            return _valorestorno;
        }
        set
        {
            PropriedadeModificada("Valorestorno", value);
            _valorestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valorliqcom
    {
        get
        {
            PropriedadeAcessada("Valorliqcom");
            return _valorliqcom;
        }
        set
        {
            PropriedadeModificada("Valorliqcom", value);
            _valorliqcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorliqcomsup
    {
        get
        {
            PropriedadeAcessada("Valorliqcomsup");
            return _valorliqcomsup;
        }
        set
        {
            PropriedadeModificada("Valorliqcomsup", value);
            _valorliqcomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valormulta
    {
        get
        {
            PropriedadeAcessada("Valormulta");
            return _valormulta;
        }
        set
        {
            PropriedadeModificada("Valormulta", value);
            _valormulta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Valororig
    {
        get
        {
            PropriedadeAcessada("Valororig");
            return _valororig;
        }
        set
        {
            PropriedadeModificada("Valororig", value);
            _valororig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Versaohash
    {
        get
        {
            PropriedadeAcessada("Versaohash");
            return _versaohash;
        }
        set
        {
            PropriedadeModificada("Versaohash", value);
            _versaohash = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcontratovendor
    {
        get
        {
            PropriedadeAcessada("Vlcontratovendor");
            return _vlcontratovendor;
        }
        set
        {
            PropriedadeModificada("Vlcontratovendor", value);
            _vlcontratovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcustodocvendor
    {
        get
        {
            PropriedadeAcessada("Vlcustodocvendor");
            return _vlcustodocvendor;
        }
        set
        {
            PropriedadeModificada("Vlcustodocvendor", value);
            _vlcustodocvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldevol
    {
        get
        {
            PropriedadeAcessada("Vldevol");
            return _vldevol;
        }
        set
        {
            PropriedadeModificada("Vldevol", value);
            _vldevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrcofinsorgpub
    {
        get
        {
            PropriedadeAcessada("Vlrcofinsorgpub");
            return _vlrcofinsorgpub;
        }
        set
        {
            PropriedadeModificada("Vlrcofinsorgpub", value);
            _vlrcofinsorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrcontsocialorgpub
    {
        get
        {
            PropriedadeAcessada("Vlrcontsocialorgpub");
            return _vlrcontsocialorgpub;
        }
        set
        {
            PropriedadeModificada("Vlrcontsocialorgpub", value);
            _vlrcontsocialorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrdespbancarias
    {
        get
        {
            PropriedadeAcessada("Vlrdespbancarias");
            return _vlrdespbancarias;
        }
        set
        {
            PropriedadeModificada("Vlrdespbancarias", value);
            _vlrdespbancarias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrdespcartorais
    {
        get
        {
            PropriedadeAcessada("Vlrdespcartorais");
            return _vlrdespcartorais;
        }
        set
        {
            PropriedadeModificada("Vlrdespcartorais", value);
            _vlrdespcartorais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlricmsretorgpub
    {
        get
        {
            PropriedadeAcessada("Vlricmsretorgpub");
            return _vlricmsretorgpub;
        }
        set
        {
            PropriedadeModificada("Vlricmsretorgpub", value);
            _vlricmsretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrimprendaorgpub
    {
        get
        {
            PropriedadeAcessada("Vlrimprendaorgpub");
            return _vlrimprendaorgpub;
        }
        set
        {
            PropriedadeModificada("Vlrimprendaorgpub", value);
            _vlrimprendaorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlroutrasdeducoesorgpub
    {
        get
        {
            PropriedadeAcessada("Vlroutrasdeducoesorgpub");
            return _vlroutrasdeducoesorgpub;
        }
        set
        {
            PropriedadeModificada("Vlroutrasdeducoesorgpub", value);
            _vlroutrasdeducoesorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlroutrosacresc
    {
        get
        {
            PropriedadeAcessada("Vlroutrosacresc");
            return _vlroutrosacresc;
        }
        set
        {
            PropriedadeModificada("Vlroutrosacresc", value);
            _vlroutrosacresc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrpisorgpub
    {
        get
        {
            PropriedadeAcessada("Vlrpisorgpub");
            return _vlrpisorgpub;
        }
        set
        {
            PropriedadeModificada("Vlrpisorgpub", value);
            _vlrpisorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrtotdespesasejuros
    {
        get
        {
            PropriedadeAcessada("Vlrtotdespesasejuros");
            return _vlrtotdespesasejuros;
        }
        set
        {
            PropriedadeModificada("Vlrtotdespesasejuros", value);
            _vlrtotdespesasejuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vltroco
    {
        get
        {
            PropriedadeAcessada("Vltroco");
            return _vltroco;
        }
        set
        {
            PropriedadeModificada("Vltroco", value);
            _vltroco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vltxboleto
    {
        get
        {
            PropriedadeAcessada("Vltxboleto");
            return _vltxboleto;
        }
        set
        {
            PropriedadeModificada("Vltxboleto", value);
            _vltxboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vltxiof
    {
        get
        {
            PropriedadeAcessada("Vltxiof");
            return _vltxiof;
        }
        set
        {
            PropriedadeModificada("Vltxiof", value);
            _vltxiof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vltxiofcomplementar
    {
        get
        {
            PropriedadeAcessada("Vltxiofcomplementar");
            return _vltxiofcomplementar;
        }
        set
        {
            PropriedadeModificada("Vltxiofcomplementar", value);
            _vltxiofcomplementar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vltxvendor
    {
        get
        {
            PropriedadeAcessada("Vltxvendor");
            return _vltxvendor;
        }
        set
        {
            PropriedadeModificada("Vltxvendor", value);
            _vltxvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vpago
    {
        get
        {
            PropriedadeAcessada("Vpago");
            return _vpago;
        }
        set
        {
            PropriedadeModificada("Vpago", value);
            _vpago = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTPREFAT", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Tipocorban
    {
        get
        {
            PropriedadeAcessada("Tipocorban");
            return _tipocorban;
        }
        set
        {
            PropriedadeModificada("Tipocorban", value);
            _tipocorban = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Processadortranspagdigital
    {
        get
        {
            PropriedadeAcessada("Processadortranspagdigital");
            return _processadortranspagdigital;
        }
        set
        {
            PropriedadeModificada("Processadortranspagdigital", value);
            _processadortranspagdigital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Numtranspagdigital
    {
        get
        {
            PropriedadeAcessada("Numtranspagdigital");
            return _numtranspagdigital;
        }
        set
        {
            PropriedadeModificada("Numtranspagdigital", value);
            _numtranspagdigital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Nsupagdigital
    {
        get
        {
            PropriedadeAcessada("Nsupagdigital");
            return _nsupagdigital;
        }
        set
        {
            PropriedadeModificada("Nsupagdigital", value);
            _nsupagdigital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Carteiradigital
    {
        get
        {
            PropriedadeAcessada("Carteiradigital");
            return _carteiradigital;
        }
        set
        {
            PropriedadeModificada("Carteiradigital", value);
            _carteiradigital = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Nomecarteiradigital
    {
        get
        {
            PropriedadeAcessada("Nomecarteiradigital");
            return _nomecarteiradigital;
        }
        set
        {
            PropriedadeModificada("Nomecarteiradigital", value);
            _nomecarteiradigital = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCPRESTPREFAT";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _agrupado = AlterarTipo<string>(leitor["Agrupado"]);
        _alinea = AlterarTipo<decimal?>(leitor["Alinea"]);
        _arqretorno = AlterarTipo<string>(leitor["Arqretorno"]);
        _baixaconciliada = AlterarTipo<string>(leitor["Baixaconciliada"]);
        _bandeiracartao = AlterarTipo<decimal?>(leitor["Bandeiracartao"]);
        _bloqdesdemitentedif = AlterarTipo<string>(leitor["Bloqdesdemitentedif"]);
        _boleto = AlterarTipo<string>(leitor["Boleto"]);
        _cartorio = AlterarTipo<string>(leitor["Cartorio"]);
        _cgccpfch = AlterarTipo<string>(leitor["Cgccpfch"]);
        _chequeterceiro = AlterarTipo<string>(leitor["Chequeterceiro"]);
        _cnpjcisp = AlterarTipo<string>(leitor["Cnpjcisp"]);
        _cnpjcredenccartao = AlterarTipo<string>(leitor["Cnpjcredenccartao"]);
        _codadmcartao = AlterarTipo<string>(leitor["Codadmcartao"]);
        _codagentecobranca = AlterarTipo<decimal?>(leitor["Codagentecobranca"]);
        _codautorizacaotef = AlterarTipo<decimal?>(leitor["Codautorizacaotef"]);
        _codbaixa = AlterarTipo<decimal?>(leitor["Codbaixa"]);
        _codbaixacartaorede = AlterarTipo<decimal?>(leitor["Codbaixacartaorede"]);
        _codbanco = AlterarTipo<decimal?>(leitor["Codbanco"]);
        _codbancobaixa = AlterarTipo<decimal?>(leitor["Codbancobaixa"]);
        _codbancocm = AlterarTipo<decimal?>(leitor["Codbancocm"]);
        _codbancocm2 = AlterarTipo<decimal?>(leitor["Codbancocm2"]);
        _codbancocustodia = AlterarTipo<decimal?>(leitor["Codbancocustodia"]);
        _codbancovendor = AlterarTipo<decimal?>(leitor["Codbancovendor"]);
        _codbandeiratef = AlterarTipo<string>(leitor["Codbandeiratef"]);
        _codbarra = AlterarTipo<string>(leitor["Codbarra"]);
        _codbarra2 = AlterarTipo<string>(leitor["Codbarra2"]);
        _codbcocustodia = AlterarTipo<decimal?>(leitor["Codbcocustodia"]);
        _codbloco = AlterarTipo<decimal?>(leitor["Codbloco"]);
        _codcli = AlterarTipo<decimal>(leitor["Codcli"]);
        _codclicc = AlterarTipo<decimal?>(leitor["Codclicc"]);
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcobbanco = AlterarTipo<string>(leitor["Codcobbanco"]);
        _codcoborig = AlterarTipo<string>(leitor["Codcoborig"]);
        _codcobpos = AlterarTipo<string>(leitor["Codcobpos"]);
        _codcobrador = AlterarTipo<decimal?>(leitor["Codcobrador"]);
        _codcobsefaz = AlterarTipo<string>(leitor["Codcobsefaz"]);
        _codcred = AlterarTipo<decimal?>(leitor["Codcred"]);
        _codedital = AlterarTipo<decimal?>(leitor["Codedital"]);
        _codemitentepedido = AlterarTipo<decimal?>(leitor["Codemitentepedido"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codestabelecimento = AlterarTipo<string>(leitor["Codestabelecimento"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
        _codfilialrec = AlterarTipo<string>(leitor["Codfilialrec"]);
        _codfuncbordero = AlterarTipo<decimal?>(leitor["Codfuncbordero"]);
        _codfunccheckout = AlterarTipo<decimal?>(leitor["Codfunccheckout"]);
        _codfuncconcil = AlterarTipo<decimal?>(leitor["Codfuncconcil"]);
        _codfuncconcilvenc = AlterarTipo<decimal?>(leitor["Codfuncconcilvenc"]);
        _codfunccxmot = AlterarTipo<decimal?>(leitor["Codfunccxmot"]);
        _codfuncdesd = AlterarTipo<decimal?>(leitor["Codfuncdesd"]);
        _codfuncdesd1 = AlterarTipo<decimal?>(leitor["Codfuncdesd1"]);
        _codfuncdnicli = AlterarTipo<decimal?>(leitor["Codfuncdnicli"]);
        _codfuncestorno = AlterarTipo<decimal?>(leitor["Codfuncestorno"]);
        _codfuncfecha = AlterarTipo<decimal?>(leitor["Codfuncfecha"]);
        _codfuncinc = AlterarTipo<decimal?>(leitor["Codfuncinc"]);
        _codfuncliberacaoentrega = AlterarTipo<decimal?>(leitor["Codfuncliberacaoentrega"]);
        _codfuncprorrog = AlterarTipo<decimal?>(leitor["Codfuncprorrog"]);
        _codfuncultalter = AlterarTipo<decimal?>(leitor["Codfuncultalter"]);
        _codfuncvale = AlterarTipo<decimal?>(leitor["Codfuncvale"]);
        _codfuncvend = AlterarTipo<decimal?>(leitor["Codfuncvend"]);
        _codhistvale = AlterarTipo<decimal?>(leitor["Codhistvale"]);
        _codmotorista = AlterarTipo<decimal?>(leitor["Codmotorista"]);
        _codocorrbaixa = AlterarTipo<decimal?>(leitor["Codocorrbaixa"]);
        _codportador = AlterarTipo<decimal?>(leitor["Codportador"]);
        _codprofissional = AlterarTipo<decimal?>(leitor["Codprofissional"]);
        _codstatuscob = AlterarTipo<decimal?>(leitor["Codstatuscob"]);
        _codsupervisor = AlterarTipo<decimal?>(leitor["Codsupervisor"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _codusur4 = AlterarTipo<decimal?>(leitor["Codusur4"]);
        _codusurant = AlterarTipo<decimal?>(leitor["Codusurant"]);
        _codusurpgcomissao = AlterarTipo<decimal?>(leitor["Codusurpgcomissao"]);
        _compensacaobco = AlterarTipo<decimal?>(leitor["Compensacaobco"]);
        _contratovendor = AlterarTipo<decimal?>(leitor["Contratovendor"]);
        _correspondente = AlterarTipo<string>(leitor["Correspondente"]);
        _credpagcomissmed = AlterarTipo<string>(leitor["Credpagcomissmed"]);
        _dadosecf = AlterarTipo<string>(leitor["Dadosecf"]);
        _dataconsolidacaoprefat = AlterarTipo<DateTime?>(leitor["Dataconsolidacaoprefat"]);
        _datahoraminutobaixa = AlterarTipo<DateTime?>(leitor["Datahoraminutobaixa"]);
        _digitao = AlterarTipo<string>(leitor["Digitao"]);
        _dtaberturaconta = AlterarTipo<DateTime?>(leitor["Dtaberturaconta"]);
        _dtassociadnicli = AlterarTipo<DateTime?>(leitor["Dtassociadnicli"]);
        _dtbaixa = AlterarTipo<DateTime?>(leitor["Dtbaixa"]);
        _dtbaixacred = AlterarTipo<DateTime?>(leitor["Dtbaixacred"]);
        _dtborder = AlterarTipo<DateTime?>(leitor["Dtborder"]);
        _dtbordero = AlterarTipo<DateTime?>(leitor["Dtbordero"]);
        _dtcancel = AlterarTipo<DateTime?>(leitor["Dtcancel"]);
        _dtconcil = AlterarTipo<DateTime?>(leitor["Dtconcil"]);
        _dtconcilvenc = AlterarTipo<DateTime?>(leitor["Dtconcilvenc"]);
        _dtcriacao = AlterarTipo<DateTime?>(leitor["Dtcriacao"]);
        _dtcustodia = AlterarTipo<DateTime?>(leitor["Dtcustodia"]);
        _dtcxmot = AlterarTipo<DateTime?>(leitor["Dtcxmot"]);
        _dtcxmothhmmss = AlterarTipo<DateTime?>(leitor["Dtcxmothhmmss"]);
        _dtdefagente = AlterarTipo<DateTime?>(leitor["Dtdefagente"]);
        _dtdesc = AlterarTipo<DateTime?>(leitor["Dtdesc"]);
        _dtdescontado = AlterarTipo<DateTime?>(leitor["Dtdescontado"]);
        _dtdescontotitbco = AlterarTipo<DateTime?>(leitor["Dtdescontotitbco"]);
        _dtdesd = AlterarTipo<DateTime?>(leitor["Dtdesd"]);
        _dtdevol = AlterarTipo<DateTime?>(leitor["Dtdevol"]);
        _dtemissao = AlterarTipo<DateTime>(leitor["Dtemissao"]);
        _dtemissaoorig = AlterarTipo<DateTime?>(leitor["Dtemissaoorig"]);
        _dtenvioserasa = AlterarTipo<DateTime?>(leitor["Dtenvioserasa"]);
        _dtestorno = AlterarTipo<DateTime?>(leitor["Dtestorno"]);
        _dtexportacaoservint = AlterarTipo<DateTime?>(leitor["Dtexportacaoservint"]);
        _dtfecha = AlterarTipo<DateTime?>(leitor["Dtfecha"]);
        _dtfechavendor = AlterarTipo<DateTime?>(leitor["Dtfechavendor"]);
        _dtimportacaoservprinc = AlterarTipo<DateTime?>(leitor["Dtimportacaoservprinc"]);
        _dtimpressao = AlterarTipo<DateTime?>(leitor["Dtimpressao"]);
        _dtinclusao = AlterarTipo<DateTime?>(leitor["Dtinclusao"]);
        _dtinclusaomanual = AlterarTipo<DateTime?>(leitor["Dtinclusaomanual"]);
        _dtlancch = AlterarTipo<DateTime?>(leitor["Dtlancch"]);
        _dtlancprorrog = AlterarTipo<DateTime?>(leitor["Dtlancprorrog"]);
        _dtliberacaoentrega = AlterarTipo<DateTime?>(leitor["Dtliberacaoentrega"]);
        _dtliberacaofechamento = AlterarTipo<DateTime?>(leitor["Dtliberacaofechamento"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _dtpag = AlterarTipo<DateTime?>(leitor["Dtpag"]);
        _dtpagcomissao = AlterarTipo<DateTime?>(leitor["Dtpagcomissao"]);
        _dtpagcomissao2 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao2"]);
        _dtpagcomissao3 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao3"]);
        _dtpagcomissao4 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao4"]);
        _dtpagcomissaoprof = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoprof"]);
        _dtprocessamento = AlterarTipo<DateTime?>(leitor["Dtprocessamento"]);
        _dtrecebimentoprevisto = AlterarTipo<DateTime?>(leitor["Dtrecebimentoprevisto"]);
        _dtregcarteira = AlterarTipo<DateTime?>(leitor["Dtregcarteira"]);
        _dtremvendor = AlterarTipo<DateTime?>(leitor["Dtremvendor"]);
        _dtretiradaserasa = AlterarTipo<DateTime?>(leitor["Dtretiradaserasa"]);
        _dtsaida = AlterarTipo<DateTime?>(leitor["Dtsaida"]);
        _dttransacaocc = AlterarTipo<DateTime?>(leitor["Dttransacaocc"]);
        _dtultalter = AlterarTipo<DateTime?>(leitor["Dtultalter"]);
        _dtultestorno = AlterarTipo<DateTime?>(leitor["Dtultestorno"]);
        _dtvenc = AlterarTipo<DateTime>(leitor["Dtvenc"]);
        _dtvencanterior = AlterarTipo<DateTime?>(leitor["Dtvencanterior"]);
        _dtvencorig = AlterarTipo<DateTime>(leitor["Dtvencorig"]);
        _dtvencvale = AlterarTipo<DateTime?>(leitor["Dtvencvale"]);
        _dtvendor = AlterarTipo<DateTime?>(leitor["Dtvendor"]);
        _duplic = AlterarTipo<decimal>(leitor["Duplic"]);
        _dvagencia = AlterarTipo<decimal?>(leitor["Dvagencia"]);
        _dvcheque = AlterarTipo<decimal?>(leitor["Dvcheque"]);
        _dvcob = AlterarTipo<decimal?>(leitor["Dvcob"]);
        _dvconta = AlterarTipo<decimal?>(leitor["Dvconta"]);
        _enviadoqis = AlterarTipo<string>(leitor["Enviadoqis"]);
        _equiplanc = AlterarTipo<string>(leitor["Equiplanc"]);
        _exportadoservint = AlterarTipo<string>(leitor["Exportadoservint"]);
        _factoring = AlterarTipo<string>(leitor["Factoring"]);
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _geracaorazaoauxiliar = AlterarTipo<string>(leitor["Geracaorazaoauxiliar"]);
        _hash = AlterarTipo<string>(leitor["Hash"]);
        _historigdesdobramento = AlterarTipo<string>(leitor["Historigdesdobramento"]);
        _hobpercommot = AlterarTipo<decimal?>(leitor["Hobpercommot"]);
        _hobpercomsup = AlterarTipo<decimal?>(leitor["Hobpercomsup"]);
        _horadesd = AlterarTipo<decimal?>(leitor["Horadesd"]);
        _horaestorno = AlterarTipo<decimal?>(leitor["Horaestorno"]);
        _horafecha = AlterarTipo<decimal?>(leitor["Horafecha"]);
        _idcob = AlterarTipo<decimal?>(leitor["Idcob"]);
        _idpagamento = AlterarTipo<decimal?>(leitor["Idpagamento"]);
        _idpagamentolocal = AlterarTipo<decimal?>(leitor["Idpagamentolocal"]);
        _idrespfiscal = AlterarTipo<decimal?>(leitor["Idrespfiscal"]);
        _idtitulo = AlterarTipo<decimal?>(leitor["Idtitulo"]);
        _importadoservprinc = AlterarTipo<string>(leitor["Importadoservprinc"]);
        _linhadig = AlterarTipo<string>(leitor["Linhadig"]);
        _linhadig2 = AlterarTipo<string>(leitor["Linhadig2"]);
        _minutodesd = AlterarTipo<decimal?>(leitor["Minutodesd"]);
        _minutoestorno = AlterarTipo<decimal?>(leitor["Minutoestorno"]);
        _minutofecha = AlterarTipo<decimal?>(leitor["Minutofecha"]);
        _nomearquivo = AlterarTipo<string>(leitor["Nomearquivo"]);
        _nossonumbco = AlterarTipo<string>(leitor["Nossonumbco"]);
        _nossonumbco2 = AlterarTipo<string>(leitor["Nossonumbco2"]);
        _nsuhost = AlterarTipo<string>(leitor["Nsuhost"]);
        _nsutef = AlterarTipo<string>(leitor["Nsutef"]);
        _numagencia = AlterarTipo<decimal?>(leitor["Numagencia"]);
        _numassocdni = AlterarTipo<decimal?>(leitor["Numassocdni"]);
        _numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
        _numbordero = AlterarTipo<decimal?>(leitor["Numbordero"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _hubnumcaixapadrao = AlterarTipo<decimal?>(leitor["Hubnumcaixapadrao"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numcartao = AlterarTipo<string>(leitor["Numcartao"]);
        _numcartaocrm = AlterarTipo<string>(leitor["Numcartaocrm"]);
        _numcheckout = AlterarTipo<decimal?>(leitor["Numcheckout"]);
        _numcheque = AlterarTipo<decimal?>(leitor["Numcheque"]);
        _numcontacorrente = AlterarTipo<decimal?>(leitor["Numcontacorrente"]);
        _numcustodia = AlterarTipo<decimal?>(leitor["Numcustodia"]);
        _numdiascarencia = AlterarTipo<decimal?>(leitor["Numdiascarencia"]);
        _numdiasprazoprotesto = AlterarTipo<decimal?>(leitor["Numdiasprazoprotesto"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _numlotecartaotef = AlterarTipo<string>(leitor["Numlotecartaotef"]);
        _numlotecustodia = AlterarTipo<decimal?>(leitor["Numlotecustodia"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numos = AlterarTipo<decimal?>(leitor["Numos"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numprotocolochq = AlterarTipo<string>(leitor["Numprotocolochq"]);
        _numrecibo = AlterarTipo<decimal?>(leitor["Numrecibo"]);
        _numremessa = AlterarTipo<decimal?>(leitor["Numremessa"]);
        _numresumo = AlterarTipo<string>(leitor["Numresumo"]);
        _numseqretorno = AlterarTipo<decimal?>(leitor["Numseqretorno"]);
        _numtrans = AlterarTipo<decimal?>(leitor["Numtrans"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentdevcli = AlterarTipo<decimal?>(leitor["Numtransentdevcli"]);
        _numtransvenda = AlterarTipo<decimal>(leitor["Numtransvenda"]);
        _numtransvendast = AlterarTipo<decimal?>(leitor["Numtransvendast"]);
        _numtransvendor = AlterarTipo<decimal?>(leitor["Numtransvendor"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _obscustodia = AlterarTipo<string>(leitor["Obscustodia"]);
        _obsfinanc = AlterarTipo<string>(leitor["Obsfinanc"]);
        _obstitulo = AlterarTipo<string>(leitor["Obstitulo"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _origemboleto = AlterarTipo<string>(leitor["Origemboleto"]);
        _parcelamentotef = AlterarTipo<string>(leitor["Parcelamentotef"]);
        _pastaarquivoboleto = AlterarTipo<string>(leitor["Pastaarquivoboleto"]);
        _pdv = AlterarTipo<string>(leitor["Pdv"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _percomliq = AlterarTipo<decimal?>(leitor["Percomliq"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _perdesc = AlterarTipo<decimal?>(leitor["Perdesc"]);
        _permiteestorno = AlterarTipo<string>(leitor["Permiteestorno"]);
        _prest = AlterarTipo<string>(leitor["Prest"]);
        _presttef = AlterarTipo<decimal?>(leitor["Presttef"]);
        _protesto = AlterarTipo<string>(leitor["Protesto"]);
        _qtparcelaspos = AlterarTipo<decimal?>(leitor["Qtparcelaspos"]);
        _razaocredenccartao = AlterarTipo<string>(leitor["Razaocredenccartao"]);
        _responsavelpag = AlterarTipo<string>(leitor["Responsavelpag"]);
        _rotdesd = AlterarTipo<decimal?>(leitor["Rotdesd"]);
        _rotinadesd = AlterarTipo<string>(leitor["Rotinadesd"]);
        _rotinafecha = AlterarTipo<string>(leitor["Rotinafecha"]);
        _rotinainsert = AlterarTipo<string>(leitor["Rotinainsert"]);
        _rotinalanc = AlterarTipo<decimal?>(leitor["Rotinalanc"]);
        _rotinalancultalt = AlterarTipo<string>(leitor["Rotinalancultalt"]);
        _rotinapag = AlterarTipo<string>(leitor["Rotinapag"]);
        _serialpos = AlterarTipo<string>(leitor["Serialpos"]);
        _somatxboleto = AlterarTipo<string>(leitor["Somatxboleto"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _statussci = AlterarTipo<string>(leitor["Statussci"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _tipoestorno = AlterarTipo<string>(leitor["Tipoestorno"]);
        _tipooperacaotef = AlterarTipo<string>(leitor["Tipooperacaotef"]);
        _tipooperedital = AlterarTipo<string>(leitor["Tipooperedital"]);
        _tipoportador = AlterarTipo<string>(leitor["Tipoportador"]);
        _tipoprorrog = AlterarTipo<string>(leitor["Tipoprorrog"]);
        _tipovendordesc = AlterarTipo<string>(leitor["Tipovendordesc"]);
        _txperm = AlterarTipo<decimal?>(leitor["Txperm"]);
        _txpermprevisto = AlterarTipo<decimal?>(leitor["Txpermprevisto"]);
        _txpermprevreal = AlterarTipo<decimal?>(leitor["Txpermprevreal"]);
        _txvendorbco = AlterarTipo<decimal?>(leitor["Txvendorbco"]);
        _txvendorcli = AlterarTipo<decimal?>(leitor["Txvendorcli"]);
        _valor = AlterarTipo<decimal>(leitor["Valor"]);
        _valordesc = AlterarTipo<decimal?>(leitor["Valordesc"]);
        _valordescorig = AlterarTipo<decimal?>(leitor["Valordescorig"]);
        _valorestorno = AlterarTipo<decimal?>(leitor["Valorestorno"]);
        _valorliqcom = AlterarTipo<decimal?>(leitor["Valorliqcom"]);
        _valorliqcomsup = AlterarTipo<decimal?>(leitor["Valorliqcomsup"]);
        _valormulta = AlterarTipo<decimal?>(leitor["Valormulta"]);
        _valororig = AlterarTipo<decimal?>(leitor["Valororig"]);
        _versaohash = AlterarTipo<decimal?>(leitor["Versaohash"]);
        _vlcontratovendor = AlterarTipo<decimal?>(leitor["Vlcontratovendor"]);
        _vlcustodocvendor = AlterarTipo<decimal?>(leitor["Vlcustodocvendor"]);
        _vldevol = AlterarTipo<decimal?>(leitor["Vldevol"]);
        _vlrcofinsorgpub = AlterarTipo<decimal?>(leitor["Vlrcofinsorgpub"]);
        _vlrcontsocialorgpub = AlterarTipo<decimal?>(leitor["Vlrcontsocialorgpub"]);
        _vlrdespbancarias = AlterarTipo<decimal?>(leitor["Vlrdespbancarias"]);
        _vlrdespcartorais = AlterarTipo<decimal?>(leitor["Vlrdespcartorais"]);
        _vlricmsretorgpub = AlterarTipo<decimal?>(leitor["Vlricmsretorgpub"]);
        _vlrimprendaorgpub = AlterarTipo<decimal?>(leitor["Vlrimprendaorgpub"]);
        _vlroutrasdeducoesorgpub = AlterarTipo<decimal?>(leitor["Vlroutrasdeducoesorgpub"]);
        _vlroutrosacresc = AlterarTipo<decimal?>(leitor["Vlroutrosacresc"]);
        _vlrpisorgpub = AlterarTipo<decimal?>(leitor["Vlrpisorgpub"]);
        _vlrtotdespesasejuros = AlterarTipo<decimal?>(leitor["Vlrtotdespesasejuros"]);
        _vltroco = AlterarTipo<decimal?>(leitor["Vltroco"]);
        _vltxboleto = AlterarTipo<decimal?>(leitor["Vltxboleto"]);
        _vltxiof = AlterarTipo<decimal?>(leitor["Vltxiof"]);
        _vltxiofcomplementar = AlterarTipo<decimal?>(leitor["Vltxiofcomplementar"]);
        _vltxvendor = AlterarTipo<decimal?>(leitor["Vltxvendor"]);
        _vpago = AlterarTipo<decimal?>(leitor["Vpago"]);
        _tipocorban = AlterarTipo<string>(leitor["Tipocorban"]);
        _processadortranspagdigital = AlterarTipo<string>(leitor["Processadortranspagdigital"]);
        _numtranspagdigital = AlterarTipo<string>(leitor["Numtranspagdigital"]);
        _nsupagdigital = AlterarTipo<string>(leitor["Nsupagdigital"]);
        _carteiradigital = AlterarTipo<string>(leitor["Carteiradigital"]);
        _nomecarteiradigital = AlterarTipo<string>(leitor["Nomecarteiradigital"]);
    }

}