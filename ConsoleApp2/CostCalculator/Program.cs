// See https://aka.ms/new-console-template for more information

namespace CostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOne = 15;
            int numberTwo = 20;
            int numberOne = Convert.ToInt32(Console.ReadLine());
            

            int result = numberOne * numberTwo;
            Console.WriteLine(result);

            string myText = Console.ReadLine();
            
            Console.WriteLine("You entered: " + myText);
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, Fred!");
        }

    }
}