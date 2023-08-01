using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class CatalogPlanet
    {
        List<string> heavenlyBody = new List<string>() { "Venus", "Earth", "Mars" };

        public (int serialNumber, int lengthOfEquator, string error) GetPlanet(string name)
        {
            Console.WriteLine("Введите имя планеты:");
            name = Console.ReadLine();
            }
        }
    }
}
