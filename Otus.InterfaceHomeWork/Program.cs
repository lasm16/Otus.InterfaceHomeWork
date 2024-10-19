using Otus.InterfaceHomeWork.Classes;

namespace Otus.InterfaceHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var quadcopter = new Quadcopter();
            var info = quadcopter.GetInfo();
            Console.WriteLine(info);
            var components = quadcopter.GetComponents();
            foreach (var component in components)
            {
                Console.WriteLine(component);
            }
            quadcopter.Charge();
        }
    }
}
