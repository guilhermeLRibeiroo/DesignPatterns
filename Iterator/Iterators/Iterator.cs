﻿using System.Collections;

namespace Iterator.Iterators
{
    public abstract class Iterator
        : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract bool HasNext();
        public abstract void Reset();
    }
}
