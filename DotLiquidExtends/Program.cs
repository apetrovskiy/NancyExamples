
namespace NancyExamples
{
    using System;
    using DotLiquid;
    using Nancy;
    using Nancy.Hosting;
    using Nancy.Hosting.Self;
    using Nancy.Conventions;

    class MainClass
    {
        public static void Main (string[] args)
        {
            // var host = new NancyHost (new Uri ("http://localhost:8080"));
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            
            // http://localhost:12340/sorted
            
            StaticConfiguration.DisableErrorTraces = false;
            
            Template.RegisterSafeType(typeof(Product), new[] { "Name", "Price", "Description" });
//            Template.RegisterSafeType(typeof(Product2), new[] { "Name", "Price", "Description", "Id", "Number" });
//            Template.RegisterSafeType(typeof(Product3), new[] { "Name", "Price", "Description", "Id", "Number", "UniqueId" });
            Template.RegisterSafeType(typeof(ProductList), new[] { "Products" });
            Template.RegisterSafeType(typeof(Guid), member => member.ToString());
            
            host.Start();
            
            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey();
            host.Stop();
        }
    }
}
