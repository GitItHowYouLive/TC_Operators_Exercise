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
                Console.WriteLine("What shape would you like to calculate the area of?");
                Console.WriteLine("You can choose a circle, rectangle, square, triangle, parallelogram, rhombus, or even an ellipse!");
                string shape = Console.ReadLine();

                switch (shape)
                {
                    case "circle":
                        Console.WriteLine("What is the radius of your circle?");
                        var radius = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a circle with radius of {radius} is {Math.PI * Math.Pow(radius, 2)}. \n\n");
                        break;
                    case "triangle":
                        Console.WriteLine("What is the length of the base of your triangle?");
                        var bass = double.Parse(Console.ReadLine());
                        Console.WriteLine("What is the triangle's height?");
                        var height = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a triangle with a base of {bass} and height of {height} is {0.5 * bass * height}. \n\n");
                        break;
                    case "square":
                        Console.WriteLine("What is the length of the side of your square?");
                        var side = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a square with sides of {side} is {Math.Pow(side, 2)}. \n\n");
                        break;
                    case "rectangle":
                        Console.WriteLine("What is the length of the long side of your rectangle?");
                        var big = double.Parse(Console.ReadLine());
                        Console.WriteLine("What is the length of the shorter side?");
                        var little = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a rectangle with a sides of {big} and {little} is {big * little}. \n\n");
                        break;
                    case "parallelogram":
                        Console.WriteLine("What is the length of the base of your parallelogram?");
                        var bottom = double.Parse(Console.ReadLine());
                        Console.WriteLine("What is the parallelogram's height?");
                        var vert = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a parallelogram with a base of {bottom} and height of {vert} is {bottom * vert}. \n\n");
                        break;
                    case "rhombus":
                        Console.WriteLine("What is the length of one diagonal of your rhombus?");
                        var diag1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("What is the length of the other diagonal?");
                        var diag2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of a rhombus with diagonals of {diag1} and {diag2} is {0.5 * diag1 * diag2}. \n\n");
                        break;
                    case "ellipse":
                        Console.WriteLine("What is the length of the major(larger) axis?");
                        var major = double.Parse(Console.ReadLine());
                        Console.WriteLine("What is the length of the minor(smaller) axis?");
                        var minor = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of an ellipse with a major axis of {major} and a minor axis of {minor} is {Math.PI * major * minor}. \n\n");
                        break;
                    default:
                        Console.WriteLine("There were lots of options, and you only had one job. Please try again with a valid shape option");
                        break;
                }
                
                
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
