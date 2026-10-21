namespace kira.vs
{
    partial class RealizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPedido));
            lbl_titulo = new Label();
            btn_pedido = new Button();
            lbl_total = new Label();
            txt_total = new TextBox();
            btn_adicionar = new Button();
            txt_nome = new TextBox();
            nud_quantidade = new NumericUpDown();
            pbox_burger = new PictureBox();
            pbox_coca = new PictureBox();
            lbl_carrinho = new Label();
            btn_consulta = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_burger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox_coca).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(6, 9);
            lbl_titulo.Margin = new Padding(6, 0, 6, 0);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(257, 31);
            lbl_titulo.TabIndex = 2;
            lbl_titulo.Text = "* Lanchonete Kira *";
            // 
            // btn_pedido
            // 
            btn_pedido.Location = new Point(22, 148);
            btn_pedido.Name = "btn_pedido";
            btn_pedido.Size = new Size(251, 49);
            btn_pedido.TabIndex = 3;
            btn_pedido.Text = "Realizar Pedido";
            btn_pedido.UseVisualStyleBackColor = true;
            btn_pedido.Click += btn_pedido_Click;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(295, 63);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(36, 15);
            lbl_total.TabIndex = 4;
            lbl_total.Text = "Total:";
            // 
            // txt_total
            // 
            txt_total.Enabled = false;
            txt_total.Location = new Point(337, 60);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(186, 23);
            txt_total.TabIndex = 5;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(22, 90);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(251, 49);
            btn_adicionar.TabIndex = 6;
            btn_adicionar.Text = "Adicionar Produto";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(90, 58);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(121, 23);
            txt_nome.TabIndex = 8;
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(217, 58);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(50, 23);
            nud_quantidade.TabIndex = 10;
            // 
            // pbox_burger
            // 
            pbox_burger.Image = Properties.Resources.dis_is_da_burger;
            pbox_burger.ImageLocation = "";
            pbox_burger.Location = new Point(401, 89);
            pbox_burger.Name = "pbox_burger";
            pbox_burger.Size = new Size(155, 151);
            pbox_burger.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_burger.TabIndex = 11;
            pbox_burger.TabStop = false;
            // 
            // pbox_coca
            // 
            pbox_coca.Image = (Image)resources.GetObject("pbox_coca.Image");
            pbox_coca.Location = new Point(323, 101);
            pbox_coca.Name = "pbox_coca";
            pbox_coca.Size = new Size(112, 107);
            pbox_coca.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_coca.TabIndex = 12;
            pbox_coca.TabStop = false;
            // 
            // lbl_carrinho
            // 
            lbl_carrinho.Location = new Point(291, 16);
            lbl_carrinho.Name = "lbl_carrinho";
            lbl_carrinho.Size = new Size(250, 36);
            lbl_carrinho.TabIndex = 13;
            lbl_carrinho.Text = ">";
            // 
            // btn_consulta
            // 
            btn_consulta.Location = new Point(22, 57);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(62, 24);
            btn_consulta.TabIndex = 14;
            btn_consulta.Text = "Consulta";
            btn_consulta.UseVisualStyleBackColor = true;
            btn_consulta.Click += btn_consulta_Click;
            // 
            // RealizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 209);
            Controls.Add(btn_consulta);
            Controls.Add(lbl_carrinho);
            Controls.Add(pbox_coca);
            Controls.Add(pbox_burger);
            Controls.Add(nud_quantidade);
            Controls.Add(txt_nome);
            Controls.Add(btn_adicionar);
            Controls.Add(txt_total);
            Controls.Add(lbl_total);
            Controls.Add(btn_pedido);
            Controls.Add(lbl_titulo);
            Name = "RealizarPedido";
            Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_burger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox_coca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button btn_pedido;
        private Label lbl_total;
        private TextBox txt_total;
        private Button btn_adicionar;
        private TextBox txt_nome;
        private Label lbl_nome;
        private NumericUpDown nud_quantidade;
        private PictureBox pbox_burger;
        private PictureBox pbox_coca;
        private Label lbl_carrinho;
        private Button btn_consulta;
    }
}