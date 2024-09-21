using System.Runtime.InteropServices;
using System.Text;

//namespace nwErp.Utilidades;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct Utilidades
{
	public string TrocarVirgulaPorPonto(string valor)
	{
		return valor.Replace(",", "V").Replace(".", "P").Replace("V", ".")
			.Replace("P", ",");
	}

	public string Decriptografa64(string cChaveCripto)
	{
		byte[] bytes = Convert.FromBase64String(cChaveCripto);
		return Encoding.ASCII.GetString(bytes);
	}
}
