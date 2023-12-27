using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Contas
{
    public partial class FrmCaixas : Form
    {
        public FrmCaixas(int usuarioID)
        {
            InitializeComponent();
            usuarioLogadoID = usuarioID;
        }


        #region Variáveis 
        List<Caixas> lstCaixas;
        List<Permissoes> lstPermissoes;

        private int usuarioLogadoID = 0;
        private int caixaID = 0;
        private int grupoID = 0;
        #endregion


        #region Propriedades
        private Caixas _CaixaSelecionado;
        #endregion


        #region Form Events
        private void FrmCaixas_Load(object sender, EventArgs e)
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    u = context.Entidade.FirstOrDefault(o => o.ID == usuarioLogadoID);
                    grupoID = Convert.ToInt16(u.GrupoID);
                    lstCaixas = context.Caixas.ToList();
                    lstPermissoes = context.Permissoes.ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.CadastroCaixas).VISUALIZAR)
                {
                    gridCaixas.DataSource = lstCaixas.ToList();
                    lblQuantidade.Text = lstCaixas.Count + " CAIXAS ENCONTRADOS";
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
        private void FrmCaixas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                btnNovo_Click(sender, e);
            else if (e.KeyCode == Keys.F2)
                btnSalvar_Click(sender, e);
            else if (e.KeyCode == Keys.Delete)
                btnExcluir_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        #endregion


        #region Control Events

        #region Button Events

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.CadastroCaixas).INSERIR)
                {
                    Caixas caixa;
                    using (Contexto context = new Contexto())
                    {
                        if (caixaID > 0)
                        {
                            caixa = lstCaixas.FirstOrDefault(o => o.ID == caixaID);
                        }
                        else
                        {
                            caixa = new Caixas();
                        }

                        caixa.Descricao = txtCaixa.Text;
                        caixa.Saldo = Convert.ToDecimal(txtSaldo.Text);

                        if (caixaID > 0)
                        {
                            context.Update(caixa);
                            context.SaveChanges();
                            MessageBox.Show("Alteração efetuado com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            context.Add(caixa);
                            context.SaveChanges();
                            MessageBox.Show("Cadastro efetuado com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para inserir novos caixas", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao salvar as mudanças", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCaixa.Clear();
            txtSaldo.Clear();
            txtSaldo.Enabled = true;
            caixaID = 0;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            using (Contexto context = new Contexto())
            {
                if (caixaID > 0)
                {
                    Caixas caixa = lstCaixas.FirstOrDefault(o => o.ID == caixaID);

                    context.Remove(caixa);
                    context.SaveChanges();
                    MessageBox.Show("Exclusão efetuado com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion


        #region Grid Events
        private void gridCaixas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _CaixaSelecionado = lstCaixas[e.RowIndex];

            if (_CaixaSelecionado != null)
            {
                caixaID = _CaixaSelecionado.ID;
                txtCaixa.Text = _CaixaSelecionado.Descricao;
                txtSaldo.Text = _CaixaSelecionado.Saldo.ToString("N2");
                txtSaldo.Enabled = false;
                this.tabPrincipal.SelectedTab = tabPage1;
            }
        }
        #endregion


        #region Text Events
        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
        #endregion

        #endregion

    }
}