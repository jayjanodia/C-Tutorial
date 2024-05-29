using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string firstName = "Mosh";
            String firstNameClass = "Mosh"; // Does the same thing as above line, you just need to import System namespace
            string lastName = "Hamedani";

            string name1 = string.Format("{0} {1}", firstName, lastName);
            string name2 = $"{firstName} {lastName}";
            Console.WriteLine(name1); Console.WriteLine(name2);
            Console.WriteLine("{0} {1}", firstName, lastName);

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            string path = "c:\\projects\\project1\\folder1";
            string seperatedLine = "Hello\nWorld";
            Console.WriteLine(path);
            Console.WriteLine(seperatedLine);

            // Can also be written as
            string verbPath = @"c:\projects\project1\folder1";
            string verbSeperatedLine = @"Hello
World";
            Console.WriteLine(verbPath);
            Console.WriteLine(verbSeperatedLine);
        }
    }
}

