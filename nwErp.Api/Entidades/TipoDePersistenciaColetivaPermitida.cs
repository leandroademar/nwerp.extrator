////namespace nwErp.Entidades;

[Flags]
public enum TipoDePersistenciaColetivaPermitida
{
	Incluir = 1,
	Alterar = 2,
	Deletar = 4,
	Carregar = 8,
	Recarregar = 0x10,
	CarregarRecarregar = 0x18,
	CarregarAlterar = 0x1A,
	IncluirAlterar = 0x1B,
	Todos = 0x1F
}
