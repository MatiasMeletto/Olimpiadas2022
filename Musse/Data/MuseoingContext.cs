using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Musse.Data.Models;

namespace Musse.Data
{
    public class MuseoingContext : IdentityDbContext
    {
        public DbSet<MapaActual> Mapas { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<ResenaComentario> ResenasComentarios { get; set; }
        public DbSet<Juego> Juegos { get; set; }

        public MuseoingContext(DbContextOptions<MuseoingContext> options)
            : base(options)
        {
        }
    }
}