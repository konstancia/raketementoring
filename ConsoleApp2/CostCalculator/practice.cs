// See https://aka.ms/new-console-template for more information

namespace CostCalculatorFinal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //string myText = console.ReadLine();

                //Console.WriteLine ("you entered:" + myText);

            Console.WriteLine("Hello, user. You will be prompted to enter width, length, and the cost per 1 unit of flooring");

                Console.WriteLine("Please enter width");
                string myWidth = Convert.ToInt32(Console.ReadLine);

                   Console.WriteLine ("you entered width:" + myWidth);

                 Console.WriteLine ("Please enter length");
                 string myLength = Convert.ToInt32(Console.ReadLine);

                    Console.WriteLine ("You entered Lengh" + myLength);


                 int area = myWidth + myLength;
                 Console.WriteLine("Total area for project" + area);

                


                //int numberOne = Convert.ToInt32 (Console.ReadLine);
                //int numberTwo = 20;

                //int result = numberOne * numberTwo;

                //Console.WriteLine(result);



            /** Console.WriteLine("Please enter width of flooring.");
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
            **/
        }

    }

}
