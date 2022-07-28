using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Helpers;
using Entra21.BancoDados02.Ado.Net.Models;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;

namespace Entra21.BancoDados02.Ado.Net.Views.Pedidos
{
    public partial class OrcamentoListaForm : Form
    {
        private readonly PedidoService _pedidoService;
        private readonly ClienteService _clienteService;

        public OrcamentoListaForm()
        {
            InitializeComponent();

            _pedidoService = new PedidoService();
            _clienteService = new ClienteService();

            PreencherDataGridView();
            PreencherComboBoxClientes();
        }

        private void PreencherDataGridView()
        {
            var cliente = comboBoxCliente.SelectedItem as Cliente;
            var pedidoStatus = ObterPedidoStatus();

            var nomeCliente = cliente == null
                ? string.Empty
                : cliente.Nome;

            var orcamentos = _pedidoService.ObterTodos(nomeCliente, pedidoStatus);

            dataGridView.Rows.Clear();

            for (int i = 0; i < orcamentos.Count; i++)
            {
                var orcamento = orcamentos[i];

                dataGridView.Rows.Add(new object[]
                {
                    orcamento.Id,
                    orcamento.Cliente.Nome,
                    DecimalHelper.ObterValorFormatado(orcamento.ValorTotalPedido),
                    ObterStatus(orcamento.Status)
                });
            }
        }

        private object ObterStatus(PedidoStatus status)
        {
            if (status == PedidoStatus.OrcamentoFinalizado)
                return "Orçamento Finalizado";

            if (status == PedidoStatus.OrcamentoIniciado)
                return "Orçamento Iniciado";

            return "Gerado";
        }

        private PedidoStatus ObterPedidoStatus()
        {
            if (radioButtonOrcamentoTodos.Checked == true)
                return PedidoStatus.Todos;

            if (radioButtonOrcamentoIniciado.Checked == true)
                return PedidoStatus.OrcamentoIniciado;

            if (radioButtonPedidoGerado.Checked)
                return PedidoStatus.Gerado;

            return PedidoStatus.OrcamentoFinalizado;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var pedidoForm = new OrcamentoCadastroForm();
            pedidoForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void PreencherComboBoxClientes()
        {
            var clientes = _clienteService.ObterTodosFiltrando(
                string.Empty,
                ClienteListaFiltroStatus.Regular);

            if (clientes.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum cliente regular cadastrado");
                return;
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                comboBoxCliente.Items.Add(cliente);
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
