using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    public class Pair<TKey, TValue>
    {
        public TKey Key
        {
            get;
            set;
        }

        public TValue Value
        {
            get;
            set;
        }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
