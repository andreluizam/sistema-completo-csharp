using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaEmpresarial.Models
{
    public class Entidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Tipo { get; set; }
        public int? GrupoID { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Usuario { get; set; }
        public string? RazaoSocial { get; set; }
        public string? CPFCNPJ { get; set; }
        public string? RGIE { get; set; }
        public string? Fone1 { get; set; }
        public string? Fone2 { get; set; }
        public string? CEP { get; set; }
        public string? Municipio { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Complemento { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Email { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Observacao { get; set; }
    }
}
