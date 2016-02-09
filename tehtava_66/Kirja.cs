using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_66
{
    class Kirja : juttui
    {
        public string Kirjoittaja { get; set; }

        public Kirja()
        {
        }

        public Kirja(string name, string location, string usefull, string kirjoittaja)
            : base(name, location, broken)
        {
            Kirjoittaja = kirjoittaja;

        }



        public override string ToString()
        {
            return base.ToString() + " Writer: " + Kirjoittaja;
        }
    }
}
