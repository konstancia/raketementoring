// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                "Hello, user. You will be prompted to enter width, length, and the cost per 1 unit of flooring");

            Console.WriteLine("Please enter width");
            int myWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you entered width: " + myWidth);

            Console.WriteLine("Please enter length");
            int myLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered Lengh: " + myLength);
            
            int area = myWidth + myLength;
            Console.WriteLine("Total area for project " + area);
            
            Console.WriteLine("Now we're going to calculate the cost for your project");

            int cost = 5;
                
            int totalCost = (cost * area);
            Console.WriteLine("Your total project cost " + totalCost);
        }

    }
    
}