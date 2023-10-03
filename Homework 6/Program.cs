using Gremlin.Net.Process.Traversal;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа 1");

            var Planeta1 = new
            {
                Name = "Venus",
                SerialNumber = 2,
                LengthOfEquator = 38025,
                previousPlanet = (object)null
            };
            var Planeta2 = new
            {
                Name = "Earth",
                SerialNumber = 3,
                LengthOfEquator = 40075,
                PreviousPlanet = Planeta1
            };
            var Planeta3 = new
            {
                Name = "Mars",
                SerialNumber = 4,
                LengthOfEquator = 21344,
                PreviousPlanet = Planeta2
            };

            Console.WriteLine($"Solar system object:{Planeta1}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta1.Name} : { Planeta1.Equals(Planeta1)}");
            Console.WriteLine($"Solar system object:{Planeta2}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta2.Name} : {Planeta2.Equals(Planeta1)}");
            Console.WriteLine($"Solar system object:{Planeta3}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta3.Name} : {Planeta2.Equals(Planeta1)}");

            Console.WriteLine();
            Console.WriteLine("Программа 2");


            PlanetList findPlanet = new PlanetList();
            findPlanet.GetPlanet("Earth");
            findPlanet.GetPlanet("Limoniya");
            findPlanet.GetPlanet("Mars");
            findPlanet.GetPlanet("Limoniya");
            findPlanet.GetPlanet("Mars");

            Console.WriteLine();
            Console.WriteLine("Программа 3");


            PlanetList planetList = new PlanetList();
            Func<string, string?> checkFrequency = (string name) =>
            {
                if (planetList.planetRequestCount % 3 == 0)
                {
                    return "Вы спрашиваете слишком часто";
                }
                else
                {
                    return null;
                }
            };

            (int serialNumber, int lengthOfEquator, string? error) = planetList.GetPlanet("Earth", checkFrequency);
            Console.WriteLine($"Порядковый номер: {serialNumber}, Длина экватора: {lengthOfEquator}, Ошибка: {error}");
        }
    }
}
