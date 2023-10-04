using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    public class PersonData
    {
        public string Name { get; }
        public int Age { get; }

        public PersonData(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
