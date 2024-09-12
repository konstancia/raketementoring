// See https://aka.ms/new-console-template for more information

namespace CostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorWidth = 20;
            int floorLength = 15;
            int floorCost = 50;
            int area = floorWidth + floorLength * floorCost;
            
        Console.WriteLine("Please enter width, length, and the cost per 1 unit of flooring.");
        
        int totalCost = (area);
        Console.WriteLine(totalCost);
    }

}
}