using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados02.Ado.Net.Models
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Renda { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool EhInadimplente{ get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}
