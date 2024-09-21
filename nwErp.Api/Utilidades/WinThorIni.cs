internal class WinThorIni
{
    public WinThorIni(string nomeArquivoIni) { NomeArquivo = nomeArquivoIni; }

    private bool ObterLinhaEmpresa(
        string nomeLoja,
        string nomeEmpresa,
        out string chaveCriptografada,
        out string senhaBDCripto)
    {
        StreamReader streamReader = new StreamReader(NomeArquivo);
        string text = string.Empty;
        string text2 = string.Empty;
        while((text = streamReader.ReadLine()) != null)
        {
            text = text.Trim();
            if(text.StartsWith("=") && text.Substring(1).ToUpper().Equals(nomeLoja))
            {
                text2 = text.Substring(1).ToUpper();
            } else if(text.StartsWith("+"))
            {
                QuebrarLinhaWinThorIni(text, out var nomeUsuarioBD, out chaveCriptografada, out senhaBDCripto);
                if(nomeUsuarioBD.Equals(nomeEmpresa) && text2.Equals(nomeLoja))
                {
                    return true;
                }
            }
        }
        chaveCriptografada = string.Empty;
        senhaBDCripto = string.Empty;
        return false;
    }

    private void QuebrarLinhaWinThorIni(
        string linhaWinThorIni,
        out string nomeUsuarioBD,
        out string chaveCriptografada,
        out string senhaBDCripto)
    {
        int num = linhaWinThorIni.IndexOf('#');
        int num2 = linhaWinThorIni.LastIndexOf('@');
        if(num > 0 && num2 > 0)
        {
            nomeUsuarioBD = linhaWinThorIni.Substring(1, num - 1);
            chaveCriptografada = linhaWinThorIni.Substring(num + 1, num2 - num - 1);
            senhaBDCripto = linhaWinThorIni.Substring(num2 + 1);
        } else
        {
            nomeUsuarioBD = string.Empty;
            chaveCriptografada = string.Empty;
            senhaBDCripto = string.Empty;
        }
    }

    private string NomeArquivo { get; set; }

    public LicencaUso ObterLicencaUso(string nomeLoja, string nomeEmpresa)
    {
        if(ObterLinhaEmpresa(nomeLoja, nomeEmpresa, out var chaveCriptografada, out var senhaBDCripto))
        {
            return new LicencaUso(nomeLoja, nomeEmpresa, chaveCriptografada, senhaBDCripto);
        }
        return null;
    }

    public List<string> ObterNomeEmpresas(string nomeLoja)
    {
        List<string> list = new List<string>();
        StreamReader streamReader = new StreamReader(NomeArquivo);
        bool flag = false;
        string text = string.Empty;
        while(text != null)
        {
            while((text = streamReader.ReadLine()) != null)
            {
                if(text.Trim().StartsWith("=") && text.Substring(1).ToUpper().Equals(nomeLoja))
                {
                    flag = true;
                    break;
                }
            }
            if(!flag)
            {
                continue;
            }
            while((text = streamReader.ReadLine()) != null)
            {
                text = text.Trim();
                if(text.StartsWith("="))
                {
                    break;
                }
                if(text.StartsWith("+"))
                {
                    int num = text.IndexOf('#');
                    list.Add(text.Substring(1, num - 1));
                }
            }
        }
        list.Sort();
        return list;
    }

    public List<string> ObterNomeLoja()
    {
        List<string> list = new List<string>();
        StreamReader streamReader = new StreamReader(NomeArquivo);
        string text = string.Empty;
        while((text = streamReader.ReadLine()) != null)
        {
            text = text.Trim();
            if(text.StartsWith("="))
            {
                list.Add(text.Replace("=", string.Empty));
            }
        }
        list.Sort();
        return list;
    }
}
