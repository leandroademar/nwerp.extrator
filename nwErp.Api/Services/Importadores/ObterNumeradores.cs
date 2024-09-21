using nwErp.Api.Persistencia;
using nwErp.Api.Entidades;

namespace nwErp.Api.Importadores;

public static class ObterNumeradores
{
	private static List<decimal> ListaNumtransvenda = new List<decimal>();

	private static List<decimal> ListaNumtransent = new List<decimal>();

	private static decimal Quantidade = 50m;

	public static decimal ProxNumtransvenda(IPersistencia persistencia)
	{
		lock (ListaNumtransvenda)
		{
			decimal num = -1m;
			if (ListaNumtransvenda.Count > 0)
			{
				num = ListaNumtransvenda[0];
			}
			else
			{
				IniciarListaNumTransVenda(ObterNumtransvenda(persistencia));
				num = ListaNumtransvenda[0];
			}
			ListaNumtransvenda.RemoveAt(0);
			return num;
		}
	}

	private static void IniciarListaNumTransVenda(decimal ultimoNumero)
	{
		for (decimal num = ultimoNumero; num < ultimoNumero + Quantidade; ++num)
		{
			ListaNumtransvenda.Add(num);
		}
	}

	private static decimal ObterNumtransvenda(IPersistencia persistencia)
	{
		FERRAMENTAS.F_PROX_NUMTRANSVENDA f_PROX_NUMTRANSVENDA = new FERRAMENTAS.F_PROX_NUMTRANSVENDA();
		try
		{
			if (persistencia.ProcedureValidaExiste(f_PROX_NUMTRANSVENDA))
			{
				f_PROX_NUMTRANSVENDA.P_INCREMENTO = Quantidade;
				persistencia.ExecutarProcedure(f_PROX_NUMTRANSVENDA);
				if (f_PROX_NUMTRANSVENDA.Retorno > 0m)
				{
					return f_PROX_NUMTRANSVENDA.Retorno;
				}
				throw new Exception("Retorno da Procedure FERRAMENTAS invalido ou inexistente");
			}
			throw new Exception("Procedure FERRAMENTAS invalida ou inexistente");
		}
		catch (Exception ex)
		{
			throw new Exception($"Erro ao gerar o ProxNumtransvenda através da PKG FERRAMENTAS.F_PROX_NUMTRANSVENDA : {f_PROX_NUMTRANSVENDA.Retorno} {ex.Message}");
		}
	}

	public static decimal ProxNumtransent(IPersistencia persistencia)
	{
		lock (ListaNumtransent)
		{
			decimal num = -1m;
			if (ListaNumtransent.Count > 0)
			{
				num = ListaNumtransent[0];
			}
			else
			{
				IniciarListaNumTransEnt(ObterNumtransent(persistencia));
				num = ListaNumtransent[0];
			}
			ListaNumtransent.RemoveAt(0);
			return num;
		}
	}

	private static decimal ObterNumtransent(IPersistencia persistencia)
	{
		FERRAMENTAS.F_PROX_NUMTRANSENT f_PROX_NUMTRANSENT = new FERRAMENTAS.F_PROX_NUMTRANSENT();
		try
		{
			if (persistencia.ProcedureValidaExiste(f_PROX_NUMTRANSENT))
			{
				f_PROX_NUMTRANSENT.P_INCREMENTO = Quantidade;
				persistencia.ExecutarProcedure(f_PROX_NUMTRANSENT);
				if (f_PROX_NUMTRANSENT.Retorno > 0m)
				{
					return f_PROX_NUMTRANSENT.Retorno;
				}
				throw new Exception("Retorno da Procedure FERRAMENTAS invalido ou inexistente");
			}
			throw new Exception("Procedure FERRAMENTAS invalida ou inexistente");
		}
		catch (Exception ex)
		{
			throw new Exception($"Erro ao gerar o ProxNumtransent através da PKG FERRAMENTAS.F_PROX_NUMTRANSENT_VAREJO : {f_PROX_NUMTRANSENT.Retorno} {ex.Message}");
		}
	}

	private static void IniciarListaNumTransEnt(decimal ultimoNumero)
	{
		for (decimal num = ultimoNumero; num < ultimoNumero + Quantidade; ++num)
		{
			ListaNumtransent.Add(num);
		}
	}
}