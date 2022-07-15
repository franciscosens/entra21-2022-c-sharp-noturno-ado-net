using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Service
{
    //dois pontos seguido de uma interface, quer dizer que a classe será obrigada a implementar os métodos(contratos)
    //estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            //Conectar com o bd
            var conexao = new Conexao().Conectar();

            //Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            //Definindo o comando para apagar o registro
            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            //Executado comando 
            comando.ExecuteNonQuery();

            //Executado o comando para apagar o registro
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Sera descrito a implementação do contrato definido na interface

            var conexao = new Conexao().Conectar();

            //Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            //Especificando o comando que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) Values('" +
                tipoPersonagem.Tipo + "')";

            //Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(TipoPersonagem tipoPersonagem)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE tipos_personagens SET tipo = '" + tipoPersonagem.Tipo +
                "' WHERE id = " + tipoPersonagem.Id;
            
            // Executa o UPDATE na tabela de tipos_personagens
            comando.ExecuteNonQuery();

            // Fechar conexão
            comando.Connection.Close();
        }

        public TipoPersonagem ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            // Conectado no banco de dados e definido a query que será executada
            var comando = conexao.CreateCommand();
            comando.CommandText =
                "SELECT id, tipo FROM tipos_personagens WHERE id = '" + id + "'";

            // instanciado tabela em memória para armazenar os registros retornados da consulta SELECT
            var tabelaEmMemoria = new DataTable();

            // Executado a consulta na tabela de tipos_personagens armazenando-os na tabela em memória
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoPersonagem = new TipoPersonagem();
            // Obter a primeira coluna do select que é o Id
            tipoPersonagem.Id = Convert.ToInt32(primeiroRegistro[0]);
            // Obter a segunda coluna do select que é o Tipo
            tipoPersonagem.Tipo = primeiroRegistro[1].ToString();

            // Fechar conexão
            comando.Connection.Close();

            return tipoPersonagem;
        }

        public List<TipoPersonagem> ObterTodos()
        {
            //criar o comando para executar no banco de dados
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";


            //Criar tabela em memória para posteriormente carregar os registros obtidos com SELECT
            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            //percorrido cada um dos registros da tabelaEmMemoria (registros do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {

                //Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                //Instanciando objeto da classe TipoPersonagem preenchendo com as informações do SELECT, da linha que esta sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                //Adicionado tipoPersonagens instanciando na lista de TipoPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }
            //Fechar a conexão com o banco de dados 
            comando.Connection.Close();

            return tiposPersonagens;
        }


    }
}
