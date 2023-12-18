using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Cadastros.Clientes
{
    public partial class FrmCadastrarCliente : Form
    {
        public FrmCadastrarCliente(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }

        #region Variaveis
        List<Entidade> lstEntidades;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUser;

        private int usuarioLogadoID;
        private int formID = 3;
        private int grupoID = 0;

        public int _EntidadeID;

        #endregion


        #region Events


        #region Form Events
        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    lstEntidades = context.Entidade.ToList();
                    lstPermissoes = context.Permissoes.ToList();
                    lstGroupUser = context.GroupUser.ToList();

                    u = context.Entidade.FirstOrDefault(o => o.ID == usuarioLogadoID);
                    grupoID = Convert.ToInt16(u.GrupoID);

                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                try
                {
                    if (lstPermissoes.FirstOrDefault(o => o.GrupoID == u.GrupoID && o.FormID == MeusForms.CadastroClientes).ALTERAR)
                    {
                        if (_EntidadeID > 0)
                            trazEntidade();
                    }
                    else
                    {
                        MessageBox.Show("Você não tem permissão para cadastrar clientes, entre em contato com um administrador", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception) { }
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
        private void FrmCadastrarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
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


        #region Button Events

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Por favor preencha um nome.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                Entidade ent;

                using (Contexto context = new Contexto())
                {
                    if (_EntidadeID > 0)
                    {
                        ent = lstEntidades.FirstOrDefault(o => o.ID == _EntidadeID);
                    }
                    else
                    {
                        ent = new Entidade();
                    }

                    ent.Tipo = 1;
                    ent.Ativo = true;
                    ent.CPFCNPJ = txtCPFCNPJ.Text.Trim();
                    ent.Nome = txtNome.Text.Trim();
                    ent.RazaoSocial = txtRazaoSocial.Text.Trim();
                    ent.RGIE = txtRGIE.Text.Trim();
                    ent.Fone1 = maskFone1.Text.Trim();
                    ent.Fone2 = maskFone2.Text.Trim();
                    ent.CEP = maskCEP.Text;
                    ent.Endereco = txtEndereco.Text.Trim();
                    ent.Numero = txtNumero.Text.Trim();
                    ent.Bairro = txtBairro.Text.Trim();
                    ent.Complemento = txtComplemento.Text.Trim();
                    ent.Email = txtEmail.Text.Trim();
                    ent.DataCadastro = DateTime.Now;
                    ent.Observacao = txtObservacao.Text.Trim();

                    if (_EntidadeID > 0)
                    {
                        context.Update(ent);
                        context.SaveChanges();
                        MessageBox.Show("Alteração concluída com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        context.Add(ent);
                        context.SaveChanges();
                        MessageBox.Show("Gravação concluída com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar operação entre em contato com o suporte\n Motivo: " + ex.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Text Events
        private void txtCPFCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #endregion


        #region Functions
        private void trazEntidade()
        {
            if (_EntidadeID > 0)
            {
                Entidade ent = new Entidade();

                using (Contexto context = new Contexto())
                {
                    ent = context.Entidade.FirstOrDefault(o => o.ID == _EntidadeID);
                }

                if (ent != null)
                {
                    if (ent.Ativo)
                    {
                        checkAtivo.Checked = true;
                    }
                    else
                    {
                        checkAtivo.Checked = false;
                        MessageBox.Show("Entidade inativa", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (ent.Bloqueado)
                    {
                        checkBloqueado.Checked = true;
                        MessageBox.Show("Entidade bloqueada", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        checkBloqueado.Checked = false;
                    }

                    txtNome.Text = ent.Nome;
                    txtRazaoSocial.Text = ent.RazaoSocial;
                    txtCPFCNPJ.Text = ent.CPFCNPJ;
                    txtRGIE.Text = ent.RGIE;
                    txtEndereco.Text = ent.Endereco;
                    txtMunicipio.Text = ent.Municipio;
                    maskFone1.Text = ent.Fone1;
                    maskFone2.Text = ent.Fone2;
                    maskCEP.Text = ent.CEP;
                    txtEmail.Text = ent.Email;
                    txtObservacao.Text = ent.Observacao;

                    maskNascimento.Text = Convert.ToDateTime(ent.DataNascimento).ToString();
                    maskCadastro.Text = Convert.ToDateTime(ent.DataCadastro).ToString();

                }
            }
        }

        #endregion


    }
}
