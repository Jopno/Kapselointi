using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {

            Elevator elevator = new Elevator();
            while (1 == 1)
            {
                Console.WriteLine("Elevator is now on floor: " + elevator.Floor);
                Console.WriteLine("Give a new floor number > (1-5)");
                elevator.Floor = int.Parse(Console.ReadLine()); }
            
            } 
            
            
        }
    }

