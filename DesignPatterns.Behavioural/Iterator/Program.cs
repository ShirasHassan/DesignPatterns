using System;

namespace DesignPatterns.Behavioural.Iterator
{
    public class Program
    {
        public static void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t Iterator Pattern ");
            Console.WriteLine("--------------------------------------");
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}