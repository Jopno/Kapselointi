using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Amplifier
    {

        private int volume;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value  <= 100 && value >= 0)
                {
                    volume = value;
                    Console.WriteLine("Amplifier volume is set to : {0} " , volume);
                }
                else if  (value > 100)
                {
                    Console.WriteLine("Volume is too loud - Volume is set to maximum : 100");
                }

                else if (value < 0)
                {
                    Console.WriteLine("Volume is too low - Volume is set to minimum : 0");
                }
            }
        }
    }
}
