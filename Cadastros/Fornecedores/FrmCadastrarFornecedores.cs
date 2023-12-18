using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Cadastros.Fornecedores
{
    public partial class FrmCadastrarFornecedores : Form
    {
        public FrmCadastrarFornecedores(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }

        #region Variaveis
        List<Entidade> lstEntidades;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUser;

        private int usuarioLogadoID;
        private int grupoID = 0;
        private int entidadeID = 0;
        #endregion


        #region Propriedades
        public int _EntidadeID;

        #endregion


        #region Events

        #region Form Events

        private void FrmCadastrarFornecedores_Load(object sender, EventArgs e)
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
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.CadastroForncedores).ALTERAR)
                {
                    if (_EntidadeID > 0)
                        TrazEntidade();
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para cadastrar ou alterar fornecedores, entre em contato com um administrador", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        #endregion

        #region Button Events

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRazaoSocial.Text == "" || txtRazaoSocial.Text == null)
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

                    ent.Tipo = 2;

                    if (checkAtivo.Checked)
                        ent.Ativo = true;
                    else
                        ent.Ativo = false;

                    if (checkBloqueado.Checked)
                        ent.Bloqueado = true;
                    else
                        ent.Bloqueado = false;

                    ent.CPFCNPJ = txtCPFCNPJ.Text.Trim();
                    ent.RazaoSocial = txtRazaoSocial.Text.Trim();
                    ent.RGIE = txtRGIE.Text.Trim();
                    ent.Fone1 = maskFone1.Text.Trim();
                    ent.Fone2 = maskFone2.Text.Trim();
                    ent.CEP = maskCEP.Text;
                    ent.Endereco = txtEndereco.Text.Trim();
                    ent.Municipio = txtMunicipio.Text.Trim();
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

        #endregion

        #endregion


        #region Functions

        public void TrazEntidade()
        {
            if (_EntidadeID > 0)
            {
                btnSalvar.Text = "Alterar [ F2 ]";
                Entidade ent = new Entidade();

                using (Contexto context = new Contexto())
                {
                    ent = context.Entidade.FirstOrDefault(o => o.ID == _EntidadeID);
                }

                if (ent != null)
                {
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


        private void FrmCadastrarFornecedores_KeyDown(object sender, KeyEventArgs e)
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
    }
}
