using System.ComponentModel;
using static kira.vs.CadastrarProduto;

namespace kira.vs
{
    public partial class FormInicial : Form
    {
        public static FormInicial InstanciaAtiva { get; private set; }
        public FormInicial()
        {
            InitializeComponent();
            InstanciaAtiva = this;
        }

        public static class Compartilhador
        {
            public static BindingList<Produto> listaprodutos { get; } = new BindingList<Produto>();

            public static double lucrototal { get; private set; } = 0;
            public static void LucroTotal(double precototal)
            {
                lucrototal += precototal;
                InstanciaAtiva.txt_lucro.Text = lucrototal.ToString();
            }

            public static string RemoverAcentos(string texto)
            {
                string normalizado = texto.Normalize(System.Text.NormalizationForm.FormKD);
                string resultado = "";

                foreach (char letra in normalizado)
                {
                    if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(letra) != System.Globalization.UnicodeCategory.NonSpacingMark)
                    {
                        resultado += letra;
                    }
                }

                return resultado.Normalize(System.Text.NormalizationForm.FormC);
            }
        }


        private void btn_produto_Click(object sender, EventArgs e)
        {
            CadastrarProduto CadastrarProduto = new CadastrarProduto();
            this.Hide();
            CadastrarProduto.ShowDialog();
            this.Show();
        }

        private void btn_cadastros_Click(object sender, EventArgs e)
        {
            ProdutosCadastrados ProdutosCadastrados = new ProdutosCadastrados();
            this.Hide();
            ProdutosCadastrados.ShowDialog();
            this.Show();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            RealizarPedido RealizarPedido = new RealizarPedido(this);
            this.Hide();
            RealizarPedido.ShowDialog();
            this.Show();
        }
    }
}
