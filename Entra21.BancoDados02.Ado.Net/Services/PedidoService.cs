using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal class PedidoService : IPedidoService
    {
        private readonly Conexao _conexao;

        public PedidoService()
        {
            _conexao = new Conexao();
        }

        public void Apagar(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "DELETE FROM pedidos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Pedido pedido)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"INSERT INTO pedidos
(id_cliente, data_compra, valor_total_pedido) 
VALUES (@ID_CLIENTE, @DATA_COMPRA, @VALOR_TOTAL_PEDIDO)";

            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@DATA_COMPRA", pedido.DataCompra);
            comando.Parameters.AddWithValue("@VALOR_TOTAL_PEDIDO", pedido.ValorTotalPedido);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Pedido pedido)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"UPDATE pedidos SET 
id_cliente = @ID_CLIENTE,
data_compra = @DATA_COMPRA,
valor_total_pedido = @VALOR_TOTAL_PEDIDO
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@DATA_COMPRA", pedido.DataCompra);
            comando.Parameters.AddWithValue("@VALOR_TOTAL_PEDIDO", pedido.ValorTotalPedido);
            comando.Parameters.AddWithValue("@ID", pedido.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Pedido ObterPorId(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"SELECT 
p.id AS 'PedidoId',
p.data_compra AS 'PedidoDataCompra',
p.valor_total_pedido AS 'PedidoValorTotalPedido',
c.id AS 'ClienteId',
c.nome AS 'ClienteNome'
FROM pedidos p
INNER JOIN c ON(p.id_cliente = c.id)
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var pedido = new Pedido();
            pedido.Id = Convert.ToInt32(registro["PedidoId"]);
            pedido.ValorTotalPedido = Convert.ToDecimal(registro["PedidoValorTotalPedido"]);
            pedido.DataCompra = Convert.ToDateTime(registro["PedidoDataCompra"]);

            pedido.Cliente = new Cliente();
            pedido.Cliente.Id = Convert.ToInt32(registro["ClienteId"]);
            pedido.Cliente.Nome = registro["ClienteId"].ToString();

            comando.Connection.Close();

            return pedido;
        }

        public List<Pedido> ObterTodos()
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"SELECT 
p.id AS 'PedidoId',
p.data_compra AS 'PedidoDataCompra',
p.valor_total_pedido AS 'PedidoValorTotalPedido',
c.id AS 'ClienteId',
c.nome AS 'ClienteNome'
FROM pedidos p
INNER JOIN c ON(p.id_cliente = c.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var pedidos = new List<Pedido>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var pedido = new Pedido();
                pedido.Id = Convert.ToInt32(registro["PedidoId"]);
                pedido.ValorTotalPedido = Convert.ToDecimal(registro["PedidoValorTotalPedido"]);
                pedido.DataCompra = Convert.ToDateTime(registro["PedidoDataCompra"]);

                pedido.Cliente = new Cliente();
                pedido.Cliente.Id = Convert.ToInt32(registro["ClienteId"]);
                pedido.Cliente.Nome = registro["ClienteId"].ToString();

                pedidos.Add(pedido);
            }

            comando.Connection.Close();

            return pedidos;
        }
    }
}
