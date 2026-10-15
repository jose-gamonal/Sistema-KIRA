namespace kira.vs
{
    partial class FormInicial
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
            lbl_titulo = new Label();
            lbl_titulosistema = new Label();
            btn_produto = new Button();
            btn_cadastros = new Button();
            btn_pedido = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(31, 9);
            lbl_titulo.Margin = new Padding(6, 0, 6, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(257, 31);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "* Lanchonete Kira *";
            // 
            // lbl_titulosistema
            // 
            lbl_titulosistema.AutoSize = true;
            lbl_titulosistema.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulosistema.Location = new Point(114, 46);
            lbl_titulosistema.Name = "lbl_titulosistema";
            lbl_titulosistema.Size = new Size(100, 23);
            lbl_titulosistema.TabIndex = 1;
            lbl_titulosistema.Text = "Sistema Central";
            // 
            // btn_produto
            // 
            btn_produto.BackColor = Color.FromArgb(255, 128, 128);
            btn_produto.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_produto.Location = new Point(30, 91);
            btn_produto.Name = "btn_produto";
            btn_produto.Size = new Size(272, 71);
            btn_produto.TabIndex = 2;
            btn_produto.Text = "Cadastrar Produto";
            btn_produto.UseVisualStyleBackColor = false;
            btn_produto.Click += btn_produto_Click;
            // 
            // btn_cadastros
            // 
            btn_cadastros.BackColor = Color.FromArgb(128, 128, 255);
            btn_cadastros.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cadastros.Location = new Point(30, 194);
            btn_cadastros.Name = "btn_cadastros";
            btn_cadastros.Size = new Size(272, 71);
            btn_cadastros.TabIndex = 3;
            btn_cadastros.Text = "Produtos Cadastrados";
            btn_cadastros.UseVisualStyleBackColor = false;
            btn_cadastros.Click += btn_cadastros_Click;
            // 
            // btn_pedido
            // 
            btn_pedido.BackColor = Color.FromArgb(128, 255, 128);
            btn_pedido.Font = new Font("Myanmar Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pedido.Location = new Point(30, 297);
            btn_pedido.Name = "btn_pedido";
            btn_pedido.Size = new Size(272, 71);
            btn_pedido.TabIndex = 4;
            btn_pedido.Text = "Realizar Pedido";
            btn_pedido.UseVisualStyleBackColor = false;
            btn_pedido.Click += btn_pedido_Click;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 398);
            Controls.Add(btn_pedido);
            Controls.Add(btn_cadastros);
            Controls.Add(btn_produto);
            Controls.Add(lbl_titulosistema);
            Controls.Add(lbl_titulo);
            Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FormInicial";
            Text = "Sistema Central";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_titulosistema;
        private Button btn_produto;
        private Button btn_cadastros;
        private Button btn_pedido;
    }
}
