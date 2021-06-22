using System;
using System.Collections.Generic;

namespace FibonacciGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            string generatedSerie = GenerateFibonacciSerie(10);
            string x = "\"";
            Console.WriteLine(generatedSerie);
            double a = 0.1;
            double b = 0.2;
            if ((double)((double)a + (double)b) == (double)0.3)
                Console.WriteLine(x);
            Console.ReadKey(true);
        }

        private static string GenerateFibonacciSerie(int n)
        {
            List<int> elements = new();
            int x = 1;
            int y = 0;
            int z;
            for (int i = 1; i <= n; i++)
            {
                z = x + y;
                elements.Add(z);
                x = y;
                y = z;
            }
            return string.Join(",", elements.ToArray());
        }
    }
}
