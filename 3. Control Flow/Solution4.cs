
namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit");
            const int speedLimit = 75;
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demerit = (speed - speedLimit) / 5;

                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Speeding ticket");
                }
            }
        }
    }
}