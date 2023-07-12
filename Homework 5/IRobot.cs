using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    interface IRobot
    {
        string GetInfo();
        List<string> GetComponents();
        void GetRobotType() 
        { 
            Console.WriteLine("I am a simple robot");
        }
    }
}