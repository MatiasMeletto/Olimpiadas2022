using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Musse.Data.Models;

namespace Musse.Data
{
    public class MuseoingContext : IdentityDbContext
    {
        public DbSet<MapaActual> Mapas { get; set; }
        public DbSet<Recorrido> Recorridos { get; set; }
        public DbSet<Stand> Stands { get; set; }

        public MuseoingContext(DbContextOptions<MuseoingContext> options)
            : base(options)
        {
        }
    }
}