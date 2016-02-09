using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_66
{
    class Kirja : juttui
    {
        public string Ohjaaja { get; set; }

        public Dvd()
        {
        }

        public Dvd(string name, string location, string usefull, string ohjaaja)
            : base(name, location, broken)
        {
            Ohjaaja = ohjaaja;

        }



        public override string ToString()
        {
            return base.ToString() + " Ohjaaja: " + Ohjaaja;
        }
    }
}
