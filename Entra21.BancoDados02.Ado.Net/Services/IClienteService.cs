using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IClienteService
    {
        List<Cliente> ObterTodosFiltrando(string nomePesquisa, ClienteListaFiltroStatus clienteListaFiltroStatus);
        Cliente ObterPorId(int id);
        void Cadastrar(Cliente cliente);
        void Editar(Cliente cliente);
        void Apagar(int id);
    }
}