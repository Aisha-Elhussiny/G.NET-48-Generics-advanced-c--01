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

            #region Q14: Write a SafeList<T> that returns default when the index is invalid.
            //SafeList<int> safeList = new SafeList<int>();


            //====== example ======
            //SafeList<string> names = new SafeList<string>();

            //names.Add("Aisha");

            //Console.WriteLine(names.Get(0));  //hytl3 Aisha
            //Console.WriteLine(names.Get(10)); //hytl3 null 3shan da el default w hwa invalid index
            #endregion

            #region Q15: What is covariance? Explain the 'out' keyword.

            //Covariance allows you to use a more derived type than originally specified. The out keyword is used to indicate that a type parameter is covariant, meaning it can be substituted with a more derived type. This is typically used in interfaces  to enable flexibility in method return types.
            #endregion
            #region Q16: What is contravariance? Explain the 'in' keyword.

            //Contravariance allows you to use a less derived type than originally specified. The in keyword is used to indicate that a type parameter is contravariant, meaning it can be substituted with a less derived type. This is typically used in interfaces to enable flexibility in method parameter types.

            #endregion
            #region Q17: What is the difference between covariance and contravariance?
            //difference between covariance and contravariance is that covariance allows you to use a more derived type, while contravariance allows you to use a less derived type. Covariance is typically used in return types, while contravariance is typically used in parameter types.

            #endregion
            #region Q18: How do static members work in generic types?

            //Static members in generic types are shared across all instances of the same generic type with the same type parameter. Each unique instantiation of a generic type has its own set of static members, allowing for type-specific behavior and data storage.

            #endregion
            #region Q19: How can you inherit from a generic class?

            //You can inherit from a generic class by specifying the type parameter(s) in the derived class. The derived class can either use the same type parameter(s) or specify concrete types for them. This allows you to create specialized versions of the generic class while still benefiting from its generic behavior.
            //y3ni lw 3ayz a5od el class ely 3mltaha generic w a3mlha extend 3la class tany lw 3ayz a5od el type parameter bta3ha w a3mlha extend 3la class tany aw a5od el type parameter bta3ha w a7ot feha type mo3ayan.
            #endregion
            #region Q20: Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 


            //Cache<int, string> cache = new Cache<int, string>();


            //// The value will expire after 5 seconds.
            //cache.Add( 1,"Aisha", 5 );


            //Console.WriteLine( "Value: " + cache.Get(1));

            //Console.WriteLine("Contains key 1: "+ cache.Contains(1) );


            //Console.WriteLine( "Press Enter after 5 seconds.");

            //Console.ReadLine();


            //Console.WriteLine( "Value after expiration: "+ cache.Get(1) );

            //Console.WriteLine("Contains key 1: " + cache.Contains(1));
            ////hytl3 null 3shan expired w hytl3 false 3shan expired

            //cache.Add( 2,"Ali", 60);
            ////zawdna ali 

            //bool removed = cache.Remove(2);
            ////kda ms7nah

            //Console.WriteLine("Key 2 removed: " + removed); //hytl3 true 3shan ms7nah

            //Console.WriteLine( "Contains key 2: " + cache.Contains(2) ); //hytl3 false 3shan ms7nah brdoo

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
    