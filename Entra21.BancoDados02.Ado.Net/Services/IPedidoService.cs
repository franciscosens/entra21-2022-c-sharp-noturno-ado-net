using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IPedidoService
    {
        List<Pedido> ObterTodos();
        Pedido ObterPorId(int id);
        int IniciarOrcamento(Pedido pedido);
        void GerarPedido(Pedido pedido);
        void FinalizarOrcamento(Pedido pedido);
        void Apagar(int id);
    }
}