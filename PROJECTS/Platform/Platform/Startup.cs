using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Platform
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Map("/branch", branch => {
                branch.UseMiddleware<QueryStringMiddleWare>();
                branch.Use(async (context, next) => {
                    await context.Response.WriteAsync($"Branch Middleware");
                });
            });
            app.Use(async (context, next) => {
                await next();
                await context.Response
                    .WriteAsync($"\nStatus Code: { context.Response.StatusCode}");
            });
            app.Use(async (context, next) => {
                if (context.Request.Path == "/short")
                {
                    await context.Response
                        .WriteAsync($"Request Short Circuited");
                }
                else
                {
                    await next();
                }
            });
            app.Use(async (context, next) => {
                if (context.Request.Method == HttpMethods.Get
                    && context.Request.Query["custom"] == "true")
                {
                    await context.Response.WriteAsync("Custom Middleware \n");
                }
                await next();
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
