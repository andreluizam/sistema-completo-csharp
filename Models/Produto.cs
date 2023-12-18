using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEmpresarial.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public string NCM { get; set; }
        public string CodigoBarra { get; set; }
        public decimal Estoque { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorEstoque { get; set; }
        //public DateTime DataCadastro { get; set; }
        //public DateTime DataUltimaVenda { get; set; }
        //public string Observacao { get; set; }
    }
}
