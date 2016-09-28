using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace dotNifties.Mvc.Attributes
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                filterContext.HttpContext.Response.StatusCode = 404;
                filterContext.HttpContext.Response.End();
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Do nothing
        }
    }
}