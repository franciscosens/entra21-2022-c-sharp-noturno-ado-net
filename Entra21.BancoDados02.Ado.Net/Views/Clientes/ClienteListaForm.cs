using Entra21.BancoDados02.Ado.Net.Models;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;
using System.Data.SqlClient;
using System.Globalization;

namespace Entra21.BancoDados02.Ado.Net.Views.Clientes
{
    public partial class ClienteListaForm : Form
    {
        private readonly ClienteService _clienteService;

        public ClienteListaForm()
        {
            InitializeComponent();

            _clienteService = new ClienteService();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var clientes = _clienteService.ObterTodos();

            dataGridView.Rows.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                var cliente = clientes[i];

                var status = cliente.EhInadimplente == true
                    ? "Inadimplente"
                    : "Regular";

                dataGridView.Rows.Add(new object[] { 
                    cliente.Id,
                    cliente.Nome,
                    status
                });
            }
            //var cultura = new CultureInfo("pt-BR");
            //cultura.NumberFormat.NumberDecimalSeparator = ","; // simbolo da separação do decimal
            //cultura.NumberFormat.CurrencyGroupSeparator = ".";
            //cultura.NumberFormat.NumberDecimalDigits = 2;

            //var valor = 10_120_293.00m;


            //var texto = string.Format(cultura, "R$ {0:N}", valor);
            //dataGridView.Rows.Add(new object[]
            //{
            //    cliente.Id,
            //    string.Format(cultura, "R$ {0:N}", valor)
            //});


            //MessageBox.Show(texto);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var clienteForm = new ClienteCadastroEdicaoForm();

            clienteForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum cliente cadastrado");

                return;
            }

            if (dataGridView.SelectedRows.Count == 0)
            {
                CustomMessageBox.ShowWarning("Nenhum cliente selecionado");

                return;
            }

            var registroSelecionado = dataGridView.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                var cliente = _clienteService.ObterPorId(idRegistroSelecionado);

                var clienteForm = new ClienteCadastroEdicaoForm(cliente);
                
                clienteForm.ShowDialog();

                PreencherDataGridView();
            }
            catch (SqlException sqlException)
            {
                CustomMessageBox.ShowError("Não foi possível buscar este registro, desculpe pelo incomodo");
            }            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.)
        }
    }
}
