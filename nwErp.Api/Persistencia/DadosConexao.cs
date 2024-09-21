namespace nwErp.Api.Persistencia
{
    public class DadosDaConexaoMS
    {
        public static String servidorMS = "192.168.201.101";
        public static String bancoMS = "terrazzo";
        public static String bancoDT = "datitech";
        public static String usuarioMS = "sa";
        public static String senhaMS = "256318";


        public static String StringDeConexao
        {
            
            get
            {
                return @"Data Source=" + servidorMS + ";Initial Catalog=" + bancoMS + ";User ID=" + usuarioMS + ";Password=" + senhaMS;
            }
        }

        public static String StringDeConexaoDT
        {

            get
            {
                return @"Data Source=" + servidorMS + ";Initial Catalog=" + bancoDT + ";User ID=" + usuarioMS + ";Password=" + senhaMS;
            }
        }
    }
}
