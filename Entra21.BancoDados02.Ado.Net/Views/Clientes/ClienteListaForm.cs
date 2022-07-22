using Entra21.BancoDados02.Ado.Net.Enums;
using Entra21.BancoDados02.Ado.Net.Services;
using Entra21.BancoDados02.Ado.Net.Views.Components;
using System.Data.SqlClient;

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
            var nomePesquisa = textBoxNome.Text.Trim();

            var clienteListaFiltroStatus = ObterClienteListaFiltroStatusEscolhido();

            var clientes = _clienteService.ObterTodosFiltrando(nomePesquisa, clienteListaFiltroStatus);

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
        }

        private ClienteListaFiltroStatus ObterClienteListaFiltroStatusEscolhido()
        {
            if (radioButtonInadimplente.Checked == true)
                return ClienteListaFiltroStatus.Inadimplente;

            if (radioButtonRegular.Checked == true)
                return ClienteListaFiltroStatus.Regular;

            return ClienteListaFiltroStatus.Todos;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var clienteForm = new ClienteCadastroEdicaoForm();

            clienteForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void Editar()
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
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível buscar este registro, desculpe pelo incomodo");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
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

            var desejaApagar = MessageBox.Show("Deseja realmente apagar?", "CUIDADO", MessageBoxButtons.YesNo);

            if (desejaApagar != DialogResult.Yes)
                return;

            var registroSelecionado = dataGridView.SelectedRows[0];

            var idRegistroSelecionado = Convert.ToInt32(registroSelecionado.Cells[0].Value);

            try
            {
                _clienteService.Apagar(idRegistroSelecionado);

                CustomMessageBox.ShowSuccess("Cliente apagado com sucesso");

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                CustomMessageBox.ShowError("Não foi possível apagar este registro, desculpe pelo incomodo");
            }
        }

        private void dataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(199, 200, 201);
            dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(0, 123, 255);
        }

        private void dataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
                return;

            Color corFundo;
            if (e.RowIndex % 2 == 0)
                corFundo = Color.FromArgb(255, 255, 255);
            else
                corFundo = Color.FromArgb(233, 236, 239);

            dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = corFundo;
            dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void textBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PreencherDataGridView();
        }

        private void radioButtonInadimplente_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}
