// See https://aka.ms/new-console-template for more information
namespace Day1
{
    public class PlayingWithConsoleApp
    {
        static void Main(string[] args)
        {
            string color;
            string astrologySign;
            int streetAddressNumber;

            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();

            Console.WriteLine("What is your astrologySign?");
            astrologySign = Console.ReadLine();

            Console.WriteLine("What is your street address number?");
            bool test3 = Int32.TryParse(Console.ReadLine(), out streetAddressNumber);
            if (test3 == false)
            {
                Console.WriteLine("Invalid street address number");
            }
            else
            {
                Console.WriteLine($"Your hacker name is {color}{astrologySign}{streetAddressNumber}.");
            }
        }
    }
}
