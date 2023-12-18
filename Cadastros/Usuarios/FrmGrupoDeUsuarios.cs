using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Cadastros.Usuarios
{
    public partial class FrmGrupoDeUsuarios : Form
    {
        public FrmGrupoDeUsuarios()
        {
            InitializeComponent();
        }

        #region Variaveis
        List<Permissoes> lstPermissoes = new List<Permissoes>();
        List<GroupUser> lstGroupUser = new List<GroupUser>();

        private int formID = 2;
        private int grupoID = 0;
        #endregion

        #region Form Events
        private void FrmGrupoDeUsuarios_Load(object sender, EventArgs e)
        {
            carregaDados();
        }
        #endregion

        #region Button events
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == null || txtNome.Text == "")
                {
                    MessageBox.Show("Por favor insira um nome", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GroupUser groupUser = new GroupUser();

                using (Contexto context = new Contexto())
                {
                    groupUser.Nome = txtNome.Text;


                    context.Add(groupUser);

                    context.SaveChanges();

                    grupoID = groupUser.ID;

                    foreach (Permissoes perm in lstPermissoes)
                    {
                        Permissoes permissoes = new Permissoes();

                        permissoes.FormID = perm.FormID;
                        permissoes.GrupoID =    grupoID;
                        permissoes.INSERIR = true;
                        permissoes.VISUALIZAR = true;
                        permissoes.ALTERAR = true;
                        permissoes.EXCLUIR = true;

                        context.Add(permissoes);
                        context.SaveChanges();
                    }



                    MessageBox.Show("Grupo de usuários cadastrados com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { }
        }
        #endregion

        #region Functions

        private void carregaDados()
        {
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    lstPermissoes = context.Permissoes.ToList();
                    lstGroupUser = context.GroupUser.ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                gridGrupos.DataSource = lstGroupUser.ToList();
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();

        }

        #endregion

    }
}
