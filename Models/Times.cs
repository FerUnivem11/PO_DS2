using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BelezaFut.Models
{
    public class Time
    {
        public int Id {get; set;}

        public string Nome {get ; set;}

        public string Abrev {get; set;}

        public string Tecnico {get; set;}
    }
}