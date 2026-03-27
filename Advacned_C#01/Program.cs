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
        }
    }
}