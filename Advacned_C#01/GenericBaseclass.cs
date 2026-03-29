using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advacned_C_01
{
    internal class GenericBaseclass<T> where T : Person
    {
        private List<T> _people = [];
        public void AddPerson(T person) => _people.Add(person);

    }
}
