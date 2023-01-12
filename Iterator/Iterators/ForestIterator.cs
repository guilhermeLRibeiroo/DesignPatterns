using Iterator.Aggregates;
using IteratorPattern;

namespace Iterator.Iterators
{
    public class ForestIterator
        : Iterator
    {
        private TreeCollection _collection;
        private int _position = 0;

        public ForestIterator(TreeCollection collection)
        {
            _collection = collection;
        }

        public override Tree Current()
        {
            return _collection.GetItems()[_position];
        }

        public override bool HasNext()
        {
            return _position < _collection.GetItems().Count;
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + 1;

            if (updatedPosition >= 0 && updatedPosition <= _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = 0;
        }
    }
}
