using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    // Q14: Write a SafeList<T> that returns default when the index is invalid.
    public class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }

            return default(T);
            //lma ykon invalid
        }
    }
}
