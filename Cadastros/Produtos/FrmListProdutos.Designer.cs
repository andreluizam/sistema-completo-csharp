namespace SistemaEmpresarial.Cadastros.Produtos
{
    partial class FrmListProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListProdutos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnExcluir = new Button();
            btnVisualizar = new Button();
            btnNovo = new Button();
            label2 = new Label();
            txtBusca = new TextBox();
            gridProdutos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            CodigoBarra = new DataGridViewTextBoxColumn();
            Fone1 = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            ValorEstoque = new DataGridViewTextBoxColumn();
            lblQuantidade = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(907, 571);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(143, 35);
            btnExcluir.TabIndex = 23;
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
            btnVisualizar.Location = new Point(140, 572);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(119, 35);
            btnVisualizar.TabIndex = 22;
            btnVisualizar.Text = "Visualizar [ F3 ]";
            btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(10, 573);
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
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 20;
            label2.Text = "Busca de produtos";
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtBusca.BackColor = Color.White;
            txtBusca.Location = new Point(12, 45);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(1045, 23);
            txtBusca.TabIndex = 19;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // gridProdutos
            // 
            gridProdutos.AllowUserToAddRows = false;
            gridProdutos.AllowUserToDeleteRows = false;
            gridProdutos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutos.Columns.AddRange(new DataGridViewColumn[] { ID, Descricao, CodigoBarra, Fone1, Estoque, Valor, ValorEstoque });
            gridProdutos.Location = new Point(10, 108);
            gridProdutos.Name = "gridProdutos";
            gridProdutos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Valor,Estoque,ValorEstoque";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridProdutos.RowTemplate.Height = 25;
            gridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProdutos.Size = new Size(1045, 458);
            gridProdutos.TabIndex = 18;
            gridProdutos.CellClick += gridProdutos_CellClick;
            gridProdutos.CellDoubleClick += gridProdutos_CellDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // CodigoBarra
            // 
            CodigoBarra.DataPropertyName = "CodigoBarra";
            CodigoBarra.HeaderText = "Código de barras";
            CodigoBarra.Name = "CodigoBarra";
            CodigoBarra.ReadOnly = true;
            // 
            // Fone1
            // 
            Fone1.DataPropertyName = "Fone1";
            Fone1.HeaderText = "NCM";
            Fone1.Name = "Fone1";
            Fone1.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.DataPropertyName = "Estoque";
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // ValorEstoque
            // 
            ValorEstoque.DataPropertyName = "ValorEstoque";
            ValorEstoque.HeaderText = "ValorEstoque";
            ValorEstoque.Name = "ValorEstoque";
            ValorEstoque.ReadOnly = true;
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
            lblQuantidade.Size = new Size(163, 15);
            lblQuantidade.TabIndex = 17;
            lblQuantidade.Text = "PRODUTOS CADASTRADOS";
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
            textBox1.TabIndex = 16;
            // 
            // FrmListProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 618);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnNovo);
            Controls.Add(label2);
            Controls.Add(txtBusca);
            Controls.Add(gridProdutos);
            Controls.Add(lblQuantidade);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "FrmListProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListProdutos";
            Load += FrmListProdutos_Load;
            KeyDown += FrmListProdutos_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcluir;
        private Button btnVisualizar;
        private Button btnNovo;
        private Label label2;
        private TextBox txtBusca;
        private DataGridView gridProdutos;
        private Label lblQuantidade;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn CodigoBarra;
        private DataGridViewTextBoxColumn Fone1;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn ValorEstoque;
    }
}