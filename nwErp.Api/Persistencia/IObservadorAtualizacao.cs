namespace nwErp.Api.Persistencia
{
    public interface IObservadorAtualizacao
    {
        void Registrar(string texto);

        void RegistrarPercetualAndamento(int parcial, int total);
    }

}
