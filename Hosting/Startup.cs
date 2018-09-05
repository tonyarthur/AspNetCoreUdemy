using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Hosting
{
    public class Startup
    {
        private IConfigurationRoot _configuration;

        public  Startup(IHostingEnvironment env){
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json");

            builder.AddEnvironmentVariables();
            _configuration = builder.Build();
        }

        //public IConfiguration Configuration{get;}
        
        //Configurando meu Metodo ou função Configure.
        //Passando como parêmto o metodo IApplicationBuilder
        public void Configure(IApplicationBuilder app){
            //Criando uma classe personalizada de middleware. 
            app.UseMiddleware<MyMiddleware>();
            //Habilitando arquivos estpaticos.
            app.UseStaticFiles();

            //Lendo a ApplicationName do arquivo de configuração app.settings.json
            var applicationName = _configuration.GetValue<string>("ApplicationName");
            //Definido um tipo de Middlewar
            app.Run(context => context.Response.WriteAsync($"Olá Mundo 2  {applicationName}"));
        }
    }
}