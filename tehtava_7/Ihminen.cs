using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_7
{
    class Ihminen
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void PersonMethod()
        {
            Console.WriteLine("paadipapiidipaadi..paadipapiidipaadi..");

        }
        public void PersonMethod2()
        {
            Console.WriteLine("Still going paadipapidipaadi.");
        }
        public override string ToString() // palauttaa merkkijonon
        {
            return " Name: " + Name + " Age: " + Age + " Address: " + Address;
        }
    }
}
