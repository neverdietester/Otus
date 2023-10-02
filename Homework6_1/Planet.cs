using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_1
{
    class Planet
    {
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public double LengthOfEquator { get; set; }
        public Planet PreviousPlanet { get; set; }
    }
}
