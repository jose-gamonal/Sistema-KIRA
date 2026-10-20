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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_lista = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(30, 63);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(181, 23);
            txt_nome.TabIndex = 8;
            // 
            // nud_quantidade
            // 
            nud_quantidade.Location = new Point(217, 63);
            nud_quantidade.Name = "nud_quantidade";
            nud_quantidade.Size = new Size(46, 23);
            nud_quantidade.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dis_is_da_burger;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(295, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(428, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // lbl_lista
            // 
            lbl_lista.Location = new Point(291, 16);
            lbl_lista.Name = "lbl_lista";
            lbl_lista.Size = new Size(250, 36);
            lbl_lista.TabIndex = 13;
            lbl_lista.Text = ">";
            // 
            // RealizarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 209);
            Controls.Add(lbl_lista);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_lista;
    }
}