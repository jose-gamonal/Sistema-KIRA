using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static kira.vs.FormInicial;

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
            dgv_tabela.DataSource = FormInicial.Compartilhador.listaprodutos;

            if (FormInicial.Compartilhador.listaprodutos.Count == 0)
            {
                MessageBox.Show("Lista vazia");
                this.Close();
                return;
            }
            else
            {
                dgv_tabela.DataSource = FormInicial.Compartilhador.listaprodutos;
            }
        } //ao abrir, associa a tabela à lista


        private void ProdutosCadastrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv_tabela.DataSource = null;
        } //ao fechar, desassocia, impedindo que a lista tente avisar uma mudança a um formulário que não existe

        private void dgv_tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
