using System;
using System.Diagnostics;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Расчет посдедовательности Фибоначчи");

            Console.WriteLine("!Рекурсия!");

            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {RecursionFib(5)}");
            TimeSpan tsFib = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib);
            stopWatch.Restart();

            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {RecursionFib(10)}");
            TimeSpan tsFib1 = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib1);
            stopWatch.Restart();

            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {RecursionFib(20)}");
            TimeSpan tsFib2 = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib2);
            stopWatch.Restart();
            
            Console.WriteLine("!Цикл!");

            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {CycleFib(5)}");
            TimeSpan tsFib3 = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib3);
            stopWatch.Restart();

            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {CycleFib(10)}");
            TimeSpan tsFib4 = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib4);
            stopWatch.Restart();

            stopWatch.Start();
            Console.WriteLine($"Значение для n=5: {CycleFib(20)}");
            TimeSpan tsFib5 = stopWatch.Elapsed;
            Console.WriteLine("RunTime: " + tsFib5);
        }
        

        static int RecursionFib(int n)
        {
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return (RecursionFib(n - 1) + RecursionFib(n - 2));
                }
            }
        }

        static long CycleFib(int n)
        {
            if (n == 0) return 0;
            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
    }
}
