using System;

namespace TC_Operators_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void OperatorExercise()
            {
                int a = 17;
                int b = 4;
                Console.WriteLine("Please choose today's operation: +, -, *, /, %");
                string opp = Console.ReadLine();

                Console.WriteLine("Would you like to enter your own numbers? Please enter yes or no.");

                string custom = Console.ReadLine();

                if (custom == "yes")
                {
                    Console.WriteLine("Please enter first integer.");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter second integer.");
                    b = Convert.ToInt32(Console.ReadLine());
                }

                switch (opp)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} is {a+b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} is {a-b}");
                        break;
                    case "x":
                    case "*":
                        Console.WriteLine($"{a} x {b} is {a*b}");
                        break;
                    case "/":
                        Console.WriteLine($"{a}/{b} is {a/b} remainder {a%b}");
                        break;
                    case "%":
                        Console.WriteLine($"{a} % {b} is {a % b}");
                        break;
                    default:
                        Console.WriteLine("Oh no, something went wrong! Try again with a valid operator.");
                        break;
                }
            }

            
            bool finished = false;

            while (!finished)
            {
                Console.WriteLine("Which program would you like to run?");
                string run = Console.ReadLine();
                switch (run)
                {
                    case "Operators":
                        OperatorExercise();
                        break;
                    case "Area":
                        break;
                    case "exit":
                    case "no":
                        finished = true;
                        break;
                    default:
                        Console.WriteLine("I'm not sure I understand. Please choose 'Operators' or 'Area', or simply choose 'exit'");
                        break;
                }
            }

            Console.WriteLine("Thanks so much for stopping by!");

            
        }
    }
}
