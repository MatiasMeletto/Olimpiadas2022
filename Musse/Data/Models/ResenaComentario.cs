namespace Musse.Data.Models
{
    public class ResenaComentario
    {
        public int ResenaComentarioId { get; set; }

        public string ResenaComentarioString { get; set; }
        public DateTime Fecha { get; set; }
        public TipoNota Nota { get; set; }
    }
}
