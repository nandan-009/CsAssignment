using Microsoft.EntityFrameworkCore;
using MVCAssignment_3.Models;

namespace MVCAssignment_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //configure dependency injection for DbContext 
            builder.Services.AddDbContext<HallDBContext>(opts =>
                opts.UseNpgsql("Host=localhost;Database=empdb;Username=postgres;Password=tiger;Persist Security Info=True")
            );

            //configure dependency injection for DataAccessLayer
            builder.Services.AddScoped<IHallDAO, HallDAO>();
                        
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
                        
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
