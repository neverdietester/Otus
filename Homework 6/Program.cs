using Gremlin.Net.Process.Traversal;
using OpenXmlPowerTools;
using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Planeta1 = new
            {
                Name = "Venus",
                SerialNumber = 2,
                LengthOfEquator = 38025,
                //PreviousPlanet = new { p = null }
            };
            var Planeta2 = new
            {
                Name = "Earth",
                SerialNumber = 3,
                LengthOfEquator = 40075,
                //PreviousPlanet = ;
            };
            var Planeta3 = new
            {
                Name = "Mars",
                SerialNumber = 4,
                LengthOfEquator = 21344,
                //PreviousPlanet = 
            };

            Console.WriteLine($"Solar system object:{Planeta1}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta1.Name} : { Planeta1.Equals(Planeta1)}");
            Console.WriteLine($"Solar system object:{Planeta2}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta2.Name} : {Planeta2.Equals(Planeta1)}");
            Console.WriteLine($"Solar system object:{Planeta3}");
            Console.WriteLine($"{Planeta1.Name} & {Planeta3.Name} : {Planeta2.Equals(Planeta1)}");

            CatalogPlanet catalogPlanet = new CatalogPlanet
            {
            };
          
        }
    }
}
