// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                "Hello, user. You will be prompted to enter width, length, and the cost per 1 unit of flooring");

            Console.WriteLine("Please enter width: ");
            int Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you entered width: " + Width);

            Console.WriteLine("Please enter length: ");
            int Length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered Lengh: " + Length);
            
            int area = Width + Length;
            Console.WriteLine("Total area for project: " + area);
            
            Console.WriteLine("Now we're going to calculate the cost for your project");

            double cost = 5;
                
            double totalCost = (cost * area);
            Console.WriteLine("Your total project cost: " + totalCost);
        }

    }
    
}