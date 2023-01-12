using System.Collections;

namespace IteratorPattern
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

        public override IEnumerator GetEnumerator()
        {
            return new ForestIterator(this);
        }
    }
}
