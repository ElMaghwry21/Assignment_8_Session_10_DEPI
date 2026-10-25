using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Session_10_DEPI
{
    public class FixedSizeList<T>
    {
        private readonly List<T> _items;
        public int Capacity { get; }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            Capacity = capacity;
            _items = new List<T>(capacity);
        }

        public void Add(T item)
        {
            if (_items.Count >= Capacity)
            {
                throw new InvalidOperationException("Error: The list is already full! Cannot add more elements.");
            }
            _items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Error: Invalid index or index out of range!");
            }
            return _items[index];
        }

        public int Count => _items.Count;
    }
}
