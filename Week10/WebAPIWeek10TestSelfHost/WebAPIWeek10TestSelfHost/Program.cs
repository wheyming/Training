using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebAPIWeek10TestSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("https://localhost:1111");
            config.MapHttpAttributeRoutes();

            var server = new HttpSelfHostServer(config);
            var task = server.OpenAsync();
            task.Wait();
            Console.WriteLine("Self Host application started");
            Console.ReadLine();
        }
    }
}
