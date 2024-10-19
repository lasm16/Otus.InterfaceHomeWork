using Otus.InterfaceHomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.InterfaceHomeWork.Classes
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = ["rotor1", "rotor2", "rotor3", "rotor4"];
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents() => _components;

        public string GetInfo() => "Some Quadcopter specifications...";
    }
}
