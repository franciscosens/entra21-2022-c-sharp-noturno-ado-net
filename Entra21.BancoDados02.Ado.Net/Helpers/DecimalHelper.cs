using System.Globalization;

namespace Entra21.BancoDados02.Ado.Net.Helpers
{
    public static class DecimalHelper
    {
        internal static string ObterValorFormatado(decimal valor)
        {
            var cultura = new CultureInfo("pt-BR");
            cultura.NumberFormat.NumberDecimalDigits = 2;
            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.CurrencyGroupSeparator = ".";

            return string.Format(cultura, "R$ {0:N}", valor);
        }

        internal static decimal RemoverMoedaConverterDecimal(string valor)
        {
            valor = valor.Replace("R$", string.Empty)
                .Replace(".", string.Empty)
                .Replace(",", ".")
                .Trim();

            return Convert.ToDecimal(valor);
        }
    }
}
