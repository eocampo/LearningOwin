using System;
using Owin;

namespace OwinHelloWorld2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            app.Run(context => {         
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello World 2!");
            });
        }
    }
}