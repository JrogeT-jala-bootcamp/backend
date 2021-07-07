using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Expresion expresion = new(20, 10);
            expresion.ApplyOperator(new Addition());
            expresion.ApplyOperator(new Substraction());
            int result = expresion.Resolve();
            Console.WriteLine($"Result: {result}");
        }

        class GeneralOperation
        {
            public delegate int Operation(int a, int b);

            public Operation operation = new((int a, int b) => 0);
        }

        class Addition : GeneralOperation
        {
            public Addition()
            {
                operation = new((int a, int b) => a + b);
            }
        }

        class Substraction : GeneralOperation
        {
            public Substraction()
            {
                operation = new((int a, int b) => a - b);
            }
        }

        class Expresion
        {
            private readonly int First;
            private readonly int Second;
            private GeneralOperation GeneralOperation;

            public Expresion(int first, int second)
            {
                First = first;
                Second = second;
                GeneralOperation = new();
            }

            public void ApplyOperator(GeneralOperation newOperation)
            {
                GeneralOperation = newOperation;
            }

            public int Resolve()
            {
                return GeneralOperation.operation(First, Second);
            }
        }
    }
}
