using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEmpresarial.Models
{
    public class FormasPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int PrazoDias { get; set; }
        public int IntervaloDias { get; set; }
        public int Parcelas { get; set; }


        [ForeignKey("StatusID")]
        public int StatusID { get; set; }
    }
}
