namespace SistemaEmpresarial.Cadastros.Produtos
{
    partial class FrmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProduto));
            maskCadastro = new MaskedTextBox();
            maskUltimoAt = new MaskedTextBox();
            btnSair = new Button();
            btnSalvar = new Button();
            label20 = new Label();
            txtObservacao = new TextBox();
            label19 = new Label();
            txtDescricao = new TextBox();
            label17 = new Label();
            txtEstoque = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtCodigoBarras = new TextBox();
            checkAtivo = new CheckBox();
            label1 = new Label();
            txtNCM = new TextBox();
            txtValor = new TextBox();
            label3 = new Label();
            txtValorEstoque = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // maskCadastro
            // 
            maskCadastro.Enabled = false;
            maskCadastro.Location = new Point(502, 88);
            maskCadastro.Mask = "00/00/0000";
            maskCadastro.Name = "maskCadastro";
            maskCadastro.Size = new Size(114, 23);
            maskCadastro.TabIndex = 182;
            maskCadastro.TextAlign = HorizontalAlignment.Center;
            maskCadastro.ValidatingType = typeof(DateTime);
            // 
            // maskUltimoAt
            // 
            maskUltimoAt.Enabled = false;
            maskUltimoAt.Location = new Point(625, 88);
            maskUltimoAt.Mask = "00/00/0000";
            maskUltimoAt.Name = "maskUltimoAt";
            maskUltimoAt.Size = new Size(154, 23);
            maskUltimoAt.TabIndex = 181;
            maskUltimoAt.TextAlign = HorizontalAlignment.Center;
            maskUltimoAt.ValidatingType = typeof(DateTime);
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(654, 297);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(125, 27);
            btnSair.TabIndex = 160;
            btnSair.Text = "Sair [ ESC ]";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(12, 297);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 27);
            btnSalvar.TabIndex = 159;
            btnSalvar.Text = "Salvar [ F7 ]";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(10, 125);
            label20.Name = "label20";
            label20.Size = new Size(82, 16);
            label20.TabIndex = 180;
            label20.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(10, 143);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(767, 148);
            txtObservacao.TabIndex = 157;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(505, 70);
            label19.Name = "label19";
            label19.Size = new Size(94, 16);
            label19.TabIndex = 179;
            label19.Text = "Data Cadastro";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 34);
            txtDescricao.MaxLength = 59;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(607, 23);
            txtDescricao.TabIndex = 144;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(625, 69);
            label17.Name = "label17";
            label17.Size = new Size(88, 16);
            label17.TabIndex = 178;
            label17.Text = "Ultima Venda";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(170, 88);
            txtEstoque.MaxLength = 49;
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(86, 23);
            txtEstoque.TabIndex = 151;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(170, 69);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 171;
            label8.Text = "Em estoque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 16);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 164;
            label6.Text = "Descricao";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 70);
            label5.Name = "label5";
            label5.Size = new Size(112, 16);
            label5.TabIndex = 165;
            label5.Text = "Código de barras";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(12, 88);
            txtCodigoBarras.MaxLength = 16;
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(151, 23);
            txtCodigoBarras.TabIndex = 145;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Checked = true;
            checkAtivo.CheckState = CheckState.Checked;
            checkAtivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkAtivo.Location = new Point(721, 119);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(56, 20);
            checkAtivo.TabIndex = 161;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(625, 16);
            label1.Name = "label1";
            label1.Size = new Size(37, 16);
            label1.TabIndex = 185;
            label1.Text = "NCM";
            // 
            // txtNCM
            // 
            txtNCM.Location = new Point(625, 34);
            txtNCM.MaxLength = 80;
            txtNCM.Name = "txtNCM";
            txtNCM.Size = new Size(154, 23);
            txtNCM.TabIndex = 184;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(262, 88);
            txtValor.MaxLength = 49;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(72, 23);
            txtValor.TabIndex = 190;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(262, 70);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 191;
            label3.Text = "Valor";
            // 
            // txtValorEstoque
            // 
            txtValorEstoque.Location = new Point(340, 88);
            txtValorEstoque.MaxLength = 49;
            txtValorEstoque.Name = "txtValorEstoque";
            txtValorEstoque.Size = new Size(157, 23);
            txtValorEstoque.TabIndex = 192;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(340, 70);
            label4.Name = "label4";
            label4.Size = new Size(113, 16);
            label4.TabIndex = 193;
            label4.Text = "Valor em estoque";
            // 
            // FrmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 335);
            Controls.Add(txtValorEstoque);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNCM);
            Controls.Add(maskCadastro);
            Controls.Add(maskUltimoAt);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(label20);
            Controls.Add(txtObservacao);
            Controls.Add(label19);
            Controls.Add(txtDescricao);
            Controls.Add(label17);
            Controls.Add(txtEstoque);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCodigoBarras);
            Controls.Add(checkAtivo);
            KeyPreview = true;
            Name = "FrmCadastrarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar produto";
            Load += FrmListProdutos_Load;
            KeyDown += FrmCadastrarProduto_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskCadastro;
        private MaskedTextBox maskUltimoAt;
        private Button btnSair;
        private Button btnSalvar;
        private Label label20;
        private TextBox txtObservacao;
        private Label label19;
        private TextBox txtDescricao;
        private Label label17;
        private TextBox txtEstoque;
        private Label label8;
        private Label label6;
        private Label label5;
        private TextBox txtCodigoBarras;
        private CheckBox checkAtivo;
        private Label label1;
        private TextBox txtNCM;
        private TextBox txtValor;
        private Label label3;
        private TextBox txtValorEstoque;
        private Label label4;
    }
}