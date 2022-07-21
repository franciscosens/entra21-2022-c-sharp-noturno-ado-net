using Entra21.BancoDados02.Ado.Net.Views;
using Entra21.BancoDados02.Ado.Net.Views.Clientes;

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
            Application.Run(new ClienteCadastroEdicaoForm());
        }
    }
}