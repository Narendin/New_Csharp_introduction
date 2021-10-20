using System;
using System.Diagnostics;

namespace Less3Ex2
{
    /*
        Долгуев Владимир.
        2. Реализовать метод, который в качестве входного параметра принимает строку string,
        возвращает строку типа string, буквы в которой идут в обратном порядке.
        Протестировать метод.
     */

    internal class Program
    {
        private static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByStringBuilder());          // По итогу - самый медленный способ
            stopwatch.Stop();
            Console.WriteLine($"from StringBuilder: {stopwatch.ElapsedTicks} ticks");

            stopwatch.Restart();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByCharArray());              // По итогу - самый быстрый способ
            stopwatch.Stop();
            Console.WriteLine($"from CharArray: {stopwatch.ElapsedTicks} ticks");

            stopwatch.Restart();
            Console.WriteLine("\nHello World! -> " + "Hello World!".ReverseByLINQ());
            stopwatch.Stop();
            Console.WriteLine($"from LINQ: {stopwatch.ElapsedTicks} ticks");

            Console.ReadKey();
        }
    }
}