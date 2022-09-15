using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Musse.Data.Models;

namespace Musse.Data
{
    public class MuseoingContext : IdentityDbContext
    {
        public DbSet<MapaActual> Mapas { get; set; }
        public DbSet<Recorrido> Recorridos { get; set; }

        public MuseoingContext(DbContextOptions<MuseoingContext> options)
            : base(options)
        {
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextFactory<MuseoingContext>(
                options =>
                    options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }

        private readonly IDbContextFactory<MuseoingContext> _contextFactory;

        public MyController(IDbContextFactory<MuseoingContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
    }
}