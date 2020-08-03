using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SuperHeroe.Data.Interfaces;
using SuperHeroe.Data.Repositories;

namespace SuperHeroe
{
    public class Startup
    {
        private object routes;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //Se registran los servicios a consumir en los controladores. Su referencia viene de la carpeta DATA
            services.AddTransient<ISearch, SearchRepository>();
            services.AddTransient<IDetailsRepository, DetailsHeroeRepository>();
            //Se establece la duraci�n de la sesi�n  
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(10);   
            });
            services.AddMvc();
            services.AddControllers();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            
           //Se registro para usar sesiones
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //Se registro servicio para implementar cache system en netcore
            services.AddMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
               //Configuraci�n realizada para centralizar los errores y mostrar pagina not found. 
               //La otra parte de la l�gica implementada esta en el ErrorController y se cambio 
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
               
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthorization();
            //Se registro para usar sesiones en los controladores
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "dfault",
                pattern: "{controller=Home}/{action=Home}/{id?}"
              


                );
             

            });




        }
    }
}
