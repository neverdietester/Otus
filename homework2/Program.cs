using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfElements = 1000000;

            //List
            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            {
                var lList = new List<int>();
                for (int i = 1; i <= amountOfElements; i++)
                {
                    lList.Add(i);
                }
            }
            stopWatch.Stop();
    
            TimeSpan tsList = stopWatch.Elapsed;
            Console.WriteLine("RunTime List: " + tsList);

            //ArrayList
            stopWatch.Start();
            var arList = new ArrayList();
            for (int i = 1; i <= amountOfElements; i++)
            {
                arList.Add(i);
            }
            stopWatch.Stop();

            TimeSpan tsArray = stopWatch.Elapsed;
            Console.WriteLine("RunTime ArrayList: " + tsArray);

            //LinkedList
            stopWatch.Start();
            var linkL = new LinkedList<int>();
            for (int i = 1; i <= amountOfElements; i++)
            {
                linkL.AddLast(i);
            }
            stopWatch.Stop();

            TimeSpan tsLinked = stopWatch.Elapsed;
            Console.WriteLine("RunTime LinkedList: " + tsLinked);
        }
    }
 }
