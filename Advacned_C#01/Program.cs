using System.Reflection.Metadata;

namespace Advacned_C_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //allow you to define type - safe classes, interfaces, methods,and delegates
            //without committing to a specific data type until the code is used , Type Safety and preformance.

            //A generic class uses type parameters that are replaced with actual types when you create an instance.The type parameter T acts as a placeholder.
            #endregion

            #region Q2: Write a generic class Container<T> with Add and Get methods
            //internal class Container<T>
            //{
            //    private readonly List<T> _containers = [];
            //    public void Add(T item) => _containers.Add(item);

            //    public List<T> GetValues() => _containers;
            //}
            #endregion

            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //Generic classes can have multiple type parameters

            //Pair<int, string> pair = new(1, "One");

            #endregion

            #region Q4: What is a generic method? Write Swap<T> method.
            ////A generic method declares its own type parameter(s)

            //int x = 10,y = 20;
            //Console.WriteLine($"Before Swaping  x = {x} , y = {y}");//10 - 20
            //Swap(ref x,ref y);
            //Console.WriteLine($"After Swaping  x = {x} , y = {y}"); //20 - 10
            #endregion

            #region Q5: Write a generic method FindMax<T> that finds maximum value

            //List<int> list = new(){1,2,10, 3, 4, 5};
            //Console.WriteLine(FindMax(list)); //10
            #endregion

            #region Q6: What is a generic interface? Write IRepository<T>.
            //Generic interfaces define contracts with type parameters.
            //Classes implementing them specify the actual types.

            #endregion

            #region Q7: What is the 'struct' constraint? Write an example.
            ////T must be a value type
            //GenericStruct<double> genericStruct = new();
            //genericStruct.Add(5);
            //genericStruct.Add(4);
            //genericStruct.Add(2);
            //Console.WriteLine(genericStruct.GetValues().Count); //3
            #endregion

            #region Q8: What is the 'class' constraint? Write an example.
            //T must be a reference type
            //GenericClass<string> genericClass = new GenericClass<string>();
            //genericClass.Add("Mahmoud");
            //genericClass.Add("Ali");
            //genericClass.Add("Mohammed");

            //Console.WriteLine(genericClass.GetValues().Count); //3
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            ////T must have parameterless constructor.

            //GenericParamterless<Person> genericParamterless = new();
            //genericParamterless.Create();
            #endregion

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T swap = a;
            a = b;
            b = swap;
        }

        public static T FindMax<T>(List<T> values) where T : IComparable<T>
        {
            T Max = values[0];
            foreach (T value in values)
            {
                //if(value > Max)
                if (value.CompareTo(Max) > 0)
                    Max = value;
            }
            return Max;
        }
    }
    public class Pair<TKey, TValue>
    {
        public Pair(TKey first, TValue second)
        {
            First = first;
            Second = second;
        }

        public TKey First { get; set; }
        public TValue Second { get; set; }
    }
    public interface IRepository<TEntity>
    {
        void Add(TEntity item);
        List<TEntity> GetAll();
    }
}