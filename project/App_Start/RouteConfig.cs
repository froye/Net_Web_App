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
                url: "Home",
                defaults: new { controller = "Home", action = "Home" }
            );

            routes.MapRoute(
                name: "Login",
                url: "Login",
                defaults: new { controller = "Home", action = "Login" }
            );

            routes.MapRoute(
                name: "Register",
                url: "Register",
                defaults: new { controller = "Home", action = "Register" }
            );

            routes.MapRoute(
               name: "User_Profile",
               url: "Home/User_Profile",
               defaults: new { controller = "Home", action = "User_Profile" }
           );


        }
    }
}
