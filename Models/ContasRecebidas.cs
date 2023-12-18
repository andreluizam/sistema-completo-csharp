using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEmpresarial.Models
{
    public class ContasRecebidas
    {
        public int ID { get; set; }


        [ForeignKey("ContaID")]
        public int ContaID { get; set; }


        [ForeignKey("UsuarioID")]
        public int UsuarioID { get; set; }


        [ForeignKey("FormaPagamentoID")]
        public int FormaPagamentoID { get; set; }

        public string Cliente { get; set; }
        public string Referente { get; set; }
        public decimal Valor { get; set; }

    }
}
