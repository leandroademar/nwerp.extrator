namespace nwErp.Api.Definicoes;

public class DadosConexao
{
    public string Tipo { get; set; }

    public string IdCliente { get; set; }

    public string Ambiente { get; set; }

    public long IdAmbiente { get; set; }

    public string Cliente { get; set; }

    public long Versao { get; set; }

    public string CodigoUsuario { get; set; }

    public string Usuario { get; set; }

    public string Request { get; set; }

    public string VersaoApp { get; set; }

    public string NomeApp { get; set; }

    public string Mensagem { get; set; }

    public object[] Parametros { get; set; }

    public Exception Excecao { get; set; }
}
