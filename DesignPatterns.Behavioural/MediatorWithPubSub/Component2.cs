using System;

namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Component2 : RequestHandler<Event2>
    {
        public Component2(IMediator mediator) : base(mediator)
        {
        }


        public void TriggerJob2()
        {
            Mediator.Notify(this, new Event1("Event 1 is triggered from component2.") );
        }
        
        public override void Handle(Event2 message)
        {
            Console.WriteLine(message.Message);
            Console.WriteLine("Handling Event2 in Component2");
        }
    }
}