using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaEmpresarial.Models
{
    public class ProdutosVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Subtotal { get; set; }

        [ForeignKey("ProdutoID")]
        public int ProdutoID { get; set; }

        [ForeignKey("VendaID")]
        public int VendaID { get; set; }
    }
}
