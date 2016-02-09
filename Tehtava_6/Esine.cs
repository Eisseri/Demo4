using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_6
{
    class Esine
    {
        class Esine : Object
        {
            public string Paino { get; set; }
            public string Koko { get; set; }
            public string Turha { get; set; }

            public Esine()
            {

            }


            public Esine(string Paino, string koko, string turha)
            {
                Paino = paino;
                Koko = koko;
                Turha = turha;
            }

            public void EsineMethod()
            {
                Console.WriteLine("Esine knows nothing....");
            }
            public override string ToString()
            {
                //Kirsi Kernel Piippukatu 2
                return Paino + " " + Koko + " " + Turha;
            }

        }
    }
}
