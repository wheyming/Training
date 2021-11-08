using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostedWebAPIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("https://localhost:1234");
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var server = new HttpSelfHostServer(config /*, new WebApiMessageHandler()*/ );
            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Self Host CMD application started");
            Console.ReadLine();
        }
    }
}
