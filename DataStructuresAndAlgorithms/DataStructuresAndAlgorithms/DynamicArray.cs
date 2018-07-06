using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class DynamicArray<String>
    {
        private Object[] _data;
        private int _size;
        private int _initialCapacity;

        public DynamicArray(int initialCapacity)
        {
            this._initialCapacity = initialCapacity;
            _data = new Object[initialCapacity];
        }

        public string Get(int index)
        {
            return (string)_data[index];
        }

        public void Set(int index, string value)
        {
            if (_data[index] != null) _size++;
            _data[index] = value;
        }

        public void Insert(int index, string value)
        {
            var newDynamicArray = new DynamicArray<String>(_data.Length + 1);
            for (int i = 0; i < _data.Length + 1; i++)
            {
                if (i < index)
                {
                    newDynamicArray.Set(i, this.Get(i));
                }
                else if (i == index)
                {
                    newDynamicArray.Set(i, value);
                }
                else
                {
                    newDynamicArray.Set(i, this.Get(i - 1));
                }
            }
        }

        public void Delete(int index)
        {

        }
    }
}
