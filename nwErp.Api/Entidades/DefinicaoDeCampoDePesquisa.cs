////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Property)]
public class DefinicaoDeCampoDePesquisa : Attribute
{
	private MascaraDeEdicaoEnumerador _tipoDeMascara;

	public bool ExibirComoFiltro { get; set; }

	public bool ExibirNoResultado { get; set; }

	public bool FiltroPadrao { get; set; }

	public bool CampoDescritivoDoResultado { get; set; }

	public string Descricao { get; set; }

	public string Mascara { get; set; }

	public MascaraDeEdicaoEnumerador TipoDeMascara
	{
		get
		{
			return _tipoDeMascara;
		}
		set
		{
			_tipoDeMascara = value;
			Mascara = _tipoDeMascara.ObterDescricao();
		}
	}
}
