namespace nwErp.Api.Persistencia
{
    public enum TipoMapeamentoDeObjeto
    {
        Inserir = 1,
        Excluir,
        Atualizar
    }

    public enum TipoPersistencia
    {
        INCLUIR,
        ALTERAR,
        DELETAR,
        CARREGAR,
        RECARREGAR
    }

    public enum OrigemDeDados
    {
        Integracao,
        Caixa,
        ServidorLoja,
        Api
    }

}
