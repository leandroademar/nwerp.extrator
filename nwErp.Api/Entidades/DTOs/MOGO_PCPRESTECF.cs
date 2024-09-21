namespace nwErp.Entidades.Modelos
{

    [Serializable]
	public class MOGO_PCPRESTECF : GerenteDePropriedades, IEntidade
	{
		private static readonly string RO_EXPORTADO = "Exportado";

		private string _exportado;

		private static readonly string RO_ASSINATURA = "Assinatura";

		private string _assinatura;

		private static readonly string RO_BOLETO = "Boleto";

		private string _boleto;

		private static readonly string RO_CODADMCARTAO = "Codadmcartao";

		private string _codadmcartao;

		private static readonly string RO_CODAUTORIZACAOTEF = "Codautorizacaotef";

		private decimal? _codautorizacaotef;

		private static readonly string RO_CODBANDEIRATEF = "Codbandeiratef";

		private string _codbandeiratef;

		private static readonly string RO_CODBARRA = "Codbarra";

		private string _codbarra;

		private static readonly string RO_CODCLI = "Codcli";

		private decimal _codcli;

		private static readonly string RO_CODCOB = "Codcob";

		private string _codcob;

		private static readonly string RO_CODCOBORIG = "Codcoborig";

		private string _codcoborig;

		private static readonly string RO_CODFILIAL = "Codfilial";

		private string _codfilial;

		private static readonly string RO_CODFILIALNF = "Codfilialnf";

		private string _codfilialnf;

		private static readonly string RO_CODFUNCCHECKOUT = "Codfunccheckout";

		private decimal _codfunccheckout;

		private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

		private decimal? _codsupervisor;

		private static readonly string RO_CODUSUR = "Codusur";

		private decimal _codusur;

		private static readonly string RO_DTBAIXA = "Dtbaixa";

		private DateTime? _dtbaixa;

		private static readonly string RO_DTEMISSAO = "Dtemissao";

		private DateTime _dtemissao;

		private static readonly string RO_DTEMISSAOORIG = "Dtemissaoorig";

		private DateTime? _dtemissaoorig;

		private static readonly string RO_DTEXPORTACAO = "Dtexportacao";

		private DateTime? _dtexportacao;

		private static readonly string RO_DTVENC = "Dtvenc";

		private DateTime _dtvenc;

		private static readonly string RO_DTVENCORIG = "Dtvencorig";

		private DateTime _dtvencorig;

		private static readonly string RO_DUPLIC = "Duplic";

		private decimal _duplic;

		private static readonly string RO_IMPORTADO = "Importado";

		private string _importado;

		private static readonly string RO_LINHADIG = "Linhadig";

		private string _linhadig;

		private static readonly string RO_NSUTEF = "Nsutef";

		private string _nsutef;

		private static readonly string RO_NSUHOST = "Nsuhost";

		private string _nsuhost;

		private static readonly string RO_NUMAGENCIA = "Numagencia";

		private decimal? _numagencia;

		private static readonly string RO_NUMBANCO = "Numbanco";

		private decimal? _numbanco;

		private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

		private decimal? _numcaixafiscal;

		private static readonly string RO_HUBNUMCAIXAPADRAO = "Hubnumcaixapadrao";

		private decimal? _hubnumcaixapadrao;

		private static readonly string RO_NUMCAR = "Numcar";

		private decimal? _numcar;

		private static readonly string RO_NUMCCF = "Numccf";

		private decimal? _numccf;

		private static readonly string RO_NUMCHECKOUT = "Numcheckout";

		private decimal _numcheckout;

		private static readonly string RO_NUMCHEQUE = "Numcheque";

		private decimal? _numcheque;

		private static readonly string RO_NUMCONTACORRENTE = "Numcontacorrente";

		private decimal? _numcontacorrente;

		private static readonly string RO_NUMECF = "Numecf";

		private decimal? _numecf;

		private static readonly string RO_NUMGNF = "Numgnf";

		private decimal? _numgnf;

		private static readonly string RO_NUMPED = "Numped";

		private decimal? _numped;

		private static readonly string RO_NUMPEDECF = "Numpedecf";

		private decimal _numpedecf;

		private static readonly string RO_NUMSERIEEQUIP = "Numserieequip";

		private string _numserieequip;

		private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

		private decimal? _numtransvenda;

		private static readonly string RO_OPERACAO = "Operacao";

		private string _operacao;

		private static readonly string RO_PARCELAMENTOTEF = "Parcelamentotef";

		private string _parcelamentotef;

		private static readonly string RO_PREST = "Prest";

		private string _prest;

		private static readonly string RO_PRESTECF = "Prestecf";

		private string _prestecf;

		private static readonly string RO_PRESTTEF = "Presttef";

		private decimal? _presttef;

		private static readonly string RO_STATUS = "Status";

		private string _status;

		private static readonly string RO_TIPOOPERACAOTEF = "Tipooperacaotef";

		private string _tipooperacaotef;

		private static readonly string RO_VALOR = "Valor";

		private decimal _valor;

		private static readonly string RO_VALORORIG = "Valororig";

		private decimal? _valororig;

		private static readonly string RO_VLTXBOLETO = "Vltxboleto";

		private decimal? _vltxboleto;

		private static readonly string RO_COMPENSACAOBCO = "Compensacaobco";

		private decimal? _compensacaobco;

		private static readonly string RO_CGCCPFCH = "Cgccpfch";

		private string _cgccpfch;

		private static readonly string RO_DVAGENCIA = "Dvagencia";

		private decimal? _dvagencia;

		private static readonly string RO_DVCONTA = "Dvconta";

		private decimal? _dvconta;

		private static readonly string RO_DVCHEQUE = "Dvcheque";

		private decimal? _dvcheque;

		private static readonly string RO_CODCRED = "Codcred";

		private decimal? _codcred;

		private static readonly string RO_NUMCARTAOCRM = "Numcartaocrm";

		private string _numcartaocrm;

		private static readonly string RO_DTCXMOT = "Dtcxmot";

		private DateTime? _dtcxmot;

		private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

		private decimal? _numfechamentomovcx;

		private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

		private DateTime? _dtmovimentocx;

		private static readonly string RO_CORRESPONDENTE = "Correspondente";

		private string _correspondente;

		private static readonly string RO_CNPJCREDENCCARTAO = "Cnpjcredenccartao";

		private string _cnpjcredenccartao;

		private static readonly string RO_CODIGOCONTRAVALE = "Codigocontravale";

		private decimal? _codigocontravale;

		private string _codcobsefaz;

		private decimal? _bandeiracartao;

		private string _md5paf;

		private decimal? _tipodoc;

		private decimal? _valorcomtroco;

		private static readonly string RO_SOMATXBOLETO = "Somatxboleto";

		private string _somatxboleto;

		private static readonly string RO_TIPOCORBAN = "Tipocorban";

		private string _tipocorban;

		private static readonly string RO_CODUSUR2 = "Codusur2";

		private decimal? _codusur2;

		private static readonly string RO_PROCESSADORTRANSPAGDIGITAL = "Processadortranspagdigital";

		private string _processadortranspagdigital;

		private static readonly string RO_NUMTRANSPAGDIGITAL = "Numtranspagdigital";

		private string _numtranspagdigital;

		private static readonly string RO_NSUPAGDIGITAL = "Nsupagdigital";

		private string _nsupagdigital;

		private static readonly string RO_CARTEIRADIGITAL = "Carteiradigital";

		private string _carteiradigital;

		private static readonly string RO_NOMECARTEIRADIGITAL = "Nomecarteiradigital";

		private string _nomecarteiradigital;

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 255, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
		public string Codadmcartao
		{
			get
			{
				PropriedadeAcessada(RO_CODADMCARTAO);
				return _codadmcartao;
			}
			set
			{
				PropriedadeModificada(RO_CODADMCARTAO, value);
				_codadmcartao = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 0)]
		public decimal? Codautorizacaotef
		{
			get
			{
				PropriedadeAcessada(RO_CODAUTORIZACAOTEF);
				return _codautorizacaotef;
			}
			set
			{
				PropriedadeModificada(RO_CODAUTORIZACAOTEF, value);
				_codautorizacaotef = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
		public string Codbandeiratef
		{
			get
			{
				PropriedadeAcessada(RO_CODBANDEIRATEF);
				return _codbandeiratef;
			}
			set
			{
				PropriedadeModificada(RO_CODBANDEIRATEF, value);
				_codbandeiratef = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
		public string Codbarra
		{
			get
			{
				PropriedadeAcessada(RO_CODBARRA);
				return _codbarra;
			}
			set
			{
				PropriedadeModificada(RO_CODBARRA, value);
				_codbarra = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
		public decimal Codcli
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
		public string Codcoborig
		{
			get
			{
				PropriedadeAcessada(RO_CODCOBORIG);
				return _codcoborig;
			}
			set
			{
				PropriedadeModificada(RO_CODCOBORIG, value);
				_codcoborig = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
		public string Codfilialnf
		{
			get
			{
				PropriedadeAcessada(RO_CODFILIALNF);
				return _codfilialnf;
			}
			set
			{
				PropriedadeModificada(RO_CODFILIALNF, value);
				_codfilialnf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = true, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
		public decimal Codfunccheckout
		{
			get
			{
				PropriedadeAcessada(RO_CODFUNCCHECKOUT);
				return _codfunccheckout;
			}
			set
			{
				PropriedadeModificada(RO_CODFUNCCHECKOUT, value);
				_codfunccheckout = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
		public decimal? Codsupervisor
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime? Dtbaixa
		{
			get
			{
				PropriedadeAcessada(RO_DTBAIXA);
				return _dtbaixa;
			}
			set
			{
				PropriedadeModificada(RO_DTBAIXA, value);
				_dtbaixa = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime Dtemissao
		{
			get
			{
				PropriedadeAcessada(RO_DTEMISSAO);
				return _dtemissao;
			}
			set
			{
				PropriedadeModificada(RO_DTEMISSAO, value);
				_dtemissao = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime? Dtemissaoorig
		{
			get
			{
				PropriedadeAcessada(RO_DTEMISSAOORIG);
				return _dtemissaoorig;
			}
			set
			{
				PropriedadeModificada(RO_DTEMISSAOORIG, value);
				_dtemissaoorig = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime? Dtexportacao
		{
			get
			{
				PropriedadeAcessada(RO_DTEXPORTACAO);
				return _dtexportacao;
			}
			set
			{
				PropriedadeModificada(RO_DTEXPORTACAO, value);
				_dtexportacao = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime Dtvenc
		{
			get
			{
				PropriedadeAcessada(RO_DTVENC);
				return _dtvenc;
			}
			set
			{
				PropriedadeModificada(RO_DTVENC, value);
				_dtvenc = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime Dtvencorig
		{
			get
			{
				PropriedadeAcessada(RO_DTVENCORIG);
				return _dtvencorig;
			}
			set
			{
				PropriedadeModificada(RO_DTVENCORIG, value);
				_dtvencorig = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal Duplic
		{
			get
			{
				PropriedadeAcessada(RO_DUPLIC);
				return _duplic;
			}
			set
			{
				PropriedadeModificada(RO_DUPLIC, value);
				_duplic = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Exportado
		{
			get
			{
				PropriedadeAcessada(RO_EXPORTADO);
				return _exportado;
			}
			set
			{
				PropriedadeModificada(RO_EXPORTADO, value);
				_exportado = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Importado
		{
			get
			{
				PropriedadeAcessada(RO_IMPORTADO);
				return _importado;
			}
			set
			{
				PropriedadeModificada(RO_IMPORTADO, value);
				_importado = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 65, Precisao = 0)]
		public string Linhadig
		{
			get
			{
				PropriedadeAcessada(RO_LINHADIG);
				return _linhadig;
			}
			set
			{
				PropriedadeModificada(RO_LINHADIG, value);
				_linhadig = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
		public string Nsutef
		{
			get
			{
				PropriedadeAcessada(RO_NSUTEF);
				return _nsutef;
			}
			set
			{
				PropriedadeModificada(RO_NSUTEF, value);
				_nsutef = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
		public string Nsuhost
		{
			get
			{
				PropriedadeAcessada(RO_NSUHOST);
				return _nsuhost;
			}
			set
			{
				PropriedadeModificada(RO_NSUHOST, value);
				_nsuhost = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
		public decimal? Numcaixafiscal
		{
			get
			{
				PropriedadeAcessada(RO_NUMCAIXAFISCAL);
				return _numcaixafiscal;
			}
			set
			{
				PropriedadeModificada(RO_NUMCAIXAFISCAL, value);
				_numcaixafiscal = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
		public decimal? Hubnumcaixapadrao
		{
			get
			{
				PropriedadeAcessada(RO_HUBNUMCAIXAPADRAO);
				return _hubnumcaixapadrao;
			}
			set
			{
				PropriedadeModificada(RO_HUBNUMCAIXAPADRAO, value);
				_hubnumcaixapadrao = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
		public decimal? Numcar
		{
			get
			{
				PropriedadeAcessada(RO_NUMCAR);
				return _numcar;
			}
			set
			{
				PropriedadeModificada(RO_NUMCAR, value);
				_numcar = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
		public decimal? Numccf
		{
			get
			{
				PropriedadeAcessada(RO_NUMCCF);
				return _numccf;
			}
			set
			{
				PropriedadeModificada(RO_NUMCCF, value);
				_numccf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = true, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
		public decimal Numcheckout
		{
			get
			{
				PropriedadeAcessada(RO_NUMCHECKOUT);
				return _numcheckout;
			}
			set
			{
				PropriedadeModificada(RO_NUMCHECKOUT, value);
				_numcheckout = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
		public decimal? Numcheque
		{
			get
			{
				PropriedadeAcessada(RO_NUMCHEQUE);
				return _numcheque;
			}
			set
			{
				PropriedadeModificada(RO_NUMCHEQUE, value);
				_numcheque = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 11, Precisao = 0)]
		public decimal? Numcontacorrente
		{
			get
			{
				PropriedadeAcessada(RO_NUMCONTACORRENTE);
				return _numcontacorrente;
			}
			set
			{
				PropriedadeModificada(RO_NUMCONTACORRENTE, value);
				_numcontacorrente = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal? Numecf
		{
			get
			{
				PropriedadeAcessada(RO_NUMECF);
				return _numecf;
			}
			set
			{
				PropriedadeModificada(RO_NUMECF, value);
				_numecf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal? Numgnf
		{
			get
			{
				PropriedadeAcessada(RO_NUMGNF);
				return _numgnf;
			}
			set
			{
				PropriedadeModificada(RO_NUMGNF, value);
				_numgnf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal? Numped
		{
			get
			{
				PropriedadeAcessada(RO_NUMPED);
				return _numped;
			}
			set
			{
				PropriedadeModificada(RO_NUMPED, value);
				_numped = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = true, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal Numpedecf
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

		[InfoCampoEntidade(ChavePrimaria = true, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
		public string Numserieequip
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal? Numtransvenda
		{
			get
			{
				PropriedadeAcessada(RO_NUMTRANSVENDA);
				return _numtransvenda;
			}
			set
			{
				PropriedadeModificada(RO_NUMTRANSVENDA, value);
				_numtransvenda = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Parcelamentotef
		{
			get
			{
				PropriedadeAcessada(RO_PARCELAMENTOTEF);
				return _parcelamentotef;
			}
			set
			{
				PropriedadeModificada(RO_PARCELAMENTOTEF, value);
				_parcelamentotef = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
		public string Prest
		{
			get
			{
				PropriedadeAcessada(RO_PREST);
				return _prest;
			}
			set
			{
				PropriedadeModificada(RO_PREST, value);
				_prest = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = true, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
		public string Prestecf
		{
			get
			{
				PropriedadeAcessada(RO_PRESTECF);
				return _prestecf;
			}
			set
			{
				PropriedadeModificada(RO_PRESTECF, value);
				_prestecf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
		public decimal? Presttef
		{
			get
			{
				PropriedadeAcessada(RO_PRESTTEF);
				return _presttef;
			}
			set
			{
				PropriedadeModificada(RO_PRESTTEF, value);
				_presttef = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Status
		{
			get
			{
				PropriedadeAcessada(RO_STATUS);
				return _status;
			}
			set
			{
				PropriedadeModificada(RO_STATUS, value);
				_status = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
		public decimal Valor
		{
			get
			{
				PropriedadeAcessada(RO_VALOR);
				return _valor;
			}
			set
			{
				PropriedadeModificada(RO_VALOR, value);
				_valor = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
		public decimal? Valororig
		{
			get
			{
				PropriedadeAcessada(RO_VALORORIG);
				return _valororig;
			}
			set
			{
				PropriedadeModificada(RO_VALORORIG, value);
				_valororig = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
		public decimal? Vltxboleto
		{
			get
			{
				PropriedadeAcessada(RO_VLTXBOLETO);
				return _vltxboleto;
			}
			set
			{
				PropriedadeModificada(RO_VLTXBOLETO, value);
				_vltxboleto = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
		public decimal? Compensacaobco
		{
			get
			{
				PropriedadeAcessada(RO_COMPENSACAOBCO);
				return _compensacaobco;
			}
			set
			{
				PropriedadeModificada(RO_COMPENSACAOBCO, value);
				_compensacaobco = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
		public string Cgccpfch
		{
			get
			{
				PropriedadeAcessada(RO_CGCCPFCH);
				return _cgccpfch;
			}
			set
			{
				PropriedadeModificada(RO_CGCCPFCH, value);
				_cgccpfch = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
		public decimal? Dvagencia
		{
			get
			{
				PropriedadeAcessada(RO_DVAGENCIA);
				return _dvagencia;
			}
			set
			{
				PropriedadeModificada(RO_DVAGENCIA, value);
				_dvagencia = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
		public decimal? Dvconta
		{
			get
			{
				PropriedadeAcessada(RO_DVCONTA);
				return _dvconta;
			}
			set
			{
				PropriedadeModificada(RO_DVCONTA, value);
				_dvconta = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
		public decimal? Dvcheque
		{
			get
			{
				PropriedadeAcessada(RO_DVCHEQUE);
				return _dvcheque;
			}
			set
			{
				PropriedadeModificada(RO_DVCHEQUE, value);
				_dvcheque = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
		public decimal? Codcred
		{
			get
			{
				PropriedadeAcessada(RO_CODCRED);
				return _codcred;
			}
			set
			{
				PropriedadeModificada(RO_CODCRED, value);
				_codcred = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 19, Precisao = 0)]
		public string Numcartaocrm
		{
			get
			{
				PropriedadeAcessada(RO_NUMCARTAOCRM);
				return _numcartaocrm;
			}
			set
			{
				PropriedadeModificada(RO_NUMCARTAOCRM, value);
				_numcartaocrm = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
		public DateTime? Dtcxmot
		{
			get
			{
				PropriedadeAcessada(RO_DTCXMOT);
				return _dtcxmot;
			}
			set
			{
				PropriedadeModificada(RO_DTCXMOT, value);
				_dtcxmot = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
		public string Correspondente
		{
			get
			{
				PropriedadeAcessada(RO_CORRESPONDENTE);
				return _correspondente;
			}
			set
			{
				PropriedadeModificada(RO_CORRESPONDENTE, value);
				_correspondente = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
		public string Cnpjcredenccartao
		{
			get
			{
				PropriedadeAcessada(RO_CNPJCREDENCCARTAO);
				return _cnpjcredenccartao;
			}
			set
			{
				PropriedadeModificada(RO_CNPJCREDENCCARTAO, value);
				_cnpjcredenccartao = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
		public decimal? Codigocontravale
		{
			get
			{
				PropriedadeAcessada(RO_CODIGOCONTRAVALE);
				return _codigocontravale;
			}
			set
			{
				PropriedadeModificada(RO_CODIGOCONTRAVALE, value);
				_codigocontravale = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
		public string Md5paf
		{
			get
			{
				PropriedadeAcessada("Md5paf");
				return _md5paf;
			}
			set
			{
				PropriedadeModificada("Md5paf", value);
				_md5paf = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
		public decimal? Tipodoc
		{
			get
			{
				PropriedadeAcessada("Tipodoc");
				return _tipodoc;
			}
			set
			{
				PropriedadeModificada("Tipodoc", value);
				_tipodoc = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
		public decimal? Valorcomtroco
		{
			get
			{
				PropriedadeAcessada("Valorcomtroco");
				return _valorcomtroco;
			}
			set
			{
				PropriedadeModificada("Valorcomtroco", value);
				_valorcomtroco = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Somatxboleto
		{
			get
			{
				PropriedadeAcessada(RO_SOMATXBOLETO);
				return _somatxboleto;
			}
			set
			{
				PropriedadeModificada(RO_SOMATXBOLETO, value);
				_somatxboleto = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
		public string Tipocorban
		{
			get
			{
				PropriedadeAcessada(RO_TIPOCORBAN);
				return _tipocorban;
			}
			set
			{
				PropriedadeModificada(RO_TIPOCORBAN, value);
				_tipocorban = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
		public decimal? Codusur2
		{
			get
			{
				PropriedadeAcessada(RO_CODUSUR2);
				return _codusur2;
			}
			set
			{
				PropriedadeModificada(RO_CODUSUR2, value);
				_codusur2 = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
		public string Processadortranspagdigital
		{
			get
			{
				PropriedadeAcessada(RO_PROCESSADORTRANSPAGDIGITAL);
				return _processadortranspagdigital;
			}
			set
			{
				PropriedadeModificada(RO_PROCESSADORTRANSPAGDIGITAL, value);
				_processadortranspagdigital = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
		public string Numtranspagdigital
		{
			get
			{
				PropriedadeAcessada(RO_NUMTRANSPAGDIGITAL);
				return _numtranspagdigital;
			}
			set
			{
				PropriedadeModificada(RO_NUMTRANSPAGDIGITAL, value);
				_numtranspagdigital = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
		public string Nsupagdigital
		{
			get
			{
				PropriedadeAcessada(RO_NSUPAGDIGITAL);
				return _nsupagdigital;
			}
			set
			{
				PropriedadeModificada(RO_NSUPAGDIGITAL, value);
				_nsupagdigital = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
		public string Carteiradigital
		{
			get
			{
				PropriedadeAcessada(RO_CARTEIRADIGITAL);
				return _carteiradigital;
			}
			set
			{
				PropriedadeModificada(RO_CARTEIRADIGITAL, value);
				_carteiradigital = value;
			}
		}

		[InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 50, Precisao = 0)]
		public string Nomecarteiradigital
		{
			get
			{
				PropriedadeAcessada(RO_NOMECARTEIRADIGITAL);
				return _nomecarteiradigital;
			}
			set
			{
				PropriedadeModificada(RO_NOMECARTEIRADIGITAL, value);
				_nomecarteiradigital = value;
			}
		}

		public void InicializarAtributos()
		{
		}

		public string ObterNomeTabela()
		{
			return "MOGO_PCPRESTECF";
		}

		public IEntidade NovaInstancia()
		{
			return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
		}

		public void CarregarPorDataReader(IDataReader leitor)
		{
			_assinatura = AlterarTipo<string>(leitor["Assinatura"]);
			_boleto = AlterarTipo<string>(leitor["Boleto"]);
			_codadmcartao = AlterarTipo<string>(leitor["Codadmcartao"]);
			_codautorizacaotef = AlterarTipo<decimal?>(leitor["Codautorizacaotef"]);
			_codbandeiratef = AlterarTipo<string>(leitor["Codbandeiratef"]);
			_codbarra = AlterarTipo<string>(leitor["Codbarra"]);
			_codcli = AlterarTipo<decimal>(leitor["Codcli"]);
			_codcob = AlterarTipo<string>(leitor["Codcob"]);
			_codcoborig = AlterarTipo<string>(leitor["Codcoborig"]);
			_codfilial = AlterarTipo<string>(leitor["Codfilial"]);
			_codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
			_codfunccheckout = AlterarTipo<decimal>(leitor["Codfunccheckout"]);
			_codsupervisor = AlterarTipo<decimal?>(leitor["Codsupervisor"]);
			_codusur = AlterarTipo<decimal>(leitor["Codusur"]);
			_dtbaixa = AlterarTipo<DateTime?>(leitor["Dtbaixa"]);
			_dtemissao = AlterarTipo<DateTime>(leitor["Dtemissao"]);
			_dtemissaoorig = AlterarTipo<DateTime?>(leitor["Dtemissaoorig"]);
			_dtexportacao = AlterarTipo<DateTime?>(leitor["Dtexportacao"]);
			_dtvenc = AlterarTipo<DateTime>(leitor["Dtvenc"]);
			_dtvencorig = AlterarTipo<DateTime>(leitor["Dtvencorig"]);
			_duplic = AlterarTipo<decimal>(leitor["Duplic"]);
			_exportado = AlterarTipo<string>(leitor["Exportado"]);
			_importado = AlterarTipo<string>(leitor["Importado"]);
			_linhadig = AlterarTipo<string>(leitor["Linhadig"]);
			_nsutef = AlterarTipo<string>(leitor["Nsutef"]);
			_nsuhost = AlterarTipo<string>(leitor["Nsuhost"]);
			_numagencia = AlterarTipo<decimal?>(leitor["Numagencia"]);
			_numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
			_numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
			_hubnumcaixapadrao = AlterarTipo<decimal?>(leitor["Hubnumcaixapadrao"]);
			_numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
			_numccf = AlterarTipo<decimal?>(leitor["Numccf"]);
			_numcheckout = AlterarTipo<decimal>(leitor["Numcheckout"]);
			_numcheque = AlterarTipo<decimal?>(leitor["Numcheque"]);
			_numcontacorrente = AlterarTipo<decimal?>(leitor["Numcontacorrente"]);
			_numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
			_numgnf = AlterarTipo<decimal?>(leitor["Numgnf"]);
			_numped = AlterarTipo<decimal?>(leitor["Numped"]);
			_numpedecf = AlterarTipo<decimal>(leitor["Numpedecf"]);
			_numserieequip = AlterarTipo<string>(leitor["Numserieequip"]);
			_numtransvenda = AlterarTipo<decimal?>(leitor["Numtransvenda"]);
			_operacao = AlterarTipo<string>(leitor["Operacao"]);
			_parcelamentotef = AlterarTipo<string>(leitor["Parcelamentotef"]);
			_prest = AlterarTipo<string>(leitor["Prest"]);
			_prestecf = AlterarTipo<string>(leitor["Prestecf"]);
			_presttef = AlterarTipo<decimal?>(leitor["Presttef"]);
			_status = AlterarTipo<string>(leitor["Status"]);
			_tipooperacaotef = AlterarTipo<string>(leitor["Tipooperacaotef"]);
			_valor = AlterarTipo<decimal>(leitor["Valor"]);
			_valororig = AlterarTipo<decimal?>(leitor["Valororig"]);
			_vltxboleto = AlterarTipo<decimal?>(leitor["Vltxboleto"]);
			_compensacaobco = AlterarTipo<decimal?>(leitor["Compensacaobco"]);
			_cgccpfch = AlterarTipo<string>(leitor["Cgccpfch"]);
			_dvagencia = AlterarTipo<decimal?>(leitor["Dvagencia"]);
			_dvconta = AlterarTipo<decimal?>(leitor["Dvconta"]);
			_dvcheque = AlterarTipo<decimal?>(leitor["Dvcheque"]);
			_codcred = AlterarTipo<decimal?>(leitor["Codcred"]);
			_numcartaocrm = AlterarTipo<string>(leitor["Numcartaocrm"]);
			_dtcxmot = AlterarTipo<DateTime?>(leitor["Dtcxmot"]);
			_numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
			_dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
			_codigocontravale = AlterarTipo<decimal?>(leitor["Codigocontravale"]);
			_codcobsefaz = AlterarTipo<string>(leitor["Codcobsefaz"]);
			_bandeiracartao = AlterarTipo<decimal?>(leitor["Bandeiracartao"]);
			_md5paf = AlterarTipo<string>(leitor["Md5paf"]);
			_tipodoc = AlterarTipo<decimal?>(leitor["Tipodoc"]);
			_valorcomtroco = AlterarTipo<decimal?>(leitor["Valorcomtroco"]);
			_somatxboleto = AlterarTipo<string>(leitor["Somatxboleto"]);
			_tipocorban = AlterarTipo<string>(leitor["Tipocorban"]);
			_codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
			_processadortranspagdigital = AlterarTipo<string>(leitor["Processadortranspagdigital"]);
			_numtranspagdigital = AlterarTipo<string>(leitor["numtranspagdigital"]);
			_nsupagdigital = AlterarTipo<string>(leitor["nsupagdigital"]);
			_carteiradigital = AlterarTipo<string>(leitor["carteiradigital"]);
			_nomecarteiradigital = AlterarTipo<string>(leitor["nomecarteiradigital"]);
		}

	}

}