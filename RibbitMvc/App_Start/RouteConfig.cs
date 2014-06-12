using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RibbitMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //profile/{action} display,edit
            routes.MapRoute(
                name: "ProfileDefault",
                url: "profile/{action}",
                defaults: new { controller = "profile",action="index"}
            );
            //account/{action} login,sigup,logout
            routes.MapRoute(
                name: "AccountDefault",
                url: "account/{action}",
                defaults: new { controller = "account"}
            );
            //followers
            routes.MapRoute(
                name: "Followers",
                url: "followers",
                defaults: new { controller = "home", action = "followers" }
            );
            //followings
            routes.MapRoute(
                name: "Following",
                url: "following",
                defaults: new { controller = "home", action = "following" }
            );
            //create - for new ribbit
            routes.MapRoute(
                name: "Create",
                url: "create",
                defaults: new { controller = "home", action = "create" }
            );
            routes.MapRoute(
                name: "Follow",
                url: "follow",
                defaults: new { controller = "home", action = "follow" }
            );
            routes.MapRoute(
                name: "Unfollow",
                url: "unfollow",
                defaults: new { controller = "home", action = "unfollow" }
            );
            routes.MapRoute(
                name: "Profiles",
                url: "profiles",
                defaults: new { controller = "home", action = "profiles" }
            );
            //{username}/{action} followings,followers
            routes.MapRoute(
                name: "UserDefault",
                url: "{username}/{action}",
                defaults: new { controller = "user", action = "index" }
            );
            //root
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "home", action = "index"}
            );
        }
    }
}