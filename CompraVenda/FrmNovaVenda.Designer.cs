namespace SistemaEmpresarial.CompraVenda
{
    partial class FrmNovaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridProdutos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ProdutoID = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            VendaID = new DataGridViewTextBoxColumn();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnFinalizar = new Button();
            txtEstoque = new TextBox();
            txtValor = new TextBox();
            txtQuantidade = new TextBox();
            btnPesquisaProduto = new Button();
            txtCodiBarra = new TextBox();
            txtCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox7 = new TextBox();
            btnPesquisaPedido = new Button();
            btnPesquisaCliente = new Button();
            lblNome = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSubtotal = new TextBox();
            label7 = new Label();
            lblTotal = new Label();
            txtTotal = new TextBox();
            cbbFormasDePagamento = new ComboBox();
            label8 = new Label();
            maskData = new MaskedTextBox();
            chkGeraConta = new CheckBox();
            txtDescontoEmPercentual = new TextBox();
            txtDescontoEmReais = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // gridProdutos
            // 
            gridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { ID, ProdutoID, Descricao, Valor, Quantidade, Subtotal, VendaID });
            gridProdutos.Location = new Point(12, 218);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.RowTemplate.Height = 25;
            gridProdutos.Size = new Size(915, 320);
            gridProdutos.TabIndex = 10;
            gridProdutos.CellClick += gridProdutos_CellClick;
            gridProdutos.CellEndEdit += gridProdutos_CellEndEdit;
            gridProdutos.RowsAdded += gridProdutos_RowsAdded;
            gridProdutos.RowsRemoved += gridProdutos_RowsRemoved;
            gridProdutos.KeyDown += gridItens_KeyDown;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // ProdutoID
            // 
            ProdutoID.DataPropertyName = "ProdutoID";
            ProdutoID.HeaderText = "Código";
            ProdutoID.Name = "ProdutoID";
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.Name = "Descricao";
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // VendaID
            // 
            VendaID.DataPropertyName = "VendaID";
            VendaID.HeaderText = "VendaID";
            VendaID.Name = "VendaID";
            VendaID.Visible = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(732, 174);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(93, 37);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(835, 174);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(92, 37);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(769, 561);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(165, 35);
            btnFinalizar.TabIndex = 6;
            btnFinalizar.Text = "Finalizar [ F7 ]";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtEstoque
            // 
            txtEstoque.Enabled = false;
            txtEstoque.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstoque.Location = new Point(171, 176);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(134, 35);
            txtEstoque.TabIndex = 14;
            txtEstoque.Text = "0.00";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(451, 176);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(134, 35);
            txtValor.TabIndex = 3;
            txtValor.Text = "0.00";
            txtValor.KeyDown += txtCodiBarra_KeyDown;
            txtValor.Leave += txtValor_Leave;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantidade.Location = new Point(311, 176);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(134, 35);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "0.00";
            txtQuantidade.KeyDown += txtCodiBarra_KeyDown;
            // 
            // btnPesquisaProduto
            // 
            btnPesquisaProduto.Image = Properties.Resources.Lupa;
            btnPesquisaProduto.Location = new Point(128, 175);
            btnPesquisaProduto.Name = "btnPesquisaProduto";
            btnPesquisaProduto.Size = new Size(37, 36);
            btnPesquisaProduto.TabIndex = 5;
            btnPesquisaProduto.UseVisualStyleBackColor = true;
            btnPesquisaProduto.Click += btnPesquisaProduto_Click;
            // 
            // txtCodiBarra
            // 
            txtCodiBarra.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodiBarra.Location = new Point(12, 177);
            txtCodiBarra.Name = "txtCodiBarra";
            txtCodiBarra.Size = new Size(110, 35);
            txtCodiBarra.TabIndex = 1;
            txtCodiBarra.KeyDown += txtCodiBarra_KeyDown;
            txtCodiBarra.Leave += txtCodiBarra_Leave;
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(214, 25);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(371, 23);
            txtCliente.TabIndex = 9;
            txtCliente.Text = "SELECIONE O CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 7);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 11;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 7);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 12;
            label2.Text = "Data de emissão";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 13;
            label3.Text = "Número do Pedido";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 25);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(153, 23);
            textBox7.TabIndex = 14;
            // 
            // btnPesquisaPedido
            // 
            btnPesquisaPedido.Image = Properties.Resources.Lupa;
            btnPesquisaPedido.Location = new Point(171, 25);
            btnPesquisaPedido.Name = "btnPesquisaPedido";
            btnPesquisaPedido.Size = new Size(37, 23);
            btnPesquisaPedido.TabIndex = 15;
            btnPesquisaPedido.UseVisualStyleBackColor = true;
            btnPesquisaPedido.Click += btnPesquisaPedido_Click;
            // 
            // btnPesquisaCliente
            // 
            btnPesquisaCliente.Image = Properties.Resources.Lupa;
            btnPesquisaCliente.Location = new Point(591, 25);
            btnPesquisaCliente.Name = "btnPesquisaCliente";
            btnPesquisaCliente.Size = new Size(37, 23);
            btnPesquisaCliente.TabIndex = 16;
            btnPesquisaCliente.UseVisualStyleBackColor = true;
            btnPesquisaCliente.Click += btnPesquisaCliente_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(17, 94);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(241, 32);
            lblNome.TabIndex = 7;
            lblNome.Text = "NOME DO PRODUTO";
            lblNome.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 159);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 18;
            label4.Text = "Estoque";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 159);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 19;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 159);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 20;
            label6.Text = "Valor";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubtotal.Location = new Point(591, 176);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(134, 35);
            txtSubtotal.TabIndex = 21;
            txtSubtotal.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(591, 159);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 22;
            label7.Text = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(622, 541);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 17);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(622, 561);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(134, 35);
            txtTotal.TabIndex = 24;
            txtTotal.Text = "0.00";
            // 
            // cbbFormasDePagamento
            // 
            cbbFormasDePagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFormasDePagamento.FormattingEnabled = true;
            cbbFormasDePagamento.Location = new Point(732, 25);
            cbbFormasDePagamento.Name = "cbbFormasDePagamento";
            cbbFormasDePagamento.Size = new Size(195, 23);
            cbbFormasDePagamento.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(732, 9);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 26;
            label8.Text = "Formas de pagamento";
            // 
            // maskData
            // 
            maskData.Location = new Point(634, 25);
            maskData.Mask = "00/00/0000";
            maskData.Name = "maskData";
            maskData.Size = new Size(91, 23);
            maskData.TabIndex = 27;
            maskData.ValidatingType = typeof(DateTime);
            // 
            // chkGeraConta
            // 
            chkGeraConta.AutoSize = true;
            chkGeraConta.Checked = true;
            chkGeraConta.CheckState = CheckState.Checked;
            chkGeraConta.Location = new Point(789, 54);
            chkGeraConta.Name = "chkGeraConta";
            chkGeraConta.Size = new Size(143, 19);
            chkGeraConta.TabIndex = 28;
            chkGeraConta.Text = "Gerar contas á receber";
            chkGeraConta.UseVisualStyleBackColor = true;
            // 
            // txtDescontoEmPercentual
            // 
            txtDescontoEmPercentual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoEmPercentual.Location = new Point(482, 561);
            txtDescontoEmPercentual.Name = "txtDescontoEmPercentual";
            txtDescontoEmPercentual.Size = new Size(134, 35);
            txtDescontoEmPercentual.TabIndex = 30;
            txtDescontoEmPercentual.Text = "0.00";
            txtDescontoEmPercentual.Leave += txtDescontoEmPercentual_Leave;
            // 
            // txtDescontoEmReais
            // 
            txtDescontoEmReais.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescontoEmReais.Location = new Point(342, 561);
            txtDescontoEmReais.Name = "txtDescontoEmReais";
            txtDescontoEmReais.Size = new Size(134, 35);
            txtDescontoEmReais.TabIndex = 29;
            txtDescontoEmReais.Text = "0.00";
            txtDescontoEmReais.Leave += txtDescontoEmReais_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(482, 543);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 32;
            label9.Text = "Desconto ( % )";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 543);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 31;
            label10.Text = "Desconto ( R$ )";
            // 
            // FrmNovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 610);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtDescontoEmPercentual);
            Controls.Add(txtDescontoEmReais);
            Controls.Add(chkGeraConta);
            Controls.Add(maskData);
            Controls.Add(label8);
            Controls.Add(cbbFormasDePagamento);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(txtSubtotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNome);
            Controls.Add(btnPesquisaCliente);
            Controls.Add(btnPesquisaPedido);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Controls.Add(txtCodiBarra);
            Controls.Add(btnPesquisaProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(txtValor);
            Controls.Add(txtEstoque);
            Controls.Add(btnFinalizar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(gridProdutos);
            KeyPreview = true;
            Name = "FrmNovaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo pedido";
            Load += FrmNovaVenda_Load;
            KeyDown += FrmNovaVenda_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProdutos;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnFinalizar;
        private TextBox txtEstoque;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private Button btnPesquisaProduto;
        private TextBox txtCodiBarra;
        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox7;
        private Button btnPesquisaPedido;
        private Button btnPesquisaCliente;
        private Label lblNome;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSubtotal;
        private Label label7;
        private Label lblTotal;
        private TextBox txtTotal;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn VendaID;
        private DataGridViewTextBoxColumn ProdutoID;
        private ComboBox cbbFormasDePagamento;
        private Label label8;
        private MaskedTextBox maskData;
        private CheckBox chkGeraConta;
        private TextBox txtDescontoEmPercentual;
        private TextBox txtDescontoEmReais;
        private Label label9;
        private Label label10;
    }
}