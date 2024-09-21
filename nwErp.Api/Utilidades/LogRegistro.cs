//namespace nwErp.Utilidades;

public class LogRegistro
{
	public DateTime DataEHora { get; set; }

	public string Conteudo { get; set; }

	public LogRegistro(DateTime dataEHora, string conteudo)
	{
		DataEHora = dataEHora;
		Conteudo = conteudo;
	}

	public string ObterLinha()
	{
		return string.Format("{0} #> {1}", DataEHora.ToString("dd/MM/yyyy HH:mm:ss:fff"), Conteudo);
	}
}
