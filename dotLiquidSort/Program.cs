/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/18/2014
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NancyExamples
{
    using System;
    using DotLiquid;
    using Nancy;
    using Nancy.Hosting.Self;
    
    class Program
    {
        public static void Main(string[] args)
        {
            // var host = new NancyHost (new Uri ("http://localhost:8080"));
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            
            // http://localhost:12340/sorted
            
            StaticConfiguration.DisableErrorTraces = false;
            
            Template.RegisterSafeType(typeof(Product), new[] { "Name", "Price", "Description" });
            Template.RegisterSafeType(typeof(Product2), new[] { "Name", "Price", "Description", "Id", "Number" });
            Template.RegisterSafeType(typeof(Product3), new[] { "Name", "Price", "Description", "Id", "Number", "UniqueId" });
            Template.RegisterSafeType(typeof(ProductList), new[] { "Products" });
            Template.RegisterSafeType(typeof(Guid), member => member.ToString());
            
            host.Start();
            
            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey(true);
            host.Stop();
        }
    }
}