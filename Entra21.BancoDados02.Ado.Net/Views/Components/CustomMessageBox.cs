using Entra21.BancoDados02.Ado.Net.Enums;

namespace Entra21.BancoDados02.Ado.Net.Views.Components
{
    public static class CustomMessageBox
    {
        public static void ShowSuccess(string texto)
        {
            ShowMessage(MessageBoxType.Success, texto);
        }

        public static void ShowError(string texto)
        {
            ShowMessage(MessageBoxType.Error, texto);
        }

        public static void ShowWarning(string texto)
        {
            ShowMessage(MessageBoxType.Warning, texto);
        }

        private static void ShowMessage(MessageBoxType messageBoxType, string texto)
        {
            new CustomMessageBoxForm(messageBoxType, texto).ShowDialog();
        }
    }
}
