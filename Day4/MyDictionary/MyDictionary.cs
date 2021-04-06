using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T1[] _tempKey;
        T2[] values;
        T2[] _tempValue;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            _tempKey = keys;
            _tempValue = values;

            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                keys[i] = _tempKey[i];
            }
            for (int i = 0; i < _tempValue.Length; i++)
            {
                values[i] = _tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
