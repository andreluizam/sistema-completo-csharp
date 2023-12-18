namespace SistemaEmpresarial.Cadastros.Fornecedores
{
    partial class FrmListFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListFornecedores));
            btnExcluir = new Button();
            btnVisualizar = new Button();
            btnNovo = new Button();
            label2 = new Label();
            txtBusca = new TextBox();
            gridFornecedores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CPFCNPJ = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            RazaoSocial = new DataGridViewTextBoxColumn();
            RGIE = new DataGridViewTextBoxColumn();
            Fone1 = new DataGridViewTextBoxColumn();
            Fone2 = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            lblQuantidade = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridFornecedores).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(914, 530);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(143, 35);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir [ DEL ]";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVisualizar.Image = (Image)resources.GetObject("btnVisualizar.Image");
            btnVisualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizar.Location = new Point(147, 531);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(119, 35);
            btnVisualizar.TabIndex = 22;
            btnVisualizar.Text = "Visualizar [ F3 ]";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(12, 531);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(119, 34);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo [ F2 ]";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 23);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 20;
            label2.Text = "Fornecedor";
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(12, 46);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(1045, 23);
            txtBusca.TabIndex = 19;
            // 
            // gridFornecedores
            // 
            gridFornecedores.AllowUserToAddRows = false;
            gridFornecedores.AllowUserToDeleteRows = false;
            gridFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFornecedores.Columns.AddRange(new DataGridViewColumn[] { ID, CPFCNPJ, Nome, RazaoSocial, RGIE, Fone1, Fone2, CEP, Cidade, Tipo });
            gridFornecedores.Location = new Point(10, 109);
            gridFornecedores.Name = "gridFornecedores";
            gridFornecedores.ReadOnly = true;
            gridFornecedores.RowTemplate.Height = 25;
            gridFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridFornecedores.Size = new Size(1045, 407);
            gridFornecedores.TabIndex = 18;
            gridFornecedores.CellClick += gridFornecedores_CellClick;
            gridFornecedores.CellDoubleClick += gridFornecedores_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // CPFCNPJ
            // 
            CPFCNPJ.DataPropertyName = "CPFCNPJ";
            CPFCNPJ.HeaderText = "CPF/CNPJ";
            CPFCNPJ.Name = "CPFCNPJ";
            CPFCNPJ.ReadOnly = true;
            CPFCNPJ.Width = 120;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 270;
            // 
            // RazaoSocial
            // 
            RazaoSocial.DataPropertyName = "RazaoSocial";
            RazaoSocial.HeaderText = "RazaoSocial";
            RazaoSocial.Name = "RazaoSocial";
            RazaoSocial.ReadOnly = true;
            // 
            // RGIE
            // 
            RGIE.DataPropertyName = "RGIE";
            RGIE.HeaderText = "RGIE";
            RGIE.Name = "RGIE";
            RGIE.ReadOnly = true;
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
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Visible = false;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Black;
            lblQuantidade.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Location = new Point(12, 80);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(191, 15);
            lblQuantidade.TabIndex = 17;
            lblQuantidade.Text = "FORNECEDORES CADASTRADOS";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1045, 28);
            textBox1.TabIndex = 16;
            // 
            // FrmListFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 578);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnNovo);
            Controls.Add(label2);
            Controls.Add(txtBusca);
            Controls.Add(gridFornecedores);
            Controls.Add(lblQuantidade);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "FrmListFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro dos fornecedores";
            Load += FrmCadastroFornecedores_Load;
            KeyDown += FrmListFornecedores_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gridFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnVisualizar;
        private Button btnNovo;
        private Label label2;
        private TextBox txtBusca;
        private DataGridView gridFornecedores;
        private Label lblQuantidade;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CPFCNPJ;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn RazaoSocial;
        private DataGridViewTextBoxColumn RGIE;
        private DataGridViewTextBoxColumn Fone1;
        private DataGridViewTextBoxColumn Fone2;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Tipo;
    }
}