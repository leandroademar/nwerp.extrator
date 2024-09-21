SELECT ID ID_CAIXA,
        DataAbertura DATAINICIO,
        HoraAberturaTxt HORAINICIO,
        DataFechamento DATAFIM,
        HoraFechamentoTxt HORAFIM,
        USUARIOABERTURA CODIGOUSUARIO,
        UPPER(UsuarioNomeAbertura)USUARIOCAIXA,
        CASE WHEN
            ISNULL((SELECT TOP 1 matricula FROM XFUNCIONARIOS WHERE XFUNCIONARIOS.chapa_rm = ControleCaixa.Funcionario), 0 ) > 0
            THEN (SELECT TOP 1 matricula FROM XFUNCIONARIOS WHERE XFUNCIONARIOS.chapa_rm = ControleCaixa.Funcionario)
            ELSE 3099 END AS MATRICULA,
            0 NUMCAR
    FROM ControleCaixa WHERE DataAbertura >= '01-JUN-2024'