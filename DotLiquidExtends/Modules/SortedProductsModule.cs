
namespace NancyExamples
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using Nancy;
    using Nancy.ModelBinding;

    public class SortedProductsModule : NancyModule
    {
        public SortedProductsModule ()
        {
            Get ["/sorted"] = _ => {
                dynamic data = new ExpandoObject ();
                var list = new ProductList ();
                list.Products.AddRange (
                    new Product[] {
                    new Product { Name = "c", Price = 5, Description = "one" },
                    new Product { Name = "a", Price = 10, Description = "two" },
                    new Product { Name = "z", Price = 1, Description = "three" },
                    new Product { Name = "b", Price = 11, Description = "four" },
                    new Product { Name = "a", Price = 8, Description = "five" },
                    new Product { Name = "z", Price = 9, Description = "six" },
                    new Product { Name = "k", Price = 11, Description = "seven" },
                    new Product { Name = "h", Price = 5, Description = "eight" },
                });
                data.Products = list.Products.ToArray();
                return View ["views/sorted", data];
            };
        }
    }
}

