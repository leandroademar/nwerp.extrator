

////namespace nwErp.Entidades;

public interface IEntidade
{
    void InicializarAtributos();

    string ObterNomeTabela();

    IEntidade NovaInstancia();

    PosicaoEntidade PosicaoEntidade { get; set; }

	PropertyInfo[] PropriedadesModificadas { get; }

	string IdentificacaoDoRegistro { get; set; }

	void CarregarPorDataReader(IDataReader leitor);
}

