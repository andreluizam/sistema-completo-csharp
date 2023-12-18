namespace SistemaEmpresarial.CompraVenda
{
    partial class FrmListVendas
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
            gridVendas = new DataGridView();
            lblTotal = new Label();
            txtCliente = new TextBox();
            label1 = new Label();
            btnPesquisarCliente = new Button();
            ID = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            DataEmissao = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Profissional = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridVendas).BeginInit();
            SuspendLayout();
            // 
            // gridVendas
            // 
            gridVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVendas.Columns.AddRange(new DataGridViewColumn[] { ID, Cliente, DataEmissao, FormaPagamento, Total, Profissional });
            gridVendas.Location = new Point(12, 71);
            gridVendas.Name = "gridVendas";
            gridVendas.RowTemplate.Height = 25;
            gridVendas.Size = new Size(776, 307);
            gridVendas.TabIndex = 0;
            gridVendas.CellDoubleClick += gridVendas_CellDoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(12, 388);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 30);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0.00";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(12, 37);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(497, 23);
            txtCliente.TabIndex = 2;
            txtCliente.Text = "SELECIONE O CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.Location = new Point(515, 37);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(28, 23);
            btnPesquisarCliente.TabIndex = 4;
            btnPesquisarCliente.Text = "button1";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Width = 200;
            // 
            // DataEmissao
            // 
            DataEmissao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DataEmissao.DataPropertyName = "DataEmissao";
            DataEmissao.HeaderText = "DataEmissao";
            DataEmissao.Name = "DataEmissao";
            DataEmissao.Width = 150;
            // 
            // FormaPagamento
            // 
            FormaPagamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FormaPagamento.DataPropertyName = "FormaPagamento";
            FormaPagamento.HeaderText = "FormaPagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.Width = 200;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Profissional
            // 
            Profissional.DataPropertyName = "Profissional";
            Profissional.HeaderText = "Profissional";
            Profissional.Name = "Profissional";
            // 
            // FrmListVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 427);
            Controls.Add(btnPesquisarCliente);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Controls.Add(lblTotal);
            Controls.Add(gridVendas);
            Name = "FrmListVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListVendas";
            Load += FrmListVendas_Load;
            ((System.ComponentModel.ISupportInitialize)gridVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridVendas;
        private Label lblTotal;
        private TextBox txtCliente;
        private Label label1;
        private Button btnPesquisarCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DataEmissao;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Profissional;
    }
}