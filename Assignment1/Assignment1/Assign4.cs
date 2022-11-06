using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign4
    {
        public static void Main()

        {
            int a;
            int b;
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping a ={0} and b ={1}", a, b);
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping a ={0} and b ={1}", a, b);
            Console.ReadKey();
        }
    }
}
