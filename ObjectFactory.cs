using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    //Q9: What is the 'new()' constraint? Write an example.

    public class ObjectFactory<T> where T : new()
    {
        public T CreateObject()
        {
            return new T();
        }
    }
}
