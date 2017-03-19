using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Pie.Models;

namespace Pie
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddTransient<IPieRepository, MockPieRepository>();
            services.AddMvc();
        }
            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // Adding support for showing exceptions in browser
            app.UseDeveloperExceptionPage();
            // Use status codes between 400-600
            app.UseStatusCodePages();
            // Allows us to serve static files
            app.UseStaticFiles();
            // Adding MVC support and simple route
            app.UseMvcWithDefaultRoute();
        }
    }
}
