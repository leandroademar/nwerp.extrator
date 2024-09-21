using nwErp.Api.Persistencia;
using System.Text;

namespace nwErp.Api.Utilidades
{
    public class LogImportacao<T> where T : IEntidade
    {
        private StringBuilder _log = new StringBuilder();

        private decimal _numpedecf;

        private decimal _numorca;

        private decimal _numcaixa;

        private decimal _numvale;

        private string _numserieequip;

        private decimal _codfunccx;

        private string _tabela;

        private IPersistencia _persistencia;

        private static string _versao = string.Empty;

        public StringBuilder Log => _log;

        public bool FinalizadoComSucesso { get; set; }

        public LogImportacao(IPersistencia persistencia, decimal numpedecf, decimal numorca, decimal numcaixa, decimal numvale, string numserieequip, decimal codfunccx)
        {
            _persistencia = persistencia;
            _numpedecf = numpedecf;
            _numorca = numorca;
            _numcaixa = numcaixa;
            _numvale = numvale;
            _numserieequip = numserieequip;
            _codfunccx = codfunccx;
            _tabela = typeof(T).Name;
        }

        public void Registrar(string texto)
        {
            _log.Append(texto);
        }

        public void RegistrarLinha()
        {
            _log.AppendLine();
        }

        public void RegistrarLinha(string texto)
        {
            _log.AppendLine(texto);
        }

        public void Gravar()
        {
            Gravar(gravarDetalhamento: true);
        }

        public void Gravar(bool gravarDetalhamento)
        {
        }

        private void GravarItensLog(decimal codigoCabecalho)
        {
        }

        private static string ObterVersao()
        {
            if (string.IsNullOrEmpty(_versao))
            {
                lock (_versao)
                {
                    _versao = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
            }
            return _versao;
        }
    }
}
