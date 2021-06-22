﻿using System;

namespace VarTypeDeclarations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -100;
            Console.WriteLine(a);
            int b = -128;
            Console.WriteLine(b);
            uint c = 3540;
            Console.WriteLine(c);

            uint d = 64876;
            Console.WriteLine(d);

            uint e = 2147483648;
            Console.WriteLine(e);

            int f = -1141583228;
            Console.WriteLine(f);
            long g = -1223372036854770;
            Console.WriteLine(g);
            int h = 808;
            Console.WriteLine(h);
            int i = 2_000_000;
            Console.WriteLine(i);
            int j = 0b_0001_1110_1000_0100_1000_0000;
            Console.WriteLine(j);
            int k = 0x_001e_8480;
            Console.WriteLine(k);

            decimal l = 3.141592653589793238m;
            Console.WriteLine(l);
            float m = 1.60217657f;
            Console.WriteLine(m);
            decimal n = 7.8184261974584555216535342341m;
            Console.WriteLine(n);
        }
    }
}
