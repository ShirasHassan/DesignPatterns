using System;
using System.Collections.Generic;
using DesignPatterns.Behavioural.Visitor.Entities;
using DesignPatterns.Behavioural.Visitor.Interfaces;

namespace DesignPatterns.Behavioural.Visitor
{
    public class Program
    {
      public  static void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t Visitor Pattern ");
            Console.WriteLine("--------------------------------------");
            var cart = new ObjectStructure(new List<IVisitableItem>()
            {
                new ElectronicProduct() { Name="Laptop",Price = 100000.00f,Quantity = 1},
                new GroceryProduct() { Name="Redbull",Price = 99.00f,Quantity = 10},
                new StationaryProduct() { Name="Papper",Price = 149.00f,Quantity = 2},
            });
            cart.ApplyDiscount(new ItemDiscountVisitor());
            Console.WriteLine($"Total amount saved:{cart.TotalDiscount}");
        }
    }
}