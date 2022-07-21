using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.Database
{
    internal class Conexao
    {
        public SqlCommand ConectarCriandoComando()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|BancoDados.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }
    }
}
