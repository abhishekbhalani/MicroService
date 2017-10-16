using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace StatlerWaldorfCorp.Secureservice 
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .Build();

                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseContentRoot(Directory.GetCurrentDirectory())                
                    .UseStartup<Startup>()
                    .UseConfiguration(config)
                    .Build();

                host.Run();
        }
    }
}
