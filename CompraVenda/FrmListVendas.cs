using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;
using System.ComponentModel;

namespace SistemaEmpresarial.CompraVenda
{
    public partial class FrmListVendas : Form
    {
        public FrmListVendas(int usuarioID)
        {
            InitializeComponent();
            usuarioLogadoID = usuarioID;
        }


        #region Variaveis
        List<ViewPedido> FindPedidos;
        List<Permissoes> lstPermissoes;

        public bool importando = false;
        private int usuarioLogadoID;
        private int grupoID = 0;
        private int clienteID = 0;

        public ViewPedido _VendaSelecionada;
        #endregion

        #region Events

        #region Form Events
        private void FrmListVendas_Load(object sender, EventArgs e)
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
                    FindPedidos = context.ViewPedido.OrderBy(o => o.DataEmissao).ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (lstPermissoes.FirstOrDefault(o => o.GrupoID == u.GrupoID && o.FormID == MeusForms.ListaVendas).VISUALIZAR)
                {
                    gridVendas.DataSource = FindPedidos.ToList();
                    int totalDeCelulas = gridVendas.Columns["Total"].Index;

                    decimal total = 0;

                    foreach (DataGridViewRow row in gridVendas.Rows)
                    {
                        total += Convert.ToDecimal(row.Cells[totalDeCelulas].Value);
                    }

                    lblTotal.Text = total.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para visualizar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
        #endregion


        #region Button Events
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FrmListClientes frmListClientes = new FrmListClientes(usuarioLogadoID);
            frmListClientes.importando = true;
            frmListClientes.ShowDialog();

            if (frmListClientes._EntidadeSelecionadaView != null)
            {
                txtCliente.Text = frmListClientes._EntidadeSelecionadaView.Nome;
            }
        }
        #endregion


        #region Grid Events
        private void gridVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (importando == true)
            {
                _VendaSelecionada = FindPedidos[e.RowIndex];

                FrmNovaVenda frmNovaVenda = new FrmNovaVenda(usuarioLogadoID);
                frmNovaVenda.vendaID = _VendaSelecionada.ID;
                this.Close();
            }
            else
            {
                _VendaSelecionada = FindPedidos[e.RowIndex];

                FrmNovaVenda frmNovaVenda = new FrmNovaVenda(usuarioLogadoID);
                frmNovaVenda.vendaID = _VendaSelecionada.ID;
                frmNovaVenda.Show();
            }
        }
        #endregion


        #region Text Events



        #endregion


        #endregion
    }
}
