using System.Globalization;
using System.Linq.Expressions;

namespace nwErp.Api.Persistencia
{
    public interface IPersistencia : IDisposable
    {
        bool TransacaoAberta { get; }

        DateTime UltimaDataHora { get; }

        bool RegistrarEventos { get; set; }

        bool ModoDeTrace { get; set; }

        void TrabalharRemoto(bool pAtivo);

        void AtualizarInformacoesRegionais(CultureInfo cultura);

        void ValidarObjetoNoBanco(Type[] tipos, IObservadorAtualizacao observador);

        bool TestarConexao();

        List<T> CarregarLista<T>(T entidade, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        List<T> CarregarLista<T>(T entidade, int quantidadeDeRegistros, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        List<T> CarregarLista<T>(T entidade, Expression<Func<T, object>> campos, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        List<T> CarregarLista<T>(T entidade, int quantidadeDeRegistros, Expression<Func<T, object>> campos, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        List<T> CarregarListaVisao<T>(T view, params Expression<Func<T, bool>>[] filtros) where T : IVisao, new();

        bool CarregarVisao<T>(IVisao visao, params Expression<Func<T, bool>>[] filtros) where T : IVisao, new();

        bool Persistir(TipoPersistencia tipo, IEntidade entidade);

        bool CarregarEntidade(IEntidade entidade, bool travarRegistro);

        bool CarregarEntidade(IEntidade entidade);

        bool CarregarEntidadeParcialmente<T>(IEntidade entidade, Expression<Func<T, object>> campos) where T : IEntidade, new();

        int DeletarRegistros<T>(string tabela, params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        bool ExecutarProcedure(IProcedure procedure);

        bool ProcedureValidaExiste(IProcedure procedure);

        bool FuncaoValidaExiste(IProcedure procedure);

        bool PackageValidaExiste(IProcedure procedure);

        bool TabelaExiste(IEntidade entidade);

        int ContarRegistros<T>() where T : IEntidade, new();

        int ContarRegistros<T>(params Expression<Func<T, bool>>[] filtros) where T : IEntidade, new();

        List<T> ConsultaPorSQL<T>(string consultaSQL) where T : new();

        string ObterAssinaturaRegistro(string consultaSQL);

        bool IniciarTransacao();

        bool FinalizarTransacao();

        bool CancelarTransacao();

        bool BloquearRegistros<T>(List<T> registros) where T : IEntidade, new();

        bool BloquearRegistros<T>(List<T> registros, bool carregarEntidade) where T : IEntidade, new();

        DateTime DataHoraAtual();

        bool PersistirEmCascata(TipoPersistencia tipo, IEntidade entidade);

        bool RegistrarOberservadorDeExecucao(IOberservadorDeExecucao observador);

        bool RemoverOberservadorDeExecucao(IOberservadorDeExecucao observador);

        List<T> MapearLista<T>(T objDTO, IMapeador mapeador);

        void MapearObjeto<T>(T objeto, IMapeador mapeador);

        void MapearObjeto<T>(T objeto, TipoMapeamentoDeObjeto tipo);

        decimal ObterNumeroSequencial(string identificador);

        decimal ObterNumeroSequencialDeTabela<TEntidade, TPropriedade>(TEntidade entidade, Expression<Func<TEntidade, TPropriedade>> expressao) where TEntidade : IEntidade, new();

        decimal ObterNumeroSequencialDeTabela<TEntidade, TPropriedade>(TEntidade entidade, decimal quantidadeDeNumeros, Expression<Func<TEntidade, TPropriedade>> expressao) where TEntidade : IEntidade, new();

        void PersistenciaParalela<T>(T entidade) where T : IEntidade, new();

        void ExecutarScript(string script);
        void ExecutarScript(string comando, string descricaoScriptEmExecucao, bool ehExecucaoHangFire);

        void ExecutarScript(string script, bool novaConexao);
    }
}