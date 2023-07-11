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
            var radix = Math.Sqrt(discriminantInt);
           
            double x1;
            double x2;

            try
            {
                if (discriminantInt > 0)
                {
                    x1 = (-b + radix) / (2 * a);
                    x2 = (-b - radix) / (2 * a);
                    Console.WriteLine($"Значение x1 =  {x1}");
                    Console.WriteLine($"Значение x2 =  {x2}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя");
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
            catch
            {
                Console.WriteLine("Произошла непредвиденная ошибка");
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
                    FormatData(ex.Message, Severity.Error);
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
