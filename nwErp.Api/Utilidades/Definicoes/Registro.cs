namespace nwErp.Api.Definicoes
{
    public static class Serializador
    {
        private static readonly object LockObj = new object();

        public static void SerializarParaArquivo<T>(T objeto, string caminhoArquivo)
        {
            lock (LockObj)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, objeto);
                }
            }
        }

        public static T DeserializarDeArquivo<T>(string caminhoArquivo)
        {
            lock (LockObj)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
        }
    }

    public class Registro
    {
        private static Registro instance;
        private static readonly object LockObj = new object();
        public BancoDeDados BancoDeDados { get; set; }

        private Registro()
        {
            BancoDeDados = new BancoDeDados
            {
                Servidor = Environment.GetEnvironmentVariable("DB_SERVER") ?? string.Empty,
                Usuario = Environment.GetEnvironmentVariable("DB_USER") ?? string.Empty,
                Endereco = Environment.GetEnvironmentVariable("DB_ADDRESS") ?? string.Empty,
                NomeDoServico = Environment.GetEnvironmentVariable("DB_SERVICE_NAME") ?? string.Empty,
                StringDeConexao = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? string.Empty,
                Senha = Environment.GetEnvironmentVariable("DB_PSW") ?? string.Empty,
                DefinicaoSimples = false,
                Porta = Environment.GetEnvironmentVariable("DB_PORT") ?? "1521",
                TipoServico = Environment.GetEnvironmentVariable("DB_SERVICE_TYPE") ?? "SID"
            };

            SalvarConfiguracoes();
        }

        public static Registro CarregarConfiguracoes()
        {
            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string configFilePath = Path.Combine(directoryName, "Configuracao.xml");

            if (File.Exists(configFilePath))
            {
                return Serializador.DeserializarDeArquivo<Registro>(configFilePath);
            }

            return new Registro();
        }

        public void SalvarConfiguracoes()
        {
            string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directoryName != null)
            {
                string configFilePath = Path.Combine(directoryName, "Configuracao.xml");

                try
                {
                    Serializador.SerializarParaArquivo(this, configFilePath);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Falha ao salvar arquivo de configuração no diretório {directoryName}", ex);
                }
            }
        }

        public static Registro GetInstance()
        {
            if (instance == null)
            {
                lock (LockObj)
                {
                    if (instance == null)
                    {
                        instance = CarregarConfiguracoes();
                    }
                }
            }
            return instance;
        }
    }
}