using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryTask
{
    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public MyDictionary()
        {
            keys = new TKey[4];
            values = new TValue[4];
            count = 0;
        }
        public void Add(TKey key, TValue value)
        {
            if (count == keys.Length)
            {
                Resize();
            }

            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                    throw new ArgumentException("The key already exists");

            }
            keys[count] = key;
            values[count] = value;
            count++;
        }

        private void Resize()
        {
            TKey[] newKeys = new TKey[keys.Length * 2];
            TValue[] newValues = new TValue[values.Length * 2];

            for (int i = 0; i < keys.Length; i++)
            {
                newKeys[i] = keys[i];
                newValues[i] = values[i];
            }

            keys = newKeys;
            values = newValues;
        }

        public TValue this[TKey key]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (keys[i].Equals(key))
                    {
                        return values[i];
                    }
                }
                throw new NotImplementedException("The key not found");
            }
        }

        public int Count
        { get { return count; } }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}