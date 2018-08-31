using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DescripcionDelArea",
                url: "{controller}/GetDescripcionDelArea/{idEmpresa}/{idArea}",
                defaults: new { controller = "Home", action = "GetDescripcionDelArea", idEmpresa = UrlParameter.Optional, idArea = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Miembros",
                url: "{controller}/GetMiembros/{idEmpresa}/{idArea}",
                defaults: new { controller = "Home", action = "GetMiembros", idEmpresa = UrlParameter.Optional, idArea = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Permisos",
                url: "{controller}/GetPermisos/{idEmpresa}/{idArea}",
                defaults: new { controller = "Home", action = "GetPermisos", idEmpresa = UrlParameter.Optional, idArea = UrlParameter.Optional, idMiembro = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "TodosPermisos",
                url: "{controller}/GetTodosPermisos",
                defaults: new { controller = "Home", action = "GetTodosPermisos"}
            );

            

            routes.MapRoute(
                name: "GrabarDescripcion",
                url: "{controller}/{action}/{idArea}/{descripcion}",
                defaults: new { controller = "Home", action = "GrabarDescripcionArea", idArea = UrlParameter.Optional, descripcion = UrlParameter.Optional }
            );
            
            

        }
    }
}
