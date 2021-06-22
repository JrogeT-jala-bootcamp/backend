﻿#nullable enable
using System;

namespace NullManipulation
{
    class Program
    {
        class Address
        {
            public string? Building;
            public string Street;
            public string City;
            public string Region;
        }

        static void Main(string[] args)
        {
            int x = 1;
            int? nx = null;

            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);

            nx = 20;

            Console.WriteLine("nx has a value? {0}", nx.HasValue);
            Console.WriteLine("nx has the value? {0}", nx.Value);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);

            nx = null;
            Console.WriteLine("nx = {0}", nx ?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));

            nx = 10;
            Console.WriteLine("nx = {0}", nx ?? -1);
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault());
            Console.WriteLine("nx = {0}", nx.GetValueOrDefault(-2));

        }
    }
}