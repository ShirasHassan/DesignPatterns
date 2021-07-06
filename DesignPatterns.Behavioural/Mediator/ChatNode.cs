using System;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class ChatNode : IChatNode
    {
        public string Address { get; }
        private Person Person { get; }
        
        private IMediator Mediator { get; set; }

        public ChatNode(Person person)
        {
            Person = person;
            Address = Guid.NewGuid().ToString();
        }
        
        public async Task SendMessage(string message)
        {
            Console.WriteLine($"-----------------------{Person.FirstName} Sending------------------------------");
            Console.WriteLine($"{message}");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Mediator?.SendMessage(this, new Message(Person.FirstName, message));
        }

        public async Task ReceiveMessage(IChatNode chatNode, Message message)
        {
            Console.WriteLine($"-------------------------{Person.FirstName} Receiving----------------------------");
            Console.WriteLine($"{message.From} {message.SendTime:MM/dd/yyyy HH:mm}:- \t {message.Content}");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }

        public async Task SignIn(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task SignOut()
        {
            Mediator = null;
        }
    }
}