using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
          // BuildWebHost(args).Run();
          
           var  host = new WebHostBuilder()
               .UseKestrel()
               .UseStartup<Startup>()
                .UseContentRoot(Directory.GetCurrentDirectory())
               .Build();
            
               host.Run();
          
        }
        //Nova forma de criar um hosting no Dotnet Core 2.0
        //Repare que agora eu não falo mais o que eu quero em um hosting, eu apenas peço para criar.
        //Com isso, a nossa classe Startup teve mudanças em seu construtor 
       /* 
        private static IWebHost BuildWebHost(string[] args) =>
        
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
        */
    }
}

