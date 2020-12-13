using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jbDEV.UI.Site
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(opts => 
            {
                opts.AreaViewLocationFormats.Clear();
                opts.AreaViewLocationFormats.Add("Modulos/{2}/Views/{1}/{0}.cshtml");
                opts.AreaViewLocationFormats.Add("Modulos/{2}/Views/Shared/{0}.cshtml");
                opts.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddMvc(opts => opts.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();


            app.UseMvc(routes =>
            {


                // Metodo para manter navegação automática de Areas do MVC, não possibilitando o usuário gerir e acessar a 
                // aplicação via link digitado na url.

                //routes.MapRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");


                // Utiliza MapAreaRoute para possibilitar e estabelecer os acessos de cada area indivualmente, permitindo assim
                // que o usário consiga navegar via URL.

                routes.MapAreaRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
                routes.MapAreaRoute("AreaVendas", "Vendas", "Vendas/{controller=Pedidos}/{action=Index}/{id?}");
            });
        }
    }
}
