// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            const string RECTANGLE = "square";
            const string CIRCLE = "circle";
            const string TRIANGLE = "triangle";
            const double PI = Double.Pi;


            Console.WriteLine("Please choose another shape for non-rectangular room: ex: (circle, triangle");
            string shape = (Console.ReadLine());

            Console.WriteLine("You choose the following shape: " + shape);
            double area;

            if (shape == CIRCLE)
            {
                Console.WriteLine("You have chosen circle shape");
                Console.WriteLine("Please enter radius: ");
                int circleRadius = Convert.ToInt32(Console.ReadLine());

                area = circleRadius * circleRadius * PI;
                
                Console.WriteLine("Your area calcuations are " + circleRadius);

                //radius^2*pi
            }

            // if case to handle the triangle shapes
            if (shape == TRIANGLE)
            {
                Console.WriteLine("You have chosen triangle shape");
                Console.WriteLine("Please enter area: ");
                int triangleArea = Convert.ToInt32(Console.ReadLine());

                area = triangleArea * triangleArea * PI;
                
                Console.WriteLine("Your area calcuations are " + triangleArea;

            }
            // if case to handle rectangle shapes

            if (shape == RECTANGLE)
            {
                Console.WriteLine("You have chosen rectangle ");
                Console.WriteLine("Please enter area: ");
                int rectangleArea = Convert.ToInt32(Console.ReadLine());

                area = rectangleArea * rectangleArea * PI;
                Console.WriteLine("Your area calcuations are " + rectangleArea);

            }

            else
            {
                Console.WriteLine("you have chosen unsupported shape");
            }
        }
    }
    }

//you should be calculating the total cost which is dependent to the area and includes labor


            // int  costPerHour = 86;




        