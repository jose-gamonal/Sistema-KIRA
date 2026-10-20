using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace kira.vs
{
    public partial class RealizarPedido : Form
    {
        public RealizarPedido()
        {
            InitializeComponent();
        }

        List<(string Nome, decimal Quantidade)> carrinho = new List<(string Nome, decimal Quantidade)>();
        int quantositensnocarrinho = 0;
        double precototal = 0;

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            bool registrado = false;

            if (quantositensnocarrinho < 9)
            {
                if (!String.IsNullOrWhiteSpace(txt_nome.Text) && nud_quantidade.Value > 0)
                {
                    foreach (var item in FormInicial.Compartilhador.listaprodutos)
                    {
                        if (txt_nome.Text == item.Nome)
                        {
                            if (nud_quantidade.Value > item.Quantidade)
                            {
                                MessageBox.Show("Quantidade informada maior do que quantidade em estoque.");
                                break;
                            }
                            else
                            {
                                if(quantositensnocarrinho == 0)
                                {
                                    lbl_carrinho.Text += $"{txt_nome.Text} x{nud_quantidade.Value}";
                                }
                                else
                                {
                                    lbl_carrinho.Text += $", {txt_nome.Text} x{nud_quantidade.Value}";
                                }
                                
                                carrinho.Add((txt_nome.Text, nud_quantidade.Value));
                                precototal += (item.Preco * Convert.ToDouble(nud_quantidade.Value));
                                registrado = true;
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
                    txt_total.Text = precototal.ToString();
                    txt_nome.Clear();
                    nud_quantidade.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Limite de itens atingido (8).");
            }

            quantositensnocarrinho += 1;
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            bool realizado = false;

            foreach(var lista in FormInicial.Compartilhador.listaprodutos)
            {
                foreach(var carrinho in carrinho)
                {
                    if(lista.Nome == carrinho.Nome)
                    {
                        lista.Venda(carrinho.Quantidade); // executa a função que diminui a quantidade
                        if (lista.Quantidade < 1)
                        {
                            var remover = FormInicial.Compartilhador.listaprodutos.FirstOrDefault(item => item.Nome == carrinho.Nome); //identifica a posição do item da lista a ser removido
                            FormInicial.Compartilhador.listaprodutos.Remove(remover);
                        }
                        realizado = true;
                        break;
                    }
                }
            }

            if(realizado == false){
                MessageBox.Show("Carrinho vazio."); // a ironia de ter uma variável chamada quantositensnocarrinho e não usar ela pra dizer que o carrinho está vazio
            }
            else
            {
                txt_total.Text = "";
                txt_nome.Clear();
                nud_quantidade.Value = 0;
                lbl_carrinho.Text = "> ";
            }
        }
    }
}
