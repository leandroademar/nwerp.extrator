using System.Text;

namespace nwErp.Api.Persistencia
{
    public interface IOberservadorDeExecucao
    {
        void RegistrarComando(IDbCommand comando, IDataAdapter adaptador);

        void Registrar(StringBuilder registro);

        void Registrar(string registro);
    }

}
