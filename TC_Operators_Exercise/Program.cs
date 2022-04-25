using System;

namespace TC_Operators_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void OperatorExercise(string opp, int a =17, int b =4)
            {
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
                        Console.WriteLine("Please choose one of the following: '+', '-', 'x', '*', '%', '/'");
                        break;
                }
            }

            Console.WriteLine("Please choose today's operation: +, -, *, /, %");
            string choice = Console.ReadLine();

            Console.WriteLine("Would you like to enter your own numbers? Please enter yes or no.");

            string custom = Console.ReadLine();

            if (custom == "yes")
            {
                Console.WriteLine("Please enter first integer.");
                int first = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter second integer.");
                int second = Convert.ToInt32(Console.ReadLine());

                OperatorExercise(choice, first, second);
            }
            else
            {
                OperatorExercise(choice);
            }

            

            
        }
    }
}
