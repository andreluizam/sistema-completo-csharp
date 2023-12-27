using SistemaEmpresarial.Cadastros.Fornecedores;
using SistemaEmpresarial.Cadastros.Produtos;
using SistemaEmpresarial.Cadastros.Usuarios;
using SistemaEmpresarial.CompraVenda;
using SistemaEmpresarial.Configuracoes;
using SistemaEmpresarial.Contas;
using SistemaEmpresarial.Models;

namespace SistemaEmpresarial
{
    public partial class FrmPrincipal : Form
    {
        private ComumSistema comumSistema;

        private int usuarioID;

        public FrmPrincipal(int usuarioLogadoID)
        {
            InitializeComponent();
            this.usuarioID = usuarioLogadoID;
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            using (Contexto context = new Contexto())
            {
                var carregandoBanco = context.Permissoes.ToList();
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListClientes frmCadastroClientes = new FrmListClientes(usuarioID);
            frmCadastroClientes.ShowInTaskbar = false;
            frmCadastroClientes.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastraUsuarios frmCadastraUsuarios = new FrmCadastraUsuarios(usuarioID);
            frmCadastraUsuarios.ShowInTaskbar = false;
            frmCadastraUsuarios.ShowDialog();
        }

        private void PermissoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermissoes frmPermissoes = new FrmPermissoes(usuarioID);
            frmPermissoes.ShowInTaskbar = false;
            frmPermissoes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListFornecedores frmCadastroFornecedores = new FrmListFornecedores(usuarioID);
            frmCadastroFornecedores.ShowInTaskbar = false;
            frmCadastroFornecedores.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListProdutos frmListProdutos = new FrmListProdutos(usuarioID);
            frmListProdutos.ShowInTaskbar = false;
            frmListProdutos.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaVenda frmNovaVenda = new FrmNovaVenda(usuarioID);
            frmNovaVenda.ShowInTaskbar = false;
            frmNovaVenda.Show();
        }
        private void pedidosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListVendas frmListVendas = new FrmListVendas(usuarioID);
            frmListVendas.ShowInTaskbar = false;
            frmListVendas.Show();
        }

        private void receberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasReceber frmContasReceber = new FrmContasReceber(usuarioID);
            frmContasReceber.Show();
        }

        private void caixasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaixas frmCaixas = new FrmCaixas(usuarioID);
            frmCaixas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja sair do sistema ? ", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }
    }
}

