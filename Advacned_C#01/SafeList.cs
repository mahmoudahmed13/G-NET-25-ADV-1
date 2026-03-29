namespace Advacned_C_01
{
    internal class SafeList<T>
    {
        private List<T> _items = new();

        public void Add(T item) => _items.Add(item);

        public T? GetIndex(int index)
        {
            if (index >= 0 && index < _items.Count)
                return _items[index];
            return default(T);
        }
    }
}
