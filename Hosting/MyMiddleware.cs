using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Hosting
{
    public class MyMiddleware
    {
       //Através do construtor da Classe deve deceber um Requeste Deleage.
       //o middlare é um Funcionamento em cadeia

       private RequestDelegate _next;

       public MyMiddleware (RequestDelegate next){

           _next = next;
       }
        public async Task Invoke(HttpContext context){
            //Request
            var start = DateTime.Now;

            await _next(context);

            //response 

            var finish = DateTime.Now;

            var diff = finish.Subtract(start);

            await context.Response.WriteAsync($"The time was {diff.Milliseconds}");
        }
    }
}