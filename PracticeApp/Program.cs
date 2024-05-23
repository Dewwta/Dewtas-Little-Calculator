using System;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true) 
            {
                double x;
                double y;
                double result;
                string input;

                Console.WriteLine("Please type an operator: '*' '/' '+' '-' (or type 'exit' to quit)");
                input = Console.ReadLine().Trim();

                if (input.ToLower() == "exit") 
                    break;

                if (!(input == "*" || input == "/" || input == "+" || input == "-"))
                {
                    Console.WriteLine("Not a valid operator");
                    continue; 
                }

                Console.WriteLine("Enter number: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid input for number 1.");
                    continue; 
                }

                Console.WriteLine("Enter number 2: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid input for number 2.");
                    continue; 
                }

                switch (input)
                {
                    case "*":
                        result = Multiply(x, y);
                        break;
                    case "/":
                        result = Division(x, y);
                        break;
                    case "+":
                        result = Addition(x, y);
                        break;
                    case "-":
                        result = Subtraction(x, y);
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue; 
                }

                Console.WriteLine("Result: " + result);
            }
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Division(double x, double y)
        {
            return x / y;
        }
        static double Addition(double x, double y)
        {
            return x + y;
        }
        static double Subtraction(double x, double y)
        {
            return x - y;
        }
    }
}
