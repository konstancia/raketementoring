﻿// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            const string RECTANGLE = "1";
            const string CIRCLE = "2";
            const string TRIANGLE = "3";
            const int SQUARE_FEET_PER_HOUR = 20;
            const int HOURLY_RATE = 86;
            const int TRIANGLE_AREA = 2;


            Console.WriteLine($"Please choose a room shape:  {RECTANGLE} for Rectangle , {CIRCLE} for Circle,  {TRIANGLE} for Triangle");
            string shape = (Console.ReadLine());


            if (shape != RECTANGLE & shape != TRIANGLE & shape != CIRCLE) 
            {
                Console.WriteLine("Invalid shape");
                return;
            }

                Console.WriteLine($"You choose the following shape: {shape}");
                double area =0;

                if (shape == CIRCLE)
                {
                    Console.WriteLine("You have chosen circle shape");
                    Console.WriteLine("Please enter radius: ");
                    int circleRadius = Convert.ToInt32(Console.ReadLine());

                    area = circleRadius * circleRadius * Math.PI;

                    //radius^2*pia
                }

                // if case to handle the triangle shapes


                if (shape == TRIANGLE)
                {
                    Console.WriteLine("You have chosen triangle shape");
                    Console.WriteLine("Please enter area width: ");
                    int triangleWidth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter area lenght: ");
                    int triangleLenght = Convert.ToInt32(Console.ReadLine());


                    area = triangleWidth * triangleLenght / TRIANGLE_AREA;

                }
                // if case to handle rectangle shapes

                if (shape == RECTANGLE)
                {
                    Console.WriteLine("You have chosen a rectangle ");
                    Console.WriteLine("Please enter area width: ");
                    int rectangleWidth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter area height: ");
                    int rectangleLenght = Convert.ToInt32(Console.ReadLine());


                    area = rectangleWidth * rectangleLenght;

                }
                
                //if (shape == RECTANGLE || shape == TRIANGLE || shape == CIRCLE)

                {
                    double cost;
                    double hours;
                    Console.WriteLine($"Your area calculations are {area}");
                    string totalHours = "hours to finish the job";
                    string totalCost = "dollars";
                    hours = area / SQUARE_FEET_PER_HOUR;
                    Console.WriteLine($"You will need: {+Math.Round(hours)}  {totalHours}");


                    cost = hours * HOURLY_RATE;
                    Console.WriteLine($"Your total project cost is: ${+Math.Round(cost)} {totalCost}");
                    Console.WriteLine(("Supported shape"));
                }
            }
        }
    }

            






        