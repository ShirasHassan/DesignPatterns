using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class Program
    {
        public static async Task Run()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\t Mediator Pattern ");
            Console.WriteLine("--------------------------------------");

            
            var shiras = new ChatNode(new Person("1","Shiras"));
            var amina = new ChatNode(new Person("2","Amina"));
            var hanah = new ChatNode(new Person("3","Hanah"));
            var dua = new ChatNode(new Person("4","Dua"));
            var mediator = new ChatRoom(new List<IChatNode>(){shiras,amina,hanah,dua});


            await shiras.SendMessage("Hi, How are you ?");
            Console.WriteLine();

            await amina.SendMessage("I am fine, Thank you.");
            Console.WriteLine();
            
        }
    }
}