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

        List<ContasReceber> lstTotalContasReceber;
        List<ContasReceber> lstContasReceberRemover = new List<ContasReceber>();
        List<ContasRecebidas> lstContasRecebidas;
        List<FormasPagamento> lstFormasPagamento;


        private ContasReceber _ContaSelecionadaReceber;
        private ContasRecebidas _ContaSelecionadaRecebida;

        private int usuarioLogadoID;
        private int formaPagamentoID = 0;
        private decimal totalContas = 0;
        private decimal totalRecebendo = 0;


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
                    lstTotalContasReceber = context.ContasReceber.Where(o => o.Recebida == false).ToList();
                    lstFormasPagamento = context.FormasPagamento.Where(o => o.StatusID == 1).ToList();
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                lstContasRecebidas = new List<ContasRecebidas>();
                gridReceber.DataSource = lstTotalContasReceber.Where(o => o.Recebida == false).ToList();

                cbbFormasPagamento.DataSource = lstFormasPagamento.ToList();
                cbbFormasPagamento.DisplayMember = "Descricao";

                int totalDeCelulas = gridReceber.Columns["Valor"].Index;

                foreach (DataGridViewRow row in gridReceber.Rows)
                {
                    totalContas += Convert.ToDecimal(row.Cells[totalDeCelulas].Value);
                }

                lblTotal.Text = totalContas.ToString("N2");
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

                if (_ContaSelecionadaReceber != null)
                {
                    recebendo = new ContasRecebidas
                    {
                        ID = _ContaSelecionadaReceber.ID,
                        UsuarioID = usuarioLogadoID,
                        Cliente = _ContaSelecionadaReceber.Cliente,
                        Referente = _ContaSelecionadaReceber.Referente,
                        Valor = _ContaSelecionadaReceber.Valor
                    };

                    lstContasRecebidas.Add(recebendo);
                    lstContasReceberRemover.Add(_ContaSelecionadaReceber);
                    lstTotalContasReceber.Remove(_ContaSelecionadaReceber);

                    gridRecebendo.DataSource = lstContasRecebidas.ToList();
                    gridReceber.DataSource = lstTotalContasReceber.ToList();

                    totalContas = totalContas - _ContaSelecionadaReceber.Valor;
                    totalRecebendo += _ContaSelecionadaReceber.Valor;


                    lblTotal.Text = totalContas.ToString("N2");
                    lblTotalRecebendo.Text = totalRecebendo.ToString("N2");

                    _ContaSelecionadaReceber = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma conta para remover", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                ContasReceber receber;

                if (_ContaSelecionadaRecebida != null)
                {
                    receber = new ContasReceber
                    {
                        ID = _ContaSelecionadaRecebida.ID,
                        Cliente = _ContaSelecionadaRecebida.Cliente,
                        Referente = _ContaSelecionadaRecebida.Referente,
                        Valor = _ContaSelecionadaRecebida.Valor
                    };

                    lstTotalContasReceber.Add(receber);
                    lstContasReceberRemover.Remove(receber);
                    lstContasRecebidas.Remove(_ContaSelecionadaRecebida);

                    gridRecebendo.DataSource = lstContasRecebidas.ToList();
                    gridReceber.DataSource = lstTotalContasReceber.Where(o => o.Recebida == false).ToList();

                    totalContas = totalContas + _ContaSelecionadaRecebida.Valor;
                    totalRecebendo -= _ContaSelecionadaRecebida.Valor;


                    lblTotal.Text = totalContas.ToString("N2");
                    lblTotalRecebendo.Text = totalRecebendo.ToString("N2");

                    _ContaSelecionadaRecebida = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma conta para remover", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnReceber_Click(object sender, EventArgs e)
        {
            try
            {
                var formaPagamento = lstFormasPagamento.FirstOrDefault(o => o.Descricao == cbbFormasPagamento.Text);
                formaPagamentoID = formaPagamento.ID;

                using (Contexto context = new Contexto())
                {
                    foreach (ContasReceber contaRecebendo in lstContasReceberRemover)
                    {
                        foreach (ContasRecebidas conta in lstContasRecebidas)
                        {
                            ContasReceber contaReceber = new ContasReceber();
                            ContasRecebidas contaRecebida = new ContasRecebidas();

                            contaReceber = lstContasReceberRemover.FirstOrDefault(o => o.ID == contaRecebendo.ID);
                            contaReceber.Recebida = true;

                            contaRecebida.Referente = conta.Referente;
                            contaRecebida.Cliente = conta.Cliente;
                            contaRecebida.Valor = conta.Valor;
                            contaRecebida.UsuarioID = usuarioLogadoID;
                            contaRecebida.FormaPagamentoID = formaPagamentoID;
                            contaRecebida.ContaID = contaReceber.ID;

                            context.Update(contaReceber);
                            context.Add(contaRecebida);
                        }
                    }
                    context.SaveChanges();

                    MessageBox.Show("Conta recebida com sucesso","Aviso do sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                limparCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao receber conta, entre em contato com o suporte do sistema","Aviso do sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion


        #region Grid Events
        private void gridReceber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ContaSelecionadaReceber = lstTotalContasReceber[e.RowIndex];
            }
            catch (Exception)
            { }
        }
        private void gridRecebendo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ContaSelecionadaRecebida = lstContasRecebidas[e.RowIndex];
            }
            catch (Exception)
            { }
        }
        #endregion

        #endregion

        #region Functions
        private void limparCampos()
        {
            lblTotalRecebendo.Text = "0.00";
        }

        #endregion
    }
}