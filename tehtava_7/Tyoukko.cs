using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_7
{
    class Tyoukko : Ihminen
    {

        public int Money { get; set; }
        public int Drunk { get; set; }
        private void TyoukkoMethod()
        {
            Console.WriteLine("Steady income but no time to party paadip.");
        }

        // ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä dad luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Money: " + Money + " Drunk: " + Drunk;
        }
    }
}
