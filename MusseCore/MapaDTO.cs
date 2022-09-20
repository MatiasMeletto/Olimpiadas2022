using System.ComponentModel.DataAnnotations;

namespace MusseCore
{
    public class MapaDTO
    {
        [Required]
        public string MapaBase64 { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
    }
}