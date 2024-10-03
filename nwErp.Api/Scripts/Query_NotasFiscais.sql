SELECT 
    ID,
    NUMERONF AS NUMNOTA,
    SerieNF AS SERIE,
    CASE WHEN ISNULL((SELECT MAX(ControleCaixa) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id), 0) > 0
        THEN (SELECT MAX(ControleCaixa) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id)
        ELSE 0 END AS ID_CONTROLECAIXA,
    CASE WHEN ISNULL((SELECT MAX(Id) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id), 0) > 0
        THEN (SELECT MAX(Id) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id)
        ELSE 0 END AS ID_CONTARECEBER,
    CASE WHEN ISNULL((SELECT COUNT(Id) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id), 0) > 0
        THEN (SELECT COUNT(Id) FROM ContasReceber WHERE ContasReceber.NotaFiscal = NotaFiscal.Id)
        ELSE 0 END AS QTD_CONTARECEBER,
    CASE MODELO WHEN 0 
    THEN 55 ELSE 65 END AS MODNFE,
    DataEmissao AS DTSAIDA,
    Protocolo AS PROTOCOLONFE,
    CodigoStatus AS SITUACAONFE,
    DataCancelamento AS DTCANCEL,
    MensagemRetorno AS MENSAGEMRETORNO,
    Ativo AS ATIVA,
    ISNULL(PendenteRetorno,0) AS PENDENTE,
    ISNULL(Inutilizada,0) AS INUTILIZADA
FROM NotaFiscal 
WHERE DataEmissao >= '01-JUL-2024';