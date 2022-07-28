using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IPedidoService
    {
        List<Pedido> ObterTodos(string nomeCliente, PedidoStatus pedidoStatus);
        Pedido ObterPorId(int id);
        int IniciarOrcamento(Pedido pedido);
        void GerarPedido(Pedido pedido);
        void FinalizarOrcamento(Pedido pedido);
        void Apagar(int id);
    }
}