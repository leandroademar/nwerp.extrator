using System.ComponentModel;

////namespace nwErp.Entidades;

[Flags]
public enum MascaraDeEdicaoEnumerador
{
	[Description(".{0,40}")]
	DescricaoPadrao = 2,
	[Description("[0-9]{3}\\.[0-9]{3}\\.[0-9]{3}-[0-9]{2}")]
	CPF = 4,
	[Description("[0-9]{2}\\.[0-9]{3}\\.[0-9]{3}/[0-9]{4}-[0-9]{2}")]
	CNPJ = 8,
	[Description("([0-9]{3}\\.[0-9]{3}\\.[0-9]{3}-[0-9]{2})|([0-9]{2}\\.[0-9]{3}\\.[0-9]{3}/[0-9]{4}-[0-9]{2})")]
	CPF_CNPJ = 0x10,
	[Description("[0-9]{0,6}")]
	CodigoParao = 0x20,
	[Description("[0-1]{1}[0-9]{1})|(2[0-3]{1}")]
	Hora = 0x40,
	[Description("[0-5]{1}[0-9]{1}")]
	Minuto = 0x80,
	[Description("[0-1]{1}[0-9]{1})|(2[0-3]{1}:[0-5]{1}[0-9]{1}")]
	HoraMinuto = 0x100,
	[Description("[0-9]*|[0-9]*,[0-9]{2}")]
	Monetario = 0x200,
	[Description("1|4|5|7|8|1[0134]")]
	CondicaoDeVenda = 0x400,
	[Description("P|B|L|M|F")]
	PosicaoDoPedido = 0x800,
	[Description("[0-9]*")]
	NumericoTamanhoIndefinido = 0x1000,
	[Description("[0-9]*")]
	NumericoDezCasas = 0x2000
}
