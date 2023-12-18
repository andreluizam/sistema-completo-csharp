namespace SistemaEmpresarial.Models.Views
{
    public class ViewProdutos
    {
        public int ID { get; set; }
        public string? Descricao { get; set; }
        public string? NCM { get; set; }
        public string? CodigoBarra { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Estoque { get; set; }
        public decimal? ValorEstoque { get; set; }
    }
}
