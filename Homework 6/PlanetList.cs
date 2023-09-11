#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Homework_6
{
    class PlanetList
    {
        public List<Planet> Planets { get; set; }

        public PlanetList()
        {
            Planets = new List<Planet>()
            {
                new Planet("Venus", 3, 38025, null)

            };
            Planets.Add(new Planet("Earth", 3, 40075, Planets.Last()));
            Planets.Add(new Planet("Mars", 4, 21344, Planets.Last()));
        }

        
        public (int serialNumber, int lengthOfEquator, string? error) GetPlanet(string name)
        {
            foreach (var planet in Planets )
            {
                if (name == planet.Name)
                {
                    Console.WriteLine($"Планета есть в списке: Имя: {planet.Name}, Порядковый номер: {planet.SerialNumber}, Длина экватора: {planet.LengthOfEquator}");
                    return (planet.SerialNumber, planet.LengthOfEquator, null);
                }
            }
            Console.WriteLine($"Планета отсутствует в списке:{name}");
            return (-1,-1,"error");
        }
    }
}
