using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    //Q12: How do you apply multiple constraints? Write an example
    public class Creator<T>  where T : class, IPrintable, new()
    {
        public T CreateAndPrint()
        {
            T item = new T();

            item.Print();

            return item;
        }
    }
}
