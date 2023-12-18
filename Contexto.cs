using Microsoft.EntityFrameworkCore;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;

namespace SistemaEmpresarial
{


    public class Contexto : DbContext
    {
        public DbSet<Entidade> Entidade { get; set; }

        public DbSet<Permissoes> Permissoes { get; set; }

        public DbSet<GroupUser> GroupUser { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<ProdutosVenda> ProdutosVendas { get; set; }

        public DbSet<Vendas> Vendas { get; set; }

        public DbSet<FormasPagamento> FormasPagamento { get; set; }

        public DbSet<StatusSistema> StatusSistema { get; set; }

        public DbSet<Caixas> Caixas { get; set; }

        public DbSet<ContasReceber> ContasReceber { get; set; }

        public DbSet<ContasRecebidas> ContasRecebidas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(@"Server=.\SQLEXPRESS;Database=SistemaEmpresarial;User Id=SA;Password=001002;Integrated security=True;Encrypt=False");


        }


        //Views

        public DbSet<ViewEntidade> ViewEntidade { get; set; }

        public DbSet<ViewProdutos> ViewProdutos { get; set; }

        public DbSet<ViewPedido> ViewPedido { get; set; }


    }

}
