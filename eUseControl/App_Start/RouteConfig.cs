using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "Register",
                url: "register",
                defaults: new { controller = "Register", action = "Index" }
            );
            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Login", action = "Index" }
            );
            routes.MapRoute(
                name: "Logout",
                url: "logout",
                defaults: new { controller = "Home", action = "Logout" }
            );
            routes.MapRoute(
                name: "Profile",
                url: "profile",
                defaults: new { controller = "Home", action = "UserProfile" }
            );

            /*ADMIN********************************************************/
            routes.MapRoute(
                name: "Panoul",
                url: "{controller}/{action}",
                defaults: new { controller = "Admin", action = "Index" }
            );
        }
    }
}
