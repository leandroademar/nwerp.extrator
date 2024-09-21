namespace nwErp.Api.Utilidades;

public static class Resources
{
    public static string GetSQL(string[] vFolders, string vResourceName)
    {
        string str = "";
        foreach (string vFolder in vFolders)
            str = str + vFolder + ".";
        Assembly callingAssembly = Assembly.GetCallingAssembly();
        callingAssembly.GetManifestResourceNames();
        string name = string.Format("{0}.{1}{2}", (object) callingAssembly.GetName().Name, (object) str, (object) vResourceName);
        string sql = new StreamReader(callingAssembly.GetManifestResourceStream(name)).ReadToEnd();
        if (sql.ToUpper().Contains("BEGIN"))
            sql = sql.Replace("\r\n", " ");
        vFolders = (string[]) null;
        return sql;
    }

    public static List<string> GetResourcesFromDirectory(string[] vFolders)
    {
        List<string> stringList = new List<string>();
        Assembly callingAssembly = Assembly.GetCallingAssembly();
        string strPath = callingAssembly.GetName().Name;
        foreach (string vFolder in vFolders)
            strPath = strPath + "." + vFolder;
        return ((IEnumerable<string>) callingAssembly.GetManifestResourceNames()).Where<string>((Func<string, bool>) (Filtro => Filtro.StartsWith(strPath))).ToList<string>();
    }
}
