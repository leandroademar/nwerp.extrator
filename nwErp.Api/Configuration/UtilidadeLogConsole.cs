namespace nwErp.Api.Configuration;

 public class UtilidadeLogConsole
    {
        public static void LogConsole(
            string message,
            string componente,
            UtilidadeLogConsole.TipoMensagem tipo = UtilidadeLogConsole.TipoMensagem.Default)
        {
            try
            {
                string str = string.Format("{0:dd/MM/yyyy HH:mm:ss.fff} - [{1}] - {2}", (object) DateTime.Now, (object) componente, (object) message);
                UtilidadeLogConsole.CorConsole(tipo);
                Console.WriteLine(str);
                Console.ResetColor();
                if (tipo != UtilidadeLogConsole.TipoMensagem.Erro)
                    return;
                
            }
            catch
            {
            }
        }

        private static void CorConsole(UtilidadeLogConsole.TipoMensagem tipo)
        {
            switch (tipo)
            {
                case UtilidadeLogConsole.TipoMensagem.Atencao:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case UtilidadeLogConsole.TipoMensagem.Sucesso:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case UtilidadeLogConsole.TipoMensagem.Erro:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case UtilidadeLogConsole.TipoMensagem.Default:
                    Console.ResetColor();
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
        }

        private static TipoLog ObterTipoLog(UtilidadeLogConsole.TipoMensagem tipo)
        {
            switch (tipo)
            {
                case UtilidadeLogConsole.TipoMensagem.Atencao:
                    return (TipoLog) 0;
                case UtilidadeLogConsole.TipoMensagem.Sucesso:
                    return (TipoLog) 1;
                case UtilidadeLogConsole.TipoMensagem.Erro:
                    return (TipoLog) 2;
                case UtilidadeLogConsole.TipoMensagem.Default:
                    return (TipoLog) 3;
                default:
                    return (TipoLog) 3;
            }
        }

        public enum TipoMensagem
        {
            Atencao,
            Sucesso,
            Erro,
            Default,
        }
        
        public enum TipoLog
        {
            Atencao,
            Sucesso,
            Erro,
            Informativo,
        }
    }