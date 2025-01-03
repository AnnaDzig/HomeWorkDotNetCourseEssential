using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListCollection
{
    internal class MyList<T> : IEnumerable
    {
        private T[] items;
        private int count;

        public MyList()
        {
            items = new T[4];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count] = item;
            count++;
        }

        private void Resize()
        {
            T[] newItems = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)

                    throw new IndexOutOfRangeException("Index out of range");
                return items[index];
            }
        }

        public int Count
        {
            get { return count; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
            }
        }
    
    

