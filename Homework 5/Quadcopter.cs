using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework_5
{
    class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components;

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetInfo()
        {
            throw new NotImplementedException();
        }

        List<string> IRobot.GetComponents()
        {
            _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
            return _components;
        }

        string IRobot.GetInfo()
        {
            throw new NotImplementedException();
        }

        string IFlyingRobot.GetRobotType()
        { return default; }
    }
}
 