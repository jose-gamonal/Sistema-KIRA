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
            components = new System.ComponentModel.Container();
            lbl_titulo = new Label();
            lbl_nome = new Label();
            lbl_preco = new Label();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            lbl_quantidade = new Label();
            nud_quantidade = new NumericUpDown();
            btn_cadastrar = new Button();
            rad_salgado = new RadioButton();
            rad_doce = new RadioButton();
            rad_bebida = new RadioButton();
            lbl_titulosistema = new Label();
            tip_remover = new ToolTip(components);
            btn_remover = new Button();
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
            txt_preco.ShortcutsEnabled = false;
            txt_preco.Size = new Size(128, 23);
            txt_preco.TabIndex = 6;
            txt_preco.KeyPress += txt_preco_KeyPress;
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
            nud_quantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(128, 23);
            nud_quantidade.TabIndex = 8;
            nud_quantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(122, 217);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(136, 53);
            btn_cadastrar.TabIndex = 9;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // rad_salgado
            // 
            rad_salgado.AutoSize = true;
            rad_salgado.Location = new Point(44, 185);
            rad_salgado.Name = "rad_salgado";
            rad_salgado.Size = new Size(67, 19);
            rad_salgado.TabIndex = 10;
            rad_salgado.TabStop = true;
            rad_salgado.Text = "Salgado";
            rad_salgado.UseVisualStyleBackColor = true;
            // 
            // rad_doce
            // 
            rad_doce.AutoSize = true;
            rad_doce.Location = new Point(125, 185);
            rad_doce.Name = "rad_doce";
            rad_doce.Size = new Size(52, 19);
            rad_doce.TabIndex = 11;
            rad_doce.TabStop = true;
            rad_doce.Text = "Doce";
            rad_doce.UseVisualStyleBackColor = true;
            // 
            // rad_bebida
            // 
            rad_bebida.AutoSize = true;
            rad_bebida.Location = new Point(197, 185);
            rad_bebida.Name = "rad_bebida";
            rad_bebida.Size = new Size(61, 19);
            rad_bebida.TabIndex = 12;
            rad_bebida.TabStop = true;
            rad_bebida.Text = "Bebida";
            rad_bebida.UseVisualStyleBackColor = true;
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
            // btn_remover
            // 
            btn_remover.Location = new Point(44, 217);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(72, 53);
            btn_remover.TabIndex = 13;
            btn_remover.Text = "Remover";
            tip_remover.SetToolTip(btn_remover, "Removerá completamente o item com o nome indicado do estoque, ignorando o qualquer dado informado em preço, quantidade ou categoria.");
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 289);
            Controls.Add(btn_remover);
            Controls.Add(rad_bebida);
            Controls.Add(rad_doce);
            Controls.Add(rad_salgado);
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
            Load += CadastrarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_nome;
        private Label lbl_preco;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private Label lbl_quantidade;
        private NumericUpDown nud_quantidade;
        private Button btn_cadastrar;
        private RadioButton rad_salgado;
        private RadioButton rad_doce;
        private RadioButton rad_bebida;
        private Label lbl_titulosistema;
        private ToolTip tip_remover;
        private Button btn_remover;
    }
}