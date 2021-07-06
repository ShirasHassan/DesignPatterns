namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Event1
    {
        public  string Message { get; private set; }

        public Event1(string message)
        {
            Message = message;
        }
    }
}