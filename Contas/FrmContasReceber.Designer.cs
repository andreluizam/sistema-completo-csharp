namespace SistemaEmpresarial.Contas
{
    partial class FrmContasReceber
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
            gridReceber = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Recebida = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Referente = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAdicionarConta = new Button();
            btnRemover = new Button();
            lblTotal = new Label();
            lblTotalRecebendo = new Label();
            gridRecebendo = new DataGridView();
            IDR = new DataGridViewTextBoxColumn();
            UsuarioID = new DataGridViewTextBoxColumn();
            FormaPagamentoID = new DataGridViewTextBoxColumn();
            CaixaID = new DataGridViewTextBoxColumn();
            ClienteR = new DataGridViewTextBoxColumn();
            ReferenteR = new DataGridViewTextBoxColumn();
            ValorR = new DataGridViewTextBoxColumn();
            btnReceber = new Button();
            cbbFormasPagamento = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridReceber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRecebendo).BeginInit();
            SuspendLayout();
            // 
            // gridReceber
            // 
            gridReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReceber.Columns.AddRange(new DataGridViewColumn[] { ID, Recebida, Cliente, Referente, Valor });
            gridReceber.Location = new Point(13, 68);
            gridReceber.Name = "gridReceber";
            gridReceber.RowTemplate.Height = 25;
            gridReceber.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReceber.Size = new Size(776, 150);
            gridReceber.TabIndex = 0;
            gridReceber.CellClick += gridReceber_CellClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Recebida
            // 
            Recebida.DataPropertyName = "Recebida";
            Recebida.HeaderText = "Recebida";
            Recebida.Name = "Recebida";
            Recebida.Visible = false;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Referente
            // 
            Referente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Referente.DataPropertyName = "Referente";
            Referente.HeaderText = "Referente";
            Referente.Name = "Referente";
            Referente.Width = 300;
            // 
            // Valor
            // 
            Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            // 
            // btnAdicionarConta
            // 
            btnAdicionarConta.Location = new Point(12, 233);
            btnAdicionarConta.Name = "btnAdicionarConta";
            btnAdicionarConta.Size = new Size(75, 23);
            btnAdicionarConta.TabIndex = 4;
            btnAdicionarConta.Text = "add";
            btnAdicionarConta.UseVisualStyleBackColor = true;
            btnAdicionarConta.Click += btnAdicionarConta_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(103, 233);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(690, 232);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 21);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "0,00";
            // 
            // lblTotalRecebendo
            // 
            lblTotalRecebendo.AutoSize = true;
            lblTotalRecebendo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRecebendo.Location = new Point(690, 400);
            lblTotalRecebendo.Name = "lblTotalRecebendo";
            lblTotalRecebendo.Size = new Size(40, 21);
            lblTotalRecebendo.TabIndex = 7;
            lblTotalRecebendo.Text = "0,00";
            // 
            // gridRecebendo
            // 
            gridRecebendo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRecebendo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecebendo.Columns.AddRange(new DataGridViewColumn[] { IDR, UsuarioID, FormaPagamentoID, CaixaID, ClienteR, ReferenteR, ValorR });
            gridRecebendo.Location = new Point(13, 272);
            gridRecebendo.Name = "gridRecebendo";
            gridRecebendo.RowTemplate.Height = 25;
            gridRecebendo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRecebendo.Size = new Size(775, 120);
            gridRecebendo.TabIndex = 8;
            gridRecebendo.CellClick += gridRecebendo_CellClick;
            // 
            // IDR
            // 
            IDR.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IDR.DataPropertyName = "ID";
            IDR.HeaderText = "ID";
            IDR.Name = "IDR";
            IDR.Width = 50;
            // 
            // UsuarioID
            // 
            UsuarioID.DataPropertyName = "UsuarioID";
            UsuarioID.HeaderText = "UsuarioID";
            UsuarioID.Name = "UsuarioID";
            UsuarioID.Visible = false;
            // 
            // FormaPagamentoID
            // 
            FormaPagamentoID.DataPropertyName = "FormaPagamentoID";
            FormaPagamentoID.HeaderText = "FormaPagamentoID";
            FormaPagamentoID.Name = "FormaPagamentoID";
            FormaPagamentoID.Visible = false;
            // 
            // CaixaID
            // 
            CaixaID.DataPropertyName = "ContaID";
            CaixaID.HeaderText = "CaixaID";
            CaixaID.Name = "CaixaID";
            CaixaID.Visible = false;
            // 
            // ClienteR
            // 
            ClienteR.DataPropertyName = "Cliente";
            ClienteR.FillWeight = 47.9591827F;
            ClienteR.HeaderText = "Cliente";
            ClienteR.Name = "ClienteR";
            // 
            // ReferenteR
            // 
            ReferenteR.DataPropertyName = "Referente";
            ReferenteR.FillWeight = 47.9591827F;
            ReferenteR.HeaderText = "Referente";
            ReferenteR.Name = "ReferenteR";
            // 
            // ValorR
            // 
            ValorR.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ValorR.DataPropertyName = "Valor";
            ValorR.FillWeight = 204.081635F;
            ValorR.HeaderText = "Valor";
            ValorR.Name = "ValorR";
            // 
            // btnReceber
            // 
            btnReceber.Location = new Point(672, 472);
            btnReceber.Name = "btnReceber";
            btnReceber.Size = new Size(116, 30);
            btnReceber.TabIndex = 9;
            btnReceber.Text = "Receber";
            btnReceber.UseVisualStyleBackColor = true;
            btnReceber.Click += btnReceber_Click;
            // 
            // cbbFormasPagamento
            // 
            cbbFormasPagamento.FormattingEnabled = true;
            cbbFormasPagamento.Location = new Point(13, 418);
            cbbFormasPagamento.Name = "cbbFormasPagamento";
            cbbFormasPagamento.Size = new Size(222, 23);
            cbbFormasPagamento.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 400);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 11;
            label2.Text = "Forma de pagamento";
            // 
            // FrmContasReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(label2);
            Controls.Add(cbbFormasPagamento);
            Controls.Add(btnReceber);
            Controls.Add(gridRecebendo);
            Controls.Add(lblTotalRecebendo);
            Controls.Add(lblTotal);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionarConta);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(gridReceber);
            Name = "FrmContasReceber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContasReceber";
            Load += FrmContasReceber_Load;
            ((System.ComponentModel.ISupportInitialize)gridReceber).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRecebendo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridReceber;
        private TextBox textBox1;
        private Label label1;
        private Button btnAdicionarConta;
        private Button btnRemover;
        private Label lblTotal;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Recebida;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Referente;
        private DataGridViewTextBoxColumn Valor;
        private Label lblTotalRecebendo;
        private DataGridView gridRecebendo;
        private DataGridViewTextBoxColumn IDR;
        private DataGridViewTextBoxColumn UsuarioID;
        private DataGridViewTextBoxColumn FormaPagamentoID;
        private DataGridViewTextBoxColumn CaixaID;
        private DataGridViewTextBoxColumn ClienteR;
        private DataGridViewTextBoxColumn ReferenteR;
        private DataGridViewTextBoxColumn ValorR;
        private Button btnReceber;
        private ComboBox cbbFormasPagamento;
        private Label label2;
    }
}