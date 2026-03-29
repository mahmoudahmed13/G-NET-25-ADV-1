using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Advacned_C_01
{
    internal class GenericInterface<T> where T : INumber<T>
    {
        public T Sum(T a,  T b)=> a + b;
        public T Multiplication(T a, T b) => a * b;

    }
}
