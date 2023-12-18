using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace SistemaEmpresarial.Cadastros.Fornecedores
{
    public partial class FrmListFornecedores : Form
    {
        public FrmListFornecedores(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;
        }

        #region Variaveis
        List<ViewEntidade> FindEntidades = new List<ViewEntidade>();
        List<Entidade> lstEntidades;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUsers;

        private Timer timerBusca;
        int tempo = 300;

        private int usuarioLogadoID;
        private int grupoID = 0;
        #endregion


        #region Propriedades

        public ViewEntidade _EntidadeSelecionada;

        #endregion

        #region Events

        #region Form Events
        private void FrmCadastroFornecedores_Load(object sender, EventArgs e)
        {
            timerBusca = new Timer();
            timerBusca.Interval = 100;
            timerBusca.Tick += (s, args) =>
            {
                tempo = tempo - 100;
                if (tempo == 0)
                {
                    var filtro = FindEntidades.Where(o => o.RazaoSocial.ToLower().Contains(txtBusca.Text.ToLower())).Select(o => new { o.ID, o.RazaoSocial, o.CPFCNPJ, o.Fone1, o.Fone2, o.RGIE, o.CEP, o.Municipio }).ToList();
                    gridFornecedores.DataSource = filtro;
                    lblQuantidade.Text = filtro.Count + " FORNECEDORES ENCONTRADOS";
                }
            };
            CarregaDados();
        }
        private void FrmListFornecedores_KeyDown(object sender, KeyEventArgs e)
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


        #region Grid Events
        private void gridFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _EntidadeSelecionada = FindEntidades[e.RowIndex];

            FrmCadastrarFornecedores frmCadastrarFornecedores = new FrmCadastrarFornecedores(usuarioLogadoID);
            frmCadastrarFornecedores._EntidadeID = _EntidadeSelecionada.ID;
            frmCadastrarFornecedores.ShowDialog();
        }
        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _EntidadeSelecionada = FindEntidades[e.RowIndex];
        }
        #endregion


        #region Button Events

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.ListaFornecedores).INSERIR)
            {
                FrmCadastrarFornecedores frmCadastrarFornecedores = new FrmCadastrarFornecedores(usuarioLogadoID);
                frmCadastrarFornecedores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para inserir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.ListaFornecedores).EXCLUIR)
                {

                    var fornecedor = lstEntidades.FirstOrDefault(o => o.ID == _EntidadeSelecionada.ID);

                    using (Contexto context = new Contexto())
                    {
                        context.Remove(fornecedor);
                        context.SaveChanges();
                        MessageBox.Show("Fornecedor excluido com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para excluir fornecedores","Aviso do sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao excluir o fornecedor", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #endregion

        #region Functions

        private void CarregaDados()
        {
            Entidade u = new Entidade();
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    FindEntidades = context.ViewEntidade.Where(o => o.Tipo == 2).ToList();
                    lstEntidades = context.Entidade.ToList();
                    lstPermissoes = context.Permissoes.ToList();
                    lstGroupUsers = context.GroupUser.ToList();

                    u = lstEntidades.FirstOrDefault(o => o.ID == usuarioLogadoID);

                    grupoID = Convert.ToInt16(u.GrupoID);

                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.ListaFornecedores).VISUALIZAR)
                {
                    gridFornecedores.DataSource = FindEntidades.ToList();
                    lblQuantidade.Text = FindEntidades.Count + " FORNECEDORES ENCONTRADOS";
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
