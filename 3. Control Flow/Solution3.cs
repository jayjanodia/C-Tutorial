
namespace MyFirstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the image");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image");
            int height = Convert.ToInt32(Console.ReadLine());

            // Vertical would mean height > width, landscape would mean width > height
            string inclination = width > height ? "horizontal" : "vertical";
            Console.WriteLine("The image is {0}", inclination);
        }
    }
}