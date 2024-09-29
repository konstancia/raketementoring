// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            const string RECTANGLE = "1";
            const string CIRCLE = "2";
            const string TRIANGLE = "3";
            const double PI = Double.Pi;
            const int SQUARE_FEET_PER_HOUR = 20;
            const int HOURLY_RATE = 86;
            

            Console.WriteLine($"Please choose a room shape:  {RECTANGLE} , {CIRCLE} ,  {TRIANGLE} " );
            string shape = (Console.ReadLine());

            Console.WriteLine("You choose the following shape: " + shape);
            double area;
            double cost;
            double hour;
           
            

            if (shape == CIRCLE)
            {
                Console.WriteLine("You have chosen circle shape");
                Console.WriteLine("Please enter radius: ");
                int circleRadius = Convert.ToInt32(Console.ReadLine());

                area = circleRadius * circleRadius * PI;
                Console.WriteLine("Your area calcuations are " + area);

                //hour = area / SQUARE_FEET_PER_HOUR;
                Console.WriteLine("You will need " + hour + " " + "hours to finish the job");

                //cost = hour * HOURLY_RATE;
                Console.WriteLine("Your total project cost is: " + cost);

                //radius^2*pi
            }

            // if case to handle the triangle shapes
            if (shape == TRIANGLE)
            {
                Console.WriteLine("You have chosen triangle shape");
                Console.WriteLine("Please enter area width: ");
                int triangleAreaWidth = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Please enter area height: ");
                int triangleAreaHeight = Convert.ToInt32(Console.ReadLine());


                area = triangleAreaWidth * triangleAreaHeight * PI;
                Console.WriteLine("Your area calcuations are " + area);
                
                //hour = area / SQUARE_FEET_PER_HOUR;
                Console.WriteLine("You will need " + hour + " " + "hours to finish the job");

                //cost = hour * HOURLY_RATE;
                Console.WriteLine("Your total project cost is: " + cost);
                
                
            }
            // if case to handle rectangle shapes

            if (shape == RECTANGLE)
            {
                Console.WriteLine("You have chosen a rectangle ");
                Console.WriteLine("Please enter area width: ");
                int rectangleAreaWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter area height: ");
                int rectangleAreaHeight = Convert.ToInt32(Console.ReadLine());
                
                
                area = rectangleAreaWidth * rectangleAreaHeight * PI;
                Console.WriteLine("Your area calculations are " + area);
                
                //hour = area / SQUARE_FEET_PER_HOUR;
                Console.WriteLine("You will need " + hour + " " + "hours to finish the job");

                //cost = hour * HOURLY_RATE;
                Console.WriteLine("Your total project cost is: " + cost);

                
            }
            
            
            if (shape == RECTANGLE || shape == TRIANGLE || shape == CIRCLE)
                Console.WriteLine("Valid shape");

            else
            {
                Console.WriteLine("you have chosen unsupported shape");
            }
            
            hour = area / SQUARE_FEET_PER_HOUR;
            cost = hour * HOURLY_RATE;
        }
    }
    }






        