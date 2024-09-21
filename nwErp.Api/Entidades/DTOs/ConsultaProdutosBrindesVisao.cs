public class ConsultaProdutosBrindesVisao : IVisao
    {
        [InfoCampoVisao]
        public int Codprod { get; set; }
        
        [InfoCampoVisao]
        public string Descricao { get; set; }
        
        [InfoCampoVisao]
        public string Unidade { get; set; }
        
        [InfoCampoVisao]
        public int Codepto { get; set; }
        
        [InfoCampoVisao]
        public int Codsec { get; set; }
        
        [InfoCampoVisao]
        public decimal Estoque { get; set; }    
        
        [InfoCampoVisao]
        public decimal PVenda { get; set; }

        [InfoCampoVisao]
        public string StatusRest { get; set; }

        public IVisao NovaInstancia()
        {
		    return (IVisao)GetType().GetConstructors()[0].Invoke(null);
        }

        public string SQLConsulta()
        {
            return " SELECT * FROM (SELECT PP.CODPROD,PP.DESCRICAO,PP.UNIDADE,PP.CODEPTO,PP.CODSEC,PE.QTESTGER ESTOQUE, PT.PVENDA1 PVENDA,PP.TLSTATUS_REST STATUSREST  FROM   TIOLUIZ.PCPRODUT PP,  TIOLUIZ.PCEST PE,  TIOLUIZ.PCTABPR PT WHERE  PP.CODPROD = PE.CODPROD AND PE.CODPROD = PT.CODPROD AND PE.CODFILIAL = '2' AND PT.NUMREGIAO = 1 AND PE.QTESTGER > 0 AND PT.PVENDA > 0 AND EXISTS(SELECT 1 FROM ROTINA587 WHERE ROTINA587.CODSEC = PP.CODSEC AND ROTINA587.CODEPTO = PP.CODEPTO )) WHERE 1 = 1 ";
        }
    }