using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaEmpresarial.Models
{
    public class Caixas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Saldo { get; set; }
    }
}
