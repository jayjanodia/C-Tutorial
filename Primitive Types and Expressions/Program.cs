using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        byte number = 10;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'a';
        string firstName = "Mosh";
        bool isWorking = true;
        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);

        // Can also define variables using var
        var numberVar = 10;
        var totalPriceVar = 20.95f;
        var firstNameVar = "Mosh";
        var characterVar = 'a';
        var isWorkingVar = true;

        // can call format string as follows
        // Get the range you can store in a byte
        Console.WriteLine("Byte Range: {0}-{1}", byte.MinValue, byte.MaxValue);
        // Alternative
        Console.WriteLine($"Float Range: {float.MinValue}-{float.MaxValue}");

        const float Pi = 3.14f;
        const double PiDouble = 3.14d;
    }
}
