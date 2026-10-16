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
        } //ao abrir, associa a tabela à lista

        private void ProdutosCadastrados_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv_tabela.DataSource = null;
        } //ao fechar, desassocia, impedindo que a lista tente avisar uma mudança a um formulário que não existe
    }
}
