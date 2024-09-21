using System.Text;
using nwErp.Api.Persistencia;
using nwErp.Api.Utilidades;


namespace nwErp.Api.Importadores;

public class ImportadorDeDados
{

    
	private List<IValidadorPedido> _validadores = new List<IValidadorPedido>();

	private ImportadorBase _importadorECF;

	private EsquemaExportacao _esquema;

	private IPersistencia _persistencia;

	private bool _modoDeTraceAtivo;

	private StringBuilder _inconsistencias;

	public ImportadorDeDados(IPersistencia persistencia, bool monitorarPersistencia, StringBuilder inconsistencias)
	{
		_inconsistencias = inconsistencias ?? new StringBuilder();
		_persistencia = persistencia;
		_persistencia.RegistrarEventos = (_modoDeTraceAtivo = monitorarPersistencia);
		_persistencia.ModoDeTrace = _modoDeTraceAtivo;
	}

    public void Importar(EsquemaExportacao esquema)
	{
		_esquema = esquema;
		DefinirImportador();
        ImportarPedido();
    }

    private void DefinirImportador()
	{
		if (_esquema.PedidoExportado)
		{
			if (_esquema.Pedido.Pedido.Serieecf == "X" || _esquema.Pedido.Pedido.Docemissao != "NF")
			{
				_importadorECF = new ImportadorCupom();
			}
			else
			{
				_importadorECF = new ImportadorNota();
			}
		}
	}

    private void ImportarPedido()
	{
		if (!_esquema.PedidoExportado)
		{
			return;
		}

		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			if (PedidoValidoParaImportacao(_esquema, stringBuilder))
			{
				try
				{
					_importadorECF.Importar(_esquema.Pedido, _persistencia);
					_esquema.Pedido = null;
				}
				catch (Exception erro)
				{
					GerarMessagemParaExcecao(erro, stringBuilder, "Erro desconhecido ao importar pedido: ");
				}
			}
			if (stringBuilder.Length > 0)
			{
				_inconsistencias.Append(stringBuilder.ToString());
			}
		}finally
        {

        }
	}

    public void ImportarComplementos()
	{
		if (!_esquema.ComplementoExportado)
		{
			return;
		}

		try
		{
		
			ImportadorComplemento importadorComplemento = new ImportadorComplemento(_esquema.Complemento, _persistencia, _inconsistencias);
            
			try
			{
				importadorComplemento.Importar();
				_esquema.Complemento = null;
			}
			catch (Exception erro)
			{
				GerarMessagemParaExcecao(erro, _inconsistencias, "Erro ao desconhecido ao importar cancelamentos:");
			}
		}
		finally
		{
			
		}
	}

    private void GerarMessagemParaExcecao(Exception erro, StringBuilder log, params string[] mensagens)
	{
		if (mensagens != null && mensagens.Length != 0)
		{
			log.AppendLine();
			foreach (string value in mensagens)
			{
				log.AppendLine(value);
			}
		}
		Exception ex = erro;
		int num = 1;
		while (ex != null)
		{
			log.AppendLine();
			log.AppendLine(num + ") ===>");
			log.AppendLine(ex.Message);
			log.AppendLine();
			log.AppendLine(ex.StackTrace);
			ex = ex.InnerException;
			num++;
		}
	}

    private bool PedidoValidoParaImportacao(EsquemaExportacao informacoes, StringBuilder mensagem)
	{
		bool flag = true;
		foreach (IValidadorPedido validadore in _validadores)
		{
			flag = flag && validadore.Validar(informacoes, mensagem);
		}
		return flag;
	}



}

public interface IValidadorPedido
{
	IPersistencia Persistencia { get; set; }

	bool Validar(EsquemaExportacao informacoes, StringBuilder mensagem);
}

