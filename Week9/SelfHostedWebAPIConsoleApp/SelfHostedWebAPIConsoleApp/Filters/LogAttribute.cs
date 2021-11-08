using System;
using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace SelfHostedWebAPIConsoleApp.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine("WebAPI Logs (Log): " + actionContext.ActionDescriptor.ActionName + " gets executed at " + DateTime.Now.ToString("HH:mm:ss"));
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine("WebAPI Logs (Log): " + actionExecutedContext.ActionContext.ActionDescriptor.ActionName + " finished execution at " + DateTime.Now.ToString("HH:mm:ss"));
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}