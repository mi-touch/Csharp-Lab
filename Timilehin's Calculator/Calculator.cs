using System;
using System.Collections.Generic;
using System.Text;

namespace Timilehin_s_Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // set default value of result to Not a number
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Enter correct math operation. ");
                    break;
            }
            return result;
        }
    }
}
