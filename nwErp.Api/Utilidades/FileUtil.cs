using System.Diagnostics;
using System.Runtime.InteropServices;

//namespace nwErp.Utilidades;

public static class FileUtil
{
	private struct RM_UNIQUE_PROCESS
	{
		public int dwProcessId;

		public System.Runtime.InteropServices.ComTypes.FILETIME ProcessStartTime;
	}

	private enum RM_APP_TYPE
	{
		RmUnknownApp = 0,
		RmMainWindow = 1,
		RmOtherWindow = 2,
		RmService = 3,
		RmExplorer = 4,
		RmConsole = 5,
		RmCritical = 1000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct RM_PROCESS_INFO
	{
		public RM_UNIQUE_PROCESS Process;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string strAppName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string strServiceShortName;

		public RM_APP_TYPE ApplicationType;

		public uint AppStatus;

		public uint TSSessionId;

		[MarshalAs(UnmanagedType.Bool)]
		public bool bRestartable;
	}

	private const int RmRebootReasonNone = 0;

	private const int CCH_RM_MAX_APP_NAME = 255;

	private const int CCH_RM_MAX_SVC_NAME = 63;

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmRegisterResources(uint pSessionHandle, uint nFiles, string[] rgsFilenames, uint nApplications, [In] RM_UNIQUE_PROCESS[] rgApplications, uint nServices, string[] rgsServiceNames);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
	private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmEndSession(uint pSessionHandle);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmGetList(uint dwSessionHandle, out uint pnProcInfoNeeded, ref uint pnProcInfo, [In][Out] RM_PROCESS_INFO[] rgAffectedApps, ref uint lpdwRebootReasons);

	public static List<Process> WhoIsLocking(string path)
	{
		string strSessionKey = Guid.NewGuid().ToString();
		List<Process> list = new List<Process>();
		if (RmStartSession(out var pSessionHandle, 0, strSessionKey) != 0)
		{
			throw new Exception("Não foi possível iniciar a sessão de reinício. Não foi possível determinar arquivo bloqueador.");
		}
		try
		{
			uint pnProcInfoNeeded = 0u;
			uint pnProcInfo = 0u;
			uint lpdwRebootReasons = 0u;
			string[] array = new string[1] { path };
			if (RmRegisterResources(pSessionHandle, (uint)array.Length, array, 0u, null, 0u, null) != 0)
			{
				throw new Exception("Não foi possível registrar o recurso.");
			}
			switch (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, null, ref lpdwRebootReasons))
			{
			case 234:
			{
				RM_PROCESS_INFO[] array2 = new RM_PROCESS_INFO[pnProcInfoNeeded];
				pnProcInfo = pnProcInfoNeeded;
				if (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, array2, ref lpdwRebootReasons) == 0)
				{
					list = new List<Process>((int)pnProcInfo);
					for (int i = 0; i < pnProcInfo; i++)
					{
						try
						{
							list.Add(Process.GetProcessById(array2[i].Process.dwProcessId));
						}
						catch (ArgumentException)
						{
						}
					}
					break;
				}
				throw new Exception("Não foi possível listar os processos do recurso bloqueador.");
			}
			default:
				throw new Exception("Não foi possível listar os processos de recurso bloqueador. Falha ao obter o tamanho do resultado.");
			case 0:
				break;
			}
		}
		finally
		{
			RmEndSession(pSessionHandle);
		}
		return list;
	}
}
