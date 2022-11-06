using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assign6
    {
         
        public struct Book
        {
            public int iBookid, iBookType;
            public string strBooktitle;
            public double dprice;
        }
        public enum BookType
        {
            Magazine = 1,
            Novel = 2,
            Referencebook = 3,
            Micellaneous = 4
        }

        public static void Main()
        {
            Console.WriteLine("Enter the book details");
            Book B;
            B.iBookid = Convert.ToInt32(Console.ReadLine());
            B.strBooktitle = Console.ReadLine();
            B.iBookType = Convert.ToInt32(Console.ReadLine());
            B.dprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Details of book");
            Console.WriteLine("Id of the book {0}", B.iBookid);
            Console.WriteLine("Title of the Book {0}", B.strBooktitle);
            Console.WriteLine("Price of the book:{0}", B.dprice);
            string strBooktype = Enum.GetName(typeof(BookType), B.iBookType);
            Console.WriteLine("Book type {0}", strBooktype);
            Console.ReadKey();
        }
    }
}

