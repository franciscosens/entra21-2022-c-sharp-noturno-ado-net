using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IClienteService
    {
        List<Cliente> ObterTodos();
        Cliente ObterPorId(int id);
        void Cadastrar(Cliente cliente);
        void Editar(Cliente cliente);
        void Apagar(int id);
    }
}