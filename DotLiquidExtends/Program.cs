
namespace NancyExamples
{
    using System;
    using DotLiquid;
    using Nancy;
    using Nancy.Hosting;
    using Nancy.Hosting.Self;
    using Nancy.Conventions;
    using Nancy.Extensions;
    using DotLiquid.NamingConventions;

    class MainClass
    {
        public static void Main (string[] args)
        {
            // var host = new NancyHost (new Uri ("http://localhost:8080"));
            var host = new NancyHost (new Uri ("http://localhost:12340"));
            StaticConfiguration.DisableErrorTraces = false;

            // Template.RegisterSafeType(typeof(Product), new[] { "Name", "Price", "Description", "Id", "Number", "UniqueId", "name", "price", "description", "id", "number", "unique_id", "compare_to" });
            Template.RegisterSafeType (typeof(Product), new[] { "name", "price", "description", "id", "number" });
            Template.RegisterSafeType(typeof(ProductList), new[] { "Products", "products" });
            Template.RegisterSafeType (typeof(Guid), member => member.ToString ());
            // Template.NamingConvention = new DotLiquid.NamingConventions.CSharpNamingConvention();

            host.Start ();

            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey ();
        }
    }
}
