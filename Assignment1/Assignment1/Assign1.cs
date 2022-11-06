using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign1
    {
        public static void Main()
        
            {
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press 1 - Addition , 2 - Subtraction ,3 - Multiplication ,4 -Division");
                int action = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int input_1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int input_2 = int.Parse(Console.ReadLine());
                int Result = 0;
                switch (action)
                {
                    case 1:
                        Result = input_1 + input_2;
                        break;

                    case 2:
                        Result = input_1 - input_2;
                        break;
                    case 3:
                        Result = input_1 * input_2;
                        break;
                    case 4:
                        Result = input_1 / input_2;
                        break;

                    default:
                        Console.WriteLine("Your action is invalid");
                        break;
                }
                Console.WriteLine("The Result is {0}", Result);
                Console.ReadKey();

            
        }
    }
}
