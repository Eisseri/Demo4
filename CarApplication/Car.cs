using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //field variables, luokan sisäisiä ominaisuuksia
        private readonly int maxSpeed = 200;
        private readonly int minSpeed = 0;
        private readonly double maxHeight = 4.5;
        private int speed;
        private double height;

        //property variable, näkyy ulkopuolelle.
        //height property
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" Too small height - set to zero");
                    height = 0;
                }else if (value > maxHeight){
                    Console.WriteLine("Too high - set to max");
                    height = maxHeight;
                }
                else
                {
                    height = value; // ok!
                }
            }
        }
        public int Speed {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much Speed - set to max!");
                    speed = maxSpeed;
                }
            }
        }

    }
}
