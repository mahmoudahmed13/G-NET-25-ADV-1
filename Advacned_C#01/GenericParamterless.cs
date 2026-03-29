using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advacned_C_01
{
    internal class GenericParamterless<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
