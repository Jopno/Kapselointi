using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.Name = "Sherman";
            tank.Type = "M4";
            tank.CrewCount = 4;
            tank.CrewCount = 0;

            Console.WriteLine(tank.Name);
            Console.WriteLine(tank.Type);
            Console.WriteLine("CrewCount is : " + tank.CrewCount);
            Console.WriteLine("Speed is: " + tank.Speed);
            Console.WriteLine("MaxSpeed is: " + tank.SpeedMax);

            tank.AccelerateTo(100);
            Console.WriteLine("Speed: " + tank.Speed);
            tank.AccelerateTo(105);
            tank.SlowTo(-3);
            tank.SlowTo(0);


            Console.ReadLine();



        }
    }
}
