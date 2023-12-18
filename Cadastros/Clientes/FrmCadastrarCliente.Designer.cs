namespace SistemaEmpresarial.Cadastros.Clientes
{
    partial class FrmCadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarCliente));
            combRapido = new ComboBox();
            maskFone2 = new MaskedTextBox();
            maskFone1 = new MaskedTextBox();
            maskCEP = new MaskedTextBox();
            maskCadastro = new MaskedTextBox();
            maskUltimoAt = new MaskedTextBox();
            maskNascimento = new MaskedTextBox();
            btnSair = new Button();
            btnSalvar = new Button();
            label20 = new Label();
            txtObservacao = new TextBox();
            label19 = new Label();
            txtRazaoSocial = new TextBox();
            label18 = new Label();
            txtUF = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            txtEmail = new TextBox();
            label14 = new Label();
            label13 = new Label();
            txtMunicipio = new TextBox();
            label12 = new Label();
            boxPaises = new ComboBox();
            label11 = new Label();
            txtComplemento = new TextBox();
            label10 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtRGIE = new TextBox();
            label4 = new Label();
            label3 = new Label();
            checkBloqueado = new CheckBox();
            checkAtivo = new CheckBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtCPFCNPJ = new TextBox();
            SuspendLayout();
            // 
            // combRapido
            // 
            combRapido.FormattingEnabled = true;
            combRapido.Location = new Point(405, 237);
            combRapido.Name = "combRapido";
            combRapido.Size = new Size(121, 23);
            combRapido.TabIndex = 97;
            combRapido.Text = "Selecione";
            combRapido.Visible = false;
            combRapido.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskFone2
            // 
            maskFone2.Location = new Point(294, 132);
            maskFone2.Mask = "00-000000000";
            maskFone2.Name = "maskFone2";
            maskFone2.Size = new Size(120, 23);
            maskFone2.TabIndex = 6;
            maskFone2.TextAlign = HorizontalAlignment.Center;
            maskFone2.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskFone1
            // 
            maskFone1.Location = new Point(172, 132);
            maskFone1.Mask = "00-000000000";
            maskFone1.Name = "maskFone1";
            maskFone1.Size = new Size(116, 23);
            maskFone1.TabIndex = 5;
            maskFone1.TextAlign = HorizontalAlignment.Center;
            maskFone1.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskCEP
            // 
            maskCEP.Location = new Point(12, 186);
            maskCEP.Mask = "00000-999";
            maskCEP.Name = "maskCEP";
            maskCEP.Size = new Size(100, 23);
            maskCEP.TabIndex = 10;
            maskCEP.TextAlign = HorizontalAlignment.Center;
            maskCEP.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskCadastro
            // 
            maskCadastro.Enabled = false;
            maskCadastro.Location = new Point(665, 238);
            maskCadastro.Mask = "00/00/0000";
            maskCadastro.Name = "maskCadastro";
            maskCadastro.Size = new Size(114, 23);
            maskCadastro.TabIndex = 96;
            maskCadastro.TextAlign = HorizontalAlignment.Center;
            maskCadastro.ValidatingType = typeof(DateTime);
            maskCadastro.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskUltimoAt
            // 
            maskUltimoAt.Enabled = false;
            maskUltimoAt.Location = new Point(534, 238);
            maskUltimoAt.Mask = "00/00/0000";
            maskUltimoAt.Name = "maskUltimoAt";
            maskUltimoAt.Size = new Size(125, 23);
            maskUltimoAt.TabIndex = 95;
            maskUltimoAt.TextAlign = HorizontalAlignment.Center;
            maskUltimoAt.ValidatingType = typeof(DateTime);
            maskUltimoAt.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // maskNascimento
            // 
            maskNascimento.Location = new Point(12, 238);
            maskNascimento.Mask = "00/00/0000";
            maskNascimento.Name = "maskNascimento";
            maskNascimento.Size = new Size(125, 23);
            maskNascimento.TabIndex = 15;
            maskNascimento.TextAlign = HorizontalAlignment.Center;
            maskNascimento.ValidatingType = typeof(DateTime);
            maskNascimento.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(654, 340);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(125, 27);
            btnSair.TabIndex = 71;
            btnSair.Text = "Sair [ ESC ]";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(12, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 27);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar [ F7 ]";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(12, 270);
            label20.Name = "label20";
            label20.Size = new Size(82, 16);
            label20.TabIndex = 94;
            label20.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(12, 288);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(767, 23);
            txtObservacao.TabIndex = 17;
            txtObservacao.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(665, 219);
            label19.Name = "label19";
            label19.Size = new Size(94, 16);
            label19.TabIndex = 93;
            label19.Text = "Data Cadastro";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(477, 78);
            txtRazaoSocial.MaxLength = 59;
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(302, 23);
            txtRazaoSocial.TabIndex = 3;
            txtRazaoSocial.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(738, 113);
            label18.Name = "label18";
            label18.Size = new Size(25, 16);
            label18.TabIndex = 82;
            label18.Text = "UF";
            // 
            // txtUF
            // 
            txtUF.Enabled = false;
            txtUF.Location = new Point(739, 131);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(40, 23);
            txtUF.TabIndex = 9;
            txtUF.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(534, 219);
            label17.Name = "label17";
            label17.Size = new Size(123, 16);
            label17.TabIndex = 92;
            label17.Text = "Ultimo Atendimento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 219);
            label16.Name = "label16";
            label16.Size = new Size(111, 16);
            label16.TabIndex = 88;
            label16.Text = "Data Nascimento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(143, 219);
            label15.Name = "label15";
            label15.Size = new Size(45, 16);
            label15.TabIndex = 89;
            label15.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 237);
            txtEmail.MaxLength = 39;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 16;
            txtEmail.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(403, 219);
            label14.Name = "label14";
            label14.Size = new Size(101, 16);
            label14.TabIndex = 90;
            label14.Text = "Acesso Rapido";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(547, 113);
            label13.Name = "label13";
            label13.Size = new Size(64, 16);
            label13.TabIndex = 81;
            label13.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Location = new Point(547, 131);
            txtMunicipio.MaxLength = 80;
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(186, 23);
            txtMunicipio.TabIndex = 8;
            txtMunicipio.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(420, 113);
            label12.Name = "label12";
            label12.Size = new Size(34, 16);
            label12.TabIndex = 80;
            label12.Text = "País";
            // 
            // boxPaises
            // 
            boxPaises.FormattingEnabled = true;
            boxPaises.Location = new Point(420, 131);
            boxPaises.Name = "boxPaises";
            boxPaises.Size = new Size(121, 23);
            boxPaises.TabIndex = 7;
            boxPaises.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(638, 167);
            label11.Name = "label11";
            label11.Size = new Size(91, 16);
            label11.TabIndex = 87;
            label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(638, 185);
            txtComplemento.MaxLength = 34;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(141, 23);
            txtComplemento.TabIndex = 14;
            txtComplemento.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(490, 167);
            label10.Name = "label10";
            label10.Size = new Size(43, 16);
            label10.TabIndex = 86;
            label10.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(490, 185);
            txtBairro.MaxLength = 39;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(142, 23);
            txtBairro.TabIndex = 13;
            txtBairro.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(416, 167);
            label9.Name = "label9";
            label9.Size = new Size(55, 16);
            label9.TabIndex = 85;
            label9.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(416, 185);
            txtNumero.MaxLength = 8;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(68, 23);
            txtNumero.TabIndex = 12;
            txtNumero.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(117, 185);
            txtEndereco.MaxLength = 49;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(293, 23);
            txtEndereco.TabIndex = 11;
            txtEndereco.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(117, 167);
            label8.Name = "label8";
            label8.Size = new Size(66, 16);
            label8.TabIndex = 84;
            label8.Text = "Endereço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 167);
            label7.Name = "label7";
            label7.Size = new Size(34, 16);
            label7.TabIndex = 83;
            label7.Text = "CEP";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(99, 23);
            textBox7.TabIndex = 69;
            textBox7.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(477, 60);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 76;
            label6.Text = "Razão Social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(48, 16);
            label5.TabIndex = 77;
            label5.Text = "RG | IE";
            // 
            // txtRGIE
            // 
            txtRGIE.Location = new Point(12, 131);
            txtRGIE.MaxLength = 16;
            txtRGIE.Name = "txtRGIE";
            txtRGIE.Size = new Size(151, 23);
            txtRGIE.TabIndex = 4;
            txtRGIE.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(293, 113);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 79;
            label4.Text = "Fone 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(169, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 78;
            label3.Text = "Fone 1";
            // 
            // checkBloqueado
            // 
            checkBloqueado.AutoSize = true;
            checkBloqueado.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBloqueado.Location = new Point(86, 20);
            checkBloqueado.Name = "checkBloqueado";
            checkBloqueado.Size = new Size(93, 20);
            checkBloqueado.TabIndex = 73;
            checkBloqueado.Text = "Bloqueado";
            checkBloqueado.UseVisualStyleBackColor = true;
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.Checked = true;
            checkAtivo.CheckState = CheckState.Checked;
            checkAtivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkAtivo.Location = new Point(35, 20);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(56, 20);
            checkAtivo.TabIndex = 72;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(169, 60);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 75;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(169, 78);
            txtNome.MaxLength = 59;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(302, 23);
            txtNome.TabIndex = 2;
            txtNome.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 74;
            label1.Text = "CPF | CNPJ";
            // 
            // txtCPFCNPJ
            // 
            txtCPFCNPJ.Location = new Point(12, 78);
            txtCPFCNPJ.MaxLength = 18;
            txtCPFCNPJ.Name = "txtCPFCNPJ";
            txtCPFCNPJ.Size = new Size(151, 23);
            txtCPFCNPJ.TabIndex = 1;
            txtCPFCNPJ.KeyDown += txtCPFCNPJ_KeyDown;
            // 
            // FrmCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 388);
            Controls.Add(combRapido);
            Controls.Add(maskFone2);
            Controls.Add(maskFone1);
            Controls.Add(maskCEP);
            Controls.Add(maskCadastro);
            Controls.Add(maskUltimoAt);
            Controls.Add(maskNascimento);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(label20);
            Controls.Add(txtObservacao);
            Controls.Add(label19);
            Controls.Add(txtRazaoSocial);
            Controls.Add(label18);
            Controls.Add(txtUF);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtEmail);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtMunicipio);
            Controls.Add(label12);
            Controls.Add(boxPaises);
            Controls.Add(label11);
            Controls.Add(txtComplemento);
            Controls.Add(label10);
            Controls.Add(txtBairro);
            Controls.Add(label9);
            Controls.Add(txtNumero);
            Controls.Add(txtEndereco);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtRGIE);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBloqueado);
            Controls.Add(checkAtivo);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtCPFCNPJ);
            KeyPreview = true;
            Name = "FrmCadastrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro do cliente";
            Load += FrmCadastrarCliente_Load;
            KeyDown += FrmCadastrarCliente_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combRapido;
        private MaskedTextBox maskFone2;
        private MaskedTextBox maskFone1;
        private MaskedTextBox maskCEP;
        private MaskedTextBox maskCadastro;
        private MaskedTextBox maskUltimoAt;
        private MaskedTextBox maskNascimento;
        private Button btnSair;
        private Button btnSalvar;
        private Label label20;
        private TextBox txtObservacao;
        private Label label19;
        private TextBox txtRazaoSocial;
        private Label label18;
        private TextBox txtUF;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtEmail;
        private Label label14;
        private Label label13;
        private TextBox txtMunicipio;
        private Label label12;
        private ComboBox boxPaises;
        private Label label11;
        private TextBox txtComplemento;
        private Label label10;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private Label label6;
        private Label label5;
        private TextBox txtRGIE;
        private Label label4;
        private Label label3;
        private CheckBox checkBloqueado;
        private CheckBox checkAtivo;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtCPFCNPJ;
    }
}