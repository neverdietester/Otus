using System;

namespace Otus
{
    class Program
    {
        static void Main(String[] args)
        {
            int n;
            while (true)
            {
                Console.WriteLine("Введите размерность таблицы");
                var inputString = Console.ReadLine();
                var dimension = int.TryParse(inputString, out var dimensionCount);
                if (dimension && dimensionCount >= 1 && dimensionCount <= 6)
                {
                    n = dimensionCount;
                    break;
                }
                Console.WriteLine("Размерность таблицы должна быть от 1 до 6");
            }

            string custom;
            while (true)
            {
                Console.WriteLine("Введите произвольный текст:");
                custom = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(custom) || custom.Length > 40)

                {
                    Console.WriteLine("Значение должно быть не пустым и меньше 40 символов");
                }

                else
                    break;
            }

            var tabWidth = (2*n + custom.Length);
            var tabHeight = (1 + 2*n);
            var wordTab = tabWidth - custom.Length - n - 2;
            
            //слово
            for (int j = 0; j < tabHeight; j++)
            {
                if (j == 0 || j == tabHeight - 1 && j != n)
                {
                    for (int i = 0; i < tabWidth; i++)
                    {
                        Console.Write("+");
                    }
                }
                if (j > 0 && j < tabHeight - 1 && j != n)
                {
                    Console.Write("+");
                    for (int i = 1; i <= tabWidth - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("+");

                }
                if (j == n)
                {
                    Console.Write("+");
                    for (int i = 0; i <= wordTab; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(custom);
                    for (int i = 0; i <= wordTab; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("+");

                }
                Console.WriteLine();
            }

            //шахматы
            for (int j = 1; j < tabHeight - 1; j++)
            {
                Console.Write("+");
                for (int i = 1; i <= tabWidth - 2; i++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("+");
                Console.WriteLine();

            }

            //линия
            for (int i = 0; i < tabWidth; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();

            //диогонали
            for (int j = 1; j <= tabWidth - 2; j++)
            {
                Console.Write("+");
                for (int i = 1; i < tabWidth - 1; i++)
                {
                    if (j == i || j == -i + (tabWidth - 1))
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("+");
                Console.WriteLine();
            }
            
            //линия
            for (int i = 0; i < tabWidth; i++)
            {
                Console.Write("+");
            }

        }
    }
}