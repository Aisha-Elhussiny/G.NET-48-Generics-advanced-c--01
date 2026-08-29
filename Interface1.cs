using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    //Q6 What is a generic interface? Write IRepository<T>. 
    //3mlt el interface w 3mlt class y3mlo implementation 3shan ab2a tb2to

    internal interface IRepository<T>
    {
        void Add(T item);

        T Get(int index);

        void Remove(T item);
    }
}
