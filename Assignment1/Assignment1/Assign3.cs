using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign3
    {
        public static void Main()
        {
            int[] num = new int[5];
            Console.WriteLine("enter elements:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int addition = Sumof(num);
            Console.WriteLine("The sum of the elements in the array ={0}", addition);
            Console.ReadKey();

        }
        public static int Sumof(params int[] num)
        {
            int add = 0;
            for (int i = 0; i < num.Length; i++)
            {
                add = add + num[i];
            }
            return add;

        }
    }
}
