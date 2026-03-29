using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advacned_C_01
{
    internal class GenericStruct<T> where T : struct
    {
        private readonly List<T> _values = [];
        
        public void Add(T item) => _values.Add(item);
        public List<T> GetValues() => _values;


    }
}
