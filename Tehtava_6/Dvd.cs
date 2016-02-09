using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_6
{
    class Dvd : Esine
    {
        public string Elokuva { get; set; }


        public Dvd()
        {
        }

        //konstruktori joka ottaa vastaan etunimi sukunimi ja osoite
        public Dvd(string paino, string koko, string turha, string elokuva)
            : base(paino, koko, turha)
        {
            Elokuva = elokuva;
        }


        public void ElokuvaMethod()
        {
            Console.WriteLine("Elokuva very good");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Elokuva;
        }


    }
}
