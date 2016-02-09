using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_66
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirja kirja = new Kirja("Matematic 1", "Top of the bookcase", "No", "No idea");
            Console.WriteLine("Kirja = " + kirja.ToString());

            Dvd dvd = new Dvd("Titanic", "404 not found", "Yes", "James Cameron");
            Console.WriteLine("Dvd = " + dvd.ToString());
        }
    }
}
