﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeBugSix01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Belt", "Tie", "Scarf", "Cufflinks" };
            double[] prices = { 29.00, 35.95, 18.50, 112.99 };
            Console.WriteLine("Items for sale:");
            for (int x = 0; x < items.Length; ++x)
                Console.WriteLine("{0,12} for {1,10}",
                    items[x], prices[x].ToString("C"));
        }
    }
}