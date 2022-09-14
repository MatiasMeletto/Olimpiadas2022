using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Musse.Data
{
    public class MuseoingContext : IdentityDbContext
    {
        public MuseoingContext(DbContextOptions<MuseoingContext> options)
            : base(options)
        {
        }
    }
}