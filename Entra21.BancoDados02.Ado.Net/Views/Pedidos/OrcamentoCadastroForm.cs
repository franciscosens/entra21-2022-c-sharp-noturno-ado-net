using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Helpers;
using Entra21.BancoDados02.Ado.Net.Models;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;

namespace Entra21.BancoDados02.Ado.Net.Views.Pedidos
{
    public partial class OrcamentoCadastroForm : Form
    {
        private readonly PedidoService _pedidoService;
        private readonly ClienteService _clienteService;
        private readonly ProdutoService _produtoService;
        private readonly PedidoProdutoService _pedidoProdutoService;

        private Produto produtoSelecionado;
        private int idPedido;
        private Cliente clienteSelecionado;

        public OrcamentoCadastroForm()
        {
            InitializeComponent();

            _pedidoService = new PedidoService();
            _clienteService = new ClienteService();
            _produtoService = new ProdutoService();
            _pedidoProdutoService = new PedidoProdutoService();

            PreencherComboBoxClientes();
            PreencherComboBoxProdutos();
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

        private void PreencherComboBoxProdutos()
        {
            var produtos = _produtoService.ObterTodos(
                string.Empty,
                decimal.MinValue,
                decimal.MinValue);

            if (produtos.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum produto cadastrado");
                return;
            }

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                comboBoxProduto.Items.Add(produto);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonIniciarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                var pedido = new Pedido();
                pedido.ModoRetirada = ObterModoRetirada();
                pedido.Cliente = clienteSelecionado;
                pedido.Observacoes = richTextBoxObservacoes.Text.Trim();
                pedido.DataOrcamentoAbertura = DateTime.Now;
                pedido.Status = PedidoStatus.OrcamentoIniciado;
                pedido.ValorTotalPedido = 0.0m;

                idPedido = _pedidoService.IniciarOrcamento(pedido);

                HabilitarCamposDetalhesOrcamento();
            }
            catch (Exception)
            {
                CustomMessageBox.ShowError("Não foi possível iniciar este orçamento, desculpe pelo incomodo");
            }
        }

        private PedidoModoRetirada ObterModoRetirada()
        {
            if (radioButtonModoRetiradaEntrega.Checked)
                return PedidoModoRetirada.Entrega;

            return PedidoModoRetirada.Loja;
        }

        private void HabilitarCamposDetalhesOrcamento()
        {
            comboBoxCliente.Enabled = false;
            comboBoxProduto.Enabled = true;
            labelProduto.Enabled = true;
            labelProdutoObrigatoriedade.Enabled = true;
            dataGridView.Enabled = true;

            buttonIniciarOrcamento.Enabled = false;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedIndex == -1)
                return;

            produtoSelecionado = comboBoxProduto.SelectedItem as Produto;
            labelProdutoValorUnitarioValor.Text = DecimalHelper.ObterValorFormatado(produtoSelecionado.ValorUnitario);

            var quantidade = Convert.ToInt32(numericUpDownQuantidade.Value);
            var valorProdutos = produtoSelecionado.ValorUnitario * quantidade;

            labelProdutoValorTotalValor.Text = DecimalHelper.ObterValorFormatado(valorProdutos);

            numericUpDownQuantidade.Enabled = true;
            buttonAdicionarProduto.Enabled = true;
            labelQuantidade.Enabled = true;
            labelProdutoValorUnitario.Enabled = true;
            labelProdutoValorUnitarioValor.Enabled = true;
            labelProdutoValorTotal.Enabled = true;
            labelProdutoValorTotalValor.Enabled = true;

            labelQuantidadeObrigatoriedade.Enabled = true;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedIndex == -1)
                return;

            clienteSelecionado = comboBoxCliente.SelectedItem as Cliente;


            buttonIniciarOrcamento.Enabled = true;
            labelModoRetirada.Enabled = true;
            labelModoRetiradaObrigatoriedade.Enabled = true;
            radioButtonModoRetiradaEntrega.Enabled = true;
            radioButtonModoRetiradaLoja.Enabled = true;
            richTextBoxObservacoes.Enabled = true;
            labelObservacoes.Enabled = true;
        }

        private void numericUpDownQuantidade_ValueChanged(object sender, EventArgs e)
        {
            var quantidade = Convert.ToInt32(numericUpDownQuantidade.Value);

            if (quantidade > 0)
            {
                var valorTotal = quantidade * produtoSelecionado.ValorUnitario;
                labelProdutoValorTotalValor.Text = DecimalHelper.ObterValorFormatado(valorTotal);
            }
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            var pedidoProduto = new PedidoProduto();
            pedidoProduto.Pedido = new Pedido();
            pedidoProduto.Pedido.Id = idPedido;
            pedidoProduto.Produto = produtoSelecionado;
            pedidoProduto.Quantidade = Convert.ToInt32(numericUpDownQuantidade.Value);

            _pedidoProdutoService.Cadastrar(pedidoProduto);

            PreencherDataGridViewProdutosOrcados();
            HabilitarBotoesFinalizar();
            LimparCamposDesabilitandoCampos();

            CustomMessageBox.ShowSuccess("Adicionado com sucesso produto ao orçamento");
        }

        private void LimparCamposDesabilitandoCampos()
        {
            numericUpDownQuantidade.Value = 1;
            comboBoxProduto.SelectedIndex = -1;

            numericUpDownQuantidade.Enabled = false;
            buttonAdicionarProduto.Enabled = false;
            labelQuantidade.Enabled = false;
            labelProdutoValorUnitario.Enabled = false;
            labelProdutoValorUnitarioValor.Enabled = false;
            labelProdutoValorTotal.Enabled = false;
            labelProdutoValorTotalValor.Enabled = false;
        }

        private void PreencherDataGridViewProdutosOrcados()
        {
            var produtosPedido = _pedidoProdutoService.ObterPorIdPedido(idPedido);

            dataGridView.Rows.Clear();

            var valorTotalOrcamento = 0m;

            for (int i = 0; i < produtosPedido.Count; i++)
            {
                var produtoPedido = produtosPedido[i];

                var valorProdutos = produtoPedido.CalcularValorProdutos();
                valorTotalOrcamento += valorProdutos;

                dataGridView.Rows.Add(new object[] {
                    $"{produtoPedido.Produto.Id} - {produtoPedido.Produto.Nome}",
                    produtoPedido.Quantidade,
                    DecimalHelper.ObterValorFormatado(produtoPedido.Produto.ValorUnitario),
                    DecimalHelper.ObterValorFormatado(valorProdutos)
                });
            }

            labelQuantidadeItensValor.Text = produtosPedido.Count.ToString();
            labelTotalOrcamentoValor.Text = DecimalHelper.ObterValorFormatado(valorTotalOrcamento);
        }

        private void HabilitarBotoesFinalizar()
        {
            if (dataGridView.Rows.Count == 0)
                return;

            labelTotalOrcamento.Enabled = true;
            labelTotalOrcamentoValor.Enabled = true;
            labelQuantidadeItens.Enabled = true;
            labelQuantidadeItensValor.Enabled = true;
            buttonFinalizarOrcamento.Enabled = true;
            buttonGerarPedido.Enabled = true;
        }

        private void buttonGerarPedido_Click(object sender, EventArgs e)
        {

        }
    }
}
