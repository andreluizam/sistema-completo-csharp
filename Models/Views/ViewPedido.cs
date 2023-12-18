namespace SistemaEmpresarial.Models.Views
{
    public class ViewPedido
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Profissional { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Total { get; set; }
        public DateTime DataEmissao { get; set; }
    }
}
