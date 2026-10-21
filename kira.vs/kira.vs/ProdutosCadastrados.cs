using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static kira.vs.FormInicial.Compartilhador;

namespace kira.vs
{
    public partial class ProdutosCadastrados : Form
    {
        public ProdutosCadastrados()
        {
            InitializeComponent();
        }

        private void ProdutosCadastrados_Load(object sender, EventArgs e)
        {
            if (listaprodutos.Count == 0)
            {
                MessageBox.Show("Lista vazia.");
                this.Close();
                return;
            }
            else
            {
                dgv_tabela.DataSource = listaprodutos;
            }
        }

        private void ProdutosCadastrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv_tabela.DataSource = null;
        }
    }
}
