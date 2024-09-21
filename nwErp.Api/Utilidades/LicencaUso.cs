using System.Runtime.InteropServices;
using System.Text;

//namespace nwErp.Utilidades;

public class LicencaUso
{
	public string NomeLoja { get; set; }

	public string NomeEmpresa { get; set; }

	public string NomeCliente { get; set; }

	public int CodigoCliente { get; set; }

	public int QuantidadeLicencas { get; set; }

	public DateTime DataExpiracao { get; set; }

	public string SenhaBD { get; set; }

	[DllImport("PCINF000Crypt.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private static extern void PCDecryptDES(IntPtr codificado, IntPtr keyCript, StringBuilder retornoDecodificado);

	[DllImport("PCINF000Crypt.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private static extern void DecodificarSenha(IntPtr nomeBancoDados, IntPtr nomeUsuarioBD, IntPtr senhaBDCripto, StringBuilder senhaBDDecripto);

	private static string GerarKeyDESAntigo()
	{
		return "P#?xc@?Sy-##???Sx?@&";
	}

	private static string GerarKeyDESNovo()
	{
		return "Z?mjg@?GJ&75lg#@#x!3w1\\@@##";
	}

	private static string DecodificarChave(string chaveCripto, bool novo)
	{
		StringBuilder stringBuilder = new StringBuilder(200);
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(chaveCripto);
		IntPtr intPtr2 = Marshal.StringToHGlobalAnsi(novo ? GerarKeyDESNovo() : GerarKeyDESAntigo());
		PCDecryptDES(intPtr, intPtr2, stringBuilder);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		return stringBuilder.ToString();
	}

	public LicencaUso()
	{
	}

	public static string DecriptoSenha(string bancoDados, string usuarioBD, string senhaCripto)
	{
		StringBuilder stringBuilder = new StringBuilder(2000);
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(bancoDados);
		IntPtr intPtr2 = Marshal.StringToHGlobalAnsi(usuarioBD);
		IntPtr intPtr3 = Marshal.StringToHGlobalAnsi(senhaCripto);
		DecodificarSenha(intPtr, intPtr2, intPtr3, stringBuilder);
		Marshal.FreeHGlobal(intPtr);
		Marshal.FreeHGlobal(intPtr2);
		Marshal.FreeHGlobal(intPtr3);
		return stringBuilder.ToString();
	}

	private static string DecodificarSenha(string nomeBancoDados, string nomeUsuarioBD, string senhaBDCripto)
	{
		return DecriptoSenha(nomeBancoDados, nomeUsuarioBD, senhaBDCripto);
	}

	public string DecodificarSenhaNovoFormato(string numeroRotina, string senhaBDCripto)
	{
		return DecriptoSenha(DateTime.Now.Date.ToString().Replace("00:00:00", "").Trim(), numeroRotina, senhaBDCripto.Replace("[", "").Replace("]", ""));
	}

	public LicencaUso(string loja, string empresa, string chaveCriptografada, string senhaBDCripto)
	{
		NomeLoja = loja;
		NomeEmpresa = empresa;
		SenhaBD = DecodificarSenha(NomeLoja, NomeEmpresa, senhaBDCripto);
		string[] array = DecodificarChave(chaveCriptografada, novo: false).Split(';');
		if (array.Length < 4)
		{
			array = DecodificarChave(chaveCriptografada, novo: true).Split(';');
			if (array.Length < 4)
			{
				throw new Exception("Licença inválida. A licença codificada contém menos de 4 trechos.");
			}
			PreencherDados(array);
		}
		else
		{
			PreencherDados(array);
		}
	}

	private void PreencherDados(string[] trechos)
	{
		NomeCliente = trechos[0];
		CodigoCliente = int.Parse(trechos[1]);
		QuantidadeLicencas = int.Parse(trechos[2]);
		string[] array = trechos[3].Split('/');
		DataExpiracao = new DateTime(int.Parse(array[2]), int.Parse(array[1]), int.Parse(array[0]));
	}
}
