using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


namespace System.Web.Mvc {

    /// <summary>
    /// From Rob Conerys Tekpub MVC 2.0 Starter Site
    /// http://blog.wekeroad.com/2010/04/19/tekpub-starter
    /// </summary>
    public static class FlashHelpers {

        public static void FlashInfo(this Controller controller,string message) {

            if (controller.TempData["info"] == null)
                controller.TempData["info"] = new StringBuilder();

            ((StringBuilder) controller.TempData["info"]).Append(String.Format("<p>{0}</p>",message));                       
        }
        public static void FlashWarning(this Controller controller, string message) {
            controller.TempData["warning"] = message;
        }
        public static void FlashError(this Controller controller, string message) {
            controller.TempData["error"] = message;
        }

        public static string Flash(this HtmlHelper helper) {

            var message = "";
            var className = "";
            if (helper.ViewContext.TempData["info"] != null) {                
                message =helper.ViewContext.TempData["info"].ToString();
                className = "info";
            } else if (helper.ViewContext.TempData["warning"] != null) {
                message = helper.ViewContext.TempData["warning"].ToString();
                className = "warning";
            } else if (helper.ViewContext.TempData["error"] != null) {
                message = helper.ViewContext.TempData["error"].ToString();
                className = "error";
            }
            var sb = new StringBuilder();
            if (!String.IsNullOrEmpty(message)) {
                sb.AppendLine("<script>");
                sb.AppendLine("$(document).ready(function() {");
                sb.AppendFormat("$('#flash').html('{0}');", message);
                sb.AppendFormat("$('#flash').toggleClass('{0}');", className);
                sb.AppendLine("$('#flash').slideDown('slow');");
                sb.AppendLine("$('#flash').click(function(){$('#flash').toggle('highlight')});");
                sb.AppendLine("});");
                sb.AppendLine("</script>");
            }
            return sb.ToString();
        }

    }
}
