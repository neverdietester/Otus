using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Stack
    {
        private List<string> _lines;

        public Stack(params string[] input)
        {
            _lines = input.ToList();
        }

        public void Add(string backstitch)
        {
            _lines.Add(backstitch);

        }
        public string Pop()
        {
            if (_lines.Count == 0)
            {
                return null;
            }
            var lastItem = _lines.Last();
            try
            {
                if (_lines.Count >= 1)
                {
                    _lines.RemoveAt(_lines.Count - 1);
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            return lastItem;
        }
        public int Size => _lines.Count;

        public string Top
        {
            get
            {
                if (_lines.Count == 0)
                {
                    return null;
                }
                var lastItem = _lines.Last();
                return lastItem;
            }
        }
    }
}
