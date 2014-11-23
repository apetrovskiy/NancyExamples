
namespace NancyExamples
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using Nancy;
    using Nancy.ModelBinding;
    using Nancy.Extensions;

    public class DotLiquidExtendsModule : NancyModule
    {
        public DotLiquidExtendsModule ()
        {
            Get["/products"] = parameters => {
                dynamic productsViewModel = new ExpandoObject();
                productsViewModel.Products = new List<Product> { new Product { Name = "prod1", Price = 1.37 }, new Product { Name = "prod2", Price = 5.15 } };
                return View["views/products_with_layout", productsViewModel];
            };
        }
    }
}

