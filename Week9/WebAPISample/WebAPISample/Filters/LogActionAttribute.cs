using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPISample.Filters
{
    public class LogActionAttribute : Attribute, IActionFilter
    // Inherit from Attribute, gives a class that we can apply this actionfilter into controller class as attribute.
    {
        public bool AllowMultiple => true;

        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext,
            CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            Trace.WriteLine("WebAPI Logs: " + actionContext.ActionDescriptor.ActionName + " gets executed at " + DateTime.Now.ToString("HH:mm:ss"));
            Task<HttpResponseMessage> result = continuation();
            result.Wait();
            Trace.WriteLine("WebAPI Logs: " + actionContext.ActionDescriptor.ActionName + " finished execution at " + DateTime.Now.ToString("HH:mm:ss"));
            return result;
        }
    }
}