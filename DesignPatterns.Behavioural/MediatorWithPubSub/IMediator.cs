using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public interface IMediator
    {
        Task Notify<T>(object sender, T message);

        Task AddMe<T>(IRequestHandler<T> component);

    }
}