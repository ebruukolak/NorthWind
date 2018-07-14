using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Northwind.MVCWebUI
{
   public class RouteConfig
   {
      public static void RegisterRoutes(RouteCollection routes)
      {
         routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional }
         );
         //routes.MapRoute(
         //           "EditProduct",
         //           "Edit/{prodouctID}",
         //           new { controller = "Admin", action = "Edit" });
         //routes.MapRoute(
         //       name: "Admin",
         //       url: "{controller}/{action}/{id}",
         //       defaults: new { controller = "Admin", action = "Edit", id = UrlParameter.Optional }
         //   );




      }
   }
}
