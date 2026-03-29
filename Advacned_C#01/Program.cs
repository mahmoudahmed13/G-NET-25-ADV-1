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

            #region Q10:  What is the interface constraint? Write an example.
            ////T must implement interface
            //GenericInterface<int> genericInterface = new GenericInterface<int>();
            //Console.WriteLine(genericInterface.Multiplication(3, 5)); //15
            //Console.WriteLine(genericInterface.Sum(3, 5)); //8
            #endregion

            #region Q11: What is the base class constraint? Write an example.
            ////T must inherit from BaseClass
            //GenericBaseclass<Person> genericBaseclass = new();
            //genericBaseclass.AddPerson(new Person() { Name = "Mahmoud", Age = 30 });
            #endregion

            #region Q12: How do you apply multiple constraints? Write an example. 
            //You can apply multiple constraints on a generic type parameter using the (where) keyword.
            //This allows you to combine base class, interface, new(), struct, and
            //class constraints together for maximum type safety.

            //MultipleConstraints<Person> multipleConstraints = new();

            #endregion

            #region Q13: What does the 'default' keyword do in generics?
            // returns the default value for type T: null for reference types, 0/false for value types.
            #endregion

            #region Q14: Write a SafeList<T> that returns default when the index is invalid.
            //SafeList<int> safeList = new SafeList<int>();
            //safeList.Add(1);
            //safeList.Add(2);
            //safeList.Add(3);
            //Console.WriteLine(safeList.GetIndex(1)); //2
            //Console.WriteLine(safeList.GetIndex(5)); //0
            #endregion

            #region Q15: What is covariance? Explain the 'out' keyword.
            //Covariance allows you to use a more derived type than originally specified.
            //In generic terms, if Dog derives from Animal, covariance lets you treat List<Dog>
            //as List<Animal> — moving from more specific to more general.
            //The out keyword marks a generic type parameter as covariant.

            #endregion

            #region Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows you to use a less derived type than originally specified.
            //Marked with in keyword. T can only appear in input positions.
            #endregion

            #region Q17: What is the difference between covariance and contravariance?
            //Covaraince -> producer of T and return only(output). like -> IEnumerable<out T>
            //Contravaraince -> Consumer of T and input only(parameter).like -> IComparer<in T>

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