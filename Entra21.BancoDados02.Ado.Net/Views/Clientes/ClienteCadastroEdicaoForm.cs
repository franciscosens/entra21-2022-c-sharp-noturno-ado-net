using Entra21.BancoDados02.Ado.Net.Helpers;
using Entra21.BancoDados02.Ado.Net.Models;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;
using System.Data.SqlClient;

namespace Entra21.BancoDados02.Ado.Net.Views.Clientes
{
    public partial class ClienteCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private readonly ClienteService _clienteService;

        private const int modoCadastro = -1;

        public ClienteCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoCadastro;

            _clienteService = new ClienteService();
        }

        public ClienteCadastroEdicaoForm(Cliente cliente) : this()
        {
            _idParaEditar = cliente.Id;

            textBoxNome.Text = cliente.Nome;
            maskedTextBoxCpf.Text = cliente.Cpf;
            textBoxRenda.Text = DecimalHelper.ObterValorFormatado(cliente.Renda);
            if (cliente.EhInadimplente)
                radioButtonStatusInadimplente.Checked = true;
            else
                radioButtonStatusRegular.Checked = true;
            dateTimePickerDataNascimento.Value = cliente.DataNascimento;
            richTextBoxObservacao.Text = cliente.Observacao;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            decimal renda;
            try
            {
                renda = Convert.ToDecimal(DecimalHelper.RemoverMoedaConverterDecimal(textBoxRenda.Text));
            }
            catch (Exception)
            {
                CustomMessageBox.ShowError("Campo de renda deve conter somente valores decimais.");

                textBoxRenda.Focus();

                return;
            }
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var ehInadimplente = radioButtonStatusInadimplente.Checked;
            var observacao = richTextBoxObservacao.Text.Trim();

            try
            {
                var cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Renda = renda;
                cliente.Cpf = cpf;
                cliente.DataNascimento = dataNascimento;
                cliente.EhInadimplente = ehInadimplente;
                cliente.Observacao = observacao;

                if (_idParaEditar == modoCadastro)
                    CadastrarCliente(cliente);
                else
                    EditarCliente(cliente);
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível salvar este registro, desculpe pelo incomodo");
            }
        }

        private void EditarCliente(Cliente cliente)
        {
            cliente.Id = _idParaEditar;

            _clienteService.Editar(cliente);

            CustomMessageBox.ShowSuccess("Cliente alterado com sucesso ");

            Close();
        }

        private void CadastrarCliente(Cliente cliente)
        {
            _clienteService.Cadastrar(cliente);

            CustomMessageBox.ShowSuccess("Cliente cadastrado com sucesso");

            Close();
        }
    }
}
