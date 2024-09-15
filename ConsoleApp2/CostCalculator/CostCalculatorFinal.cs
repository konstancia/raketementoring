// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter width of flooring.");
            int floorWidth = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter length flooring.");
            int floorLength = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter cost per 1 unit of flooring.");
            int floorCost = int.Parse(Console.ReadLine());
            
            //int floorWidth = 20;
            //int floorLength = 15;
            //int floorCost = 50;
            int area = floorWidth * floorLength ;
        
            int totalCost = (area);
            Console.WriteLine(totalCost);
        }

    }
}