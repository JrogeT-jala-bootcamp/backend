using System;
using System.Collections.Generic;

namespace ValueReferenceType
{
    class Program
    {
        struct DetailedInteger
        {
            public int Number;
            List<string> Letters;

            public DetailedInteger(int newNumber)
            {
                Number = newNumber;
                Letters = new();
            }

            public DetailedInteger(DetailedInteger tech)
            {
                Number = tech.Number;
                Letters = new();
            }

            public void AddDetail(string newString)
            {
                this.Letters.Add(newString);
            }

            public override string ToString()
            {
                return $"{Number} [{string.Join(",", Letters.ToArray())}]";
            }
        }

        static void Main(string[] args)
        {
            var n1 = new DetailedInteger(0);
            n1.AddDetail("A");
            Console.WriteLine(n1);

            var n2 = n1;
            n2.Number = 7;
            n2.AddDetail("B");

            Console.WriteLine(n1);
            Console.WriteLine(n2);

        }
    }
}
