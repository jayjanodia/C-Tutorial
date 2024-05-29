// See https://aka.ms/new-console-template for more information
namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hour = 15;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            // Conditional Operator
            bool isGoldCustomer = true;

            float price;

            if (isGoldCustomer) { price = 19.95f; }
            else price = 29.95f;

            // Can also be written as
            float conditionalPrice = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(conditionalPrice);


            // Switch case with enum Season
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;
                case Season.Winter:
                case Season.Spring:
                    Console.WriteLine("We have got a promotion!");
                    break;
                default:
                    Console.WriteLine("Invalid season entered!");
                    break;
            }
        }
    }
}