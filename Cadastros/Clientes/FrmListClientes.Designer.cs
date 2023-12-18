namespace SistemaEmpresarial
{
    partial class FrmListClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnExcluir = new Button();
            btnVisualizar = new Button();
            btnNovo = new Button();
            label2 = new Label();
            txtBusca = new TextBox();
            gridCliente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            RazaoSocial = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPFCNPJ = new DataGridViewTextBoxColumn();
            Fone1 = new DataGridViewTextBoxColumn();
            Fone2 = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            lblQuantidade = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridCliente).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(914, 529);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(143, 35);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir [ DEL ]";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(147, 530);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(119, 35);
            btnVisualizar.TabIndex = 14;
            btnVisualizar.Text = "Visualizar [ F3 ]";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(12, 530);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(119, 34);
            btnNovo.TabIndex = 13;
            btnNovo.Text = "Novo [ F2 ]";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 12;
            label2.Text = "Busca de Clientes";
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(12, 45);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(1045, 23);
            txtBusca.TabIndex = 11;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // gridCliente
            // 
            gridCliente.AllowUserToAddRows = false;
            gridCliente.AllowUserToDeleteRows = false;
            gridCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gridCliente.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCliente.Columns.AddRange(new DataGridViewColumn[] { ID, RazaoSocial, Tipo, Nome, CPFCNPJ, Fone1, Fone2, CEP, Cidade });
            gridCliente.Location = new Point(10, 108);
            gridCliente.Name = "gridCliente";
            gridCliente.ReadOnly = true;
            gridCliente.RowTemplate.Height = 25;
            gridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCliente.Size = new Size(1045, 407);
            gridCliente.TabIndex = 10;
            gridCliente.CellClick += gridCliente_CellClick;
            gridCliente.CellDoubleClick += gridCliente_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // RazaoSocial
            // 
            RazaoSocial.DataPropertyName = "RazaoSocial";
            RazaoSocial.HeaderText = "RazaoSocial";
            RazaoSocial.Name = "RazaoSocial";
            RazaoSocial.ReadOnly = true;
            RazaoSocial.Visible = false;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Visible = false;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 270;
            // 
            // CPFCNPJ
            // 
            CPFCNPJ.DataPropertyName = "CPFCNPJ";
            CPFCNPJ.HeaderText = "CPF/CNPJ";
            CPFCNPJ.Name = "CPFCNPJ";
            CPFCNPJ.ReadOnly = true;
            CPFCNPJ.Width = 120;
            // 
            // Fone1
            // 
            Fone1.DataPropertyName = "Fone1";
            Fone1.HeaderText = "Fone 1";
            Fone1.Name = "Fone1";
            Fone1.ReadOnly = true;
            // 
            // Fone2
            // 
            Fone2.DataPropertyName = "Fone2";
            Fone2.HeaderText = "Fone 2";
            Fone2.Name = "Fone2";
            Fone2.ReadOnly = true;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Municipio";
            Cidade.HeaderText = "Cidade";
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Black;
            lblQuantidade.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Location = new Point(12, 79);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(153, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "CLIENTES CADASTRADOS";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1045, 28);
            textBox1.TabIndex = 8;
            // 
            // FrmListClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1067, 575);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnNovo);
            Controls.Add(label2);
            Controls.Add(txtBusca);
            Controls.Add(gridCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "FrmListClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroClientes";
            Load += FrmCadastroClientes_Load;
            KeyDown += FrmCadastroClientes_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gridCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnVisualizar;
        private Button btnNovo;
        private Label label2;
        private TextBox txtBusca;
        private DataGridView gridCliente;
        private Label lblQuantidade;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn RazaoSocial;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPFCNPJ;
        private DataGridViewTextBoxColumn Fone1;
        private DataGridViewTextBoxColumn Fone2;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Cidade;
    }
}