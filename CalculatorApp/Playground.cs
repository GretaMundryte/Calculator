using System;
using CalculatorApp;

namespace CalculatorApp
{
    public class Playground
    {
        public static void Test()
        {
            double result = Calculator.StaticRun("+", 5, 4);
            Console.WriteLine(result);
        }
    }
}