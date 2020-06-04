using System;

namespace Timilehin_s_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "", num2 = "";
            double result = 0;
            Console.WriteLine("Hello! Welcome...");
            bool Tocontinue = true;
            // The Beginning of the program
            while (Tocontinue) 
            {
                //The first input number from the user
                Console.WriteLine("Enter the first number");
                num1 = Console.ReadLine();
                //Checking for any type of error on input num1
                double cleanNum1 = 0;
                while (!double.TryParse(num1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    num1 = Console.ReadLine();
                }
                //The second input number from the user
                Console.WriteLine("Enter the second number");
                num2 = Console.ReadLine();
                //Checking for any type of error on input num2
                double cleanNum2 = 0;
                while (!double.TryParse(num2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    num2 = Console.ReadLine();
                }

                Console.WriteLine("Please enter the operation you will like to do.");
                Console.WriteLine($"//***********Choose an option from the following list************//");
                Console.WriteLine("\ta - Add,");
                Console.WriteLine("\ts - Subtract,");
                Console.WriteLine("\td - Divide,");
                Console.WriteLine("\tm - Multiply,");
                Console.WriteLine("Your Option?");
                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Will you like to perform another operation? Enter yes to continue or no to terminate.");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    Tocontinue = true;
                }
                else
                {
                    Tocontinue = false;
                }
                
            }
            
            Console.WriteLine(Environment.NewLine);
            return;
        }
    }
}
