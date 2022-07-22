namespace Entra21.BancoDados02.Ado.Net.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Renda { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool EhInadimplente{ get; set; }
        public string Observacao { get; internal set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
