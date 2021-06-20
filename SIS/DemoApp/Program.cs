using SIS.Http;
using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {


            //var routeTable = new List<Route>();

            //var httpServer = new HttpServer(80, routeTable);
            //await httpServer.StartAsync();

            await WebHost.StartAsync(new StartUp());
        }

        
    }
}
