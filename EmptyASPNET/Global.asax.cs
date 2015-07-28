using System;
using System.Collections.Generic;
using System.Web;

namespace EmptyASPNET
{
    public class MyCustomHandler : IHttpHandler, System.Web.Routing.IRouteHandler
    {
        public bool IsReusable { get { return false; } }

        public void ProcessRequest(HttpContext context) {
            context.Response.Write("<html><head><title>hello world!</title></head><body>");            
            foreach(string handler in context.ApplicationInstance.Modules.AllKeys) {
                context.Response.Write(handler + "<br>");
            }
            context.Response.Write("</body></html>");
        }

        public IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) {
            return this; // Here you can do factory and delegate ProcessRequest;
        }
    }

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e) {
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("", new MyCustomHandler()));

            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            //// System.Web.Mvc.dll, v5.2.3.0
            ////routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "Dev.Server.Mvc4App.Controllers" });

            //System.Web.Routing.RouteTable.Routes.MapRoute();
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_EndRequest(object sender, EventArgs e) {
           
        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}