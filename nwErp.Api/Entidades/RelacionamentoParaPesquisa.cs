////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Property)]
public class RelacionamentoParaPesquisa : Attribute
{
	private PropertyInfo _propriedade;

	public Type TipoParaPesquisa { get; set; }

	public PropertyInfo Propriedade => _propriedade;

	public RelacionamentoParaPesquisa()
	{
	}

	public RelacionamentoParaPesquisa(Type tipoParaPesquisa, string nomeDaPropriedade)
	{
		TipoParaPesquisa = tipoParaPesquisa;
		_propriedade = TipoParaPesquisa.GetProperty(nomeDaPropriedade);
	}
}
