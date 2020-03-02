﻿using System;

namespace Persons
{
    public class Calculator
    {
        public static bool ThrowErrors = true;
        
        static void Main(string[] args)
        {
            var result = Run(args);
            System.Console.WriteLine(result);
        }

        public static double Run(string[] args)
        {
            var a = args[1];
            var b = args[2];
            var firstNumber = Convert.ToDouble(a);
            var secondNumber = Convert.ToDouble(b);

            var action = args[0];

            if (action == "multiply")
            {
                return firstNumber * secondNumber;
            }
            else if (action == "divide")
            {
                return firstNumber / secondNumber;
            }
            else if (action == "subtract")
            {
                return firstNumber - secondNumber;
            }
            else if (action == "sum")
            {
                return firstNumber + secondNumber;
            }
            else
            {
                if (ThrowErrors == true)
                {
                    throw new ArgumentException("Invalid action <3");
                }
                else
                {
                    return 0;
                }
                
            }
        }
    }
}