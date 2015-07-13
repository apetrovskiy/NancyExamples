/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 26/06/2015
 * Time: 04:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace ModelBindingSimple
{
    using System;
    using Nancy;
    using Nancy.Hosting.Self;
    
    class Program
    {
        public static void Main(string[] args)
        {
            var host = new NancyHost (new Uri ("http://localhost:8080"));
            StaticConfiguration.DisableErrorTraces = false;
            
            host.Start();
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
            host.Stop();
        }
    }
}