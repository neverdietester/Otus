using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{9}' Size = {s.Size}");
            s.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Pop();

        }


        class Stack
        {
            private List<string> lines;

            public Stack(params string[] input)
            {
                lines = input.ToList();
                
            }

            public void Add(string backstitch)
            {
                lines.Add(backstitch);

            }

            public void Pop()
            {
                try
                {
                    if (lines.Count >= 1)
                    {
                        lines.RemoveAt(lines.Count - 1);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    throw new Exception ("Стек пустой");
                }
            }

            public int Size => lines.Count;

            public string Top
            {
                get
                {
                    if (lines.Count == 0)
                    {
                        return null;
                    }
                    var lastItem = lines.Last();
                    Console.WriteLine(lastItem);
                    return lastItem;
                }
            }
        }
    }
 }
