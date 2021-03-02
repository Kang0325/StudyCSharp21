using System;

namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자. 대신 호출한다.

    class Program
    {
        class Calculator
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }

            public int Minus(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {Callback(3, 4)}");

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {Callback(4, 3)}");
        }
    }
}
