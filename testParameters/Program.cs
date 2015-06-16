/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 6/16/2015
 * Time: 12:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Nancy;
using Nancy.Hosting.Self;

namespace testParameters
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            
            StaticConfiguration.DisableErrorTraces = false;
            
            host.Start ();
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}