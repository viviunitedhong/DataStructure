using System;

namespace ArrayPractices
{
    public class Array
    {
        private int[] _data;

        // The length of the Array
        private int _length;

        // The actual used count
        private int _count;

        public Array(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException("Capacity should be greater than 0");
            }

            _data = new int[capacity];
            _length = capacity;
            _count = 0;
        }

        public int Find(int index)
        {
            if (index < 0 || index >= _count)
            {
                return -1;
            }

            return _data[index];
        }

        public bool Insert(int index, int value)
        {
            if (index < 0 || index > _count)
            {
                Console.WriteLine("Invalid index {0}", index);
                return false;
            }

            if (_length == _count)
            {
                Console.WriteLine("The array is aready full");
                return false;
            }

            for (var i = _count; i > index; i--)
            {
                _data[i] = _data[i - 1];
            }

            _data[index] = value;

            _count++;

            return true;
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= _count)
            {
                Console.WriteLine("Invalid index {0}", index);
                return false;
            }

            for (var i = index + 1; i < _count; i++)
            {
                _data[i - 1] = _data[i];
            }

            _count--;

            return true;
        }

        public void PrintAll()
        {
            Console.WriteLine("This array has {0} items.", _count);
            for (var i = 0; i < _count; i++)
            {
                Console.Write(_data[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
