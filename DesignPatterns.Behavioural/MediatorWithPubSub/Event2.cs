namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Event2
    {
        public  string Message { get; private set; }

        public Event2(string message)
        {
            Message = message;
        }
    }
}