using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Hissi
    {
        private readonly double maxFloor = 5;
        private readonly double minFloor = 1;
    }

    public double Floor {
        get
        {

        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("Too small floor - set to 1.");
                floor = 1;
            }else if (value > 5)
            {
                Console.WriteLine("Floor too high - set to 5.");
            }

        }

    }
}
