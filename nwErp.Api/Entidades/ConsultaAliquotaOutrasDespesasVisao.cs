namespace nwErp.Api.Entidades;

public class ConsultaAliquotaOutrasDespesasVisao : IVisao
{
	[InfoCampoVisao]
	public string Tipoaliqoutrasdesp { get; set; }

	[InfoCampoVisao]
	public decimal Numtransvenda { get; set; }

	[InfoCampoVisao]
	public string Codfilialnf { get; set; }

	[InfoCampoVisao]
	public decimal Aliquota { get; set; }

	public string SQLConsulta()
	{
		return " SELECT * FROM ( SELECT PCCONSUM.TIPOALIQOUTRASDESP,\r\n         PCNFSAID.NUMTRANSVENDA,\r\n         PCTRIBOUTROS.CODFILIALNF\r\n \r\n       , CASE WHEN PCCONSUM.TIPOALIQOUTRASDESP = 'T'                                       \r\n              THEN NVL(CASE WHEN ((PCCLIENT.TIPOFJ = 'F') AND                              \r\n                                  (NVL(PCCLIENT.UTILIZAIESIMPLIFICADA,'N')    = 'N'))    \r\n                               OR (NVL(PCCLIENT.CONSUMIDORFINAL,'N')          = 'S')     \r\n                               OR ((NVL(PCCONSUM.CONSIDERAISENTOSCOMOPF, 'S') = 'S') AND \r\n                                  ((PCCLIENT.IEENT IS NULL) OR                               \r\n                                   (UPPER(PCCLIENT.IEENT) = 'ISENTO') OR                   \r\n                                   (UPPER(PCCLIENT.IEENT) = 'ISENTA')))                    \r\n                            THEN NVL(PCTRIBOUTROS.ALIQICMOUTRASDESPPF, 0)                    \r\n                            ELSE NVL(PCTRIBOUTROS.ALIQICMOUTRASDESP,   0)                    \r\n                       END,0)                                                                \r\n \r\n              WHEN PCCONSUM.TIPOALIQOUTRASDESP = 'F'                                       \r\n              THEN CASE WHEN (PCFILIAL.UF = PCCLIENT.ESTENT)                                 \r\n                        THEN NVL (PCFILIAL.ALIQICMOUTRASDESP, 0)                             \r\n                        ELSE NVL (PCFILIAL.ALIQICMINTEROUTRASDESP, 0)                        \r\n                   END                                                                       \r\n \r\n              ELSE CASE WHEN (PCFILIAL.UF = PCCLIENT.ESTENT)                                 \r\n                        THEN NVL (PCCONSUM.ALIQICMOUTRASDESP, 0)                             \r\n                        ELSE NVL (PCCONSUM.ALIQICMINTEROUTRASDESP, 0)                        \r\n                   END                                                                       \r\n         END ALIQUOTA                                                                        \r\n         \r\n    FROM PCNFSAID                                                                            \r\n       , PCCLIENT                                                                            \r\n       , PCCONSUM                                                                            \r\n       , PCFILIAL                                                                            \r\n       , PCTRIBOUTROS                                                                        \r\n   WHERE PCCLIENT.CODCLI             = PCNFSAID.CODCLI                                       \r\n     AND PCFILIAL.CODIGO             = PCNFSAID.CODFILIALNF                                  \r\n     AND PCTRIBOUTROS.UFDESTINO(+)   = PCCLIENT.ESTENT )                                     \r\n WHERE 1 = 1 ";
	}

	public IVisao NovaInstancia()
	{
		return (IVisao)GetType().GetConstructors()[0].Invoke(null);
	}
}