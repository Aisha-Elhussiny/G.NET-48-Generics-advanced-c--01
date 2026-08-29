using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    public class ReferenceContainer<T> where T : class
    {
        public T Item { get; set; }
     
    }
}
