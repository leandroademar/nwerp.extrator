using System.ComponentModel.DataAnnotations;

#nullable disable
namespace nwErp.Api.Entidades;

public class Script : BaseEntity<Script>
  {
    [Required(AllowEmptyStrings = false, ErrorMessage = "Tabela: Campo com preenchimento obrigatório.")]
    public string Tabela { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Script_Sql: Campo com preenchimento obrigatório.")]
    public string Script_Sql { get; set; }

    public int Versao { get; set; }

    public string Objeto { get; set; }

    public string Tipo { get; set; }

    public int Ordem { get; set; }

    public bool Ativo { get; set; }
  }
