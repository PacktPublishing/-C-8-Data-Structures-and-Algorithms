using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class ArrayList<T>
    {
        private T[] _storage;
        private int _lastItemIndex;

        public ArrayList()
        {
            _storage = new T[4];
            _lastItemIndex = -1;
        }

        public void Add(T item)
        {
            if(_lastItemIndex == _storage.Length - 1)
            {
                ExpandStorage();
            }

            _lastItemIndex++;
            _storage[_lastItemIndex] = item;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);

            if (_lastItemIndex == _storage.Length - 1)
            {
                ExpandStorage();
            }

            // for example, if we copy elements from poisition
            // 4 to position 5, we need to count how many
            // elements are there, and the number is 5 - 4 + 1
            int segmentLength = _lastItemIndex - index + 1;

            // copy the segment starting from the initial 
            // index to the index + 1 to free up the space
            // to insert the element
            Array.Copy(_storage, index, _storage, index + 1, 
                segmentLength);

            _lastItemIndex++;
            _storage[index] = item;
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);

                return _storage[index];
            }
            set
            {
                ValidateIndex(index);

                _storage[index] = value;
            }
        }

        public int Length => _lastItemIndex + 1;

        public int StorageLength => _storage.Length;

        private void ExpandStorage()
        {
            var newStorage = new T[_storage.Length * 2];
            Array.Copy(_storage, newStorage, _storage.Length);
            _storage = newStorage;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > _lastItemIndex)
                throw new ArgumentOutOfRangeException(
                    nameof(index));
        }
    }
}
