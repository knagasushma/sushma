using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign2
    {
        public static void Main()
        {


            Console.WriteLine("Average marks of 5 students");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int[] average = { a, b, c, d, e };
            Console.WriteLine("Maximum marks obtained are {0} ", average.Max());
            Console.ReadKey();
        }
    }
}
