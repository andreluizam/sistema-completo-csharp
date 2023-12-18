namespace SistemaEmpresarial.Cadastros.Usuarios
{
    partial class FrmGrupoDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupoDeUsuarios));
            gridGrupos = new DataGridView();
            btnSalvar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridGrupos).BeginInit();
            SuspendLayout();
            // 
            // gridGrupos
            // 
            gridGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGrupos.Location = new Point(10, 12);
            gridGrupos.Name = "gridGrupos";
            gridGrupos.RowTemplate.Height = 25;
            gridGrupos.Size = new Size(418, 181);
            gridGrupos.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(303, 211);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 27);
            btnSalvar.TabIndex = 116;
            btnSalvar.Text = "Salvar [ F7 ]";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 215);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 23);
            txtNome.TabIndex = 117;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 197);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 118;
            label1.Text = "Nome do grupo";
            // 
            // FrmGrupoDeUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 250);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(gridGrupos);
            Name = "FrmGrupoDeUsuarios";
            Text = "FrmGrupoDeUsuarios";
            Load += FrmGrupoDeUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)gridGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridGrupos;
        private Button btnSalvar;
        private TextBox txtNome;
        private Label label1;
    }
}