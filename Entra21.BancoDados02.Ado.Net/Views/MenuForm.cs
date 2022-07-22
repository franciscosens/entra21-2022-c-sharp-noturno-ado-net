﻿using Entra21.BancoDados02.Ado.Net.Views.Clientes;
using Entra21.BancoDados02.Ado.Net.Views.Pedidos;
using Entra21.BancoDados02.Ado.Net.Views.Produtos;

namespace Entra21.BancoDados02.Ado.Net.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            var clientesForm = new ClienteCadastroEdicaoForm();
            clientesForm.ShowDialog();
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            var produtosForm = new ProdutoCadastroEdicaoForm();
            produtosForm.ShowDialog();
        }

        private void buttonOrcamentos_Click(object sender, EventArgs e)
        {
            var orcamentoForm = new OrcamentoCadastroForm();
            orcamentoForm.ShowDialog();
        }
    }
}
