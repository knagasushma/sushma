using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];
            Console.WriteLine("enter array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            string[] Name = new string[5];
            Console.WriteLine("enter strings");
            for (int r = 0; r < Name.Length; r++)
            {
                Name[r] = Console.ReadLine();
            }
            Console.WriteLine("Array elements before sorting");
            Console.WriteLine("Elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("String Elements before sorting");
            Console.WriteLine("Strings are:");
            for (int r = 0; r < Name.Length; r++)
            {
                Console.WriteLine(Name[r]);
            }
            Array.Sort(arr);
            Console.WriteLine("After sorting element in ascending order:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Sort(Name);
            Console.WriteLine("After sorting String array elements");
            foreach (string r in Name)
            {
                Console.WriteLine(r);
            }
            Array.Reverse(arr);
            Console.WriteLine("After reversing the elements:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(Name);
            Console.WriteLine("After arranging into descending order");
            foreach (String r in Name)
            {
                Console.WriteLine(r, true);
            }
            Array.Copy(Name, 0, Name, 0, Name.Length);
            Console.WriteLine("After copying");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            foreach (string r in Name)
            {
                Console.WriteLine(r);
            }
            Array.Clear(arr, 0, 5);
            Console.WriteLine("After clearing");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Clear(Name, 0, 5);
            Console.WriteLine("After Clearing string array");
            foreach (string r in Name)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
