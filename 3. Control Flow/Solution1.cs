
namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a number between 1-10");
                int input = Convert.ToInt32(Console.ReadLine());
                // int input = int.Parse(Console.ReadLine());
                if (input >= 1 && input <= 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }
}