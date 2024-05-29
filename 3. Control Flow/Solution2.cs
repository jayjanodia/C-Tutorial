
namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            float number2 = float.Parse(Console.ReadLine());
            float maximum = number1 < number2 ? number2 : number1;
            Console.WriteLine($"The maximum value between {number1} and {number2} is {maximum}");
        }
    }
}