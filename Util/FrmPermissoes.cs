using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Configuracoes
{
    public partial class FrmPermissoes : Form
    {
        public FrmPermissoes(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }


        #region Variaveis
        List<Permissoes> lstPermissoes = new List<Permissoes>();
        List<GroupUser> lstGroups = new List<GroupUser>();
        List<Entidade> lstEntidades = new List<Entidade>();


        private int usuarioLogadoID;
        private int grupoID = 0;
        private int formID = 0;
        private int linhaID = 0;
        private int linhaDesc = 0;
        private bool inserir = false;
        private bool visualizar = false;
        private bool alterar = false;
        private bool excluir = false;

        #endregion


        #region Events

        #region Form Events
        private void FrmPermissoes_Load(object sender, EventArgs e)
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    lstEntidades = context.Entidade.ToList();
                    lstGroups = context.GroupUser.ToList();
                    lstPermissoes = context.Permissoes.Where(o => o.GrupoID == 1).ToList();

                    u = lstEntidades.FirstOrDefault(o => o.ID == usuarioLogadoID);
                    lstGroups.FirstOrDefault(grupo => grupo.ID == u.ID);
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(p => p.GrupoID == u.GrupoID && p.FormID == MeusForms.Permissoes).VISUALIZAR)
                {
                    gridPermissoes.DataSource = lstPermissoes;
                    cbbGrupoUsuarios.DataSource = lstGroups.ToList();
                    cbbGrupoUsuarios.DisplayMember = "Nome";

                    linhaID = gridPermissoes.Columns["Tela"].Index;
                    linhaDesc = gridPermissoes.Columns["Formulario"].Index;


                    foreach (DataGridViewRow row in gridPermissoes.Rows)
                    {
                        formID = Convert.ToInt32(row.Cells[linhaID].Value);
                        row.Cells[linhaDesc].Value = DescricaoConformeFormID(formID);
                    }

                    #region Cria CheckBox na grid para as permissões

                    DataGridViewCheckBoxColumn inserirCheckBox = new DataGridViewCheckBoxColumn();
                    inserirCheckBox.HeaderText = "Inserir";
                    inserirCheckBox.Name = "Inserir";
                    inserirCheckBox.DataPropertyName = "INSERIR";
                    gridPermissoes.Columns.Add(inserirCheckBox);

                    DataGridViewCheckBoxColumn alterarCheckBox = new DataGridViewCheckBoxColumn();
                    alterarCheckBox.HeaderText = "Alterar";
                    alterarCheckBox.Name = "Alterar";
                    alterarCheckBox.DataPropertyName = "ALTERAR";
                    gridPermissoes.Columns.Add(alterarCheckBox);

                    DataGridViewCheckBoxColumn visualizarCheckBox = new DataGridViewCheckBoxColumn();
                    visualizarCheckBox.HeaderText = "Visualizar";
                    visualizarCheckBox.Name = "Visualizar";
                    visualizarCheckBox.DataPropertyName = "VISUALIZAR";
                    gridPermissoes.Columns.Add(visualizarCheckBox);

                    DataGridViewCheckBoxColumn excluirCheckBox = new DataGridViewCheckBoxColumn();
                    excluirCheckBox.HeaderText = "Excluir";
                    excluirCheckBox.Name = "Excluir";
                    excluirCheckBox.DataPropertyName = "EXCLUIR";
                    gridPermissoes.Columns.Add(excluirCheckBox);

                    #endregion

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
        private void FrmPermissoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        #endregion


        #region Button Events

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (Contexto context = new Contexto())
            {

                foreach (DataGridViewRow row in gridPermissoes.Rows)
                {
                    formID = Convert.ToInt32(row.Cells["Tela"].Value);
                    grupoID = Convert.ToInt32(row.Cells["Grupo"].Value);
                    inserir = Convert.ToBoolean(row.Cells["Inserir"].Value);
                    visualizar = Convert.ToBoolean(row.Cells["Visualizar"].Value);
                    alterar = Convert.ToBoolean(row.Cells["Alterar"].Value);
                    excluir = Convert.ToBoolean(row.Cells["Excluir"].Value);

                    AtualizarPermissao(context, formID, grupoID, inserir, visualizar, alterar, excluir);

                }
                context.SaveChanges();

                MessageBox.Show("Permissões alteradas com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Other Events

        private void cbbGrupoUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GroupUser groupUser = new GroupUser();
                using (Contexto context = new Contexto())
                {
                    groupUser = context.GroupUser.FirstOrDefault(o => o.Nome == cbbGrupoUsuarios.Text);
                    grupoID = groupUser.ID;

                    if (grupoID > 0)
                    {
                        lstPermissoes.Clear();
                        lstPermissoes = context.Permissoes.Where(o => o.GrupoID == grupoID).ToList();

                        gridPermissoes.DataSource = lstPermissoes;
                        foreach (DataGridViewRow row in gridPermissoes.Rows)
                        {
                            formID = Convert.ToInt32(row.Cells[linhaID].Value);
                            row.Cells[linhaDesc].Value = DescricaoConformeFormID(formID);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        #endregion

        #endregion


        #endregion


        #region Function

        private void AtualizarPermissao(Contexto context, int formID, int grupoID, bool inserir, bool visualizar, bool alterar, bool excluir)
        {
            var permissao = context.Permissoes.FirstOrDefault(p => p.FormID == formID && p.GrupoID == grupoID);

            if (permissao != null)
            {
                permissao.INSERIR = inserir;
                permissao.VISUALIZAR = visualizar;
                permissao.ALTERAR = alterar;
                permissao.EXCLUIR = excluir;
            }
        }
        private string DescricaoConformeFormID(int formID)
        {
            string descricao = string.Empty;

            switch (formID)
            {
                case 0:
                    descricao = "";
                    break;
                case 1:
                    descricao = "Permissões";
                    break;
                case 2:
                    descricao = "Listagem de  clientes";
                    break;
                case 3:
                    descricao = "Cadastrar cliente";
                    break;
                case 4:
                    descricao = "Listagem de fornecedores";
                    break;
                case 5:
                    descricao = "Cadastrar fornecedor";
                    break;
                case 6:
                    descricao = "Cadastrar usuário";
                    break;
                case 7:
                    descricao = "Lista de produtos";
                    break;
                case 8:
                    descricao = "Cadastrar produtos";
                    break;
                case 9:
                    descricao = "Pedido de venda";
                    break;
                case 10:
                    descricao = "Consultar pedidos";
                    break;
                case 11:
                    descricao = "Cadastrar caixas";
                    break;


            }

            return descricao;
        }

        #endregion


    }
}