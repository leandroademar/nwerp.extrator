namespace nwErp.Api.Entidades;

[Serializable]
public class Monitor
{  
        public string Projeto { get; set; }

        public DateTime DataHora { get; set; }

        public object Retorno { get; set; }

        public string Descricao { get; set; }

        public string MensagemDeErro { get; set; }    
}