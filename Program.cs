using Foods1.DAL;
using Microsoft.EntityFrameworkCore;

namespace Foods1
{
    public class Program
    {
        public static void Main(string[] args)
      {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => 
                    { 
                        options.UseSqlServer(builder.Configuration.GetConnectionString("Default")); 
                    });
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

          

            app.Run();

        }
    }
}