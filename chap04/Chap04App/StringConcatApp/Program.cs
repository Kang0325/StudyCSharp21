using System;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456;
            Console.WriteLine(123+p2);
            Console.WriteLine("123" + p2);
            Console.WriteLine($"123{p2}");
            Console.WriteLine(123 + "456");
            Console.WriteLine("123" + "456");

            // 관계연산자
            Console.WriteLine("관계연산자");
            int a = 30, b = 30;
            Console.WriteLine(a < b); //false
            Console.WriteLine(a > b); //false
            Console.WriteLine(a != b); //false
            Console.WriteLine(a <= b); //true
            Console.WriteLine(a >= b); //true
            Console.WriteLine(a == b); //true

            // 논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a > 0); //true
            Console.WriteLine(a > 0 || a > b); //true
            Console.WriteLine(!(a < b)); //true

            // 조건(삼항)연산자 단항 if문을 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삽십아님";
            /*if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/
            Console.WriteLine(result);

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}");
        }
    }
}
