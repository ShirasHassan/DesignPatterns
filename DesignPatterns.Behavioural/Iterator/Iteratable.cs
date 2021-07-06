using System.Collections;

namespace DesignPatterns.Behavioural.Iterator
{
    public abstract class Iteratable : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}