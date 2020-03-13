using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;


namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseKestrel(options =>
            {
                // Configure the Url and ports to bind to
                // This overrides calls to UseUrls and the ASPNETCORE_URLS environment variable, but will be 
                // overridden if you call UseIisIntegration() and host behind IIS/IIS Express
                options.Listen(IPAddress.Loopback, 5001);
                
            })
                .UseStartup<Startup>();
                //.UseUrls("https://localhost:5001/");
    }
}
