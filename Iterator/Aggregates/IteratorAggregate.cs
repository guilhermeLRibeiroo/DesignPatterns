using System.Collections;

namespace Iterator.Aggregates
{
    public abstract class IteratorAggregate
        : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
