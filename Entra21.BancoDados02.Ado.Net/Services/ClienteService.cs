using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal class ClienteService : IClienteService
    {
        private readonly Conexao _conexao;

        public ClienteService()
        {
            _conexao = new Conexao();
        }

        public void Apagar(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "DELETE FROM clientes WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cliente cliente)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"INSERT INTO clientes
(nome, renda, cpf, data_nascimento, eh_inadimplente, observacao) 
VALUES (@NOME, @RENDA, @CPF, @DATA_NASCIMENTO, @EH_INADIMPLENTE, @OBSERVACAO)";

            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@RENDA", cliente.Renda);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@EH_INADIMPLENTE", cliente.EhInadimplente);
            comando.Parameters.AddWithValue("@OBSERVACAO", cliente.Observacao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Cliente cliente)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"UPDATE clientes SET 
nome = @NOME,
renda = @RENDA,
cpf = @CPF,
data_nascimento = @DATA_NASCIMENTO,
eh_inadimplente = @EH_INADIMPLENTE,
observacao = @OBSERVACAO
WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", cliente.Nome);
            comando.Parameters.AddWithValue("@RENDA", cliente.Renda);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@EH_INADIMPLENTE", cliente.EhInadimplente);
            comando.Parameters.AddWithValue("@OBSERVACAO", cliente.Observacao);
            comando.Parameters.AddWithValue("@ID", cliente.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Cliente ObterPorId(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"SELECT id, nome, renda, cpf, data_nascimento, eh_inadimplente, observacao
FROM clientes
WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(registro["id"]);
            cliente.Nome = registro["nome"].ToString();
            cliente.Cpf = registro["cpf"].ToString();
            cliente.Observacao = registro["observacao"].ToString();
            cliente.Renda = Convert.ToDecimal(registro["renda"]);
            cliente.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
            cliente.EhInadimplente = Convert.ToBoolean(registro["eh_inadimplente"]);

            comando.Connection.Close();

            return cliente;
        }

        public List<Cliente> ObterTodosFiltrando(
            string nomePesquisa,
            ClienteListaFiltroStatus clienteListaFiltroStatus)
        {
            var comando = _conexao.ConectarCriandoComando();

            comando.CommandText = @"SELECT 
id, nome, renda, cpf, data_nascimento, eh_inadimplente
FROM clientes 
WHERE nome LIKE @NOME";
            comando.Parameters.AddWithValue("@NOME", $"%{nomePesquisa}%");

            if (clienteListaFiltroStatus == ClienteListaFiltroStatus.Inadimplente ||
                clienteListaFiltroStatus == ClienteListaFiltroStatus.Regular)
            {
                comando.CommandText += " AND eh_inadimplente = @EH_INADIMPLENTE";

                comando.Parameters.AddWithValue("@EH_INADIMPLENTE", clienteListaFiltroStatus == ClienteListaFiltroStatus.Inadimplente);
            }


            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var clientes = new List<Cliente>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(registro["id"]);
                cliente.Nome = registro["nome"].ToString();
                cliente.Cpf = registro["cpf"].ToString();
                cliente.Renda = Convert.ToDecimal(registro["renda"]);
                cliente.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
                cliente.EhInadimplente = Convert.ToBoolean(registro["eh_inadimplente"]);

                clientes.Add(cliente);
            }

            comando.Connection.Close();

            return clientes;
        }
    }
}