using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class CarriageBlock<T> : IEnumerable where T : IRollingStock
    {
        private LinkedList<T> carriages;

        public CarriageBlock(LinkedList<T> carriages)
        {
            this.carriages = carriages;
        }

        public int Count
        {
            get
            {
                return carriages.Count();
            }
        }

        public IRollingStock this[int k]
        {
            get
            {
                return carriages.ElementAt(k);
            }
        }

        public CarriageBlock<T> Hook(CarriageBlock<T> other)
        {
            foreach (T item in other.carriages)
            {
                carriages.AddLast(item);
            }
            return this;
        }

        public CarriageBlock<T> Unhook(int positionFrom)
        {
            if (positionFrom >= carriages.Count()) throw new IndexOutOfRangeException();
            var count = carriages.Count();

            for (int i = 0; i < count - positionFrom; i++)
                carriages.RemoveLast();

            return this;
        }

        public IEnumerator GetEnumerator()
        {
            return carriages.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
