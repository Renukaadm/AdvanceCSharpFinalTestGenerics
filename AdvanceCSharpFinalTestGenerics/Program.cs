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
            GenericClass<string> gs = new GenericClass<string>();
            gs.addElements("John");
            gs.addElements("Renuka");
            gs.addElements("Adam");

            gs.SortElements();

            Console.Write(gs.getElements(2));

            GenericClass<int> gs1 = new GenericClass<int>();
            gs1.addElements(1003);
            gs1.addElements(2005);
            gs1.addElements(5244);
            gs1.addElements(2424);

            gs1.SortElements();

            Console.Write(gs1.getElements(1));

        }
    }

    public class GenericClass<T> : IEnumerable<T>
    {
        private List<T> list = new List<T>();

        public void addElements(T item)
        {
            list.Add(item);
            Console.WriteLine("Added Item:{0}", item);
        }

        public T getElements(int index)
        {
            Console.WriteLine("get eleements from list at Index : {0}", index);
            return list[index];
               
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public void SortElements()
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("After sorting List:");
            foreach (var item in list)
                Console.WriteLine(item);
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
