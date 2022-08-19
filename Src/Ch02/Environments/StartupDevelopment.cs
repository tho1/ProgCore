//////////////////////////////////////////////////////////////////
//
//   PROGRAMMING ASP.NET CORE
//   Dino Esposito
//   
//   Ch02 - The First ASP.NET Core Project 
//   Environments
//

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


namespace Ch02.Environments
{
    public class StartupDevelopment
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Run(async (context) =>
            {
                await context.Response
                .WriteAsync("Courtesy of <b>Programming ASP.NET Core</b>!" + 
                    "<hr>" +
                    "TYPE=StartupDevelopment<br>" + 
                    "ENVIRONMENT=" + env.EnvironmentName);
            });
        }
    }
}
