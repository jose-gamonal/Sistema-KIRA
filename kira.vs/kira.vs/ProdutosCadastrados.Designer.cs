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
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).BeginInit();
            SuspendLayout();
            // 
            // dgv_tabela
            // 
            dgv_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tabela.Location = new Point(12, 12);
            dgv_tabela.Name = "dgv_tabela";
            dgv_tabela.ReadOnly = true;
            dgv_tabela.Size = new Size(346, 410);
            dgv_tabela.TabIndex = 0;
            // 
            // ProdutosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 444);
            Controls.Add(dgv_tabela);
            Name = "ProdutosCadastrados";
            Text = "Produtos Cadastrados";
            FormClosing += ProdutosCadastrados_FormClosing;
            Load += ProdutosCadastrados_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_tabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_tabela;
    }
}