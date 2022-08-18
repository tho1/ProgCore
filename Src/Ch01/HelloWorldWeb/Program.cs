//////////////////////////////////////////////////////////////////
//
//   PROGRAMMING ASP.NET CORE
//   Dino Esposito
//   
//   Ch01 - Why Another (ASP).NET
//   HelloWorldWeb
//

using Ch01.HelloWorldWeb;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HelloWorldWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
