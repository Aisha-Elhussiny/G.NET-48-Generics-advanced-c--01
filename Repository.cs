using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    public class Repository<T> : IRepository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }
    }
}
