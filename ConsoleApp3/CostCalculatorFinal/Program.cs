// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose another shape for non-rectangular room: ex: (circle, triangle");
            string Shape = (Console.ReadLine());
            
            Console.WriteLine("You choose the following shape: " + Shape);

            Console.WriteLine(
                "Hello, user. You will be prompted to enter width, length, and the cost per 1 unit of flooring for your room shape");

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
            
            Console.WriteLine("Please choose another shape for non-rectangular room: ex: (circle, triangle");
            string roomShape = (Console.ReadLine());
            
            Console.WriteLine("You choose the following shape: " + roomShape);
            
            Console.WriteLine("Please enter height of the circle: ");
            int circleLenght = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please enter widgth of the circle: ");
            int circleWidth = Convert.ToInt32(Console.ReadLine());
            
            int areaCircle = circleLenght * circleWidth;
            
            Console.WriteLine("Total area for project: " + areaCircle);
            
            Console.WriteLine("Now we're going to calculate the cost for your new project");

            double costCircle = 8;
                
            double totalCostCircle = (cost * area);
            Console.WriteLine("Your total project cost: " + totalCostCircle);
            
            


        }

    }
    
}