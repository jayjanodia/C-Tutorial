using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 10, b = 3;
        Console.WriteLine(a + b);
        Console.WriteLine((float)a / b);
        var c = 3;
        Console.WriteLine(a + b * c);
        Console.WriteLine(a > b); // Should be True
        Console.WriteLine(a == b); // Should be False
        Console.WriteLine(c < b && c <= a); // False and True =  False

    }
}
