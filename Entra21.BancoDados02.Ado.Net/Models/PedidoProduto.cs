namespace Entra21.BancoDados02.Ado.Net.Models
{
    internal class PedidoProduto
    {
        public int Quantidade { get; set; }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public decimal CalcularValorProdutos()
        {
            return Quantidade * Produto.ValorUnitario;
        }
    }
}
