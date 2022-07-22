namespace Entra21.BancoDados02.Ado.Net.Views.Pedidos
{
    public partial class PedidoListaForm : Form
    {
        public PedidoListaForm()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var pedidoForm = new OrcamentoCadastroForm();
            pedidoForm.ShowDialog();
        }
    }
}
