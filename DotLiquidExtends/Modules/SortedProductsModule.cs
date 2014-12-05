
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
            Before += ctx => {
                Console.WriteLine(ctx.CurrentUser.UserName);
            };
            
            Get ["/sorted"] = _ => {
                dynamic data = new ExpandoObject ();
                var list = new ProductList ();
                list.Products.AddRange (
                    new [] {
                    new Product { Name = "c", Price = 5, Description = "one" },
                    new Product { Name = "a", Price = 10, Description = "two" },
                    new Product { Name = "z", Price = 1, Description = "three" },
                    new Product { Name = "b", Price = 11, Description = "four" },
                    new Product { Name = "a", Price = 8, Description = "five" },
                    new Product { Name = "z", Price = 9, Description = "six" },
                    new Product { Name = "k", Price = 11, Description = "seven" },
                    new Product { Name = "h", Price = 5, Description = "eight" }
                });
                data.Products = list.Products.ToArray();
                return View ["views/sorted", data];
            };
            
            Get ["/sorted2"] = _ => {
                dynamic data = new ExpandoObject ();
                var list = new ProductList ();
                list.Products.AddRange (
                    new [] {
                    new Product2 { Name = "c", Price = 5, Description = "one", Id = "1", Number = 4 },
                    new Product2 { Name = "a", Price = 10, Description = "two", Id = "10", Number = 5 },
                    new Product2 { Name = "z", Price = 1, Description = "three", Id = "5", Number = 6 },
                    new Product2 { Name = "b", Price = 11, Description = "four", Id = "6", Number = 7 },
                    new Product2 { Name = "a", Price = 8, Description = "five", Id = "7", Number = 3 },
                    new Product2 { Name = "z", Price = 9, Description = "six", Id = "4", Number = 2 },
                    new Product2 { Name = "k", Price = 11, Description = "seven", Id = "3", Number = 1 },
                    new Product2 { Name = "h", Price = 5, Description = "eight", Id = "2", Number = 8 }
                });
                data.Products = list.Products.ToArray();
                return View ["views/sorted2", data];
//                var vvv = View["views/sorted2", data];
//                return vvv;
            };
            
            Get ["/sorted3"] = _ => {
                dynamic data = new ExpandoObject ();
                var list = new ProductList ();
                list.Products.AddRange (
                    new [] {
                    new Product3 { Name = "c", Price = 5, Description = "one", Id = "1", Number = 4 },
                    new Product3 { Name = "a", Price = 10, Description = "two", Id = "10", Number = 5 },
                    new Product3 { Name = "z", Price = 1, Description = "three", Id = "5", Number = 6 },
                    new Product3 { Name = "b", Price = 11, Description = "four", Id = "6", Number = 7 },
                    new Product3 { Name = "a", Price = 8, Description = "five", Id = "7", Number = 3 },
                    new Product3 { Name = "z", Price = 9, Description = "six", Id = "4", Number = 2 },
                    new Product3 { Name = "k", Price = 11, Description = "seven", Id = "3", Number = 1 },
                    new Product3 { Name = "h", Price = 5, Description = "eight", Id = "2", Number = 8 }
                });
                data.Products = list.Products.ToArray();
                return View ["views/sorted3", data];
            };
        }
    }
}

