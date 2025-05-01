using Microsoft.EntityFrameworkCore;
using PoniaFx.Models;

namespace PoniaFx
{
    public class FxDbContext:DbContext
    {
        public FxDbContext(DbContextOptions<FxDbContext> options):base(options) { }
       


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
