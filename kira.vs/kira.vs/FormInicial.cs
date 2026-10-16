using System.ComponentModel;
using static kira.vs.CadastrarProduto;
using static kira.vs.ProdutosCadastrados;

namespace kira.vs
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        public static class Compartilhador
        {
            public static BindingList<CadastrarProduto.Produto> listaprodutos { get; } = new BindingList<CadastrarProduto.Produto>();
        }

        // Cada função abaixo abre o popup do formulário correspondente e fecha o anterior
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
            RealizarPedido RealizarPedido = new RealizarPedido();
            this.Hide();
            RealizarPedido.ShowDialog();
            this.Show();
        }
    }
}
