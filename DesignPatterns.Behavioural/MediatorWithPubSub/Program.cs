using System;

namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Program
    {
        public static void Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t Mediator(Pub/Sub) Pattern ");
            Console.WriteLine("--------------------------------------");

            var mediator = new Mediator();
            var component1 = new Component1(mediator);
            var component2 = new Component2(mediator);

            Console.WriteLine("Component1: Triggered job1");
            component1.TriggerJob1();
            Console.WriteLine();
            
            Console.WriteLine("Component2: Triggered job2");
            component2.TriggerJob2();
        }
    }
}