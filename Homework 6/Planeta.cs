using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class Planeta
    {
        public Planeta(string name, int serialNumber, int lengthOfEquator, string previousPlanet)
        {
            Name = name;
            SerialNumber = serialNumber;
            LengthOfEquator = lengthOfEquator;
            PreviousPlanet = previousPlanet;
        }

        public string Name { get; }
        public int SerialNumber { get; }
        public int LengthOfEquator { get; }
        public string PreviousPlanet { get; }

    }
}