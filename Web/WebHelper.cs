using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Web
{
    public static class WebHelper
    {
        public static int GetStatusCode(Exception exception)
        {
            var httpException = exception as HttpException;
            return httpException != null ? httpException.GetHttpCode() : (int)HttpStatusCode.InternalServerError;
        }
    }
}