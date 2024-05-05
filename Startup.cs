using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.Repository;
using CatalogoAutomotivo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace CatalogoAutomotivo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services, IWebHostEnvironment env)
        {
            // Add services to the container.
            services.AddControllersWithViews();

            services.AddControllers();

            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer("Data Source=DESKTOP-NRIVBVQ\\SQLEXPRESS;Initial Catalog=CatalogoAutomotivo;Integrated Security=True;TrustServerCertificate=True"));
            //services.AddDbContext<AppDbContext>(
            //    options => options.UseSqlServer("Data Source=DESKTOP-E15VM80\\SQLEXPRESS;Initial Catalog=CatalogoAutomotivo;Integrated Security=True;TrustServerCertificate=True"));

            services.AddScoped<IFabricante, FabricanteRepository>();
            services.AddScoped<ICategoria, CategoriaRepository>();
            services.AddSingleton(env.ContentRootFileProvider);
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
