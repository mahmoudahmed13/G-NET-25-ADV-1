using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advacned_C_01
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"{Name} with {Age} Years";
    }
}
