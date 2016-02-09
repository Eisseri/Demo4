using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_66
{
    class juttui
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Usefull { get; set; }

        public tavarat()
        {
        }

        public tavarat(string name, string location, string usefull) // alustetaan tavarat olion ominaisuudet
        {
            Name = name;
            Location = location;
            Usefull = usefull;
        }


        public override string ToString() // palauttaa merkkijonon
        {
            return " Name: " + Name + " Location: " + Location + " Usefull: " + usefull;
        }
    }

}
