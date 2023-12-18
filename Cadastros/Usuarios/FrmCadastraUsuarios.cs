using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Cadastros.Usuarios
{
    public partial class FrmCadastraUsuarios : Form
    {
        public FrmCadastraUsuarios(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }

        #region Variaveis
        List<Permissoes> lstPermissoes = new List<Permissoes>();
        List<Entidade> lstEntidades = new List<Entidade>();
        List<GroupUser> lstGroups = new List<GroupUser>();

        private int usuarioLogadoID;
        private int grupoID = 0;

        #endregion


        #region Form Events
        private void FrmCadastraUsuarios_Load(object sender, EventArgs e)
        {
            carregaDados();
        }
        private void FrmCadastraUsuarios_KeyDown(object sender, KeyEventArgs e)
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
                if (txtNome.Text == "" || txtNome.Text == null)
                {
                    MessageBox.Show("Por favor preencha um nome.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtMunicipio.Text == "")
                {
                    MessageBox.Show("Por favor insira um município", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.CadastroUsuarios).INSERIR)
                {
                    Entidade ent = new Entidade();
                    GroupUser groupUser = new GroupUser();
                    Permissoes permissoes = new Permissoes();

                    using (Contexto context = new Contexto())
                    {
                        groupUser = context.GroupUser.FirstOrDefault(o => o.Nome == cbbGroupUser.Text);
                        grupoID = groupUser.ID;

                        ent.Tipo = 3;
                        ent.Ativo = true;
                        ent.GrupoID = grupoID;
                        ent.CPFCNPJ = txtCPFCNPJ.Text.Trim();
                        ent.Nome = txtNome.Text.Trim();
                        ent.Senha = txtSenha.Text.Trim();
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

                        context.Add(ent);
                        context.SaveChanges();
                        MessageBox.Show("Gravação concluída com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário logado não possui permissão para inserir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar operação entre em contato com o suporte\n Motivo: " + ex.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovoGrupo_Click(object sender, EventArgs e)
        {
            if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == 6).INSERIR)
            {
                FrmGrupoDeUsuarios frmGrupoDeUsuarios = new FrmGrupoDeUsuarios();
                frmGrupoDeUsuarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para inserir um novo grupo de usuário", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        #region Functions

        private void carregaDados()
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    lstPermissoes = context.Permissoes.ToList();
                    lstEntidades = context.Entidade.Where(o => o.Tipo == 3).ToList();
                    lstGroups = context.GroupUser.ToList();


                    u = lstEntidades.FirstOrDefault(o => o.ID == usuarioLogadoID);
                    grupoID = Convert.ToInt16(u.GrupoID);
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                cbbGroupUser.DataSource = lstGroups.ToList();
                cbbGroupUser.DisplayMember = "Nome";
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        #endregion


    }
}