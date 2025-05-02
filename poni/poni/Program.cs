using Microsoft.EntityFrameworkCore;
using PoniaFx.DAL;

namespace PoniaFx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FxDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });


            var app = builder.Build();
            app.UseStaticFiles();



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
                );
            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Fx_Dashboard}/{action=Index}"
                );
            app.Run();
        }
    }
}
