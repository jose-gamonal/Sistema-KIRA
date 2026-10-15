using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kira.vs
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        public void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_preco.Text) || decimal.IsNegative(nud_quantidade.Value))
            {
                MessageBox.Show("Inclua dados válidos.");
            }
            else
            {
                Produto novoProduto = new Produto();
                novoProduto.DefinirValores(txt_nome.Text, txt_preco.Text, nud_quantidade.Value);

                FormInicial.Compartilhador.listaprodutos.Add(novoProduto);

                txt_nome.Clear();
                txt_preco.Clear();
            }
        }
        public class Produto
        {
            private string? Nome { get; set; }
            private string? Preco { get; set; }
            private decimal? Quantidade { get; set; }

            public void DefinirValores(string nome, string preco, decimal quantidade)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
            }
        };
    }
}
