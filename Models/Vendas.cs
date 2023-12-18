using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEmpresarial.Models
{
    public class Vendas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public decimal DescontoReais { get; set; }
        public decimal DescontoPercentual { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("ClienteID")]
        public int ClienteID { get; set; }
        [ForeignKey("UsuarioID")]

        public int UsuarioID { get; set; }
        [ForeignKey("FormaPagamentoID")]
        public int FormaPagamentoID { get; set; }
    }
}
