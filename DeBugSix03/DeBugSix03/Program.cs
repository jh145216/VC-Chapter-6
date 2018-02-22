using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeBugSix03
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
            int x;
            string entryString;
            Console.Write("What book are you looking for? ");
            entryString = Console.ReadLine();
            x = Array.BinarySearch(books);
            if (x < 0)
                Console.WriteLine("{0} not found", entry);
            else
                Console.WriteLine("Yes, we carry {0}", entry);
        }
    }
}
