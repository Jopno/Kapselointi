using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Amplifier amp = new Amplifier();
            while (true)
            {
                Console.Write("Give a new volume value (0-100) > ");
                bool result = Int32.TryParse(Console.ReadLine(), out number);
                if (result)
                    amp.Volume = number;
                else
                {
                    Console.WriteLine("Not a number!");
                    continue;
                }
            }
        }
    }
}