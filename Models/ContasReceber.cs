using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace SistemaEmpresarial.Models
{
    public class ContasReceber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Referente { get; set; }
        public decimal Valor { get; set; }
        public bool Recebida { get; set; }
    }
}
