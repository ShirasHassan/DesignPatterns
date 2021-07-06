using System;

namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Component1 : RequestHandler<Event1>
    {
        public Component1(IMediator mediator) : base(mediator)
        {
        }
        
        public void TriggerJob1()
        {
            Mediator.Notify(this, new Event2("Event 2 is triggered from component1.") );
        }
        
        public override void Handle(Event1 message)
        { 
            Console.WriteLine(message.Message);
            Console.WriteLine("Handling Event1 in Component1");
        }
    }
}