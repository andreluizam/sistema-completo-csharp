using SistemaEmpresarial.Cadastros.Clientes;
using SistemaEmpresarial.CompraVenda;
using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;
using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace SistemaEmpresarial
{
    public partial class FrmListClientes : Form
    {
        private ComumSistema comumSistema;

        public FrmListClientes(int usuarioID)
        {
            InitializeComponent();
            this.usuarioLogadoID = usuarioID;

        }

        #region Variaveis

        List<ViewEntidade> FindEntidades;
        List<Entidade> lstEntidades;
        List<Permissoes> lstPermissoes;
        List<GroupUser> lstGroupUsers;

        public bool importando = false;
        public int entidadeID = 0;
        public int grupoID = 0;
        private int usuarioLogadoID;

        private Timer timerBusca;
        int tempo = 300;

        public ViewEntidade _EntidadeSelecionadaView;
        #endregion


        #region Eventos


        #region Form Events
        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            timerBusca = new Timer();
            timerBusca.Interval = 100;
            timerBusca.Tick += (s, args) =>
            {
                tempo = tempo - 100;
                if (tempo == 0)
                {
                    var filtro = FindEntidades.Where(o => o.Nome.ToLower().Contains(txtBusca.Text.ToLower())).Select(o => new { o.ID, o.Nome, o.CPFCNPJ, o.Fone1, o.Fone2, o.RGIE, o.CEP, o.Municipio }).ToList();
                    gridCliente.DataSource = filtro;
                    lblQuantidade.Text = filtro.Count + " CLIENTES ENCONTRADOS";
                }
            };
            carregaClientes();
        }

        private void FrmCadastroClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnNovo_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnExcluir_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        #endregion


        #region Button Events
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.ListaClientes).INSERIR)
            {
                FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(usuarioLogadoID);
                frmCadastrarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para inserir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.ListaClientes).EXCLUIR)
            {
                if (MessageBox.Show("Deseja excluir o cliente " + _EntidadeSelecionadaView.Nome + " ?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (Contexto context = new Contexto())
                    {
                        Entidade ent = new Entidade();
                        ent = context.Entidade.FirstOrDefault(o => o.ID == entidadeID);

                        if (ent != null)
                        {

                            context.Remove(ent);
                            context.SaveChanges();
                            MessageBox.Show("Cliente excluido com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            carregaClientes();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para excluir", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        #region Grid Events

        private void gridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (importando == true)
                {
                    _EntidadeSelecionadaView = FindEntidades[e.RowIndex];
                    this.Close();
                }
                else
                {

                    FrmCadastrarCliente cadastroClientes = new FrmCadastrarCliente(usuarioLogadoID);

                    _EntidadeSelecionadaView = FindEntidades[e.RowIndex];
                    entidadeID = _EntidadeSelecionadaView.ID;

                    cadastroClientes._EntidadeID = entidadeID;
                    cadastroClientes.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cliente válido", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmCadastrarCliente cadastroClientes = new FrmCadastrarCliente(usuarioLogadoID);

                _EntidadeSelecionadaView = FindEntidades[e.RowIndex];
                entidadeID = _EntidadeSelecionadaView.ID;

                cadastroClientes._EntidadeID = entidadeID;
            }
            catch (Exception)
            { }
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


        #endregion


        #region Functions

        private void carregaClientes()
        {
            BackgroundWorker worker = new BackgroundWorker();
            Entidade u = new Entidade();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {
                    FindEntidades = context.ViewEntidade.Where(o => o.Tipo == 1).ToList();

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
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == u.GrupoID && o.FormID == 2).VISUALIZAR)
                {
                    gridCliente.DataSource = FindEntidades.ToList();
                    lblQuantidade.Text = FindEntidades.Count + " CLIENTES ENCONTRADOS";
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