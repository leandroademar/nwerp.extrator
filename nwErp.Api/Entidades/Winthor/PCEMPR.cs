// Decompiled with JetBrains decompiler
// Type: AutoServico.Entidades.Winthor.PCEMPR
// Assembly: AutoServico.Entidades.Winthor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1599EAB1-CA3A-4344-9C5A-C18A66CE5F0C
// Assembly location: D:\dev\servfaturamento_v33\Executaveis\dotPeek\AutoServico.Entidades.Winthor.dll

    [Serializable]
    public class PCEMPR : GerenteDePropriedades, IEntidade
    {
        private static readonly string RO_ADMISSAO = nameof(Admissao);
        private DateTime _admissao;
        private static readonly string RO_AREAATUACAO = nameof(Areaatuacao);
        private string _areaatuacao;
        private static readonly string RO_BAIRRO = nameof(Bairro);
        private string _bairro;
        private static readonly string RO_CATEGORIACNH = nameof(Categoriacnh);
        private string _categoriacnh;
        private static readonly string RO_CELULAR = nameof(Celular);
        private string _celular;
        private static readonly string RO_CEP = nameof(Cep);
        private Decimal? _cep;
        private static readonly string RO_CIDADE = nameof(Cidade);
        private string _cidade;
        private static readonly string RO_CNH = nameof(Cnh);
        private string _cnh;
        private static readonly string RO_CODBARRA = nameof(Codbarra);
        private string _codbarra;
        private static readonly string RO_CODCONFERENTE = nameof(Codconferente);
        private Decimal? _codconferente;
        private static readonly string RO_CODFILIAL = nameof(Codfilial);
        private string _codfilial;
        private static readonly string RO_CODFORNEC = nameof(Codfornec);
        private Decimal? _codfornec;
        private static readonly string RO_CODFUNCAO = nameof(Codfuncao);
        private Decimal? _codfuncao;
        private static readonly string RO_CODIDIOMA = nameof(Codidioma);
        private string _codidioma;
        private static readonly string RO_CODIGOCENTROCUSTO = nameof(Codigocentrocusto);
        private string _codigocentrocusto;
        private static readonly string RO_CODIGOPERFIL = nameof(Codigoperfil);
        private Decimal? _codigoperfil;
        private static readonly string RO_CODPERFIL = nameof(Codperfil);
        private Decimal? _codperfil;
        private static readonly string RO_CODSETOR = nameof(Codsetor);
        private Decimal _codsetor;
        private static readonly string RO_CODUSUR = nameof(Codusur);
        private Decimal? _codusur;
        private static readonly string RO_CODVEICULO = nameof(Codveiculo);
        private Decimal? _codveiculo;
        private static readonly string RO_COMISSAOFIXA = nameof(Comissaofixa);
        private Decimal? _comissaofixa;
        private static readonly string RO_COMPLEMENTO = nameof(Complemento);
        private string _complemento;
        private static readonly string RO_CONCEDERABATIMENTO = nameof(Concederabatimento);
        private string _concederabatimento;
        private static readonly string RO_CPF = nameof(Cpf);
        private string _cpf;
        private static readonly string RO_CTPS = nameof(Ctps);
        private string _ctps;
        private static readonly string RO_DDDTEL = nameof(Dddtel);
        private Decimal? _dddtel;
        private static readonly string RO_DIASCOB = nameof(Diascob);
        private Decimal? _diascob;
        private static readonly string RO_DT_EXCLUSAO = nameof(Dt_Exclusao);
        private DateTime? _dt_exclusao;
        private static readonly string RO_DTEXPIRASENHA = nameof(Dtexpirasenha);
        private DateTime? _dtexpirasenha;
        private static readonly string RO_DTFIMLIMCREDCOMPRA = nameof(Dtfimlimcredcompra);
        private DateTime? _dtfimlimcredcompra;
        private static readonly string RO_DTINICIO = nameof(Dtinicio);
        private DateTime? _dtinicio;
        private static readonly string RO_DTINICIOLIMCREDCOMPRA = nameof(Dtiniciolimcredcompra);
        private DateTime? _dtiniciolimcredcompra;
        private static readonly string RO_DTNASC = nameof(Dtnasc);
        private DateTime? _dtnasc;
        private static readonly string RO_DTVALIDADECNH = nameof(Dtvalidadecnh);
        private DateTime? _dtvalidadecnh;
        private static readonly string RO_EMAIL = nameof(Email);
        private string _email;
        private static readonly string RO_ENDERECO = nameof(Endereco);
        private string _endereco;
        private static readonly string RO_ENVIAFV = nameof(Enviafv);
        private string _enviafv;
        private static readonly string RO_ESTADO = nameof(Estado);
        private string _estado;
        private static readonly string RO_ESTADOCIVIL = nameof(Estadocivil);
        private string _estadocivil;
        private static readonly string RO_FATORCOMISSAO = nameof(Fatorcomissao);
        private Decimal? _fatorcomissao;
        private static readonly string RO_FONE = nameof(Fone);
        private string _fone;
        private static readonly string RO_FUNCAO = nameof(Funcao);
        private string _funcao;
        private static readonly string RO_GERACCCARD = nameof(Geracccard);
        private string _geracccard;
        private static readonly string RO_GRUPOEMAIL = nameof(Grupoemail);
        private string _grupoemail;
        private static readonly string RO_GRUPOOS = nameof(Grupoos);
        private Decimal? _grupoos;
        private static readonly string RO_IPRF = nameof(Iprf);
        private string _iprf;
        private static readonly string RO_LIMITEDESCONTO561 = nameof(Limitedesconto561);
        private Decimal? _limitedesconto561;
        private static readonly string RO_MATRICULA = nameof(Matricula);
        private Decimal _matricula;
        private static readonly string RO_MATRICULACCCARD = nameof(Matriculacccard);
        private Decimal? _matriculacccard;
        private static readonly string RO_MAXTEMPOSECAOOCIOSA = nameof(Maxtemposecaoociosa);
        private Decimal? _maxtemposecaoociosa;
        private static readonly string RO_NACIONALIDADE = nameof(Nacionalidade);
        private string _nacionalidade;
        private static readonly string RO_NOME = nameof(Nome);
        private string _nome;
        private static readonly string RO_NOMEEMAIL = nameof(Nomeemail);
        private string _nomeemail;
        private static readonly string RO_NOME_GUERRA = nameof(Nome_Guerra);
        private string _nome_guerra;
        private static readonly string RO_NOMEMAE = nameof(Nomemae);
        private string _nomemae;
        private static readonly string RO_NOMEPAI = nameof(Nomepai);
        private string _nomepai;
        private static readonly string RO_NUMAGENCIA = nameof(Numagencia);
        private Decimal? _numagencia;
        private static readonly string RO_NUMBANCO = nameof(Numbanco);
        private Decimal? _numbanco;
        private static readonly string RO_NUMCAIXABALCAO = nameof(Numcaixabalcao);
        private Decimal? _numcaixabalcao;
        private static readonly string RO_NUMCCORRENTE = nameof(Numccorrente);
        private string _numccorrente;
        private static readonly string RO_NUMCENTRALPA = nameof(Numcentralpa);
        private Decimal? _numcentralpa;
        private static readonly string RO_NUMCENTRALTEL = nameof(Numcentraltel);
        private string _numcentraltel;
        private static readonly string RO_NUMCONEXOES = nameof(Numconexoes);
        private Decimal? _numconexoes;
        private static readonly string RO_NUMCONEXOESATUAL = nameof(Numconexoesatual);
        private Decimal? _numconexoesatual;
        private static readonly string RO_NUMDIASMAXPRORROG = nameof(Numdiasmaxprorrog);
        private Decimal? _numdiasmaxprorrog;
        private static readonly string RO_NUMDIASPAGTORETROATIVO = nameof(Numdiaspagtoretroativo);
        private Decimal? _numdiaspagtoretroativo;
        private static readonly string RO_NUMDVAGENCIA = nameof(Numdvagencia);
        private string _numdvagencia;
        private static readonly string RO_NUMDVCONTA = nameof(Numdvconta);
        private string _numdvconta;
        private static readonly string RO_NUMFILHOS = nameof(Numfilhos);
        private Decimal? _numfilhos;
        private static readonly string RO_NUMIDENTIFICADORECF = nameof(Numidentificadorecf);
        private string _numidentificadorecf;
        private static readonly string RO_NUMINSS = nameof(Numinss);
        private string _numinss;
        private static readonly string RO_OBS = nameof(Obs);
        private string _obs;
        private static readonly string RO_OBSERVACAO = nameof(Observacao);
        private string _observacao;
        private static readonly string RO_OBSINATIVO = nameof(Obsinativo);
        private string _obsinativo;
        private static readonly string RO_ORGAOEMISSORRG = nameof(Orgaoemissorrg);
        private string _orgaoemissorrg;
        private static readonly string RO_PERCDESC = nameof(Percdesc);
        private Decimal? _percdesc;
        private static readonly string RO_PERCEXCLIMCRED = nameof(Percexclimcred);
        private Decimal? _percexclimcred;
        private static readonly string RO_PERCINSS = nameof(Percinss);
        private Decimal? _percinss;
        private static readonly string RO_PERCMAXDESCTITULO = nameof(Percmaxdesctitulo);
        private Decimal? _percmaxdesctitulo;
        private static readonly string RO_PERCMAXJUROSMORA = nameof(Percmaxjurosmora);
        private Decimal? _percmaxjurosmora;
        private static readonly string RO_PERCMINJUROSMORA = nameof(Percminjurosmora);
        private Decimal? _percminjurosmora;
        private static readonly string RO_PERCOMMOT = nameof(Percommot);
        private Decimal? _percommot;
        private static readonly string RO_PERCREDUZCOMISRCA = nameof(Percreduzcomisrca);
        private Decimal? _percreduzcomisrca;
        private static readonly string RO_PERCVT = nameof(Percvt);
        private Decimal? _percvt;
        private static readonly string RO_PERMITEALTDESCBX = nameof(Permitealtdescbx);
        private string _permitealtdescbx;
        private static readonly string RO_PERMITEALTJUROSBX = nameof(Permitealtjurosbx);
        private string _permitealtjurosbx;
        private static readonly string RO_PERMITEPERSONCAD = nameof(Permitepersoncad);
        private string _permitepersoncad;
        private static readonly string RO_PIS = nameof(Pis);
        private string _pis;
        private static readonly string RO_PROFISSAO = nameof(Profissao);
        private string _profissao;
        private static readonly string RO_REFERENCIAPESSOAL = nameof(Referenciapessoal);
        private string _referenciapessoal;
        private static readonly string RO_RESCISAO = nameof(Rescisao);
        private DateTime? _rescisao;
        private static readonly string RO_RESPLIBCADASTRO = nameof(Resplibcadastro);
        private string _resplibcadastro;
        private static readonly string RO_RG = nameof(Rg);
        private string _rg;
        private static readonly string RO_SENHABD = nameof(Senhabd);
        private string _senhabd;
        private static readonly string RO_SERIECTPS = nameof(Seriectps);
        private string _seriectps;
        private static readonly string RO_SEXO = nameof(Sexo);
        private string _sexo;
        private static readonly string RO_SITUACAO = nameof(Situacao);
        private string _situacao;
        private static readonly string RO_TIPO = nameof(Tipo);
        private string _tipo;
        private static readonly string RO_TIPOAGENTECOB = nameof(Tipoagentecob);
        private string _tipoagentecob;
        private static readonly string RO_TIPOATENDE = nameof(Tipoatende);
        private string _tipoatende;
        private static readonly string RO_TIPOCOMISSAO = nameof(Tipocomissao);
        private string _tipocomissao;
        private static readonly string RO_TIPOENVIO = nameof(Tipoenvio);
        private string _tipoenvio;
        private static readonly string RO_TIPOMOTORISTA = nameof(Tipomotorista);
        private string _tipomotorista;
        private static readonly string RO_TIPOVENDA = nameof(Tipovenda);
        private string _tipovenda;
        private static readonly string RO_UFCNH = nameof(Ufcnh);
        private string _ufcnh;
        private static readonly string RO_USAAVISOAUTOMENU = nameof(Usaavisoautomenu);
        private string _usaavisoautomenu;
        private static readonly string RO_USABIOMETRIAMENU = nameof(Usabiometriamenu);
        private string _usabiometriamenu;
        private static readonly string RO_USARATEIOCOMISSAOOPERADOR = nameof(Usarateiocomissaooperador);
        private string _usarateiocomissaooperador;
        private static readonly string RO_USATABELACLIENTE = nameof(Usatabelacliente);
        private string _usatabelacliente;
        private static readonly string RO_USUARIOBD = nameof(Usuariobd);
        private string _usuariobd;
        private static readonly string RO_USUARIOLOGADO = nameof(Usuariologado);
        private string _usuariologado;
        private static readonly string RO_USUARIOLOGADORF = nameof(Usuariologadorf);
        private string _usuariologadorf;
        private static readonly string RO_VENDAASSISTIDA = nameof(Vendaassistida);
        private string _vendaassistida;
        private static readonly string RO_VLADICIONAL = nameof(Vladicional);
        private Decimal? _vladicional;
        private static readonly string RO_VLAUMENTOLIMCRED = nameof(Vlaumentolimcred);
        private Decimal? _vlaumentolimcred;
        private static readonly string RO_VLCOMISSENT = nameof(Vlcomissent);
        private Decimal? _vlcomissent;
        private static readonly string RO_VLCOMISSTON = nameof(Vlcomisston);
        private Decimal? _vlcomisston;
        private static readonly string RO_VLFRETEENTREGA = nameof(Vlfreteentrega);
        private Decimal? _vlfreteentrega;
        private static readonly string RO_VLLIMCREDCOMPRA = nameof(Vllimcredcompra);
        private Decimal? _vllimcredcompra;
        private static readonly string RO_VLMAXLIBPEDIDO = nameof(Vlmaxlibpedido);
        private Decimal? _vlmaxlibpedido;
        private static readonly string RO_VLMAXLIMCREDCLI = nameof(Vlmaxlimcredcli);
        private Decimal? _vlmaxlimcredcli;
        private static readonly string RO_VLPENSAOALIMENTICIA = nameof(Vlpensaoalimenticia);
        private Decimal? _vlpensaoalimenticia;
        private static readonly string RO_VLPLANOSAUDE = nameof(Vlplanosaude);
        private Decimal? _vlplanosaude;
        private static readonly string RO_VLSALARIO = nameof(Vlsalario);
        private Decimal? _vlsalario;
        private static readonly string RO_VLSALCARTEIRA = nameof(Vlsalcarteira);
        private Decimal? _vlsalcarteira;
        private static readonly string RO_VLSALDOLIMALTCREDITO = nameof(Vlsaldolimaltcredito);
        private Decimal? _vlsaldolimaltcredito;
        private static readonly string RO_VLSALFAMILIA = nameof(Vlsalfamilia);
        private Decimal? _vlsalfamilia;
        private static readonly string RO_VLVALES = nameof(Vlvales);
        private Decimal? _vlvales;

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime Admissao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ADMISSAO);
                return this._admissao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ADMISSAO, (object)value);
                this._admissao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Areaatuacao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_AREAATUACAO);
                return this._areaatuacao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_AREAATUACAO, (object)value);
                this._areaatuacao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Bairro
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_BAIRRO);
                return this._bairro;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_BAIRRO, (object)value);
                this._bairro = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
        public string Categoriacnh
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CATEGORIACNH);
                return this._categoriacnh;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CATEGORIACNH, (object)value);
                this._categoriacnh = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
        public string Celular
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CELULAR);
                return this._celular;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CELULAR, (object)value);
                this._celular = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
        public Decimal? Cep
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CEP);
                return this._cep;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CEP, (object)value);
                this._cep = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Cidade
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CIDADE);
                return this._cidade;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CIDADE, (object)value);
                this._cidade = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
        public string Cnh
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CNH);
                return this._cnh;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CNH, (object)value);
                this._cnh = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Codbarra
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODBARRA);
                return this._codbarra;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODBARRA, (object)value);
                this._codbarra = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
        public Decimal? Codconferente
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODCONFERENTE);
                return this._codconferente;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODCONFERENTE, (object)value);
                this._codconferente = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
        public string Codfilial
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODFILIAL);
                return this._codfilial;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODFILIAL, (object)value);
                this._codfilial = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
        public Decimal? Codfornec
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODFORNEC);
                return this._codfornec;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODFORNEC, (object)value);
                this._codfornec = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Codfuncao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODFUNCAO);
                return this._codfuncao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODFUNCAO, (object)value);
                this._codfuncao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
        public string Codidioma
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODIDIOMA);
                return this._codidioma;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODIDIOMA, (object)value);
                this._codidioma = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Codigocentrocusto
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODIGOCENTROCUSTO);
                return this._codigocentrocusto;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODIGOCENTROCUSTO, (object)value);
                this._codigocentrocusto = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 20, Precisao = 0)]
        public Decimal? Codigoperfil
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODIGOPERFIL);
                return this._codigoperfil;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODIGOPERFIL, (object)value);
                this._codigoperfil = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
        public Decimal? Codperfil
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODPERFIL);
                return this._codperfil;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODPERFIL, (object)value);
                this._codperfil = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
        public Decimal Codsetor
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODSETOR);
                return this._codsetor;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODSETOR, (object)value);
                this._codsetor = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Codusur
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODUSUR);
                return this._codusur;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODUSUR, (object)value);
                this._codusur = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Codveiculo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CODVEICULO);
                return this._codveiculo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CODVEICULO, (object)value);
                this._codveiculo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Comissaofixa
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_COMISSAOFIXA);
                return this._comissaofixa;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_COMISSAOFIXA, (object)value);
                this._comissaofixa = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Complemento
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_COMPLEMENTO);
                return this._complemento;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_COMPLEMENTO, (object)value);
                this._complemento = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Concederabatimento
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CONCEDERABATIMENTO);
                return this._concederabatimento;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CONCEDERABATIMENTO, (object)value);
                this._concederabatimento = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Cpf
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CPF);
                return this._cpf;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CPF, (object)value);
                this._cpf = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Ctps
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_CTPS);
                return this._ctps;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_CTPS, (object)value);
                this._ctps = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
        public Decimal? Dddtel
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DDDTEL);
                return this._dddtel;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DDDTEL, (object)value);
                this._dddtel = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
        public Decimal? Diascob
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DIASCOB);
                return this._diascob;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DIASCOB, (object)value);
                this._diascob = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dt_Exclusao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DT_EXCLUSAO);
                return this._dt_exclusao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DT_EXCLUSAO, (object)value);
                this._dt_exclusao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtexpirasenha
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTEXPIRASENHA);
                return this._dtexpirasenha;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTEXPIRASENHA, (object)value);
                this._dtexpirasenha = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtfimlimcredcompra
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTFIMLIMCREDCOMPRA);
                return this._dtfimlimcredcompra;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTFIMLIMCREDCOMPRA, (object)value);
                this._dtfimlimcredcompra = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtinicio
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTINICIO);
                return this._dtinicio;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTINICIO, (object)value);
                this._dtinicio = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtiniciolimcredcompra
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTINICIOLIMCREDCOMPRA);
                return this._dtiniciolimcredcompra;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTINICIOLIMCREDCOMPRA, (object)value);
                this._dtiniciolimcredcompra = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtnasc
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTNASC);
                return this._dtnasc;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTNASC, (object)value);
                this._dtnasc = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Dtvalidadecnh
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_DTVALIDADECNH);
                return this._dtvalidadecnh;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_DTVALIDADECNH, (object)value);
                this._dtvalidadecnh = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
        public string Email
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_EMAIL);
                return this._email;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_EMAIL, (object)value);
                this._email = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Endereco
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ENDERECO);
                return this._endereco;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ENDERECO, (object)value);
                this._endereco = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Enviafv
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ENVIAFV);
                return this._enviafv;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ENVIAFV, (object)value);
                this._enviafv = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
        public string Estado
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ESTADO);
                return this._estado;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ESTADO, (object)value);
                this._estado = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
        public string Estadocivil
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ESTADOCIVIL);
                return this._estadocivil;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ESTADOCIVIL, (object)value);
                this._estadocivil = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
        public Decimal? Fatorcomissao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_FATORCOMISSAO);
                return this._fatorcomissao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_FATORCOMISSAO, (object)value);
                this._fatorcomissao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
        public string Fone
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_FONE);
                return this._fone;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_FONE, (object)value);
                this._fone = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
        public string Funcao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_FUNCAO);
                return this._funcao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_FUNCAO, (object)value);
                this._funcao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Geracccard
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_GERACCCARD);
                return this._geracccard;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_GERACCCARD, (object)value);
                this._geracccard = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 10, Precisao = 0)]
        public string Grupoemail
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_GRUPOEMAIL);
                return this._grupoemail;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_GRUPOEMAIL, (object)value);
                this._grupoemail = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 15, Precisao = 0)]
        public Decimal? Grupoos
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_GRUPOOS);
                return this._grupoos;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_GRUPOOS, (object)value);
                this._grupoos = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 14, Precisao = 0)]
        public string Iprf
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_IPRF);
                return this._iprf;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_IPRF, (object)value);
                this._iprf = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
        public Decimal? Limitedesconto561
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_LIMITEDESCONTO561);
                return this._limitedesconto561;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_LIMITEDESCONTO561, (object)value);
                this._limitedesconto561 = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
        public Decimal Matricula
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_MATRICULA);
                return this._matricula;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_MATRICULA, (object)value);
                this._matricula = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
        public Decimal? Matriculacccard
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_MATRICULACCCARD);
                return this._matriculacccard;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_MATRICULACCCARD, (object)value);
                this._matriculacccard = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
        public Decimal? Maxtemposecaoociosa
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_MAXTEMPOSECAOOCIOSA);
                return this._maxtemposecaoociosa;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_MAXTEMPOSECAOOCIOSA, (object)value);
                this._maxtemposecaoociosa = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Nacionalidade
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NACIONALIDADE);
                return this._nacionalidade;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NACIONALIDADE, (object)value);
                this._nacionalidade = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Nome
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NOME);
                return this._nome;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NOME, (object)value);
                this._nome = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
        public string Nomeemail
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NOMEEMAIL);
                return this._nomeemail;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NOMEEMAIL, (object)value);
                this._nomeemail = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
        public string Nome_Guerra
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NOME_GUERRA);
                return this._nome_guerra;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NOME_GUERRA, (object)value);
                this._nome_guerra = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
        public string Nomemae
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NOMEMAE);
                return this._nomemae;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NOMEMAE, (object)value);
                this._nomemae = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
        public string Nomepai
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NOMEPAI);
                return this._nomepai;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NOMEPAI, (object)value);
                this._nomepai = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Numagencia
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMAGENCIA);
                return this._numagencia;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMAGENCIA, (object)value);
                this._numagencia = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
        public Decimal? Numbanco
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMBANCO);
                return this._numbanco;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMBANCO, (object)value);
                this._numbanco = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
        public Decimal? Numcaixabalcao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCAIXABALCAO);
                return this._numcaixabalcao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCAIXABALCAO, (object)value);
                this._numcaixabalcao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
        public string Numccorrente
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCCORRENTE);
                return this._numccorrente;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCCORRENTE, (object)value);
                this._numccorrente = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Numcentralpa
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCENTRALPA);
                return this._numcentralpa;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCENTRALPA, (object)value);
                this._numcentralpa = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Numcentraltel
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCENTRALTEL);
                return this._numcentraltel;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCENTRALTEL, (object)value);
                this._numcentraltel = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Numconexoes
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCONEXOES);
                return this._numconexoes;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCONEXOES, (object)value);
                this._numconexoes = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Numconexoesatual
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMCONEXOESATUAL);
                return this._numconexoesatual;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMCONEXOESATUAL, (object)value);
                this._numconexoesatual = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
        public Decimal? Numdiasmaxprorrog
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMDIASMAXPRORROG);
                return this._numdiasmaxprorrog;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMDIASMAXPRORROG, (object)value);
                this._numdiasmaxprorrog = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
        public Decimal? Numdiaspagtoretroativo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMDIASPAGTORETROATIVO);
                return this._numdiaspagtoretroativo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMDIASPAGTORETROATIVO, (object)value);
                this._numdiaspagtoretroativo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
        public string Numdvagencia
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMDVAGENCIA);
                return this._numdvagencia;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMDVAGENCIA, (object)value);
                this._numdvagencia = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
        public string Numdvconta
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMDVCONTA);
                return this._numdvconta;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMDVCONTA, (object)value);
                this._numdvconta = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
        public Decimal? Numfilhos
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMFILHOS);
                return this._numfilhos;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMFILHOS, (object)value);
                this._numfilhos = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 13, Precisao = 0)]
        public string Numidentificadorecf
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMIDENTIFICADORECF);
                return this._numidentificadorecf;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMIDENTIFICADORECF, (object)value);
                this._numidentificadorecf = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 12, Precisao = 0)]
        public string Numinss
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_NUMINSS);
                return this._numinss;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_NUMINSS, (object)value);
                this._numinss = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 60, Precisao = 0)]
        public string Obs
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_OBS);
                return this._obs;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_OBS, (object)value);
                this._obs = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
        public string Observacao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_OBSERVACAO);
                return this._observacao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_OBSERVACAO, (object)value);
                this._observacao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
        public string Obsinativo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_OBSINATIVO);
                return this._obsinativo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_OBSINATIVO, (object)value);
                this._obsinativo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Orgaoemissorrg
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_ORGAOEMISSORRG);
                return this._orgaoemissorrg;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_ORGAOEMISSORRG, (object)value);
                this._orgaoemissorrg = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
        public Decimal? Percdesc
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCDESC);
                return this._percdesc;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCDESC, (object)value);
                this._percdesc = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
        public Decimal? Percexclimcred
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCEXCLIMCRED);
                return this._percexclimcred;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCEXCLIMCRED, (object)value);
                this._percexclimcred = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
        public Decimal? Percinss
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCINSS);
                return this._percinss;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCINSS, (object)value);
                this._percinss = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
        public Decimal? Percmaxdesctitulo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCMAXDESCTITULO);
                return this._percmaxdesctitulo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCMAXDESCTITULO, (object)value);
                this._percmaxdesctitulo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
        public Decimal? Percmaxjurosmora
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCMAXJUROSMORA);
                return this._percmaxjurosmora;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCMAXJUROSMORA, (object)value);
                this._percmaxjurosmora = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
        public Decimal? Percminjurosmora
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCMINJUROSMORA);
                return this._percminjurosmora;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCMINJUROSMORA, (object)value);
                this._percminjurosmora = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
        public Decimal? Percommot
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCOMMOT);
                return this._percommot;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCOMMOT, (object)value);
                this._percommot = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
        public Decimal? Percreduzcomisrca
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCREDUZCOMISRCA);
                return this._percreduzcomisrca;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCREDUZCOMISRCA, (object)value);
                this._percreduzcomisrca = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
        public Decimal? Percvt
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERCVT);
                return this._percvt;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERCVT, (object)value);
                this._percvt = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Permitealtdescbx
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERMITEALTDESCBX);
                return this._permitealtdescbx;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERMITEALTDESCBX, (object)value);
                this._permitealtdescbx = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Permitealtjurosbx
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERMITEALTJUROSBX);
                return this._permitealtjurosbx;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERMITEALTJUROSBX, (object)value);
                this._permitealtjurosbx = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Permitepersoncad
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PERMITEPERSONCAD);
                return this._permitepersoncad;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PERMITEPERSONCAD, (object)value);
                this._permitepersoncad = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Pis
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PIS);
                return this._pis;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PIS, (object)value);
                this._pis = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
        public string Profissao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_PROFISSAO);
                return this._profissao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_PROFISSAO, (object)value);
                this._profissao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
        public string Referenciapessoal
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_REFERENCIAPESSOAL);
                return this._referenciapessoal;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_REFERENCIAPESSOAL, (object)value);
                this._referenciapessoal = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
        public DateTime? Rescisao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_RESCISAO);
                return this._rescisao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_RESCISAO, (object)value);
                this._rescisao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Resplibcadastro
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_RESPLIBCADASTRO);
                return this._resplibcadastro;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_RESPLIBCADASTRO, (object)value);
                this._resplibcadastro = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 20, Precisao = 0)]
        public string Rg
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_RG);
                return this._rg;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_RG, (object)value);
                this._rg = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 32, Precisao = 0)]
        public string Senhabd
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_SENHABD);
                return this._senhabd;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_SENHABD, (object)value);
                this._senhabd = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
        public string Seriectps
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_SERIECTPS);
                return this._seriectps;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_SERIECTPS, (object)value);
                this._seriectps = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Sexo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_SEXO);
                return this._sexo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_SEXO, (object)value);
                this._sexo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Situacao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_SITUACAO);
                return this._situacao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_SITUACAO, (object)value);
                this._situacao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipo
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPO);
                return this._tipo;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPO, (object)value);
                this._tipo = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipoagentecob
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOAGENTECOB);
                return this._tipoagentecob;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOAGENTECOB, (object)value);
                this._tipoagentecob = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipoatende
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOATENDE);
                return this._tipoatende;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOATENDE, (object)value);
                this._tipoatende = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipocomissao
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOCOMISSAO);
                return this._tipocomissao;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOCOMISSAO, (object)value);
                this._tipocomissao = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipoenvio
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOENVIO);
                return this._tipoenvio;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOENVIO, (object)value);
                this._tipoenvio = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipomotorista
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOMOTORISTA);
                return this._tipomotorista;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOMOTORISTA, (object)value);
                this._tipomotorista = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Tipovenda
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_TIPOVENDA);
                return this._tipovenda;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_TIPOVENDA, (object)value);
                this._tipovenda = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
        public string Ufcnh
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_UFCNH);
                return this._ufcnh;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_UFCNH, (object)value);
                this._ufcnh = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usaavisoautomenu
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USAAVISOAUTOMENU);
                return this._usaavisoautomenu;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USAAVISOAUTOMENU, (object)value);
                this._usaavisoautomenu = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usabiometriamenu
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USABIOMETRIAMENU);
                return this._usabiometriamenu;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USABIOMETRIAMENU, (object)value);
                this._usabiometriamenu = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usarateiocomissaooperador
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USARATEIOCOMISSAOOPERADOR);
                return this._usarateiocomissaooperador;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USARATEIOCOMISSAOOPERADOR, (object)value);
                this._usarateiocomissaooperador = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usatabelacliente
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USATABELACLIENTE);
                return this._usatabelacliente;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USATABELACLIENTE, (object)value);
                this._usatabelacliente = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
        public string Usuariobd
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USUARIOBD);
                return this._usuariobd;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USUARIOBD, (object)value);
                this._usuariobd = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usuariologado
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USUARIOLOGADO);
                return this._usuariologado;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USUARIOLOGADO, (object)value);
                this._usuariologado = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Usuariologadorf
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_USUARIOLOGADORF);
                return this._usuariologadorf;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_USUARIOLOGADORF, (object)value);
                this._usuariologadorf = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
        public string Vendaassistida
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VENDAASSISTIDA);
                return this._vendaassistida;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VENDAASSISTIDA, (object)value);
                this._vendaassistida = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vladicional
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLADICIONAL);
                return this._vladicional;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLADICIONAL, (object)value);
                this._vladicional = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vlaumentolimcred
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLAUMENTOLIMCRED);
                return this._vlaumentolimcred;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLAUMENTOLIMCRED, (object)value);
                this._vlaumentolimcred = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vlcomissent
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLCOMISSENT);
                return this._vlcomissent;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLCOMISSENT, (object)value);
                this._vlcomissent = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vlcomisston
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLCOMISSTON);
                return this._vlcomisston;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLCOMISSTON, (object)value);
                this._vlcomisston = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
        public Decimal? Vlfreteentrega
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLFRETEENTREGA);
                return this._vlfreteentrega;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLFRETEENTREGA, (object)value);
                this._vlfreteentrega = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vllimcredcompra
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLLIMCREDCOMPRA);
                return this._vllimcredcompra;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLLIMCREDCOMPRA, (object)value);
                this._vllimcredcompra = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 16, Precisao = 3)]
        public Decimal? Vlmaxlibpedido
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLMAXLIBPEDIDO);
                return this._vlmaxlibpedido;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLMAXLIBPEDIDO, (object)value);
                this._vlmaxlibpedido = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vlmaxlimcredcli
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLMAXLIMCREDCLI);
                return this._vlmaxlimcredcli;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLMAXLIMCREDCLI, (object)value);
                this._vlmaxlimcredcli = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlpensaoalimenticia
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLPENSAOALIMENTICIA);
                return this._vlpensaoalimenticia;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLPENSAOALIMENTICIA, (object)value);
                this._vlpensaoalimenticia = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlplanosaude
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLPLANOSAUDE);
                return this._vlplanosaude;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLPLANOSAUDE, (object)value);
                this._vlplanosaude = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlsalario
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLSALARIO);
                return this._vlsalario;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLSALARIO, (object)value);
                this._vlsalario = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlsalcarteira
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLSALCARTEIRA);
                return this._vlsalcarteira;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLSALCARTEIRA, (object)value);
                this._vlsalcarteira = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
        public Decimal? Vlsaldolimaltcredito
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLSALDOLIMALTCREDITO);
                return this._vlsaldolimaltcredito;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLSALDOLIMALTCREDITO, (object)value);
                this._vlsaldolimaltcredito = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlsalfamilia
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLSALFAMILIA);
                return this._vlsalfamilia;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLSALFAMILIA, (object)value);
                this._vlsalfamilia = value;
            }
        }

        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCEMPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
        public Decimal? Vlvales
        {
            get
            {
                this.PropriedadeAcessada(PCEMPR.RO_VLVALES);
                return this._vlvales;
            }
            set
            {
                this.PropriedadeModificada(PCEMPR.RO_VLVALES, (object)value);
                this._vlvales = value;
            }
        }

        public void InicializarAtributos()
        {
        }

        public string ObterNomeTabela() => nameof(PCEMPR);

        public IEntidade NovaInstancia() => (IEntidade)this.GetType().GetConstructors()[0].Invoke((object[])null);

        public void CarregarPorDataReader(IDataReader leitor)
        {
            this._admissao = this.AlterarTipo<DateTime>(leitor["Admissao"]);
            this._areaatuacao = this.AlterarTipo<string>(leitor["Areaatuacao"]);
            this._bairro = this.AlterarTipo<string>(leitor["Bairro"]);
            this._categoriacnh = this.AlterarTipo<string>(leitor["Categoriacnh"]);
            this._celular = this.AlterarTipo<string>(leitor["Celular"]);
            this._cep = this.AlterarTipo<Decimal?>(leitor["Cep"]);
            this._cidade = this.AlterarTipo<string>(leitor["Cidade"]);
            this._cnh = this.AlterarTipo<string>(leitor["Cnh"]);
            this._codbarra = this.AlterarTipo<string>(leitor["Codbarra"]);
            this._codconferente = this.AlterarTipo<Decimal?>(leitor["Codconferente"]);
            this._codfilial = this.AlterarTipo<string>(leitor["Codfilial"]);
            this._codfornec = this.AlterarTipo<Decimal?>(leitor["Codfornec"]);
            this._codfuncao = this.AlterarTipo<Decimal?>(leitor["Codfuncao"]);
            this._codidioma = this.AlterarTipo<string>(leitor["Codidioma"]);
            this._codigocentrocusto = this.AlterarTipo<string>(leitor["Codigocentrocusto"]);
            this._codigoperfil = this.AlterarTipo<Decimal?>(leitor["Codigoperfil"]);
            this._codperfil = this.AlterarTipo<Decimal?>(leitor["Codperfil"]);
            this._codsetor = this.AlterarTipo<Decimal>(leitor["Codsetor"]);
            this._codusur = this.AlterarTipo<Decimal?>(leitor["Codusur"]);
            this._codveiculo = this.AlterarTipo<Decimal?>(leitor["Codveiculo"]);
            this._comissaofixa = this.AlterarTipo<Decimal?>(leitor["Comissaofixa"]);
            this._complemento = this.AlterarTipo<string>(leitor["Complemento"]);
            this._concederabatimento = this.AlterarTipo<string>(leitor["Concederabatimento"]);
            this._cpf = this.AlterarTipo<string>(leitor["Cpf"]);
            this._ctps = this.AlterarTipo<string>(leitor["Ctps"]);
            this._dddtel = this.AlterarTipo<Decimal?>(leitor["Dddtel"]);
            this._diascob = this.AlterarTipo<Decimal?>(leitor["Diascob"]);
            this._dt_exclusao = this.AlterarTipo<DateTime?>(leitor["Dt_Exclusao"]);
            this._dtexpirasenha = this.AlterarTipo<DateTime?>(leitor["Dtexpirasenha"]);
            this._dtfimlimcredcompra = this.AlterarTipo<DateTime?>(leitor["Dtfimlimcredcompra"]);
            this._dtinicio = this.AlterarTipo<DateTime?>(leitor["Dtinicio"]);
            this._dtiniciolimcredcompra = this.AlterarTipo<DateTime?>(leitor["Dtiniciolimcredcompra"]);
            this._dtnasc = this.AlterarTipo<DateTime?>(leitor["Dtnasc"]);
            this._dtvalidadecnh = this.AlterarTipo<DateTime?>(leitor["Dtvalidadecnh"]);
            this._email = this.AlterarTipo<string>(leitor["Email"]);
            this._endereco = this.AlterarTipo<string>(leitor["Endereco"]);
            this._enviafv = this.AlterarTipo<string>(leitor["Enviafv"]);
            this._estado = this.AlterarTipo<string>(leitor["Estado"]);
            this._estadocivil = this.AlterarTipo<string>(leitor["Estadocivil"]);
            this._fatorcomissao = this.AlterarTipo<Decimal?>(leitor["Fatorcomissao"]);
            this._fone = this.AlterarTipo<string>(leitor["Fone"]);
            this._funcao = this.AlterarTipo<string>(leitor["Funcao"]);
            this._geracccard = this.AlterarTipo<string>(leitor["Geracccard"]);
            this._grupoemail = this.AlterarTipo<string>(leitor["Grupoemail"]);
            this._grupoos = this.AlterarTipo<Decimal?>(leitor["Grupoos"]);
            this._iprf = this.AlterarTipo<string>(leitor["Iprf"]);
            this._limitedesconto561 = this.AlterarTipo<Decimal?>(leitor["Limitedesconto561"]);
            this._matricula = this.AlterarTipo<Decimal>(leitor["Matricula"]);
            this._matriculacccard = this.AlterarTipo<Decimal?>(leitor["Matriculacccard"]);
            this._maxtemposecaoociosa = this.AlterarTipo<Decimal?>(leitor["Maxtemposecaoociosa"]);
            this._nacionalidade = this.AlterarTipo<string>(leitor["Nacionalidade"]);
            this._nome = this.AlterarTipo<string>(leitor["Nome"]);
            this._nomeemail = this.AlterarTipo<string>(leitor["Nomeemail"]);
            this._nome_guerra = this.AlterarTipo<string>(leitor["Nome_Guerra"]);
            this._nomemae = this.AlterarTipo<string>(leitor["Nomemae"]);
            this._nomepai = this.AlterarTipo<string>(leitor["Nomepai"]);
            this._numagencia = this.AlterarTipo<Decimal?>(leitor["Numagencia"]);
            this._numbanco = this.AlterarTipo<Decimal?>(leitor["Numbanco"]);
            this._numcaixabalcao = this.AlterarTipo<Decimal?>(leitor["Numcaixabalcao"]);
            this._numccorrente = this.AlterarTipo<string>(leitor["Numccorrente"]);
            this._numcentralpa = this.AlterarTipo<Decimal?>(leitor["Numcentralpa"]);
            this._numcentraltel = this.AlterarTipo<string>(leitor["Numcentraltel"]);
            this._numconexoes = this.AlterarTipo<Decimal?>(leitor["Numconexoes"]);
            this._numconexoesatual = this.AlterarTipo<Decimal?>(leitor["Numconexoesatual"]);
            this._numdiasmaxprorrog = this.AlterarTipo<Decimal?>(leitor["Numdiasmaxprorrog"]);
            this._numdiaspagtoretroativo = this.AlterarTipo<Decimal?>(leitor["Numdiaspagtoretroativo"]);
            this._numdvagencia = this.AlterarTipo<string>(leitor["Numdvagencia"]);
            this._numdvconta = this.AlterarTipo<string>(leitor["Numdvconta"]);
            this._numfilhos = this.AlterarTipo<Decimal?>(leitor["Numfilhos"]);
            this._numidentificadorecf = this.AlterarTipo<string>(leitor["Numidentificadorecf"]);
            this._numinss = this.AlterarTipo<string>(leitor["Numinss"]);
            this._obs = this.AlterarTipo<string>(leitor["Obs"]);
            this._observacao = this.AlterarTipo<string>(leitor["Observacao"]);
            this._obsinativo = this.AlterarTipo<string>(leitor["Obsinativo"]);
            this._orgaoemissorrg = this.AlterarTipo<string>(leitor["Orgaoemissorrg"]);
            this._percdesc = this.AlterarTipo<Decimal?>(leitor["Percdesc"]);
            this._percexclimcred = this.AlterarTipo<Decimal?>(leitor["Percexclimcred"]);
            this._percinss = this.AlterarTipo<Decimal?>(leitor["Percinss"]);
            this._percmaxdesctitulo = this.AlterarTipo<Decimal?>(leitor["Percmaxdesctitulo"]);
            this._percmaxjurosmora = this.AlterarTipo<Decimal?>(leitor["Percmaxjurosmora"]);
            this._percminjurosmora = this.AlterarTipo<Decimal?>(leitor["Percminjurosmora"]);
            this._percommot = this.AlterarTipo<Decimal?>(leitor["Percommot"]);
            this._percreduzcomisrca = this.AlterarTipo<Decimal?>(leitor["Percreduzcomisrca"]);
            this._percvt = this.AlterarTipo<Decimal?>(leitor["Percvt"]);
            this._permitealtdescbx = this.AlterarTipo<string>(leitor["Permitealtdescbx"]);
            this._permitealtjurosbx = this.AlterarTipo<string>(leitor["Permitealtjurosbx"]);
            this._permitepersoncad = this.AlterarTipo<string>(leitor["Permitepersoncad"]);
            this._pis = this.AlterarTipo<string>(leitor["Pis"]);
            this._profissao = this.AlterarTipo<string>(leitor["Profissao"]);
            this._referenciapessoal = this.AlterarTipo<string>(leitor["Referenciapessoal"]);
            this._rescisao = this.AlterarTipo<DateTime?>(leitor["Rescisao"]);
            this._resplibcadastro = this.AlterarTipo<string>(leitor["Resplibcadastro"]);
            this._rg = this.AlterarTipo<string>(leitor["Rg"]);
            this._senhabd = this.AlterarTipo<string>(leitor["Senhabd"]);
            this._seriectps = this.AlterarTipo<string>(leitor["Seriectps"]);
            this._sexo = this.AlterarTipo<string>(leitor["Sexo"]);
            this._situacao = this.AlterarTipo<string>(leitor["Situacao"]);
            this._tipo = this.AlterarTipo<string>(leitor["Tipo"]);
            this._tipoagentecob = this.AlterarTipo<string>(leitor["Tipoagentecob"]);
            this._tipoatende = this.AlterarTipo<string>(leitor["Tipoatende"]);
            this._tipocomissao = this.AlterarTipo<string>(leitor["Tipocomissao"]);
            this._tipoenvio = this.AlterarTipo<string>(leitor["Tipoenvio"]);
            this._tipomotorista = this.AlterarTipo<string>(leitor["Tipomotorista"]);
            this._tipovenda = this.AlterarTipo<string>(leitor["Tipovenda"]);
            this._ufcnh = this.AlterarTipo<string>(leitor["Ufcnh"]);
            this._usaavisoautomenu = this.AlterarTipo<string>(leitor["Usaavisoautomenu"]);
            this._usabiometriamenu = this.AlterarTipo<string>(leitor["Usabiometriamenu"]);
            this._usarateiocomissaooperador = this.AlterarTipo<string>(leitor["Usarateiocomissaooperador"]);
            this._usatabelacliente = this.AlterarTipo<string>(leitor["Usatabelacliente"]);
            this._usuariobd = this.AlterarTipo<string>(leitor["Usuariobd"]);
            this._usuariologado = this.AlterarTipo<string>(leitor["Usuariologado"]);
            this._usuariologadorf = this.AlterarTipo<string>(leitor["Usuariologadorf"]);
            this._vendaassistida = this.AlterarTipo<string>(leitor["Vendaassistida"]);
            this._vladicional = this.AlterarTipo<Decimal?>(leitor["Vladicional"]);
            this._vlaumentolimcred = this.AlterarTipo<Decimal?>(leitor["Vlaumentolimcred"]);
            this._vlcomissent = this.AlterarTipo<Decimal?>(leitor["Vlcomissent"]);
            this._vlcomisston = this.AlterarTipo<Decimal?>(leitor["Vlcomisston"]);
            this._vlfreteentrega = this.AlterarTipo<Decimal?>(leitor["Vlfreteentrega"]);
            this._vllimcredcompra = this.AlterarTipo<Decimal?>(leitor["Vllimcredcompra"]);
            this._vlmaxlibpedido = this.AlterarTipo<Decimal?>(leitor["Vlmaxlibpedido"]);
            this._vlmaxlimcredcli = this.AlterarTipo<Decimal?>(leitor["Vlmaxlimcredcli"]);
            this._vlpensaoalimenticia = this.AlterarTipo<Decimal?>(leitor["Vlpensaoalimenticia"]);
            this._vlplanosaude = this.AlterarTipo<Decimal?>(leitor["Vlplanosaude"]);
            this._vlsalario = this.AlterarTipo<Decimal?>(leitor["Vlsalario"]);
            this._vlsalcarteira = this.AlterarTipo<Decimal?>(leitor["Vlsalcarteira"]);
            this._vlsaldolimaltcredito = this.AlterarTipo<Decimal?>(leitor["Vlsaldolimaltcredito"]);
            this._vlsalfamilia = this.AlterarTipo<Decimal?>(leitor["Vlsalfamilia"]);
            this._vlvales = this.AlterarTipo<Decimal?>(leitor["Vlvales"]);
        }

        
    }
