using System;
using System.Numerics;

namespace MyFirstProgram
{
    class Program
    {
        public enum AppState
        {
            OnOpen,
            Multiplication,
            Division,
            Addition,
            Subtraction
        }

        public AppState currentState;

        static void Main(string[] args)
        {
            double x;
            double y;
            double result;
            string input;

            Console.WriteLine("Please type an operator: '*' '/' '+' '-'");
            input = Console.ReadLine();
            if (!(input is "*" or "/" or "+" or "-"))
            {
                Console.WriteLine("Not a valid operator");
            }
            else
            {
                Console.WriteLine("Enter number: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid input for number 1.");
                    return; // Exit the program if input is invalid
                }

                Console.WriteLine("Enter number 2: ");
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid input for number 2.");
                    return; // Exit the program if input is invalid
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
                        return; // Exit the program if operator is invalid
                }

                Console.WriteLine(result);
            }

            Console.ReadKey();
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