

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCUSUARI : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AREAATUACAO = "Areaatuacao";

    private string _areaatuacao;

    private static readonly string RO_BAIRRO = "Bairro";

    private string _bairro;

    private static readonly string RO_BIP = "Bip";

    private string _bip;

    private static readonly string RO_BLOQCOMIS = "Bloqcomis";

    private string _bloqcomis;

    private static readonly string RO_BLOQUEIO = "Bloqueio";

    private string _bloqueio;

    private static readonly string RO_BLOQVENDATLMK = "Bloqvendatlmk";

    private string _bloqvendatlmk;

    private static readonly string RO_CCORRENTE = "Ccorrente";

    private string _ccorrente;

    private static readonly string RO_CEP = "Cep";

    private string _cep;

    private static readonly string RO_CGC = "Cgc";

    private string _cgc;

    private static readonly string RO_CI = "Ci";

    private string _ci;

    private static readonly string RO_CIDADE = "Cidade";

    private string _cidade;

    private static readonly string RO_CODBAIRRO = "Codbairro";

    private decimal? _codbairro;

    private static readonly string RO_CODCIDADE = "Codcidade";

    private decimal? _codcidade;

    private static readonly string RO_CODCOMOCLIENTE = "Codcomocliente";

    private decimal? _codcomocliente;

    private static readonly string RO_CODCONTAB = "Codcontab";

    private string _codcontab;

    private static readonly string RO_CODCONTACOFINS = "Codcontacofins";

    private decimal? _codcontacofins;

    private static readonly string RO_CODCONTACSRF = "Codcontacsrf";

    private decimal? _codcontacsrf;

    private static readonly string RO_CODCONTAINSS = "Codcontainss";

    private decimal? _codcontainss;

    private static readonly string RO_CODCONTAIRRF = "Codcontairrf";

    private decimal? _codcontairrf;

    private static readonly string RO_CODCONTAISS = "Codcontaiss";

    private decimal? _codcontaiss;

    private static readonly string RO_CODCONTAPIS = "Codcontapis";

    private decimal? _codcontapis;

    private static readonly string RO_CODCONTASRF = "Codcontasrf";

    private decimal? _codcontasrf;

    private static readonly string RO_CODDISTRIB = "Coddistrib";

    private string _coddistrib;

    private static readonly string RO_CODEQUIPE = "Codequipe";

    private decimal? _codequipe;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODIGOCENTROCUSTO = "Codigocentrocusto";

    private string _codigocentrocusto;

    private static readonly string RO_CODMONITOR = "Codmonitor";

    private decimal? _codmonitor;

    private static readonly string RO_CODOPERACAO = "Codoperacao";

    private string _codoperacao;

    private static readonly string RO_CODPRACAPRINCIPAL = "Codpracaprincipal";

    private decimal? _codpracaprincipal;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal _codsupervisor;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_COMISSAOFIXA = "Comissaofixa";

    private decimal? _comissaofixa;

    private static readonly string RO_CONJUGE = "Conjuge";

    private string _conjuge;

    private static readonly string RO_CPF = "Cpf";

    private string _cpf;

    private static readonly string RO_CPFAUX = "Cpfaux";

    private string _cpfaux;

    private static readonly string RO_DIRENVIOFTP = "Direnvioftp";

    private string _direnvioftp;

    private static readonly string RO_DIRETORIOASSINATURA = "Diretorioassinatura";

    private string _diretorioassinatura;

    private static readonly string RO_DIRRECEPCAOFTP = "Dirrecepcaoftp";

    private string _dirrecepcaoftp;

    private static readonly string RO_DTENTREGADOC = "Dtentregadoc";

    private DateTime? _dtentregadoc;

    private static readonly string RO_DTEXCLUSAO = "Dtexclusao";

    private DateTime? _dtexclusao;

    private static readonly string RO_DTINFORMATIZA = "Dtinformatiza";

    private DateTime? _dtinformatiza;

    private static readonly string RO_DTINICIO = "Dtinicio";

    private DateTime? _dtinicio;

    private static readonly string RO_DTLIMENTREGADOC = "Dtlimentregadoc";

    private DateTime? _dtlimentregadoc;

    private static readonly string RO_DTNASC = "Dtnasc";

    private DateTime? _dtnasc;

    private static readonly string RO_DTNASCONJUGE = "Dtnasconjuge";

    private DateTime? _dtnasconjuge;

    private static readonly string RO_DTTERMINO = "Dttermino";

    private DateTime? _dttermino;

    private static readonly string RO_DTULTALTERACAO = "Dtultalteracao";

    private DateTime? _dtultalteracao;

    private static readonly string RO_DTULTPAGCONSELHO = "Dtultpagconselho";

    private DateTime? _dtultpagconselho;

    private static readonly string RO_DTULTVENDA = "Dtultvenda";

    private DateTime? _dtultvenda;

    private static readonly string RO_EMAIL = "Email";

    private string _email;

    private static readonly string RO_EMAIL2 = "Email2";

    private string _email2;

    private static readonly string RO_ENDERECO = "Endereco";

    private string _endereco;

    private static readonly string RO_ENDERECO2 = "Endereco2";

    private string _endereco2;

    private static readonly string RO_ESTADO = "Estado";

    private string _estado;

    private static readonly string RO_EXPORTADADOS = "Exportadados";

    private string _exportadados;

    private static readonly string RO_EXPORTARECF = "Exportarecf";

    private string _exportarecf;

    private static readonly string RO_EXPORTARPARAFORCAVENDAS = "Exportarparaforcavendas";

    private string _exportarparaforcavendas;

    private static readonly string RO_FAX = "Fax";

    private string _fax;

    private static readonly string RO_FIRMA = "Firma";

    private string _firma;

    private static readonly string RO_HORAFIMCONEXAOPALM = "Horafimconexaopalm";

    private decimal? _horafimconexaopalm;

    private static readonly string RO_HORAINICONEXAOPALM = "Horainiconexaopalm";

    private decimal? _horainiconexaopalm;

    private static readonly string RO_INDICECPFECHCOMISSAO = "Indicecpfechcomissao";

    private string _indicecpfechcomissao;

    private static readonly string RO_INDICERATEIOCOMISSAO = "Indicerateiocomissao";

    private decimal? _indicerateiocomissao;

    private static readonly string RO_INSCMUNICIPAL = "Inscmunicipal";

    private string _inscmunicipal;

    private static readonly string RO_INSS = "Inss";

    private decimal? _inss;

    private static readonly string RO_MASKPREPOSTO = "Maskpreposto";

    private string _maskpreposto;

    private static readonly string RO_MENS1 = "Mens1";

    private string _mens1;

    private static readonly string RO_MENS2 = "Mens2";

    private string _mens2;

    private static readonly string RO_MENS3 = "Mens3";

    private string _mens3;

    private static readonly string RO_MENS4 = "Mens4";

    private string _mens4;

    private static readonly string RO_MINUTOFIMCONEXAOPALM = "Minutofimconexaopalm";

    private decimal? _minutofimconexaopalm;

    private static readonly string RO_MINUTOINICONEXAOPALM = "Minutoiniconexaopalm";

    private decimal? _minutoiniconexaopalm;

    private static readonly string RO_MODELOPALM = "Modelopalm";

    private string _modelopalm;

    private static readonly string RO_MOTIVO = "Motivo";

    private string _motivo;

    private static readonly string RO_NOME = "Nome";

    private string _nome;

    private static readonly string RO_NUMAGENCIA = "Numagencia";

    private decimal? _numagencia;

    private static readonly string RO_NUMAGENCIAPOUP = "Numagenciapoup";

    private decimal? _numagenciapoup;

    private static readonly string RO_NUMBANCO = "Numbanco";

    private decimal? _numbanco;

    private static readonly string RO_NUMBANCOPOUP = "Numbancopoup";

    private decimal? _numbancopoup;

    private static readonly string RO_NUMCCORRENTE = "Numccorrente";

    private decimal? _numccorrente;

    private static readonly string RO_NUMCCORRENTEALFA = "Numccorrentealfa";

    private string _numccorrentealfa;

    private static readonly string RO_NUMCCORRENTEPOUP = "Numccorrentepoup";

    private decimal? _numccorrentepoup;

    private static readonly string RO_NUMCLIPOS = "Numclipos";

    private decimal? _numclipos;

    private static readonly string RO_NUMCONSELHO = "Numconselho";

    private string _numconselho;

    private static readonly string RO_NUMDEP = "Numdep";

    private decimal? _numdep;

    private static readonly string RO_NUMDVAGENCIA = "Numdvagencia";

    private string _numdvagencia;

    private static readonly string RO_NUMDVAGENCIAPOUP = "Numdvagenciapoup";

    private string _numdvagenciapoup;

    private static readonly string RO_NUMDVCCORRENTE = "Numdvccorrente";

    private string _numdvccorrente;

    private static readonly string RO_NUMDVCCORRENTEPOUP = "Numdvccorrentepoup";

    private string _numdvccorrentepoup;

    private static readonly string RO_NUMNOTABLOCO1 = "Numnotabloco1";

    private string _numnotabloco1;

    private static readonly string RO_NUMPEDECF = "Numpedecf";

    private decimal? _numpedecf;

    private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

    private decimal? _numserieequip;

    private static readonly string RO_NUMSERIEEQUIP2 = "Numserieequip2";

    private string _numserieequip2;

    private static readonly string RO_OBSBLOQ = "Obsbloq";

    private string _obsbloq;

    private static readonly string RO_OBSFORCAVENDAS1 = "Obsforcavendas1";

    private string _obsforcavendas1;

    private static readonly string RO_OBSFORCAVENDAS2 = "Obsforcavendas2";

    private string _obsforcavendas2;

    private static readonly string RO_OBSFORCAVENDAS3 = "Obsforcavendas3";

    private string _obsforcavendas3;

    private static readonly string RO_OBSFORCAVENDAS4 = "Obsforcavendas4";

    private string _obsforcavendas4;

    private static readonly string RO_OBS1 = "Obs1";

    private string _obs1;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_PERCACRESCIMOVENDA = "Percacrescimovenda";

    private decimal? _percacrescimovenda;

    private static readonly string RO_PERCACRESFV = "Percacresfv";

    private decimal? _percacresfv;

    private static readonly string RO_PERCCOFINSNFSERVICO = "Perccofinsnfservico";

    private decimal? _perccofinsnfservico;

    private static readonly string RO_PERCCSRF = "Perccsrf";

    private decimal? _perccsrf;

    private static readonly string RO_PERCENT = "Percent";

    private decimal? _percent;

    private static readonly string RO_PERCENT2 = "Percent2";

    private decimal? _percent2;

    private static readonly string RO_PERCINSS = "Percinss";

    private decimal? _percinss;

    private static readonly string RO_PERCIRRF = "Percirrf";

    private decimal? _percirrf;

    private static readonly string RO_PERCISS = "Perciss";

    private decimal? _perciss;

    private static readonly string RO_PERCMETADEPTO = "Percmetadepto";

    private decimal? _percmetadepto;

    private static readonly string RO_PERCOMMETA = "Percommeta";

    private decimal? _percommeta;

    private static readonly string RO_PERCPISNFSERVICO = "Percpisnfservico";

    private decimal? _percpisnfservico;

    private static readonly string RO_PERDESCMAX = "Perdescmax";

    private decimal? _perdescmax;

    private static readonly string RO_PERMAXVENDA = "Permaxvenda";

    private decimal? _permaxvenda;

    private static readonly string RO_PERMETA = "Permeta";

    private decimal? _permeta;

    private static readonly string RO_PERMETAMETRO = "Permetametro";

    private decimal? _permetametro;

    private static readonly string RO_PERMITEADIANTCOMISSAO = "Permiteadiantcomissao";

    private string _permiteadiantcomissao;

    private static readonly string RO_PRACA1 = "Praca1";

    private string _praca1;

    private static readonly string RO_PRACA2 = "Praca2";

    private string _praca2;

    private static readonly string RO_PROXCODCLIPALM = "Proxcodclipalm";

    private decimal? _proxcodclipalm;

    private static readonly string RO_PROXNUMPED = "Proxnumped";

    private decimal? _proxnumped;

    private static readonly string RO_PROXNUMPEDFORCA = "Proxnumpedforca";

    private decimal? _proxnumpedforca;

    private static readonly string RO_PROXNUMPEDWEB = "Proxnumpedweb";

    private decimal? _proxnumpedweb;

    private static readonly string RO_QTITENSPEDPREV = "Qtitenspedprev";

    private decimal? _qtitenspedprev;

    private static readonly string RO_QTPEDPREV = "Qtpedprev";

    private decimal? _qtpedprev;

    private static readonly string RO_ROTAMASTERFOODS = "Rotamasterfoods";

    private string _rotamasterfoods;

    private static readonly string RO_SENHA = "Senha";

    private string _senha;

    private static readonly string RO_SENHADIALUP = "Senhadialup";

    private string _senhadialup;

    private static readonly string RO_SENHAFTP = "Senhaftp";

    private string _senhaftp;

    private static readonly string RO_SENHALOGIN = "Senhalogin";

    private string _senhalogin;

    private static readonly string RO_SENHAPOP = "Senhapop";

    private string _senhapop;

    private static readonly string RO_SERVFTP = "Servftp";

    private string _servftp;

    private static readonly string RO_SERVPOP = "Servpop";

    private string _servpop;

    private static readonly string RO_SERVSMTP = "Servsmtp";

    private string _servsmtp;

    private static readonly string RO_SIMPLESNACIONAL = "Simplesnacional";

    private string _simplesnacional;

    private static readonly string RO_TELEFONE1 = "Telefone1";

    private string _telefone1;

    private static readonly string RO_TELEFONE2 = "Telefone2";

    private string _telefone2;

    private static readonly string RO_TELPROVEDOR = "Telprovedor";

    private string _telprovedor;

    private static readonly string RO_TIPOCOMISSAO = "Tipocomissao";

    private string _tipocomissao;

    private static readonly string RO_TIPOFIRMA = "Tipofirma";

    private string _tipofirma;

    private static readonly string RO_TIPOPESSOA = "Tipopessoa";

    private string _tipopessoa;

    private static readonly string RO_TIPOVEND = "Tipovend";

    private string _tipovend;

    private static readonly string RO_ULTNUMPED = "Ultnumped";

    private decimal? _ultnumped;

    private static readonly string RO_USACOBRANCACARTAO = "Usacobrancacartao";

    private string _usacobrancacartao;

    private static readonly string RO_USADEBCREDRCA = "Usadebcredrca";

    private string _usadebcredrca;

    private static readonly string RO_USARRCAOPERADOR = "Usarrcaoperador";

    private string _usarrcaoperador;

    private static readonly string RO_USURDIALUP = "Usurdialup";

    private string _usurdialup;

    private static readonly string RO_USURDIRFV = "Usurdirfv";

    private string _usurdirfv;

    private static readonly string RO_USURFTP = "Usurftp";

    private string _usurftp;

    private static readonly string RO_USURLOGIN = "Usurlogin";

    private string _usurlogin;

    private static readonly string RO_USURPOP = "Usurpop";

    private string _usurpop;

    private static readonly string RO_VALIDARACRESCDESCPRECOFIXO = "Validaracrescdescprecofixo";

    private string _validaracrescdescprecofixo;

    private static readonly string RO_VENDEDORQK = "Vendedorqk";

    private string _vendedorqk;

    private static readonly string RO_VISUALIZARPRODDEPTOSEC = "Visualizarproddeptosec";

    private string _visualizarproddeptosec;

    private static readonly string RO_VLCORRENTE = "Vlcorrente";

    private decimal? _vlcorrente;

    private static readonly string RO_VLLIMCRED = "Vllimcred";

    private decimal? _vllimcred;

    private static readonly string RO_VLMAXTROCA = "Vlmaxtroca";

    private decimal? _vlmaxtroca;

    private static readonly string RO_VLVENDAMINPED = "Vlvendaminped";

    private decimal? _vlvendaminped;

    private static readonly string RO_VLVENDAPREV = "Vlvendaprev";

    private decimal? _vlvendaprev;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Areaatuacao
    {
        get
        {
            PropriedadeAcessada(RO_AREAATUACAO);
            return _areaatuacao;
        }
        set
        {
            PropriedadeModificada(RO_AREAATUACAO, value);
            _areaatuacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Bairro
    {
        get
        {
            PropriedadeAcessada(RO_BAIRRO);
            return _bairro;
        }
        set
        {
            PropriedadeModificada(RO_BAIRRO, value);
            _bairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Bip
    {
        get
        {
            PropriedadeAcessada(RO_BIP);
            return _bip;
        }
        set
        {
            PropriedadeModificada(RO_BIP, value);
            _bip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqcomis
    {
        get
        {
            PropriedadeAcessada(RO_BLOQCOMIS);
            return _bloqcomis;
        }
        set
        {
            PropriedadeModificada(RO_BLOQCOMIS, value);
            _bloqcomis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqueio
    {
        get
        {
            PropriedadeAcessada(RO_BLOQUEIO);
            return _bloqueio;
        }
        set
        {
            PropriedadeModificada(RO_BLOQUEIO, value);
            _bloqueio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqvendatlmk
    {
        get
        {
            PropriedadeAcessada(RO_BLOQVENDATLMK);
            return _bloqvendatlmk;
        }
        set
        {
            PropriedadeModificada(RO_BLOQVENDATLMK, value);
            _bloqvendatlmk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Ccorrente
    {
        get
        {
            PropriedadeAcessada(RO_CCORRENTE);
            return _ccorrente;
        }
        set
        {
            PropriedadeModificada(RO_CCORRENTE, value);
            _ccorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Cep
    {
        get
        {
            PropriedadeAcessada(RO_CEP);
            return _cep;
        }
        set
        {
            PropriedadeModificada(RO_CEP, value);
            _cep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cgc
    {
        get
        {
            PropriedadeAcessada(RO_CGC);
            return _cgc;
        }
        set
        {
            PropriedadeModificada(RO_CGC, value);
            _cgc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Ci
    {
        get
        {
            PropriedadeAcessada(RO_CI);
            return _ci;
        }
        set
        {
            PropriedadeModificada(RO_CI, value);
            _ci = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Cidade
    {
        get
        {
            PropriedadeAcessada(RO_CIDADE);
            return _cidade;
        }
        set
        {
            PropriedadeModificada(RO_CIDADE, value);
            _cidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbairro
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIRRO);
            return _codbairro;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIRRO, value);
            _codbairro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcidade
    {
        get
        {
            PropriedadeAcessada(RO_CODCIDADE);
            return _codcidade;
        }
        set
        {
            PropriedadeModificada(RO_CODCIDADE, value);
            _codcidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcomocliente
    {
        get
        {
            PropriedadeAcessada(RO_CODCOMOCLIENTE);
            return _codcomocliente;
        }
        set
        {
            PropriedadeModificada(RO_CODCOMOCLIENTE, value);
            _codcomocliente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Codcontab
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAB);
            return _codcontab;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAB, value);
            _codcontab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacofins
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACOFINS);
            return _codcontacofins;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACOFINS, value);
            _codcontacofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontacsrf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTACSRF);
            return _codcontacsrf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTACSRF, value);
            _codcontacsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontainss
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAINSS);
            return _codcontainss;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAINSS, value);
            _codcontainss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontairrf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAIRRF);
            return _codcontairrf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAIRRF, value);
            _codcontairrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontaiss
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAISS);
            return _codcontaiss;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAISS, value);
            _codcontaiss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontapis
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTAPIS);
            return _codcontapis;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTAPIS, value);
            _codcontapis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codcontasrf
    {
        get
        {
            PropriedadeAcessada(RO_CODCONTASRF);
            return _codcontasrf;
        }
        set
        {
            PropriedadeModificada(RO_CODCONTASRF, value);
            _codcontasrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Coddistrib
    {
        get
        {
            PropriedadeAcessada(RO_CODDISTRIB);
            return _coddistrib;
        }
        set
        {
            PropriedadeModificada(RO_CODDISTRIB, value);
            _coddistrib = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codequipe
    {
        get
        {
            PropriedadeAcessada(RO_CODEQUIPE);
            return _codequipe;
        }
        set
        {
            PropriedadeModificada(RO_CODEQUIPE, value);
            _codequipe = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Codigocentrocusto
    {
        get
        {
            PropriedadeAcessada(RO_CODIGOCENTROCUSTO);
            return _codigocentrocusto;
        }
        set
        {
            PropriedadeModificada(RO_CODIGOCENTROCUSTO, value);
            _codigocentrocusto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmonitor
    {
        get
        {
            PropriedadeAcessada(RO_CODMONITOR);
            return _codmonitor;
        }
        set
        {
            PropriedadeModificada(RO_CODMONITOR, value);
            _codmonitor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codoperacao
    {
        get
        {
            PropriedadeAcessada(RO_CODOPERACAO);
            return _codoperacao;
        }
        set
        {
            PropriedadeModificada(RO_CODOPERACAO, value);
            _codoperacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codpracaprincipal
    {
        get
        {
            PropriedadeAcessada(RO_CODPRACAPRINCIPAL);
            return _codpracaprincipal;
        }
        set
        {
            PropriedadeModificada(RO_CODPRACAPRINCIPAL, value);
            _codpracaprincipal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codsupervisor
    {
        get
        {
            PropriedadeAcessada(RO_CODSUPERVISOR);
            return _codsupervisor;
        }
        set
        {
            PropriedadeModificada(RO_CODSUPERVISOR, value);
            _codsupervisor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Codusur
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR);
            return _codusur;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR, value);
            _codusur = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Comissaofixa
    {
        get
        {
            PropriedadeAcessada(RO_COMISSAOFIXA);
            return _comissaofixa;
        }
        set
        {
            PropriedadeModificada(RO_COMISSAOFIXA, value);
            _comissaofixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Conjuge
    {
        get
        {
            PropriedadeAcessada(RO_CONJUGE);
            return _conjuge;
        }
        set
        {
            PropriedadeModificada(RO_CONJUGE, value);
            _conjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cpf
    {
        get
        {
            PropriedadeAcessada(RO_CPF);
            return _cpf;
        }
        set
        {
            PropriedadeModificada(RO_CPF, value);
            _cpf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Cpfaux
    {
        get
        {
            PropriedadeAcessada(RO_CPFAUX);
            return _cpfaux;
        }
        set
        {
            PropriedadeModificada(RO_CPFAUX, value);
            _cpfaux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Direnvioftp
    {
        get
        {
            PropriedadeAcessada(RO_DIRENVIOFTP);
            return _direnvioftp;
        }
        set
        {
            PropriedadeModificada(RO_DIRENVIOFTP, value);
            _direnvioftp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Diretorioassinatura
    {
        get
        {
            PropriedadeAcessada(RO_DIRETORIOASSINATURA);
            return _diretorioassinatura;
        }
        set
        {
            PropriedadeModificada(RO_DIRETORIOASSINATURA, value);
            _diretorioassinatura = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Dirrecepcaoftp
    {
        get
        {
            PropriedadeAcessada(RO_DIRRECEPCAOFTP);
            return _dirrecepcaoftp;
        }
        set
        {
            PropriedadeModificada(RO_DIRRECEPCAOFTP, value);
            _dirrecepcaoftp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtentregadoc
    {
        get
        {
            PropriedadeAcessada(RO_DTENTREGADOC);
            return _dtentregadoc;
        }
        set
        {
            PropriedadeModificada(RO_DTENTREGADOC, value);
            _dtentregadoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTEXCLUSAO);
            return _dtexclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTEXCLUSAO, value);
            _dtexclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinformatiza
    {
        get
        {
            PropriedadeAcessada(RO_DTINFORMATIZA);
            return _dtinformatiza;
        }
        set
        {
            PropriedadeModificada(RO_DTINFORMATIZA, value);
            _dtinformatiza = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicio
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIO);
            return _dtinicio;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIO, value);
            _dtinicio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlimentregadoc
    {
        get
        {
            PropriedadeAcessada(RO_DTLIMENTREGADOC);
            return _dtlimentregadoc;
        }
        set
        {
            PropriedadeModificada(RO_DTLIMENTREGADOC, value);
            _dtlimentregadoc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnasc
    {
        get
        {
            PropriedadeAcessada(RO_DTNASC);
            return _dtnasc;
        }
        set
        {
            PropriedadeModificada(RO_DTNASC, value);
            _dtnasc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtnasconjuge
    {
        get
        {
            PropriedadeAcessada(RO_DTNASCONJUGE);
            return _dtnasconjuge;
        }
        set
        {
            PropriedadeModificada(RO_DTNASCONJUGE, value);
            _dtnasconjuge = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dttermino
    {
        get
        {
            PropriedadeAcessada(RO_DTTERMINO);
            return _dttermino;
        }
        set
        {
            PropriedadeModificada(RO_DTTERMINO, value);
            _dttermino = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultalteracao
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERACAO);
            return _dtultalteracao;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERACAO, value);
            _dtultalteracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultpagconselho
    {
        get
        {
            PropriedadeAcessada(RO_DTULTPAGCONSELHO);
            return _dtultpagconselho;
        }
        set
        {
            PropriedadeModificada(RO_DTULTPAGCONSELHO, value);
            _dtultpagconselho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultvenda
    {
        get
        {
            PropriedadeAcessada(RO_DTULTVENDA);
            return _dtultvenda;
        }
        set
        {
            PropriedadeModificada(RO_DTULTVENDA, value);
            _dtultvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Email
    {
        get
        {
            PropriedadeAcessada(RO_EMAIL);
            return _email;
        }
        set
        {
            PropriedadeModificada(RO_EMAIL, value);
            _email = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Email2
    {
        get
        {
            PropriedadeAcessada(RO_EMAIL2);
            return _email2;
        }
        set
        {
            PropriedadeModificada(RO_EMAIL2, value);
            _email2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endereco
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECO);
            return _endereco;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECO, value);
            _endereco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Endereco2
    {
        get
        {
            PropriedadeAcessada(RO_ENDERECO2);
            return _endereco2;
        }
        set
        {
            PropriedadeModificada(RO_ENDERECO2, value);
            _endereco2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Estado
    {
        get
        {
            PropriedadeAcessada(RO_ESTADO);
            return _estado;
        }
        set
        {
            PropriedadeModificada(RO_ESTADO, value);
            _estado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadados
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADADOS);
            return _exportadados;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADADOS, value);
            _exportadados = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportarparaforcavendas
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTARPARAFORCAVENDAS);
            return _exportarparaforcavendas;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTARPARAFORCAVENDAS, value);
            _exportarparaforcavendas = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Fax
    {
        get
        {
            PropriedadeAcessada(RO_FAX);
            return _fax;
        }
        set
        {
            PropriedadeModificada(RO_FAX, value);
            _fax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Firma
    {
        get
        {
            PropriedadeAcessada(RO_FIRMA);
            return _firma;
        }
        set
        {
            PropriedadeModificada(RO_FIRMA, value);
            _firma = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafimconexaopalm
    {
        get
        {
            PropriedadeAcessada(RO_HORAFIMCONEXAOPALM);
            return _horafimconexaopalm;
        }
        set
        {
            PropriedadeModificada(RO_HORAFIMCONEXAOPALM, value);
            _horafimconexaopalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horainiconexaopalm
    {
        get
        {
            PropriedadeAcessada(RO_HORAINICONEXAOPALM);
            return _horainiconexaopalm;
        }
        set
        {
            PropriedadeModificada(RO_HORAINICONEXAOPALM, value);
            _horainiconexaopalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Indicecpfechcomissao
    {
        get
        {
            PropriedadeAcessada(RO_INDICECPFECHCOMISSAO);
            return _indicecpfechcomissao;
        }
        set
        {
            PropriedadeModificada(RO_INDICECPFECHCOMISSAO, value);
            _indicecpfechcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Indicerateiocomissao
    {
        get
        {
            PropriedadeAcessada(RO_INDICERATEIOCOMISSAO);
            return _indicerateiocomissao;
        }
        set
        {
            PropriedadeModificada(RO_INDICERATEIOCOMISSAO, value);
            _indicerateiocomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Inscmunicipal
    {
        get
        {
            PropriedadeAcessada(RO_INSCMUNICIPAL);
            return _inscmunicipal;
        }
        set
        {
            PropriedadeModificada(RO_INSCMUNICIPAL, value);
            _inscmunicipal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 0)]
    public decimal? Inss
    {
        get
        {
            PropriedadeAcessada(RO_INSS);
            return _inss;
        }
        set
        {
            PropriedadeModificada(RO_INSS, value);
            _inss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Maskpreposto
    {
        get
        {
            PropriedadeAcessada(RO_MASKPREPOSTO);
            return _maskpreposto;
        }
        set
        {
            PropriedadeModificada(RO_MASKPREPOSTO, value);
            _maskpreposto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Mens1
    {
        get
        {
            PropriedadeAcessada(RO_MENS1);
            return _mens1;
        }
        set
        {
            PropriedadeModificada(RO_MENS1, value);
            _mens1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Mens2
    {
        get
        {
            PropriedadeAcessada(RO_MENS2);
            return _mens2;
        }
        set
        {
            PropriedadeModificada(RO_MENS2, value);
            _mens2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Mens3
    {
        get
        {
            PropriedadeAcessada(RO_MENS3);
            return _mens3;
        }
        set
        {
            PropriedadeModificada(RO_MENS3, value);
            _mens3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
    public string Mens4
    {
        get
        {
            PropriedadeAcessada(RO_MENS4);
            return _mens4;
        }
        set
        {
            PropriedadeModificada(RO_MENS4, value);
            _mens4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofimconexaopalm
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOFIMCONEXAOPALM);
            return _minutofimconexaopalm;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOFIMCONEXAOPALM, value);
            _minutofimconexaopalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoiniconexaopalm
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOINICONEXAOPALM);
            return _minutoiniconexaopalm;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOINICONEXAOPALM, value);
            _minutoiniconexaopalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Modelopalm
    {
        get
        {
            PropriedadeAcessada(RO_MODELOPALM);
            return _modelopalm;
        }
        set
        {
            PropriedadeModificada(RO_MODELOPALM, value);
            _modelopalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Motivo
    {
        get
        {
            PropriedadeAcessada(RO_MOTIVO);
            return _motivo;
        }
        set
        {
            PropriedadeModificada(RO_MOTIVO, value);
            _motivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Nome
    {
        get
        {
            PropriedadeAcessada(RO_NOME);
            return _nome;
        }
        set
        {
            PropriedadeModificada(RO_NOME, value);
            _nome = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numagencia
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGENCIA);
            return _numagencia;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGENCIA, value);
            _numagencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numagenciapoup
    {
        get
        {
            PropriedadeAcessada(RO_NUMAGENCIAPOUP);
            return _numagenciapoup;
        }
        set
        {
            PropriedadeModificada(RO_NUMAGENCIAPOUP, value);
            _numagenciapoup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Numbancopoup
    {
        get
        {
            PropriedadeAcessada(RO_NUMBANCOPOUP);
            return _numbancopoup;
        }
        set
        {
            PropriedadeModificada(RO_NUMBANCOPOUP, value);
            _numbancopoup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numccorrente
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTE);
            return _numccorrente;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTE, value);
            _numccorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Numccorrentealfa
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTEALFA);
            return _numccorrentealfa;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTEALFA, value);
            _numccorrentealfa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numccorrentepoup
    {
        get
        {
            PropriedadeAcessada(RO_NUMCCORRENTEPOUP);
            return _numccorrentepoup;
        }
        set
        {
            PropriedadeModificada(RO_NUMCCORRENTEPOUP, value);
            _numccorrentepoup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 8)]
    public decimal? Numclipos
    {
        get
        {
            PropriedadeAcessada(RO_NUMCLIPOS);
            return _numclipos;
        }
        set
        {
            PropriedadeModificada(RO_NUMCLIPOS, value);
            _numclipos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Numconselho
    {
        get
        {
            PropriedadeAcessada(RO_NUMCONSELHO);
            return _numconselho;
        }
        set
        {
            PropriedadeModificada(RO_NUMCONSELHO, value);
            _numconselho = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Numdep
    {
        get
        {
            PropriedadeAcessada(RO_NUMDEP);
            return _numdep;
        }
        set
        {
            PropriedadeModificada(RO_NUMDEP, value);
            _numdep = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numdvagencia
    {
        get
        {
            PropriedadeAcessada(RO_NUMDVAGENCIA);
            return _numdvagencia;
        }
        set
        {
            PropriedadeModificada(RO_NUMDVAGENCIA, value);
            _numdvagencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Numdvagenciapoup
    {
        get
        {
            PropriedadeAcessada(RO_NUMDVAGENCIAPOUP);
            return _numdvagenciapoup;
        }
        set
        {
            PropriedadeModificada(RO_NUMDVAGENCIAPOUP, value);
            _numdvagenciapoup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Numdvccorrente
    {
        get
        {
            PropriedadeAcessada(RO_NUMDVCCORRENTE);
            return _numdvccorrente;
        }
        set
        {
            PropriedadeModificada(RO_NUMDVCCORRENTE, value);
            _numdvccorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Numdvccorrentepoup
    {
        get
        {
            PropriedadeAcessada(RO_NUMDVCCORRENTEPOUP);
            return _numdvccorrentepoup;
        }
        set
        {
            PropriedadeModificada(RO_NUMDVCCORRENTEPOUP, value);
            _numdvccorrentepoup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 9, Precisao = 0)]
    public string Numnotabloco1
    {
        get
        {
            PropriedadeAcessada(RO_NUMNOTABLOCO1);
            return _numnotabloco1;
        }
        set
        {
            PropriedadeModificada(RO_NUMNOTABLOCO1, value);
            _numnotabloco1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numpedecf
    {
        get
        {
            PropriedadeAcessada(RO_NUMPEDECF);
            return _numpedecf;
        }
        set
        {
            PropriedadeModificada(RO_NUMPEDECF, value);
            _numpedecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numserieequip
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP);
            return _numserieequip;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP, value);
            _numserieequip = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Numserieequip2
    {
        get
        {
            PropriedadeAcessada(RO_NUMSERIEEQUIP2);
            return _numserieequip2;
        }
        set
        {
            PropriedadeModificada(RO_NUMSERIEEQUIP2, value);
            _numserieequip2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Obsbloq
    {
        get
        {
            PropriedadeAcessada(RO_OBSBLOQ);
            return _obsbloq;
        }
        set
        {
            PropriedadeModificada(RO_OBSBLOQ, value);
            _obsbloq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsforcavendas1
    {
        get
        {
            PropriedadeAcessada(RO_OBSFORCAVENDAS1);
            return _obsforcavendas1;
        }
        set
        {
            PropriedadeModificada(RO_OBSFORCAVENDAS1, value);
            _obsforcavendas1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsforcavendas2
    {
        get
        {
            PropriedadeAcessada(RO_OBSFORCAVENDAS2);
            return _obsforcavendas2;
        }
        set
        {
            PropriedadeModificada(RO_OBSFORCAVENDAS2, value);
            _obsforcavendas2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsforcavendas3
    {
        get
        {
            PropriedadeAcessada(RO_OBSFORCAVENDAS3);
            return _obsforcavendas3;
        }
        set
        {
            PropriedadeModificada(RO_OBSFORCAVENDAS3, value);
            _obsforcavendas3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obsforcavendas4
    {
        get
        {
            PropriedadeAcessada(RO_OBSFORCAVENDAS4);
            return _obsforcavendas4;
        }
        set
        {
            PropriedadeModificada(RO_OBSFORCAVENDAS4, value);
            _obsforcavendas4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obs1
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obs2
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percacrescimovenda
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCIMOVENDA);
            return _percacrescimovenda;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCIMOVENDA, value);
            _percacrescimovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percacresfv
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESFV);
            return _percacresfv;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESFV, value);
            _percacresfv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perccofinsnfservico
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOFINSNFSERVICO);
            return _perccofinsnfservico;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOFINSNFSERVICO, value);
            _perccofinsnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perccsrf
    {
        get
        {
            PropriedadeAcessada(RO_PERCCSRF);
            return _perccsrf;
        }
        set
        {
            PropriedadeModificada(RO_PERCCSRF, value);
            _perccsrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percent
    {
        get
        {
            PropriedadeAcessada(RO_PERCENT);
            return _percent;
        }
        set
        {
            PropriedadeModificada(RO_PERCENT, value);
            _percent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percent2
    {
        get
        {
            PropriedadeAcessada(RO_PERCENT2);
            return _percent2;
        }
        set
        {
            PropriedadeModificada(RO_PERCENT2, value);
            _percent2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Percinss
    {
        get
        {
            PropriedadeAcessada(RO_PERCINSS);
            return _percinss;
        }
        set
        {
            PropriedadeModificada(RO_PERCINSS, value);
            _percinss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Percirrf
    {
        get
        {
            PropriedadeAcessada(RO_PERCIRRF);
            return _percirrf;
        }
        set
        {
            PropriedadeModificada(RO_PERCIRRF, value);
            _percirrf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 2)]
    public decimal? Perciss
    {
        get
        {
            PropriedadeAcessada(RO_PERCISS);
            return _perciss;
        }
        set
        {
            PropriedadeModificada(RO_PERCISS, value);
            _perciss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Percmetadepto
    {
        get
        {
            PropriedadeAcessada(RO_PERCMETADEPTO);
            return _percmetadepto;
        }
        set
        {
            PropriedadeModificada(RO_PERCMETADEPTO, value);
            _percmetadepto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percommeta
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMMETA);
            return _percommeta;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMMETA, value);
            _percommeta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Percpisnfservico
    {
        get
        {
            PropriedadeAcessada(RO_PERCPISNFSERVICO);
            return _percpisnfservico;
        }
        set
        {
            PropriedadeModificada(RO_PERCPISNFSERVICO, value);
            _percpisnfservico = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescmax
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAX);
            return _perdescmax;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAX, value);
            _perdescmax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Permaxvenda
    {
        get
        {
            PropriedadeAcessada(RO_PERMAXVENDA);
            return _permaxvenda;
        }
        set
        {
            PropriedadeModificada(RO_PERMAXVENDA, value);
            _permaxvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Permeta
    {
        get
        {
            PropriedadeAcessada(RO_PERMETA);
            return _permeta;
        }
        set
        {
            PropriedadeModificada(RO_PERMETA, value);
            _permeta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Permetametro
    {
        get
        {
            PropriedadeAcessada(RO_PERMETAMETRO);
            return _permetametro;
        }
        set
        {
            PropriedadeModificada(RO_PERMETAMETRO, value);
            _permetametro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteadiantcomissao
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEADIANTCOMISSAO);
            return _permiteadiantcomissao;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEADIANTCOMISSAO, value);
            _permiteadiantcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Praca1
    {
        get
        {
            PropriedadeAcessada(RO_PRACA1);
            return _praca1;
        }
        set
        {
            PropriedadeModificada(RO_PRACA1, value);
            _praca1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Praca2
    {
        get
        {
            PropriedadeAcessada(RO_PRACA2);
            return _praca2;
        }
        set
        {
            PropriedadeModificada(RO_PRACA2, value);
            _praca2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Proxcodclipalm
    {
        get
        {
            PropriedadeAcessada(RO_PROXCODCLIPALM);
            return _proxcodclipalm;
        }
        set
        {
            PropriedadeModificada(RO_PROXCODCLIPALM, value);
            _proxcodclipalm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Proxnumped
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPED);
            return _proxnumped;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPED, value);
            _proxnumped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumpedforca
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPEDFORCA);
            return _proxnumpedforca;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPEDFORCA, value);
            _proxnumpedforca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Proxnumpedweb
    {
        get
        {
            PropriedadeAcessada(RO_PROXNUMPEDWEB);
            return _proxnumpedweb;
        }
        set
        {
            PropriedadeModificada(RO_PROXNUMPEDWEB, value);
            _proxnumpedweb = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtitenspedprev
    {
        get
        {
            PropriedadeAcessada(RO_QTITENSPEDPREV);
            return _qtitenspedprev;
        }
        set
        {
            PropriedadeModificada(RO_QTITENSPEDPREV, value);
            _qtitenspedprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtpedprev
    {
        get
        {
            PropriedadeAcessada(RO_QTPEDPREV);
            return _qtpedprev;
        }
        set
        {
            PropriedadeModificada(RO_QTPEDPREV, value);
            _qtpedprev = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
    public string Rotamasterfoods
    {
        get
        {
            PropriedadeAcessada(RO_ROTAMASTERFOODS);
            return _rotamasterfoods;
        }
        set
        {
            PropriedadeModificada(RO_ROTAMASTERFOODS, value);
            _rotamasterfoods = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senha
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
    public string Senhadialup
    {
        get
        {
            PropriedadeAcessada(RO_SENHADIALUP);
            return _senhadialup;
        }
        set
        {
            PropriedadeModificada(RO_SENHADIALUP, value);
            _senhadialup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senhaftp
    {
        get
        {
            PropriedadeAcessada(RO_SENHAFTP);
            return _senhaftp;
        }
        set
        {
            PropriedadeModificada(RO_SENHAFTP, value);
            _senhaftp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senhalogin
    {
        get
        {
            PropriedadeAcessada(RO_SENHALOGIN);
            return _senhalogin;
        }
        set
        {
            PropriedadeModificada(RO_SENHALOGIN, value);
            _senhalogin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
    public string Senhapop
    {
        get
        {
            PropriedadeAcessada(RO_SENHAPOP);
            return _senhapop;
        }
        set
        {
            PropriedadeModificada(RO_SENHAPOP, value);
            _senhapop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Servftp
    {
        get
        {
            PropriedadeAcessada(RO_SERVFTP);
            return _servftp;
        }
        set
        {
            PropriedadeModificada(RO_SERVFTP, value);
            _servftp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Servpop
    {
        get
        {
            PropriedadeAcessada(RO_SERVPOP);
            return _servpop;
        }
        set
        {
            PropriedadeModificada(RO_SERVPOP, value);
            _servpop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Servsmtp
    {
        get
        {
            PropriedadeAcessada(RO_SERVSMTP);
            return _servsmtp;
        }
        set
        {
            PropriedadeModificada(RO_SERVSMTP, value);
            _servsmtp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Simplesnacional
    {
        get
        {
            PropriedadeAcessada(RO_SIMPLESNACIONAL);
            return _simplesnacional;
        }
        set
        {
            PropriedadeModificada(RO_SIMPLESNACIONAL, value);
            _simplesnacional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telefone1
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONE1);
            return _telefone1;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONE1, value);
            _telefone1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
    public string Telefone2
    {
        get
        {
            PropriedadeAcessada(RO_TELEFONE2);
            return _telefone2;
        }
        set
        {
            PropriedadeModificada(RO_TELEFONE2, value);
            _telefone2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Telprovedor
    {
        get
        {
            PropriedadeAcessada(RO_TELPROVEDOR);
            return _telprovedor;
        }
        set
        {
            PropriedadeModificada(RO_TELPROVEDOR, value);
            _telprovedor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipofirma
    {
        get
        {
            PropriedadeAcessada(RO_TIPOFIRMA);
            return _tipofirma;
        }
        set
        {
            PropriedadeModificada(RO_TIPOFIRMA, value);
            _tipofirma = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipopessoa
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPESSOA);
            return _tipopessoa;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPESSOA, value);
            _tipopessoa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Tipovend
    {
        get
        {
            PropriedadeAcessada(RO_TIPOVEND);
            return _tipovend;
        }
        set
        {
            PropriedadeModificada(RO_TIPOVEND, value);
            _tipovend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Ultnumped
    {
        get
        {
            PropriedadeAcessada(RO_ULTNUMPED);
            return _ultnumped;
        }
        set
        {
            PropriedadeModificada(RO_ULTNUMPED, value);
            _ultnumped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usacobrancacartao
    {
        get
        {
            PropriedadeAcessada(RO_USACOBRANCACARTAO);
            return _usacobrancacartao;
        }
        set
        {
            PropriedadeModificada(RO_USACOBRANCACARTAO, value);
            _usacobrancacartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usadebcredrca
    {
        get
        {
            PropriedadeAcessada(RO_USADEBCREDRCA);
            return _usadebcredrca;
        }
        set
        {
            PropriedadeModificada(RO_USADEBCREDRCA, value);
            _usadebcredrca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Usarrcaoperador
    {
        get
        {
            PropriedadeAcessada(RO_USARRCAOPERADOR);
            return _usarrcaoperador;
        }
        set
        {
            PropriedadeModificada(RO_USARRCAOPERADOR, value);
            _usarrcaoperador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usurdialup
    {
        get
        {
            PropriedadeAcessada(RO_USURDIALUP);
            return _usurdialup;
        }
        set
        {
            PropriedadeModificada(RO_USURDIALUP, value);
            _usurdialup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
    public string Usurdirfv
    {
        get
        {
            PropriedadeAcessada(RO_USURDIRFV);
            return _usurdirfv;
        }
        set
        {
            PropriedadeModificada(RO_USURDIRFV, value);
            _usurdirfv = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usurftp
    {
        get
        {
            PropriedadeAcessada(RO_USURFTP);
            return _usurftp;
        }
        set
        {
            PropriedadeModificada(RO_USURFTP, value);
            _usurftp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usurlogin
    {
        get
        {
            PropriedadeAcessada(RO_USURLOGIN);
            return _usurlogin;
        }
        set
        {
            PropriedadeModificada(RO_USURLOGIN, value);
            _usurlogin = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Usurpop
    {
        get
        {
            PropriedadeAcessada(RO_USURPOP);
            return _usurpop;
        }
        set
        {
            PropriedadeModificada(RO_USURPOP, value);
            _usurpop = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Validaracrescdescprecofixo
    {
        get
        {
            PropriedadeAcessada(RO_VALIDARACRESCDESCPRECOFIXO);
            return _validaracrescdescprecofixo;
        }
        set
        {
            PropriedadeModificada(RO_VALIDARACRESCDESCPRECOFIXO, value);
            _validaracrescdescprecofixo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Vendedorqk
    {
        get
        {
            PropriedadeAcessada(RO_VENDEDORQK);
            return _vendedorqk;
        }
        set
        {
            PropriedadeModificada(RO_VENDEDORQK, value);
            _vendedorqk = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Visualizarproddeptosec
    {
        get
        {
            PropriedadeAcessada(RO_VISUALIZARPRODDEPTOSEC);
            return _visualizarproddeptosec;
        }
        set
        {
            PropriedadeModificada(RO_VISUALIZARPRODDEPTOSEC, value);
            _visualizarproddeptosec = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcorrente
    {
        get
        {
            PropriedadeAcessada(RO_VLCORRENTE);
            return _vlcorrente;
        }
        set
        {
            PropriedadeModificada(RO_VLCORRENTE, value);
            _vlcorrente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vllimcred
    {
        get
        {
            PropriedadeAcessada(RO_VLLIMCRED);
            return _vllimcred;
        }
        set
        {
            PropriedadeModificada(RO_VLLIMCRED, value);
            _vllimcred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Vlmaxtroca
    {
        get
        {
            PropriedadeAcessada(RO_VLMAXTROCA);
            return _vlmaxtroca;
        }
        set
        {
            PropriedadeModificada(RO_VLMAXTROCA, value);
            _vlmaxtroca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvendaminped
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDAMINPED);
            return _vlvendaminped;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDAMINPED, value);
            _vlvendaminped = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCUSUARI", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
    public decimal? Vlvendaprev
    {
        get
        {
            PropriedadeAcessada(RO_VLVENDAPREV);
            return _vlvendaprev;
        }
        set
        {
            PropriedadeModificada(RO_VLVENDAPREV, value);
            _vlvendaprev = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCUSUARI";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _areaatuacao = AlterarTipo<string>(leitor["Areaatuacao"]);
        _bairro = AlterarTipo<string>(leitor["Bairro"]);
        _bip = AlterarTipo<string>(leitor["Bip"]);
        _bloqcomis = AlterarTipo<string>(leitor["Bloqcomis"]);
        _bloqueio = AlterarTipo<string>(leitor["Bloqueio"]);
        _bloqvendatlmk = AlterarTipo<string>(leitor["Bloqvendatlmk"]);
        _ccorrente = AlterarTipo<string>(leitor["Ccorrente"]);
        _cep = AlterarTipo<string>(leitor["Cep"]);
        _cgc = AlterarTipo<string>(leitor["Cgc"]);
        _ci = AlterarTipo<string>(leitor["Ci"]);
        _cidade = AlterarTipo<string>(leitor["Cidade"]);
        _codbairro = AlterarTipo<decimal?>(leitor["Codbairro"]);
        _codcidade = AlterarTipo<decimal?>(leitor["Codcidade"]);
        _codcomocliente = AlterarTipo<decimal?>(leitor["Codcomocliente"]);
        _codcontab = AlterarTipo<string>(leitor["Codcontab"]);
        _codcontacofins = AlterarTipo<decimal?>(leitor["Codcontacofins"]);
        _codcontacsrf = AlterarTipo<decimal?>(leitor["Codcontacsrf"]);
        _codcontainss = AlterarTipo<decimal?>(leitor["Codcontainss"]);
        _codcontairrf = AlterarTipo<decimal?>(leitor["Codcontairrf"]);
        _codcontaiss = AlterarTipo<decimal?>(leitor["Codcontaiss"]);
        _codcontapis = AlterarTipo<decimal?>(leitor["Codcontapis"]);
        _codcontasrf = AlterarTipo<decimal?>(leitor["Codcontasrf"]);
        _coddistrib = AlterarTipo<string>(leitor["Coddistrib"]);
        _codequipe = AlterarTipo<decimal?>(leitor["Codequipe"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codigocentrocusto = AlterarTipo<string>(leitor["Codigocentrocusto"]);
        _codmonitor = AlterarTipo<decimal?>(leitor["Codmonitor"]);
        _codoperacao = AlterarTipo<string>(leitor["Codoperacao"]);
        _codpracaprincipal = AlterarTipo<decimal?>(leitor["Codpracaprincipal"]);
        _codsupervisor = AlterarTipo<decimal>(leitor["Codsupervisor"]);
        _codusur = AlterarTipo<decimal>(leitor["Codusur"]);
        _comissaofixa = AlterarTipo<decimal?>(leitor["Comissaofixa"]);
        _conjuge = AlterarTipo<string>(leitor["Conjuge"]);
        _cpf = AlterarTipo<string>(leitor["Cpf"]);
        _cpfaux = AlterarTipo<string>(leitor["Cpfaux"]);
        _direnvioftp = AlterarTipo<string>(leitor["Direnvioftp"]);
        _diretorioassinatura = AlterarTipo<string>(leitor["Diretorioassinatura"]);
        _dirrecepcaoftp = AlterarTipo<string>(leitor["Dirrecepcaoftp"]);
        _dtentregadoc = AlterarTipo<DateTime?>(leitor["Dtentregadoc"]);
        _dtexclusao = AlterarTipo<DateTime?>(leitor["Dtexclusao"]);
        _dtinformatiza = AlterarTipo<DateTime?>(leitor["Dtinformatiza"]);
        _dtinicio = AlterarTipo<DateTime?>(leitor["Dtinicio"]);
        _dtlimentregadoc = AlterarTipo<DateTime?>(leitor["Dtlimentregadoc"]);
        _dtnasc = AlterarTipo<DateTime?>(leitor["Dtnasc"]);
        _dtnasconjuge = AlterarTipo<DateTime?>(leitor["Dtnasconjuge"]);
        _dttermino = AlterarTipo<DateTime?>(leitor["Dttermino"]);
        _dtultalteracao = AlterarTipo<DateTime?>(leitor["Dtultalteracao"]);
        _dtultpagconselho = AlterarTipo<DateTime?>(leitor["Dtultpagconselho"]);
        _dtultvenda = AlterarTipo<DateTime?>(leitor["Dtultvenda"]);
        _email = AlterarTipo<string>(leitor["Email"]);
        _email2 = AlterarTipo<string>(leitor["Email2"]);
        _endereco = AlterarTipo<string>(leitor["Endereco"]);
        _endereco2 = AlterarTipo<string>(leitor["Endereco2"]);
        _estado = AlterarTipo<string>(leitor["Estado"]);
        _exportadados = AlterarTipo<string>(leitor["Exportadados"]);
        _exportarecf = AlterarTipo<string>(leitor["Exportarecf"]);
        _exportarparaforcavendas = AlterarTipo<string>(leitor["Exportarparaforcavendas"]);
        _fax = AlterarTipo<string>(leitor["Fax"]);
        _firma = AlterarTipo<string>(leitor["Firma"]);
        _horafimconexaopalm = AlterarTipo<decimal?>(leitor["Horafimconexaopalm"]);
        _horainiconexaopalm = AlterarTipo<decimal?>(leitor["Horainiconexaopalm"]);
        _indicecpfechcomissao = AlterarTipo<string>(leitor["Indicecpfechcomissao"]);
        _indicerateiocomissao = AlterarTipo<decimal?>(leitor["Indicerateiocomissao"]);
        _inscmunicipal = AlterarTipo<string>(leitor["Inscmunicipal"]);
        _inss = AlterarTipo<decimal?>(leitor["Inss"]);
        _maskpreposto = AlterarTipo<string>(leitor["Maskpreposto"]);
        _mens1 = AlterarTipo<string>(leitor["Mens1"]);
        _mens2 = AlterarTipo<string>(leitor["Mens2"]);
        _mens3 = AlterarTipo<string>(leitor["Mens3"]);
        _mens4 = AlterarTipo<string>(leitor["Mens4"]);
        _minutofimconexaopalm = AlterarTipo<decimal?>(leitor["Minutofimconexaopalm"]);
        _minutoiniconexaopalm = AlterarTipo<decimal?>(leitor["Minutoiniconexaopalm"]);
        _modelopalm = AlterarTipo<string>(leitor["Modelopalm"]);
        _motivo = AlterarTipo<string>(leitor["Motivo"]);
        _nome = AlterarTipo<string>(leitor["Nome"]);
        _numagencia = AlterarTipo<decimal?>(leitor["Numagencia"]);
        _numagenciapoup = AlterarTipo<decimal?>(leitor["Numagenciapoup"]);
        _numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
        _numbancopoup = AlterarTipo<decimal?>(leitor["Numbancopoup"]);
        _numccorrente = AlterarTipo<decimal?>(leitor["Numccorrente"]);
        _numccorrentealfa = AlterarTipo<string>(leitor["Numccorrentealfa"]);
        _numccorrentepoup = AlterarTipo<decimal?>(leitor["Numccorrentepoup"]);
        _numclipos = AlterarTipo<decimal?>(leitor["Numclipos"]);
        _numconselho = AlterarTipo<string>(leitor["Numconselho"]);
        _numdep = AlterarTipo<decimal?>(leitor["Numdep"]);
        _numdvagencia = AlterarTipo<string>(leitor["Numdvagencia"]);
        _numdvagenciapoup = AlterarTipo<string>(leitor["Numdvagenciapoup"]);
        _numdvccorrente = AlterarTipo<string>(leitor["Numdvccorrente"]);
        _numdvccorrentepoup = AlterarTipo<string>(leitor["Numdvccorrentepoup"]);
        _numnotabloco1 = AlterarTipo<string>(leitor["Numnotabloco1"]);
        _numpedecf = AlterarTipo<decimal?>(leitor["Numpedecf"]);
        _numserieequip = AlterarTipo<decimal?>(leitor["Numserieequip"]);
        _numserieequip2 = AlterarTipo<string>(leitor["Numserieequip2"]);
        _obsbloq = AlterarTipo<string>(leitor["Obsbloq"]);
        _obsforcavendas1 = AlterarTipo<string>(leitor["Obsforcavendas1"]);
        _obsforcavendas2 = AlterarTipo<string>(leitor["Obsforcavendas2"]);
        _obsforcavendas3 = AlterarTipo<string>(leitor["Obsforcavendas3"]);
        _obsforcavendas4 = AlterarTipo<string>(leitor["Obsforcavendas4"]);
        _obs1 = AlterarTipo<string>(leitor["Obs1"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _percacrescimovenda = AlterarTipo<decimal?>(leitor["Percacrescimovenda"]);
        _percacresfv = AlterarTipo<decimal?>(leitor["Percacresfv"]);
        _perccofinsnfservico = AlterarTipo<decimal?>(leitor["Perccofinsnfservico"]);
        _perccsrf = AlterarTipo<decimal?>(leitor["Perccsrf"]);
        _percent = AlterarTipo<decimal?>(leitor["Percent"]);
        _percent2 = AlterarTipo<decimal?>(leitor["Percent2"]);
        _percinss = AlterarTipo<decimal?>(leitor["Percinss"]);
        _percirrf = AlterarTipo<decimal?>(leitor["Percirrf"]);
        _perciss = AlterarTipo<decimal?>(leitor["Perciss"]);
        _percmetadepto = AlterarTipo<decimal?>(leitor["Percmetadepto"]);
        _percommeta = AlterarTipo<decimal?>(leitor["Percommeta"]);
        _percpisnfservico = AlterarTipo<decimal?>(leitor["Percpisnfservico"]);
        _perdescmax = AlterarTipo<decimal?>(leitor["Perdescmax"]);
        _permaxvenda = AlterarTipo<decimal?>(leitor["Permaxvenda"]);
        _permeta = AlterarTipo<decimal?>(leitor["Permeta"]);
        _permetametro = AlterarTipo<decimal?>(leitor["Permetametro"]);
        _permiteadiantcomissao = AlterarTipo<string>(leitor["Permiteadiantcomissao"]);
        _praca1 = AlterarTipo<string>(leitor["Praca1"]);
        _praca2 = AlterarTipo<string>(leitor["Praca2"]);
        _proxcodclipalm = AlterarTipo<decimal?>(leitor["Proxcodclipalm"]);
        _proxnumped = AlterarTipo<decimal?>(leitor["Proxnumped"]);
        _proxnumpedforca = AlterarTipo<decimal?>(leitor["Proxnumpedforca"]);
        _proxnumpedweb = AlterarTipo<decimal?>(leitor["Proxnumpedweb"]);
        _qtitenspedprev = AlterarTipo<decimal?>(leitor["Qtitenspedprev"]);
        _qtpedprev = AlterarTipo<decimal?>(leitor["Qtpedprev"]);
        _rotamasterfoods = AlterarTipo<string>(leitor["Rotamasterfoods"]);
        _senha = AlterarTipo<string>(leitor["Senha"]);
        _senhadialup = AlterarTipo<string>(leitor["Senhadialup"]);
        _senhaftp = AlterarTipo<string>(leitor["Senhaftp"]);
        _senhalogin = AlterarTipo<string>(leitor["Senhalogin"]);
        _senhapop = AlterarTipo<string>(leitor["Senhapop"]);
        _servftp = AlterarTipo<string>(leitor["Servftp"]);
        _servpop = AlterarTipo<string>(leitor["Servpop"]);
        _servsmtp = AlterarTipo<string>(leitor["Servsmtp"]);
        _simplesnacional = AlterarTipo<string>(leitor["Simplesnacional"]);
        _telefone1 = AlterarTipo<string>(leitor["Telefone1"]);
        _telefone2 = AlterarTipo<string>(leitor["Telefone2"]);
        _telprovedor = AlterarTipo<string>(leitor["Telprovedor"]);
        _tipocomissao = AlterarTipo<string>(leitor["Tipocomissao"]);
        _tipofirma = AlterarTipo<string>(leitor["Tipofirma"]);
        _tipopessoa = AlterarTipo<string>(leitor["Tipopessoa"]);
        _tipovend = AlterarTipo<string>(leitor["Tipovend"]);
        _ultnumped = AlterarTipo<decimal?>(leitor["Ultnumped"]);
        _usacobrancacartao = AlterarTipo<string>(leitor["Usacobrancacartao"]);
        _usadebcredrca = AlterarTipo<string>(leitor["Usadebcredrca"]);
        _usarrcaoperador = AlterarTipo<string>(leitor["Usarrcaoperador"]);
        _usurdialup = AlterarTipo<string>(leitor["Usurdialup"]);
        _usurdirfv = AlterarTipo<string>(leitor["Usurdirfv"]);
        _usurftp = AlterarTipo<string>(leitor["Usurftp"]);
        _usurlogin = AlterarTipo<string>(leitor["Usurlogin"]);
        _usurpop = AlterarTipo<string>(leitor["Usurpop"]);
        _validaracrescdescprecofixo = AlterarTipo<string>(leitor["Validaracrescdescprecofixo"]);
        _vendedorqk = AlterarTipo<string>(leitor["Vendedorqk"]);
        _visualizarproddeptosec = AlterarTipo<string>(leitor["Visualizarproddeptosec"]);
        _vlcorrente = AlterarTipo<decimal?>(leitor["Vlcorrente"]);
        _vllimcred = AlterarTipo<decimal?>(leitor["Vllimcred"]);
        _vlmaxtroca = AlterarTipo<decimal?>(leitor["Vlmaxtroca"]);
        _vlvendaminped = AlterarTipo<decimal?>(leitor["Vlvendaminped"]);
        _vlvendaprev = AlterarTipo<decimal?>(leitor["Vlvendaprev"]);
    }

}