using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows.Forms;
using static kira.vs.FormInicial.Compartilhador;

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
            bool cadastrado = true;
            char categoria = 'X';

            foreach (var item in listaprodutos)
            {
                if (RemoverAcentos(txt_nome.Text.Trim()).Equals(
                    RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase))
                {
                    cadastrado = false;
                    break;
                }
            }

            if (string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_preco.Text) || nud_quantidade.Value < 1)
            {
                cadastrado = false;
            }
            else
            {
                if (rad_salgado.Checked)
                {
                    categoria = 'S';

                }
                else if (rad_doce.Checked)
                {
                    categoria = 'D';
                }
                else if (rad_bebida.Checked)
                {
                    categoria = 'B';
                }
                else
                {
                    cadastrado = false;
                }
            }

            if (cadastrado == true)
            {
                if (categoria == 'S')
                {
                    Produto novoProduto = new Salgado();
                    novoProduto.DefinirValores(txt_nome.Text.Trim(), txt_preco.Text, nud_quantidade.Value);//trim remove espaços em branco no início e no final da string
                    listaprodutos.Add(novoProduto);
                }
                else if (categoria == 'D')
                {
                    Produto novoProduto = new Doce();
                    novoProduto.DefinirValores(txt_nome.Text.Trim(), txt_preco.Text, nud_quantidade.Value);
                    listaprodutos.Add(novoProduto);
                }
                else if (categoria == 'B')
                {
                    Produto novoProduto = new Bebida();
                    novoProduto.DefinirValores(txt_nome.Text.Trim(), txt_preco.Text, nud_quantidade.Value);
                    listaprodutos.Add(novoProduto);
                }

                txt_nome.Clear();
                txt_preco.Clear();
                nud_quantidade.Value = 0;
                rad_bebida.Checked = false;
                rad_doce.Checked = false;
                rad_salgado.Checked = false;
            }
            else
            {
                MessageBox.Show("Insira dados válidos.");
            }
        }

        public class Produto
        {
            public string Nome { get; private set; }
            public double Preco { get; private set; }
            public decimal Quantidade { get; private set; }
            public string Categoria { get; protected set; }

            public virtual void DefinirValores(string nome, string preco, decimal quantidade)
            {
                Nome = nome;
                Preco = Convert.ToDouble(preco);
                Quantidade = quantidade;
            }

            public void Venda(decimal quantidadevendida)
            {
                Quantidade -= quantidadevendida;
            }
        };

        public class Salgado : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade)
            {
                base.DefinirValores(nome, preco, quantidade);
                Categoria = "Salgado";
            }
        }
        public class Doce : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade)
            {
                base.DefinirValores(nome, preco, quantidade);
                Categoria = "Doce";
            }
        }
        public class Bebida : Produto
        {
            public override void DefinirValores(string nome, string preco, decimal quantidade)
            {
                base.DefinirValores(nome, preco, quantidade);
                Categoria = "Bebida";
            }
        }

        private void txt_preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
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