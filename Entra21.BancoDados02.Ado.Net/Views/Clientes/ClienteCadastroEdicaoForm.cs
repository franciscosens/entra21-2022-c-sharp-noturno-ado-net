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

        private const int modoEdicao = -1;

        public ClienteCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoEdicao;

            _clienteService = new ClienteService();
        }

        public ClienteCadastroEdicaoForm(Cliente cliente) : this()
        {
            _idParaEditar = cliente.Id;

            textBoxNome.Text = cliente.Nome;
            maskedTextBoxCpf.Text = cliente.Cpf;
            textBoxRenda.Text = cliente.Renda.ToString();
            checkBoxInadimplente.Checked = cliente.EhInadimplente;
            dateTimePickerDataNascimento.Value = cliente.DataNascimento;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var renda = Convert.ToDecimal(RemoverFormatacaoDinheiro(textBoxNome.Text));
            var cpf = maskedTextBoxCpf.Text.Trim();
            var dataNascimento = dateTimePickerDataNascimento.Value;
            var ehInadimplente = checkBoxInadimplente.Checked;

            try
            {
                var cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Renda = renda;
                cliente.Cpf = cpf;
                cliente.DataNascimento = dataNascimento;
                cliente.EhInadimplente = ehInadimplente;

                if (_idParaEditar == modoEdicao)
                    EditarCliente(cliente);
                else
                    CadastrarCliente(cliente);
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível salvar este registro, desculpe pelo incomodo");
            }
        }

        private string RemoverFormatacaoDinheiro(string texto)
        {
            return texto.Replace("R$", string.Empty)
                .Replace(".", string.Empty)
                .Replace(",", ".")
                .Trim();
        }

        private void EditarCliente(Cliente cliente)
        {
            _clienteService.Cadastrar(cliente);

            CustomMessageBox.ShowSuccess("Cliente alterado com sucesso ");

            Close();
        }

        private void CadastrarCliente(Cliente cliente)
        {
            cliente.Id = _idParaEditar;

            _clienteService.Editar(cliente);

            CustomMessageBox.ShowSuccess("Cliente cadastrado com sucesso");

            Close();
        }
    }
}
