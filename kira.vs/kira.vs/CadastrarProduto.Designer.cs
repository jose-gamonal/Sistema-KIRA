namespace kira.vs
{
    partial class CadastrarProduto
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
            lbl_titulo = new Label();
            lbl_titulosistema = new Label();
            lbl_nome = new Label();
            lbl_preco = new Label();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            lbl_quantidade = new Label();
            nud_quantidade = new NumericUpDown();
            btn_cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(17, 16);
            lbl_titulo.Margin = new Padding(6, 0, 6, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(257, 31);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "* Lanchonete Kira *";
            // 
            // lbl_titulosistema
            // 
            lbl_titulosistema.AutoSize = true;
            lbl_titulosistema.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulosistema.Location = new Point(90, 51);
            lbl_titulosistema.Name = "lbl_titulosistema";
            lbl_titulosistema.Size = new Size(118, 23);
            lbl_titulosistema.TabIndex = 2;
            lbl_titulosistema.Text = "Cadastrar Produto";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(44, 95);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 3;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(44, 124);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(40, 15);
            lbl_preco.TabIndex = 4;
            lbl_preco.Text = "Preço:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(130, 92);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(128, 23);
            txt_nome.TabIndex = 5;
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(130, 121);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(128, 23);
            txt_preco.TabIndex = 6;
            // 
            // lbl_quantidade
            // 
            lbl_quantidade.AutoSize = true;
            lbl_quantidade.Location = new Point(44, 156);
            lbl_quantidade.Name = "lbl_quantidade";
            lbl_quantidade.Size = new Size(72, 15);
            lbl_quantidade.TabIndex = 7;
            lbl_quantidade.Text = "Quantidade:";
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(130, 150);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(128, 23);
            nud_quantidade.TabIndex = 8;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(44, 204);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(214, 53);
            btn_cadastrar.TabIndex = 9;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 295);
            Controls.Add(btn_cadastrar);
            Controls.Add(nud_quantidade);
            Controls.Add(lbl_quantidade);
            Controls.Add(txt_preco);
            Controls.Add(txt_nome);
            Controls.Add(lbl_preco);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_titulosistema);
            Controls.Add(lbl_titulo);
            Name = "CadastrarProduto";
            Text = "Cadastrar Produto";
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_titulosistema;
        private Label lbl_nome;
        private Label lbl_preco;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private Label lbl_quantidade;
        private NumericUpDown nud_quantidade;
        private Button btn_cadastrar;
    }
}