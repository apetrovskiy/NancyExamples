
namespace NancyExamples
{
    using System;
    using System.Collections.Generic;

    public class ProductList
    {
        public ProductList()
        {
            Products = new List<Product> ();
        }

        public List<Product> Products { get; set; }
    }
}

