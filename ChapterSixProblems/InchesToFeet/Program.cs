﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        public static void totalFeet(int inches)
        {
            int feet,inch;

            feet = inches / 12;
            
            inch = inches % 12;

            Console.WriteLine("{0} feet and {1} inches", feet, inch); 
        }

        static void Main(string[] args)
        {
            int inches = 67;
            totalFeet(inches);
        }
    }
}
