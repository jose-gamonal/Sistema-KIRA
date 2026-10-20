using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
                string categoria = "";

                if (rad_bebida.Checked)
                {
                    categoria = "Bebida";
                }
                else if (rad_doce.Checked)
                {
                    categoria = "Doce";
                }
                else if (rad_salgado.Checked)
                {
                    categoria = "Salgado";
                }
                else
                {
                    MessageBox.Show("Selecione uma categoria.");
                    return;
                }

                Produto novoProduto = new Produto();
                novoProduto.DefinirValores(txt_nome.Text, txt_preco.Text, nud_quantidade.Value, categoria);

                FormInicial.Compartilhador.listaprodutos.Add(novoProduto);

                txt_nome.Clear();
                txt_preco.Clear();
                nud_quantidade.Value = 0;
                rad_bebida.Checked = false;
                rad_doce.Checked = false;
                rad_salgado.Checked = false;
            }
        }
        public class Produto
        {
            public string? Nome { get; private set; }
            public double? Preco { get; private set; }
            public decimal? Quantidade { get; private set; }
            public string? Categoria { get; private set; }
            public virtual void DefinirValores(string nome, string preco, decimal quantidade, string categoria)
            {
                Nome = nome;
                Preco = Convert.ToDouble(preco);
                Quantidade = quantidade;
                Categoria = categoria;
            }
        };

        Produto novoProduto;

        public class Salgado : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade, string categoria)
            {
                base.DefinirValores(nome , preco, quantidade, categoria);
            }
        }
        public class Doce : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade, string categoria)
            {
                base.DefinirValores(nome, preco, quantidade, categoria);
            }
        }
        public class Bebida : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade, string categoria)
            {
                base.DefinirValores(nome, preco, quantidade, categoria);
            }
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
