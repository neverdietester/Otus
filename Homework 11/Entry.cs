using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class Entry
    {
        public int Key { get; }
        public string Value { get; }

        public Entry(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
