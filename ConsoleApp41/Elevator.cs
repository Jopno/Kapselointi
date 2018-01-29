using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Elevator
    {
        private int floor = 1;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value >= 1 && value <= 5 && value != floor)
                {
                    floor = value;
                }
                else if (value == floor)
                    Console.WriteLine("You are already in that floor. ");
                else
                    Console.WriteLine("You can only select from 1 to 5. ");

            }
        }

    }
}
