namespace Entra21.BancoDados02.Ado.Net.Models
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal ValorTotalPedido { get; set; }

        public Cliente Cliente { get; set; }
        public List<PedidoProduto> PedidosProdutos { get; set; }

        public void CalcularValorTotalPedido()
        {
            var totalPedido = 0.0m;


            for (int i = 0; i < PedidosProdutos.Count; i++)
            {
                var pedidoProduto = PedidosProdutos[i];
                var valorProdutos = pedidoProduto.CalcularValorProdutos();

                totalPedido += valorProdutos;
            }

            ValorTotalPedido = totalPedido;
        }
    }
}
