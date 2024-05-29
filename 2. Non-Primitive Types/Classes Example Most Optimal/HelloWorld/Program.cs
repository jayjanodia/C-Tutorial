using System;
using HelloWorld.Math;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Person jay = new Person(name);
            jay.Introduce();

            Console.WriteLine("\nAddition of 2 numbers (integers): ");
            Console.Write("Enter Number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = Calculator.Add(a, b);
            Console.WriteLine("The final result is: {0}", result);
        }
    }
}

