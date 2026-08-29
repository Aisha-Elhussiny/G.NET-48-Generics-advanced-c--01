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

            //container<string> container =new container<string>();

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
    