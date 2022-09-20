using Enum;
using System.ComponentModel.DataAnnotations;

namespace MusseCore
{
    public class ResenaDTO
    {
        [Required]
        public string ResenaComentarioString { get; set; }
        public DateTime Fecha { get; set; }
        public TipoNota Nota { get; set; }
    }
}
