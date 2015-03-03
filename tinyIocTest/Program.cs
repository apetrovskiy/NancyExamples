/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/22/2014
 * Time: 2:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace tinyIocTest
{
    using System;
    using Nancy;
    using Nancy.Hosting.Self;
    
    /// <summary>
    /// Description of Program.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            
            // http://localhost:12340/sorted
            
            StaticConfiguration.DisableErrorTraces = false;
            
            host.Start ();
            
            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey(true);
        }
    }
}