namespace Musse.Data.Models
{
    public class MapaActual
    {
        public int MapaActualId { get; set; }
        public string MapaBase64 { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public bool Actual { get; set; }
    }
}
