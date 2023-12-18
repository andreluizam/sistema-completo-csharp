using Microsoft.Identity.Client;
using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace SistemaEmpresarial.Cadastros.Produtos
{
    public partial class FrmListProdutos : Form
    {
        public FrmListProdutos(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }


        #region Variáveis

        List<ViewProdutos> FindProdutos;
        List<Entidade> lstEntidades;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUsers;

        private Timer timerBusca;
        private int tempo = 300;
        private int entidadeID = 0;
        private int grupoID = 0;
        private int usuarioLogadoID;
        public bool importando = false;

        public ViewProdutos _ProdutoSelecionado;

        #endregion


        #region Form Events
        private void FrmListProdutos_Load(object sender, EventArgs e)
        {
            timerBusca = new Timer();
            timerBusca.Interval = 100;
            timerBusca.Tick += (s, args) =>
            {
                tempo = tempo - 100;
                if (tempo == 0)
                {
                    var filtro = FindProdutos.Where(o => o.Descricao.ToLower().Contains(txtBusca.Text.ToLower())).Select(o => new { o.ID, o.Descricao, o.NCM, o.CodigoBarra, o.Valor, o.Estoque, o.ValorEstoque }).ToList();
                    gridProdutos.DataSource = filtro;
                    lblQuantidade.Text = filtro.Count + " FORNECEDORES ENCONTRADOS";
                }
            };
            CarregaProdutos();
        }
        private void FrmListProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnNovo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnExcluir_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion


        #region Button Events
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(usuarioLogadoID);
            frmCadastrarProduto.ShowInTaskbar = false;
            frmCadastrarProduto.ShowDialog();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var produto = FindProdutos.FirstOrDefault(o => o.ID == _ProdutoSelecionado.ID);
            using (Contexto context = new Contexto())
            {
                context.Remove(produto);
                context.SaveChanges();
            }
        }
        #endregion


        #region Grid Events

        private void gridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (importando == false)
                {

                    _ProdutoSelecionado = FindProdutos[e.RowIndex];
                    FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(usuarioLogadoID);
                    frmCadastrarProduto._ProdutoID = _ProdutoSelecionado.ID;
                    frmCadastrarProduto.ShowDialog();
                }
                else
                {
                    _ProdutoSelecionado = FindProdutos[e.RowIndex];
                    this.Close();
                }
            }
            catch (Exception)
            { }

        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ProdutoSelecionado = FindProdutos[e.RowIndex];
        }

        #endregion


        #region Text Events

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (!timerBusca.Enabled)
                timerBusca.Start();
            tempo = 300;
        }

        #endregion


        #region Functions

        private void CarregaProdutos()
        {
            BackgroundWorker worker = new BackgroundWorker();
            Entidade u = new Entidade();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    FindProdutos = context.ViewProdutos.ToList();

                    lstEntidades = context.Entidade.ToList();
                    lstPermissoes = context.Permissoes.ToList();
                    lstGroupUsers = context.GroupUser.ToList();

                    u = lstEntidades.FirstOrDefault(o => o.ID == usuarioLogadoID);

                    grupoID = Convert.ToInt16(u.GrupoID);

                    lstGroupUsers.FirstOrDefault(grupo => grupo.ID == u.GrupoID);

                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == u.GrupoID && o.FormID == MeusForms.ListaProdutos).VISUALIZAR)
                {
                    gridProdutos.DataSource = FindProdutos.ToList();
                    lblQuantidade.Text = FindProdutos.Count + " PRODUTOS ENCONTRADOS";
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para visualizar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        #endregion


    }
}