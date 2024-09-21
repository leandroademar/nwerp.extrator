using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nwErp.Api.Modelos
{
    public class PedidoMatriz
    {
        public int CODFILIAL { get; set; }
        public long NUMPED { get; set; }
        public int CODUSUR { get; set; }
        public int CODCLI { get; set; }
        public DateTime DATA { get; set; }
        public int QTPED { get; set; }
        public string DIVIDPED { get; set; }
        public int CODCLI_TRIB { get; set; }
        public int CODCLI_ST { get; set; }
        
    }
}