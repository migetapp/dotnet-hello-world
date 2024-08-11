using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace aspnet
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

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(@"<!DOCTYPE html>
<html>
<head>
  <head>
  <!-- Required meta tags -->
  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

  <!-- Bootstrap CSS -->
  <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
  
  <title>.NET ASPNet Hello World</title>
</head>
</head>
<body>

  <div class=""container mt-5"">
    <div class=""row justify-content-center"">
      <div class=""col-md-8"">
        <div class=""card text-center"">
          <div class=""card-header"">
            Welcome
          </div>
          <div class=""card-body"">
            <img src=""/images/miget-logo.png"" width=""128"" height=""128"" class=""d-inline-block align-top"" alt=""Logo"">
            <h5 class=""card-title"">Hello, world!</h5>
            <p class=""card-text"">This simple .NET ASPNet application with Bootstrap has been deployed to Miget.</p>
            <a href=""https://miget.com"" class=""btn btn-primary"">Click to learn more</a>
          </div>
          <br>
          <div class=""card-footer text-muted"">
            © miget.com
          </div>
        </div>
      </div>
    </div>
  </div>

  <!-- Optional JavaScript -->
  <!-- jQuery first, then Popper.js, then Bootstrap JS -->
  <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
  <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
</body>
</html>");
                });
            });
        }
    }
}
