﻿namespace ExportadorNFCe.XMLNFe
{

    [XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NFeProc
    {
        [XmlAttribute("versao")]
        public string versao { get; set; }

        [XmlElement("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public NFe NotaFiscalEletronica { get; set; }

        [XmlElement("protNFe")]
        public ProtNFe infProt { get; set; }
        
    }
}
