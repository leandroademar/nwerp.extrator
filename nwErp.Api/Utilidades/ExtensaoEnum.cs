using System.ComponentModel;

//namespace nwErp.Utilidades;

public static class ExtensaoEnum
{
	public static string ObterDescricao(this Enum enumerador)
	{
		FieldInfo field = enumerador.GetType().GetField(enumerador.ToString());
		if (field != null && field.IsDefined(typeof(DescriptionAttribute), inherit: true))
		{
			return ((DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: true)[0]).Description;
		}
		return enumerador.ToString();
	}
}
