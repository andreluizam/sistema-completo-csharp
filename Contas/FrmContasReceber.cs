using SistemaEmpresarial.Models;
using System.ComponentModel;

namespace SistemaEmpresarial.Contas
{
    public partial class FrmContasReceber : Form
    {
        public FrmContasReceber(int usuarioID)
        {
            InitializeComponent();
            usuarioLogadoID = usuarioID;
        }

        #region Variaveis

        List<ContasReceber> lstContasReceber;
        List<ContasRecebidas> lstContasRecebidas;


        private ContasReceber _ContaSelecionada;

        private int usuarioLogadoID;
        #endregion



        #region Events
        #region Form Events
        private void FrmContasReceber_Load(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += (s, args) =>
            {
                using (Contexto context = new Contexto())
                {

                    lstContasReceber = context.ContasReceber.ToList();
                    lstContasRecebidas = context.ContasRecebidas.ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                gridReceber.DataSource = lstContasReceber.ToList();
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }
        #endregion

        #region Button Events

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            try
            {
                ContasRecebidas recebendo;

                if (_ContaSelecionada != null)
                {
                    recebendo = new ContasRecebidas
                    {
                        ID = _ContaSelecionada.ID,
                        Cliente = _ContaSelecionada.Cliente,
                        Referente = _ContaSelecionada.Referente,
                        Valor = _ContaSelecionada.Valor
                    };

                    lstContasRecebidas.Add(recebendo);
                    //lstContasReceber.Remove(_ContaSelecionada);

                    gridRecebendo.DataSource = lstContasRecebidas;
                    //gridReceber.DataSource = lstContasReceber;
                    gridRecebendo.Refresh();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma conta para remover", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion


        private void gridReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ContaSelecionada = lstContasReceber[e.RowIndex];
        }
    }
}
