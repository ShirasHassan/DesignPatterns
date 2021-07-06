namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public abstract class RequestHandler<T> : IRequestHandler<T> 
    {
        protected readonly IMediator Mediator;
        protected RequestHandler(IMediator mediator)
        {
            Mediator = mediator;
            mediator.AddMe(this);
        }
        
        public abstract void Handle(T message);

    }
}