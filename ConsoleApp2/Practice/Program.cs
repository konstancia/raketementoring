// See https://aka.ms/new-console-template for more information

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = "Hello";
            string pamela = "what";
            string tanga = "oh!";
            int aNumber = 5;
            
            Console.WriteLine(aString + "this is me" + pamela + "is your name" + tanga);
            
            Console.WriteLine("{0} this is {1} is your name? {2}", aString, pamela, tanga);
            
            Console.WriteLine($"{aString} this is me {pamela} is your name?  + {tanga}");
            
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