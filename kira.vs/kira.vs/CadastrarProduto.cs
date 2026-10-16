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
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_preco.Text) || nud_quantidade.Value < 1)
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
                nud_quantidade.Value = 0;
            }
        }
        public class Produto
        {
            public string? Nome { get; private set; }
            public double? Preco { get; private set; }
            public decimal? Quantidade { get; private set; }
            public string? Categoria { }

            public virtual void DefinirValores(string nome, string preco, decimal quantidade)
            {
                Nome = nome;
                Preco = Convert.ToDouble(preco);
                Quantidade = quantidade;
            }
        };

        public class Salgado : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade)
            {
                base.DefinirValores(string nome, string preco, decimal quantidade);

            }
        }
        public class Doce : Produto
        {

        }
        public class Bebida : Produto
        {

        }

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; //bloqueia
            }
            else
            {
                e.Handled = false;
            }

            if (e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',')) > -1)
            {
                e.Handled = true;
            } //se o último caractere for uma vírgula e ele encontrar outra vírgula no texto
        }
    }
}
