using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    class PlanetList
    {
        private List<Planet> planets;
        private Func<string, string> planetValidator;

        public PlanetList(Func<string, string> validator)
        {
            planets = new List<Planet>
        {
            new Planet { Name = "Венера", SerialNumber = 2, LengthOfEquator = 3774 },
            new Planet { Name = "Земля", SerialNumber = 3, LengthOfEquator = 40075 },
            new Planet { Name = "Марс", SerialNumber = 4, LengthOfEquator = 21340 }
        };

            planetValidator = validator;
        }

        public string GetPlanet(string planetName)
        {
            string validationResult = planetValidator(planetName);

            if (validationResult != null)
            {
                return validationResult;
            }

            var foundPlanet = planets.Find(p => p.Name == planetName);
            if (foundPlanet != null)
            {
                return $"Планета: {foundPlanet.Name}, Порядковый номер: {foundPlanet.SerialNumber}, Длина экватора: {foundPlanet.LengthOfEquator}";
            }
            else
            {
                return "Не удалось найти планету";
            }
        }
    }
}
