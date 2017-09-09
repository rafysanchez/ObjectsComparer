﻿using System;

namespace ObjectsComparer
{
    public class ComparersFactory : IComparersFactory
    {
        public virtual IComparer<T> GetObjectsComparer<T>(ComparisonSettings settings = null, BaseComparer parentComparer = null)
        {
            return new Comparer<T>(settings, parentComparer);
        }

        public IComparer GetObjectsComparer(Type type, ComparisonSettings settings = null, BaseComparer parentComparer = null)
        {
            return new Comparer(settings, parentComparer, this);
        }
    }
}
