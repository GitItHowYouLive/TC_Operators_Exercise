using System;

namespace TC_Operators_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool finished = false;

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
                        Console.WriteLine($"{a} + {b} is {a+b} \n\n");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} is {a-b} \n\n");
                        break;
                    case "x":
                    case "*":
                        Console.WriteLine($"{a} x {b} is {a*b} \n\n");
                        break;
                    case "/":
                        Console.WriteLine($"{a}/{b} is {a/b} remainder {a%b} \n\n");
                        break;
                    case "%":
                        Console.WriteLine($"{a} % {b} is {a % b} \n\n");
                        break;
                    default:
                        Console.WriteLine("Oh no, something went wrong! Try again with a valid operator. \n\n");
                        break;
                }

            }

            static void Area()
            {
                Console.WriteLine("What is the radius of your circle?");
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"The area of a circle with radius of {radius} is {Math.PI * Math.Pow(radius, 2)} \n\n");
            }

            

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
                        Area();
                        break;
                    case "exit":
                    case "no":
                    case "none":
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
