namespace Generics_advanced_c__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?

            // A generic class is a class that is defined with type parameters, allowing it to operate on different data types while providing type safety. Generics enable developers to create classes, methods, and data structures that can work with any data type without decressing performance or type safety.
            //A generic class uses a type parameter such as T, allowing the same class to work with different data types while maintaining type safety.

            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods.

            //containerClass<string> container = new containerClass<string>();

            //container.Add("Aisha");

            //Console.WriteLine(container.Get());
            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue>.

            // Multiple type parameters allow a generic class or method to accept more than one type parameter, enabling it to work with multiple data types simultaneously. This is useful when you want to create a class or method that can handle different combinations of types.


            //Pair<int, string> person = new Pair<int, string>(1, "Aisha");

            //Console.WriteLine(person.Key);
            //Console.WriteLine(person.Value);
            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            // A generic method is a method that is defined with type parameters, allowing it to operate on different data types while providing type safety. 
            //int a = 10;
            //int b = 20;

            //Swap(ref a, ref b);

            //Console.WriteLine(a); 
            //Console.WriteLine(b); 
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value
            //Console.WriteLine(FindMax<int>(10, 20));

            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>.
            // A generic interface is an interface that is defined with type parameters, allowing it to operate on different data types while providing type safety. Generic interfaces enable developers to create contracts that can be implemented by classes working with various data types.
            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            //The struct constraint requires the generic type to be a value type
            //lma a3oz agbro eno ydkhl value type b3ml el struct constrain.



            //=========  example ===========
            //numContainer<int> number = new numContainer<int>();
            //shaghal 3adi w sah 3shan int de value type lakn lw grbt akhleha string msh hyrda


            #endregion

            #region  Q8: What is the 'class' constraint? Write an example.
            //class constraint requires the generic type to be a reference type.

            // ====== example ======
            ReferenceContainer<string> refcontainer = new ReferenceContainer<string>();

            // hna b2a el3ks howa beygbrna nktb refrence type msh value

            #endregion
            #region Q9: What is the 'new()' constraint? Write an example.
            //new() constraint require the class to have a parameterless constructor .
            //lazem ya7twii 3la parameterless constructor.


            //====== example =====
            //ObjectFactory<Student> factory = new ObjectFactory<Student>();

            //Student student = factory.CreateObject();


            #endregion

            #region Q10:  What is the interface constraint? Write an example.
            //inerface constraint requires the generic type to implement the interface
            //lazem ykon bytab2 el interface da


            #endregion
            #region Q11: What is the base class constraint? Write an example.
            //base class constraint requires the generic type to be a derived class of the specified base class.


            //====== example ======
            //PersonContainer<Child> container =new PersonContainer<Child>();
            // hna T hya el class ely bywarath mn el base class elly hwa Person
            #endregion

            #region Q12: How do you apply multiple constraints? Write an example
            //You can apply multiple constraints by separating them with commas.  you can require a generic type to be a reference type and implement a specific interface.



            #endregion
            #region Q13: What does the 'default' keyword do in generics?

            //The default keyword in generics is used to obtain the default value of a type parameter. For reference types, the default value is null, while for value types, it is the zero value ( 0 for int, false for bool). It allows you to create instances of generic types without knowing their specific type at compile time.
            #endregion

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;

            a = b;
            b = temp;
        }
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b ;
        }
    }
}
    