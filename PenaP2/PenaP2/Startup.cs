using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PenaP2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Make the homepage file the first thing that comes up when running
            //later had to move all the other files to wwwroot to be able interact with eachother
            DefaultFilesOptions home = new DefaultFilesOptions();
            home.DefaultFileNames.Clear();
            home.DefaultFileNames.Add("HomePage.html");
            app.UseDefaultFiles(home);
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                app.UseStaticFiles();
            });
        }
    }
}
