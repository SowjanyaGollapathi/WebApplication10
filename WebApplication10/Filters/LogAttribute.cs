using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0}- controller:{1} action:{2}", methodName, controllerName, actionName);

            Debug.writeLine(message);

        }
    }
    
}
