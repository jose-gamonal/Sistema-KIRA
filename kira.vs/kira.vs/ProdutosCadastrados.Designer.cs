namespace kira.vs
{
    partial class ProdutosCadastrados
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
            dgv_tabela = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabela
            // 
            dgv_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabela.Location = new Point(13, 48);
            dgv_tabela.Name = "dgv_tabela";
            dgv_tabela.ReadOnly = true;
            dgv_tabela.Size = new Size(461, 410);
            dgv_tabela.TabIndex = 0;
            dgv_tabela.CellContentClick += dgv_tabela_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 2;
            label1.Text = "* Lanchonete Kira *";
            // 
            // ProdutosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 488);
            Controls.Add(label1);
            Controls.Add(dgv_tabela);
            Name = "ProdutosCadastrados";
            Text = "Tabela de Produtos";
            FormClosing += ProdutosCadastrados_FormClosing;
            Load += ProdutosCadastrados_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_tabela;
        private Label label1;
    }
}