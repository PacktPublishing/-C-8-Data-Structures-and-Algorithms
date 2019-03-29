using System;
using System.Collections.Generic;
using System.Text;

namespace Heaps
{
    public class MaxHeap
    {
        private readonly List<int> _items;
        private int _lastPosition => _items.Count;

        public MaxHeap(int value)
        {
            _items = new List<int>();
            _items.Add(value);
        }

        public int Peek()
        {
            if (_lastPosition == 0) throw new Exception("The heap is empty!");
            return _items[0];
        }

        public int Pop()
        {
            if (_lastPosition == 0) throw new Exception("The heap is empty!");

            int oldMin = _items[0];
            _items[0] = _items[_lastPosition - 1];
            _items.RemoveAt(_lastPosition - 1);


            PercolateDown();

            return oldMin;
        }

        public void Add(int value)
        {
            _items.Add(value);

            PercolateUp();
        }

        public void PrintElements() => _items.PrintElements();


        private void PercolateUp()
        {
            int itemIndex = _lastPosition - 1;

            while (HasParent(itemIndex) 
                && _items[itemIndex] >= _items[GetParent(itemIndex)])
            {
                int parentIndex = GetParent(itemIndex);
                _items.Swap(itemIndex, parentIndex);
                itemIndex = parentIndex;
            }
        }

        private void PercolateDown()
        {
            int itemIndex = 0;

            while (HasLeft(itemIndex))
            {
                int smaller = GetLeft(itemIndex);
                if (HasRight(itemIndex) 
                    && _items[GetRight(itemIndex)] >= _items[GetLeft(itemIndex)])
                {
                    smaller = GetRight(itemIndex);
                }

                if (_items[smaller] < _items[itemIndex]) break;

                _items.Swap(smaller, itemIndex);
                itemIndex = smaller;
            }
        }

        private int GetParent(int index) => (index - 1) / 2;

        private int GetLeft(int index) => index * 2 + 1;

        private int GetRight(int index) => index * 2 + 2;

        private bool HasLeft(int index) => GetLeft(index) < _lastPosition;

        private bool HasRight(int index) => GetRight(index) < _lastPosition;

        private bool HasParent(int index) => index > 0;
    }
}
