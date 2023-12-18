using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Cadastros.Produtos
{
    public partial class FrmCadastrarProduto : Form
    {
        public FrmCadastrarProduto(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }


        #region Variaveis
        List<Entidade> lstEntidade;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUser;

        private int usuarioLogadoID;
        private int grupoID = 0;
        public int _ProdutoID;



        #endregion


        #region Form Events
        private void FrmListProdutos_Load(object sender, EventArgs e)
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    u = context.Entidade.FirstOrDefault(o => o.ID == usuarioLogadoID);
                    grupoID = Convert.ToInt16(u.GrupoID);
                    lstPermissoes = context.Permissoes.ToList();
                    lstGroupUser = context.GroupUser.ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.CadastroProdutos).VISUALIZAR)
                {
                    if (_ProdutoID > 0)
                        TrazProduto();
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para visualizar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
        private void FrmCadastrarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnSalvar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion


        #region Button events
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == 8).INSERIR)
                {
                    if (txtDescricao.Text == "" || txtDescricao.Text == null)
                    {
                        MessageBox.Show("Por favor preencha um nome.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (Contexto context = new Contexto())
                    {
                        Produto p = new Produto();

                        //if (checkAtivo.Checked)
                        //    p.Ativo = true;
                        //else
                        //    p.Ativo = false;

                        p.Descricao = txtDescricao.Text.Trim();
                        p.NCM = txtNCM.Text.Trim();
                        p.CodigoBarra = txtCodigoBarras.Text.Trim();
                        p.Estoque = Convert.ToDecimal(txtEstoque.Text.Trim());
                        p.Valor = Convert.ToDecimal(txtValor.Text.Trim());
                        p.ValorEstoque = Convert.ToDecimal(txtValorEstoque.Text);
                        //p.Observacao = txtObservacao.Text.Trim();
                        context.Add(p);
                        context.SaveChanges();
                        MessageBox.Show("Gravação concluída com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para inserir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar operação entre em contato com o suporte\n Motivo: " + ex.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Functions

        private void TrazProduto()
        {
            using (Contexto context = new Contexto())
            {
                Produto p = new Produto();

                p = context.Produto.FirstOrDefault(o => o.ID == _ProdutoID);

                if (p != null)
                {
                    txtDescricao.Text = p.Descricao;
                    txtNCM.Text = p.NCM;
                    txtCodigoBarras.Text = p.CodigoBarra;
                    txtEstoque.Text = p.Estoque.ToString();
                    txtValor.Text = p.Valor.ToString();
                    txtValorEstoque.Text = p.ValorEstoque.ToString();

                }
            }
        }

        #endregion


    }
}
