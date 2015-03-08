using System;
using Owin;

namespace OwinHelloWorld
{
    public class Startup
    {        
        public void Configuration(IAppBuilder app) {            
            app.Run(context => {
                if (context.Request.Path.Value == "/fail")
                    throw new Exception("Random exception");
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World!");
            });
        }
    }
}