using Hangfire;
using Hangfire.Server;
using nwErp.Api.Configuration;
using nwErp.Api.Modelos;
using nwErp.Api.Persistencia;

namespace nwErp.Api.Jobs
{
    public class JobTioluizIntegracaoPedidoBalcao : IHostedService
    {
        private readonly IConfiguration _configuration;
        private readonly IPersistencia _persistencia;

       public List<PCPEDI> _itensTrib = new List<PCPEDI>();

        public List<PCPEDI> _itensST = new List<PCPEDI>();
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Configure();
            return Task.CompletedTask;

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

          public JobTioluizIntegracaoPedidoBalcao(IConfiguration configuration, IPersistencia persistencia)
        {
            _configuration = configuration;
            _persistencia = persistencia;
        }

        public static void Configure()
        {
            UtilidadeLogConsole.LogConsole("Iniciando processo de criação de estrutura no HangFire", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Atencao);
            CriarTasksJobs();
            UtilidadeLogConsole.LogConsole("Estrutura do HangFire criada com sucesso!", nameof(Configure), UtilidadeLogConsole.TipoMensagem.Sucesso);
        }

        public static void CriarTasksJobs()
        {
            RecurringJob.AddOrUpdate<JobTioluizIntegracaoPedidoBalcao>("Carga de Replicação Pedido - Filial 10", x => x.GetPedidosFilialAsync(null), Cron.Hourly(1), TimeZoneInfo.Local);
        }
        
        public void GetPedidosFilialAsync(PerformContext context)
        {
            UtilidadeLogConsole.LogConsole("Iniciando processo de integração de pedidos", nameof(GetPedidosFilialAsync), UtilidadeLogConsole.TipoMensagem.Atencao);
            try
            {

                List<PedidoMatriz> pedidosMatriz = _persistencia.ConsultaPorSQL<PedidoMatriz>(ExecutaComandoScript("Query_PedidosFilial10")); 
                foreach (var ped in pedidosMatriz)
                {
                    PCPEDC pCPEDC = _persistencia.CarregarLista(new PCPEDC(), (PCPEDC x) => (decimal?)x.Numped == ped.NUMPED).FirstOrDefault();
                    if(ped.DIVIDPED == "S" && ped.QTPED > 1)
                    {
                        List<PCPEDI> pCPEDIs = _persistencia.CarregarLista(new PCPEDI(), (PCPEDI x) => (decimal?)x.Numped == ped.NUMPED);
                        foreach(var item in pCPEDIs)
                        {
                            PCTRIBUT tipotributo = _persistencia.CarregarLista(new PCTRIBUT(), (PCTRIBUT x) => x.Codst == item.Codst).FirstOrDefault();
                            if(tipotributo.Sittribut == "10")
                            {
                                _itensST.Add(item);
                            }
                            else
                            {                                
                                _itensTrib.Add(item);   
                            }
                        }

                        if(_itensST != null && _itensST.Count > 0)
                        {
                            decimal numeroPedido = _persistencia.ObterNumeroSequencialDeTabela(pCPEDC, (PCPEDC? usu) => usu.Numped);
                            foreach(var item in _itensST)
                            {
                                item.Numped = numeroPedido;
                                _persistencia.Persistir(TipoPersistencia.INCLUIR,item);
                            }
                            pCPEDC.Numpedweb = ped.NUMPED;
                            pCPEDC.Numped = numeroPedido;
                            pCPEDC.Codfilial = "1";
                            pCPEDC.Codfilialnf = "1";
                            _persistencia.Persistir(TipoPersistencia.INCLUIR,pCPEDC);
                        }

                        if(_itensTrib != null && _itensTrib.Count > 0)
                        {
                            decimal numeroPedido = _persistencia.ObterNumeroSequencialDeTabela(pCPEDC, (PCPEDC? usu) => usu.Numped);
                            foreach(var item in _itensTrib)
                            {
                                item.Numped = numeroPedido;
                                _persistencia.Persistir(TipoPersistencia.INCLUIR,item);
                            }
                            pCPEDC.Numpedweb = ped.NUMPED;
                            pCPEDC.Numped = numeroPedido;
                            pCPEDC.Codfilial = "1";
                            pCPEDC.Codfilialnf = "1";
                            _persistencia.Persistir(TipoPersistencia.INCLUIR,pCPEDC);
                        }

                    }

                    if(ped.QTPED == 1)
                    {

                        PCUSUARI pCUSUARI = _persistencia.CarregarLista(new PCUSUARI(), (PCUSUARI usu) => usu.Codusur == ped.CODUSUR).FirstOrDefault();
                        decimal numeroPedido = _persistencia.ObterNumeroSequencialDeTabela(pCUSUARI, (PCUSUARI? usu) => usu.Proxnumped);
                        
                        List<PCPEDI> pCPEDIs = _persistencia.CarregarLista(new PCPEDI(), (PCPEDI x) => (decimal?)x.Numped == ped.NUMPED);
                        foreach(var item in pCPEDIs)
                        {                                                 
                            item.Numped = numeroPedido;
                            _persistencia.Persistir(TipoPersistencia.INCLUIR,item);                                                                               
                        }
                        pCPEDC.Numpedweb = pCPEDC.Numped;
                        pCPEDC.Numped = numeroPedido;
                        pCPEDC.Codfilial = "1";
                        pCPEDC.Codfilialnf = "1";
                        _persistencia.Persistir(TipoPersistencia.INCLUIR,pCPEDC);

                    }
                   
                }

                UtilidadeLogConsole.LogConsole("Integração de pedidos finalizada com sucesso!", nameof(GetPedidosFilialAsync), UtilidadeLogConsole.TipoMensagem.Sucesso);
            }
            catch (Exception ex)
            {
                UtilidadeLogConsole.LogConsole("Erro ao integrar pedidos: " + ex.Message, nameof(GetPedidosFilialAsync), UtilidadeLogConsole.TipoMensagem.Erro);
            }
        }        

        public string ExecutaComandoScript(string nomeScript)
        {
            string baseDirectory = AppContext.BaseDirectory;
            if (!File.Exists(Path.Combine(baseDirectory, "Script", nomeScript + ".sql")))
                return null;
            string @string = File.ReadAllText(Path.Combine(baseDirectory, "Script", nomeScript + ".sql"));
            if (string.IsNullOrEmpty(@string))
                return null;
            Console.WriteLine($"Executando Script: {nomeScript}");
            return @string.ToString();
        }

    }
}