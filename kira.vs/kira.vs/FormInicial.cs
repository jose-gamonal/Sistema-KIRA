namespace kira.vs
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        // Cada função abaixo abre o popup do formulário correspondente
        private void btn_produto_Click(object sender, EventArgs e)
        {
            CadastrarProduto CadastrarProduto = new CadastrarProduto();

            CadastrarProduto.ShowDialog();
        }

        private void btn_cadastros_Click(object sender, EventArgs e)
        {
            ProdutosCadastrados ProdutosCadastrados = new ProdutosCadastrados();

            ProdutosCadastrados.ShowDialog();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            RealizarPedido RealizarPedido = new RealizarPedido();

            RealizarPedido.ShowDialog();
        }
    }
}
