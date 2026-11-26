
namespace SistemaPizzaria
{
    public class ItemPedido
    {
        private Produto produto;
        private int quantidade;

        public Produto Produto
        {
            get { return produto; }
        }

        public int Quantidade
        {
            get { return quantidade; }
        }

        public decimal Subtotal
        {
            get { return produto.Preco * quantidade; }
        }

        public ItemPedido(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                this.quantidade += quantidade;
            }
        }
    }
}
