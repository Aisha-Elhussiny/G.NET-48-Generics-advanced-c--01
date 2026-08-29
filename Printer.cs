using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    //Q10 What is the interface constraint? Write an example.

    public class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}
