////namespace nwErp.Entidades;

[AttributeUsage(AttributeTargets.Property)]
public class PersistirEmCascata : Attribute
{
	private TipoDePersistenciaColetivaPermitida _tiposPermitidos;

	private TipoDePersistenciaEmCascata _tipo;

	public TipoDePersistenciaColetivaPermitida TiposPermitidos => _tiposPermitidos;

	public TipoDePersistenciaEmCascata Tipo => _tipo;

	public PersistirEmCascata(TipoDePersistenciaEmCascata tipo, TipoDePersistenciaColetivaPermitida tiposPermitidos)
	{
		_tipo = tipo;
		_tiposPermitidos = tiposPermitidos;
	}
}
