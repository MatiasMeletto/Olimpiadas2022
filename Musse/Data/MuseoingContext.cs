using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Musse.Data.Models;

namespace Musse.Data
{
    public class MuseoingContext : IdentityDbContext
    {
        DbSet<MapaActual> Mapa { get; set; }
        DbSet<MapaPrevio> MapaPrevios { get; set; }
        DbSet<Recorrido> Recorridos { get; set; }
        public MuseoingContext(DbContextOptions<MuseoingContext> options)
            : base(options)
        {
        }
    }
}