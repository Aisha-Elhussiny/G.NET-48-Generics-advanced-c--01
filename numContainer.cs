using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    public class numContainer<T> where T : struct
    {
        public T Value { get; set; }
       
    }
}
