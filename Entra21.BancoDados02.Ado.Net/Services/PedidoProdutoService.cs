using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal class PedidoProdutoService : IPedidoProdutoService
    {
        private readonly Conexao _conexao;

        public PedidoProdutoService()
        {
            _conexao = new Conexao();
        }

        public void Apagar(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "DELETE FROM pedidos_produtos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(PedidoProduto pedidoProduto)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "INSERT INTO pedidos_produtos (id_pedido, id_produto, quantidade) VALUES (@ID_PEDIDO, @ID_PRODUTO, @QUANTIDADE)";

            comando.Parameters.AddWithValue("@ID_PEDIDO", pedidoProduto.Pedido.Id);
            comando.Parameters.AddWithValue("@ID_PRODUTO", pedidoProduto.Produto.Id);
            comando.Parameters.AddWithValue("@QUANTIDADE", pedidoProduto.Quantidade);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(PedidoProduto pedidoProduto)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "UPDATE pedidos_produtos SET quantidade = @QUANTIDADE WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", pedidoProduto.Id);
            comando.Parameters.AddWithValue("@QUANTIDADE", pedidoProduto.Quantidade);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
