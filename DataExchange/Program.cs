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
	using Nancy;
	using Nancy.Hosting.Self;
	
	class Program
	{
		public static void Main(string[] args)
		{
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            StaticConfiguration.DisableErrorTraces = false;
            host.Start ();

            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey ();
		}
	}
}