﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            // Calculation using compound assignment 
            number += 10; // same as number = number + 10;

            // Result output
            Console.WriteLine("Number ten more greater is: " + number);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
