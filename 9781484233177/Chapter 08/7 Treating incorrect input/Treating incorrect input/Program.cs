﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treating_incorrect_input
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input of 1. number
                Console.Write("Enter 1. number: ");
                string input1 = Console.ReadLine();
                int number1 = Convert.ToInt32(input1);

                // Input of 2. number
                Console.Write("Enter 2. number: ");
                string input2 = Console.ReadLine();
                int number2 = Convert.ToInt32(input2);

                // Calculating 
                int result = number1 + number2;

                // Result output
                Console.WriteLine("Sum of entered numbers is: " + result);
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input - cannot calculate");
            }

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
