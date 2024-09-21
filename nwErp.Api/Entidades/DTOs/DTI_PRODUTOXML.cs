namespace ExportadorNFCe.Modelos
{
    public class DTI_PRODUTOXML
    {
        public int IdXml { get; set; }
        public int IdNotaFiscal { get; set; }
        public int MyProperty { get; set; }
        public int TipoXMLNF { get; set; }
        public string cProd { get; set; }
        public string xProd { get; set; }
        public string CFOP { get; set; }
        public string NCM { get; set; }
        public decimal qCom { get; set; }
        public decimal qTrib { get; set; }
        public decimal vUnTrib { get; set; }
        public decimal vProd { get; set; }
        public double Exportado { get; set; }
        public double Integrado { get; set; }

        // IdXML	IdNotaFiscal	TipoXMLNF	cProd	xProd	CFOP	NCM	qCom	qTrib	vUnTrib	vProd	Exportado	Integrado
    }
}
