using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_7
{
    class Opiskelia : Ihminen
    {

        public int Money { get; set; }
        public int Drunk { get; set; }
        private void OpiskelijaMethod()
        {
            Console.WriteLine("Poor AF but still has money for party..");
        }

        // ylikirjoitetaan person luokassa oleva ToString metodi, jotta saadaan tulostuslauseeseen lisättyä dad luokan tiedot
        public override string ToString()
        {
            return base.ToString() + " Money: " + Money + " Drunk: " + Drunk;
        }
    }
}
