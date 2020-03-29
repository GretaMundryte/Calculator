using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public bool ThrowErrors = true;
        
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Write operation: *, /, +, -");
                var action = Console.ReadLine();
                
                Console.WriteLine("Write first number");
                var firstNumber = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Write second number");
                var secondNumber = Convert.ToDouble(Console.ReadLine());
                
                var result = new Calculator().Run(action, firstNumber, secondNumber);
                Console.WriteLine(result);
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot be divided by 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
        }

        public double Run(string action, double firstNumber, double secondNumber)
        {
            if (action == "*")
            {
                return firstNumber * secondNumber;
            }
            else if (action == "/")
            {
                if (secondNumber == 0)
                {
                    throw new ArgumentException("Number cannot be divided by 0");
                }
                return firstNumber / secondNumber;
            }
            else if (action == "-")
            {
                return firstNumber - secondNumber;
            }
            else if (action == "+")
            {
                return firstNumber + secondNumber;
            }
            else
            {
                if (ThrowErrors)
                {
                    throw new ArgumentException("Invalid action: " + action);
                }
                else
                {
                    return 0;
                }
                
            }
        }
    }
}
