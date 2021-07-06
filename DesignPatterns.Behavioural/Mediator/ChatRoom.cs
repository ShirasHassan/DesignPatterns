using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class ChatRoom :IMediator
    {
        public string Address { get; private set; }
        private readonly  List<IChatNode> ChatNodes;
   
        public ChatRoom(List<IChatNode> chatNodes)
        {
            this.Address = Guid.NewGuid().ToString();
            ChatNodes = chatNodes;
            chatNodes.ForEach(n => n.SignIn(this));
        }
        
        public async Task SendMessage(IChatNode sender, Message message)
        {
            NotifyChatNodes(sender, message);
        }

        public async Task AddChatNode(IChatNode chatNode)
        {
            ChatNodes.Add(chatNode);
        }
        
        private void NotifyChatNodes(IChatNode sender, Message message)
        {
            ChatNodes.ForEach(n =>
            {
                if (n.Address != sender.Address)
                    n.ReceiveMessage(sender, message);
            });
        }
        
    }
}