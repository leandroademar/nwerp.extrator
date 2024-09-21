namespace ExportadorNFCe.Modelos
{
    public class MOGO_ERROXML : GerenteDePropriedades, IEntidade
    {
        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_ERROXML", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
        public int IdXml { get; set; }
        
        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_ERROXML", Tipo = TipoDoCampoNoBancoDeDados.Inteiro, Tamanho = 8, Precisao = 0)]
        public int IdNota { get; set; }
       
        [InfoCampoEntidade(ChavePrimaria = false, Tabela = "MOGO_ERROXML", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 100, Precisao = 0)]
        public string localxml { get; set; }
        public void CarregarPorDataReader(IDataReader leitor)
        {
            IdXml = AlterarTipo<int>(leitor["IDXML"]);
            IdNota = AlterarTipo<int>(leitor["IDNOTA"]);
            localxml = AlterarTipo<string>(leitor["LOCALXML"]);
        }

        public void InicializarAtributos()
        {
        }

        public IEntidade NovaInstancia()
        {
            return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
        }

        public string ObterNomeTabela()
        {
            return "MOGO_ERROXML";
        }
    }
}
