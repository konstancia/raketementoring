// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            const string rectangle = "square";
            const string circle = "circle";


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

            Console.WriteLine("You entered Length: " + Length);

            int areaSquare = Width + Length;
            Console.WriteLine("Total area for project: " + areaSquare);

            Console.WriteLine("Now we're going to calculate the cost for your project");

            int costPerHourSquare = 86;

            int totalCost = (costPerHourSquare * areaSquare);
            Console.WriteLine("Your total project cost: " + totalCost);

            if (totalCost < 500)
            {
                Console.WriteLine(" Good Deal");
            }
            else
            {
                Console.WriteLine(" Hope you have a coupon");
            }


            Console.WriteLine("Please choose another shape for non-rectangular room: ex: (circle, triangle");
            string roomShape = (Console.ReadLine());

            Console.WriteLine("You choose the following shape: " + roomShape);

            Console.WriteLine("Please enter height of the circle: ");
            int circleLenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter width of the circle: ");
            int circleWidth = Convert.ToInt32(Console.ReadLine());

            int areaCircle = circleLenght * circleWidth;

            Console.WriteLine("Total area for project: " + areaCircle);

            Console.WriteLine("Now we're going to calculate the cost for your new project");

            int  costPerHourCircle = 86;

            double totalCostCircle = (costPerHourCircle * areaCircle);
            Console.WriteLine("Your total project cost: " + totalCostCircle);
            
            if (totalCostCircle < 10000)
            {
                Console.WriteLine(" Good Deal");
            }
            else
            {
                Console.WriteLine(" Hope you have a coupon");
            }
    }

    }
    
}