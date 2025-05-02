using Microsoft.EntityFrameworkCore;
using PoniaFx.Models;

namespace PoniaFx.DAL
{
    public class FxDbContext : DbContext
    {
        public FxDbContext(DbContextOptions<FxDbContext> options) : base(options) { }

        public DbSet<Slayder> Slayders { get; set; }

        
    }
}
