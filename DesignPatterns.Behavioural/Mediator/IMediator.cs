using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public interface IMediator
    {
        string Address { get;  }
        Task SendMessage(IChatNode sender, Message message);

        Task AddChatNode(IChatNode chatNode);

    }
}