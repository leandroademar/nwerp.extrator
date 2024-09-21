namespace nwErp.Api.Modelos
{
    public class TerrazzoCliente
    {
        public decimal Codigomogo { get; set; }
        public string Descricaomogo { get; set; }
        public decimal Codigowinthor { get; set; }
        public string NrInscr { get; set; }
        public string Endereco { get; set; }
        public string Uf { get; set; }
        public string Codigomunicipio { get; set; }
    }

    public class TerrazzoXml
    {
        public decimal Idxml { get; set; }
        public decimal Idnotafiscal { get; set; }
        public decimal Tipoxml { get; set; }
        public string Localxml { get; set; }
        public DateTime Datahoraleitura { get; set; }
        public string ImportadoNormal { get; set; }
        public string ImportadoCancel { get; set; }
        public string ErroXml { get; set; }
        public string ErroMogo { get; set; }
        public string ErroWinthor { get; set; }
    }

    public class TerrazzoControleCaixa
    {
        public int Id { get; set; }
        public int CodFuncionarioAbertura { get; set; }
        public int CodFuncionarioFechamento { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public String NomeFuncionario { get; set; }
    }

    public class TerrazzoPagamento
    {
        public int IdPag { get; set; }
        public int IdCr { get; set; }
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public DateTime Emissao { get; set; }
        public decimal Valor { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? ValorCover { get; set; }
        public string TipoTitulo { get; set; }
        public string Bandeira { get; set; }
        public string Nsu { get; set; }
        public string Pedido { get; set; }
        public string ControleCaixa { get; set; }
        public string Funcionario { get; set; }
        public string NotaFiscal { get; set; }
        public string CODCOB { get; set; }
        public string COBSEFAZ { get; set; }
        public string CODADMCARTAO { get; set; }
        public string TIPOOPERACAOTEF { get; set; }
        public string CODBANDEIRATEF { get; set; }
        public DateTime Dtvenc { get; set; }
        public int Dias { get; set; }


        //CODCOB,COBSEFAZ,CODADMCARTAO,TIPOOPERACAOTEF,CODBANDEIRATEF

    }
    public class TerrazzoNotasPorDia
    {
        public int QtNotasFaltantes { get; set; }
        public int QtNotasExportadas { get; set; }
        public DateTime DataEmissao { get; set; }
    }
    public class TerrazzoNotaFiscal
    {
        public int Id { get; set; }
        public string StatusNf { get; set; }
        public int NumeroNf { get; set; }
        public string SerieNf { get; set; }
        public int ModNfe { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal Valor { get; set; }
        public string Chave { get; set; }
        public string Protocolo { get; set; }
        public string ChavePagamento { get; set; }
        public decimal CodCliente { get; set; }
        public int QtdItens { get; set; }
        public int CodFuncionarioEmitente { get; set; }
        public decimal Matricula { get; set; }
    }
    public class NotaFiscalMogo
    {
        public int IdUsuario { get; set; }
        public string Usuarioemitente { get; set; }
        public string Tipoxmlnf { get; set; }
        public int IdXml { get; set; }
        public int CodNotaFiscal { get; set; }
        public int matricula { get; set; }
        public decimal precocusto { get; set; }
        public int statusintegracao { get; set; }

    }

    public class TotalVendaFunc
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int ModeloNfe { get; set; }
        public double VlrTotal { get; set; }
        public int CodFuncionarioEmitente { get; set; }

    }

}
