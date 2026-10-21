using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace kira.vs
{
    public partial class RealizarPedido : Form
    {
        public RealizarPedido()
        {
            InitializeComponent();
            nud_quantidade.Minimum = 1;
        }



        List<(string Nome, decimal Quantidade)> carrinho = new List<(string Nome, decimal Quantidade)>();

        double precototal = 0;
        private string RemoverAcentos(string texto)
        {
            string normalizado = texto.Normalize(System.Text.NormalizationForm.FormD);
            string resultado = "";

            foreach (char letra in normalizado)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(letra)
                    != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    resultado += letra;
                }
            }

            return resultado.Normalize(System.Text.NormalizationForm.FormC);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            {
                bool registrado = false;

                if (carrinho.Count < 8)
                {
                    if (!String.IsNullOrWhiteSpace(txt_nome.Text) && nud_quantidade.Value > 0)
                    {
                        foreach (var item in FormInicial.Compartilhador.listaprodutos)
                        {
                            if (RemoverAcentos(txt_nome.Text.Trim()).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase))
                            {
                                decimal reservado = carrinho
                                .Where(x => x.Nome.Equals(item.Nome, StringComparison.OrdinalIgnoreCase))
                                .Sum(x => x.Quantidade);

                                if (nud_quantidade.Value > item.Quantidade - reservado)
                                {
                                    MessageBox.Show("Quantidade informada maior do que quantidade em estoque.");
                                    registrado = true;
                                    break;
                                }
                                else
                                {
                                    var existente = carrinho.FindIndex(x => RemoverAcentos(x.Nome).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase));

                                    if (existente != -1)
                                    {
                                        var produtoCarrinho = carrinho[existente];

                                        carrinho[existente] = (
                                            produtoCarrinho.Nome,
                                            produtoCarrinho.Quantidade + nud_quantidade.Value
                                        );
                                    }
                                    else
                                    {
                                        carrinho.Add((item.Nome, nud_quantidade.Value));
                                    }

                                    lbl_carrinho.Text = "> ";

                                    foreach (var produto in carrinho)
                                    {
                                        lbl_carrinho.Text += $"{produto.Nome} x{produto.Quantidade}, ";
                                    }

                                    lbl_carrinho.Text = lbl_carrinho.Text.TrimEnd(',', ' ');

                                    precototal += item.Preco * Convert.ToDouble(nud_quantidade.Value);
                                    registrado = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (registrado == false)
                    {
                        MessageBox.Show("Insira dados válidos.");
                    }
                    else
                    {
                        if (carrinho.Count > 0)
                        {
                            txt_total.Text = precototal.ToString();
                            txt_nome.Clear();
                            nud_quantidade.Value = 1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Limite de itens atingido (8).");
                }
            }
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            bool realizado = false;

            foreach (var lista in FormInicial.Compartilhador.listaprodutos.ToList())
            {
                foreach (var ItemCarrinho in carrinho)
                {
                    if (RemoverAcentos(lista.Nome).Equals(
                        RemoverAcentos(ItemCarrinho.Nome),
                        StringComparison.OrdinalIgnoreCase))
                    {
                        lista.Venda(ItemCarrinho.Quantidade);

                        if (lista.Quantidade < 1)
                        {
                            var remover = FormInicial.Compartilhador.listaprodutos.FirstOrDefault(
                                item => RemoverAcentos(item.Nome).Equals(
                                    RemoverAcentos(ItemCarrinho.Nome),
                                    StringComparison.OrdinalIgnoreCase)
                            );

                            if (remover != null)
                            {
                                FormInicial.Compartilhador.listaprodutos.Remove(remover);
                            }
                        }

                        realizado = true;
                        break;
                    }
                }
            }

            if (realizado == false)
            {
                MessageBox.Show("Carrinho vazio.");
            }
            else
            {
                carrinho.Clear();
                txt_total.Text = "";
                precototal = 0;
                txt_nome.Clear();
                nud_quantidade.Value = 1;
                lbl_carrinho.Text = "> ";
            }
        }
    }
}