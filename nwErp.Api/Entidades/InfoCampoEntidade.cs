////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class InfoCampoEntidade : Attribute
{
	public bool ChavePrimaria { get; set; }

	public string Tabela { get; set; }

	public TipoDoCampoNoBancoDeDados Tipo { get; set; }

	public int Tamanho { get; set; }

	public int Precisao { get; set; }

	public bool TruncarData { get; set; }
}
