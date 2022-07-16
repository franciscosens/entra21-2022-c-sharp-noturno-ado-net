﻿using Entra21.BancoDados02.Ado.Net.Models;

namespace Entra21.BancoDados02.Ado.Net.Services
{
    internal interface IProdutoService
    {
        List<Produto> ObterTodos();
        Produto ObterPorId(int id);
        void Cadastrar(Produto produto);
        void Editar(Produto produto);
        void Apagar(int id);
    }
}