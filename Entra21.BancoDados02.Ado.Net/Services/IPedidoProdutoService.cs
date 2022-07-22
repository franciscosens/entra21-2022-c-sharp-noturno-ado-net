using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IPedidoProdutoService
    {
        void Cadastrar(PedidoProduto pedidoProduto);
        void Editar(PedidoProduto pedidoProduto);
        void Apagar(int id);
        List<PedidoProduto> ObterPorIdPedido(int idPedido);
    }
}