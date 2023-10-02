using System;
using System.Collections.Generic;

namespace Homework6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> planetValidationFunc = planetName =>
            {
                if (planetName == "Лимония")
                {
                    return "Вы спрашиваете слишком часто";
                }
                return null;
            };

            var planetCatalog = new PlanetList(planetValidationFunc);

            string[] planetNames = { "Земля", "Лимония", "Марс" };

            foreach (var planetName in planetNames)
            {
                string result = planetCatalog.GetPlanet(planetName);
                Console.WriteLine(result);
            }
        }
    }
}