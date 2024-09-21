//namespace nwErp.Utilidades;

public static class Extensoes
{
	public static int ConverteStringParaInt32(this string valor)
	{
		try
		{
			return Convert.ToInt32(valor);
		}
		catch
		{
			return 0;
		}
	}

	public static int ConverteDecimalParaInt32(this decimal valor)
	{
		try
		{
			return Convert.ToInt32(valor);
		}
		catch
		{
			return 0;
		}
	}

	public static int ConverteDecimalParaInt16(this decimal valor)
	{
		try
		{
			return Convert.ToInt16(valor);
		}
		catch
		{
			return 0;
		}
	}

	public static int ConverteDecimalParaInt32(this decimal? valor)
	{
		try
		{
			return Convert.ToInt32(valor);
		}
		catch
		{
			return 0;
		}
	}

	public static int ConverteDecimalParaInt16(this decimal? valor)
	{
		try
		{
			return Convert.ToInt16(valor);
		}
		catch
		{
			return 0;
		}
	}

	public static DateTime ConverteStringParaDateTime(this string valor)
	{
		try
		{
			return Convert.ToDateTime(valor);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static decimal ConverteStringParaDecimal(this string valor)
	{
		try
		{
			return Convert.ToDecimal(valor);
		}
		catch
		{
			return 0m;
		}
	}

	public static decimal ConverteStringParaDecimal(this string valor, bool trocarVirgulaPorPonto)
	{
		try
		{
			if (trocarVirgulaPorPonto)
			{
				valor = default(Utilidades).TrocarVirgulaPorPonto(valor);
			}
			return Convert.ToDecimal(valor);
		}
		catch
		{
			return 0m;
		}
	}

	public static string ValorPadrao(this string valor, string padrao)
	{
		if (!string.IsNullOrEmpty(valor))
		{
			return valor;
		}
		return padrao;
	}

	public static string Inverte(this string valor)
	{
		try
		{
			char[] array = new char[valor.Length];
			for (int i = 0; i < valor.Length; i++)
			{
				array[i] = valor[valor.Length - 1 - i];
			}
			return new string(array);
		}
		catch
		{
			return "";
		}
	}

	public static string Left(this string valor, int tamanho)
	{
		return valor.Substring(0, tamanho);
	}

	public static string Right(this string valor, int tamanho)
	{
		return valor.Substring(valor.Length - tamanho, tamanho);
	}
}
