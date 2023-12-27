using SistemaEmpresarial.Cadastros.Produtos;
using SistemaEmpresarial.Enumeradores;
using SistemaEmpresarial.Models;
using SistemaEmpresarial.Models.Views;
using SistemaEmpresarial.Configuracoes;
using System.ComponentModel;
using System.Drawing.Printing;
using SistemaEmpresarial.Util;

namespace SistemaEmpresarial.CompraVenda
{
    public partial class FrmNovaVenda : Form
    {
        public FrmNovaVenda(int usuarioID)
        {
            InitializeComponent();
            usuarioLogadoID = usuarioID;
        }

        #region Variáveis
        List<Entidade> lstEntidades;
        List<Produto> lstProdutos;
        List<Vendas> lstVendas;
        List<ProdutosVenda> lstProdutosVendas;
        List<Permissoes> lstPermissoes;
        List<FormasPagamento> lstFormasPagamentos;
        List<StatusSistema> lstStatusSistemas;

        private ProdutosVenda _ProdutoSelecionado;

        private decimal totalGeral = 0;
        private int usuarioLogadoID;
        private int grupoID = 0;
        private int produtoVendaID = 0;
        private int clienteID = 0;
        private int formaPagamentoID = 0;
        public int vendaID = 0;

        private bool pago = false;
        #endregion


        #region Events


        #region Form Events
        private void FrmNovaVenda_Load(object sender, EventArgs e)
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
                    lstStatusSistemas = context.StatusSistema.ToList();
                    lstFormasPagamentos = context.FormasPagamento.ToList();
                    lstProdutos = context.Produto.ToList();

                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                if (!lstPermissoes.FirstOrDefault(o => o.GrupoID == grupoID && o.FormID == MeusForms.NovoPedido).VISUALIZAR)
                {
                    MessageBox.Show("Você não tem permissão para fazer pedidos entre em contato com um administrador do sistema", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                if (vendaID > 0)
                    trazVenda();
                else
                    maskData.Text = DateTime.Now.ToString();

                cbbFormasDePagamento.DataSource = lstFormasPagamentos.ToList();
                cbbFormasDePagamento.DisplayMember = "Descricao";
            };

            if (!worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void FrmNovaVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.F7)
            {
                btnFinalizar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        #endregion


        #region Button Events
        private void btnPesquisaPedido_Click(object sender, EventArgs e)
        {
            FrmListVendas frmListVendas = new FrmListVendas(usuarioLogadoID);
            frmListVendas.importando = true;
            frmListVendas.ShowDialog();

            if (frmListVendas._VendaSelecionada != null)
            {

                lstProdutosVendas.FirstOrDefault(o => o.VendaID == frmListVendas._VendaSelecionada.ID);
                gridProdutos.DataSource = lstProdutosVendas.ToList();

                txtCliente.Text = frmListVendas._VendaSelecionada.Cliente;
                txtTotal.Text = frmListVendas._VendaSelecionada.Total.ToString();
                maskData.Text = frmListVendas._VendaSelecionada.DataEmissao.ToString();
            }
        }
        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            FrmListClientes frmListClientes = new FrmListClientes(usuarioLogadoID);
            frmListClientes.importando = true;
            frmListClientes.ShowDialog();

            if (frmListClientes._EntidadeSelecionadaView != null)
            {
                clienteID = frmListClientes._EntidadeSelecionadaView.ID;
                txtCliente.Text = frmListClientes._EntidadeSelecionadaView.Nome;
            }
        }
        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            FrmListProdutos frmListProdutos = new FrmListProdutos(usuarioLogadoID);
            frmListProdutos.importando = true;
            frmListProdutos.ShowDialog();

            if (frmListProdutos._ProdutoSelecionado != null)
            {
                produtoVendaID = frmListProdutos._ProdutoSelecionado.ID;
                lblNome.Text = frmListProdutos._ProdutoSelecionado.Descricao;
                txtEstoque.Text = frmListProdutos._ProdutoSelecionado.Estoque.ToString();

                if (frmListProdutos._ProdutoSelecionado.Valor > 0)
                {
                    txtValor.Text = frmListProdutos._ProdutoSelecionado.Valor.ToString();
                }

                txtQuantidade.Focus();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutosVenda produtoVenda = new ProdutosVenda();
                lstProdutosVendas = new List<ProdutosVenda>();

                decimal quantidade = Convert.ToDecimal(txtQuantidade.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                decimal total = quantidade * valor;

                if (valor <= 0)
                {
                    MessageBox.Show("Coloque um valor para inserir o produto no pedido", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor.Focus();
                    return;
                }

                if (quantidade <= 0)
                {
                    MessageBox.Show("Coloque uma quantidade para inserir o produto no pedido", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQuantidade.Focus();
                    return;
                }

                if (produtoVendaID > 0)
                {
                    produtoVenda.ProdutoID = produtoVendaID;
                    produtoVenda.Descricao = lblNome.Text;
                    produtoVenda.Quantidade = quantidade;
                    produtoVenda.Valor = valor;
                    produtoVenda.Subtotal = total;

                    totalGeral = totalGeral + total;

                    lstProdutosVendas.Add(produtoVenda);
                    gridProdutos.DataSource = lstProdutosVendas.ToList();
                    gridProdutos.Refresh();

                    limparCamposAdicao();
                }
                else
                {
                    MessageBox.Show("Selecione um produto para adicionar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível adicionar o produto, entre em contato com o suporte do sistema", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                decimal subtotal = _ProdutoSelecionado.Valor * _ProdutoSelecionado.Quantidade;
                if (_ProdutoSelecionado.ProdutoID > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("Deseja remover o item " + _ProdutoSelecionado.Descricao, "Pergunta do sistema", MessageBoxButtons.OK, MessageBoxIcon.Question))
                    {
                        lstProdutosVendas.Remove(_ProdutoSelecionado);
                        gridProdutos.DataSource = lstProdutosVendas.ToList();
                        gridProdutos.Refresh();

                        totalGeral = totalGeral - subtotal;
                        txtTotal.Text = totalGeral.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Escolha pelo menos um item para remover", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível remover o produto, entre em contato com o suporte do sistema", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text == "SELECIONE O CLIENTE")
                {
                    MessageBox.Show("Por favor selecione um cliente", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPesquisaCliente_Click(sender, e);
                }

                if (gridProdutos.Rows.Count <= 0)
                {
                    MessageBox.Show("Por favor insira ao menos um produto para efetuar a venda", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cbbFormasDePagamento.Equals(0))
                {
                    MessageBox.Show("Por favor selecione a forma de pagamento para efetuar a venda", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FormasPagamento formaPagamento = new FormasPagamento();

                formaPagamento = lstFormasPagamentos.FirstOrDefault(o => o.Descricao == cbbFormasDePagamento.Text);
                formaPagamentoID = formaPagamento.ID;

                if (formaPagamento.StatusID == 1)
                    pago = true;
                else
                    pago = false;

                Vendas venda = new Vendas();

                using (Contexto context = new Contexto())
                {
                    venda.ClienteID = clienteID;
                    venda.UsuarioID = usuarioLogadoID;
                    venda.FormaPagamentoID = formaPagamentoID;
                    venda.DescontoPercentual = Convert.ToDecimal(txtDescontoEmPercentual.Text);
                    venda.DescontoReais = Convert.ToDecimal(txtDescontoEmReais.Text);
                    venda.DataEmissao = Convert.ToDateTime(maskData.Text);
                    venda.Total = Convert.ToDecimal(txtTotal.Text);

                    context.Add(venda);
                    context.SaveChanges();

                    foreach (ProdutosVenda produto in lstProdutosVendas)
                    {
                        Produto produtoEstoque = context.Produto.FirstOrDefault(o => o.ID == produto.ProdutoID);
                        ProdutosVenda produtoVendido = new ProdutosVenda();

                        produtoVendido.VendaID = venda.ID;
                        produtoVendido.ProdutoID = produto.ProdutoID;
                        produtoVendido.Descricao = produto.Descricao;
                        produtoVendido.Quantidade = produto.Quantidade;
                        produtoEstoque.Estoque += produtoVendido.Quantidade * -1;
                        produtoVendido.Valor = produto.Valor;
                        produtoVendido.Subtotal = produto.Subtotal;

                        context.Add(produtoVendido);
                        context.SaveChanges();
                    }

                    #region Cria contas a receber caso não esteja pago

                    if (pago)
                    {
                        Caixas caixa = new Caixas();

                        caixa = context.Caixas.FirstOrDefault(o => o.ID == 1);
                        caixa.Saldo += venda.Total;
                        context.SaveChanges();
                    }
                    else
                    {
                        if (chkGeraConta.Checked)
                        {
                            ContasReceber conta = new ContasReceber();

                            conta.Referente = "REFERENTE A PEDIDO DE VENDA NÚMERO " + venda.ID;
                            conta.Cliente = txtCliente.Text;
                            conta.Valor = venda.Total;
                            conta.Recebida = false;

                            context.Add(conta);
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Atenção, pedido não irá gerar contas a receber, deseja continuar?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (DialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    #endregion

                    MessageBox.Show("Venda efetuda com sucesso", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    imprimirCupom(venda.ID,txtCliente.Text);
                    LimparCampos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível concluir a venda entre em contato com o suporte do sistema", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Text Events
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
        private void txtCodiBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }
        private void txtCodiBarra_Leave(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                using (Contexto context = new Contexto())
                {
                    produto = context.Produto.FirstOrDefault(o => o.CodigoBarra == txtCodiBarra.Text);

                    if (!string.IsNullOrEmpty(txtCodiBarra.Text))
                    {
                        produtoVendaID = produto.ID;
                        lblNome.Text = produto.Descricao;
                        txtEstoque.Text = produto.Estoque.ToString("N2");

                        if (produto.Valor > 0)
                        {
                            txtValor.Text = produto.Valor.ToString();
                        }

                        txtQuantidade.Focus();
                    }
                }
            }
            catch (Exception)
            {
                txtCodiBarra.Clear();
                txtCodiBarra.Focus();
            }

        }
        private void txtValor_Leave(object sender, EventArgs e)
        {
            decimal quantidade = Convert.ToDecimal(txtQuantidade.Text);
            decimal valor = Convert.ToDecimal(txtValor.Text);
            decimal total = quantidade * valor;

            txtSubtotal.Text = total.ToString("N2");
        }
        private void txtDescontoEmReais_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal descontoReais = decimal.Parse(txtDescontoEmReais.Text);
                decimal descontoPercentual = (descontoReais / totalGeral) * 100;
                decimal totalComDesconto = descontoReais - totalGeral;

                if (descontoReais > totalGeral)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }
                txtTotal.Text = Math.Abs(totalComDesconto).ToString("0.00");
                txtDescontoEmPercentual.Text = descontoPercentual.ToString("0");
            }
            catch (Exception)
            { }
        }
        private void txtDescontoEmPercentual_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal descontoPercentual = decimal.Parse(txtDescontoEmPercentual.Text);
                decimal descontoReais = (descontoPercentual / 100) * totalGeral;
                decimal totalComDesconto = ((100 - descontoPercentual) / 100) * totalGeral;

                if (totalComDesconto > totalGeral)
                {
                    MessageBox.Show("Não é possível dar um desconto maior que o valor total.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    return;
                }

                txtTotal.Text = totalComDesconto.ToString("0.00");
                txtDescontoEmReais.Text = descontoReais.ToString("0.00");
            }
            catch (Exception)
            { }
        }
        #endregion


        #region Grid Events
        private void gridProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtTotal.Text = lstProdutosVendas.Sum(o => o.Subtotal).ToString("N2");
        }
        private void gridProdutos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtTotal.Text = lstProdutosVendas.Sum(o => o.Subtotal).ToString("N2");
        }
        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ProdutoSelecionado = lstProdutosVendas[e.RowIndex];
            }
            catch (Exception)
            { }
        }
        private void gridItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente remover o item selecionado?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    lstProdutosVendas.RemoveAt(gridProdutos.CurrentRow.Index);
                    gridProdutos.DataSource = lstProdutosVendas.ToList();
                }
            }
        }
        private void gridProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProdutos.Rows.Count > 0)
            {
                if (e.ColumnIndex == gridProdutos.Columns["Quantidade"].Index || e.ColumnIndex == gridProdutos.Columns["Valor"].Index)
                {
                    if (!string.IsNullOrEmpty(gridProdutos.Rows[gridProdutos.CurrentRow.Index].Cells["Quantidade"].Value.ToString()))
                        lstProdutosVendas[gridProdutos.CurrentRow.Index].Subtotal = lstProdutosVendas[gridProdutos.CurrentRow.Index].Quantidade * lstProdutosVendas[gridProdutos.CurrentRow.Index].Valor;


                    gridProdutos.Refresh();
                    txtTotal.Text = lstProdutosVendas.Sum(o => o.Subtotal).ToString("N2");
                    txtTotal.Refresh();
                }
            }
        }

        #endregion

        #endregion


        #region Functions
        private void LimparCampos()
        {
            lblNome.Text = string.Empty;
            txtCliente.Text = "SELECIONE O CLIENTE";
            txtQuantidade.Text = "0.00";
            txtValor.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtEstoque.Text = "0.00";
            txtCodiBarra.Text = string.Empty;
            txtTotal.Text = "0.00";
            lstProdutosVendas.Clear();
            gridProdutos.DataSource = lstProdutosVendas.ToList();
        }
        private void limparCamposAdicao()
        {
            lblNome.Text = string.Empty;
            txtQuantidade.Text = "0.00";
            txtValor.Text = "0.00";
            txtSubtotal.Text = "0.00";
            txtEstoque.Text = "0.00";
            txtCodiBarra.Text = string.Empty;
        }
        private void trazVenda()
        {
            using (Contexto context = new Contexto())
            {
                ViewPedido venda = new ViewPedido();

                venda = context.ViewPedido.FirstOrDefault(o => o.ID == vendaID);
                lstProdutosVendas = context.ProdutosVendas.Where(o => o.VendaID == vendaID).ToList();

                if (venda != null)
                {
                    txtCliente.Text = venda.Cliente.ToString();
                    cbbFormasDePagamento.Text = venda.FormaPagamento.ToString();
                    maskData.Text = venda.DataEmissao.ToString();

                    gridProdutos.DataSource = lstProdutosVendas.ToList();
                }
            }
        }
        private void imprimirCupom(int vendaID, string cliente)
        {
            try
            {
                string filePath = Application.StartupPath + "\\pedido.txt";
                string caminhoImpressao = @"\\DESKTOP-55O0AF4\ELGIN";

                using (StreamWriter imprimir = new StreamWriter(filePath))
                {
                    imprimir.WriteLine("==================================");
                    imprimir.WriteLine("           NOME DA EMPRESA        ");
                    imprimir.WriteLine("             99999999999          ");
                    imprimir.WriteLine("       PEDIDO NUMERO " + vendaID + "       ");
                    imprimir.WriteLine("==================================");
                    imprimir.WriteLine("         " + cliente.ToUpper() +  "      ");
                    imprimir.WriteLine("PROD       QTD   UNIT    TOTAL    ");
                }

                if (File.Exists(filePath))
                {
                    PrintDocument pd = new PrintDocument();

                    //pd.PrinterSettings.PrinterName = caminhoImpressao;

                    pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

                    pd.PrintPage += (sender, e) =>
                    {
                        try
                        {
                            using (StreamReader reader = new StreamReader(filePath))
                            {
                                Font fonte = new Font("Arial", 12);
                                float yPos = 0;
                                int count = 0;
                                float leftMargin = 0;
                                float topMargin = 0;
                                string linha = null;

                                while (count < 100 && ((linha = reader.ReadLine()) != null))
                                {
                                    yPos = topMargin + (count * fonte.GetHeight(e.Graphics));
                                    e.Graphics.DrawString(linha, fonte, System.Drawing.Brushes.Black, leftMargin, yPos, new StringFormat());
                                    count++;
                                }
                            }

                            e.HasMorePages = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("erro------");
                            e.HasMorePages = false;
                        }
                    };

                    pd.Print();
                }
                else
                {
                    Console.WriteLine("O arquivo não existe. Certifique-se de que o caminho do arquivo está correto.");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion



    }
}