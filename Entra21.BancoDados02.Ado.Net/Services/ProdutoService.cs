using Entra21.BancoDados02.Ado.Net.Database;
using Entra21.BancoDados02.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal class ProdutoService : IProdutoService
    {
        private readonly Conexao _conexao;

        public ProdutoService()
        {
            _conexao = new Conexao();
        }
        
        public void Apagar(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "DELETE FROM produtos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Produto produto)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "INSERT INTO produtos (nome, valor_unitario) VALUES (@NOME, @VALOR_UNITARIO)";

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@VALOR_UNITARIO", produto.ValorUnitario);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Produto produto)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = @"UPDATE produtos SET 
nome = @NOME, 
valor_unitario = @VALOR_UNITARIO
WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@VALOR_UNITARIO", produto.ValorUnitario);
            comando.Parameters.AddWithValue("@ID", produto.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Produto ObterPorId(int id)
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "SELECT id, nome, valor_unitario FROM produtos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var produto = new Produto();
            produto.Id = Convert.ToInt32(registro["id"]);
            produto.Nome = registro["nome"].ToString();
            produto.ValorUnitario = Convert.ToDecimal(registro["valor_unitario"]);

            comando.Connection.Close();

            return produto;
        }

        public List<Produto> ObterTodos()
        {
            var comando = _conexao.ConectarCriandoComando();
            comando.CommandText = "SELECT id, nome, valor_unitario FROM produtos";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var produtos = new List<Produto>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();
                produto.ValorUnitario = Convert.ToDecimal(registro["valor_unitario"]);

                produtos.Add(produto);
            }

            comando.Connection.Close();

            return produtos;
        }
    }
}
