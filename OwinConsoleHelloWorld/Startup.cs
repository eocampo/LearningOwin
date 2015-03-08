using System;
using Owin;

namespace OwinConsoleHelloWorld
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
        #if DEBUG
            app.UseErrorPage();
        #endif
            app.UseWelcomePage("/");

            //app.Run(context => {
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
