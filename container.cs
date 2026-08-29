using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    //Question 2
    public class containerClass<T>
    {
        private T item;

        public void Add(T newItem)
        {
            item = newItem;
        }

        public T Get()
        {
            return item;
        }
    }
}
