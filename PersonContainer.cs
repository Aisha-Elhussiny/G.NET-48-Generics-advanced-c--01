using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_advanced_c__01
{
    // Q11: What is the base class constraint? Write an example.
    public class PersonContainer<T> where T : Person
    {
        public void PrintName(T person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
