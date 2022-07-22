﻿using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Enums;
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

        public int IniciarOrcamento(Pedido pedido)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"INSERT INTO pedidos
(id_cliente, data_orcamento_abertura, modo_retirada, observacoes, status, valor_total) OUTPUT INSERTED.ID
VALUES (@ID_CLIENTE, @DATA_ORCAMENTO_ABERTURA, @MODO_RETIRADA, @OBSERVACOES, @STATUS, @VALOR_TOTAL)";

            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@DATA_ORCAMENTO_ABERTURA", pedido.DataOrcamentoAbertura);
            comando.Parameters.AddWithValue("@MODO_RETIRADA", pedido.ModoRetirada);
            comando.Parameters.AddWithValue("@OBSERVACOES", pedido.Observacoes);
            comando.Parameters.AddWithValue("@STATUS", pedido.Status);
            comando.Parameters.AddWithValue("@VALOR_TOTAL", pedido.ValorTotalPedido);

            var idPedido = Convert.ToInt32(comando.ExecuteScalar());

            comando.Connection.Close();

            return idPedido;
        }

        public void FinalizarOrcamento(Pedido pedido)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"UPDATE pedidos SET 
data_finalizacao_orcamento = @DATA_FINALIZACAO_ORCAMENTO,
observacoes = @OBSERVACOES,
status = @STATUS,
valor_total = @VALOR_TOTAL_PEDIDO
WHERE id = @ID_PEDIDO";

            comando.Parameters.AddWithValue("@DATA_FINALIZACAO_ORCAMENTO", DateTime.Now);
            comando.Parameters.AddWithValue("@OBSERVACOES", pedido.Observacoes);
            comando.Parameters.AddWithValue("@STATUS", PedidoStatus.OrcamentoFinalizado);
            comando.Parameters.AddWithValue("@VALOR_TOTAL_PEDIDO", pedido.ValorTotalPedido);
            comando.Parameters.AddWithValue("@ID_PEDIDO", pedido.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void GerarPedido(Pedido pedido)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"UPDATE pedidos SET 
data_pedido_gerado = @DATA_PEDIDO_GERADO,
data_finalizacao_orcamento = @DATA_FINALIZACAO_ORCAMENTO,
observacoes = @OBSERVACOES,
status = @STATUS,
valor_total = @VALOR_TOTAL_PEDIDO
WHERE id = @ID_PEDIDO";

            comando.Parameters.AddWithValue("@DATA_FINALIZACAO_ORCAMENTO", DateTime.Now);
            comando.Parameters.AddWithValue("@DATA_FINALIZACAO_ORCAMENTO", DateTime.Now);
            comando.Parameters.AddWithValue("@OBSERVACOES", pedido.Observacoes);
            comando.Parameters.AddWithValue("@STATUS", PedidoStatus.Gerado);
            comando.Parameters.AddWithValue("@VALOR_TOTAL_PEDIDO", pedido.ValorTotalPedido);
            comando.Parameters.AddWithValue("@ID_PEDIDO", pedido.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Pedido ObterPorId(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"SELECT 
p.id AS 'PedidoId',
p.data_orcamento_abertura AS 'PedidoDataOrcamentoAberto',
p.data_orcamento_finalizacao AS 'PedidoDataOrcamentoFinalizado',
p.data_pedido_gerado AS 'PedidoDataGerado',
p.valor_total AS 'PedidoValorTotalPedido',
p.modo_retirada AS 'PedidoModoRetirada',
p.status AS 'PedidoStatus',
p.observacoes AS 'PedidoObservacoes',
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
            pedido.Observacoes = registro["PedidoObservacoes"].ToString();
            //pedido.ModoRetirada = Convert.ToInt32(registro["PedidoModoRetirada"]) as PedidoModoRetirada;
            //pedido.Status = Convert.ToInt32(registro["PedidoStatus"]) as PedidoStatus;

            pedido.ValorTotalPedido = Convert.ToDecimal(registro["PedidoValorTotalPedido"]);
            pedido.DataOrcamentoAbertura = Convert.ToDateTime(registro["PedidoDataOrcamentoAberto"]);
            pedido.DataOrcamentoFinalizado = Convert.ToDateTime(registro["PedidoDataOrcamentoFinalizado"]);
            pedido.DataPedidoGerado = Convert.ToDateTime(registro["PedidoDataGerado"]);

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
                pedido.DataOrcamentoAbertura = Convert.ToDateTime(registro["PedidoDataCompra"]);

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
