using System;
using DesignPatterns.Behavioural.Visitor.Interfaces;
using DesignPatterns.Behavioural.Visitor.Entities;

namespace DesignPatterns.Behavioural.Visitor
{
    public class ItemDiscountVisitor : IItemDiscountVisitor
    {
        public float Discount { get; private set; } = 0.00f;
        public void ApplyStationaryDiscount(StationaryProduct product)
        {
            Console.WriteLine("Applied 4% Discount for Stationary items.");
            var discount = (product.Price * product.Quantity * 0.04f);
            Discount = Discount + discount;
            Console.WriteLine($"Amount saved:{discount}");
        }

        public void GroceryDiscount(GroceryProduct product)
        {
            Console.WriteLine("Applied 5% Discount for Grocery items.");
            var discount = (product.Price * product.Quantity * 0.05f);
            Discount = Discount + discount;
            Console.WriteLine($"Amount saved:{discount}");
        }

        public void ElectronicDiscount(ElectronicProduct product)
        {
            Console.WriteLine("Applied 20% Discount for Electronic items.");
            var discount = (product.Price * product.Quantity * 0.20f);
            Discount = Discount + discount;
            Console.WriteLine($"Amount saved:{discount}");
        }
    }
}