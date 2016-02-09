using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio radio = new Radio();
            radio.Volume = 10;
            radio.Freq = 300000;
            radio.OnOff = true;

            Console.WriteLine("Frequency is {0} and Volume is {1}", radio.Freq, radio.Volume);
        }
    }
}
