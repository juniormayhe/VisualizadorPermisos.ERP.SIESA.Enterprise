using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    [AllowAnonymous]
    public class ErrorHandlerController : Controller
    {
        
        public ActionResult Index(Exception exception)
        {
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = GetStatusCode(exception);

            if (exception.InnerException == null)
            {
                ViewBag.Error = exception.GetType().FullName;
                ViewBag.Message = exception.Message;
                ViewBag.Detalles = exception.StackTrace;
            }
            else {
                ViewBag.Error = exception.InnerException.GetType().FullName;
                ViewBag.Message = exception.InnerException.Message;
                ViewBag.Detalles = exception.InnerException.StackTrace;
            }
            ViewBag.Detalles = ViewBag.Detalles.Replace("\r\n", "<br/>");

            EmailHelper.Send($"VisualizadorPermisosUNOEE - Excepción: {ViewBag.Error}", $"<b>Error:</b> {ViewBag.Error}<br><br><b>Mensaje:</b> {ViewBag.Message}<br><br><b>Detalles:</b> {ViewBag.Detalles}");

            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult NotAuthorized()
        {
            return View();
        }

        private int GetStatusCode(Exception exception)
        {
            var httpException = exception as HttpException;
            return httpException != null ? httpException.GetHttpCode() : (int)HttpStatusCode.InternalServerError;
        }
    }
}