namespace SistemaEmpresarial.Util
{
    partial class FrmLogin
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
            txtUsuario = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(510, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(404, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(28, 106);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(510, 23);
            txtSenha.TabIndex = 3;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 211);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bem vindo !";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtSenha;
    }
}