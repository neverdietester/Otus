#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class PlanetList
    {
        public List<Planet> Planets { get; set; }
        public int planetRequestCount;

        public PlanetList()
        {
            Planets = new List<Planet>()
            {
                new Planet("Venus", 3, 38025, null)
            };
            Planets.Add(new Planet("Earth", 3, 40075, Planets.Last()));
            Planets.Add(new Planet("Mars", 4, 21344, Planets.Last()));

            planetRequestCount = 0;
        }


        public (int serialNumber, int lengthOfEquator, string? error) GetPlanet(string name)
        {
            planetRequestCount++;
            if (planetRequestCount % 3 == 0)
            {
                Console.WriteLine("Вы спрашиваете слишком часто");
            }

            foreach (var planet in Planets)
            {

                if (name == planet.Name)
                {
                    Console.WriteLine($"Планета есть в списке: Имя: {planet.Name}, Порядковый номер: {planet.SerialNumber}, Длина экватора: {planet.LengthOfEquator}");
                    return (planet.SerialNumber, planet.LengthOfEquator, null);
                }
            }
            return (0, 0, $"Планета отсутствует в списке:{name}");
        }

        public (int serialNumber, int lengthOfEquator, string? error) GetPlanet(string name, Func<string, string?> planetValidator)
        {
            planetRequestCount++;
            string? error = planetValidator(name);
            if (planetValidator != null)
                {
                    return (0, 0, $"Планета отсутствует в списке:{name}");
                }

            foreach (var planet in Planets)
            {
                if (name == planet.Name)
                {
                    Console.WriteLine($"Планета есть в списке: Имя: {planet.Name}, Порядковый номер: {planet.SerialNumber}, Длина экватора: {planet.LengthOfEquator}");
                    return (planet.SerialNumber, planet.LengthOfEquator, null);
                }
            }
            Console.WriteLine($"Планета отсутствует в списке:{name}");
            return (0, 0, $"Планета отсутствует в списке:{name}");
        }


        private Exception ArgumentNullException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
