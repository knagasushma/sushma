using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign5
    {
          
        public static void Main()
        {
            float PI = 3.141F;
            float R;
            Console.WriteLine("enter the radius");
            R = int.Parse(Console.ReadLine());
            float circum = 2 * PI * R * R;
            float area = PI * R * R;
            Console.WriteLine("Circumference = {0} and Area = {1}", circum, area);
            Console.ReadKey();
        }
    }
}

