
namespace NancyExamples
{
    using System;
    using DotLiquid;

    public class Product // : IComparable
    {
        public Product()
        {
            UniqueId = Guid.NewGuid ();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Guid UniqueId { get; set; }
        public int Number { get; set; }

        int CompareTo (object obj) {
            return 5;
        }
    }
}

