using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web.Controllers;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            BundleTable.EnableOptimizations = true;
        }

        protected void Application_Error(object sender, EventArgs e) {

            var exception = Server.GetLastError();

            var httpContext = ((HttpApplication)sender).Context;
            httpContext.Response.Clear();
            httpContext.ClearError();
            if (WebHelper.GetStatusCode(exception) == 404) {
                ExecuteErrorHandlerController("NotFound", httpContext, exception);
            }
            else { 
                ExecuteErrorHandlerController("Index", httpContext, exception);
            }
        }

        protected void Application_EndRequest()
        {
            if (Context.Response.StatusCode == 401)
            {
                Response.Clear();

                ExecuteErrorHandlerController("NotAuthorized", Context, new ApplicationException());
            }
        }

        private void ExecuteErrorHandlerController(string action, HttpContext httpContext, Exception exception)
        {
            var routeData = new RouteData();
            routeData.Values["controller"] = "ErrorHandler";
            routeData.Values["action"] = action;
            routeData.Values["exception"] = exception;

            using (Controller controller = new ErrorHandlerController())
            {
                ((IController)controller).Execute(new RequestContext(new HttpContextWrapper(httpContext), routeData));
            }
        }


    }
}
