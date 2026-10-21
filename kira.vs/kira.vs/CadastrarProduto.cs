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

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void btn_cadastrar_Click(object sender, EventArgs e)
        {
            bool cadastrado = true;
            char categoria = 'X';

            foreach (var item in listaprodutos)
            {
                if (RemoverAcentos(txt_nome.Text.Trim()).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase))
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

            if (cadastrado)
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
                MessageBox.Show("Insira dados válidos.", "Aviso");
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            bool removido = false;

            if(txt_nome.Text.Trim() == "")
            {
                MessageBox.Show("Nenhum item informado.", "Aviso");
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                "Você tem certeza de que quer remover este item do estoque?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    foreach (var item in listaprodutos.ToList())
                    {
                        if (RemoverAcentos(txt_nome.Text.Trim()).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase))
                        {
                            var remover =
                                    listaprodutos.FirstOrDefault(item => RemoverAcentos(item.Nome).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase));

                            if (remover != null)
                            {
                                listaprodutos.Remove(remover);
                            }

                            removido = true;
                        }
                    }
                }

                if (removido) {
                    txt_nome.Clear();
                }
                else
                {
                    MessageBox.Show("Item inexistente.", "Aviso");
                }
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
            } //se você digitar uma vírgula E ele tiver encontrado uma outra vírgula já em algum lugar do texto
        }
    }
}