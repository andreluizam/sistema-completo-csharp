namespace SistemaEmpresarial
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tabPrincipal = new TabControl();
            tabPage1 = new TabPage();
            menuStrip3 = new MenuStrip();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            pedidosRealizadosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            compraToolStripMenuItem = new ToolStripMenuItem();
            comprasFeitasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            receberToolStripMenuItem = new ToolStripMenuItem();
            pagarToolStripMenuItem = new ToolStripMenuItem();
            tabCadastros = new TabPage();
            menuStrip2 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            PermissoesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPrincipal.SuspendLayout();
            tabPage1.SuspendLayout();
            menuStrip3.SuspendLayout();
            tabCadastros.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 80);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1732, 702);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tabPrincipal
            // 
            tabPrincipal.Controls.Add(tabPage1);
            tabPrincipal.Controls.Add(tabCadastros);
            tabPrincipal.Dock = DockStyle.Fill;
            tabPrincipal.Location = new Point(0, 80);
            tabPrincipal.Name = "tabPrincipal";
            tabPrincipal.SelectedIndex = 0;
            tabPrincipal.Size = new Size(1370, 669);
            tabPrincipal.SizeMode = TabSizeMode.Fixed;
            tabPrincipal.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(menuStrip3);
            tabPage1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 641);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movimento";
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem, pedidosRealizadosToolStripMenuItem, toolStripMenuItem7, compraToolStripMenuItem, comprasFeitasToolStripMenuItem, toolStripMenuItem8, receberToolStripMenuItem, pagarToolStripMenuItem });
            menuStrip3.Location = new Point(3, 3);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1356, 71);
            menuStrip3.TabIndex = 0;
            menuStrip3.Text = "menuStrip3";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Image = (Image)resources.GetObject("pedidosToolStripMenuItem.Image");
            pedidosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(88, 67);
            pedidosToolStripMenuItem.Text = "Novo pedido";
            pedidosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // pedidosRealizadosToolStripMenuItem
            // 
            pedidosRealizadosToolStripMenuItem.Image = Properties.Resources.Pedido;
            pedidosRealizadosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pedidosRealizadosToolStripMenuItem.Name = "pedidosRealizadosToolStripMenuItem";
            pedidosRealizadosToolStripMenuItem.Size = new Size(93, 67);
            pedidosRealizadosToolStripMenuItem.Text = "Pedidos feitos";
            pedidosRealizadosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            pedidosRealizadosToolStripMenuItem.Click += pedidosRealizadosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(22, 67);
            toolStripMenuItem7.Text = "|";
            // 
            // compraToolStripMenuItem
            // 
            compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            compraToolStripMenuItem.Size = new Size(62, 67);
            compraToolStripMenuItem.Text = "Compra";
            // 
            // comprasFeitasToolStripMenuItem
            // 
            comprasFeitasToolStripMenuItem.Name = "comprasFeitasToolStripMenuItem";
            comprasFeitasToolStripMenuItem.Size = new Size(98, 67);
            comprasFeitasToolStripMenuItem.Text = "Compras feitas";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(22, 67);
            toolStripMenuItem8.Text = "|";
            // 
            // receberToolStripMenuItem
            // 
            receberToolStripMenuItem.Image = (Image)resources.GetObject("receberToolStripMenuItem.Image");
            receberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            receberToolStripMenuItem.Name = "receberToolStripMenuItem";
            receberToolStripMenuItem.Size = new Size(107, 67);
            receberToolStripMenuItem.Text = "Contas a receber";
            receberToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            receberToolStripMenuItem.Click += receberToolStripMenuItem_Click;
            // 
            // pagarToolStripMenuItem
            // 
            pagarToolStripMenuItem.Image = (Image)resources.GetObject("pagarToolStripMenuItem.Image");
            pagarToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            pagarToolStripMenuItem.Size = new Size(98, 67);
            pagarToolStripMenuItem.Text = "Contas a pagar";
            pagarToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tabCadastros
            // 
            tabCadastros.BackColor = Color.Transparent;
            tabCadastros.Controls.Add(menuStrip2);
            tabCadastros.Location = new Point(4, 24);
            tabCadastros.Name = "tabCadastros";
            tabCadastros.Padding = new Padding(3);
            tabCadastros.Size = new Size(1362, 641);
            tabCadastros.TabIndex = 1;
            tabCadastros.Text = "Cadastros";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedoresToolStripMenuItem, produtosToolStripMenuItem, toolStripMenuItem1, usuáriosToolStripMenuItem, PermissoesToolStripMenuItem });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1356, 71);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.Cliente;
            clientesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 67);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Image = Properties.Resources.Fornecedores;
            fornecedoresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(90, 67);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Image = Properties.Resources.Produtos;
            produtosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 67);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.MergeAction = MergeAction.Replace;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(22, 67);
            toolStripMenuItem1.Text = "|";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Image = Properties.Resources.Usuarios;
            usuáriosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 67);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // PermissoesToolStripMenuItem
            // 
            PermissoesToolStripMenuItem.Image = (Image)resources.GetObject("PermissoesToolStripMenuItem.Image");
            PermissoesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PermissoesToolStripMenuItem.Name = "PermissoesToolStripMenuItem";
            PermissoesToolStripMenuItem.Size = new Size(78, 67);
            PermissoesToolStripMenuItem.Text = "Permissões";
            PermissoesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            PermissoesToolStripMenuItem.Click += PermissoesToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tabPrincipal);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip3;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA EMPRESARIAL ";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPrincipal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            tabCadastros.ResumeLayout(false);
            tabCadastros.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnCadastros;
        private Button btnAtendimento;
        private PictureBox pictureBox1;
        private TabControl tabPrincipal;
        private TabPage tabPage1;
        private TabPage tabCadastros;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem PermissoesToolStripMenuItem;
        private System.CodeDom.CodeTypeReference menuStrip1;
        private System.CodeDom.CodeTypeReference toolStripMenuItem2;
        private System.CodeDom.CodeTypeReference toolStripMenuItem3;
        private System.CodeDom.CodeTypeReference toolStripMenuItem4;
        private System.CodeDom.CodeTypeReference toolStripMenuItem5;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem pedidosRealizadosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem compraToolStripMenuItem;
        private ToolStripMenuItem comprasFeitasToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem receberToolStripMenuItem;
        private ToolStripMenuItem pagarToolStripMenuItem;
    }
}