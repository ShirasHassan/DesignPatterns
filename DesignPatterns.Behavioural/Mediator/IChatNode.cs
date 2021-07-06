using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public interface IChatNode
    {
        public string Address { get; }
        Task SendMessage(string content);
        Task ReceiveMessage(IChatNode chatNode, Message message);
        
        Task SignIn(IMediator mediator);
        
        Task SignOut();
    }
}