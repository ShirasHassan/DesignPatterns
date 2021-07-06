using System;

namespace DesignPatterns.Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Visitor.Program.Run();
            Strategy.Program.Run();
            Iterator.Program.Run();
            MediatorWithPubSub.Program.Run();
           var result =  Mediator.Program.Run();
        }
    }
}