namespace SistemaEmpresarial.Configuracoes
{
    partial class FrmPermissoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissoes));
            gridPermissoes = new DataGridView();
            Formulario = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Tela = new DataGridViewTextBoxColumn();
            Perm1 = new DataGridViewTextBoxColumn();
            Perm2 = new DataGridViewTextBoxColumn();
            Perm3 = new DataGridViewTextBoxColumn();
            Perm4 = new DataGridViewTextBoxColumn();
            cbbGrupoUsuarios = new ComboBox();
            label1a = new Label();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPermissoes).BeginInit();
            SuspendLayout();
            // 
            // gridPermissoes
            // 
            gridPermissoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPermissoes.Columns.AddRange(new DataGridViewColumn[] { Formulario, Codigo, Grupo, Tela, Perm1, Perm2, Perm3, Perm4 });
            gridPermissoes.Location = new Point(12, 72);
            gridPermissoes.Name = "gridPermissoes";
            gridPermissoes.RowTemplate.Height = 25;
            gridPermissoes.Size = new Size(766, 268);
            gridPermissoes.TabIndex = 0;
            // 
            // Formulario
            // 
            Formulario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Formulario.DataPropertyName = "Formulario";
            Formulario.HeaderText = "Formulário";
            Formulario.Name = "Formulario";
            Formulario.Width = 300;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "ID";
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Visible = false;
            // 
            // Grupo
            // 
            Grupo.DataPropertyName = "GrupoID";
            Grupo.HeaderText = "Grupo";
            Grupo.Name = "Grupo";
            Grupo.Visible = false;
            // 
            // Tela
            // 
            Tela.DataPropertyName = "FormID";
            Tela.HeaderText = "Tela";
            Tela.Name = "Tela";
            Tela.Visible = false;
            // 
            // Perm1
            // 
            Perm1.DataPropertyName = "INSERIR";
            Perm1.HeaderText = "Perm1";
            Perm1.Name = "Perm1";
            Perm1.Visible = false;
            // 
            // Perm2
            // 
            Perm2.DataPropertyName = "VISUALIZAR";
            Perm2.HeaderText = "Perm2";
            Perm2.Name = "Perm2";
            Perm2.Visible = false;
            // 
            // Perm3
            // 
            Perm3.DataPropertyName = "ALTERAR";
            Perm3.HeaderText = "Perm3";
            Perm3.Name = "Perm3";
            Perm3.Visible = false;
            // 
            // Perm4
            // 
            Perm4.DataPropertyName = "EXCLUIR";
            Perm4.HeaderText = "Perm4";
            Perm4.Name = "Perm4";
            Perm4.Visible = false;
            // 
            // cbbGrupoUsuarios
            // 
            cbbGrupoUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGrupoUsuarios.FormattingEnabled = true;
            cbbGrupoUsuarios.Items.AddRange(new object[] { "Selecione" });
            cbbGrupoUsuarios.Location = new Point(12, 30);
            cbbGrupoUsuarios.Name = "cbbGrupoUsuarios";
            cbbGrupoUsuarios.Size = new Size(635, 23);
            cbbGrupoUsuarios.TabIndex = 1;
            cbbGrupoUsuarios.SelectedIndexChanged += cbbGrupoUsuarios_SelectedIndexChanged;
            // 
            // label1a
            // 
            label1a.AutoSize = true;
            label1a.Location = new Point(12, 9);
            label1a.Name = "label1a";
            label1a.Size = new Size(103, 15);
            label1a.TabIndex = 3;
            label1a.Text = "Grupo de usuários";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(653, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 27);
            btnSalvar.TabIndex = 117;
            btnSalvar.Text = "Salvar [ F7 ]";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmPermissoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 350);
            Controls.Add(btnSalvar);
            Controls.Add(label1a);
            Controls.Add(cbbGrupoUsuarios);
            Controls.Add(gridPermissoes);
            KeyPreview = true;
            Name = "FrmPermissoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permissoes";
            Load += FrmPermissoes_Load;
            KeyDown += FrmPermissoes_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gridPermissoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPermissoes;
        private ComboBox cbbGrupoUsuarios;
        private Label label1a;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Formulario;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Tela;
        private DataGridViewTextBoxColumn Perm1;
        private DataGridViewTextBoxColumn Perm2;
        private DataGridViewTextBoxColumn Perm3;
        private DataGridViewTextBoxColumn Perm4;
        private Button btnSalvar;
    }
}