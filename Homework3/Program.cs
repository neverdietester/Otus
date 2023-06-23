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


            var discriminantInt = (b * b - 4 * a * c);
            double discriminant = Convert.ToDouble(discriminantInt);
            double a1 = Convert.ToDouble(a);
            double b1 = Convert.ToDouble(b);
            double c1 = Convert.ToDouble(c);

            Console.WriteLine($"Дискриминант равен = {discriminantInt}");
            var radix = Math.Sqrt(discriminant);
            double x1 = 0;
            double x2 = 0;


            try
            {
                if (discriminant > 0)
                {
                    x1 = ((-b1 + radix) / (2 * a));
                    x2 = ((-b1 - radix) / (2 * a));
                    Console.WriteLine($"Значение x1 =  {x1}");
                    Console.WriteLine($"Значение x2 =  {x2}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Значение дискриминанта отрицательное");
            }


            try
            {
                if (discriminant < 0)
                {
                    throw new MyException();
                }
            }

            catch (MyException ex)
            {
                FormatData(message, Severity.Warning);
            }


            try
            {
                if (discriminant == 0)
                {
                    x1 = ((-b1 + radix) / (2 * a));

                    Console.WriteLine($"Значение x =  {x1}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка");
            }
        }

    private static int NumberEntry(string message)
        {
            while (true)
            {
                Console.WriteLine($"Введите число: {message}");
                var input = Console.ReadLine();
                try
                {
                    int result = Convert.ToInt32(input);
                    return result;
                    //break;
                }
                catch (Exception ex)
                {
                    FormatData(message, Severity.Error);
                }
            }
        }

        static void FormatData(string message, Severity severity)
        {
            if (severity == Severity.Error)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Значение должно быть целым числом");
                Console.ResetColor();
            }
            if (severity == Severity.Warning)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вещественных значений не найдено");
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
    internal class MyException : Exception
    {
        private object ex;

        public MyException()
        {
        }

        public MyException(object ex)
        {
            this.ex = ex;
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
