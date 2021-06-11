using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelezaFut.Models
{
    public class Jogador
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        public int Idade {get; set;}

        public decimal Altura {get; set;}

        public string Posicao {get; set;}

        public int TimesId {get; set;}

        public Time time {get; set;}

    }
}