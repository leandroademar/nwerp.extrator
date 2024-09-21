//namespace nwErp.Utilidades;

public class Colecao<T> : List<T>
{
	public delegate bool AlteracaoItem(T item);

	public event AlteracaoItem AntesRemover;

	public event AlteracaoItem AposRemover;

	public event AlteracaoItem AntesIncluir;

	public event AlteracaoItem AposIncluir;

	private bool ExecutarAlteracaoItem(T item, AlteracaoItem metodo, bool resultadoPadrao)
	{
		return metodo?.Invoke(item) ?? resultadoPadrao;
	}

	public new bool Add(T item)
	{
		bool num = ExecutarAlteracaoItem(item, this.AntesIncluir, resultadoPadrao: true);
		if (num)
		{
			base.Add(item);
			ExecutarAlteracaoItem(item, this.AposIncluir, resultadoPadrao: true);
		}
		return num;
	}

	public bool ValidarAlteracao(T item)
	{
		bool num = ExecutarAlteracaoItem(item, this.AntesIncluir, resultadoPadrao: true);
		if (num)
		{
			ExecutarAlteracaoItem(item, this.AposIncluir, resultadoPadrao: true);
		}
		return num;
	}

	public new bool Remove(T item)
	{
		if (ExecutarAlteracaoItem(item, this.AntesRemover, resultadoPadrao: true))
		{
			ExecutarAlteracaoItem(item, this.AposRemover, resultadoPadrao: true);
			return base.Remove(item);
		}
		return false;
	}
}
