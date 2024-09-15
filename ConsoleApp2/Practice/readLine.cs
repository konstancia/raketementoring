namespace readLine
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int numberOfAppendages = 4;
            int numberOfCountries = 195;

            Console.WriteLine("How many people?");
            int peopleCount = int.Parse(Console.ReadLine());

            int result = peopleCount * numberOfCountries;

            Console.WriteLine(result);

            //for (int i = 0; i < 195; i++)
        }
    }
}
    
            