﻿namespace Entra21.BancoDados01.Ado.Net.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Editora e TipoPersonagem será preenchido com INNER JOIN
        public Editora Editora { get; set; }
        public TipoPersonagem TipoPersonagem { get; set; }
    }
}
