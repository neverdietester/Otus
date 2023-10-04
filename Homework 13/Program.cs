using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Homework!");

            var listValue = new List<int> { 12, 2, 3, 4, 5, 6, 7, 8, 1 };
            var listPersonData = new List<PersonData> { new("Ольга", 18), new("Настя", 23), new("Кирилл", 32), new("Валера", 21), new("Дима", 29), new("Леша", 25), new("Наташа", 26) };

            var result = listValue.Top(50);
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }

            var result2 = listPersonData.Top(50, x => x.Age);
            foreach (var element in result2)
            {
                Console.WriteLine($"Имя:{element.Name} Возраст: {element.Age}");


            }
        }
    }
}
