using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Собери свой словарь");
            Console.WriteLine();

            OtusDictionary otusDictionary = new OtusDictionary();

            otusDictionary.Add(3, "Vollga");
            otusDictionary.Add(2, "Vol");
            otusDictionary.Add(3, "Vol");

            var result = otusDictionary.Get(2);

            Console.WriteLine($"Найдено значение: {result}");
        }
    }
}