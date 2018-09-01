using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
    public class Startup
    {
        //Configurando meu Metodo ou função Configure.
        //Passando como parêmto o metodo IApplicationBuilder
        public void Configure(IApplicationBuilder app){
            //Criando uma classe personalizada de middleware. 
            app.UseMiddleware<MyMiddleware>();
            //Definido um tipo de Middleware
            app.Run(context => context.Response.WriteAsync("Olá Mundo 2"));
        }
    }
}