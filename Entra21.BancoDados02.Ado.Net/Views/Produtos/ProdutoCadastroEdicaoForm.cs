using Entra21.BancoDados02.Ado.Net.Helpers;
using Entra21.BancoDados02.Ado.Net.Models;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;
using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.Views.Produtos
{
    public partial class ProdutoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private readonly ProdutoService _produtoService;

        private const int modoCadastro = -1;

        public ProdutoCadastroEdicaoForm()
        {
            InitializeComponent();

            _produtoService = new ProdutoService();

            _idParaEditar = modoCadastro;
        }
        public ProdutoCadastroEdicaoForm(Produto produto) : this()
        {
            _idParaEditar = produto.Id;
            textBoxNome.Text = produto.Nome;
            textBoxValorUnitario.Text = DecimalHelper.ObterValorFormatado(produto.ValorUnitario);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            decimal valorUnitario;
            try
            {
                valorUnitario = Convert.ToDecimal(DecimalHelper.RemoverMoedaConverterDecimal(textBoxValorUnitario.Text));
            }
            catch (Exception)
            {
                CustomMessageBox.ShowError("Campo de valor unitário deve conter somente valores decimais.");

                textBoxValorUnitario.Focus();

                return;
            }

            try
            {
                var produto = new Produto();
                produto.Nome = nome;
                produto.ValorUnitario = valorUnitario;

                if (_idParaEditar == modoCadastro)
                    Cadastrar(produto);
                else
                    Editar(produto);
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível salvar este registro, desculpe pelo incomodo");
            }
        }

        private void Cadastrar(Produto produto)
        {
            _produtoService.Cadastrar(produto);

            CustomMessageBox.ShowSuccess("Produto cadastrado com sucesso");

            Close();
        }

        private void Editar(Produto produto)
        {
            produto.Id = _idParaEditar;

            _produtoService.Editar(produto);

            CustomMessageBox.ShowSuccess("Produto alterado com sucesso ");

            Close();
        }
    }
}
