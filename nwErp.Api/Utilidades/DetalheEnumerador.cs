//namespace nwErp.Utilidades;

public class DetalheEnumerador<T>
{
	private Enum _tipo;

	public byte Codigo => Convert.ToByte(_tipo);

	public string Descricao => _tipo.ObterDescricao();

	public T Tipo => (T)Convert.ChangeType(_tipo, typeof(T));

	public DetalheEnumerador()
	{
	}

	public DetalheEnumerador(Enum tipo)
	{
		_tipo = tipo;
	}

	public override string ToString()
	{
		return Descricao;
	}
}
