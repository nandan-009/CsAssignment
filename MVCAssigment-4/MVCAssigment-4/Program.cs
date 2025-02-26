using Microsoft.EntityFrameworkCore;
using MVCAssigment_4.Models;

namespace MVCAssigment_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MovieDBContext>(opts =>
               opts.UseNpgsql("Host=localhost;Database=empdb;Username=postgres;Password=tiger;Persist Security Info=True")
           );

            //configure dependency injection for DataAccessLayer
            builder.Services.AddScoped<IMovieDAO,MovieDAO>();

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
