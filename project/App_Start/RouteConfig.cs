using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Home" }
            );

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Login" }
            );

            routes.MapRoute(
                name: "Register",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Register" }
            );

            routes.MapRoute(
               name: "User_Profile",
               url: "{controller}/{action}",
               defaults: new { controller = "Home", action = "User_Profile" }
           );


        }
    }
}
