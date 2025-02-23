using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
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

           // webApplicationBuilder.Services.AddControllers(); //Registering APIs Requird services (Controller Activator, Action Selector, Action Invoker, Model Binder, etc.)


            webApplicationBuilder.Services.AddControllersWithViews(); //Registering MVC Requird services (Controller Activator, Action Selector, Action Invoker, Model Binder, etc.)


            //webApplicationBuilder.Services.AddRazorPages(); //Registering Razor Pages Requird services (Action Selector, Action Invoker, Model Binder, Razor Pages, etc.)


            //webApplicationBuilder.Services.AddMvc(); //Registering MVC Requird services (Controller Activator, Action Selector, Action Invoker, Model Binder, Razor Pages, etc.)

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

            app.UseStaticFiles(); 

            app.MapControllerRoute(
                name: "default",
                pattern/*urlPath*/: "{controller=Home}/{action=Index}/{id:int?}"
                //constraints: new {id = new IntRouteConstraint()}
               // defaults: new { controller = "Movies", action = "Index" } //Old way
            );
            #endregion

            app.Run();
        }

    }
}
