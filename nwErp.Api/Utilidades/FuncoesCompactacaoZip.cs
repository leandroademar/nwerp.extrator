using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

//namespace nwErp.Utilidades;

public static class FuncoesCompactacaoZip
{
	public static string Compactar(string arquivo)
	{
		string text = Path.Combine(Path.GetDirectoryName(arquivo), Path.GetFileName(Path.ChangeExtension(arquivo, ".zip")));
		Compactar(text, new string[1] { arquivo });
		return text;
	}

	public static void Compactar(string arquivoCompactado, string arquivo)
	{
		Compactar(arquivoCompactado, new string[1] { arquivo });
	}

	public static void Compactar(string arquivoCompactado, string[] arquivos)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		FileStream fileStream = File.Create(arquivoCompactado);
		ZipOutputStream val = new ZipOutputStream((Stream)fileStream);
		try
		{
			foreach (string obj in arquivos)
			{
				FileInfo fileInfo = new FileInfo(obj);
				ZipEntry val2 = new ZipEntry(Path.GetFileName(obj));
				val2.DateTime = fileInfo.LastWriteTime;
				val2.Size = fileInfo.Length;
				val.PutNextEntry(val2);
				FileStream fileStream2 = File.OpenRead(obj);
				byte[] array = new byte[1024];
				int num = 0;
				while ((num = fileStream2.Read(array, 0, array.Length)) > 0)
				{
					((Stream)(object)val).Write(array, 0, num);
				}
			}
			((DeflaterOutputStream)val).Finish();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static bool Descompactar(string nomeDoArquivo, out string[] arquivos)
	{
		return Descompactar(nomeDoArquivo, out arquivos, 0, Overload: true);
	}

	private static bool Descompactar(string nomeDoArquivo, out string[] arquivos, int quantidadeTentativa, bool Overload)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		arquivos = null;
		try
		{
			List<string> list = new List<string>();
			FileStream fileStream = File.OpenRead(nomeDoArquivo);
			ZipFile val = null;
			try
			{
				val = new ZipFile(fileStream);
				string text = "";
				byte[] array = new byte[4096];
				foreach (ZipEntry item in val)
				{
					ZipEntry val2 = item;
					if (val2.IsFile)
					{
						string name = val2.Name;
						text = Path.Combine(Path.GetDirectoryName(nomeDoArquivo), name);
						string directoryName = Path.GetDirectoryName(text);
						if (directoryName.Length > 0 && !Directory.Exists(directoryName))
						{
							Directory.CreateDirectory(directoryName);
						}
						Stream inputStream = val.GetInputStream(val2);
						using (FileStream fileStream2 = File.Create(text))
						{
							StreamUtils.Copy(inputStream, (Stream)fileStream2, array);
						}
						list.Add(text);
					}
				}
				arquivos = list.ToArray();
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao Extrair o arquivo: {ex.Message}");
			}
			finally
			{
				if (val != null)
				{
					val.IsStreamOwner = true;
					val.Close();
				}
				fileStream.Close();
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static bool Descompactar(string nomeDoArquivo, out string[] arquivos, int quantidadeTentativa)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		arquivos = null;
		try
		{
			if (File.Exists(nomeDoArquivo))
			{
				string directoryName = Path.GetDirectoryName(nomeDoArquivo);
				FileStream fileStream = FuncoesDeArquivo.AbrirParaLeitura(nomeDoArquivo);
				ZipInputStream val = new ZipInputStream((Stream)fileStream);
				try
				{
					List<string> list = new List<string>();
					ZipEntry nextEntry;
					while ((nextEntry = val.GetNextEntry()) != null)
					{
						Path.GetFileName(nextEntry.Name);
						if (!nextEntry.IsFile || !(nextEntry.Name != ""))
						{
							continue;
						}
						string text = Path.Combine(directoryName, nextEntry.Name);
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						using (FileStream fileStream2 = File.Create(text))
						{
							int num = 2048;
							byte[] array = new byte[2048];
							while (true)
							{
								num = ((Stream)(object)val).Read(array, 0, array.Length);
								if (num <= 0)
								{
									break;
								}
								fileStream2.Write(array, 0, num);
							}
							fileStream2.Close();
						}
						list.Add(text);
					}
					((Stream)(object)val).Close();
					arquivos = list.ToArray();
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				fileStream.Close();
			}
		}
		catch (IOException ex)
		{
			if (quantidadeTentativa < 10)
			{
				Thread.Sleep(300);
				return Descompactar(nomeDoArquivo, out arquivos, ++quantidadeTentativa);
			}
			throw ex;
		}
		catch (Exception)
		{
			arquivos = null;
		}
		if (arquivos != null)
		{
			return arquivos.Length != 0;
		}
		return false;
	}
}
