using System.Linq.Expressions;
using nwErp.Api.Persistencia;

namespace nwErp.Api.Importadores;

public static class ParametrosDoSistema
{
	public static List<PCPARAMFILIAL> _PCPARAMFILIAL;

	private static PCCONSUM _PCCONSUM;

	public static string ObterParametroPorFilial(IPersistencia persistencia, string parametro)
	{
		return ObterParametroPorFilial(persistencia, parametro, "99");
	}

	public static string ObterParametroPorFilial(IPersistencia persistencia, string parametro, string filial)
	{
		if (_PCPARAMFILIAL == null)
		{
			_PCPARAMFILIAL = persistencia.CarregarLista(new PCPARAMFILIAL());
		}
		PCPARAMFILIAL pCPARAMFILIAL = _PCPARAMFILIAL.Where((PCPARAMFILIAL param) => param.Nome == parametro && param.Codfilial == filial).FirstOrDefault();
		if (pCPARAMFILIAL != null)
		{
			return pCPARAMFILIAL.Valor;
		}
		return string.Empty;
	}

	public static PCCONSUM ObterParametros(IPersistencia persistencia)
	{
		if (_PCCONSUM == null)
		{
			_PCCONSUM = persistencia.CarregarLista(new PCCONSUM()).FirstOrDefault();
		}
		return _PCCONSUM;
	}

	public static decimal ObterProximoNumero<TPropriedade>(IPersistencia persistencia, Expression<Func<PCCONSUM, TPropriedade>> expressao)
	{
		if (_PCCONSUM == null)
		{
			_PCCONSUM = persistencia.CarregarLista(new PCCONSUM()).FirstOrDefault();
		}
		lock (_PCCONSUM)
		{
			return persistencia.ObterNumeroSequencialDeTabela(_PCCONSUM, expressao);
		}
	}
}