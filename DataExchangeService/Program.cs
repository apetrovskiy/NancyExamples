/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 3/3/2015
 * Time: 12:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace DataExchangeService
{
    using System;
    using System.ServiceProcess;
    using System.Threading;
    using Nancy;
    using Nancy.Hosting.Self;
    
    class Program
    {
        public static void Main(string[] args)
        {
            // this works too
            /*
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            StaticConfiguration.DisableErrorTraces = false;
            host.Start();

            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey ();
            host.Stop();
            */
            
           NancyHost host = null;
            try
            {
                host = new NancyHost (new Uri ("http://localhost:12340"));
                host.Start();
                
                if (!Environment.UserInteractive) {
                    var services = new ServiceBase[] { new ServiceControl() };
                    ServiceBase.Run(services);
                } else {
                    var service = new ServiceControl();
                    Thread.Sleep(Timeout.Infinite);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
            }
            Console.Write("Press any key to stop server . . . ");
            Console.ReadKey(true);
            host.Stop();
        }
    }
}