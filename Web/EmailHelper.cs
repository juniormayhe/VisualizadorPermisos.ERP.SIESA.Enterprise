using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace Web
{
    public static class EmailHelper
    {
        
        public static void Send(string subject, string message) {

            
            try
            {
                if (ConfigurationManager.AppSettings["activarCorreo"] != "si")
                    return;

                //configuracion leída automaticamente de system.net/mailSettings/smtp
                SmtpClient smtpClient = new SmtpClient();
                var mensaje = new MailMessage(ConfigurationManager.AppSettings["from"], ConfigurationManager.AppSettings["to"], subject, message);
                mensaje.CC.Add(ConfigurationManager.AppSettings["cc"]);
                mensaje.IsBodyHtml = true;
                smtpClient.Send(mensaje);

            }
            catch (Exception e)
            {
                System.Diagnostics.Trace.WriteLine(e.Message);
            }
            
            
        }
    }
}