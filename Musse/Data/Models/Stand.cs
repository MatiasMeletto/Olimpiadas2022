﻿namespace Musse.Data.Models
{
    public class Stand
    {
        public int StandId { get; set; }

        public string Nombre { get; set; }
        public string Explicacion { get; set; }
        public bool Estado { get; set; }

        public int RecorridoId { get; set; }
        public Recorrido Recorrido { get; set; }
    }
}