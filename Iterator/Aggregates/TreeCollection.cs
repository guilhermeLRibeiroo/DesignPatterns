using Iterator.Iterators;
using IteratorPattern;

namespace Iterator.Aggregates
{
    public class TreeCollection
        : IteratorAggregate
    {
        List<Tree> _trees = new List<Tree>();

        public List<Tree> GetItems()
        {
            return _trees;
        }

        public void AddItem(Tree tree)
        {
            _trees.Add(tree);
        }

        public override ForestIterator GetEnumerator()
        {
            return new ForestIterator(this);
        }
    }
}
