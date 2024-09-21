

////namespace nwErp.Entidades;

public class InformacoesDePropriedade
{
	public string Nome { get; set; }

	public object ValorOriginal { get; set; }

	public object NovoValor { get; set; }

	public PropertyInfo Propriedade { get; set; }

	public bool Modificada => NovoValor != ValorOriginal;

	public InformacoesDePropriedade(PropertyInfo propriedade)
	{
		Propriedade = propriedade;
		Nome = propriedade.Name;
	}
}
