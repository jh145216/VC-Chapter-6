using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeBugSix04
{
    class Program
    {
        static void Main(string[] args)
      {
      const int QUIT = 999;
      int[] numbers = new int[5];
      int x = 0;
      int num;
      double average;
      double total = 0;
      string inString;
      Console.Write("Please enter a number or " +
         QUIT + " to quit...");
      inString = Console.ReadLine();
      num = Convert.ToInt32(inString);
      while((0 < numbers.Length) && num != QUIT)
      {
 	  numbers[x] = num;
          total += numbers[x];
          ++x;
          Console.Write("Please enter a number or " +
             QUIT + " to quit...");
          inString = Console.ReadLine();
          num = Convert.ToInt32(inString);
      }
      Console.WriteLine("The numbers are:");
      for(int y = 0; y < x; ++y)
          Console.Write("{0,6}", numbers[y]);
      average = total / x;
      Console.WriteLine();
      Console.WriteLine("The average is {0}", average);
      } 
    }
}