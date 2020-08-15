using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdvanceCSharpFinalTestGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class GenericClass<T> : IEnumerable<T>
    {
        private List<T> list { get; set; }

        public void addElements(T item)
        {
            list.Add(item);
        }

        public void getElements(T item)
        {
            return item[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void sortElements(T item)
        {
            list.Sort();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
