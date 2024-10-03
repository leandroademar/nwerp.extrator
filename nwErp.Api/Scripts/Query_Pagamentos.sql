SELECT PG.ID AS IDPAG,
        CR.ID AS IDCR,
        NUMERO,
        CR.DESCRICAO,
        EMISSAO,
        CR.VALOR,
        DESCONTO,
        ACRESCIMO,
        PG.VALORCOVER,
        TIPOTITULO,
        CR.BANDEIRA,
        ISNULL(NSU,0) as NSU,
        PEDIDO,
        CONTROLECAIXA,
        CR.FUNCIONARIO,
        NOTAFISCAL,
        ISNULL((SELECT xc.CodCob FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.CodCob FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = tp.Id),'DH')) as CODCOB, 
        ISNULL((SELECT xc.COBSEFAZ FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.COBSEFAZ FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = tp.Id),'99')) as COBSEFAZ, 
        ISNULL((SELECT xc.CODADMCARTAO FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.CODADMCARTAO FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = PG.Id),' ')) as CODADMCARTAO, 
        ISNULL((SELECT xc.TIPOOPERACAOTEF FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.TIPOOPERACAOTEF FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = PG.Id),' ')) as TIPOOPERACAOTEF, 
        ISNULL((SELECT xc.CODBANDEIRATEF FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.CODBANDEIRATEF FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = PG.Id),' ')) as CODBANDEIRATEF,
        (EMISSAO + ISNULL((SELECT xc.DIASVENC FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.DIASVENC FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = tp.Id),0))) as DTVENC,
        ISNULL((SELECT xc.DIASVENC FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.IdPag = tp.Id and xc.IdBandeira = cr.Bandeira),ISNULL((SELECT xc.DIASVENC FROM terrazzo.dbo.XCOBRANCA xc WHERE xc.Id = tp.Id),0)) AS DIAS
        FROM terrazzo.dbo.ContasReceber CR,
            terrazzo.dbo.Pagamentos PG,
            terrazzo.dbo.tipopagamento tp
        WHERE PG.ContaReceber = CR.ID 
        AND PG.TipoPagamento = tp.Id
        AND PG.TipoPagamento <> 11
        AND PG.Nfce = @codNotaFiscal  