using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using static kira.vs.FormInicial.Compartilhador;

namespace kira.vs
{
    public partial class RealizarPedido : Form
    {
        private FormInicial formPai;
        public RealizarPedido(FormInicial form_Pai) // traz pra dentro do escopo do filho a informação de qual instância é o formulário inicial, a fim de atualizar a txtbox do lucrototal (linha ~90)
        {
            InitializeComponent();
            formPai = form_Pai;
        }

        List<(string Nome, decimal Quantidade)> carrinho = new List<(string Nome, decimal Quantidade)>();

        double precototal = 0;

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            {
                bool registrado = false;

                if (carrinho.Count < 9)
                {
                    if (!String.IsNullOrWhiteSpace(txt_nome.Text) && nud_quantidade.Value > 0)
                    {
                        foreach (var item in listaprodutos)
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
                                        carrinho[existente] = (
                                            carrinho[existente].Nome,
                                            carrinho[existente].Quantidade + nud_quantidade.Value
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
                            formPai.txt_lucro.Text = LucroTotal(precototal).ToString();
                            txt_nome.Clear();
                            nud_quantidade.Value = 0;
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

            foreach (var lista in listaprodutos.ToList())
            {
                foreach (var item in carrinho)
                {
                    if (RemoverAcentos(lista.Nome).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase))
                    {
                        lista.Venda(item.Quantidade);

                        if (lista.Quantidade < 1)
                        {
                            var remover =
                                listaprodutos.FirstOrDefault(item => RemoverAcentos(item.Nome).Equals(RemoverAcentos(item.Nome), StringComparison.OrdinalIgnoreCase));

                            if (remover != null)
                            {
                                listaprodutos.Remove(remover);
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
                nud_quantidade.Value = 0;
                lbl_carrinho.Text = "> ";
            }

            btn_adicionar.Focus();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            ProdutosCadastrados ProdutosCadastrados = new ProdutosCadastrados();
            ProdutosCadastrados.ShowDialog();
            btn_adicionar.Focus();
        }
    }
}