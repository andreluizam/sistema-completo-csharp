namespace SistemaEmpresarial.Contas
{
    partial class FrmCaixas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixas));
            txtSaldo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCaixa = new TextBox();
            tabPrincipal = new TabControl();
            tabPage1 = new TabPage();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            lblQuantidade = new Label();
            gridCaixas = new DataGridView();
            tabPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCaixas).BeginInit();
            SuspendLayout();
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(19, 99);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(125, 23);
            txtSaldo.TabIndex = 0;
            txtSaldo.KeyPress += txtSaldo_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 81);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Caixa";
            // 
            // txtCaixa
            // 
            txtCaixa.Location = new Point(19, 38);
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(588, 23);
            txtCaixa.TabIndex = 2;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPage1);
            tabPrincipal.Controls.Add(tabPage2);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 0);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(639, 239);
            tabPrincipal.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNovo);
            tabPage1.Controls.Add(btnExcluir);
            tabPage1.Controls.Add(btnSalvar);
            tabPage1.Controls.Add(txtCaixa);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtSaldo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(631, 211);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Caixa";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(254, 165);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(125, 27);
            btnNovo.TabIndex = 21;
            btnNovo.Text = "Novo [ F1 ]";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(482, 165);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(125, 27);
            btnExcluir.TabIndex = 20;
            btnExcluir.Text = "Excluir [ DEL ]";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(19, 165);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 27);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar [ F2 ]";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(gridCaixas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(631, 211);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pesquisar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblQuantidade);
            panel1.Location = new Point(8, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 21);
            panel1.TabIndex = 1;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Location = new Point(3, 3);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(144, 15);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "x CAIXAS ENCONTRADOS";
            // 
            // gridCaixas
            // 
            gridCaixas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCaixas.Location = new Point(8, 42);
            gridCaixas.Name = "gridCaixas";
            gridCaixas.ReadOnly = true;
            gridCaixas.RowTemplate.Height = 25;
            gridCaixas.Size = new Size(615, 161);
            gridCaixas.TabIndex = 0;
            gridCaixas.CellDoubleClick += gridCaixas_CellDoubleClick;
            // 
            // FrmCaixas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 239);
            Controls.Add(tabPrincipal);
            KeyPreview = true;
            Name = "FrmCaixas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixas do sistema";
            Load += FrmCaixas_Load;
            KeyDown += FrmCaixas_KeyDown;
            tabPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCaixas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSaldo;
        private Label label1;
        private Label label2;
        private TextBox txtCaixa;
        private TabControl tabPrincipal;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSalvar;
        private Button btnExcluir;
        private Panel panel1;
        private Label lblQuantidade;
        private Button btnNovo;
        public DataGridView gridCaixas;
    }
}