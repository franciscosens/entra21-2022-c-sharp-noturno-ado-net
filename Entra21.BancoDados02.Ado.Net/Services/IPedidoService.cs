using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IPedidoService
    {
        List<Pedido> ObterTodos();
        Pedido ObterPorId(int id);
        void Cadastrar(Pedido pedido);
        void Editar(Pedido pedido);
        void Apagar(int id);
    }
}