using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        public static void totalYards(int inches)
        {
            int feet, inch, yard;

            feet = inches / 12;

            yard = feet / 3;

            inch = inches % 12;

            Console.WriteLine("{0} yards {1} feet and {2} inches", yard, feet, inch);
        }

        static void Main(string[] args)
        {
            int inches = 67;
            totalYards(inches);
        }
    }
}
