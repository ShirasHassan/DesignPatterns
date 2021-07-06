using System;

namespace DesignPatterns.Behavioural.Mediator
{
    public class Message
    {
        public  Message(string from,string content)
        {
            From = from;
            Content = content;
            SendTime = DateTime.Now;
        }

        public string From { get; private set; }
        public string Content { get; private set; }
        public DateTime SendTime { get; private set; }
    }
}