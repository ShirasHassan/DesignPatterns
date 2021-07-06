using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.MediatorWithPubSub
{
    public class Mediator : IMediator
    {
        private ConcurrentDictionary<string, List<object>> _requestHandlers = new ConcurrentDictionary<string,List<object>>();
        
        public async Task Notify<T>(object sender, T message)
        {
            var messageName = typeof(T).Name.ToString();
            if (!_requestHandlers.ContainsKey(messageName)) return;
            var handlers = _requestHandlers[messageName];
            handlers?.ForEach(x => ((IRequestHandler<T>)x).Handle(message));
        }

        public async Task  AddMe<T>(IRequestHandler<T> component)
        {
            var messageName = typeof(T).Name.ToString();
            var handlers= _requestHandlers.ContainsKey(messageName) ? _requestHandlers[messageName] : new List<object>();
            handlers.Add(component);
            if (handlers.Count == 1) {
                _requestHandlers.AddOrUpdate(messageName,handlers, (s, list) =>
                {
                    list.Add(component);
                    return list;
                });
            }
        }

        public async Task  RemoveMe<T>(IRequestHandler<T> component)
        {
            var messageName = typeof(T).Name.ToString();
            var handlers = _requestHandlers.ContainsKey(messageName) ? _requestHandlers[messageName] : null;
            handlers?.Remove(component);
            if (handlers?.Count == 0) {
                _requestHandlers.TryRemove(messageName,out handlers);
            }
        }
    }
}