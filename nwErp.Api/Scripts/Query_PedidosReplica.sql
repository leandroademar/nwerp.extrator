SELECT
    T.CODFILIAL,
    T.NUMPED,
    DATA,
    COUNT(DISTINCT T.SITTRIBUT) AS QTPED,
    T.CODUSUR,
    T.CODCLI,
    DIVIDEPED,
    CODCLI_TRIB,
    CODCLI_ST
FROM (
         SELECT
             PCPEDC.CODFILIAL,
             PCPEDC.DATA,
             PCPEDC.NUMPED,
             PCPEDC.CODUSUR,
             PCCLIENT.CODCLI,
             NVL(DIRETORIOCONTRATO,PCCLIENT.CODCLI)CODCLI_TRIB,
             NVL(CODCLIPRINC,PCCLIENT.CODCLI)CODCLI_ST,
             NVL('N','N')DIVIDEPED,
             PCPEDC.POSICAO,
             (SELECT SITTRIBUT FROM PCTRIBUT WHERE PCTRIBUT.CODST = PCPEDI.CODST) SITTRIBUT
         FROM
             PCCLIENT,
             PCPEDC,
             PCPEDI
         WHERE
             PCPEDC.CODFILIAL = '3'
           AND NVL(0,0) = 0
           AND PCPEDI.NUMPED = PCPEDC.NUMPED
           AND PCPEDC.CODCLI = PCCLIENT.CODCLI ) T
WHERE T.DATA >= TRUNC(SYSDATE) - 100
  AND ROWNUM < 10
GROUP BY T.CODFILIAL,T.NUMPED,T.CODCLI,DIVIDEPED,T.CODCLI_TRIB,T.CODCLI_ST,T.DATA,T.CODUSUR