﻿namespace Musse.Data.Models
{
    public class Juego
    { 
        public int JuegoId { get; set; }

        public string Pregunta { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string RespuestaIncorrecta1 { get; set; }
        public string RespuestaIncorrecta2 { get; set; }
        public string RespuestaIncorrecta3 { get; set; }
    }
}
