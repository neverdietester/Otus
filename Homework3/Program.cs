using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадартного уравнения a * x^2 + b * x + c = 0");

            string message = "";
            int a = NumberEntry(message);
            int b = NumberEntry(message);
            int c = NumberEntry(message);

            Console.WriteLine($"Значение a = {a}");
            Console.WriteLine($"Значение b = {b}");
            Console.WriteLine($"Значение c = {c}");


            var discriminantInt = (double)(b * b - 4 * a * c);

            Console.WriteLine($"Дискриминант равен = {discriminantInt}");
            Console.WriteLine();
            var radix = Math.Sqrt(discriminantInt);
           
            double x1;
            double x2;
            double d = 2 * a;



            try
            {
                if (discriminantInt > 0)
                {
                    if (d == 0) throw new DivideByZeroException();
                    x1 = (-b + radix) / (d);
                    x2 = (-b - radix) / (d);
                    Console.WriteLine($"Значение x1 =  {x1}");
                    Console.WriteLine($"Значение x2 =  {x2}");
                }
            }

            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"! При рассчете вещественных значений произошла ошибка: На ноль делить нельзя!: {ex.Message}");
                Console.ResetColor();
            }

            try
            {
                if (discriminantInt < 0)
                {
                    throw new CalculatioтError("Вещественных значений не найдено");
                }
            }

            catch (CalculatioтError ex)
            {
                FormatData(ex.Message, Severity.Warning);
            }

            try
            {
                if (discriminantInt == 0)
                {
                    x1 = ((-b + radix) / (2 * a));

                    Console.WriteLine($"Значение x =  {x1}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка:{ ex.Message}");
            }
        }

    private static int NumberEntry(string numeric)
        {
            while (true)
            {
                Console.WriteLine($"Введите число: {numeric}");
                var input = Console.ReadLine();
                try
                {
                    int result = Convert.ToInt32(input);
                    return result;
                }
                catch (System.FormatException ex)
                {
                    FormatData($"Значение числа должно быть целым!:{ex.Message}", Severity.Error);
                }
            }
        }

        static void FormatData(string message, Severity severity)
        {
            if (severity == Severity.Error)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            if (severity == Severity.Warning)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
        enum Severity
        {
            Error,
            Warning
        }

    }
    [Serializable]
    internal class CalculatioтError : Exception
    {

        public CalculatioтError()
        {
        }

        public CalculatioтError(string message) : base(message)
        {
        }

        public CalculatioтError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CalculatioтError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
