namespace SistemaEmpresarial.Contas
{
    partial class FrmContasReceber
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
            gridReceber = new DataGridView();
            gridRecebendo = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            btnAdicionarConta = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridReceber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridRecebendo).BeginInit();
            SuspendLayout();
            // 
            // gridReceber
            // 
            gridReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridReceber.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gridReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReceber.Location = new Point(12, 51);
            gridReceber.Name = "gridReceber";
            gridReceber.RowTemplate.Height = 25;
            gridReceber.Size = new Size(776, 150);
            gridReceber.TabIndex = 0;
            gridReceber.CellClick += gridReceber_CellClick;
            // 
            // gridRecebendo
            // 
            gridRecebendo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRecebendo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gridRecebendo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRecebendo.Location = new Point(12, 244);
            gridRecebendo.Name = "gridRecebendo";
            gridRecebendo.RowTemplate.Height = 25;
            gridRecebendo.Size = new Size(776, 178);
            gridRecebendo.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            // 
            // btnAdicionarConta
            // 
            btnAdicionarConta.Location = new Point(12, 210);
            btnAdicionarConta.Name = "btnAdicionarConta";
            btnAdicionarConta.Size = new Size(75, 23);
            btnAdicionarConta.TabIndex = 4;
            btnAdicionarConta.Text = "add";
            btnAdicionarConta.UseVisualStyleBackColor = true;
            btnAdicionarConta.Click += btnAdicionarConta_Click;
            // 
            // button2
            // 
            button2.Location = new Point(103, 210);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmContasReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 464);
            Controls.Add(button2);
            Controls.Add(btnAdicionarConta);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(gridRecebendo);
            Controls.Add(gridReceber);
            Name = "FrmContasReceber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContasReceber";
            Load += FrmContasReceber_Load;
            ((System.ComponentModel.ISupportInitialize)gridReceber).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridRecebendo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridReceber;
        private DataGridView gridRecebendo;
        private TextBox textBox1;
        private Label label1;
        private Button btnAdicionarConta;
        private Button button2;
    }
}