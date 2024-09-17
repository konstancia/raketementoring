// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;


            Console.WriteLine(a + b);

            double c = 0.3;
            double d = 0.6;

            Console.WriteLine(c + d);

            bool weAreHungry = true;

            if (weAreHungry)
            {

                Console.WriteLine("lets go eat");
            }
            else
            {
                {
                    Console.WriteLine("Lets stay home");
                }
            }

            int aNumber = 15;
            int anotherNumber = 16;


            if (aNumber == anotherNumber) ;
            {
                Console.WriteLine("It's the same");
            }
            if (aNumber < anotherNumber)
            {
                Console.WriteLine("It's smaller");
            }

            //else
            if (aNumber > anotherNumber)
            {
                Console.WriteLine("its bigger");
            }



//if (true)
                //Console.WriteLine("That works as well"); 
            //{
                //something
            //}
            
            /**
            if (aNumber == anotherNumber)
                Console.WriteLine(("it's the same"));
            else if (aNumber < anotherNumber)
                Console.WriteLine(("its smaller"));
            else if (aNumber > anotherNumber)
                Console.WriteLine("Its better");
            **/
        
    

    
