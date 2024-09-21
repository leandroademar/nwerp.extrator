using System.Runtime.InteropServices;

namespace nwErp.Api.Persistencia
{
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct PersistenciaDefinida
    {
        public static IPersistencia Persistencia { get; set; }
    }

}
