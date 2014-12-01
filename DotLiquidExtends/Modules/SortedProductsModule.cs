
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
                    new Product { Id = "1", Name = "c", Price = 5, Description = "one", Number = 100 },
                    new Product { Id = "2", Name = "a", Price = 10, Description = "two", Number = 10 },
                    new Product { Id = "3", Name = "z", Price = 1, Description = "three", Number = 50 },
                    new Product { Id = "4", Name = "b", Price = 11, Description = "four", Number = 60 },
                    new Product { Id = "5", Name = "a", Price = 8, Description = "five", Number = 20 },
                    new Product { Id = "6", Name = "z", Price = 9, Description = "six", Number = 110 },
                    new Product { Id = "7", Name = "k", Price = 11, Description = "seven", Number = 150 },
                    new Product { Id = "8", Name = "h", Price = 5, Description = "eight", Number = 80 },
                });
                data.Products = list.Products.ToArray();
                return View ["views/sorted", data];
            };
        }
    }
}

