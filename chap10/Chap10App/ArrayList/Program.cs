using System;
using System.Collections;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34 });

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81 위치에 50 추가");
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);
            array.RemoveAt(loc); // 90삭제

            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }
            
            Console.WriteLine("정렬");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }
        }
    }
}
