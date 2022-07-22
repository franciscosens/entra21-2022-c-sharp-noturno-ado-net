using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Models;
using System.Data;

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


        public List<PedidoProduto> ObterPorIdPedido(int idPedido)
        {
            var comando = new Conexao().ConectarCriandoComando();

            comando.CommandText = @"SELECT 
pro.id AS 'ProdutoId', 
pro.nome AS 'ProdutoNome',
pro.valor_unitario AS 'ProdutoValorUnitario',
pp.quantidade AS 'Quantidade'
FROM pedidos_produtos AS pp
INNER JOIN produtos AS pro ON(pp.id_produto = pro.id)
WHERE pp.id_pedido = @ID_PEDIDO";
            comando.Parameters.AddWithValue("@ID_PEDIDO", idPedido);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pedidoProdutos = new List<PedidoProduto>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var pedidoProduto = new PedidoProduto();
                pedidoProduto.Quantidade = Convert.ToInt32(registro["Quantidade"]);

                pedidoProduto.Produto = new Produto();
                pedidoProduto.Produto.ValorUnitario = Convert.ToDecimal(registro["ProdutoValorUnitario"]);
                pedidoProduto.Produto.Id = Convert.ToInt32(registro["ProdutoId"]);
                pedidoProduto.Produto.Nome = registro["ProdutoNome"].ToString();

                pedidoProdutos.Add(pedidoProduto);
            }

            return pedidoProdutos;
        }
    }
}
