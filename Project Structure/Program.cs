using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Project_Structure
{
    //Entry point of the application
    public class Program
    {
        public static void Main(string[] args)
        {
            var webApplicationBuilder = WebApplication.CreateBuilder();


            #region Configure Services
            webApplicationBuilder.Services.AddControllersWithViews(); 
            #endregion

            var app = webApplicationBuilder.Build();

            #region Configure


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Middleware
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Home/Error");
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                app.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                app.MapGet("/Hamada", async context =>
                {
                    await context.Response.WriteAsync("Hello Hamada!");
                });

                app.MapPost("/Hamada", async context =>
                {
                    await context.Response.WriteAsync("Hello Hamada!");
                });

                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            }); 
            #endregion

            app.Run();
        }

    }
}
