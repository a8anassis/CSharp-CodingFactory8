using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp.Model
{
    internal class Product : IEquatable<Product>, IComparable<Product>
    {

        public string? Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int CompareTo(Product? other)
        {
            return Description!.CompareTo(other!.Description);
        }

        public override string? ToString()
        {
            return $"Description: {Description}, Price: {Price}, Quantity: {Quantity}";
        }

        public bool Equals(Product? other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
