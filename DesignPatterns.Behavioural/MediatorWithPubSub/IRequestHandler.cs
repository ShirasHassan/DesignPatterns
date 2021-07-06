namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public interface IRequestHandler<in T>
    {
        void Handle(T message);
    }
}