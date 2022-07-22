using Entra21.BancoDados02.Ado.Net.Views.Pedidos;
using Entra21.BancoDados02.Ado.Net.Views.Produtos;

namespace Entra21.BancoDados02.Ado.Net
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PedidoListaForm());
        }
    }
}