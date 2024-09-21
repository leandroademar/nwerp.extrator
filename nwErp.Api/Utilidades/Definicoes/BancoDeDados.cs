namespace nwErp.Api.Definicoes
{
    public class BancoDeDados
    {
        public string Servidor { get; set; }

        public string Porta { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Endereco { get; set; }

        public string NomeDoServico { get; set; }

        public string StringDeConexao { get; set; }

        public string TipoServico { get; set; }

        public bool DefinicaoSimples { get; set; }

        internal BancoDeDados(string servidor, string usuario, string endereco, string nomeDoServico, string senha, string stringDeConexao, bool definicaoSimples, string porta, string tipoServico)
        {
            Servidor = servidor;
            Usuario = usuario;
            Endereco = endereco;
            NomeDoServico = nomeDoServico;
            Senha = senha;
            StringDeConexao = stringDeConexao;
            DefinicaoSimples = definicaoSimples;
            Porta = porta;
            TipoServico = tipoServico;
        }

        public BancoDeDados()
        {
        }

        public string ObterStringDeConexao()
        {
            string arg = Servidor;
            if (!DefinicaoSimples)
            {
                arg = ObterStringDeIdentificacao();
            }
            return $"Data Source={arg};User ID={Usuario};Password={Senha}";
        }

        public string ObterStringDeIdentificacao(string endereco, string nomeDoServico, string tipoServico)
        {
            return string.Format(string.IsNullOrEmpty(StringDeConexao) ? "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=({3}={2})))" : StringDeConexao.ToLower().Replace("{ip}", "{0}").Replace("{servico}", "{1}")
                .Replace("{PORTA}", "{2}"), endereco, Porta, nomeDoServico, tipoServico.Trim()).ToUpper();
        }

        public string ObterStringDeIdentificacao()
        {
            return ObterStringDeIdentificacao(Endereco, NomeDoServico, TipoServico);
        }
    }
}
