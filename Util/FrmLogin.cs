using SistemaEmpresarial.Models;

namespace SistemaEmpresarial.Util
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, informe o usuário", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por favor, informe a senha", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (Contexto context = new Contexto())
            {
                Entidade u = context.Entidade.FirstOrDefault(o => o.Usuario == txtUsuario.Text && o.Senha == txtSenha.Text);

                if (u != null)
                {
                    if (u.Ativo)
                    {
                        ComumSistema comumSistema = new ComumSistema(u.ID);
                        FrmPrincipal frmPrincipal = new FrmPrincipal(u.ID);
                        frmPrincipal.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário se encontra inativo, verifique com um administrador do sistema", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha informado incorretamente", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
