using System.Runtime.CompilerServices;

namespace CoffeeMarketPanel.AppData
{
    public static class RouteConfig
    {
        public static IEndpointRouteBuilder Routes(
            this IEndpointRouteBuilder route)
        {
            route.MapControllerRoute(

           name: "login",
           pattern: "login/{action=Login}",
           defaults: new { controller = "User" }
           );

            route.MapControllerRoute(
            name: "dashboard",
            pattern: "dashboard/{action=index}",
            defaults: new { controller = "Dashboard" }
            );

            route.MapControllerRoute(
           name: "types/GetTypes",
           pattern: "producttype/{action=GetTypes}",
           defaults: new { controller = "ProductType" }
           );


            route.MapControllerRoute(
             name: "ekle",
             pattern: "ekle/{action=Add}",
             defaults: new { controller = "Product" }
            );

            route.MapControllerRoute(
             name: "list",
             pattern: "list/{action=List}",
             defaults: new { controller = "Product" }
            );

            route.MapControllerRoute(
             name: "",
            pattern: "/{action=Login}",
             defaults: new { controller = "User" }
          );


            route.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
            return route;
        }
    }
}
