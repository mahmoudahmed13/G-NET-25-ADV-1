using System.ComponentModel;
using System.Numerics;

namespace Advacned_C_01
{
    //Q20: Complete Exercise - Create a generic Cache<TKey, TValue>
    //with Add, Get, Remove, Contains, and expiration support.
    internal class GenericCashe<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;
        public bool IsExpired { get; set; }

        public GenericCashe()
        {
            _dictionary = new Dictionary<TKey, TValue>();
            IsExpired = false;
        }

        //Add
        public void Add(TKey key, TValue value)
        {
            if( _dictionary.ContainsKey(key))
                Console.WriteLine("This Key has Value");
            _dictionary.Add(key, value);
        }
        //Get
        public TValue GetValue(TKey key)
        {
            if (_dictionary.Count == 0)
                return default(TValue);
            if (!_dictionary.ContainsKey(key))
            {
                Console.WriteLine("This Key is not fount");
                return default;
            }
            return _dictionary[key];
        }
        //Remove
        public TValue RemoveValue(TKey key)
        {
            if (_dictionary.Count == 0)
                return default(TValue);
            if (!_dictionary.ContainsKey(key))
            {
                Console.WriteLine("You can not remove this Key is not fount");
                return default;
            }
            _dictionary.Remove(key);
            return _dictionary[key];
        }
        //Contains
        public bool Contains()
        {
            return _dictionary.Count > 0;
        }
        //Expiration
        public  TValue Expitation(TKey key) 
        {
            if (_dictionary.ContainsKey(key))
            {
                IsExpired = true;
            }
            return _dictionary[key];
        }


    }
}
