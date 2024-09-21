////namespace nwErp.Entidades;

public static class Propagador
{
	private static Dictionary<Assembly, Type[]> _entidades = new Dictionary<Assembly, Type[]>();

	public static Type[] ObterEntidades(Assembly asm)
	{
		if (!_entidades.Keys.Contains(asm))
		{
			List<Type> list = new List<Type>();
			Type[] types = asm.GetTypes();
			foreach (Type type in types)
			{
				if (type.GetInterface("IEntidade", ignoreCase: true) != null)
				{
					list.Add(type);
				}
			}
			_entidades.Add(asm, list.OrderBy((Type tip) => tip.Name).ToArray());
		}
		return _entidades[asm];
	}
}
