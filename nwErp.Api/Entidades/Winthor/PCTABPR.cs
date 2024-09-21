

////// namespace nwErp.Entidades.Winthor;

// namespace nwErp.Api.Modelos;

[Serializable]
public class PCTABPR : GerenteDePropriedades, IEntidade
{
    private static readonly string RO_ATUALIZAR = "Atualizar";

    private string _atualizar;

    private static readonly string RO_CODPROD = "Codprod";

    private decimal _codprod;

    private static readonly string RO_CODST = "Codst";

    private decimal? _codst;

    private static readonly string RO_CODTRIBPISCOFINS = "Codtribpiscofins";

    private decimal? _codtribpiscofins;

    private static readonly string RO_COTAITEM = "Cotaitem";

    private decimal? _cotaitem;

    private static readonly string RO_COTAITEMTAB = "Cotaitemtab";

    private decimal? _cotaitemtab;

    private static readonly string RO_DESCONTAFRETE = "Descontafrete";

    private string _descontafrete;

    private static readonly string RO_DTEMISSAOETIQ = "Dtemissaoetiq";

    private DateTime? _dtemissaoetiq;

    private static readonly string RO_DTFIMVALIDADE = "Dtfimvalidade";

    private DateTime? _dtfimvalidade;

    private static readonly string RO_DTIMPORTINTEGRACAO = "Dtimportintegracao";

    private DateTime? _dtimportintegracao;

    private static readonly string RO_DTINICIOPTABELA = "Dtinicioptabela";

    private DateTime? _dtinicioptabela;

    private static readonly string RO_DTINICIOVALIDADE = "Dtiniciovalidade";

    private DateTime? _dtiniciovalidade;

    private static readonly string RO_DTULTALTERSRVPRC = "Dtultaltersrvprc";

    private DateTime? _dtultaltersrvprc;

    private static readonly string RO_DTULTALTPTABELA = "Dtultaltptabela";

    private DateTime? _dtultaltptabela;

    private static readonly string RO_DTULTALTPTABELAFUTURO = "Dtultaltptabelafuturo";

    private DateTime? _dtultaltptabelafuturo;

    private static readonly string RO_DTULTALTPVENDA = "Dtultaltpvenda";

    private DateTime? _dtultaltpvenda;

    private static readonly string RO_DTULTATUPVENDA = "Dtultatupvenda";

    private DateTime? _dtultatupvenda;

    private static readonly string RO_DTVALPREVISTA = "Dtvalprevista";

    private DateTime? _dtvalprevista;

    private static readonly string RO_EXCLUIDO = "Excluido";

    private string _excluido;

    private static readonly string RO_INDICEPRECO = "Indicepreco";

    private decimal? _indicepreco;

    private static readonly string RO_MARGEM = "Margem";

    private decimal? _margem;

    private static readonly string RO_MARGEM_ESP = "Margem_Esp";

    private decimal? _margem_esp;

    private static readonly string RO_MATRICULA = "Matricula";

    private decimal? _matricula;

    private static readonly string RO_NUMREGIAO = "Numregiao";

    private decimal _numregiao;

    private static readonly string RO_NUMSEQATU = "Numseqatu";

    private decimal? _numseqatu;

    private static readonly string RO_OBS = "Obs";

    private string _obs;

    private static readonly string RO_PCOMREP1 = "Pcomrep1";

    private decimal? _pcomrep1;

    private static readonly string RO_PCOMREP2 = "Pcomrep2";

    private decimal? _pcomrep2;

    private static readonly string RO_PCOMREP3 = "Pcomrep3";

    private decimal? _pcomrep3;

    private static readonly string RO_PERCACRESCIMOFRETE = "Percacrescimofrete";

    private decimal? _percacrescimofrete;

    private static readonly string RO_PERCCOMGARANTIDA = "Perccomgarantida";

    private decimal? _perccomgarantida;

    private static readonly string RO_PERCCOMGARANTIDATAB = "Perccomgarantidatab";

    private decimal? _perccomgarantidatab;

    private static readonly string RO_PERCDESCSIMPLESNAC = "Percdescsimplesnac";

    private decimal? _percdescsimplesnac;

    private static readonly string RO_PERCIPIVENDATAB = "Percipivendatab";

    private decimal? _percipivendatab;

    private static readonly string RO_PERDESCAUTOR = "Perdescautor";

    private decimal? _perdescautor;

    private static readonly string RO_PERDESCAUTORTAB = "Perdescautortab";

    private decimal? _perdescautortab;

    private static readonly string RO_PERDESCFOB = "Perdescfob";

    private decimal? _perdescfob;

    private static readonly string RO_PERDESCMAX = "Perdescmax";

    private decimal? _perdescmax;

    private static readonly string RO_PERDESCMAXAVISTA = "Perdescmaxavista";

    private decimal? _perdescmaxavista;

    private static readonly string RO_PERDESCMAXAVISTATAB = "Perdescmaxavistatab";

    private decimal? _perdescmaxavistatab;

    private static readonly string RO_PERDESCMAXBALCAO = "Perdescmaxbalcao";

    private decimal? _perdescmaxbalcao;

    private static readonly string RO_PERDESCMAXESP = "Perdescmaxesp";

    private decimal? _perdescmaxesp;

    private static readonly string RO_PERDESCMAXIDEAL = "Perdescmaxideal";

    private decimal? _perdescmaxideal;

    private static readonly string RO_PERDESCMAXIDEALTAB = "Perdescmaxidealtab";

    private decimal? _perdescmaxidealtab;

    private static readonly string RO_PERDESCMAXPOSSIVEL = "Perdescmaxpossivel";

    private decimal? _perdescmaxpossivel;

    private static readonly string RO_PERDESCMAXPOSSIVELTAB = "Perdescmaxpossiveltab";

    private decimal? _perdescmaxpossiveltab;

    private static readonly string RO_PERDESCMAXTAB = "Perdescmaxtab";

    private decimal? _perdescmaxtab;

    private static readonly string RO_PERDESCMAXTABBALCAO = "Perdescmaxtabbalcao";

    private decimal? _perdescmaxtabbalcao;

    private static readonly string RO_PFRETE = "Pfrete";

    private decimal? _pfrete;

    private static readonly string RO_POFERTA = "Poferta";

    private decimal? _poferta;

    private static readonly string RO_POFERTAAUX = "Pofertaaux";

    private decimal? _pofertaaux;

    private static readonly string RO_POFERTATAB = "Pofertatab";

    private decimal? _pofertatab;

    private static readonly string RO_PRECOANTERIORATAC = "Precoanterioratac";

    private decimal? _precoanterioratac;

    private static readonly string RO_PRECOFAB = "Precofab";

    private decimal? _precofab;

    private static readonly string RO_PRECOMAXCONSUM = "Precomaxconsum";

    private decimal? _precomaxconsum;

    private static readonly string RO_PRECOMAXCONSUMTAB = "Precomaxconsumtab";

    private decimal? _precomaxconsumtab;

    private static readonly string RO_PRECOMINIMOTABELA = "Precominimotabela";

    private decimal? _precominimotabela;

    private static readonly string RO_PRECOMINIMOVENDA = "Precominimovenda";

    private decimal? _precominimovenda;

    private static readonly string RO_PRECOREVISTA = "Precorevista";

    private decimal? _precorevista;

    private static readonly string RO_PTABELA = "Ptabela";

    private decimal? _ptabela;

    private static readonly string RO_PTABELAATAC = "Ptabelaatac";

    private decimal? _ptabelaatac;

    private static readonly string RO_PTABELAATAC1 = "Ptabelaatac1";

    private decimal? _ptabelaatac1;

    private static readonly string RO_PTABELAATAC2 = "Ptabelaatac2";

    private decimal? _ptabelaatac2;

    private static readonly string RO_PTABELAATAC3 = "Ptabelaatac3";

    private decimal? _ptabelaatac3;

    private static readonly string RO_PTABELAATAC4 = "Ptabelaatac4";

    private decimal? _ptabelaatac4;

    private static readonly string RO_PTABELAATAC5 = "Ptabelaatac5";

    private decimal? _ptabelaatac5;

    private static readonly string RO_PTABELAATAC6 = "Ptabelaatac6";

    private decimal? _ptabelaatac6;

    private static readonly string RO_PTABELAATAC7 = "Ptabelaatac7";

    private decimal? _ptabelaatac7;

    private static readonly string RO_PTABELAFUTURO = "Ptabelafuturo";

    private decimal? _ptabelafuturo;

    private static readonly string RO_PTABELAMED = "Ptabelamed";

    private decimal? _ptabelamed;

    private static readonly string RO_PTABELAMED1 = "Ptabelamed1";

    private decimal? _ptabelamed1;

    private static readonly string RO_PTABELAMED2 = "Ptabelamed2";

    private decimal? _ptabelamed2;

    private static readonly string RO_PTABELAMED3 = "Ptabelamed3";

    private decimal? _ptabelamed3;

    private static readonly string RO_PTABELAMED4 = "Ptabelamed4";

    private decimal? _ptabelamed4;

    private static readonly string RO_PTABELAMED5 = "Ptabelamed5";

    private decimal? _ptabelamed5;

    private static readonly string RO_PTABELAMED6 = "Ptabelamed6";

    private decimal? _ptabelamed6;

    private static readonly string RO_PTABELAMED7 = "Ptabelamed7";

    private decimal? _ptabelamed7;

    private static readonly string RO_PTABELA1 = "Ptabela1";

    private decimal? _ptabela1;

    private static readonly string RO_PTABELA2 = "Ptabela2";

    private decimal? _ptabela2;

    private static readonly string RO_PTABELA3 = "Ptabela3";

    private decimal? _ptabela3;

    private static readonly string RO_PTABELA4 = "Ptabela4";

    private decimal? _ptabela4;

    private static readonly string RO_PTABELA5 = "Ptabela5";

    private decimal? _ptabela5;

    private static readonly string RO_PTABELA6 = "Ptabela6";

    private decimal? _ptabela6;

    private static readonly string RO_PTABELA7 = "Ptabela7";

    private decimal? _ptabela7;

    private static readonly string RO_PVENDA = "Pvenda";

    private decimal? _pvenda;

    private static readonly string RO_PVENDAATAC = "Pvendaatac";

    private decimal? _pvendaatac;

    private static readonly string RO_PVENDAATAC1 = "Pvendaatac1";

    private decimal? _pvendaatac1;

    private static readonly string RO_PVENDAATAC2 = "Pvendaatac2";

    private decimal? _pvendaatac2;

    private static readonly string RO_PVENDAATAC3 = "Pvendaatac3";

    private decimal? _pvendaatac3;

    private static readonly string RO_PVENDAATAC4 = "Pvendaatac4";

    private decimal? _pvendaatac4;

    private static readonly string RO_PVENDAATAC5 = "Pvendaatac5";

    private decimal? _pvendaatac5;

    private static readonly string RO_PVENDAATAC6 = "Pvendaatac6";

    private decimal? _pvendaatac6;

    private static readonly string RO_PVENDAATAC7 = "Pvendaatac7";

    private decimal? _pvendaatac7;

    private static readonly string RO_PVENDAMED = "Pvendamed";

    private decimal? _pvendamed;

    private static readonly string RO_PVENDAMED1 = "Pvendamed1";

    private decimal? _pvendamed1;

    private static readonly string RO_PVENDAMED2 = "Pvendamed2";

    private decimal? _pvendamed2;

    private static readonly string RO_PVENDAMED3 = "Pvendamed3";

    private decimal? _pvendamed3;

    private static readonly string RO_PVENDAMED4 = "Pvendamed4";

    private decimal? _pvendamed4;

    private static readonly string RO_PVENDAMED5 = "Pvendamed5";

    private decimal? _pvendamed5;

    private static readonly string RO_PVENDAMED6 = "Pvendamed6";

    private decimal? _pvendamed6;

    private static readonly string RO_PVENDAMED7 = "Pvendamed7";

    private decimal? _pvendamed7;

    private static readonly string RO_PVENDA1 = "Pvenda1";

    private decimal? _pvenda1;

    private static readonly string RO_PVENDA2 = "Pvenda2";

    private decimal? _pvenda2;

    private static readonly string RO_PVENDA3 = "Pvenda3";

    private decimal? _pvenda3;

    private static readonly string RO_PVENDA4 = "Pvenda4";

    private decimal? _pvenda4;

    private static readonly string RO_PVENDA5 = "Pvenda5";

    private decimal? _pvenda5;

    private static readonly string RO_PVENDA6 = "Pvenda6";

    private decimal? _pvenda6;

    private static readonly string RO_PVENDA7 = "Pvenda7";

    private decimal? _pvenda7;

    private static readonly string RO_QTDESCAUTOR = "Qtdescautor";

    private decimal? _qtdescautor;

    private static readonly string RO_QTDESCAUTORTAB = "Qtdescautortab";

    private decimal? _qtdescautortab;

    private static readonly string RO_ROTINA = "Rotina";

    private string _rotina;

    private static readonly string RO_TABELAEMITIDA = "Tabelaemitida";

    private string _tabelaemitida;

    private static readonly string RO_VLACRESFRETEKG = "Vlacresfretekg";

    private decimal? _vlacresfretekg;

    private static readonly string RO_VLIPIPORKGVENDATAB = "Vlipiporkgvendatab";

    private decimal? _vlipiporkgvendatab;

    private static readonly string RO_VLPAUTAIPIVENDATAB = "Vlpautaipivendatab";

    private decimal? _vlpautaipivendatab;

    private static readonly string RO_VLST = "Vlst";

    private decimal? _vlst;

    private static readonly string RO_VLSTTAB = "Vlsttab";

    private decimal? _vlsttab;

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Atualizar
    {
        get
        {
            PropriedadeAcessada(RO_ATUALIZAR);
            return _atualizar;
        }
        set
        {
            PropriedadeModificada(RO_ATUALIZAR, value);
            _atualizar = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal Codprod
    {
        get
        {
            PropriedadeAcessada(RO_CODPROD);
            return _codprod;
        }
        set
        {
            PropriedadeModificada(RO_CODPROD, value);
            _codprod = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codst
    {
        get
        {
            PropriedadeAcessada(RO_CODST);
            return _codst;
        }
        set
        {
            PropriedadeModificada(RO_CODST, value);
            _codst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal? Codtribpiscofins
    {
        get
        {
            PropriedadeAcessada(RO_CODTRIBPISCOFINS);
            return _codtribpiscofins;
        }
        set
        {
            PropriedadeModificada(RO_CODTRIBPISCOFINS, value);
            _codtribpiscofins = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Cotaitem
    {
        get
        {
            PropriedadeAcessada(RO_COTAITEM);
            return _cotaitem;
        }
        set
        {
            PropriedadeModificada(RO_COTAITEM, value);
            _cotaitem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Cotaitemtab
    {
        get
        {
            PropriedadeAcessada(RO_COTAITEMTAB);
            return _cotaitemtab;
        }
        set
        {
            PropriedadeModificada(RO_COTAITEMTAB, value);
            _cotaitemtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Descontafrete
    {
        get
        {
            PropriedadeAcessada(RO_DESCONTAFRETE);
            return _descontafrete;
        }
        set
        {
            PropriedadeModificada(RO_DESCONTAFRETE, value);
            _descontafrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtemissaoetiq
    {
        get
        {
            PropriedadeAcessada(RO_DTEMISSAOETIQ);
            return _dtemissaoetiq;
        }
        set
        {
            PropriedadeModificada(RO_DTEMISSAOETIQ, value);
            _dtemissaoetiq = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtfimvalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTFIMVALIDADE);
            return _dtfimvalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTFIMVALIDADE, value);
            _dtfimvalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtimportintegracao
    {
        get
        {
            PropriedadeAcessada(RO_DTIMPORTINTEGRACAO);
            return _dtimportintegracao;
        }
        set
        {
            PropriedadeModificada(RO_DTIMPORTINTEGRACAO, value);
            _dtimportintegracao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtinicioptabela
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIOPTABELA);
            return _dtinicioptabela;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIOPTABELA, value);
            _dtinicioptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtiniciovalidade
    {
        get
        {
            PropriedadeAcessada(RO_DTINICIOVALIDADE);
            return _dtiniciovalidade;
        }
        set
        {
            PropriedadeModificada(RO_DTINICIOVALIDADE, value);
            _dtiniciovalidade = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltersrvprc
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTERSRVPRC);
            return _dtultaltersrvprc;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTERSRVPRC, value);
            _dtultaltersrvprc = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltptabela
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPTABELA);
            return _dtultaltptabela;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPTABELA, value);
            _dtultaltptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltptabelafuturo
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPTABELAFUTURO);
            return _dtultaltptabelafuturo;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPTABELAFUTURO, value);
            _dtultaltptabelafuturo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultaltpvenda
    {
        get
        {
            PropriedadeAcessada(RO_DTULTALTPVENDA);
            return _dtultaltpvenda;
        }
        set
        {
            PropriedadeModificada(RO_DTULTALTPVENDA, value);
            _dtultaltpvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtultatupvenda
    {
        get
        {
            PropriedadeAcessada(RO_DTULTATUPVENDA);
            return _dtultatupvenda;
        }
        set
        {
            PropriedadeModificada(RO_DTULTATUPVENDA, value);
            _dtultatupvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Data, Tamanho = 7, Precisao = 0)]
    public DateTime? Dtvalprevista
    {
        get
        {
            PropriedadeAcessada(RO_DTVALPREVISTA);
            return _dtvalprevista;
        }
        set
        {
            PropriedadeModificada(RO_DTVALPREVISTA, value);
            _dtvalprevista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Excluido
    {
        get
        {
            PropriedadeAcessada(RO_EXCLUIDO);
            return _excluido;
        }
        set
        {
            PropriedadeModificada(RO_EXCLUIDO, value);
            _excluido = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 8)]
    public decimal? Indicepreco
    {
        get
        {
            PropriedadeAcessada(RO_INDICEPRECO);
            return _indicepreco;
        }
        set
        {
            PropriedadeModificada(RO_INDICEPRECO, value);
            _indicepreco = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margem
    {
        get
        {
            PropriedadeAcessada(RO_MARGEM);
            return _margem;
        }
        set
        {
            PropriedadeModificada(RO_MARGEM, value);
            _margem = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Margem_Esp
    {
        get
        {
            PropriedadeAcessada(RO_MARGEM_ESP);
            return _margem_esp;
        }
        set
        {
            PropriedadeModificada(RO_MARGEM_ESP, value);
            _margem_esp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 0)]
    public decimal? Matricula
    {
        get
        {
            PropriedadeAcessada(RO_MATRICULA);
            return _matricula;
        }
        set
        {
            PropriedadeModificada(RO_MATRICULA, value);
            _matricula = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = true, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 4, Precisao = 0)]
    public decimal Numregiao
    {
        get
        {
            PropriedadeAcessada(RO_NUMREGIAO);
            return _numregiao;
        }
        set
        {
            PropriedadeModificada(RO_NUMREGIAO, value);
            _numregiao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 0, Precisao = 0)]
    public decimal? Numseqatu
    {
        get
        {
            PropriedadeAcessada(RO_NUMSEQATU);
            return _numseqatu;
        }
        set
        {
            PropriedadeModificada(RO_NUMSEQATU, value);
            _numseqatu = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 80, Precisao = 0)]
    public string Obs
    {
        get
        {
            PropriedadeAcessada(RO_OBS);
            return _obs;
        }
        set
        {
            PropriedadeModificada(RO_OBS, value);
            _obs = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep1
    {
        get
        {
            PropriedadeAcessada(RO_PCOMREP1);
            return _pcomrep1;
        }
        set
        {
            PropriedadeModificada(RO_PCOMREP1, value);
            _pcomrep1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep2
    {
        get
        {
            PropriedadeAcessada(RO_PCOMREP2);
            return _pcomrep2;
        }
        set
        {
            PropriedadeModificada(RO_PCOMREP2, value);
            _pcomrep2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 2)]
    public decimal? Pcomrep3
    {
        get
        {
            PropriedadeAcessada(RO_PCOMREP3);
            return _pcomrep3;
        }
        set
        {
            PropriedadeModificada(RO_PCOMREP3, value);
            _pcomrep3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 8, Precisao = 2)]
    public decimal? Percacrescimofrete
    {
        get
        {
            PropriedadeAcessada(RO_PERCACRESCIMOFRETE);
            return _percacrescimofrete;
        }
        set
        {
            PropriedadeModificada(RO_PERCACRESCIMOFRETE, value);
            _percacrescimofrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perccomgarantida
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMGARANTIDA);
            return _perccomgarantida;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMGARANTIDA, value);
            _perccomgarantida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perccomgarantidatab
    {
        get
        {
            PropriedadeAcessada(RO_PERCCOMGARANTIDATAB);
            return _perccomgarantidatab;
        }
        set
        {
            PropriedadeModificada(RO_PERCCOMGARANTIDATAB, value);
            _perccomgarantidatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percdescsimplesnac
    {
        get
        {
            PropriedadeAcessada(RO_PERCDESCSIMPLESNAC);
            return _percdescsimplesnac;
        }
        set
        {
            PropriedadeModificada(RO_PERCDESCSIMPLESNAC, value);
            _percdescsimplesnac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Percipivendatab
    {
        get
        {
            PropriedadeAcessada(RO_PERCIPIVENDATAB);
            return _percipivendatab;
        }
        set
        {
            PropriedadeModificada(RO_PERCIPIVENDATAB, value);
            _percipivendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perdescautor
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCAUTOR);
            return _perdescautor;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCAUTOR, value);
            _perdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perdescautortab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCAUTORTAB);
            return _perdescautortab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCAUTORTAB, value);
            _perdescautortab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 5, Precisao = 2)]
    public decimal? Perdescfob
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCFOB);
            return _perdescfob;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCFOB, value);
            _perdescfob = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmax
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAX);
            return _perdescmax;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAX, value);
            _perdescmax = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxavista
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXAVISTA);
            return _perdescmaxavista;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXAVISTA, value);
            _perdescmaxavista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxavistatab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXAVISTATAB);
            return _perdescmaxavistatab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXAVISTATAB, value);
            _perdescmaxavistatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxbalcao
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXBALCAO);
            return _perdescmaxbalcao;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXBALCAO, value);
            _perdescmaxbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 3)]
    public decimal? Perdescmaxesp
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXESP);
            return _perdescmaxesp;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXESP, value);
            _perdescmaxesp = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxideal
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXIDEAL);
            return _perdescmaxideal;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXIDEAL, value);
            _perdescmaxideal = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxidealtab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXIDEALTAB);
            return _perdescmaxidealtab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXIDEALTAB, value);
            _perdescmaxidealtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxpossivel
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXPOSSIVEL);
            return _perdescmaxpossivel;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXPOSSIVEL, value);
            _perdescmaxpossivel = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxpossiveltab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXPOSSIVELTAB);
            return _perdescmaxpossiveltab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXPOSSIVELTAB, value);
            _perdescmaxpossiveltab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxtab
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXTAB);
            return _perdescmaxtab;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXTAB, value);
            _perdescmaxtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 2)]
    public decimal? Perdescmaxtabbalcao
    {
        get
        {
            PropriedadeAcessada(RO_PERDESCMAXTABBALCAO);
            return _perdescmaxtabbalcao;
        }
        set
        {
            PropriedadeModificada(RO_PERDESCMAXTABBALCAO, value);
            _perdescmaxtabbalcao = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 10, Precisao = 4)]
    public decimal? Pfrete
    {
        get
        {
            PropriedadeAcessada(RO_PFRETE);
            return _pfrete;
        }
        set
        {
            PropriedadeModificada(RO_PFRETE, value);
            _pfrete = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Poferta
    {
        get
        {
            PropriedadeAcessada(RO_POFERTA);
            return _poferta;
        }
        set
        {
            PropriedadeModificada(RO_POFERTA, value);
            _poferta = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pofertaaux
    {
        get
        {
            PropriedadeAcessada(RO_POFERTAAUX);
            return _pofertaaux;
        }
        set
        {
            PropriedadeModificada(RO_POFERTAAUX, value);
            _pofertaaux = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pofertatab
    {
        get
        {
            PropriedadeAcessada(RO_POFERTATAB);
            return _pofertatab;
        }
        set
        {
            PropriedadeModificada(RO_POFERTATAB, value);
            _pofertatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precoanterioratac
    {
        get
        {
            PropriedadeAcessada(RO_PRECOANTERIORATAC);
            return _precoanterioratac;
        }
        set
        {
            PropriedadeModificada(RO_PRECOANTERIORATAC, value);
            _precoanterioratac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precofab
    {
        get
        {
            PropriedadeAcessada(RO_PRECOFAB);
            return _precofab;
        }
        set
        {
            PropriedadeModificada(RO_PRECOFAB, value);
            _precofab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsum
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUM);
            return _precomaxconsum;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUM, value);
            _precomaxconsum = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precomaxconsumtab
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMAXCONSUMTAB);
            return _precomaxconsumtab;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMAXCONSUMTAB, value);
            _precomaxconsumtab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Precominimotabela
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMINIMOTABELA);
            return _precominimotabela;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMINIMOTABELA, value);
            _precominimotabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Precominimovenda
    {
        get
        {
            PropriedadeAcessada(RO_PRECOMINIMOVENDA);
            return _precominimovenda;
        }
        set
        {
            PropriedadeModificada(RO_PRECOMINIMOVENDA, value);
            _precominimovenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Precorevista
    {
        get
        {
            PropriedadeAcessada(RO_PRECOREVISTA);
            return _precorevista;
        }
        set
        {
            PropriedadeModificada(RO_PRECOREVISTA, value);
            _precorevista = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA);
            return _ptabela;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA, value);
            _ptabela = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC);
            return _ptabelaatac;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC, value);
            _ptabelaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac1
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC1);
            return _ptabelaatac1;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC1, value);
            _ptabelaatac1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac2
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC2);
            return _ptabelaatac2;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC2, value);
            _ptabelaatac2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac3
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC3);
            return _ptabelaatac3;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC3, value);
            _ptabelaatac3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac4
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC4);
            return _ptabelaatac4;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC4, value);
            _ptabelaatac4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac5
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC5);
            return _ptabelaatac5;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC5, value);
            _ptabelaatac5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac6
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC6);
            return _ptabelaatac6;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC6, value);
            _ptabelaatac6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabelaatac7
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAATAC7);
            return _ptabelaatac7;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAATAC7, value);
            _ptabelaatac7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelafuturo
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAFUTURO);
            return _ptabelafuturo;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAFUTURO, value);
            _ptabelafuturo = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED);
            return _ptabelamed;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED, value);
            _ptabelamed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed1
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED1);
            return _ptabelamed1;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED1, value);
            _ptabelamed1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed2
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED2);
            return _ptabelamed2;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED2, value);
            _ptabelamed2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed3
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED3);
            return _ptabelamed3;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED3, value);
            _ptabelamed3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed4
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED4);
            return _ptabelamed4;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED4, value);
            _ptabelamed4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed5
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED5);
            return _ptabelamed5;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED5, value);
            _ptabelamed5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed6
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED6);
            return _ptabelamed6;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED6, value);
            _ptabelamed6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Ptabelamed7
    {
        get
        {
            PropriedadeAcessada(RO_PTABELAMED7);
            return _ptabelamed7;
        }
        set
        {
            PropriedadeModificada(RO_PTABELAMED7, value);
            _ptabelamed7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela1
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA1);
            return _ptabela1;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA1, value);
            _ptabela1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela2
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA2);
            return _ptabela2;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA2, value);
            _ptabela2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela3
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA3);
            return _ptabela3;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA3, value);
            _ptabela3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela4
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA4);
            return _ptabela4;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA4, value);
            _ptabela4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela5
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA5);
            return _ptabela5;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA5, value);
            _ptabela5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela6
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA6);
            return _ptabela6;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA6, value);
            _ptabela6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Ptabela7
    {
        get
        {
            PropriedadeAcessada(RO_PTABELA7);
            return _ptabela7;
        }
        set
        {
            PropriedadeModificada(RO_PTABELA7, value);
            _ptabela7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA);
            return _pvenda;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA, value);
            _pvenda = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC);
            return _pvendaatac;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC, value);
            _pvendaatac = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac1
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC1);
            return _pvendaatac1;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC1, value);
            _pvendaatac1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac2
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC2);
            return _pvendaatac2;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC2, value);
            _pvendaatac2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac3
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC3);
            return _pvendaatac3;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC3, value);
            _pvendaatac3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac4
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC4);
            return _pvendaatac4;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC4, value);
            _pvendaatac4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac5
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC5);
            return _pvendaatac5;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC5, value);
            _pvendaatac5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac6
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC6);
            return _pvendaatac6;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC6, value);
            _pvendaatac6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvendaatac7
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAATAC7);
            return _pvendaatac7;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAATAC7, value);
            _pvendaatac7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED);
            return _pvendamed;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED, value);
            _pvendamed = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed1
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED1);
            return _pvendamed1;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED1, value);
            _pvendamed1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed2
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED2);
            return _pvendamed2;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED2, value);
            _pvendamed2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed3
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED3);
            return _pvendamed3;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED3, value);
            _pvendamed3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed4
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED4);
            return _pvendamed4;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED4, value);
            _pvendamed4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed5
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED5);
            return _pvendamed5;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED5, value);
            _pvendamed5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed6
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED6);
            return _pvendamed6;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED6, value);
            _pvendamed6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 3)]
    public decimal? Pvendamed7
    {
        get
        {
            PropriedadeAcessada(RO_PVENDAMED7);
            return _pvendamed7;
        }
        set
        {
            PropriedadeModificada(RO_PVENDAMED7, value);
            _pvendamed7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda1
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA1);
            return _pvenda1;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA1, value);
            _pvenda1 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda2
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA2);
            return _pvenda2;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA2, value);
            _pvenda2 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda3
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA3);
            return _pvenda3;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA3, value);
            _pvenda3 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda4
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA4);
            return _pvenda4;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA4, value);
            _pvenda4 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda5
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA5);
            return _pvenda5;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA5, value);
            _pvenda5 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda6
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA6);
            return _pvenda6;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA6, value);
            _pvenda6 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Pvenda7
    {
        get
        {
            PropriedadeAcessada(RO_PVENDA7);
            return _pvenda7;
        }
        set
        {
            PropriedadeModificada(RO_PVENDA7, value);
            _pvenda7 = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdescautor
    {
        get
        {
            PropriedadeAcessada(RO_QTDESCAUTOR);
            return _qtdescautor;
        }
        set
        {
            PropriedadeModificada(RO_QTDESCAUTOR, value);
            _qtdescautor = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 6, Precisao = 0)]
    public decimal? Qtdescautortab
    {
        get
        {
            PropriedadeAcessada(RO_QTDESCAUTORTAB);
            return _qtdescautortab;
        }
        set
        {
            PropriedadeModificada(RO_QTDESCAUTORTAB, value);
            _qtdescautortab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 15, Precisao = 0)]
    public string Rotina
    {
        get
        {
            PropriedadeAcessada(RO_ROTINA);
            return _rotina;
        }
        set
        {
            PropriedadeModificada(RO_ROTINA, value);
            _rotina = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Texto, Tamanho = 1, Precisao = 0)]
    public string Tabelaemitida
    {
        get
        {
            PropriedadeAcessada(RO_TABELAEMITIDA);
            return _tabelaemitida;
        }
        set
        {
            PropriedadeModificada(RO_TABELAEMITIDA, value);
            _tabelaemitida = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 12, Precisao = 6)]
    public decimal? Vlacresfretekg
    {
        get
        {
            PropriedadeAcessada(RO_VLACRESFRETEKG);
            return _vlacresfretekg;
        }
        set
        {
            PropriedadeModificada(RO_VLACRESFRETEKG, value);
            _vlacresfretekg = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlipiporkgvendatab
    {
        get
        {
            PropriedadeAcessada(RO_VLIPIPORKGVENDATAB);
            return _vlipiporkgvendatab;
        }
        set
        {
            PropriedadeModificada(RO_VLIPIPORKGVENDATAB, value);
            _vlipiporkgvendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlpautaipivendatab
    {
        get
        {
            PropriedadeAcessada(RO_VLPAUTAIPIVENDATAB);
            return _vlpautaipivendatab;
        }
        set
        {
            PropriedadeModificada(RO_VLPAUTAIPIVENDATAB, value);
            _vlpautaipivendatab = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlst
    {
        get
        {
            PropriedadeAcessada(RO_VLST);
            return _vlst;
        }
        set
        {
            PropriedadeModificada(RO_VLST, value);
            _vlst = value;
        }
    }

    [InfoCampoEntidade(ChavePrimaria = false, Tabela = "PCTABPR", Tipo = TipoDoCampoNoBancoDeDados.Decimal, Tamanho = 18, Precisao = 6)]
    public decimal? Vlsttab
    {
        get
        {
            PropriedadeAcessada(RO_VLSTTAB);
            return _vlsttab;
        }
        set
        {
            PropriedadeModificada(RO_VLSTTAB, value);
            _vlsttab = value;
        }
    }

    public void InicializarAtributos()
    {
    }

    public string ObterNomeTabela()
    {
        return "PCTABPR";
    }

    public IEntidade NovaInstancia()
    {
        return (IEntidade)GetType().GetConstructors()[0].Invoke(null);
    }

    public void CarregarPorDataReader(IDataReader leitor)
    {
        _atualizar = AlterarTipo<string>(leitor["Atualizar"]);
        _codprod = AlterarTipo<decimal>(leitor["Codprod"]);
        _codst = AlterarTipo<decimal?>(leitor["Codst"]);
        _codtribpiscofins = AlterarTipo<decimal?>(leitor["Codtribpiscofins"]);
        _cotaitem = AlterarTipo<decimal?>(leitor["Cotaitem"]);
        _cotaitemtab = AlterarTipo<decimal?>(leitor["Cotaitemtab"]);
        _descontafrete = AlterarTipo<string>(leitor["Descontafrete"]);
        _dtemissaoetiq = AlterarTipo<DateTime?>(leitor["Dtemissaoetiq"]);
        _dtfimvalidade = AlterarTipo<DateTime?>(leitor["Dtfimvalidade"]);
        _dtimportintegracao = AlterarTipo<DateTime?>(leitor["Dtimportintegracao"]);
        _dtinicioptabela = AlterarTipo<DateTime?>(leitor["Dtinicioptabela"]);
        _dtiniciovalidade = AlterarTipo<DateTime?>(leitor["Dtiniciovalidade"]);
        _dtultaltersrvprc = AlterarTipo<DateTime?>(leitor["Dtultaltersrvprc"]);
        _dtultaltptabela = AlterarTipo<DateTime?>(leitor["Dtultaltptabela"]);
        _dtultaltptabelafuturo = AlterarTipo<DateTime?>(leitor["Dtultaltptabelafuturo"]);
        _dtultaltpvenda = AlterarTipo<DateTime?>(leitor["Dtultaltpvenda"]);
        _dtultatupvenda = AlterarTipo<DateTime?>(leitor["Dtultatupvenda"]);
        _dtvalprevista = AlterarTipo<DateTime?>(leitor["Dtvalprevista"]);
        _excluido = AlterarTipo<string>(leitor["Excluido"]);
        _indicepreco = AlterarTipo<decimal?>(leitor["Indicepreco"]);
        _margem = AlterarTipo<decimal?>(leitor["Margem"]);
        _margem_esp = AlterarTipo<decimal?>(leitor["Margem_Esp"]);
        _matricula = AlterarTipo<decimal?>(leitor["Matricula"]);
        _numregiao = AlterarTipo<decimal>(leitor["Numregiao"]);
        _numseqatu = AlterarTipo<decimal?>(leitor["Numseqatu"]);
        _obs = AlterarTipo<string>(leitor["Obs"]);
        _pcomrep1 = AlterarTipo<decimal?>(leitor["Pcomrep1"]);
        _pcomrep2 = AlterarTipo<decimal?>(leitor["Pcomrep2"]);
        _pcomrep3 = AlterarTipo<decimal?>(leitor["Pcomrep3"]);
        _percacrescimofrete = AlterarTipo<decimal?>(leitor["Percacrescimofrete"]);
        _perccomgarantida = AlterarTipo<decimal?>(leitor["Perccomgarantida"]);
        _perccomgarantidatab = AlterarTipo<decimal?>(leitor["Perccomgarantidatab"]);
        _percdescsimplesnac = AlterarTipo<decimal?>(leitor["Percdescsimplesnac"]);
        _percipivendatab = AlterarTipo<decimal?>(leitor["Percipivendatab"]);
        _perdescautor = AlterarTipo<decimal?>(leitor["Perdescautor"]);
        _perdescautortab = AlterarTipo<decimal?>(leitor["Perdescautortab"]);
        _perdescfob = AlterarTipo<decimal?>(leitor["Perdescfob"]);
        _perdescmax = AlterarTipo<decimal?>(leitor["Perdescmax"]);
        _perdescmaxavista = AlterarTipo<decimal?>(leitor["Perdescmaxavista"]);
        _perdescmaxavistatab = AlterarTipo<decimal?>(leitor["Perdescmaxavistatab"]);
        _perdescmaxbalcao = AlterarTipo<decimal?>(leitor["Perdescmaxbalcao"]);
        _perdescmaxesp = AlterarTipo<decimal?>(leitor["Perdescmaxesp"]);
        _perdescmaxideal = AlterarTipo<decimal?>(leitor["Perdescmaxideal"]);
        _perdescmaxidealtab = AlterarTipo<decimal?>(leitor["Perdescmaxidealtab"]);
        _perdescmaxpossivel = AlterarTipo<decimal?>(leitor["Perdescmaxpossivel"]);
        _perdescmaxpossiveltab = AlterarTipo<decimal?>(leitor["Perdescmaxpossiveltab"]);
        _perdescmaxtab = AlterarTipo<decimal?>(leitor["Perdescmaxtab"]);
        _perdescmaxtabbalcao = AlterarTipo<decimal?>(leitor["Perdescmaxtabbalcao"]);
        _pfrete = AlterarTipo<decimal?>(leitor["Pfrete"]);
        _poferta = AlterarTipo<decimal?>(leitor["Poferta"]);
        _pofertaaux = AlterarTipo<decimal?>(leitor["Pofertaaux"]);
        _pofertatab = AlterarTipo<decimal?>(leitor["Pofertatab"]);
        _precoanterioratac = AlterarTipo<decimal?>(leitor["Precoanterioratac"]);
        _precofab = AlterarTipo<decimal?>(leitor["Precofab"]);
        _precomaxconsum = AlterarTipo<decimal?>(leitor["Precomaxconsum"]);
        _precomaxconsumtab = AlterarTipo<decimal?>(leitor["Precomaxconsumtab"]);
        _precominimotabela = AlterarTipo<decimal?>(leitor["Precominimotabela"]);
        _precominimovenda = AlterarTipo<decimal?>(leitor["Precominimovenda"]);
        _precorevista = AlterarTipo<decimal?>(leitor["Precorevista"]);
        _ptabela = AlterarTipo<decimal?>(leitor["Ptabela"]);
        _ptabelaatac = AlterarTipo<decimal?>(leitor["Ptabelaatac"]);
        _ptabelaatac1 = AlterarTipo<decimal?>(leitor["Ptabelaatac1"]);
        _ptabelaatac2 = AlterarTipo<decimal?>(leitor["Ptabelaatac2"]);
        _ptabelaatac3 = AlterarTipo<decimal?>(leitor["Ptabelaatac3"]);
        _ptabelaatac4 = AlterarTipo<decimal?>(leitor["Ptabelaatac4"]);
        _ptabelaatac5 = AlterarTipo<decimal?>(leitor["Ptabelaatac5"]);
        _ptabelaatac6 = AlterarTipo<decimal?>(leitor["Ptabelaatac6"]);
        _ptabelaatac7 = AlterarTipo<decimal?>(leitor["Ptabelaatac7"]);
        _ptabelafuturo = AlterarTipo<decimal?>(leitor["Ptabelafuturo"]);
        _ptabelamed = AlterarTipo<decimal?>(leitor["Ptabelamed"]);
        _ptabelamed1 = AlterarTipo<decimal?>(leitor["Ptabelamed1"]);
        _ptabelamed2 = AlterarTipo<decimal?>(leitor["Ptabelamed2"]);
        _ptabelamed3 = AlterarTipo<decimal?>(leitor["Ptabelamed3"]);
        _ptabelamed4 = AlterarTipo<decimal?>(leitor["Ptabelamed4"]);
        _ptabelamed5 = AlterarTipo<decimal?>(leitor["Ptabelamed5"]);
        _ptabelamed6 = AlterarTipo<decimal?>(leitor["Ptabelamed6"]);
        _ptabelamed7 = AlterarTipo<decimal?>(leitor["Ptabelamed7"]);
        _ptabela1 = AlterarTipo<decimal?>(leitor["Ptabela1"]);
        _ptabela2 = AlterarTipo<decimal?>(leitor["Ptabela2"]);
        _ptabela3 = AlterarTipo<decimal?>(leitor["Ptabela3"]);
        _ptabela4 = AlterarTipo<decimal?>(leitor["Ptabela4"]);
        _ptabela5 = AlterarTipo<decimal?>(leitor["Ptabela5"]);
        _ptabela6 = AlterarTipo<decimal?>(leitor["Ptabela6"]);
        _ptabela7 = AlterarTipo<decimal?>(leitor["Ptabela7"]);
        _pvenda = AlterarTipo<decimal?>(leitor["Pvenda"]);
        _pvendaatac = AlterarTipo<decimal?>(leitor["Pvendaatac"]);
        _pvendaatac1 = AlterarTipo<decimal?>(leitor["Pvendaatac1"]);
        _pvendaatac2 = AlterarTipo<decimal?>(leitor["Pvendaatac2"]);
        _pvendaatac3 = AlterarTipo<decimal?>(leitor["Pvendaatac3"]);
        _pvendaatac4 = AlterarTipo<decimal?>(leitor["Pvendaatac4"]);
        _pvendaatac5 = AlterarTipo<decimal?>(leitor["Pvendaatac5"]);
        _pvendaatac6 = AlterarTipo<decimal?>(leitor["Pvendaatac6"]);
        _pvendaatac7 = AlterarTipo<decimal?>(leitor["Pvendaatac7"]);
        _pvendamed = AlterarTipo<decimal?>(leitor["Pvendamed"]);
        _pvendamed1 = AlterarTipo<decimal?>(leitor["Pvendamed1"]);
        _pvendamed2 = AlterarTipo<decimal?>(leitor["Pvendamed2"]);
        _pvendamed3 = AlterarTipo<decimal?>(leitor["Pvendamed3"]);
        _pvendamed4 = AlterarTipo<decimal?>(leitor["Pvendamed4"]);
        _pvendamed5 = AlterarTipo<decimal?>(leitor["Pvendamed5"]);
        _pvendamed6 = AlterarTipo<decimal?>(leitor["Pvendamed6"]);
        _pvendamed7 = AlterarTipo<decimal?>(leitor["Pvendamed7"]);
        _pvenda1 = AlterarTipo<decimal?>(leitor["Pvenda1"]);
        _pvenda2 = AlterarTipo<decimal?>(leitor["Pvenda2"]);
        _pvenda3 = AlterarTipo<decimal?>(leitor["Pvenda3"]);
        _pvenda4 = AlterarTipo<decimal?>(leitor["Pvenda4"]);
        _pvenda5 = AlterarTipo<decimal?>(leitor["Pvenda5"]);
        _pvenda6 = AlterarTipo<decimal?>(leitor["Pvenda6"]);
        _pvenda7 = AlterarTipo<decimal?>(leitor["Pvenda7"]);
        _qtdescautor = AlterarTipo<decimal?>(leitor["Qtdescautor"]);
        _qtdescautortab = AlterarTipo<decimal?>(leitor["Qtdescautortab"]);
        _rotina = AlterarTipo<string>(leitor["Rotina"]);
        _tabelaemitida = AlterarTipo<string>(leitor["Tabelaemitida"]);
        _vlacresfretekg = AlterarTipo<decimal?>(leitor["Vlacresfretekg"]);
        _vlipiporkgvendatab = AlterarTipo<decimal?>(leitor["Vlipiporkgvendatab"]);
        _vlpautaipivendatab = AlterarTipo<decimal?>(leitor["Vlpautaipivendatab"]);
        _vlst = AlterarTipo<decimal?>(leitor["Vlst"]);
        _vlsttab = AlterarTipo<decimal?>(leitor["Vlsttab"]);
    }

}