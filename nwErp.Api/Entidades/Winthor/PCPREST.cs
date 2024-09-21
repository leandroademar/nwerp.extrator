

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCPREST : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_AGRUPADO = "Agrupado";

    private string _agrupado;

    private static readonly string RO_ALINEA = "Alinea";

    private decimal? _alinea;

    private static readonly string RO_ARQRETORNO = "Arqretorno";

    private string _arqretorno;

    private static readonly string RO_BAIXACONCILIADA = "Baixaconciliada";

    private string _baixaconciliada;

    private static readonly string RO_BLOQDESDEMITENTEDIF = "Bloqdesdemitentedif";

    private string _bloqdesdemitentedif;

    private static readonly string RO_BOLETO = "Boleto";

    private string _boleto;

    private static readonly string RO_CARTORIO = "Cartorio";

    private string _cartorio;

    private static readonly string RO_CGCCPFCH = "Cgccpfch";

    private string _cgccpfch;

    private static readonly string RO_CHEQUETERCEIRO = "Chequeterceiro";

    private string _chequeterceiro;

    private static readonly string RO_CNPJCISP = "Cnpjcisp";

    private string _cnpjcisp;

    private static readonly string RO_CODADMCARTAO = "Codadmcartao";

    private string _codadmcartao;

    private static readonly string RO_CODAGENTECOBRANCA = "Codagentecobranca";

    private decimal? _codagentecobranca;

    private static readonly string RO_CODAUTORIZACAOTEF = "Codautorizacaotef";

    private decimal? _codautorizacaotef;

    private static readonly string RO_CODBAIXA = "Codbaixa";

    private decimal? _codbaixa;

    private static readonly string RO_CODBANCO = "Codbanco";

    private decimal? _codbanco;

    private static readonly string RO_CODBANCOBAIXA = "Codbancobaixa";

    private decimal? _codbancobaixa;

    private static readonly string RO_CODBANCOCM = "Codbancocm";

    private decimal? _codbancocm;

    private static readonly string RO_CODBANCOCM2 = "Codbancocm2";

    private decimal? _codbancocm2;

    private static readonly string RO_CODBANCOCUSTODIA = "Codbancocustodia";

    private decimal? _codbancocustodia;

    private static readonly string RO_CODBANCOVENDOR = "Codbancovendor";

    private decimal? _codbancovendor;

    private static readonly string RO_CODBANDEIRATEF = "Codbandeiratef";

    private string _codbandeiratef;

    private static readonly string RO_CODBARRA = "Codbarra";

    private string _codbarra;

    private static readonly string RO_CODBARRA2 = "Codbarra2";

    private string _codbarra2;

    private static readonly string RO_CODBCOCUSTODIA = "Codbcocustodia";

    private decimal? _codbcocustodia;

    private static readonly string RO_CODBLOCO = "Codbloco";

    private decimal? _codbloco;

    private static readonly string RO_CODCLI = "Codcli";

    private decimal _codcli;

    private static readonly string RO_CODCOB = "Codcob";

    private string _codcob;

    private static readonly string RO_CODCOBBANCO = "Codcobbanco";

    private string _codcobbanco;

    private static readonly string RO_CODCOBORIG = "Codcoborig";

    private string _codcoborig;

    private static readonly string RO_CODCOBPOS = "Codcobpos";

    private string _codcobpos;

    private static readonly string RO_CODCOBRADOR = "Codcobrador";

    private decimal? _codcobrador;

    private static readonly string RO_CODEMITENTEPEDIDO = "Codemitentepedido";

    private decimal? _codemitentepedido;

    private static readonly string RO_CODEPTO = "Codepto";

    private decimal? _codepto;

    private static readonly string RO_CODESTABELECIMENTO = "Codestabelecimento";

    private string _codestabelecimento;

    private static readonly string RO_CODFILIAL = "Codfilial";

    private string _codfilial;

    private static readonly string RO_CODFILIALNF = "Codfilialnf";

    private string _codfilialnf;

    private static readonly string RO_CODFUNCBORDERO = "Codfuncbordero";

    private decimal? _codfuncbordero;

    private static readonly string RO_CODFUNCCHECKOUT = "Codfunccheckout";

    private decimal? _codfunccheckout;

    private static readonly string RO_CODFUNCCONCIL = "Codfuncconcil";

    private decimal? _codfuncconcil;

    private static readonly string RO_CODFUNCCONCILVENC = "Codfuncconcilvenc";

    private decimal? _codfuncconcilvenc;

    private static readonly string RO_CODFUNCCXMOT = "Codfunccxmot";

    private decimal? _codfunccxmot;

    private static readonly string RO_CODFUNCDESD = "Codfuncdesd";

    private decimal? _codfuncdesd;

    private static readonly string RO_CODFUNCDESD1 = "Codfuncdesd1";

    private decimal? _codfuncdesd1;

    private static readonly string RO_CODFUNCDNICLI = "Codfuncdnicli";

    private decimal? _codfuncdnicli;

    private static readonly string RO_CODFUNCESTORNO = "Codfuncestorno";

    private decimal? _codfuncestorno;

    private static readonly string RO_CODFUNCFECHA = "Codfuncfecha";

    private decimal? _codfuncfecha;

    private static readonly string RO_CODFUNCINC = "Codfuncinc";

    private decimal? _codfuncinc;

    private static readonly string RO_CODFUNCLIBERACAOENTREGA = "Codfuncliberacaoentrega";

    private decimal? _codfuncliberacaoentrega;

    private static readonly string RO_CODFUNCPRORROG = "Codfuncprorrog";

    private decimal? _codfuncprorrog;

    private static readonly string RO_CODFUNCULTALTER = "Codfuncultalter";

    private decimal? _codfuncultalter;

    private static readonly string RO_CODFUNCVALE = "Codfuncvale";

    private decimal? _codfuncvale;

    private static readonly string RO_CODFUNCVEND = "Codfuncvend";

    private decimal? _codfuncvend;

    private static readonly string RO_CODHISTVALE = "Codhistvale";

    private decimal? _codhistvale;

    private static readonly string RO_CODMOTORISTA = "Codmotorista";

    private decimal? _codmotorista;

    private static readonly string RO_CODOCORRBAIXA = "Codocorrbaixa";

    private decimal? _codocorrbaixa;

    private static readonly string RO_CODPORTADOR = "Codportador";

    private decimal? _codportador;

    private static readonly string RO_CODPROFISSIONAL = "Codprofissional";

    private decimal? _codprofissional;

    private static readonly string RO_CODSTATUSCOB = "Codstatuscob";

    private decimal? _codstatuscob;

    private static readonly string RO_CODSUPERVISOR = "Codsupervisor";

    private decimal? _codsupervisor;

    private static readonly string RO_CODUSUR = "Codusur";

    private decimal _codusur;

    private static readonly string RO_CODUSURANT = "Codusurant";

    private decimal? _codusurant;

    private static readonly string RO_CODUSURPGCOMISSAO = "Codusurpgcomissao";

    private decimal? _codusurpgcomissao;

    private static readonly string RO_CODUSUR2 = "Codusur2";

    private decimal? _codusur2;

    private static readonly string RO_CODUSUR3 = "Codusur3";

    private decimal? _codusur3;

    private static readonly string RO_CODUSUR4 = "Codusur4";

    private decimal? _codusur4;

    private static readonly string RO_COMPENSACAOBCO = "Compensacaobco";

    private decimal? _compensacaobco;

    private static readonly string RO_CONTRATOVENDOR = "Contratovendor";

    private decimal? _contratovendor;

    private static readonly string RO_DADOSECF = "Dadosecf";

    private string _dadosecf;

    private static readonly string RO_DATAHORAMINUTOBAIXA = "Datahoraminutobaixa";

    private DateTime? _datahoraminutobaixa;

    private static readonly string RO_DIGITAO = "Digitao";

    private string _digitao;

    private static readonly string RO_DTABERTURACONTA = "Dtaberturaconta";

    private DateTime? _dtaberturaconta;

    private static readonly string RO_DTASSOCIADNICLI = "Dtassociadnicli";

    private DateTime? _dtassociadnicli;

    private static readonly string RO_DTBAIXA = "Dtbaixa";

    private DateTime? _dtbaixa;

    private static readonly string RO_DTBAIXACRED = "Dtbaixacred";

    private DateTime? _dtbaixacred;

    private static readonly string RO_DTBORDER = "Dtborder";

    private DateTime? _dtborder;

    private static readonly string RO_DTBORDERO = "Dtbordero";

    private DateTime? _dtbordero;

    private static readonly string RO_DTCANCEL = "Dtcancel";

    private DateTime? _dtcancel;

    private static readonly string RO_DTCONCIL = "Dtconcil";

    private DateTime? _dtconcil;

    private static readonly string RO_DTCONCILVENC = "Dtconcilvenc";

    private DateTime? _dtconcilvenc;

    private static readonly string RO_DTCRIACAO = "Dtcriacao";

    private DateTime? _dtcriacao;

    private static readonly string RO_DTCUSTODIA = "Dtcustodia";

    private DateTime? _dtcustodia;

    private static readonly string RO_DTCXMOT = "Dtcxmot";

    private DateTime? _dtcxmot;

    private static readonly string RO_DTCXMOTHHMMSS = "Dtcxmothhmmss";

    private DateTime? _dtcxmothhmmss;

    private static readonly string RO_DTDEFAGENTE = "Dtdefagente";

    private DateTime? _dtdefagente;

    private static readonly string RO_DTDESC = "Dtdesc";

    private DateTime? _dtdesc;

    private static readonly string RO_DTDESCONTADO = "Dtdescontado";

    private DateTime? _dtdescontado;

    private static readonly string RO_DTDESCONTOTITBCO = "Dtdescontotitbco";

    private DateTime? _dtdescontotitbco;

    private static readonly string RO_DTDESD = "Dtdesd";

    private DateTime? _dtdesd;

    private static readonly string RO_DTDEVOL = "Dtdevol";

    private DateTime? _dtdevol;

    private static readonly string RO_DTEMISSAO = "Dtemissao";

    private DateTime _dtemissao;

    private static readonly string RO_DTEMISSAOORIG = "Dtemissaoorig";

    private DateTime? _dtemissaoorig;

    private static readonly string RO_DTENVIOSERASA = "Dtenvioserasa";

    private DateTime? _dtenvioserasa;

    private static readonly string RO_DTESTORNO = "Dtestorno";

    private DateTime? _dtestorno;

    private static readonly string RO_DTEXPORTACAOSERVINT = "Dtexportacaoservint";

    private DateTime? _dtexportacaoservint;

    private static readonly string RO_DTFECHA = "Dtfecha";

    private DateTime? _dtfecha;

    private static readonly string RO_DTFECHAVENDOR = "Dtfechavendor";

    private DateTime? _dtfechavendor;

    private static readonly string RO_DTIMPORTACAOSERVPRINC = "Dtimportacaoservprinc";

    private DateTime? _dtimportacaoservprinc;

    private static readonly string RO_DTINCLUSAO = "Dtinclusao";

    private DateTime? _dtinclusao;

    private static readonly string RO_DTINCLUSAOMANUAL = "Dtinclusaomanual";

    private DateTime? _dtinclusaomanual;

    private static readonly string RO_DTLANCCH = "Dtlancch";

    private DateTime? _dtlancch;

    private static readonly string RO_DTLANCPRORROG = "Dtlancprorrog";

    private DateTime? _dtlancprorrog;

    private static readonly string RO_DTLIBERACAOENTREGA = "Dtliberacaoentrega";

    private DateTime? _dtliberacaoentrega;

    private static readonly string RO_DTLIBERACAOFECHAMENTO = "Dtliberacaofechamento";

    private DateTime? _dtliberacaofechamento;

    private static readonly string RO_DTPAG = "Dtpag";

    private DateTime? _dtpag;

    private static readonly string RO_DTPAGCOMISSAO = "Dtpagcomissao";

    private DateTime? _dtpagcomissao;

    private static readonly string RO_DTPAGCOMISSAOPROF = "Dtpagcomissaoprof";

    private DateTime? _dtpagcomissaoprof;

    private static readonly string RO_DTPAGCOMISSAO2 = "Dtpagcomissao2";

    private DateTime? _dtpagcomissao2;

    private static readonly string RO_DTPAGCOMISSAO3 = "Dtpagcomissao3";

    private DateTime? _dtpagcomissao3;

    private static readonly string RO_DTPAGCOMISSAO4 = "Dtpagcomissao4";

    private DateTime? _dtpagcomissao4;

    private static readonly string RO_DTPROCESSAMENTO = "Dtprocessamento";

    private DateTime? _dtprocessamento;

    private static readonly string RO_DTREGCARTEIRA = "Dtregcarteira";

    private DateTime? _dtregcarteira;

    private static readonly string RO_DTREMVENDOR = "Dtremvendor";

    private DateTime? _dtremvendor;

    private static readonly string RO_DTRETIRADASERASA = "Dtretiradaserasa";

    private DateTime? _dtretiradaserasa;

    private static readonly string RO_DTSAIDA = "Dtsaida";

    private DateTime? _dtsaida;

    private static readonly string RO_DTULTALTER = "Dtultalter";

    private DateTime? _dtultalter;

    private static readonly string RO_DTULTESTORNO = "Dtultestorno";

    private DateTime? _dtultestorno;

    private static readonly string RO_DTVENC = "Dtvenc";

    private DateTime _dtvenc;

    private static readonly string RO_DTVENCANTERIOR = "Dtvencanterior";

    private DateTime? _dtvencanterior;

    private static readonly string RO_DTVENCORIG = "Dtvencorig";

    private DateTime _dtvencorig;

    private static readonly string RO_DTVENCVALE = "Dtvencvale";

    private DateTime? _dtvencvale;

    private static readonly string RO_DTVENDOR = "Dtvendor";

    private DateTime? _dtvendor;

    private static readonly string RO_DUPLIC = "Duplic";

    private decimal _duplic;

    private static readonly string RO_DVAGENCIA = "Dvagencia";

    private decimal? _dvagencia;

    private static readonly string RO_DVCHEQUE = "Dvcheque";

    private decimal? _dvcheque;

    private static readonly string RO_DVCOB = "Dvcob";

    private decimal? _dvcob;

    private static readonly string RO_DVCONTA = "Dvconta";

    private decimal? _dvconta;

    private static readonly string RO_ENVIADOQIS = "Enviadoqis";

    private string _enviadoqis;

    private static readonly string RO_EQUIPLANC = "Equiplanc";

    private string _equiplanc;

    private static readonly string RO_EXPORTADOSERVINT = "Exportadoservint";

    private string _exportadoservint;

    private static readonly string RO_FUNCLANC = "Funclanc";

    private string _funclanc;

    private static readonly string RO_GERACAORAZAOAUXILIAR = "Geracaorazaoauxiliar";

    private string _geracaorazaoauxiliar;

    private static readonly string RO_HOBPERCOMMOT = "Hobpercommot";

    private decimal? _hobpercommot;

    private static readonly string RO_HOBPERCOMSUP = "Hobpercomsup";

    private decimal? _hobpercomsup;

    private static readonly string RO_HORADESD = "Horadesd";

    private decimal? _horadesd;

    private static readonly string RO_HORAESTORNO = "Horaestorno";

    private decimal? _horaestorno;

    private static readonly string RO_HORAFECHA = "Horafecha";

    private decimal? _horafecha;

    private static readonly string RO_IDCOB = "Idcob";

    private decimal? _idcob;

    private static readonly string RO_IDTITULO = "Idtitulo";

    private decimal? _idtitulo;

    private static readonly string RO_IMPORTADOSERVPRINC = "Importadoservprinc";

    private string _importadoservprinc;

    private static readonly string RO_LINHADIG = "Linhadig";

    private string _linhadig;

    private static readonly string RO_LINHADIG2 = "Linhadig2";

    private string _linhadig2;

    private static readonly string RO_MINUTODESD = "Minutodesd";

    private decimal? _minutodesd;

    private static readonly string RO_MINUTOESTORNO = "Minutoestorno";

    private decimal? _minutoestorno;

    private static readonly string RO_MINUTOFECHA = "Minutofecha";

    private decimal? _minutofecha;

    private static readonly string RO_NOMEARQUIVO = "Nomearquivo";

    private string _nomearquivo;

    private static readonly string RO_NOSSONUMBCO = "Nossonumbco";

    private string _nossonumbco;

    private static readonly string RO_NOSSONUMBCO2 = "Nossonumbco2";

    private string _nossonumbco2;

    private static readonly string RO_NSUTEF = "Nsutef";

    private string _nsutef;

    private static readonly string RO_NSUHOST = "Nsuhost";

    private string _nsuhost;

    private static readonly string RO_NUMAGENCIA = "Numagencia";

    private decimal? _numagencia;

    private static readonly string RO_NUMASSOCDNI = "Numassocdni";

    private decimal? _numassocdni;

    private static readonly string RO_NUMBANCO = "Numbanco";

    private decimal? _numbanco;

    private static readonly string RO_NUMBORDERO = "Numbordero";

    private decimal? _numbordero;

    private static readonly string RO_NUMCAIXAFISCAL = "Numcaixafiscal";

    private decimal? _numcaixafiscal;

    private static readonly string RO_HUBNUMCAIXAPADRAO = "Hubnumcaixapadrao";

    private decimal? _hubnumcaixapadrao;

    private static readonly string RO_NUMCAR = "Numcar";

    private decimal? _numcar;

    private static readonly string RO_NUMCARANTERIOR = "Numcaranterior";

    private decimal? _numcaranterior;

    private static readonly string RO_NUMCARTAO = "Numcartao";

    private string _numcartao;

    private static readonly string RO_NUMCHECKOUT = "Numcheckout";

    private decimal? _numcheckout;

    private static readonly string RO_NUMCHEQUE = "Numcheque";

    private decimal? _numcheque;

    private static readonly string RO_NUMCONTACORRENTE = "Numcontacorrente";

    private decimal? _numcontacorrente;

    private static readonly string RO_NUMCUSTODIA = "Numcustodia";

    private decimal? _numcustodia;

    private static readonly string RO_NUMDIASCARENCIA = "Numdiascarencia";

    private decimal? _numdiascarencia;

    private static readonly string RO_NUMDIASPRAZOPROTESTO = "Numdiasprazoprotesto";

    private decimal? _numdiasprazoprotesto;

    private static readonly string RO_NUMECF = "Numecf";

    private decimal? _numecf;

    private static readonly string RO_NUMLOTECARTAOTEF = "Numlotecartaotef";

    private string _numlotecartaotef;

    private static readonly string RO_NUMLOTECUSTODIA = "Numlotecustodia";

    private decimal? _numlotecustodia;

    private static readonly string RO_NUMNEGOCIACAO = "Numnegociacao";

    private decimal? _numnegociacao;

    private static readonly string RO_NUMPED = "Numped";

    private decimal? _numped;

    private static readonly string RO_NUMRECIBO = "Numrecibo";

    private decimal? _numrecibo;

    private static readonly string RO_NUMREMESSA = "Numremessa";

    private decimal? _numremessa;

    private static readonly string RO_NUMSEQRETORNO = "Numseqretorno";

    private decimal? _numseqretorno;

    private static readonly string RO_NUMTRANS = "Numtrans";

    private decimal? _numtrans;

    private static readonly string RO_NUMTRANSENT = "Numtransent";

    private decimal? _numtransent;

    private static readonly string RO_NUMTRANSENTDEVCLI = "Numtransentdevcli";

    private decimal? _numtransentdevcli;

    private static readonly string RO_NUMTRANSVENDA = "Numtransvenda";

    private decimal _numtransvenda;

    private static readonly string RO_NUMTRANSVENDAST = "Numtransvendast";

    private decimal? _numtransvendast;

    private static readonly string RO_NUMTRANSVENDOR = "Numtransvendor";

    private decimal? _numtransvendor;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_OBSCUSTODIA = "Obscustodia";

    private string _obscustodia;

    private static readonly string RO_OBSFINANC = "Obsfinanc";

    private string _obsfinanc;

    private static readonly string RO_OBS2 = "Obs2";

    private string _obs2;

    private static readonly string RO_OPERACAO = "Operacao";

    private string _operacao;

    private static readonly string RO_ORIGEMBOLETO = "Origemboleto";

    private string _origemboleto;

    private static readonly string RO_PARCELAMENTOTEF = "Parcelamentotef";

    private string _parcelamentotef;

    private static readonly string RO_PERCOM = "Percom";

    private decimal? _percom;

    private static readonly string RO_PERCOMSUP = "Percomsup";

    private decimal? _percomsup;

    private static readonly string RO_PERCOM2 = "Percom2";

    private decimal? _percom2;

    private static readonly string RO_PERCOM3 = "Percom3";

    private decimal? _percom3;

    private static readonly string RO_PERCOM4 = "Percom4";

    private decimal? _percom4;

    private static readonly string RO_PERDESC = "Perdesc";

    private decimal? _perdesc;

    private static readonly string RO_PERMITEESTORNO = "Permiteestorno";

    private string _permiteestorno;

    private static readonly string RO_PREST = "Prest";

    private string _prest;

    private static readonly string RO_PRESTTEF = "Presttef";

    private decimal? _presttef;

    private static readonly string RO_PROTESTO = "Protesto";

    private string _protesto;

    private static readonly string RO_QTPARCELASPOS = "Qtparcelaspos";

    private decimal? _qtparcelaspos;

    private static readonly string RO_RESPONSAVELPAG = "Responsavelpag";

    private string _responsavelpag;

    private static readonly string RO_ROTDESD = "Rotdesd";

    private decimal? _rotdesd;

    private static readonly string RO_ROTINALANC = "Rotinalanc";

    private decimal? _rotinalanc;

    private static readonly string RO_ROTINALANCULTALT = "Rotinalancultalt";

    private string _rotinalancultalt;

    private static readonly string RO_SOMATXBOLETO = "Somatxboleto";

    private string _somatxboleto;

    private static readonly string RO_STATUS = "Status";

    private string _status;

    private static readonly string RO_TIPO = "Tipo";

    private string _tipo;

    private static readonly string RO_TIPOESTORNO = "Tipoestorno";

    private string _tipoestorno;

    private static readonly string RO_TIPOOPERACAOTEF = "Tipooperacaotef";

    private string _tipooperacaotef;

    private static readonly string RO_TIPOPORTADOR = "Tipoportador";

    private string _tipoportador;

    private static readonly string RO_TIPOPRORROG = "Tipoprorrog";

    private string _tipoprorrog;

    private static readonly string RO_TXPERM = "Txperm";

    private decimal? _txperm;

    private static readonly string RO_TXVENDORBCO = "Txvendorbco";

    private decimal? _txvendorbco;

    private static readonly string RO_TXVENDORCLI = "Txvendorcli";

    private decimal? _txvendorcli;

    private static readonly string RO_VALOR = "Valor";

    private decimal _valor;

    private static readonly string RO_VALORDESC = "Valordesc";

    private decimal? _valordesc;

    private static readonly string RO_VALORDESCORIG = "Valordescorig";

    private decimal? _valordescorig;

    private static readonly string RO_VALORESTORNO = "Valorestorno";

    private decimal? _valorestorno;

    private static readonly string RO_VALORLIQCOM = "Valorliqcom";

    private decimal? _valorliqcom;

    private static readonly string RO_VALORLIQCOMSUP = "Valorliqcomsup";

    private decimal? _valorliqcomsup;

    private static readonly string RO_VALORORIG = "Valororig";

    private decimal? _valororig;

    private static readonly string RO_VLCONTRATOVENDOR = "Vlcontratovendor";

    private decimal? _vlcontratovendor;

    private static readonly string RO_VLCUSTODOCVENDOR = "Vlcustodocvendor";

    private decimal? _vlcustodocvendor;

    private static readonly string RO_VLDEVOL = "Vldevol";

    private decimal? _vldevol;

    private static readonly string RO_VLRCOFINSORGPUB = "Vlrcofinsorgpub";

    private decimal? _vlrcofinsorgpub;

    private static readonly string RO_VLRCONTSOCIALORGPUB = "Vlrcontsocialorgpub";

    private decimal? _vlrcontsocialorgpub;

    private static readonly string RO_VLRDESPBANCARIAS = "Vlrdespbancarias";

    private decimal? _vlrdespbancarias;

    private static readonly string RO_VLRDESPCARTORAIS = "Vlrdespcartorais";

    private decimal? _vlrdespcartorais;

    private static readonly string RO_VLRICMSRETORGPUB = "Vlricmsretorgpub";

    private decimal? _vlricmsretorgpub;

    private static readonly string RO_VLRIMPRENDAORGPUB = "Vlrimprendaorgpub";

    private decimal? _vlrimprendaorgpub;

    private static readonly string RO_VLROUTRASDEDUCOESORGPUB = "Vlroutrasdeducoesorgpub";

    private decimal? _vlroutrasdeducoesorgpub;

    private static readonly string RO_VLROUTROSACRESC = "Vlroutrosacresc";

    private decimal? _vlroutrosacresc;

    private static readonly string RO_VLRPISORGPUB = "Vlrpisorgpub";

    private decimal? _vlrpisorgpub;

    private static readonly string RO_VLRTOTDESPESASEJUROS = "Vlrtotdespesasejuros";

    private decimal? _vlrtotdespesasejuros;

    private static readonly string RO_VLTXBOLETO = "Vltxboleto";

    private decimal? _vltxboleto;

    private static readonly string RO_VLTXIOF = "Vltxiof";

    private decimal? _vltxiof;

    private static readonly string RO_VLTXIOFCOMPLEMENTAR = "Vltxiofcomplementar";

    private decimal? _vltxiofcomplementar;

    private static readonly string RO_VLTXVENDOR = "Vltxvendor";

    private decimal? _vltxvendor;

    private static readonly string RO_VPAGO = "Vpago";

    private decimal? _vpago;

    private static readonly string RO_NUMCARTAOCRM = "Numcartaocrm";

    private string _numcartaocrm;

    private static readonly string RO_NUMFECHAMENTOMOVCX = "Numfechamentomovcx";

    private decimal? _numfechamentomovcx;

    private static readonly string RO_DTMOVIMENTOCX = "Dtmovimentocx";

    private DateTime? _dtmovimentocx;

    private static readonly string RO_CORRESPONDENTE = "Correspondente";

    private string _correspondente;

    private static readonly string RO_CNPJCREDENCCARTAO = "Cnpjcredenccartao";

    private string _cnpjcredenccartao;

    private string _codcobsefaz;

    private decimal? _bandeiracartao;

    private string _tipocorban;

    private string _processadortranspagdigital;

    private string _numtranspagdigital;

    private string _nsupagdigital;

    private string _carteiradigital;

    private string _nomecarteiradigital;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Agrupado
    {
        get
        {
            PropriedadeAcessada(RO_AGRUPADO);
            return _agrupado;
        }
        set
        {
            PropriedadeModificada(RO_AGRUPADO, value);
            _agrupado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Alinea
    {
        get
        {
            PropriedadeAcessada(RO_ALINEA);
            return _alinea;
        }
        set
        {
            PropriedadeModificada(RO_ALINEA, value);
            _alinea = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 25, Precisao = 0)]
    public string Arqretorno
    {
        get
        {
            PropriedadeAcessada(RO_ARQRETORNO);
            return _arqretorno;
        }
        set
        {
            PropriedadeModificada(RO_ARQRETORNO, value);
            _arqretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Baixaconciliada
    {
        get
        {
            PropriedadeAcessada(RO_BAIXACONCILIADA);
            return _baixaconciliada;
        }
        set
        {
            PropriedadeModificada(RO_BAIXACONCILIADA, value);
            _baixaconciliada = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Bloqdesdemitentedif
    {
        get
        {
            PropriedadeAcessada(RO_BLOQDESDEMITENTEDIF);
            return _bloqdesdemitentedif;
        }
        set
        {
            PropriedadeModificada(RO_BLOQDESDEMITENTEDIF, value);
            _bloqdesdemitentedif = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Cartorio
    {
        get
        {
            PropriedadeAcessada(RO_CARTORIO);
            return _cartorio;
        }
        set
        {
            PropriedadeModificada(RO_CARTORIO, value);
            _cartorio = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Chequeterceiro
    {
        get
        {
            PropriedadeAcessada(RO_CHEQUETERCEIRO);
            return _chequeterceiro;
        }
        set
        {
            PropriedadeModificada(RO_CHEQUETERCEIRO, value);
            _chequeterceiro = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 8, Precisao = 0)]
    public string Cnpjcisp
    {
        get
        {
            PropriedadeAcessada(RO_CNPJCISP);
            return _cnpjcisp;
        }
        set
        {
            PropriedadeModificada(RO_CNPJCISP, value);
            _cnpjcisp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codagentecobranca
    {
        get
        {
            PropriedadeAcessada(RO_CODAGENTECOBRANCA);
            return _codagentecobranca;
        }
        set
        {
            PropriedadeModificada(RO_CODAGENTECOBRANCA, value);
            _codagentecobranca = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 13, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codbaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODBAIXA);
            return _codbaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODBAIXA, value);
            _codbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codbancobaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOBAIXA);
            return _codbancobaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOBAIXA, value);
            _codbancobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocm
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOCM);
            return _codbancocm;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOCM, value);
            _codbancocm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocm2
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOCM2);
            return _codbancocm2;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOCM2, value);
            _codbancocm2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancocustodia
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOCUSTODIA);
            return _codbancocustodia;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOCUSTODIA, value);
            _codbancocustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbancovendor
    {
        get
        {
            PropriedadeAcessada(RO_CODBANCOVENDOR);
            return _codbancovendor;
        }
        set
        {
            PropriedadeModificada(RO_CODBANCOVENDOR, value);
            _codbancovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 5, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 44, Precisao = 0)]
    public string Codbarra2
    {
        get
        {
            PropriedadeAcessada(RO_CODBARRA2);
            return _codbarra2;
        }
        set
        {
            PropriedadeModificada(RO_CODBARRA2, value);
            _codbarra2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codbcocustodia
    {
        get
        {
            PropriedadeAcessada(RO_CODBCOCUSTODIA);
            return _codbcocustodia;
        }
        set
        {
            PropriedadeModificada(RO_CODBCOCUSTODIA, value);
            _codbcocustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Codbloco
    {
        get
        {
            PropriedadeAcessada(RO_CODBLOCO);
            return _codbloco;
        }
        set
        {
            PropriedadeModificada(RO_CODBLOCO, value);
            _codbloco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobbanco
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBBANCO);
            return _codcobbanco;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBBANCO, value);
            _codcobbanco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
    public string Codcobpos
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBPOS);
            return _codcobpos;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBPOS, value);
            _codcobpos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codcobrador
    {
        get
        {
            PropriedadeAcessada(RO_CODCOBRADOR);
            return _codcobrador;
        }
        set
        {
            PropriedadeModificada(RO_CODCOBRADOR, value);
            _codcobrador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codemitentepedido
    {
        get
        {
            PropriedadeAcessada(RO_CODEMITENTEPEDIDO);
            return _codemitentepedido;
        }
        set
        {
            PropriedadeModificada(RO_CODEMITENTEPEDIDO, value);
            _codemitentepedido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codepto
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 3, Precisao = 0)]
    public string Codestabelecimento
    {
        get
        {
            PropriedadeAcessada(RO_CODESTABELECIMENTO);
            return _codestabelecimento;
        }
        set
        {
            PropriedadeModificada(RO_CODESTABELECIMENTO, value);
            _codestabelecimento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncbordero
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCBORDERO);
            return _codfuncbordero;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCBORDERO, value);
            _codfuncbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccheckout
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconcil
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONCIL);
            return _codfuncconcil;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONCIL, value);
            _codfuncconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncconcilvenc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCONCILVENC);
            return _codfuncconcilvenc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCONCILVENC, value);
            _codfuncconcilvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfunccxmot
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCCXMOT);
            return _codfunccxmot;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCCXMOT, value);
            _codfunccxmot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncdesd
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCDESD);
            return _codfuncdesd;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCDESD, value);
            _codfuncdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncdesd1
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCDESD1);
            return _codfuncdesd1;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCDESD1, value);
            _codfuncdesd1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Codfuncdnicli
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCDNICLI);
            return _codfuncdnicli;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCDNICLI, value);
            _codfuncdnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncestorno
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCESTORNO);
            return _codfuncestorno;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCESTORNO, value);
            _codfuncestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncfecha
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCFECHA);
            return _codfuncfecha;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCFECHA, value);
            _codfuncfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncinc
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCINC);
            return _codfuncinc;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCINC, value);
            _codfuncinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncliberacaoentrega
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCLIBERACAOENTREGA);
            return _codfuncliberacaoentrega;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCLIBERACAOENTREGA, value);
            _codfuncliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncprorrog
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCPRORROG);
            return _codfuncprorrog;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCPRORROG, value);
            _codfuncprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncultalter
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCULTALTER);
            return _codfuncultalter;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCULTALTER, value);
            _codfuncultalter = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncvale
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCVALE);
            return _codfuncvale;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCVALE, value);
            _codfuncvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codfuncvend
    {
        get
        {
            PropriedadeAcessada(RO_CODFUNCVEND);
            return _codfuncvend;
        }
        set
        {
            PropriedadeModificada(RO_CODFUNCVEND, value);
            _codfuncvend = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codhistvale
    {
        get
        {
            PropriedadeAcessada(RO_CODHISTVALE);
            return _codhistvale;
        }
        set
        {
            PropriedadeModificada(RO_CODHISTVALE, value);
            _codhistvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codmotorista
    {
        get
        {
            PropriedadeAcessada(RO_CODMOTORISTA);
            return _codmotorista;
        }
        set
        {
            PropriedadeModificada(RO_CODMOTORISTA, value);
            _codmotorista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codocorrbaixa
    {
        get
        {
            PropriedadeAcessada(RO_CODOCORRBAIXA);
            return _codocorrbaixa;
        }
        set
        {
            PropriedadeModificada(RO_CODOCORRBAIXA, value);
            _codocorrbaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codportador
    {
        get
        {
            PropriedadeAcessada(RO_CODPORTADOR);
            return _codportador;
        }
        set
        {
            PropriedadeModificada(RO_CODPORTADOR, value);
            _codportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codprofissional
    {
        get
        {
            PropriedadeAcessada(RO_CODPROFISSIONAL);
            return _codprofissional;
        }
        set
        {
            PropriedadeModificada(RO_CODPROFISSIONAL, value);
            _codprofissional = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codstatuscob
    {
        get
        {
            PropriedadeAcessada(RO_CODSTATUSCOB);
            return _codstatuscob;
        }
        set
        {
            PropriedadeModificada(RO_CODSTATUSCOB, value);
            _codstatuscob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusurant
    {
        get
        {
            PropriedadeAcessada(RO_CODUSURANT);
            return _codusurant;
        }
        set
        {
            PropriedadeModificada(RO_CODUSURANT, value);
            _codusurant = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Codusurpgcomissao
    {
        get
        {
            PropriedadeAcessada(RO_CODUSURPGCOMISSAO);
            return _codusurpgcomissao;
        }
        set
        {
            PropriedadeModificada(RO_CODUSURPGCOMISSAO, value);
            _codusurpgcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codusur3
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR3);
            return _codusur3;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR3, value);
            _codusur3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Codusur4
    {
        get
        {
            PropriedadeAcessada(RO_CODUSUR4);
            return _codusur4;
        }
        set
        {
            PropriedadeModificada(RO_CODUSUR4, value);
            _codusur4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Contratovendor
    {
        get
        {
            PropriedadeAcessada(RO_CONTRATOVENDOR);
            return _contratovendor;
        }
        set
        {
            PropriedadeModificada(RO_CONTRATOVENDOR, value);
            _contratovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Dadosecf
    {
        get
        {
            PropriedadeAcessada(RO_DADOSECF);
            return _dadosecf;
        }
        set
        {
            PropriedadeModificada(RO_DADOSECF, value);
            _dadosecf = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Datahoraminutobaixa
    {
        get
        {
            PropriedadeAcessada(RO_DATAHORAMINUTOBAIXA);
            return _datahoraminutobaixa;
        }
        set
        {
            PropriedadeModificada(RO_DATAHORAMINUTOBAIXA, value);
            _datahoraminutobaixa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Digitao
    {
        get
        {
            PropriedadeAcessada(RO_DIGITAO);
            return _digitao;
        }
        set
        {
            PropriedadeModificada(RO_DIGITAO, value);
            _digitao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtaberturaconta
    {
        get
        {
            PropriedadeAcessada(RO_DTABERTURACONTA);
            return _dtaberturaconta;
        }
        set
        {
            PropriedadeModificada(RO_DTABERTURACONTA, value);
            _dtaberturaconta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtassociadnicli
    {
        get
        {
            PropriedadeAcessada(RO_DTASSOCIADNICLI);
            return _dtassociadnicli;
        }
        set
        {
            PropriedadeModificada(RO_DTASSOCIADNICLI, value);
            _dtassociadnicli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0, TruncarData = true)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbaixacred
    {
        get
        {
            PropriedadeAcessada(RO_DTBAIXACRED);
            return _dtbaixacred;
        }
        set
        {
            PropriedadeModificada(RO_DTBAIXACRED, value);
            _dtbaixacred = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtborder
    {
        get
        {
            PropriedadeAcessada(RO_DTBORDER);
            return _dtborder;
        }
        set
        {
            PropriedadeModificada(RO_DTBORDER, value);
            _dtborder = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtbordero
    {
        get
        {
            PropriedadeAcessada(RO_DTBORDERO);
            return _dtbordero;
        }
        set
        {
            PropriedadeModificada(RO_DTBORDERO, value);
            _dtbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcancel
    {
        get
        {
            PropriedadeAcessada(RO_DTCANCEL);
            return _dtcancel;
        }
        set
        {
            PropriedadeModificada(RO_DTCANCEL, value);
            _dtcancel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcil
    {
        get
        {
            PropriedadeAcessada(RO_DTCONCIL);
            return _dtconcil;
        }
        set
        {
            PropriedadeModificada(RO_DTCONCIL, value);
            _dtconcil = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtconcilvenc
    {
        get
        {
            PropriedadeAcessada(RO_DTCONCILVENC);
            return _dtconcilvenc;
        }
        set
        {
            PropriedadeModificada(RO_DTCONCILVENC, value);
            _dtconcilvenc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcriacao
    {
        get
        {
            PropriedadeAcessada(RO_DTCRIACAO);
            return _dtcriacao;
        }
        set
        {
            PropriedadeModificada(RO_DTCRIACAO, value);
            _dtcriacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcustodia
    {
        get
        {
            PropriedadeAcessada(RO_DTCUSTODIA);
            return _dtcustodia;
        }
        set
        {
            PropriedadeModificada(RO_DTCUSTODIA, value);
            _dtcustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0, TruncarData = true)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtcxmothhmmss
    {
        get
        {
            PropriedadeAcessada(RO_DTCXMOTHHMMSS);
            return _dtcxmothhmmss;
        }
        set
        {
            PropriedadeModificada(RO_DTCXMOTHHMMSS, value);
            _dtcxmothhmmss = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdefagente
    {
        get
        {
            PropriedadeAcessada(RO_DTDEFAGENTE);
            return _dtdefagente;
        }
        set
        {
            PropriedadeModificada(RO_DTDEFAGENTE, value);
            _dtdefagente = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesc
    {
        get
        {
            PropriedadeAcessada(RO_DTDESC);
            return _dtdesc;
        }
        set
        {
            PropriedadeModificada(RO_DTDESC, value);
            _dtdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdescontado
    {
        get
        {
            PropriedadeAcessada(RO_DTDESCONTADO);
            return _dtdescontado;
        }
        set
        {
            PropriedadeModificada(RO_DTDESCONTADO, value);
            _dtdescontado = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdescontotitbco
    {
        get
        {
            PropriedadeAcessada(RO_DTDESCONTOTITBCO);
            return _dtdescontotitbco;
        }
        set
        {
            PropriedadeModificada(RO_DTDESCONTOTITBCO, value);
            _dtdescontotitbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdesd
    {
        get
        {
            PropriedadeAcessada(RO_DTDESD);
            return _dtdesd;
        }
        set
        {
            PropriedadeModificada(RO_DTDESD, value);
            _dtdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtdevol
    {
        get
        {
            PropriedadeAcessada(RO_DTDEVOL);
            return _dtdevol;
        }
        set
        {
            PropriedadeModificada(RO_DTDEVOL, value);
            _dtdevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtenvioserasa
    {
        get
        {
            PropriedadeAcessada(RO_DTENVIOSERASA);
            return _dtenvioserasa;
        }
        set
        {
            PropriedadeModificada(RO_DTENVIOSERASA, value);
            _dtenvioserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtestorno
    {
        get
        {
            PropriedadeAcessada(RO_DTESTORNO);
            return _dtestorno;
        }
        set
        {
            PropriedadeModificada(RO_DTESTORNO, value);
            _dtestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtexportacaoservint
    {
        get
        {
            PropriedadeAcessada(RO_DTEXPORTACAOSERVINT);
            return _dtexportacaoservint;
        }
        set
        {
            PropriedadeModificada(RO_DTEXPORTACAOSERVINT, value);
            _dtexportacaoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfecha
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHA);
            return _dtfecha;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHA, value);
            _dtfecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfechavendor
    {
        get
        {
            PropriedadeAcessada(RO_DTFECHAVENDOR);
            return _dtfechavendor;
        }
        set
        {
            PropriedadeModificada(RO_DTFECHAVENDOR, value);
            _dtfechavendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportacaoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTACAOSERVPRINC);
            return _dtimportacaoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTACAOSERVPRINC, value);
            _dtimportacaoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinclusao
    {
        get
        {
            PropriedadeAcessada(RO_DTINCLUSAO);
            return _dtinclusao;
        }
        set
        {
            PropriedadeModificada(RO_DTINCLUSAO, value);
            _dtinclusao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinclusaomanual
    {
        get
        {
            PropriedadeAcessada(RO_DTINCLUSAOMANUAL);
            return _dtinclusaomanual;
        }
        set
        {
            PropriedadeModificada(RO_DTINCLUSAOMANUAL, value);
            _dtinclusaomanual = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancch
    {
        get
        {
            PropriedadeAcessada(RO_DTLANCCH);
            return _dtlancch;
        }
        set
        {
            PropriedadeModificada(RO_DTLANCCH, value);
            _dtlancch = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtlancprorrog
    {
        get
        {
            PropriedadeAcessada(RO_DTLANCPRORROG);
            return _dtlancprorrog;
        }
        set
        {
            PropriedadeModificada(RO_DTLANCPRORROG, value);
            _dtlancprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaoentrega
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERACAOENTREGA);
            return _dtliberacaoentrega;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERACAOENTREGA, value);
            _dtliberacaoentrega = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtliberacaofechamento
    {
        get
        {
            PropriedadeAcessada(RO_DTLIBERACAOFECHAMENTO);
            return _dtliberacaofechamento;
        }
        set
        {
            PropriedadeModificada(RO_DTLIBERACAOFECHAMENTO, value);
            _dtliberacaofechamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0, TruncarData = true)]
    public DateTime? Dtpag
    {
        get
        {
            PropriedadeAcessada(RO_DTPAG);
            return _dtpag;
        }
        set
        {
            PropriedadeModificada(RO_DTPAG, value);
            _dtpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAO);
            return _dtpagcomissao;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAO, value);
            _dtpagcomissao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissaoprof
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAOPROF);
            return _dtpagcomissaoprof;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAOPROF, value);
            _dtpagcomissaoprof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao2
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAO2);
            return _dtpagcomissao2;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAO2, value);
            _dtpagcomissao2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao3
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAO3);
            return _dtpagcomissao3;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAO3, value);
            _dtpagcomissao3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtpagcomissao4
    {
        get
        {
            PropriedadeAcessada(RO_DTPAGCOMISSAO4);
            return _dtpagcomissao4;
        }
        set
        {
            PropriedadeModificada(RO_DTPAGCOMISSAO4, value);
            _dtpagcomissao4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtprocessamento
    {
        get
        {
            PropriedadeAcessada(RO_DTPROCESSAMENTO);
            return _dtprocessamento;
        }
        set
        {
            PropriedadeModificada(RO_DTPROCESSAMENTO, value);
            _dtprocessamento = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtregcarteira
    {
        get
        {
            PropriedadeAcessada(RO_DTREGCARTEIRA);
            return _dtregcarteira;
        }
        set
        {
            PropriedadeModificada(RO_DTREGCARTEIRA, value);
            _dtregcarteira = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtremvendor
    {
        get
        {
            PropriedadeAcessada(RO_DTREMVENDOR);
            return _dtremvendor;
        }
        set
        {
            PropriedadeModificada(RO_DTREMVENDOR, value);
            _dtremvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtretiradaserasa
    {
        get
        {
            PropriedadeAcessada(RO_DTRETIRADASERASA);
            return _dtretiradaserasa;
        }
        set
        {
            PropriedadeModificada(RO_DTRETIRADASERASA, value);
            _dtretiradaserasa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtsaida
    {
        get
        {
            PropriedadeAcessada(RO_DTSAIDA);
            return _dtsaida;
        }
        set
        {
            PropriedadeModificada(RO_DTSAIDA, value);
            _dtsaida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultestorno
    {
        get
        {
            PropriedadeAcessada(RO_DTULTESTORNO);
            return _dtultestorno;
        }
        set
        {
            PropriedadeModificada(RO_DTULTESTORNO, value);
            _dtultestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencanterior
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCANTERIOR);
            return _dtvencanterior;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCANTERIOR, value);
            _dtvencanterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvencvale
    {
        get
        {
            PropriedadeAcessada(RO_DTVENCVALE);
            return _dtvencvale;
        }
        set
        {
            PropriedadeModificada(RO_DTVENCVALE, value);
            _dtvencvale = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvendor
    {
        get
        {
            PropriedadeAcessada(RO_DTVENDOR);
            return _dtvendor;
        }
        set
        {
            PropriedadeModificada(RO_DTVENDOR, value);
            _dtvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
    public decimal? Dvcob
    {
        get
        {
            PropriedadeAcessada(RO_DVCOB);
            return _dvcob;
        }
        set
        {
            PropriedadeModificada(RO_DVCOB, value);
            _dvcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Enviadoqis
    {
        get
        {
            PropriedadeAcessada(RO_ENVIADOQIS);
            return _enviadoqis;
        }
        set
        {
            PropriedadeModificada(RO_ENVIADOQIS, value);
            _enviadoqis = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 64, Precisao = 0)]
    public string Equiplanc
    {
        get
        {
            PropriedadeAcessada(RO_EQUIPLANC);
            return _equiplanc;
        }
        set
        {
            PropriedadeModificada(RO_EQUIPLANC, value);
            _equiplanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Exportadoservint
    {
        get
        {
            PropriedadeAcessada(RO_EXPORTADOSERVINT);
            return _exportadoservint;
        }
        set
        {
            PropriedadeModificada(RO_EXPORTADOSERVINT, value);
            _exportadoservint = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Funclanc
    {
        get
        {
            PropriedadeAcessada(RO_FUNCLANC);
            return _funclanc;
        }
        set
        {
            PropriedadeModificada(RO_FUNCLANC, value);
            _funclanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Geracaorazaoauxiliar
    {
        get
        {
            PropriedadeAcessada(RO_GERACAORAZAOAUXILIAR);
            return _geracaorazaoauxiliar;
        }
        set
        {
            PropriedadeModificada(RO_GERACAORAZAOAUXILIAR, value);
            _geracaorazaoauxiliar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Hobpercommot
    {
        get
        {
            PropriedadeAcessada(RO_HOBPERCOMMOT);
            return _hobpercommot;
        }
        set
        {
            PropriedadeModificada(RO_HOBPERCOMMOT, value);
            _hobpercommot = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Hobpercomsup
    {
        get
        {
            PropriedadeAcessada(RO_HOBPERCOMSUP);
            return _hobpercomsup;
        }
        set
        {
            PropriedadeModificada(RO_HOBPERCOMSUP, value);
            _hobpercomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horadesd
    {
        get
        {
            PropriedadeAcessada(RO_HORADESD);
            return _horadesd;
        }
        set
        {
            PropriedadeModificada(RO_HORADESD, value);
            _horadesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horaestorno
    {
        get
        {
            PropriedadeAcessada(RO_HORAESTORNO);
            return _horaestorno;
        }
        set
        {
            PropriedadeModificada(RO_HORAESTORNO, value);
            _horaestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Horafecha
    {
        get
        {
            PropriedadeAcessada(RO_HORAFECHA);
            return _horafecha;
        }
        set
        {
            PropriedadeModificada(RO_HORAFECHA, value);
            _horafecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Idcob
    {
        get
        {
            PropriedadeAcessada(RO_IDCOB);
            return _idcob;
        }
        set
        {
            PropriedadeModificada(RO_IDCOB, value);
            _idcob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Idtitulo
    {
        get
        {
            PropriedadeAcessada(RO_IDTITULO);
            return _idtitulo;
        }
        set
        {
            PropriedadeModificada(RO_IDTITULO, value);
            _idtitulo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Importadoservprinc
    {
        get
        {
            PropriedadeAcessada(RO_IMPORTADOSERVPRINC);
            return _importadoservprinc;
        }
        set
        {
            PropriedadeModificada(RO_IMPORTADOSERVPRINC, value);
            _importadoservprinc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 65, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 65, Precisao = 0)]
    public string Linhadig2
    {
        get
        {
            PropriedadeAcessada(RO_LINHADIG2);
            return _linhadig2;
        }
        set
        {
            PropriedadeModificada(RO_LINHADIG2, value);
            _linhadig2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutodesd
    {
        get
        {
            PropriedadeAcessada(RO_MINUTODESD);
            return _minutodesd;
        }
        set
        {
            PropriedadeModificada(RO_MINUTODESD, value);
            _minutodesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutoestorno
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOESTORNO);
            return _minutoestorno;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOESTORNO, value);
            _minutoestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
    public decimal? Minutofecha
    {
        get
        {
            PropriedadeAcessada(RO_MINUTOFECHA);
            return _minutofecha;
        }
        set
        {
            PropriedadeModificada(RO_MINUTOFECHA, value);
            _minutofecha = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Nomearquivo
    {
        get
        {
            PropriedadeAcessada(RO_NOMEARQUIVO);
            return _nomearquivo;
        }
        set
        {
            PropriedadeModificada(RO_NOMEARQUIVO, value);
            _nomearquivo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Nossonumbco
    {
        get
        {
            PropriedadeAcessada(RO_NOSSONUMBCO);
            return _nossonumbco;
        }
        set
        {
            PropriedadeModificada(RO_NOSSONUMBCO, value);
            _nossonumbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Nossonumbco2
    {
        get
        {
            PropriedadeAcessada(RO_NOSSONUMBCO2);
            return _nossonumbco2;
        }
        set
        {
            PropriedadeModificada(RO_NOSSONUMBCO2, value);
            _nossonumbco2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numassocdni
    {
        get
        {
            PropriedadeAcessada(RO_NUMASSOCDNI);
            return _numassocdni;
        }
        set
        {
            PropriedadeModificada(RO_NUMASSOCDNI, value);
            _numassocdni = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numbordero
    {
        get
        {
            PropriedadeAcessada(RO_NUMBORDERO);
            return _numbordero;
        }
        set
        {
            PropriedadeModificada(RO_NUMBORDERO, value);
            _numbordero = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcaranterior
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARANTERIOR);
            return _numcaranterior;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARANTERIOR, value);
            _numcaranterior = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 30, Precisao = 0)]
    public string Numcartao
    {
        get
        {
            PropriedadeAcessada(RO_NUMCARTAO);
            return _numcartao;
        }
        set
        {
            PropriedadeModificada(RO_NUMCARTAO, value);
            _numcartao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numcheckout
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numcustodia
    {
        get
        {
            PropriedadeAcessada(RO_NUMCUSTODIA);
            return _numcustodia;
        }
        set
        {
            PropriedadeModificada(RO_NUMCUSTODIA, value);
            _numcustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiascarencia
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASCARENCIA);
            return _numdiascarencia;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASCARENCIA, value);
            _numdiascarencia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Numdiasprazoprotesto
    {
        get
        {
            PropriedadeAcessada(RO_NUMDIASPRAZOPROTESTO);
            return _numdiasprazoprotesto;
        }
        set
        {
            PropriedadeModificada(RO_NUMDIASPRAZOPROTESTO, value);
            _numdiasprazoprotesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 40, Precisao = 0)]
    public string Numlotecartaotef
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTECARTAOTEF);
            return _numlotecartaotef;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTECARTAOTEF, value);
            _numlotecartaotef = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numlotecustodia
    {
        get
        {
            PropriedadeAcessada(RO_NUMLOTECUSTODIA);
            return _numlotecustodia;
        }
        set
        {
            PropriedadeModificada(RO_NUMLOTECUSTODIA, value);
            _numlotecustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numnegociacao
    {
        get
        {
            PropriedadeAcessada(RO_NUMNEGOCIACAO);
            return _numnegociacao;
        }
        set
        {
            PropriedadeModificada(RO_NUMNEGOCIACAO, value);
            _numnegociacao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numrecibo
    {
        get
        {
            PropriedadeAcessada(RO_NUMRECIBO);
            return _numrecibo;
        }
        set
        {
            PropriedadeModificada(RO_NUMRECIBO, value);
            _numrecibo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 7, Precisao = 0)]
    public decimal? Numremessa
    {
        get
        {
            PropriedadeAcessada(RO_NUMREMESSA);
            return _numremessa;
        }
        set
        {
            PropriedadeModificada(RO_NUMREMESSA, value);
            _numremessa = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Numseqretorno
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQRETORNO);
            return _numseqretorno;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQRETORNO, value);
            _numseqretorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numtrans
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANS);
            return _numtrans;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANS, value);
            _numtrans = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransent
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENT);
            return _numtransent;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENT, value);
            _numtransent = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransentdevcli
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSENTDEVCLI);
            return _numtransentdevcli;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSENTDEVCLI, value);
            _numtransentdevcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal Numtransvenda
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
    public decimal? Numtransvendast
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDAST);
            return _numtransvendast;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDAST, value);
            _numtransvendast = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Numtransvendor
    {
        get
        {
            PropriedadeAcessada(RO_NUMTRANSVENDOR);
            return _numtransvendor;
        }
        set
        {
            PropriedadeModificada(RO_NUMTRANSVENDOR, value);
            _numtransvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
    public string Obscustodia
    {
        get
        {
            PropriedadeAcessada(RO_OBSCUSTODIA);
            return _obscustodia;
        }
        set
        {
            PropriedadeModificada(RO_OBSCUSTODIA, value);
            _obscustodia = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 200, Precisao = 0)]
    public string Obsfinanc
    {
        get
        {
            PropriedadeAcessada(RO_OBSFINANC);
            return _obsfinanc;
        }
        set
        {
            PropriedadeModificada(RO_OBSFINANC, value);
            _obsfinanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
    public string Origemboleto
    {
        get
        {
            PropriedadeAcessada(RO_ORIGEMBOLETO);
            return _origemboleto;
        }
        set
        {
            PropriedadeModificada(RO_ORIGEMBOLETO, value);
            _origemboleto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 4)]
    public decimal? Percomsup
    {
        get
        {
            PropriedadeAcessada(RO_PERCOMSUP);
            return _percomsup;
        }
        set
        {
            PropriedadeModificada(RO_PERCOMSUP, value);
            _percomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom2
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM2);
            return _percom2;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM2, value);
            _percom2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom3
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM3);
            return _percom3;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM3, value);
            _percom3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 5)]
    public decimal? Percom4
    {
        get
        {
            PropriedadeAcessada(RO_PERCOM4);
            return _percom4;
        }
        set
        {
            PropriedadeModificada(RO_PERCOM4, value);
            _percom4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Perdesc
    {
        get
        {
            PropriedadeAcessada(RO_PERDESC);
            return _perdesc;
        }
        set
        {
            PropriedadeModificada(RO_PERDESC, value);
            _perdesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Permiteestorno
    {
        get
        {
            PropriedadeAcessada(RO_PERMITEESTORNO);
            return _permiteestorno;
        }
        set
        {
            PropriedadeModificada(RO_PERMITEESTORNO, value);
            _permiteestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Protesto
    {
        get
        {
            PropriedadeAcessada(RO_PROTESTO);
            return _protesto;
        }
        set
        {
            PropriedadeModificada(RO_PROTESTO, value);
            _protesto = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
    public decimal? Qtparcelaspos
    {
        get
        {
            PropriedadeAcessada(RO_QTPARCELASPOS);
            return _qtparcelaspos;
        }
        set
        {
            PropriedadeModificada(RO_QTPARCELASPOS, value);
            _qtparcelaspos = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Responsavelpag
    {
        get
        {
            PropriedadeAcessada(RO_RESPONSAVELPAG);
            return _responsavelpag;
        }
        set
        {
            PropriedadeModificada(RO_RESPONSAVELPAG, value);
            _responsavelpag = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rotdesd
    {
        get
        {
            PropriedadeAcessada(RO_ROTDESD);
            return _rotdesd;
        }
        set
        {
            PropriedadeModificada(RO_ROTDESD, value);
            _rotdesd = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Rotinalanc
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANC);
            return _rotinalanc;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANC, value);
            _rotinalanc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 48, Precisao = 0)]
    public string Rotinalancultalt
    {
        get
        {
            PropriedadeAcessada(RO_ROTINALANCULTALT);
            return _rotinalancultalt;
        }
        set
        {
            PropriedadeModificada(RO_ROTINALANCULTALT, value);
            _rotinalancultalt = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipo
    {
        get
        {
            PropriedadeAcessada(RO_TIPO);
            return _tipo;
        }
        set
        {
            PropriedadeModificada(RO_TIPO, value);
            _tipo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoestorno
    {
        get
        {
            PropriedadeAcessada(RO_TIPOESTORNO);
            return _tipoestorno;
        }
        set
        {
            PropriedadeModificada(RO_TIPOESTORNO, value);
            _tipoestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoportador
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPORTADOR);
            return _tipoportador;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPORTADOR, value);
            _tipoportador = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tipoprorrog
    {
        get
        {
            PropriedadeAcessada(RO_TIPOPRORROG);
            return _tipoprorrog;
        }
        set
        {
            PropriedadeModificada(RO_TIPOPRORROG, value);
            _tipoprorrog = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Txperm
    {
        get
        {
            PropriedadeAcessada(RO_TXPERM);
            return _txperm;
        }
        set
        {
            PropriedadeModificada(RO_TXPERM, value);
            _txperm = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Txvendorbco
    {
        get
        {
            PropriedadeAcessada(RO_TXVENDORBCO);
            return _txvendorbco;
        }
        set
        {
            PropriedadeModificada(RO_TXVENDORBCO, value);
            _txvendorbco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Txvendorcli
    {
        get
        {
            PropriedadeAcessada(RO_TXVENDORCLI);
            return _txvendorcli;
        }
        set
        {
            PropriedadeModificada(RO_TXVENDORCLI, value);
            _txvendorcli = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valordesc
    {
        get
        {
            PropriedadeAcessada(RO_VALORDESC);
            return _valordesc;
        }
        set
        {
            PropriedadeModificada(RO_VALORDESC, value);
            _valordesc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Valordescorig
    {
        get
        {
            PropriedadeAcessada(RO_VALORDESCORIG);
            return _valordescorig;
        }
        set
        {
            PropriedadeModificada(RO_VALORDESCORIG, value);
            _valordescorig = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorestorno
    {
        get
        {
            PropriedadeAcessada(RO_VALORESTORNO);
            return _valorestorno;
        }
        set
        {
            PropriedadeModificada(RO_VALORESTORNO, value);
            _valorestorno = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Valorliqcom
    {
        get
        {
            PropriedadeAcessada(RO_VALORLIQCOM);
            return _valorliqcom;
        }
        set
        {
            PropriedadeModificada(RO_VALORLIQCOM, value);
            _valorliqcom = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Valorliqcomsup
    {
        get
        {
            PropriedadeAcessada(RO_VALORLIQCOMSUP);
            return _valorliqcomsup;
        }
        set
        {
            PropriedadeModificada(RO_VALORLIQCOMSUP, value);
            _valorliqcomsup = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcontratovendor
    {
        get
        {
            PropriedadeAcessada(RO_VLCONTRATOVENDOR);
            return _vlcontratovendor;
        }
        set
        {
            PropriedadeModificada(RO_VLCONTRATOVENDOR, value);
            _vlcontratovendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vlcustodocvendor
    {
        get
        {
            PropriedadeAcessada(RO_VLCUSTODOCVENDOR);
            return _vlcustodocvendor;
        }
        set
        {
            PropriedadeModificada(RO_VLCUSTODOCVENDOR, value);
            _vlcustodocvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vldevol
    {
        get
        {
            PropriedadeAcessada(RO_VLDEVOL);
            return _vldevol;
        }
        set
        {
            PropriedadeModificada(RO_VLDEVOL, value);
            _vldevol = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrcofinsorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLRCOFINSORGPUB);
            return _vlrcofinsorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLRCOFINSORGPUB, value);
            _vlrcofinsorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrcontsocialorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLRCONTSOCIALORGPUB);
            return _vlrcontsocialorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLRCONTSOCIALORGPUB, value);
            _vlrcontsocialorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrdespbancarias
    {
        get
        {
            PropriedadeAcessada(RO_VLRDESPBANCARIAS);
            return _vlrdespbancarias;
        }
        set
        {
            PropriedadeModificada(RO_VLRDESPBANCARIAS, value);
            _vlrdespbancarias = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrdespcartorais
    {
        get
        {
            PropriedadeAcessada(RO_VLRDESPCARTORAIS);
            return _vlrdespcartorais;
        }
        set
        {
            PropriedadeModificada(RO_VLRDESPCARTORAIS, value);
            _vlrdespcartorais = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlricmsretorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLRICMSRETORGPUB);
            return _vlricmsretorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLRICMSRETORGPUB, value);
            _vlricmsretorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrimprendaorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLRIMPRENDAORGPUB);
            return _vlrimprendaorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLRIMPRENDAORGPUB, value);
            _vlrimprendaorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlroutrasdeducoesorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLROUTRASDEDUCOESORGPUB);
            return _vlroutrasdeducoesorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLROUTRASDEDUCOESORGPUB, value);
            _vlroutrasdeducoesorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlroutrosacresc
    {
        get
        {
            PropriedadeAcessada(RO_VLROUTROSACRESC);
            return _vlroutrosacresc;
        }
        set
        {
            PropriedadeModificada(RO_VLROUTROSACRESC, value);
            _vlroutrosacresc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrpisorgpub
    {
        get
        {
            PropriedadeAcessada(RO_VLRPISORGPUB);
            return _vlrpisorgpub;
        }
        set
        {
            PropriedadeModificada(RO_VLRPISORGPUB, value);
            _vlrpisorgpub = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 2)]
    public decimal? Vlrtotdespesasejuros
    {
        get
        {
            PropriedadeAcessada(RO_VLRTOTDESPESASEJUROS);
            return _vlrtotdespesasejuros;
        }
        set
        {
            PropriedadeModificada(RO_VLRTOTDESPESASEJUROS, value);
            _vlrtotdespesasejuros = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 2)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vltxiof
    {
        get
        {
            PropriedadeAcessada(RO_VLTXIOF);
            return _vltxiof;
        }
        set
        {
            PropriedadeModificada(RO_VLTXIOF, value);
            _vltxiof = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 4)]
    public decimal? Vltxiofcomplementar
    {
        get
        {
            PropriedadeAcessada(RO_VLTXIOFCOMPLEMENTAR);
            return _vltxiofcomplementar;
        }
        set
        {
            PropriedadeModificada(RO_VLTXIOFCOMPLEMENTAR, value);
            _vltxiofcomplementar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 14, Precisao = 6)]
    public decimal? Vltxvendor
    {
        get
        {
            PropriedadeAcessada(RO_VLTXVENDOR);
            return _vltxvendor;
        }
        set
        {
            PropriedadeModificada(RO_VLTXVENDOR, value);
            _vltxvendor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Vpago
    {
        get
        {
            PropriedadeAcessada(RO_VPAGO);
            return _vpago;
        }
        set
        {
            PropriedadeModificada(RO_VPAGO, value);
            _vpago = value;
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 2, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPRESTECF", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 18, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 3, Precisao = 0)]
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

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCPREST", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 4, Precisao = 0)]
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
        return "PCPREST";
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
        _bloqdesdemitentedif = AlterarTipo<string>(leitor["Bloqdesdemitentedif"]);
        _boleto = AlterarTipo<string>(leitor["Boleto"]);
        _cartorio = AlterarTipo<string>(leitor["Cartorio"]);
        _cgccpfch = AlterarTipo<string>(leitor["Cgccpfch"]);
        _chequeterceiro = AlterarTipo<string>(leitor["Chequeterceiro"]);
        _cnpjcisp = AlterarTipo<string>(leitor["Cnpjcisp"]);
        _codadmcartao = AlterarTipo<string>(leitor["Codadmcartao"]);
        _codagentecobranca = AlterarTipo<decimal?>(leitor["Codagentecobranca"]);
        _codautorizacaotef = AlterarTipo<decimal?>(leitor["Codautorizacaotef"]);
        _codbaixa = AlterarTipo<decimal?>(leitor["Codbaixa"]);
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
        _codcob = AlterarTipo<string>(leitor["Codcob"]);
        _codcobbanco = AlterarTipo<string>(leitor["Codcobbanco"]);
        _codcoborig = AlterarTipo<string>(leitor["Codcoborig"]);
        _codcobpos = AlterarTipo<string>(leitor["Codcobpos"]);
        _codcobrador = AlterarTipo<decimal?>(leitor["Codcobrador"]);
        _codemitentepedido = AlterarTipo<decimal?>(leitor["Codemitentepedido"]);
        _codepto = AlterarTipo<decimal?>(leitor["Codepto"]);
        _codestabelecimento = AlterarTipo<string>(leitor["Codestabelecimento"]);
        _codfilial = AlterarTipo<string>(leitor["Codfilial"]);
        _codfilialnf = AlterarTipo<string>(leitor["Codfilialnf"]);
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
        _codusurant = AlterarTipo<decimal?>(leitor["Codusurant"]);
        _codusurpgcomissao = AlterarTipo<decimal?>(leitor["Codusurpgcomissao"]);
        _codusur2 = AlterarTipo<decimal?>(leitor["Codusur2"]);
        _codusur3 = AlterarTipo<decimal?>(leitor["Codusur3"]);
        _codusur4 = AlterarTipo<decimal?>(leitor["Codusur4"]);
        _compensacaobco = AlterarTipo<decimal?>(leitor["Compensacaobco"]);
        _contratovendor = AlterarTipo<decimal?>(leitor["Contratovendor"]);
        _dadosecf = AlterarTipo<string>(leitor["Dadosecf"]);
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
        _dtinclusao = AlterarTipo<DateTime?>(leitor["Dtinclusao"]);
        _dtinclusaomanual = AlterarTipo<DateTime?>(leitor["Dtinclusaomanual"]);
        _dtlancch = AlterarTipo<DateTime?>(leitor["Dtlancch"]);
        _dtlancprorrog = AlterarTipo<DateTime?>(leitor["Dtlancprorrog"]);
        _dtliberacaoentrega = AlterarTipo<DateTime?>(leitor["Dtliberacaoentrega"]);
        _dtliberacaofechamento = AlterarTipo<DateTime?>(leitor["Dtliberacaofechamento"]);
        _dtpag = AlterarTipo<DateTime?>(leitor["Dtpag"]);
        _dtpagcomissao = AlterarTipo<DateTime?>(leitor["Dtpagcomissao"]);
        _dtpagcomissaoprof = AlterarTipo<DateTime?>(leitor["Dtpagcomissaoprof"]);
        _dtpagcomissao2 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao2"]);
        _dtpagcomissao3 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao3"]);
        _dtpagcomissao4 = AlterarTipo<DateTime?>(leitor["Dtpagcomissao4"]);
        _dtprocessamento = AlterarTipo<DateTime?>(leitor["Dtprocessamento"]);
        _dtregcarteira = AlterarTipo<DateTime?>(leitor["Dtregcarteira"]);
        _dtremvendor = AlterarTipo<DateTime?>(leitor["Dtremvendor"]);
        _dtretiradaserasa = AlterarTipo<DateTime?>(leitor["Dtretiradaserasa"]);
        _dtsaida = AlterarTipo<DateTime?>(leitor["Dtsaida"]);
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
        _funclanc = AlterarTipo<string>(leitor["Funclanc"]);
        _geracaorazaoauxiliar = AlterarTipo<string>(leitor["Geracaorazaoauxiliar"]);
        _hobpercommot = AlterarTipo<decimal?>(leitor["Hobpercommot"]);
        _hobpercomsup = AlterarTipo<decimal?>(leitor["Hobpercomsup"]);
        _horadesd = AlterarTipo<decimal?>(leitor["Horadesd"]);
        _horaestorno = AlterarTipo<decimal?>(leitor["Horaestorno"]);
        _horafecha = AlterarTipo<decimal?>(leitor["Horafecha"]);
        _idcob = AlterarTipo<decimal?>(leitor["Idcob"]);
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
        _nsutef = AlterarTipo<string>(leitor["Nsutef"]);
        _nsuhost = AlterarTipo<string>(leitor["Nsuhost"]);
        _numagencia = AlterarTipo<decimal?>(leitor["Numagencia"]);
        _numassocdni = AlterarTipo<decimal?>(leitor["Numassocdni"]);
        _numbanco = AlterarTipo<decimal?>(leitor["Numbanco"]);
        _numbordero = AlterarTipo<decimal?>(leitor["Numbordero"]);
        _numcaixafiscal = AlterarTipo<decimal?>(leitor["Numcaixafiscal"]);
        _hubnumcaixapadrao = AlterarTipo<decimal?>(leitor["Hubnumcaixapadrao"]);
        _numcar = AlterarTipo<decimal?>(leitor["Numcar"]);
        _numcaranterior = AlterarTipo<decimal?>(leitor["Numcaranterior"]);
        _numcartao = AlterarTipo<string>(leitor["Numcartao"]);
        _numcheckout = AlterarTipo<decimal?>(leitor["Numcheckout"]);
        _numcheque = AlterarTipo<decimal?>(leitor["Numcheque"]);
        _numcontacorrente = AlterarTipo<decimal?>(leitor["Numcontacorrente"]);
        _numcustodia = AlterarTipo<decimal?>(leitor["Numcustodia"]);
        _numdiascarencia = AlterarTipo<decimal?>(leitor["Numdiascarencia"]);
        _numdiasprazoprotesto = AlterarTipo<decimal?>(leitor["Numdiasprazoprotesto"]);
        _numecf = AlterarTipo<decimal?>(leitor["Numecf"]);
        _numlotecartaotef = AlterarTipo<string>(leitor["Numlotecartaotef"]);
        _numlotecustodia = AlterarTipo<decimal?>(leitor["Numlotecustodia"]);
        _numnegociacao = AlterarTipo<decimal?>(leitor["Numnegociacao"]);
        _numped = AlterarTipo<decimal?>(leitor["Numped"]);
        _numrecibo = AlterarTipo<decimal?>(leitor["Numrecibo"]);
        _numremessa = AlterarTipo<decimal?>(leitor["Numremessa"]);
        _numseqretorno = AlterarTipo<decimal?>(leitor["Numseqretorno"]);
        _numtrans = AlterarTipo<decimal?>(leitor["Numtrans"]);
        _numtransent = AlterarTipo<decimal?>(leitor["Numtransent"]);
        _numtransentdevcli = AlterarTipo<decimal?>(leitor["Numtransentdevcli"]);
        _numtransvenda = AlterarTipo<decimal>(leitor["Numtransvenda"]);
        _numtransvendast = AlterarTipo<decimal?>(leitor["Numtransvendast"]);
        _numtransvendor = AlterarTipo<decimal?>(leitor["Numtransvendor"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _obscustodia = AlterarTipo<string>(leitor["Obscustodia"]);
        _obsfinanc = AlterarTipo<string>(leitor["Obsfinanc"]);
        _obs2 = AlterarTipo<string>(leitor["Obs2"]);
        _operacao = AlterarTipo<string>(leitor["Operacao"]);
        _origemboleto = AlterarTipo<string>(leitor["Origemboleto"]);
        _parcelamentotef = AlterarTipo<string>(leitor["Parcelamentotef"]);
        _percom = AlterarTipo<decimal?>(leitor["Percom"]);
        _percomsup = AlterarTipo<decimal?>(leitor["Percomsup"]);
        _percom2 = AlterarTipo<decimal?>(leitor["Percom2"]);
        _percom3 = AlterarTipo<decimal?>(leitor["Percom3"]);
        _percom4 = AlterarTipo<decimal?>(leitor["Percom4"]);
        _perdesc = AlterarTipo<decimal?>(leitor["Perdesc"]);
        _permiteestorno = AlterarTipo<string>(leitor["Permiteestorno"]);
        _prest = AlterarTipo<string>(leitor["Prest"]);
        _presttef = AlterarTipo<decimal?>(leitor["Presttef"]);
        _protesto = AlterarTipo<string>(leitor["Protesto"]);
        _qtparcelaspos = AlterarTipo<decimal?>(leitor["Qtparcelaspos"]);
        _responsavelpag = AlterarTipo<string>(leitor["Responsavelpag"]);
        _rotdesd = AlterarTipo<decimal?>(leitor["Rotdesd"]);
        _rotinalanc = AlterarTipo<decimal?>(leitor["Rotinalanc"]);
        _rotinalancultalt = AlterarTipo<string>(leitor["Rotinalancultalt"]);
        _somatxboleto = AlterarTipo<string>(leitor["Somatxboleto"]);
        _status = AlterarTipo<string>(leitor["Status"]);
        _tipo = AlterarTipo<string>(leitor["Tipo"]);
        _tipoestorno = AlterarTipo<string>(leitor["Tipoestorno"]);
        _tipooperacaotef = AlterarTipo<string>(leitor["Tipooperacaotef"]);
        _tipoportador = AlterarTipo<string>(leitor["Tipoportador"]);
        _tipoprorrog = AlterarTipo<string>(leitor["Tipoprorrog"]);
        _txperm = AlterarTipo<decimal?>(leitor["Txperm"]);
        _txvendorbco = AlterarTipo<decimal?>(leitor["Txvendorbco"]);
        _txvendorcli = AlterarTipo<decimal?>(leitor["Txvendorcli"]);
        _valor = AlterarTipo<decimal>(leitor["Valor"]);
        _valordesc = AlterarTipo<decimal?>(leitor["Valordesc"]);
        _valordescorig = AlterarTipo<decimal?>(leitor["Valordescorig"]);
        _valorestorno = AlterarTipo<decimal?>(leitor["Valorestorno"]);
        _valorliqcom = AlterarTipo<decimal?>(leitor["Valorliqcom"]);
        _valorliqcomsup = AlterarTipo<decimal?>(leitor["Valorliqcomsup"]);
        _valororig = AlterarTipo<decimal?>(leitor["Valororig"]);
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
        _vltxboleto = AlterarTipo<decimal?>(leitor["Vltxboleto"]);
        _vltxiof = AlterarTipo<decimal?>(leitor["Vltxiof"]);
        _vltxiofcomplementar = AlterarTipo<decimal?>(leitor["Vltxiofcomplementar"]);
        _vltxvendor = AlterarTipo<decimal?>(leitor["Vltxvendor"]);
        _vpago = AlterarTipo<decimal?>(leitor["Vpago"]);
        _numcartaocrm = AlterarTipo<string>(leitor["Numcartaocrm"]);
        _numfechamentomovcx = AlterarTipo<decimal?>(leitor["Numfechamentomovcx"]);
        _dtmovimentocx = AlterarTipo<DateTime?>(leitor["Dtmovimentocx"]);
        _codcobsefaz = AlterarTipo<string>(leitor["Codcobsefaz"]);
        _bandeiracartao = AlterarTipo<decimal?>(leitor["Bandeiracartao"]);
        _tipocorban = AlterarTipo<string>(leitor["Tipocorban"]);
        _processadortranspagdigital = AlterarTipo<string>(leitor["Processadortranspagdigital"]);
        _numtranspagdigital = AlterarTipo<string>(leitor["Numtranspagdigital"]);
        _nsupagdigital = AlterarTipo<string>(leitor["Nsupagdigital"]);
        _carteiradigital = AlterarTipo<string>(leitor["Carteiradigital"]);
        _nomecarteiradigital = AlterarTipo<string>(leitor["Nomecarteiradigital"]);
    }

}