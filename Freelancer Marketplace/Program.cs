using Freelancer_Marketplace.Models;
using Freelancer_Marketplace.Services;
using Microsoft.EntityFrameworkCore;

namespace Freelancer_Marketplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllersWithViews(); // Use this if you're using Razor Views too
            builder.Services.AddDbContext<FreelancerDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IClientService, ClientService>();

            // Optional: Swagger/OpenAPI (for API testing)
            builder.Services.AddEndpointsApiExplorer();
         

            var app = builder.Build();

            // Configure the HTTP request pipeline
         

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
