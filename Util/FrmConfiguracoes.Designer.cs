namespace SistemaEmpresarial.Util
{
    partial class FrmConfiguracoes
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
            txtCaminhoImpressao = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtCaminhoImpressao
            // 
            txtCaminhoImpressao.Location = new Point(130, 267);
            txtCaminhoImpressao.Name = "txtCaminhoImpressao";
            txtCaminhoImpressao.Size = new Size(100, 23);
            txtCaminhoImpressao.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(319, 265);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtCaminhoImpressao);
            Name = "FrmConfiguracoes";
            Text = "FrmConfiguracoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCaminhoImpressao;
        private Button btnSalvar;
    }
}