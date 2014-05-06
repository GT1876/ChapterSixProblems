using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers2.Cs
{
    class Program
    {
        public static int product(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            int q = 30, t = 39;
            int result = product(q, t);
            Console.WriteLine(result);
        }
    }
}
