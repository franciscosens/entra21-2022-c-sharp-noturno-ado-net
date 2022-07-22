using Entra21.BancoDados02.Ado.Net.Enums;

namespace Entra21.BancoDados02.Ado.Net.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataOrcamentoFinalizado { get; set; }
        public DateTime DataOrcamentoAbertura { get; set; }
        public DateTime DataPedidoGerado { get; set; }
        public decimal ValorTotalPedido { get; set; }
        public string Observacoes { get; internal set; }
        public PedidoStatus Status { get; set; }
        public PedidoModoRetirada ModoRetirada { get; internal set; }

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
