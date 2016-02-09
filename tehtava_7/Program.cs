using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Name = "";
            opiskelija.Age = 20;
            opiskelija.Adress = "Asuntola 2 ";


            Tyoukko tyoukko = new Tyoukko();
            tyoukko.Name = "";
            tyoukko.Age = 40;
            tyoukko.Adress = "Pankin maksama.";

            Console.WriteLine = ("Opiskelija: " + opiskelija.ToString());
        }
    }
}
