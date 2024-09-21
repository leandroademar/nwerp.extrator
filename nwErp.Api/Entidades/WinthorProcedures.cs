namespace nwErp.Api.Entidades
{
    public class P_PC_CACELA_NF : IProcedure
    {
        [ParametroDeEntrada]
        public string PNCODIGOFUNCIONARIO { get; set; }

        [ParametroDeEntrada]
        public decimal PNNUMTRANSVENDA { get; set; }

        [ParametroDeEntrada]
        public string PVC2MOTIVOCANCEL { get; set; }

        [ParametroDeSaida]
        public string PVC2MENSSAGEM { get; set; }
    }

    public class P_PC_CACELA_NF_NOEST : IProcedure
    {
        [ParametroDeEntrada]
        public string PNCODIGOFUNCIONARIO { get; set; }

        [ParametroDeEntrada]
        public decimal PNNUMTRANSVENDA { get; set; }

        [ParametroDeEntrada]
        public string PVC2MOTIVOCANCEL { get; set; }

        [ParametroDeSaida]
        public string PVC2MENSSAGEM { get; set; }
    }


    public class P_PC_CANCELAMENTOAUTOMATICO : IProcedure
    {
        [ParametroDeEntrada]
        public decimal P_MATRICULA { get; set; }

        [ParametroDeEntrada]
        public decimal P_NUMTRANSVENDA { get; set; }
    }

    public class P_PC_FATURAMENTOAUTOSERVICO : IProcedure
    {
        [ParametroDeEntrada]
        public decimal PNUMPEDIDO { get; set; }

        [ParametroDeSaida]
        public string AMSGRETORNO { get; set; }
    }

    public class PARAMFILIAL
    {
        [NomeDaPackage("PARAMFILIAL")]
        public class OBTERCOMOVARCHAR2 : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public string NOMEPARAM { get; set; }

            [ParametroDeEntrada]
            public string PCODFILIAL { get; set; }
        }

        [NomeDaPackage("PARAMFILIAL")]
        public class OBTERCOMOBOOLEAN : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public string NOMEPARAM { get; set; }

            [ParametroDeEntrada]
            public string CODFILIAL { get; set; }
        }

        [NomeDaPackage("PARAMFILIAL")]
        public class OBTERCOMODATE : IProcedure
        {
            [ParametroDeRetorno]
            public DateTime Retorno { get; set; }

            [ParametroDeEntrada]
            public string NOMEPARAM { get; set; }

            [ParametroDeEntrada]
            public string CODFILIAL { get; set; }
        }

        [NomeDaPackage("PARAMFILIAL")]
        public class OBTERCOMONUMBER : IProcedure
        {
            [ParametroDeRetorno]
            public decimal Retorno { get; set; }

            [ParametroDeEntrada]
            public string NOMEPARAM { get; set; }

            [ParametroDeEntrada]
            public string CODFILIAL { get; set; }
        }
    }

    public class FERRAMENTAS
    {
        [NomeDaPackage("FERRAMENTAS")]
        public class RECONTAR_NUMSEQ : IProcedure
        {
            [ParametroDeEntrada]
            public decimal PNUMPED { get; set; }
        }

        [NomeDaPackage("FERRAMENTAS")]
        public class VERIFICAR_FJ : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal PCODCLI { get; set; }
        }

        [NomeDaPackage("FERRAMENTAS")]
        public class VERIFICAR_ISENTOST : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal PCODCLI { get; set; }

            [ParametroDeEntrada]
            public decimal PCODPROD { get; set; }

            [ParametroDeEntrada]
            public decimal PCODST { get; set; }
        }

        [NomeDaPackage("FERRAMENTAS")]
        public class F_PROX_NUMTRANSVENDA : IProcedure
        {
            [ParametroDeEntrada]
            public decimal P_INCREMENTO { get; set; }

            [ParametroDeRetorno]
            public decimal Retorno { get; set; }
        }

        [NomeDaPackage("FERRAMENTAS")]
        public class F_PROX_NUMTRANSENT : IProcedure
        {
            [ParametroDeEntrada]
            public decimal P_INCREMENTO { get; set; }

            [ParametroDeRetorno]
            public decimal Retorno { get; set; }
        }

        [NomeDaPackage("FERRAMENTAS")]
        public class F_PROX_RECNUM : IProcedure
        {
            [ParametroDeRetorno]
            public decimal Retorno { get; set; }
        }
    }

    public class DECRYPT : IProcedure
    {
        [ParametroDeRetorno]
        public string Retorno { get; set; }

        [ParametroDeEntrada]
        public string KEY { get; set; }

        [ParametroDeEntrada]
        public string MASK { get; set; }
    }


    public class PC_PKG_FATURAMENTO
    {
        [NomeDaPackage("FATURAMENTO")]
        public class RATEIO_ITENS_PEDIDO : IProcedure
        {
            [ParametroDeEntrada]
            public decimal PNUMPED { get; set; }

            [ParametroDeEntrada]
            public string PCAMPO { get; set; }
        }
    }

    public class PKG_ESTOQUE
    {
        [NomeDaPackage("PKG_ESTOQUE")]
        public class VENDAS_SAIDA : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnNUMTRANSACAO { get; set; }

            [ParametroDeEntrada]
            public string psECANCELAMENTO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class VENDAS_ENTRADA : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnNUMTRANSACAO { get; set; }

            [ParametroDeEntrada]
            public string psECANCELAMENTO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class VENDAS_SAIDA_PROD : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnNUMTRANSACAO { get; set; }

            [ParametroDeEntrada]
            public decimal pnCODPROD { get; set; }

            [ParametroDeEntrada]
            public string psECANCELAMENTO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class VENDAS_ENTRADA_PROD : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnNUMTRANSACAO { get; set; }

            [ParametroDeEntrada]
            public decimal pnCODPROD { get; set; }

            [ParametroDeEntrada]
            public string psAPENAS_QTEST_QTESTGER { get; set; }

            [ParametroDeEntrada]
            public string psECANCELAMENTO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class ESTOQUE_DISPONIVEL : IProcedure
        {
            [ParametroDeRetorno]
            public decimal Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnCODPROD { get; set; }

            [ParametroDeEntrada]
            public string psCODFILIAL { get; set; }

            [ParametroDeSaida]
            public string psPROCESSO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class COMPRAS_ENTRADA : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnNUMTRANSACAO { get; set; }

            [ParametroDeEntrada]
            public string psECANCELAMENTO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class FRENTELOJA_ATUALIZAR_PCEST : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public string psCODFILIAL { get; set; }

            [ParametroDeEntrada]
            public decimal pnCODPROD { get; set; }

            [ParametroDeEntrada]
            public decimal pnQTDE { get; set; }

            [ParametroDeEntrada]
            public string psOPERACAO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }

            [ParametroDeEntrada]
            public string pnIDENTIFICADOR { get; set; }
        }

        [NomeDaPackage("PKG_ESTOQUE")]
        public class RESERVA_BAIXAR_PEDIDO : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal pnIDENTIFICADOR { get; set; }

            [ParametroDeEntrada]
            public string psOPERACAO { get; set; }

            [ParametroDeSaida]
            public string psMSG_RETORNO { get; set; }
        }
    }

    public class NFCE_INUTILIZARNUMERACAO : IProcedure
    {
        [ParametroDeEntrada]
        public string P_CODFILIAL { get; set; }

        [ParametroDeEntrada]
        public DateTime P_DTHORAPROCESSAMENTO { get; set; }

        [ParametroDeEntrada]
        public decimal P_NUMINICIAL { get; set; }

        [ParametroDeEntrada]
        public decimal P_NUMFINAL { get; set; }

        [ParametroDeEntrada]
        public decimal P_SERIE { get; set; }

        [ParametroDeEntrada]
        public decimal P_ANO { get; set; }

        [ParametroDeEntrada]
        public string P_JUSTIFICATIVA { get; set; }

        [ParametroDeEntrada]
        public string P_PROTOCOLO { get; set; }

        [ParametroDeEntrada]
        public string P_AMBIENTE { get; set; }

        [ParametroDeEntrada]
        public decimal P_CODUSUARIO { get; set; }

        [ParametroDeEntrada]
        public string P_TIPOMOV { get; set; }

        [ParametroDeEntrada]
        public decimal P_CAIXA { get; set; }
    }

    public class FISCAL
    {
        [NomeDaPackage("FISCAL")]
        public class CALCULAR_RATEIO_DESPESAS : IProcedure
        {
            [ParametroDeEntrada]
            public decimal P_TRANSACAO { get; set; }

            [ParametroDeSaida]
            public string MSG { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class CALCULAR_RATEIO_DESPESAS_DEVOL : IProcedure
        {
            [ParametroDeEntrada]
            public decimal P_TRANSACAO { get; set; }

            [ParametroDeSaida]
            public string MSG { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class GET_CODTRIBEXCECAO_PISCOFINS : IProcedure
        {
            [ParametroDeRetorno]
            public decimal Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal PCODTRIBPISCOFINS { get; set; }

            [ParametroDeEntrada]
            public decimal PCODFISCAL { get; set; }

            [ParametroDeEntrada]
            public string PCODOPER { get; set; }

            [ParametroDeEntrada]
            public decimal PCONDVENDA { get; set; }

            [ParametroDeEntrada]
            public string PCLIENTESUFRAMA { get; set; }

            [ParametroDeEntrada]
            public string PPRODUTOIMPORTADO { get; set; }

            [ParametroDeEntrada]
            public string PTIPOCLIENT { get; set; }

            [ParametroDeEntrada]
            public string PPISCOFINSCUM { get; set; }

            [ParametroDeEntrada]
            public string PFILIALORIGEM { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class CALCULARPISCOFINS_VENDA : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal NUMTRANSACAO { get; set; }

            [ParametroDeSaida]
            public string MSG { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class CALCULARPISCOFINS_TRANSPORTE : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal NUMTRANSACAO { get; set; }

            [ParametroDeSaida]
            public string MSG { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class CALCULARPISCOFINS_DEVOLUCAO : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal NUMTRANSACAO { get; set; }

            [ParametroDeSaida]
            public string MSG { get; set; }
        }

        [NomeDaPackage("FISCAL")]
        public class GET_DADOS_TRIBUTACAO_IPI : IProcedure
        {
            [ParametroDeRetorno]
            public string Retorno { get; set; }

            [ParametroDeEntrada]
            public decimal P_CODCLI { get; set; }

            [ParametroDeEntrada]
            public decimal P_CODPROD { get; set; }

            [ParametroDeEntrada]
            public string P_CODFILIAL { get; set; }

            [ParametroDeEntrada]
            public DateTime P_DATAOPERACAO { get; set; }

            [ParametroDeSaida]
            public decimal P_CST_ENTRADA { get; set; }

            [ParametroDeSaida]
            public decimal P_CST_SAIDA { get; set; }

            [ParametroDeSaida]
            public string P_GERABASEALIQZERO { get; set; }

            [ParametroDeSaida]
            public string P_MSG { get; set; }

            [ParametroDeEntrada]
            public decimal P_CODFISCAL { get; set; }

            [ParametroDeEntrada]
            public string P_TIPO_VENDA { get; set; }

            [ParametroDeEntrada]
            public string P_TIPO_ENTRADA { get; set; }

            [ParametroDeEntrada]
            public string P_CODIGO_OPERACAO { get; set; }
        }
    }

}
