using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL1.Models
{
    public class Jugador
    {
        public string? Name {get; set;}
        public int? Edad { get; set;}
        public int? Categoria { get; set;}
        public string? Genero { get; set;}
        public string? Equipo { get; set;}
        public int? Temporada { get; set;}
        public int? TemporadaM { get; set;}
        public decimal? CostoTotal { get; set; }
        public string? Pregunta { get; set; }

    }
}