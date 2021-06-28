using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {

        class MyGenericArray<T>
        {
            List<T> list;

            public MyGenericArray()
            {
                list = new();
            }

            public void AddItem(T newItem)
            {
                list.Add(newItem);
            }

            public List<T> GetList() => list;

        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }

        static void Main(string[] args)
        {
            //MyGenericArray<int> x = new();

            //for (int i = 1; i <= 5; i++)
            //{
            //    x.AddItem(i);
            //}

            //Console.WriteLine(string.Join(",", x.GetList()));

            //int a, b;
            //char c, d;
            //a = 10;
            //b = 20;
            //c = 'I';
            //d = 'V';

            //Console.WriteLine("Before calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //Swap<int>(ref a, ref b);
            //Swap<char>(ref c, ref d);

            //Console.WriteLine("after calling swap:");
            //Console.WriteLine("a = {0}, b = {1}", a, b);
            //Console.WriteLine("c = {0}, d = {1}", c, d);

            //MySuperClass<MyClass> x = new();

            Person.Unique1.Name = "pepe";
            Console.WriteLine(Person.Unique1.Name);

        }

        public class Person : UniqueInstance<Person>
        {
            public string Name;

        }

        public class UniqueInstance<T> where T : new()
        {
            private static T Unique;

            public static T Unique1 { get => Unique == null ? Unique=new() : Unique; }
        }
    }
}
