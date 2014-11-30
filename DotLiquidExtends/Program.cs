
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
            StaticConfiguration.DisableErrorTraces = false;

            Template.RegisterSafeType(typeof(Product), new[] { "Name", "Price" });

            host.Start ();

            Console.WriteLine ("Press any key to stop server...");
            Console.ReadKey ();
        }
    }
}
