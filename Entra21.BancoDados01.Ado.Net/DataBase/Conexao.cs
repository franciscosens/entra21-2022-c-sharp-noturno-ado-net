using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            //Instanciado um objeto da classe SqlConnection, que permitirá
            //Fazer selects, inserts, updates, deletes, etc...
            SqlConnection conexao = new SqlConnection();

            //String que contem o caminho para o banco de dados, o que permitira conectar ao bando de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\SERVER\Profs-E21\francisco.sens\Downloads\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            //Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            //Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
