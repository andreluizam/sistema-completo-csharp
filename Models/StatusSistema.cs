using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaEmpresarial.Models
{
    public class StatusSistema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; } // 1 PAGO 0 ABERTO
    }
}
