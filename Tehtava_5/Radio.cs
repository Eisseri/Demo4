using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_5
{
    class Radio
    {
        //field variables, luokan sisäisiä ominaisuuksia
        private readonly int maxFreq = 26000;
        private readonly int minFreq = 2000;
        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;

        private double freq;
        private double volume;
        public bool OnOff { get; set; }

        //property variable, näkyy ulkopuolelle.
        //height property
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Volume too low - set to zero");
                    volume = 0;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("Volume too high - set to max");
                    volume = maxVolume;
                }
                else
                {
                    volume = value; // ok!
                }
            }
        }


        public double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (value < 2000)
                {
                    Console.WriteLine(" Freq too low - set to 2000");
                    freq = 0;
                }
                else if (value > maxFreq)
                {
                    Console.WriteLine("Freq too high - set to max");
                    freq = maxFreq;
                }
                else
                {
                    freq = value; // ok!
                }
            }
        }
    }
}
