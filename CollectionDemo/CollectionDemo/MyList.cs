using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class MyList<T> : IEnumerable<T> //generic class created explictly.
    {
        public int Count { get; set; }

        int size;
        T[] arr; //datatype of collection can be anything
        public MyList(int size)
        {
            this.size = size;
            arr = new T[size];
        }
        public void Add(T data)
        {
            if (Count >= size)
                throw new Exception("Data is full");
            arr[Count] = data;
            Count++;

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
                yield return arr[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //We use indexing
        public T this[int i]
        {
            get { return arr[i]; }
        }

    }
}
