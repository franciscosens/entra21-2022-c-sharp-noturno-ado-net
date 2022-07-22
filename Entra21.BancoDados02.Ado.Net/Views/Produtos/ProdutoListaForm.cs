using Entra21.BancoDados02.Ado.Net.Helpers;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;
using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.Views.Produtos
{
    public partial class ProdutoListaForm : Form
    {
        private readonly ProdutoService _produtoService;

        public ProdutoListaForm()
        {
            InitializeComponent();

            _produtoService = new ProdutoService();

            PreencherDataGridView();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var produtoForm = new ProdutoCadastroEdicaoForm();

            produtoForm.ShowDialog();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var nomePesquisa = textBoxNome.Text.Trim();

            var minimoValorUnitario = ObterValorUnitarioMinimoPesquisa();

            var maximoValorUnitario = ObterValorUnitarioMaximoPesquisa();

            var produtos = _produtoService.ObterTodos(nomePesquisa, minimoValorUnitario, maximoValorUnitario);

            dataGridView.Rows.Clear();
            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];

                dataGridView.Rows.Add(new object[] {
                    produto.Id,
                    produto.Nome,
                    DecimalHelper.ObterValorFormatado(produto.ValorUnitario)
                });
            }
        }

        private decimal ObterValorUnitarioMaximoPesquisa()
        {
            try
            {
                var text = textBoxValorUnitarioMaximo.Text;

                if (text.Length == 0)
                    return decimal.MinValue;

                var valorUnitarioMaximo = DecimalHelper.RemoverMoedaConverterDecimal(text);

                return valorUnitarioMaximo;
            }
            catch (FormatException)
            {

                CustomMessageBox.ShowError("Valor máximo não é um decimal válido");
                textBoxValorUnitarioMaximo.Focus();

                return decimal.MinValue;
            }
        }

        private decimal ObterValorUnitarioMinimoPesquisa()
        {
            try
            {
                var text = textBoxValorUnitarioMinimo.Text;

                if (text.Length == 0)
                    return decimal.MinValue;

                var valorUnitarioMinimo = DecimalHelper.RemoverMoedaConverterDecimal(text);

                return valorUnitarioMinimo;
            }
            catch (FormatException)
            {

                CustomMessageBox.ShowError("Valor mínimo não é um decimal válido");
                textBoxValorUnitarioMinimo.Focus();

                return decimal.MinValue;
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum produto cadastrado");

                return;
            }

            if (dataGridView.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum produto selecionado");

                return;
            }

            var desejaApagar = MessageBox.Show("Deseja realmente apagar?", "CUIDADO", MessageBoxButtons.YesNo);

            if (desejaApagar != DialogResult.Yes)
                return;

            var registroSelecionado = dataGridView.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                _produtoService.Apagar(idRegistroSelecionado);

                CustomMessageBox.ShowSuccess("Produto apagado com sucesso");

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível apagar este registro, desculpe pelo incomodo");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridView.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum produto cadastrado");

                return;
            }

            if (dataGridView.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum produto selecionado");

                return;
            }

            var registroSelecionado = dataGridView.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                var produto = _produtoService.ObterPorId(idRegistroSelecionado);

                var produtoForm = new ProdutoCadastroEdicaoForm(produto);

                produtoForm.ShowDialog();

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível buscar este registro, desculpe pelo incomodo");
            }
        }
    }
}
