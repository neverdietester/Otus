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

            //    enum Severity
            //{
            //    Warning,
            //    Error
            //}
            
            int a = 0;
            int b = 0;
            int c = 0;

            while (true)
            {
                Console.WriteLine("Введите число a:");
                var input = Console.ReadLine();
                try
                {
                    int result = Convert.ToInt32(input);
                    a = result;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Значение должно быть целым числом");
                }
            }

            while (true)
            {
                Console.WriteLine("Введите число b:");
                var input = Console.ReadLine();
                try
                {
                    int result = Convert.ToInt32(input);
                    b = result;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Значение должно быть целым числом");
                }
            }

            while (true)
            {
                Console.WriteLine("Введите число c:");
                var input = Console.ReadLine();
                try
                {
                    int result = Convert.ToInt32(input);
                    c = result;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Значение должно быть целым числом");
                }
            }
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
                    Console.WriteLine("Вещественных значений не найдено");
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
            

            //static void FormatData((string message, Severity severity, IDictionary data))
            //{
            //    switch (severity)
            //    {
            //        case Severity.Error:
            //            throw Exception(e);
            //        case Severity.Warning:
            //            throw Exception(e);
            //        default:
            //            throw new InvalidOperationException($"Непонятная ошибка");
            //    }
            //}

            //static void FormatData((string message, Severity severity, IDictionary data))
            //{
            //        Console.WriteLine("Введите значение a:");
            //        double d = 0;
            //        try
            //        {
            //            d = Convert.ToDouble(Console.ReadLine());
            //        }
            //        catch (FormatException e)
            //        {
            //            Console.WriteLine("Произошла ошибка" + e.Error);
            //            return;
            //        }
            //    }
            //}

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