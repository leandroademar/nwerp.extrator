using System.Runtime.InteropServices;


#nullable disable
namespace nwErp.Api.Jobs;


public abstract class BaseTarefas : IDisposable
{
    private IntPtr nativeResource = Marshal.AllocHGlobal(100);

    ~BaseTarefas() => this.Dispose(false);

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize((object)this);
    }

    protected virtual void DisposeJob()
    {
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
            this.DisposeJob();
        if (!(this.nativeResource != IntPtr.Zero))
            return;
        Marshal.FreeHGlobal(this.nativeResource);
        this.nativeResource = IntPtr.Zero;
    }
}

