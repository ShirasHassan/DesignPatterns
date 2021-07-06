using System;

namespace DesignPatterns.Behavioural.Strategy
{
    public class Program
    {
        public static void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t Strategy Pattern ");
            Console.WriteLine("--------------------------------------");
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();
            
            Console.WriteLine();
            
            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}